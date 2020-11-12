using System;
using System.Linq;

namespace SillyTextAdventure.Scenes
{
    public static class SceneManager
    {
        public static void Init(Scene initialScene)
        {
            if (CurrentScene != null)
            {
                throw new InvalidOperationException("Init can only be called once.");
            }
            CurrentScene = initialScene;
        }

        public static InteractionResult AttemptInteraction(string action)
        {
            //TODO: handle interacting with objects within a scene
            var matchingInteractions = CurrentScene.InteractionResults.Where(x => x.Action == action).ToList();
            if (matchingInteractions.Any())
            {
                var interaction = matchingInteractions.First();
                switch (interaction.ResultingObject)
                {
                    case Scene scene:
                        CurrentScene = scene;
                        break;
                    default:
                        CurrentScene.AddInteractions(interaction.ResultingObject.InteractionResults);
                        break;
                }

                return matchingInteractions.First();
            }

            return null;
        }

        public static Scene CurrentScene { get; private set; }
    }
}