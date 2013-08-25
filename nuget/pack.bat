@ECHO OFF

SET fwversion=%1
IF "%1"=="" SET fwversion=v4.0.30319

SET MSBUILD=C:\Windows\Microsoft.NET\Framework\%fwversion%\MSBUILD.exe

%MSBUILD% ..\Cyotek.Windows.Forms.TabList.sln /p:Configuration=Release /verbosity:minimal /nologo /t:Clean,Build
NUGET pack ..\Cyotek.Windows.Forms.TabList\Cyotek.Windows.Forms.TabList.csproj -Prop Configuration=Release

PAUSE