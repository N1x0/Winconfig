
; === PROGRAM SHORTCUTS ===
Browser := "C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
Music := "C:\Users\Nicholas.Balzer\AppData\Roaming\Spotify\Spotify.exe"

!w::run %Browser%
!e::run Explorer
!m::run %Music%
!x::run "C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE"

; === WINDOW ACTIONS ===

!+f::MinMaxWindow()
+^q::QuitActiveWindow()