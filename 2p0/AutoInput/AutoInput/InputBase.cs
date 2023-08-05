using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace CustAutoInput
{
    class InputBase
    {
        /// <summary>
        /// get Class name with window handle 'hWnd'
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static string getWndClass(IntPtr hWnd)
        {
            int length = 256;
            StringBuilder sb = new StringBuilder(length + 1);
            Win32.GetClassName(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }

        /// <summary>
        /// get Window text(Caption) name with window handle 'hWnd'
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static string getWndCaption(IntPtr hWnd)
        {
            int length = Win32.GetWindowTextLength(hWnd);
            StringBuilder sb = new StringBuilder(length + 1);
            Win32.GetWindowText(hWnd, sb, sb.Capacity);
            return sb.ToString();
        }

        /// <summary>
        /// find window handle for thread id
        /// </summary>
        /// <param name="threadHandle"></param>
        /// <returns></returns>
        public static IntPtr[] getWindowHandlesForThread(int threadHandle)
        {
            InputEngine._results.Clear();
            Win32.EnumWindows(enumerateWindow, threadHandle);
            return InputEngine._results.ToArray();
        }

        /// <summary>
        /// WindowEnum
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public static int enumerateWindow(IntPtr hWnd, int lParam)
        {
            int processID = 0;
            int threadID = Win32.GetWindowThreadProcessId(hWnd, out processID);
            if (threadID == lParam)
            {
                InputEngine._results.Add(hWnd);
                Win32.EnumChildWindows(hWnd, enumerateWindow, threadID);
            }
            return 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <returns></returns>
        public static int getListViewCount(IntPtr hWnd)
        {
            int cnt = 0;
            int dwProcessID = 0;
            Win32.LVITEM lvItem;

            bool bSuccess;
            IntPtr hProcess = IntPtr.Zero;
            IntPtr lpRemoteBuffer = IntPtr.Zero;
            IntPtr lpLocalBuffer = IntPtr.Zero;
            int threadId = 0;

            try
            {
                lvItem = new Win32.LVITEM();

                // Get the process id owning the window
                threadId = Win32.GetWindowThreadProcessId(hWnd, out dwProcessID);
                if (threadId == 0 || dwProcessID == 0)
                    throw new ArgumentException("hWnd");

                // Open the process with all access
                hProcess = Win32.OpenProcess(Win32.PROCESS_ALL_ACCESS, false, dwProcessID);
                if (hProcess == IntPtr.Zero)
                    throw new ApplicationException("Failed to access process");

                // Allocate a buffer in the remote process
                lpRemoteBuffer = Win32.VirtualAllocEx(hProcess, IntPtr.Zero, Marshal.SizeOf(typeof(Win32.LVITEM)), Win32.MEM_COMMIT,
                  Win32.PAGE_READWRITE);
                if (lpRemoteBuffer == IntPtr.Zero)
                    throw new SystemException("Failed to allocate memory in remote process");

                // Fill in the LVITEM struct, this is in your own process
                // Set the pszText member to somewhere in the remote buffer,
                // For the example I used the address imediately following the LVITEM stuct
                lvItem.mask = Win32.LVIF_STATE;

                lvItem.state = 15;
                lvItem.stateMask = Win32.LVIS_SELECTED | Win32.LVIS_FOCUSED;

                // Copy the local LVITEM to the remote buffer
                bSuccess = Win32.WriteProcessMemory(hProcess, lpRemoteBuffer, ref lvItem,
                  Marshal.SizeOf(typeof(Win32.LVITEM)), IntPtr.Zero);
                if (!bSuccess)
                    throw new SystemException("Failed to write to process memory");

                // Send the message to the remote window with the address of the remote buffer
                cnt = (int)Win32.SendMessage(hWnd, Win32.LVM_GETITEMCOUNT, IntPtr.Zero, IntPtr.Zero);
            }
            finally
            {

                if (lpRemoteBuffer != IntPtr.Zero)
                    Win32.VirtualFreeEx(hProcess, lpRemoteBuffer, 0, Win32.MEM_RELEASE);
                if (hProcess != IntPtr.Zero)
                    Win32.CloseHandle(hProcess);
            }

            return cnt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="item"></param>
        public static void selectListViewItem(IntPtr hWnd, int item)
        {
            int dwProcessID = 0;
            Win32.LVITEM lvItem;

            bool bSuccess;
            IntPtr hProcess = IntPtr.Zero;
            IntPtr lpRemoteBuffer = IntPtr.Zero;
            IntPtr lpLocalBuffer = IntPtr.Zero;
            int threadId = 0;

            try
            {
                lvItem = new Win32.LVITEM();

                // Get the process id owning the window
                threadId = Win32.GetWindowThreadProcessId(hWnd, out dwProcessID);
                if (threadId == 0 || dwProcessID == 0)
                    throw new ArgumentException("hWnd");

                // Open the process with all access
                hProcess = Win32.OpenProcess(Win32.PROCESS_ALL_ACCESS, false, dwProcessID);
                if (hProcess == IntPtr.Zero)
                    throw new ApplicationException("Failed to access process");

                // Allocate a buffer in the remote process
                lpRemoteBuffer = Win32.VirtualAllocEx(hProcess, IntPtr.Zero, Marshal.SizeOf(typeof(Win32.LVITEM)), Win32.MEM_COMMIT,
                  Win32.PAGE_READWRITE);
                if (lpRemoteBuffer == IntPtr.Zero)
                    throw new SystemException("Failed to allocate memory in remote process");

                // Fill in the LVITEM struct, this is in your own process
                // Set the pszText member to somewhere in the remote buffer,
                // For the example I used the address imediately following the LVITEM stuct
                lvItem.mask = Win32.LVIF_STATE;

                lvItem.state = 15;
                lvItem.stateMask = Win32.LVIS_SELECTED | Win32.LVIS_FOCUSED;

                // Copy the local LVITEM to the remote buffer
                bSuccess = Win32.WriteProcessMemory(hProcess, lpRemoteBuffer, ref lvItem,
                  Marshal.SizeOf(typeof(Win32.LVITEM)), IntPtr.Zero);
                if (!bSuccess)
                    throw new SystemException("Failed to write to process memory");

                // Send the message to the remote window with the address of the remote buffer
                Win32.SendMessage(hWnd, Win32.LVM_SETITEMSTATE, (IntPtr)item, lpRemoteBuffer);
            }
            finally
            {

                if (lpRemoteBuffer != IntPtr.Zero)
                    Win32.VirtualFreeEx(hProcess, lpRemoteBuffer, 0, Win32.MEM_RELEASE);
                if (hProcess != IntPtr.Zero)
                    Win32.CloseHandle(hProcess);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static string readListViewItem(IntPtr hWnd, int item)
        {
            const int dwBufferSize = 1024;

            int dwProcessID = 0;
            Win32.LVITEM lvItem;
            string retval;
            bool bSuccess;
            IntPtr hProcess = IntPtr.Zero;
            IntPtr lpRemoteBuffer = IntPtr.Zero;
            IntPtr lpLocalBuffer = IntPtr.Zero;
            int threadId = 0;

            try
            {
                lvItem = new Win32.LVITEM();
                lpLocalBuffer = Marshal.AllocHGlobal(dwBufferSize);
                // Get the process id owning the window
                threadId = Win32.GetWindowThreadProcessId(hWnd, out dwProcessID);
                if (threadId == 0 || dwProcessID == 0)
                    throw new ArgumentException("hWnd");

                // Open the process with all access
                hProcess = Win32.OpenProcess(Win32.PROCESS_ALL_ACCESS, false, dwProcessID);
                if (hProcess == IntPtr.Zero)
                    throw new ApplicationException("Failed to access process");

                // Allocate a buffer in the remote process
                lpRemoteBuffer = Win32.VirtualAllocEx(hProcess, IntPtr.Zero, dwBufferSize, Win32.MEM_COMMIT, Win32.PAGE_READWRITE);
                if (lpRemoteBuffer == IntPtr.Zero)
                    throw new SystemException("Failed to allocate memory in remote process");

                // Fill in the LVITEM struct, this is in your own process
                // Set the pszText member to somewhere in the remote buffer,
                // For the example I used the address imediately following the LVITEM stuct
                lvItem.mask = Win32.LVIF_TEXT;

                lvItem.iItem = item;
                lvItem.iSubItem = 1;
                lvItem.pszText = (IntPtr)(lpRemoteBuffer.ToInt32() + Marshal.SizeOf(typeof(Win32.LVITEM)));
                lvItem.cchTextMax = 50;

                // Copy the local LVITEM to the remote buffer
                bSuccess = Win32.WriteProcessMemory(hProcess, lpRemoteBuffer, ref lvItem,
                  Marshal.SizeOf(typeof(Win32.LVITEM)), IntPtr.Zero);
                if (!bSuccess)
                    throw new SystemException("Failed to write to process memory");

                // Send the message to the remote window with the address of the remote buffer
                Win32.SendMessage(hWnd, Win32.LVM_GETITEM, IntPtr.Zero, lpRemoteBuffer);

                // Read the struct back from the remote process into local buffer
                bSuccess = Win32.ReadProcessMemory(hProcess, lpRemoteBuffer, lpLocalBuffer, dwBufferSize,
                  IntPtr.Zero);
                if (!bSuccess)
                    throw new SystemException("Failed to read from process memory");

                // At this point the lpLocalBuffer contains the returned LV_ITEM structure
                // the next line extracts the text from the buffer into a managed string
                retval = Marshal.PtrToStringAnsi((IntPtr)(lpLocalBuffer.ToInt32() +
                  Marshal.SizeOf(typeof(Win32.LVITEM))));
            }
            finally
            {
                if (lpLocalBuffer != IntPtr.Zero)
                    Marshal.FreeHGlobal(lpLocalBuffer);
                if (lpRemoteBuffer != IntPtr.Zero)
                    Win32.VirtualFreeEx(hProcess, lpRemoteBuffer, 0, Win32.MEM_RELEASE);
                if (hProcess != IntPtr.Zero)
                    Win32.CloseHandle(hProcess);
            }
            return retval;
        }
    }
}
