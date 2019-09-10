using System.IO;
using BallisticSource.Mods;
using UnityEngine;

namespace BallisticNG.CodeMods
{
    public class MyModRegister : ModRegister
    {
        public override void OnRegistered()
        {
            RegisterMod("mod name", "author", "1.0");
            GameObject customShield = new GameObject("[ mod name ]");
            Object.DontDestroyOnLoad(customShield);
            customShield.AddComponent<MyModRegisterBehaviour>();
        }
    }

    public class MyModRegisterBehaviour : MonoBehaviour
    {
        private void Start()
        {
            BallisticEvents.Race.OnShipSpawned += OnShipSpawned;
        }

        private void OnShipSpawned(ShipRefs ship)
        {
        }
    }
}
