using System;

namespace SillyTextAdventure.Scenes
{
    public class InteractiveObject
    {
        public InteractiveObject(string name, string description, InteractionResult[] interactionResults)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }
        public string Description { get; }

        public InteractionResult[] InteractionResults { get; set; }
    }
}