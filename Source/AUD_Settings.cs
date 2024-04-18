using Verse;

namespace AUD
{
    public class AUD_Settings : ModSettings
    {
        public bool infiniteUnnaturalDarkness = false;

        public float minDuration = 6f;

        public float maxDuration = 8f;

        public int maxCount = 3;

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look(ref infiniteUnnaturalDarkness, "infiniteUnnaturalDarkness", defaultValue: false);
            Scribe_Values.Look(ref maxDuration, "maxDuration", defaultValue: 8f);
            Scribe_Values.Look(ref minDuration, "minDuration", defaultValue: 6f);
            Scribe_Values.Look(ref maxCount, "maxCount", defaultValue: 3);
        }
    }
}