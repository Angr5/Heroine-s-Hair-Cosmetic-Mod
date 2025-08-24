using Kitchen;
using KitchenMods;
using UnityEngine;

namespace KitchenHeroinesHair
{
    public class Mod : GameSystemBase, IModSystem
    {
        public const string MOD_GUID = "com.angr5.heroineshair";
        public const string MOD_NAME = "Heroines Hair";
        public const string MOD_VERSION = "0.1.0";
        public const string MOD_AUTHOR = " Angr5";

        protected override void Initialise()
        {
            LogWarning($"{MOD_GUID} v{MOD_VERSION} in use!");
        }

        protected override void OnUpdate()
        {
        }
        
        #region Logging
        internal static void LogInfo(string _log) { Debug.Log($"[{MOD_NAME}] " + _log); }
        internal static void LogWarning(string _log) { Debug.LogWarning($"[{MOD_NAME}] " + _log); }
        internal static void LogError(string _log) { Debug.LogError($"[{MOD_NAME}] " + _log); }
        #endregion
    }
}