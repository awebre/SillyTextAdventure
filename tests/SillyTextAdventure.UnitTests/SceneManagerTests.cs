using Microsoft.VisualStudio.TestTools.UnitTesting;
using SillyTextAdventure.Scenes;

namespace SillyTextAdventure.UnitTests
{
    [TestClass]
    public class SceneManagerTests
    {
        [TestMethod]
        public void SceneManagerInit_SetsCurrentScene()
        {
            var scene = new Scene("initial scene", "You find yourself in a strange land.", null);
            SceneManager.Init(scene);

            Assert.AreEqual(scene, SceneManager.CurrentScene);
        }
    }
}
