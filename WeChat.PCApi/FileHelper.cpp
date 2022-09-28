#include "pch.h"
#include "FileHelper.h"
#include <direct.h>
#include <corecrt_io.h>

FileHelper::FileHelper() {}
FileHelper::~FileHelper() {}

#pragma region �ж��ļ��Ƿ����
bool FileHelper::FileExist(string filePath) 
{
	struct stat buffer;
	int exist = stat(filePath.c_str(), &buffer);
	return (exist == 0);
}
#pragma endregion

#pragma region ����Ŀ¼
bool FileHelper::CreateDir(string filePath) 
{
	int m = 0, n;
	string str1, str2;

	str1 = filePath;
	str2 = str1.substr(0, 2);
	str1 = str1.substr(3, str1.size());

	while (m >= 0)
	{
		m = str1.find('\\');
		str2 += '\\' + str1.substr(0, m);
		n = _access(str2.c_str(), 0); //�жϸ�Ŀ¼�Ƿ����
		if (n == -1)
		{
			_mkdir(str2.c_str());     //����Ŀ¼
		}
		str1 = str1.substr(m + 1, str1.size());
	}
	return true;
}
#pragma endregion
