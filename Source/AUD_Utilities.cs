using Verse;

namespace AUD
{
    public static class AUD_Utilities
    {
        public static AUD_Settings Settings => LoadedModManager.GetMod<AUDMod>().GetSettings<AUD_Settings>();
    }
}