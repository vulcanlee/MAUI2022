using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace MA37;

public class Program : MauiApplication
{
    protected override MauiApp CreatePrismApp() => MauiProgram.CreatePrismApp();

    static void Main(string[] args)
    {
        var app = new Program();
        app.Run(args);
    }
}
