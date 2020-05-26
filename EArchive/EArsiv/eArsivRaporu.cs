[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://earsiv.efatura.gov.tr", IsNullable = false)]
public partial class eArsivRaporu
{
    private baslikType baslikField;
    private object[] itemsField;
    public baslikType baslik
    {
        get
        {
            return this.baslikField;
        }
        set
        {
            this.baslikField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("fatura", typeof(eArsivRaporuFatura))]
    [System.Xml.Serialization.XmlElementAttribute("faturaIptal", typeof(eArsivRaporuFaturaIptal))]
    [System.Xml.Serialization.XmlElementAttribute("mRapor", typeof(mRaporType))]
    [System.Xml.Serialization.XmlElementAttribute("mustahsilMakbuz", typeof(eArsivRaporuMustahsilMakbuz))]
    [System.Xml.Serialization.XmlElementAttribute("mustahsilMakbuzIptal", typeof(eArsivRaporuMustahsilMakbuzIptal))]
    [System.Xml.Serialization.XmlElementAttribute("serbestMeslekMakbuz", typeof(eArsivRaporuSerbestMeslekMakbuz))]
    [System.Xml.Serialization.XmlElementAttribute("serbestMeslekMakbuzIptal", typeof(eArsivRaporuSerbestMeslekMakbuzIptal))]
    [System.Xml.Serialization.XmlElementAttribute("ymRapor", typeof(ymRaporType))]
    public object[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }
}