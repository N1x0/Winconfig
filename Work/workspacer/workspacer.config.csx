#r "C:\Program Files\workspacer\workspacer.Shared.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.Bar\workspacer.Bar.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.ActionMenu\workspacer.ActionMenu.dll"
#r "C:\Program Files\workspacer\plugins\workspacer.FocusIndicator\workspacer.FocusIndicator.dll"

using System;
using System.IO;
using workspacer;
using workspacer.Bar;
using workspacer.ActionMenu;
using workspacer.FocusIndicator;


Action<IConfigContext> doConfig = (context) =>
{
    context.AddBar();
    context.AddFocusIndicator();
    var actionMenu = context.AddActionMenu();
    var sticky = new StickyWorkspaceContainer(context, StickyWorkspaceIndexMode.Local);
    var monitors = context.MonitorContainer.GetAllMonitors();
    context.WorkspaceContainer = sticky;
    // workspaces and layouts
    sticky.CreateWorkspaces(monitors[0], "Email", "Chat","Music");
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Outlook") ? context.WorkspaceContainer["Email"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Teams") ? context.WorkspaceContainer["Chat"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Spotify") ? context.WorkspaceContainer["Music"] : null);
    sticky.CreateWorkspaces(monitors[1], "Web", "Files", "Excel", "Word");
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Edge") ? context.WorkspaceContainer["Web"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Firefox") ? context.WorkspaceContainer["Web"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Excel") ? context.WorkspaceContainer["Excel"] : null);
    context.WindowRouter.AddRoute((window) => window.Title.Contains("Word") ? context.WorkspaceContainer["Word"] : null);


    //keybinds
    // var mod = KeyModifiers.Alt;
    //context.Keybinds.Subscribe(mod, Keys.F, () => System.Diagnostics.Process.Start("explorer.exe", @"C:\Users\Desktop"));
    //context.Keybinds.Subscribe(mod, Keys.B, () => System.Diagnostics.Process.Start(@"C:\Program Files\Mozilla Firefox\firefox.exe"));

};


return doConfig;