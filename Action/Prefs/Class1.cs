using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Prefs
{
    public class Prefs
    {
        string fileName;
        Dictionary<string,string> preferences = new Dictionary<string,string>();
        static Prefs instance = null; //the one and only instance of Prefs

        public static Prefs GetInstance(string fileName)
        {
            if (instance == null)
            {
                instance = new Prefs(fileName);
            }

            return instance;
             
        }

        private Prefs(string fileName)
        {
            this.fileName = fileName;

            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);
                foreach (string s in lines)
                {
                    string[] toks = s.Split('=');
                    preferences.Add(toks[0].Trim(), toks[1].Trim());
                }
            } else
            {
                File.Create(fileName).Close();
            }


        }

        public string Get(string preference)
        {
            if (preferences.ContainsKey(preference))
            {
                return preferences[preference];
            }
            return "";
        }

        public void Set(string key, string value)
        {
            preferences[key] = value;
        }

        public void Save()
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var pair in preferences)
                {
                    sw.WriteLine(pair.Key + "=" + pair.Value);
                }
            }
                


        }

    }
}
