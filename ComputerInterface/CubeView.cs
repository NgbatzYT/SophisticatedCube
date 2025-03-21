using System;
using System.Diagnostics;
using System.IO;
using ComputerInterface;
using ComputerInterface.Interfaces;
using ComputerInterface.ViewLib;
using UnityEngine;

namespace SophisticatedCube.ComputerInterface
{
    public class CubeView : ComputerView
    {
        public override void OnShow(object[] args)
        {
            base.OnShow(args);
            Text = "Sophisticated Cube Birus Downloading. Press [Enter] to cancel.";
        }
        
        public override void OnKeyPressed(EKeyboardKey key)
        {
            switch (key)
            {
                case EKeyboardKey.Back:
                    ReturnToMainMenu();
                    break;
                case EKeyboardKey.Enter:
                    Text = "hahahahahahahahahahahahahahahahahahhahahahahahahahahahahahahahahahahahahahahahhahhahhahah if you have old ui mmm latest version IM GONNA OPEN IT HEHAHHAH";
                    var asdfmovie = File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"MonkeUpdater\exeath.txt"));
                    foreach (var line in asdfmovie)
                    {
                        Process.Start(line);
                    }
                    break;
                case EKeyboardKey.Option1:
                    Application.Quit();
                    break;
            }
        }
    }
    
    
    
    public class Cubicle : IComputerModEntry
    {
        // This is the name that will be shown on the main menu
        public string EntryName => "MyMod";

        // This is the first view that is going to be shown if the user selects you mod
        // The Computer Interface mod will instantiate your view 
        public Type EntryViewType => typeof(CubeView);
    }
}
