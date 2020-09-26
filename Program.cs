using System;
using Terminal.Gui;

namespace SillyTextAdventure
{
    class Program
    {

        static bool Quit()
        {
            var answer = MessageBox.Query(50, 7, "Quit Game", "Are you sure you want to quit the game?", "Yes", "No");
            return answer == 0;
        }

        static void Main(string[] args)
        {
            Application.Init();
            var top = Application.Top;
            var topFrame = top.Frame;

            var window = new Window("Hello")
            {
                X = 0,
                Y = 1,
                Width = Dim.Fill(),
                Height = Dim.Fill() - 1
            };

            var menuBar = new MenuBar(new MenuBarItem[]{
                new MenuBarItem ("_Silly Text Adventure", new MenuItem[]{
                    new MenuItem("_Quit", "", () => {if(Quit()){
                        top.Running = false;
                    }})
                })
            });

            top.Add(window, menuBar);
            top.Add(menuBar);
            Application.Run();
        }
    }
}
