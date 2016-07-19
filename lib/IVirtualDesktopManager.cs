﻿// Port from https://github.com/Grabacr07/VirtualDesktop
using System;
using System.Runtime.InteropServices;

namespace LTCountDownTimer.lib
{
    [ComImport]
    [Guid("a5cd92ff-29be-454c-8d04-d82879fb3f1b")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IVirtualDesktopManager
    {
        bool IsWindowOnCurrentVirtualDesktop(IntPtr topLevelWindow);

        Guid GetWindowDesktopId(IntPtr topLevelWindow);

        void MoveWindowToDesktop(IntPtr topLevelWindow, ref Guid desktopId);
    }
}
