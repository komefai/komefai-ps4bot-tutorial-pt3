using PS4MacroAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExampleScript
{
    class InteractionMenu : Scene
    {
        public override string Name => "Interaction Menu";

        public static RectMap HeaderBar = new RectMap()
        {
            X = 52,
            Y = 111,
            Width = 224,
            Height = 73,
            Hash = 9223371914439753728
        };

        public static RectMap QuickGPS = new RectMap()
        {
            X = 51,
            Y = 186,
            Width = 137,
            Height = 19,
            Hash = 6953398460151201663
        };

        public override bool Match(ScriptBase script)
        {
            return script.MatchTemplate(HeaderBar, 95) && script.MatchTemplate(QuickGPS, 92);
        }

        public override void OnMatched(ScriptBase script)
        {
            script.Press(new DualShockState() { DPad_Right = true });
            script.Press(new DualShockState() { Cross = true });
        }
    }
}
