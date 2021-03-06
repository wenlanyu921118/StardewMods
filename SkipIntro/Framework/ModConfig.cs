namespace Pathoschild.Stardew.SkipIntro.Framework
{
    /// <summary>The mod configuration.</summary>
    internal class ModConfig
    {
        /*********
        ** Accessors
        *********/
        /// <summary>Whether to check for updates to the mod.</summary>
        public bool CheckForUpdates { get; set; } = true;

        /// <summary>Whether to skip directly to the loading screen.</summary>
        public bool SkipToLoadScreen { get; set; } = true;
    }
}