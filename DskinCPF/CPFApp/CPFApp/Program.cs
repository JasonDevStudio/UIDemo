using System;
using CPF.Platform;
using CPF.Windows;
#if !Net4
using CPF.Skia;
using CPF.Mac;//如果需要支持Mac才需要
using CPF.Linux;//如果需要支持Linux才需要

#endif

namespace CPFApp
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.Initialize(
#if Net4
               (OperatingSystemType.Windows, new WindowsPlatform(), new CPF.GDIPlus.GDIPlusDrawingFactory())
#else
                (OperatingSystemType.Windows, new WindowsPlatform(), new SkiaDrawingFactory()),
                (OperatingSystemType.OSX, new MacPlatform(), new SkiaDrawingFactory()),//如果需要支持Mac才需要
                (OperatingSystemType.Linux, new LinuxPlatform(), new SkiaDrawingFactory())//如果需要支持Linux才需要
#endif
            );
            Application.Run(new Window1(){ });
        }
    }
}
