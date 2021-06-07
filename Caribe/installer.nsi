!include "MUI2.nsh"

Name "Salon Caribe"
OutFile "caribe.exe"

Unicode True
RequestExecutionLevel admin

InstallDir "$PROGRAMFILES\Salon Caribe"

!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

!insertmacro MUI_LANGUAGE "Spanish"

Section "Install"
    SetOutPath "$INSTDIR"
    File "bin\Release\net5.0-windows\Caribe.exe"
    File "bin\Release\net5.0-windows\Caribe.dll"
    File "bin\Release\net5.0-windows\Caribe.deps.json"
    File "bin\Release\net5.0-windows\Caribe.runtimeconfig.json"
    WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd


Section "Uninstall"
    Delete "$INSTDIR\Caribe.exe"
    Delete "$INSTDIR\Caribe.dll"
    Delete "$INSTDIR\Caribe.deps.json"
    Delete "$INSTDIR\Caribe.runtimeconfig.json"
    Delete "$INSTDIR\Uninstall.exe"
    RMDir "$INSTDIR"
SectionEnd