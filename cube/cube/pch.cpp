// pch.cpp: 与预编译标头对应的源文件

#include "pch.h"

#define C_API extern "C" __declspec(dllexport)
// 当使用预编译的头时，需要使用此源文件，编译才能成功。
C_API void Extrude(float** rawVertices, float* rawNormals, size_t verticesCount)
{
	for (size_t i = 0; i < verticesCount * 3; i++)
	{
		*(*rawVertices + i) = *(*rawVertices + i) + *rawNormals * 0.01f;
	}
}