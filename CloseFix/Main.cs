using MelonLoader;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloseFix
{
    public static class BuildInfo
    {
        public const string Name = "CloseFix"; // Name of the Mod.  (MUST BE SET)
        public const string Author = "404#0004"; // Author of the Mod.  (Set as null if none)
        public const string Company = "I am not a company -Kappa-"; // Company that made the Mod.  (Set as null if none)
        public const string Version = "1.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = "https://github.com/l-404-l"; // Download Link for the Mod.  (Set as null if none)
    }

    public class CloseFix404 : MelonMod
    {
        public override void OnApplicationQuit()
        {
            CloseGameAfterConfig().GetAwaiter().GetResult();
        }

        public async Task CloseGameAfterConfig()
        {
            MelonModLogger.Log("Closing your game.");
            // Will add more for world glitching soon
            await Task.Delay(1000);
            Process.GetCurrentProcess().Kill();
        }
    }

}
