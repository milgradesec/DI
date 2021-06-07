!include "MUI2.nsh"

Name "Salon Habana"
OutFile "habana.exe"

Unicode True
RequestExecutionLevel admin

InstallDir "$PROGRAMFILES\Salon Habana"

!insertmacro MUI_PAGE_COMPONENTS
!insertmacro MUI_PAGE_DIRECTORY
!insertmacro MUI_PAGE_INSTFILES

!insertmacro MUI_UNPAGE_CONFIRM
!insertmacro MUI_UNPAGE_INSTFILES

!insertmacro MUI_LANGUAGE "Spanish"

Section "Install"
    SetOutPath "$INSTDIR"
    File "app\build\libs\app.jar"
    WriteUninstaller "$INSTDIR\Uninstall.exe"
SectionEnd


Section "Uninstall"
    Delete "$INSTDIR\app.jar"
    Delete "$INSTDIR\Uninstall.exe"
    RMDir "$INSTDIR"
SectionEnd