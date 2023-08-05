// testC.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"

#include <windows.h>
#include "stdio.h"
#include <tchar.h>
#include <iphlpapi.h>
#include "winsock.h"
#include "winbase.h"

TCHAR* _stdcall ImportSrvInfo(TCHAR *srvAddr)
{

	HRESULT hr;
	IPAddr  ipAddr;
	ULONG   pulMac[2];
	ULONG   ulLen;
	char convSrvAddr[16] = {0};

	WideCharToMultiByte(CP_ACP, 0, srvAddr, wcslen(srvAddr), convSrvAddr, sizeof(convSrvAddr), NULL, NULL);
	ipAddr = inet_addr(convSrvAddr);
	memset (pulMac, 0xff, sizeof (pulMac));
	ulLen = 6;

	hr = SendARP (ipAddr, 0, pulMac, &ulLen);

	size_t i, j;
	TCHAR *szMac = new TCHAR[ulLen*3];
	PBYTE pbHexMac = (PBYTE) pulMac;

	//
	// Convert the binary MAC address into human-readable
	//
	if (ulLen <= 0) {
		return L"";
	}

	for (i = 0, j = 0; i < ulLen - 1; ++i) {		
		j += wsprintf (szMac + j, L"%02X:", pbHexMac[i]);
	}

	wsprintf(szMac + j, L"%02X", pbHexMac[i]);

	return szMac;
}