# UnityCubeExtrude
 C#DLL called by C++ to extrude the cube object in Unity
check result.mp4 to quick know the function of this project

# easy open method:
1- open UnityCubeExtrude\cubeDivFinal\cubeDiv.sln by Unity\
2- choose play mode\
3- press "Extrude" button


# sequence of creation of file/folder and their definition
CubeProto [folder]: some practice C# code for vertices and cube construction\
pch-draft.h: header file to check C++ environment of machine\
cube-demo.dll: dll demo by simple function to check dll release environment\
CubeControl - simple function demo.cs: simple C# demo to call demo dll\
cube [folder]: C++ and DLL folder (you can check history draft version in .cpp)\
cubeDivDraft [folder]: pure Unity C# folder to achieve the anticipated function\
cubeDivFinal [folder]: final Unity C# folder to achieve the anticipated function, need to copy from\
UnityCubeExtrude/cube/x64/Release/cube.dll\
to\
UnityCubeExtrude/cubeDivFinal/Assets/Plugins\
for the anticipated function.\
result.mp4: video of final result
