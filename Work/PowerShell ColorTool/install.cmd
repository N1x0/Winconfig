@echo off
echo After this script completes, the terminal may look wrong
echo However, new terminals will look ok. Press any key to
echo continue and then close this terminal
pause
copy "install\Windows PowerShell.lnk" "%HOMEDRIVE%%HOMEPATH%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Windows PowerShell\"
copy "install\Windows PowerShell (x86).lnk" "%HOMEDRIVE%%HOMEPATH%\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Windows PowerShell\"
reg import "install\Remove Default Console Overrides.reg"
ColorTool.exe -b "install\Dracula-ColorTool.itermcolors"
