using System;

using EArchive.EArsiv;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Xml.Serialization;

using EArchive.Extensions;

namespace EArchive.Test
{
    [TestClass]
    public class EArchiveReportTest
    {
        private readonly string _reportPath;
        private readonly string _path;

        public EArchiveReportTest()
        {
            _path = "TestFiles/";
            _reportPath = $"{_path}d9f15872-1c78-4f7f-b025-a35816c80ab9.xml";
        }

        eArsivRaporu DeserializeEArsivRaporuXml(string path)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(eArsivRaporu));

            using (StreamReader reader = new StreamReader(path))
            {
                return (eArsivRaporu)serializer.Deserialize(reader);
            }
        }

        [TestMethod]
        public void DeserializeReport()
        {
            var report = DeserializeEArsivRaporuXml(_reportPath);
            Assert.AreEqual("d9f15872-1c78-4f7f-b025-a35816c80ab9", report.baslik.raporNo);
            Assert.AreEqual(9, report.Items.Length);
        }

        [TestMethod]
        public void SerializeReport()
        {
            eArsivRaporu report = GetSampleReport();


            XmlSerializer xmlSerializer = new XmlSerializer(typeof(eArsivRaporu));
            var stream = new MemoryStream();
            xmlSerializer.Serialize(stream, report);
            stream.Seek(0, SeekOrigin.Begin);


            var deserializedReport = (eArsivRaporu)xmlSerializer.Deserialize(stream);

            Assert.AreEqual(report.baslik.bolumNo, deserializedReport.baslik.bolumNo);
            Assert.AreEqual(report.baslik.raporNo, deserializedReport.baslik.raporNo);

        }

        private static eArsivRaporu GetSampleReport()
        {
            var report = new eArsivRaporu
            {
                baslik = new baslikType()
                {
                    bolumNo = 1,
                    hazirlayan = new vknTcknType() {Item = "123456789"},
                    raporNo = "2",
                    versiyon = "1.0"
                }
            };
            return report;
        }

        [TestMethod]
        public void SaveXmlShouldCreateFile()
        {
            var samplePathFile = $"{_path}{Guid.NewGuid().ToString()}.xml";

            var report = GetSampleReport();

            report.SaveXml(samplePathFile);

            var reportCreated = File.Exists(samplePathFile);

            Assert.IsTrue(reportCreated);

            File.Delete(samplePathFile);
        }
               
    }
}
