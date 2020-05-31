using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using EArchive.EArsiv;

namespace EArchive.Extensions
{
    public static class EArsivRaporuExtensions
    {
        public static void SaveXml(this eArsivRaporu report, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(eArsivRaporu));

            using (var writer = new StreamWriter(File.Create(path)))
            {
                xmlSerializer.Serialize(writer, report);
            }
        }
    }
}
