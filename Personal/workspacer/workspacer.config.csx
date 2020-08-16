#r "C:\Program Files\workspacer\workspacer.Shared.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.Bar\workspacer.Bar.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.ActionMenu\workspacer.ActionMenu.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.FocusIndicator\workspacer.FocusIndicator.dll"

using System;
using System.IO;
using workspacer;
using workspacer.Bar;
using workspacer.Bar.Widgets;
using workspacer.ActionMenu;
using workspacer.FocusIndicator;
 
// setting shortcut modifier key
var mod = KeyModifiers.Alt;

var barBack  = Color.Black;
var barFore = Color.Purple;


// creating custom Colors using the inbuilt Color Class
Color custom = new Color(0x3C, 0x3C, 0x3C); // hex codes
Color simplecustom = new Color(46,25,70); // integers

Action<IConfigContext> doConfig = (context) => {
    
context.AddBar(new BarPluginConfig(){
    BarTitle = "workspacer.Bar",
    BarHeight = 20,
    FontSize = 12,
    FontName = "Font Awesome",
    DefaultWidgetForeground = Color.White,
    DefaultWidgetBackground = Color.Black,
    Background = barBack,
    // adding left widgets to the left and right bar sections
    LeftWidgets = () => new IBarWidget[] { 
        new WorkspaceWidget(){
        WorkspaceHasFocusColor = Color.Purple,
        WorkspaceEmptyColor = Color.Gray,
        WorkspaceIndicatingBackColor = Color.Red,
        BlinkPeriod = 1000,
        },
        new TextWidget(":"),
        new TitleWidget(),
     },
        
    RightWidgets = () => new IBarWidget[] 
    { 
        new TimeWidget(1000,"dd/MM/yy  hh:mm tt"),
        new ActiveLayoutWidget() 
    },
});


context.AddFocusIndicator(new FocusIndicatorPluginConfig(){
    BorderColor = Color.Purple,
    BorderSize = 5,
    TimeToShow = 250,
});

  var actionMenu = context.AddActionMenu(new ActionMenuPluginConfig() {
    RegisterKeybind = true,
    KeybindMod = KeyModifiers.LAlt,
    KeybindKey = Keys.P,

    MenuTitle = "workspacer.ActionMenu",
    MenuHeight = 50,
    MenuWidth = 300,
    FontSize = 12,
    Matcher = new OrMatcher(new PrefixMatcher(), new ContiguousMatcher()),
    Background = barBack,
    Foreground = barFore,
});


// creating a submenu 
var subMenu = actionMenu.Create();
actionMenu.DefaultMenu.AddMenu("Programs", subMenu);
// adding items to the subMenu
subMenu.AddFreeForm("Files", (e) => System.Diagnostics.Process.Start("explorer.exe", @"C:\Users\Desktop"));
subMenu.AddFreeForm("Browser", (b) => System.Diagnostics.Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe"));
// keybind

// creating a sticky (persistent) layout configuration
var sticky = new StickyWorkspaceContainer(context, StickyWorkspaceIndexMode.Local);
context.WorkspaceContainer = sticky; 

// workspaces and layouts
sticky.CreateWorkspaces("Chat", "Web", "Working","Code", "Games", "Music", "Email");
context.WindowRouter.AddRoute((window) => window.Title.Contains("Outlook") ? context.WorkspaceContainer["Email"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("File Explorer") ? context.Workspaces.FocusedWorkspace : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("Discord") ? context.WorkspaceContainer["Chat"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("Visual Studio") ? context.WorkspaceContainer["Code"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("PowerShell") ? context.WorkspaceContainer["Code"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("cmd.exe") ? context.WorkspaceContainer["Code"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("Spotify") ? context.WorkspaceContainer["Music"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("Firefox") ? context.WorkspaceContainer["Web"] : null);
context.WindowRouter.AddRoute((window) => window.Title.Contains("Steam") ? context.WorkspaceContainer["Games"] : null);


// filters
context.WindowRouter.AddFilter((window) => !window.Title.Contains("Dota 2"));        

// program shortcuts/keybinds
context.Keybinds.Subscribe(mod | KeyModifiers.LShift, Keys.F, () => System.Diagnostics.Process.Start("explorer.exe", @"C:\Users\Desktop"));
context.Keybinds.Subscribe(mod, Keys.B, () => System.Diagnostics.Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe"), "Browser");

};

return doConfig;