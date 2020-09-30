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
            var name = "Dave's Init Scene";
            var description = "You have entered Dave's Lair.";
            var interactionResults = new InteractionResult[]{
                new InteractionResult("west", "There is nothing to the west, you go back to the center of the room.", null),
                new InteractionResult("east", "To the east of the room is Dave's Laptop, it's password protected.", new InteractiveObject("Dave's Laptop", "It's password protected", null))
            };
            CurrentScene = new Scene(name, description, interactionResults);
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