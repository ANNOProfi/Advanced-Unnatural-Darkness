using System;
using UnityEngine;
using Verse;

namespace AUD
{
    public class AUDMod : Mod
    {
        private AUD_Settings settings;

        private string minDurationBuffer = "";

        private string maxDurationBuffer = "";

        private int minDuration = 6;

        private int maxDuration = 8;

        private bool initialised = false;

        public AUDMod(ModContentPack content) : base(content)
        {
            settings = GetSettings<AUD_Settings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();

            listing_Standard.Begin(inRect);

            listing_Standard.Gap(10f);
            listing_Standard.Label("AUD.Settings.MinDuration".Translate(minDuration), -1, "AUD.Settings.MinDurationDesc".Translate());
            listing_Standard.IntEntry(ref minDuration, ref minDurationBuffer);
            if(!initialised)
            {
                minDuration = 6;
            }
            settings.minDuration = minDuration;
            minDurationBuffer = minDuration.ToString();

            listing_Standard.Gap(10f);
            listing_Standard.Label("AUD.Settings.MaxDuration".Translate(maxDuration), -1, "AUD.Settings.MaxDurationDesc".Translate());
            listing_Standard.IntEntry(ref maxDuration, ref maxDurationBuffer);
            if(!initialised)
            {
                minDuration = 8;
            }
            else
            {
                maxDuration = Math.Max(maxDuration, minDuration);
            }
            settings.maxDuration = maxDuration;
            maxDurationBuffer = maxDuration.ToString();

            listing_Standard.Gap(10f);
            listing_Standard.CheckboxLabeled("AUD.Settings.InfiniteUD".Translate(), ref settings.infiniteUnnaturalDarkness, "AUD.Settings.InfiniteUDDesc".Translate());

            listing_Standard.End();

            if(!initialised)
            {
                initialised = true;
            }
        }

        public override string SettingsCategory()
        {
            return "Advanced Unnatural Darkness";
        }
    }
}