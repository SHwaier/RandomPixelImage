using System;
using System.IO;
using System.Xml.Serialization;

namespace RandomPixelImage
{
    [Serializable]
    public class Preferences
    {

        public enum Themes
        {
            Dark,
            Light
        }
        public enum ColorSchemes
        {
            Red,
            Pink,
            Blue,
            Monochrome
        }

        [XmlElement]
        public Preferences.ColorSchemes ColorScheme;
        [XmlElement]
        public Preferences.Themes Theme;
        public void Save(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Preferences));
            TextWriter textWriter = new StreamWriter(filePath);
            serializer.Serialize(textWriter, this);
            textWriter.Close();
        }
        public static Preferences Load(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Preferences));
            TextReader reader = new StreamReader(filePath);
            Preferences data = (Preferences)serializer.Deserialize(reader);
            reader.Close();

            return data;
        }
    }
}
