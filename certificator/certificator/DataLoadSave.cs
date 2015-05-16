using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Sertificator
{
    public static class DataLoadSave
    {
        public static void SaveData <T>(T data)
        {
            var f = new SaveFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = File.Create(f.FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fileStream, data);
                fileStream.Close();
            }
        }

        public static void LoadData <T> (ref T data)
        {
            var f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = File.OpenRead(f.FileName);
                var deserializer = new BinaryFormatter();
                data = (T) deserializer.Deserialize(fileStream);
                fileStream.Close();
            }
        }
    }
}
