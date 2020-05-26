[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
public partial class eArsivRaporuSerbestMeslekMakbuz
{
    private string makbuzNoField;
    private eArsivRaporuSerbestMeslekMakbuzGonderimSekli gonderimSekliField;
    private string dosyaAdiField;
    private string ozetDegerField;
    private System.DateTime duzenlenmeTarihiField;
    private System.DateTime duzenlenmeZamaniField;
    private bool duzenlenmeZamaniFieldSpecified;
    private decimal toplamTutarField;
    private decimal odenecekTutarField;
    private eArsivRaporuSerbestMeslekMakbuzParaBirimi paraBirimiField;
    private eArsivRaporuSerbestMeslekMakbuzVergiBilgisi vergiBilgisiField;
    private aliciTypeMin aliciBilgileriField;
    private eArsivRaporuSerbestMeslekMakbuzYnOkcFisBilgisi[] ynOkcFisBilgisiField;
    public string makbuzNo
    {
        get
        {
            return this.makbuzNoField;
        }
        set
        {
            this.makbuzNoField = value;
        }
    }
    public eArsivRaporuSerbestMeslekMakbuzGonderimSekli gonderimSekli
    {
        get
        {
            return this.gonderimSekliField;
        }
        set
        {
            this.gonderimSekliField = value;
        }
    }
    public string dosyaAdi
    {
        get
        {
            return this.dosyaAdiField;
        }
        set
        {
            this.dosyaAdiField = value;
        }
    }
    public string ozetDeger
    {
        get
        {
            return this.ozetDegerField;
        }
        set
        {
            this.ozetDegerField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime duzenlenmeTarihi
    {
        get
        {
            return this.duzenlenmeTarihiField;
        }
        set
        {
            this.duzenlenmeTarihiField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
    public System.DateTime duzenlenmeZamani
    {
        get
        {
            return this.duzenlenmeZamaniField;
        }
        set
        {
            this.duzenlenmeZamaniField = value;
        }
    }
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool duzenlenmeZamaniSpecified
    {
        get
        {
            return this.duzenlenmeZamaniFieldSpecified;
        }
        set
        {
            this.duzenlenmeZamaniFieldSpecified = value;
        }
    }
    public decimal toplamTutar
    {
        get
        {
            return this.toplamTutarField;
        }
        set
        {
            this.toplamTutarField = value;
        }
    }
    public decimal odenecekTutar
    {
        get
        {
            return this.odenecekTutarField;
        }
        set
        {
            this.odenecekTutarField = value;
        }
    }
    public eArsivRaporuSerbestMeslekMakbuzParaBirimi paraBirimi
    {
        get
        {
            return this.paraBirimiField;
        }
        set
        {
            this.paraBirimiField = value;
        }
    }
    public eArsivRaporuSerbestMeslekMakbuzVergiBilgisi vergiBilgisi
    {
        get
        {
            return this.vergiBilgisiField;
        }
        set
        {
            this.vergiBilgisiField = value;
        }
    }
    public aliciTypeMin aliciBilgileri
    {
        get
        {
            return this.aliciBilgileriField;
        }
        set
        {
            this.aliciBilgileriField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("ynOkcFisBilgisi")]
    public eArsivRaporuSerbestMeslekMakbuzYnOkcFisBilgisi[] ynOkcFisBilgisi
    {
        get
        {
            return this.ynOkcFisBilgisiField;
        }
        set
        {
            this.ynOkcFisBilgisiField = value;
        }
    }
}