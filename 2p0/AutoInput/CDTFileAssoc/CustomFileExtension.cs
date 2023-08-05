using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.Collections;
using System.Globalization;
using System.Reflection;
using System.ComponentModel.Design.Serialization;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Design;

namespace CDTFileAssoc
{
    [ToolboxBitmap(typeof(CDTFileExtension), "icon")]
    public partial class CDTFileExtension : Component
    {
        [DllImport("shell32.dll")]
        static extern void SHChangeNotify(HChangeNotifyEventID wEventId,
                                           HChangeNotifyFlags uFlags,
                                           IntPtr dwItem1,
                                           IntPtr dwItem2);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, int wParam, ref COPYDATASTRUCT lParam);


        #region enum HChangeNotifyEventID
        /// <summary>
        /// Describes the event that has occurred. 
        /// Typically, only one event is specified at a time. 
        /// If more than one event is specified, the values contained 
        /// in the <i>dwItem1</i> and <i>dwItem2</i> 
        /// parameters must be the same, respectively, for all specified events. 
        /// This parameter can be one or more of the following values. 
        /// </summary>
        /// <remarks>
        /// <para><b>Windows NT/2000/XP:</b> <i>dwItem2</i> contains the index 
        /// in the system image list that has changed. 
        /// <i>dwItem1</i> is not used and should be <see langword="null"/>.</para>
        /// <para><b>Windows 95/98:</b> <i>dwItem1</i> contains the index 
        /// in the system image list that has changed. 
        /// <i>dwItem2</i> is not used and should be <see langword="null"/>.</para>
        /// </remarks>
        [Flags]
        enum HChangeNotifyEventID
        {
            /// <summary>
            /// All events have occurred. 
            /// </summary>
            SHCNE_ALLEVENTS = 0x7FFFFFFF,

            /// <summary>
            /// A file type association has changed. <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> 
            /// must be specified in the <i>uFlags</i> parameter. 
            /// <i>dwItem1</i> and <i>dwItem2</i> are not used and must be <see langword="null"/>. 
            /// </summary>
            SHCNE_ASSOCCHANGED = 0x08000000,

            /// <summary>
            /// The attributes of an item or folder have changed. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the item or folder that has changed. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
            /// </summary>
            SHCNE_ATTRIBUTES = 0x00000800,

            /// <summary>
            /// A nonfolder item has been created. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the item that was created. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>.
            /// </summary>
            SHCNE_CREATE = 0x00000002,

            /// <summary>
            /// A nonfolder item has been deleted. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the item that was deleted. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_DELETE = 0x00000004,

            /// <summary>
            /// A drive has been added. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the root of the drive that was added. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_DRIVEADD = 0x00000100,

            /// <summary>
            /// A drive has been added and the Shell should create a new window for the drive. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the root of the drive that was added. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_DRIVEADDGUI = 0x00010000,

            /// <summary>
            /// A drive has been removed. <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the root of the drive that was removed.
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_DRIVEREMOVED = 0x00000080,

            /// <summary>
            /// Not currently used. 
            /// </summary>
            SHCNE_EXTENDED_EVENT = 0x04000000,

            /// <summary>
            /// The amount of free space on a drive has changed. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the root of the drive on which the free space changed.
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_FREESPACE = 0x00040000,

            /// <summary>
            /// Storage media has been inserted into a drive. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the root of the drive that contains the new media. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_MEDIAINSERTED = 0x00000020,

            /// <summary>
            /// Storage media has been removed from a drive. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the root of the drive from which the media was removed. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_MEDIAREMOVED = 0x00000040,

            /// <summary>
            /// A folder has been created. <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> 
            /// or <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the folder that was created. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_MKDIR = 0x00000008,

            /// <summary>
            /// A folder on the local computer is being shared via the network. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the folder that is being shared. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_NETSHARE = 0x00000200,

            /// <summary>
            /// A folder on the local computer is no longer being shared via the network. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the folder that is no longer being shared. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_NETUNSHARE = 0x00000400,

            /// <summary>
            /// The name of a folder has changed. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the previous pointer to an item identifier list (PIDL) or name of the folder. 
            /// <i>dwItem2</i> contains the new PIDL or name of the folder. 
            /// </summary>
            SHCNE_RENAMEFOLDER = 0x00020000,

            /// <summary>
            /// The name of a nonfolder item has changed. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the previous PIDL or name of the item. 
            /// <i>dwItem2</i> contains the new PIDL or name of the item. 
            /// </summary>
            SHCNE_RENAMEITEM = 0x00000001,

            /// <summary>
            /// A folder has been removed. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the folder that was removed. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_RMDIR = 0x00000010,

            /// <summary>
            /// The computer has disconnected from a server. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the server from which the computer was disconnected. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// </summary>
            SHCNE_SERVERDISCONNECT = 0x00004000,

            /// <summary>
            /// The contents of an existing folder have changed, 
            /// but the folder still exists and has not been renamed. 
            /// <see cref="HChangeNotifyFlags.SHCNF_IDLIST"/> or 
            /// <see cref="HChangeNotifyFlags.SHCNF_PATH"/> must be specified in <i>uFlags</i>. 
            /// <i>dwItem1</i> contains the folder that has changed. 
            /// <i>dwItem2</i> is not used and should be <see langword="null"/>. 
            /// If a folder has been created, deleted, or renamed, use SHCNE_MKDIR, SHCNE_RMDIR, or 
            /// SHCNE_RENAMEFOLDER, respectively, instead. 
            /// </summary>
            SHCNE_UPDATEDIR = 0x00001000,

            /// <summary>
            /// An image in the system image list has changed. 
            /// <see cref="HChangeNotifyFlags.SHCNF_DWORD"/> must be specified in <i>uFlags</i>. 
            /// </summary>
            SHCNE_UPDATEIMAGE = 0x00008000,

        }
        #endregion // enum HChangeNotifyEventID

        #region public enum HChangeNotifyFlags
        /// <summary>
        /// Flags that indicate the meaning of the <i>dwItem1</i> and <i>dwItem2</i> parameters. 
        /// The uFlags parameter must be one of the following values.
        /// </summary>
        [Flags]
        public enum HChangeNotifyFlags
        {
            /// <summary>
            /// The <i>dwItem1</i> and <i>dwItem2</i> parameters are DWORD values. 
            /// </summary>
            SHCNF_DWORD = 0x0003,
            /// <summary>
            /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of ITEMIDLIST structures that 
            /// represent the item(s) affected by the change. 
            /// Each ITEMIDLIST must be relative to the desktop folder. 
            /// </summary>
            SHCNF_IDLIST = 0x0000,
            /// <summary>
            /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of null-terminated strings of 
            /// maximum length MAX_PATH that contain the full path names 
            /// of the items affected by the change. 
            /// </summary>
            SHCNF_PATHA = 0x0001,
            /// <summary>
            /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of null-terminated strings of 
            /// maximum length MAX_PATH that contain the full path names 
            /// of the items affected by the change. 
            /// </summary>
            SHCNF_PATHW = 0x0005,
            /// <summary>
            /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of null-terminated strings that 
            /// represent the friendly names of the printer(s) affected by the change. 
            /// </summary>
            SHCNF_PRINTERA = 0x0002,
            /// <summary>
            /// <i>dwItem1</i> and <i>dwItem2</i> are the addresses of null-terminated strings that 
            /// represent the friendly names of the printer(s) affected by the change. 
            /// </summary>
            SHCNF_PRINTERW = 0x0006,
            /// <summary>
            /// The function should not return until the notification 
            /// has been delivered to all affected components. 
            /// As this flag modifies other data-type flags, it cannot by used by itself.
            /// </summary>
            SHCNF_FLUSH = 0x1000,
            /// <summary>
            /// The function should begin delivering notifications to all affected components 
            /// but should return as soon as the notification process has begun. 
            /// As this flag modifies other data-type flags, it cannot by used by itself.
            /// </summary>
            SHCNF_FLUSHNOWAIT = 0x2000
        }
        #endregion // enum HChangeNotifyFlags

        string HKCR = "HKEY_CLASSES_ROOT\\";

        private const int WM_COPYDATA = 0x4A;

        struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        AppCollection openWith = new AppCollection();
        bool embeddedIcon = false;
        string ext;
        string handler = "";
        string desc;
        int iconPos = 0;
        string iconName;
        string openText;
        string appName;

        public CDTFileExtension()
        {
            InitializeComponent();
        }

        public CDTFileExtension(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void InitInformation(string app, string icon)
        {
            appName = app;
            iconName = icon;
        }

        public void RegisterFileType()
        {
            string strPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.System);

            Registry.SetValue(HKCR + ext, "", handler);
            Registry.SetValue(HKCR + handler, "", desc);

            Registry.ClassesRoot.CreateSubKey("DefaultIcon");
            if (embeddedIcon)
                Registry.SetValue(HKCR + handler + "\\DefaultIcon", "", "\"" + strPath + "\\" + appName + "\"," + iconPos + "");
            else
                Registry.SetValue(HKCR + handler + "\\DefaultIcon", "", "\"" + strPath + "\\" + iconName + "\"");

            Registry.SetValue(HKCR + handler + "\\shell", "", "");
            Registry.SetValue(HKCR + handler + "\\shell\\open", "", openText);
            Registry.SetValue(HKCR + handler + "\\shell\\open\\command", "", "\"" + strPath + "\\" + appName + @""" ""%1""");
            
            for (int i = 0; i < openWith.Count; i++)
            {
                string app = openWith[i].AppPath;
                string originalApp = app;
                app = app.Substring(app.LastIndexOf("\\") + 1);
                app = app.Substring(0, app.LastIndexOf('.'));

                string runHandler = "CustomFileExtension." + app + ".Run.Handler";

                Registry.ClassesRoot.CreateSubKey(ext + "\\OpenWithProgids");
                Registry.SetValue(HKCR + ext + "\\OpenWithProgids", runHandler, "");

                // openwith handler
                Registry.SetValue(HKCR + runHandler, "", "");
                
                Registry.SetValue(HKCR + runHandler + "\\shell", "", "");
                Registry.SetValue(HKCR + runHandler + "\\shell\\open", "", "");
                Registry.SetValue(HKCR + runHandler + "\\shell\\open\\command", "", "\"" + originalApp + @""" ""%1""");
            }

            SHChangeNotify(HChangeNotifyEventID.SHCNE_ASSOCCHANGED, HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
        }

        public void RemoveFileType()
        {
            RegistryKey regExt = Registry.ClassesRoot.OpenSubKey(ext);
            RegistryKey regHandler = Registry.ClassesRoot.OpenSubKey(handler);

            if (regExt != null && regHandler != null)
            {
                RegistryKey rk = Registry.ClassesRoot.OpenSubKey(ext + "\\OpenWithProgids");

                string[] names = null;
                if (rk != null)
                {
                    names = rk.GetValueNames();

                    for (int i = 0; i < names.Length; i++)
                    {
                        Registry.ClassesRoot.DeleteSubKeyTree(names[i]);
                    }
                }

                Registry.ClassesRoot.DeleteSubKeyTree(ext);
                Registry.ClassesRoot.DeleteSubKeyTree(handler);

                SHChangeNotify(HChangeNotifyEventID.SHCNE_ASSOCCHANGED, HChangeNotifyFlags.SHCNF_IDLIST, IntPtr.Zero, IntPtr.Zero);
            }
        }


        /// <summary>
        /// Sends the file path to the one of the application instance.
        /// </summary>
        /// <param name="args">Arguments passed from main method</param>
        /// <returns>Return true if there's more then one instance active.</returns>
        /// <example>if (!ctf.SendFilePath(args)) Application.Run(new Form1(args));</example>
        public bool SendFilePath(string[] args)
        {
            Process proc = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(proc.ProcessName);

            if (processes.Length == 0)
                return false;

            string message = "";

            for (int i = 0; i < args.Length; i++)
                message += args[i] + ";";


            byte[] data = Encoding.Default.GetBytes(message);
            int dataLen = data.Length;

            COPYDATASTRUCT cds;
            cds.dwData = (IntPtr)100;
            cds.lpData = message;
            cds.cbData = dataLen + 1;

            if (processes.Length > 1)
            {
                foreach (Process p in processes)
                {
                    if (p.Id != proc.Id)
                    {
                        SendMessage(p.MainWindowHandle, WM_COPYDATA, 0, ref cds);
                        return true;
                    }
                }
            }

            return false;
        }

        public string[] GetData(string data)
        {
            data = data.TrimEnd(';');
            string[] arr = data.Split(';');

            return arr;
        }

        #region PROPERTIES



 
        // This attribute tells the code generator to serialize the contained items
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AppCollection OpenWith
        {
            get { return openWith; }

            set { openWith = value; }
        }

        [Description("If set to true, icon is used from an application otherwise icon is used from a icon name.")]
        public bool EmbeddedIcon
        {
            get { return embeddedIcon; }

            set { embeddedIcon = value; }
        }

        [Description("Enter the name of your application.")]
        public string ApplicationName
        {
            get { return appName; }

            set { appName = value; }
        }

        [Description("Set the text to be displayed when you right click on the file with selected extension.")]
        public string OpenText
        {
            get { return openText; }

            set { openText = value; }
        }

        [Description("Enter the name of the icon file if the EmbeddedIcon is set to false.")]
        public string IconName
        {
            get { return iconName; }

            set { iconName = value; }
        }

        [Description("Selects the icon position inside the resource file if EmbeddedIcon is set to true.")]
        public int IconPosition
        {
            get { return iconPos; }

            set { iconPos = value; }
        }

        [Description("Description of the custom file format in the explorer.")]
        public string Description
        {
            get { return desc; }

            set { desc = value; }
        }

        [Description("Reference between file extension and the application to be started.")]
        public string Handler
        {
            get { return handler; }

            set { handler = value; }
        }

        [Description("Extension to create association for.")]
        public string Extension
        {
            get { return ext; }

            set { ext = value; }
        }

        #endregion

    }


    // The strongly typed collection
    // Never expose an ArrayList or an Array as a public property!
    [Serializable]
    public class AppCollection : CollectionBase
    {
        public App this[int index]
        {
            get { return (App)List[index]; }
            set { List[index] = value; }
        }

        public int Add(App item)
        {
            return List.Add(item);
        }

        public void Remove(App item)
        {
            List.Remove(item);
        }
        
    }


    // assign the converter
    
    public class App
    {
        public App()
        {
            this.appPath = null;
        }

        public App(string appPath)
        {
            // add validation logic here
            this.appPath = appPath;
        }

        private string appPath;

        [Editor(typeof(FileSelectorTypeEditor), typeof(UITypeEditor))]
        public string AppPath
        {
            get { return appPath; }
            set { appPath = value; }
        }
    }


    // The converter for Holiday. It's main purpose is to support code generation
    // It also makes the object "expandable", like e.g. Point or Size.
    internal class AppConverter : ExpandableObjectConverter
    {
        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            // An InstanceDescriptor is required for code generation
            if (destinationType == typeof(InstanceDescriptor))
                return true;

            // delegate other conversions
            return base.CanConvertTo(context, destinationType);
        }


        public override object ConvertTo(ITypeDescriptorContext context,
            CultureInfo culture, object value, Type destinationType)
        {
            // cast value
            App app = value as App;

            // the InstanceDescriptor is used by the CodeGenerator to
            // get information about how to construct the value
            if (destinationType == typeof(InstanceDescriptor) && app != null)
            {
                // the arguments of the constructor (int month, int day, string reason)
                Type[] argumentTypes = new Type[] { typeof(int), typeof(int), typeof(string) };

                // get the constructor
                ConstructorInfo constructor = typeof(App).GetConstructor(argumentTypes);

                // array with the actual constructor arguments
                object[] arguments = new object[] { app.AppPath };

                if (constructor != null)
                    // return the instance descriptor
                    return new InstanceDescriptor(constructor, arguments, false);
            }

            // delegate other conversions
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
