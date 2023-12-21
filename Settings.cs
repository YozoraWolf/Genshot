using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Genshot
{
    // Create a Class Settings with getters and setters
    public static class Settings
    {

        // Create a JObject to store the settings and setter that saves the object to the settings.json file
        public static JObject? config { get; set; }

        // Make a custom SetConfig method that takes argument key, value and saves the config to the settings.json file
        public static void SetConfig(string key, string value)
        {
            // Set the key to the value
            if (!config.ContainsKey(key)) config.Add(key, value);
            else config[key] = value;
            // Save the config to the settings.json file
            System.IO.File.WriteAllText("settings.json", config.ToString());
        }

    }
}
