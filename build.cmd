@ECHO OFF

SETLOCAL

CALL ..\..\..\build\set35vars.bat

REM Build and sign the file
%msbuildexe% Cyotek.Windows.Forms.TabList.sln /p:Configuration=Release /verbosity:minimal /nologo /t:Clean,Build
CALL signcmd Cyotek.Windows.Forms.TabList\bin\Release\Cyotek.Windows.Forms.TabList.dll

REM Create the package
PUSHD %CD%
IF NOT EXIST nuget MKDIR nuget
CD nuget
NUGET pack ..\Cyotek.Windows.Forms.TabList\Cyotek.Windows.Forms.TabList.csproj -Prop Configuration=Release
POPD

ENDLOCAL
