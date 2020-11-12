using System;

namespace SillyTextAdventure.Scenes
{
    public class InteractionResult
    {
        public InteractionResult(string action, string description, InteractiveObject resultingObject)
        {
            Action = action;
            Description = description;
            ResultingObject = resultingObject;
        }

        public string Action { get; }
        public string Description { get; }
        public InteractiveObject ResultingObject { get; }
    }
}