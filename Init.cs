using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Genshot.Settings;

namespace Genshot
{
    public static class Init
    {

        public static bool openGameFolderDiag()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (folderBrowserDialog.SelectedPath.ToLower().Contains("genshin impact\\genshin impact game"))
                {
                    // Display a message box to the user indicating that the folder selected was ok!
                    System.Windows.MessageBox.Show("Game folder set at: " + folderBrowserDialog.SelectedPath);
                    Settings.SetConfig("game_folder", folderBrowserDialog.SelectedPath);
                    return true;
                }
                else
                {
                    // Display a message box to the user
                    System.Windows.MessageBox.Show("Please select a folder under the game's folder!");
                    return false;
                }
            }
            return false;
        }

        public static JObject initSettings()
        {
            // Create a json file if it doesn't exist
            if (!File.Exists("settings.json"))
            {
                Settings.config = new JObject();
                File.WriteAllText("settings.json", "{}");
                return Settings.config;

            }
            else
            {
                // Read the json file
                string json = File.ReadAllText("settings.json");
                // Parse the json file
                Settings.config = JObject.Parse(json);

                return Settings.config;
            }
        }

    }
}
