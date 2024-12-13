using BepInEx;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCHelloWorld
{
    [BepInPlugin(GUID, Name, Version)]
    public class HelloWorldPlugin : BaseUnityPlugin
    {
        private const string GUID = "23452f0b-701c-421d-a33b-4245e9657b80";
        private const string Name = "Hello World";
        private const string Version = "0.0.1";

        private readonly Harmony Harmony = new Harmony(GUID);

        private static HelloWorldPlugin Instance;

        void Awake()
        {
            if(Instance == null)
                Instance = this;

            Harmony.PatchAll(typeof(HelloWorldPlugin));
        }

    }
}
