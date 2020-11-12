using System;
using Terminal.Gui;
using SillyTextAdventure.Scenes;

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

            var window = new Window("Welcome to Silly Text Adventure!")
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

            SceneManager.Init(new Scene("init scene", "You find yourself awake in a clearing, surrounded by forest. Where will you explore first?", null));
            window.Add(new Label(SceneManager.CurrentScene.Description));

            top.Add(window, menuBar);
            top.Add(menuBar);
            Application.Run();
        }
    }
}
