using System.IO;
using BallisticSource.Mods;
using UnityEngine;

namespace BallisticNG.CodeMods
{
    public class CustomShieldRegister : ModRegister
    {
        public override void OnRegistered()
        {
            RegisterMod("my mod", "author", "1.0");
            GameObject customShield = new GameObject("[ my mod ]");
            Object.DontDestroyOnLoad(customShield);
            customShield.AddComponent<CustomShieldBehaviour>();
        }
    }

    public class CustomShieldBehaviour : MonoBehaviour
    {
        private void Start()
        {
            BallisticEvents.Race.OnShipSpawned += OnShipSpawned;
        }

        private void OnShipSpawned(ShipRefs ship)
        {
            ship.Effects.TargetShieldColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        }
    }
}