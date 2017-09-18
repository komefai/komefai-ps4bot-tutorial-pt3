using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleScript
{
    public class Script : ScriptBase
    {
        /* Constructor */
        public Script()
        {
            Config.Name = "Example Script";
            Config.Scenes = new List<Scene>()
            {
                new InteractionMenu()
            };
        }

        public override void Start()
        {
            base.Start();
        }

        public override void Update()
        {
            HandleScenes(scene =>
            {
                Console.WriteLine(scene.Name);
            });
        }
    }
}
