#pragma once
#include <string>
#include "pch.h"
using namespace std;
class FileHelper
{
public:
	FileHelper();
	~FileHelper();

private:

public:
	/// <summary>
	/// 判断文件是否存在
	/// </summary>
	/// <param name="filePath">文件路径</param>
	/// <returns></returns>
	static bool FileExist(string filePath);
	/// <summary>
	/// 创建目录
	/// </summary>
	/// <param name="filePath">目录路径</param>
	/// <returns></returns>
	static bool CreateDir(string filePath);
};