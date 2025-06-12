using BepInEx;
using BepInEx.Unity.IL2CPP;

using UnityEngine;

using Cardboard.Utils;
using Cardboard.Internals;

namespace Cardboard.Start
{
    [BepInPlugin("bingus.cbcapuchin", "CB_Capuchin", "1.0.0")]
    public class Bootstrap : BasePlugin
    {
        public static Bootstrap instance;

        public override void Load()
        {
            instance = this;

            CardboardHarmony.PatchInstance("bingus.cbcapuchin");
            new GameObject("CardboardManager").AddComponent<CardboardManager>();
        }
    }
}