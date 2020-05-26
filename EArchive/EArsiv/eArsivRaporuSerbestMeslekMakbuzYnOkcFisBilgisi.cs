//
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
public partial class eArsivRaporuSerbestMeslekMakbuzYnOkcFisBilgisi
{
    private string okcSeriNoField;
    private string zNoField;
    private string fisNoField;
    private eArsivRaporuSerbestMeslekMakbuzYnOkcFisBilgisiFisTip fisTipField;
    private System.DateTime fisTarihField;
    private System.DateTime fisZamanField;
    private bool fisZamanFieldSpecified;
    public string okcSeriNo
    {
        get
        {
            return this.okcSeriNoField;
        }
        set
        {
            this.okcSeriNoField = value;
        }
    }
    public string zNo
    {
        get
        {
            return this.zNoField;
        }
        set
        {
            this.zNoField = value;
        }
    }
    public string fisNo
    {
        get
        {
            return this.fisNoField;
        }
        set
        {
            this.fisNoField = value;
        }
    }
    public eArsivRaporuSerbestMeslekMakbuzYnOkcFisBilgisiFisTip fisTip
    {
        get
        {
            return this.fisTipField;
        }
        set
        {
            this.fisTipField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime fisTarih
    {
        get
        {
            return this.fisTarihField;
        }
        set
        {
            this.fisTarihField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
    public System.DateTime fisZaman
    {
        get
        {
            return this.fisZamanField;
        }
        set
        {
            this.fisZamanField = value;
        }
    }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool fisZamanSpecified
    {
        get
        {
            return this.fisZamanFieldSpecified;
        }
        set
        {
            this.fisZamanFieldSpecified = value;
        }
    }
}