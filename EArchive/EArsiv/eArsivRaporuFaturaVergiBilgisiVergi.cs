[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
public partial class eArsivRaporuFaturaVergiBilgisiVergi
{
    private decimal matrahField;
    private eArsivRaporuFaturaVergiBilgisiVergiVergiKodu vergiKoduField;
    private decimal vergiTutariField;
    private decimal vergiOraniField;
    private bool vergiOraniFieldSpecified;
    public decimal matrah
    {
        get
        {
            return this.matrahField;
        }
        set
        {
            this.matrahField = value;
        }
    }
    public eArsivRaporuFaturaVergiBilgisiVergiVergiKodu vergiKodu
    {
        get
        {
            return this.vergiKoduField;
        }
        set
        {
            this.vergiKoduField = value;
        }
    }
    public decimal vergiTutari
    {
        get
        {
            return this.vergiTutariField;
        }
        set
        {
            this.vergiTutariField = value;
        }
    }
    public decimal vergiOrani
    {
        get
        {
            return this.vergiOraniField;
        }
        set
        {
            this.vergiOraniField = value;
        }
    }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool vergiOraniSpecified
    {
        get
        {
            return this.vergiOraniFieldSpecified;
        }
        set
        {
            this.vergiOraniFieldSpecified = value;
        }
    }
}