; === SYMBOLS ===
; !   <- Alt
; +   <- Shift
; ^   <- Ctrl
; #   <- Win
; For more, visit https://autohotkey.com/docs/Hotkeys.htm

; === PROGRAM SHORTCUTS ===

Browser := "C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe"
Music := "C:\Users\Nicholas.Balzer\AppData\Roaming\Spotify\Spotify.exe"

!w::run %Browser%
!e::run Explorer
!m::run %Music%
!x::run "C:\Program Files (x86)\Microsoft Office\root\Office16\EXCEL.EXE"

; === VIRTUAL DESKTOP ACTIONS ===

;!c::createVirtualDesktop()
;!d::deleteVirtualDesktop()

!s::switchDesktopToRight()
!a::switchDesktopToLeft()

!1::switchDesktopByNumber(1)
!2::switchDesktopByNumber(2)
!3::switchDesktopByNumber(3)
!4::switchDesktopByNumber(4)
!5::switchDesktopByNumber(5)
!6::switchDesktopByNumber(6)
!7::switchDesktopByNumber(7)
!8::switchDesktopByNumber(8)
!9::switchDesktopByNumber(9)

!Numpad1::switchDesktopByNumber(1)
!Numpad2::switchDesktopByNumber(2)
!Numpad3::switchDesktopByNumber(3)
!Numpad4::switchDesktopByNumber(4)
!Numpad5::switchDesktopByNumber(5)
!Numpad6::switchDesktopByNumber(6)
!Numpad7::switchDesktopByNumber(7)
!Numpad8::switchDesktopByNumber(8)
!Numpad9::switchDesktopByNumber(9)


!+1::MoveCurrentWindowToDesktop(1)
!+2::MoveCurrentWindowToDesktop(2)
!+3::MoveCurrentWindowToDesktop(3)
!+4::MoveCurrentWindowToDesktop(4)
!+5::MoveCurrentWindowToDesktop(5)
!+6::MoveCurrentWindowToDesktop(6)
!+7::MoveCurrentWindowToDesktop(7)
!+8::MoveCurrentWindowToDesktop(8)
!+9::MoveCurrentWindowToDesktop(9)

!NumpadEnd::MoveCurrentWindowToDesktop(1)
!NumpadDown::MoveCurrentWindowToDesktop(2)
!NumpadPgDn::MoveCurrentWindowToDesktop(3)
!NumpadLeft::MoveCurrentWindowToDesktop(4)
!NumpadClear::MoveCurrentWindowToDesktop(5)
!NumpadRight::MoveCurrentWindowToDesktop(6)
!NumpadHome::MoveCurrentWindowToDesktop(7)
!NumpadUp::MoveCurrentWindowToDesktop(8)
!NumpadDel::MoveCurrentWindowToDesktop(9)


; === WINDOW ACTIONS ===

!+f::MinMaxWindow()
+^q::QuitActiveWindow()