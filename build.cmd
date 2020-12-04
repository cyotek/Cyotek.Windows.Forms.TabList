@ECHO OFF

SETLOCAL

CALL ..\..\..\build\set35vars.bat

SET BASENAME=Cyotek.Windows.Forms.TabList
SET RELDIR=Cyotek.Windows.Forms.TabList\bin\Release\
SET PRJFILE=Cyotek.Windows.Forms.TabList\%BASENAME%.csproj
SET DLLNAME=%BASENAME%.dll

IF EXIST %RELDIR%*.nupkg DEL /F %RELDIR%*.nupkg
IF EXIST %RELDIR%*.snupkg DEL /F %RELDIR%*.snupkg
IF EXIST %RELDIR%*.zip DEL /F %RELDIR%*.zip

%msbuildexe% %PRJFILE% /p:Configuration=Release /verbosity:minimal /nologo /t:Clean,Build

PUSHD %RELDIR%

CALL signcmd %DLLNAME%

%nugetexe% pack ..\..\..\%PRJFILE% -Prop Configuration=Release
CALL sign-package *.nupkg

POPD

ENDLOCAL
