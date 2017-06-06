﻿using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                
                return ConfigureApp
                    .Android
                    .EnableLocalScreenshots()
                    .ApkFile("..\\..\\..\\MyRoadshowApp\\MyRoadshowApp.Android\\bin\\release\\MyRoadshowApp.Android.APK")
                    .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}

