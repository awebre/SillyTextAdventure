using System;
using System.Linq;

namespace SillyTextAdventure.Scenes
{
    public class Scene : InteractiveObject
    {
        public Scene(
            string name,
            string description,
            InteractionResult[] interactionResults,
            InteractiveObject[] interactiveObjects = null) : base(name, description, interactionResults)
        {
            SceneObjects = interactiveObjects;
        }

        public void AddInteractions(InteractionResult[] interactions)
        {
            InteractionResults = InteractionResults.Concat(interactions).ToArray();
        }

        public InteractiveObject[] SceneObjects { get; }
    }
}