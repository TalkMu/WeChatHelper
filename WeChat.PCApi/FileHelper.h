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
	/// �ж��ļ��Ƿ����
	/// </summary>
	/// <param name="filePath">�ļ�·��</param>
	/// <returns></returns>
	static bool FileExist(string filePath);
	/// <summary>
	/// ����Ŀ¼
	/// </summary>
	/// <param name="filePath">Ŀ¼·��</param>
	/// <returns></returns>
	static bool CreateDir(string filePath);
};