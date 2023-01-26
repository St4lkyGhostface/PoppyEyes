using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Net;

namespace PoppyEyes
{
    internal class Modifier
    {
        public static string PATH;

        // Gets the game's local save file directory
        public static void GetPath()
        {
            PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Playtime_Multiplayer\\Saved\\SaveGames");
            if (!Directory.Exists(PATH))
            {
                MessageBox.Show("Could not find PROJECT: PLAYTIME's directory, make sure you've installed the game, and have launched it at least once!", "Game not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

        }

        // Class that does the modding "magic" - Downloads the modded save file from the infinity server, and overwrites the game's local one
        public static void Mod(string SERVER_FILE_NAME, string LOCAL_FILE_NAME, string MODIFICATION_NAME)
        {
            
            WebClient client = new WebClient();
            client.DownloadFile("https://cdn.infinitygg.net/store/poppy/" + SERVER_FILE_NAME, (Path.Combine(PATH, LOCAL_FILE_NAME)));
            MessageBox.Show("Done! " + MODIFICATION_NAME + " have/has been modded successfully.", "Throw me a tip at infinitygg.net/tip - Enjoy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
