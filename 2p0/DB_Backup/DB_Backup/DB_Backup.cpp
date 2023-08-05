// DB_Backup.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <Windows.h>

#define DEFAULT_BACKUP_PATH			L"E:"
#define SQL_USERNAME				L"root"
#define SQL_PASSWORD				L"root"
#define SQL_DBNAME					L"bgddb"
#define DEFAULT_SAVE_FILENAME		L"C:\\Program Files\\MySQL\\MySQL Server 5.0\\bin\\mysqldump.exe"

#define DEFALT_BACKUP_INTERVAL		1000 * 60 * 60 * 60 * 2

int _tmain(int argc, _TCHAR* argv[])
{
	TCHAR exePath[MAX_PATH], savePath[MAX_PATH], fileName[MAX_PATH];
	char szExeFileName[MAX_PATH];
	SYSTEMTIME curDateTime;

	DWORD dwStartTick, dwCurTick;
	DWORD dwInterval;

	if (argc > 1)
		dwInterval = _wtoi(argv[1]) * 60 * 1000;
	else
		dwInterval = DEFALT_BACKUP_INTERVAL;

	dwStartTick = GetTickCount() - dwInterval;
	while (1)
	{
		dwCurTick = GetTickCount();
		if (dwCurTick - dwStartTick > dwInterval)
		{
			dwStartTick = dwCurTick;

			ZeroMemory(exePath, MAX_PATH);
			ZeroMemory(savePath, MAX_PATH);
			ZeroMemory(fileName, MAX_PATH);

			GetLocalTime(&curDateTime);
			wsprintf(fileName, L"%.4d-%.2d-%.2d", curDateTime.wYear, curDateTime.wMonth, curDateTime.wDay);

			if (argc > 2)
				lstrcpy(savePath, argv[2]);
			else
				lstrcpy(savePath, DEFAULT_BACKUP_PATH);

			lstrcat(savePath, L"\\");
			lstrcat(savePath, fileName);
			_wmkdir(savePath);

			DWORD dwtick = GetTickCount();
			wsprintf(savePath, L"%s\\%s-%.2d-%.2d_%s.sql", savePath, fileName, curDateTime.wHour, curDateTime.wMinute, SQL_DBNAME);
			wsprintf(exePath, L"\"%s\" -u %s -p%s -r %s %s", DEFAULT_SAVE_FILENAME, SQL_USERNAME, SQL_PASSWORD, savePath, SQL_DBNAME);

			ZeroMemory(szExeFileName, sizeof(szExeFileName));
			WideCharToMultiByte(CP_ACP, 0, exePath, (int)_tcslen(exePath), szExeFileName, MAX_PATH, NULL, NULL);


			PROCESS_INFORMATION piInfo;
			ZeroMemory(&piInfo ,sizeof(PROCESS_INFORMATION));

			STARTUPINFO stInfo;
			ZeroMemory(&stInfo, sizeof(STARTUPINFO));
			stInfo.cb = sizeof(STARTUPINFO);
			stInfo.wShowWindow = SW_HIDE;

			CreateProcess(NULL, exePath, NULL, NULL, FALSE, NORMAL_PRIORITY_CLASS , NULL, NULL, &stInfo, &piInfo);

			// Wait until child process exits.
			WaitForSingleObject( piInfo.hProcess, INFINITE );


			CloseHandle(piInfo.hProcess);
			CloseHandle(piInfo.hThread);
		}

		Sleep(1000);
	}

	return 0;
}
