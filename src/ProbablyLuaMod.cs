using UnityEngine;

namespace ProbablyLua
{
    public sealed class ProbablyLuaMod : IMod
    {
        public void Init(ModManifest manifest)
        {
            ProbablyLuaSettings.Initialize(manifest.ID);
        }

        public void OnEnable()
        {
            ModHook.OnModAssetsLoaded += OnAssetsLoaded;
        }

        public void OnDisable()
        {
            ModHook.OnModAssetsLoaded -= OnAssetsLoaded;
        }

        private void OnAssetsLoaded(LoadedMod mod) { }
    }
}
