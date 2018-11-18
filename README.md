# Xamarin GTK#

I found it surprisingly cheeky to configure a Xamarin Forms project, for a desktop application, that compiles and runs on both Windows and Linux. I hope my efforts are helpful to you.

## Was this repo helpful? Leave a star!

Feel free to take this code and use it how you see fit. It is [unlicensed](#license)! Leaving a star tells me it was useful to you.

## Building on Linux

I am running on Ubuntu Bionic. These steps worked for me. Your mileage may vary.

1. Install Mono. I recommend following the steps for your Linux distro [here](https://www.mono-project.com/download/stable/). You will want to install the `mono-complete` package.
2. Install NuGet. `sudo apt-get install nuget`. This will pull the nuget package from the `stable-bionic` mono repository as set in `/etc/apt/sources.list.d/mono-official-stable.list`
3. Navigate into the location where you cloned this repository.
4. Restore the NuGet packages: `nuget restore`
5. Build the code: `msbuild`
6. Run the program: `mono src/xamarin.ui.gtk/bin/Debug/xamarin_rtsp_poc.gtk.exe`

I also used `Visual Studio Code` and `MonoDevelop` to edit the code on Linux.

## Building on Windows

I am running on Windows 10 Pro with Visual Studio Code 2017 CE. 

1. Install [Visual Studio 2017](https://visualstudio.microsoft.com/vs/community)
2. Install [GTK# for .NET](https://www.mono-project.com/docs/gui/gtksharp/installer-for-net-framework)
3. Set `xamarin.ui.gtk` as the start-up project
4. Build & Run the program.

This setup works with .NET v4.7 and Xamarin Forms v3.3.0.967583 on Windows 10, with Visual Studio 2017. I also used `Visual Studio Code` on Windows, as it is really nice to be able to manipulate the project files directly.

## Contributing

I accept pull requests, just be aware of the permissive nature of the license.

# License

[The Unlicense](./LICENSE)
