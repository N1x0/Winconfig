# Current Configuration
Personal configuration for windows 10 (2004)

This is my current setup for windows and some common MS office programs, so something like linux `dotfiles` just for windows I guess. There a few (IMO) neat things in here that may be useful to others, hich is why I made this repo public. The core features can be split into two seperate configurations, 1 for personal and the other for work. 
## OS configurations

### [workspacer](https://www.workspacer.org)
A fantastic tool currently being developed. It still has a couple of limitations that make it a bit troublesome at times but overall it's quite good and does what I need it to.
My biggest issues so far:
* Lack of documentation (I just read most of the source code and will do my best to update the documentation so you won't have to)
* No dynamic reassignment of ` sticky workspaces` to available monitors, i.e. if I disconnect my laptop from my monitor (or there is any other screen change) then it'll just quit
 * Working on this currently
* Cannot __easily__ adjust window gaps in config file; 
 * I already found a way to adjust one of the `LayoutEngines (TallLayoutEngine)` but I don't really like the way I did it and it's not easily set in the config file so I might revisit this eventually


 ### [ThrottleStop](https://www.techpowerup.com/download/techpowerup-throttlestop/)
 An undervolting utility similar (but better than) Intel XTU. I use a laptop with an i7-7700HQ at home which, while decent performance wise, gets pretty hot for my liking. I leave almost everything at default and only play with the CPU/Cache & IGPU resulting in about 8-10 degrees lower temperatures.
 
     * CPU & Cache: -125 mV
     * IGPU:        -50  mV
 
 
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

### 2.Excel/Word/Outlook/Powerpoint
* Quick-access toolbars: Probably the least useful to others but I like it, just have a look. The one that's actually being used the most is obviously the excel one. I use the numpad a lot and most of these are set up in such a way that I can fully utilize this for features that otherwise would take *4+* characters

* Powerpoint Slide numbering add-in:
    * A small macro I wrote that *before saving* adjusts the slide numbers based on the number of *visible* slides. I had this issue in the past that when exporting Powerpoint to PDF some slides were hidden but the slide numbers didn't update accordingly. This meant that in the PDF you'd "randomly" jump from slide 5 to 10 for instance. Since in most of my templates I have many optional slides that users can simply hide I found this to be a decent way for PDF's to still be consistent in numbering. Just save the file and then print/export it and the slide numbers will look like there were never any hidden slides ;).

### 3. VBE Theme color editor
A custom editor I found [here](https://github.com/dimitropoulos/VBECustomColors) on github. 
I added the dracula palette because that's what I'm currently using for cmd/powershell as well. It still needs some tweaking so I might change one or two things. If I switch to something else I'll also update this one (gruvbox, looking at you)


## Other program configs
*  [Dracula for Visual Studio](https://github.com/dracula/visual-studio)


## TODO
- [x] Try out [workspacer](https://www.workspacer.org/)
- [ ] Refine dracula theme for **VBE**


# Previously Used

### Autohotkey  
 A combination of a couple of autohotkey scripts and set-ups I gathered and modified. Uses the `VirtualDesktopAccessor.dll` and basically tries to emulate the `i3wm` setup I use on Linux.
The main purpose is for resizing windows (minimize & maximize) as well as moving them around my virtual desktops.

### [PowerToys](https://github.com/microsoft/PowerToys)
Here I use mostly `FancyZones` with the remaining stuff turned off. Same as the AHK scripts the idea is to emulate my i3wm setup. The zones here are supposed to substitute the tiling approach and while they do a decent job it's still not really what I am looking for.
