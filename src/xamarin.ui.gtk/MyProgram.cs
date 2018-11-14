﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace xamarin_rtsp_poc
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            
            Gtk.Application.Init();
            Forms.Init();

            var app = new App();
            var window = new FormsWindow();

            window.LoadApplication(app);
            window.SetApplicationTitle("Game of Life");
            window.Show();

            Gtk.Application.Run();
        }
    }
}