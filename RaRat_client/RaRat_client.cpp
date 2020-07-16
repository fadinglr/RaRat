#include <iostream>
#include <Windows.h>
#include <fstream>
#include <ctime>
#include <string>
#include <sstream>
#include <ctime>
#include <stdio.h>

using namespace std;

string convertToString(char* a, int size)
{
    int i;
    string s = "";
    for (i = 0; i < size; i++) {
        s = s + a[i];
    }
    return s;
}


void CapruteScreenAndSaveToFile()
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

string RunCommand(string ra_cmd) {
    
    char   psBuffer[128];
    FILE* pPipe;
    string output;
    string temp;
    output = "";

    if ((pPipe = _popen("dir", "rt")) == NULL)
        exit(1);
    while (fgets(psBuffer, 128, pPipe)) {
        output = output +  convertToString(psBuffer,128);
        printf(psBuffer);
    }
    return output;
}


int main()
{
    

    RunCommand("dir") ;
    return 0;
}