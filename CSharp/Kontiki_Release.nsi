; The name of the installer - might be changed later
Name "Kontiki"

; The file to write
OutFile "Kontiki.exe"

; The default installation directory
InstallDir "$DESKTOP\Kontiki"

; Request application privileges for Windows Vista
RequestExecutionLevel user

; Pages
Page Directory
Page Instfiles
;--------------------------------
; The stuff to install
Section "Files" 
  ; Set output path to the installation directory.
  ; CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r "Binary\Release\*.dll"
  File /r "Binary\Release\Kontiki.WF.exe"
  File /r "Binary\Release\kontiki_connections.xml"
  
SectionEnd ; end the section
