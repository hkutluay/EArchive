# EArchive
![build & test](https://github.com/hkutluay/EArchive/workflows/build%20&%20test/badge.svg)

C# proxy classes to create and serialize .Net objects to Xml that conforms [Turkey E-Archive Invoice report](https://ebelge.gib.gov.tr/earsivmevzuat.html) standards or deserialize e-Archive documents to .Net objects.

First install UblTr NuGet package:
```
PM> Install-Package EArchive
```

## Serialize
```csharp
private static void Main(string[] args)
{
      var report = new eArsivRaporu
      {
        baslik = new baslikType()
        {
          bolumNo = 1,
          hazirlayan = new vknTcknType() { Item = "123456789" },
          raporNo = "2",
          versiyon = "1.0"
        }
      };


  XmlSerializer xmlSerializer = new XmlSerializer(typeof(eArsivRaporu));
  using TextWriter writer = new StreamWriter(@"C:\Temp\TestReport.xml"); //path to document
  xmlSerializer.Serialize(writer, report);
}

 ```
 
**Xml file content**
 ```xml
<?xml version="1.0" encoding="utf-8"?>
<eArsivRaporu xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://earsiv.efatura.gov.tr">
  <baslik>
    <versiyon>1.0</versiyon>
    <hazirlayan>
      <tckn>123456789</tckn>
    </hazirlayan>
    <raporNo>2</raporNo>
    <donemBaslangicTarihi>0001-01-01</donemBaslangicTarihi>
    <donemBitisTarihi>0001-01-01</donemBitisTarihi>
    <bolumBaslangicTarihi>0001-01-01</bolumBaslangicTarihi>
    <bolumBitisTarihi>0001-01-01</bolumBitisTarihi>
    <bolumNo>1</bolumNo>
  </baslik>
</eArsivRaporu>
 ```

## Deserialize
```csharp

var path = @"C:\report.xml"; // path to report document
XmlSerializer serializer = new XmlSerializer(typeof(eArsivRaporu));

using (StreamReader reader = new StreamReader(path))
{
      var report = (eArsivRaporu)serializer.Deserialize(reader);
}
 ```
 
