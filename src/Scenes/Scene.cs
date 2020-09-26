using System;

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

        public InteractiveObject[] SceneObjects { get; }
    }
}