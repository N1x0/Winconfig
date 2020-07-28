# Winconfig
Personal configuration for windows 10 (1903/1909)

This is my current setup for windows and some common MS office programs, so something like linux `dotfiles` just for windows I guess. There a few (IMO) neat things in here that may be useful to others,
which is why I made this repo public. The core features can be seperated into

Split into two seperate configurations 1 for personal and the other for work. 

## Windows configurations

### [workspacer](https://www.workspacer.org)
A fantastic tool currently being developed. It still has quite a few limitations so I won't be using it all the time but for my setup at work it should already be sufficient.
My biggest issues so far (and these are probably because I don't know C#):
* Lack of documentation
* Inability to handle full screen apps or at least most games I play
* Cannot change focus colors of the app bar and the red really is harsh on the eyes
* Cannot adjust window gaps in config file


### Autohotkey 
 A combination of a couple of autohotkey scripts and set-ups I gathered and modified. Uses the `VirtualDesktopAccessor.dll` and basically tries to emulate the `i3wm` setup I use on Linux.
The main purpose is for resizing windows (minimize & maximize) as well as moving them around my virtual desktops.

### [PowerToys](https://github.com/microsoft/PowerToys)
Here I use mostly `FancyZones` with the remaining stuff turned off. Same as the AHK scripts the idea is to emulate my i3wm setup. The zones here are supposed to substitute the tiling approach and while they do a decent job it's still not really what I am looking for.

 
### Dracula Terminal themes
Does what it says.. Dracula themes for `cmd` and `powershell`


### [PasteHere](https://github.com/tomzorz/PasteHere)
As someone using the `win+shift+s` quite a lot this is really great as I can skip the trip to MS paint to save my screenshot to a file directly

## MS Office configurations
I have tested these on both MS office 2016 as well as the 365 version but have not bothered with doing some other compatibility checks.

### 1. Rubberduck
![Rubberduck](https://user-images.githubusercontent.com/5751684/48656196-a507af80-e9ef-11e8-9c09-1ce3c619c019.png)

This is an amazing add-in for the VBE (Visual Basic Editor) that comes with all office applications. For details you can look  on [Github](https://github.com/rubberduck-vba/Rubberduck) or on the official [website](https://rubberduckvba.com).
It helps bring so much more productivity to writing VBA and I love it. The things I use the most are 
* Code Explorer 
  * I replaced the in-built project explorer with this.
  * Being able to see each sub function or variable from within the explorer makes finding relevant code much easier and gives it the feel of a real IDE
  * It also helps with organizing as you can group modules/sheets/userforms into `folders`. While these have 0 effect without Rubberduck they help creating logical groups that go beyond just modules and classes.
* Code inspections
  * just tons of ways on how to improve you code, make it more readable and more robust
* Auto completion

### 2.Excel/Word/Outlook Quick Access Toolbar
Probably the least useful to others but I like it, just have a look. The one that's actually being used the most is obviously the excel one. 
I use the numpad a lot and most of these are set up in such a way that I can fully utilize this for features that otherwise would take *4+* characters

### 3. VBE Theme color editor
A custom editor I found [here](https://github.com/dimitropoulos/VBECustomColors) on github. 
I added the dracula palette because that's what I'm currently using for cmd/powershell as well. It still needs some tweaking so I might change one or two things. If I switch to something else I'll also update this one (gruvbox, looking at you)


## Other program configs
*  [Dracula for Visual Studio](https://github.com/dracula/visual-studio)


## TODO
- [x] Try out [workspacer](https://www.workspacer.org/). If my `C#` holds up then I'm pretty sure I can configure it so it replaces both my AHK scripts as well as PowerToys' FancyZones
- [ ] Refine dracula theme for **VBE**