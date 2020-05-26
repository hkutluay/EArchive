[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
public partial class eArsivRaporuMustahsilMakbuz
{
    private string makbuzNoField;
    private string dosyaAdiField;
    private string ozetDegerField;
    private System.DateTime duzenlenmeTarihiField;
    private System.DateTime duzenlenmeZamaniField;
    private decimal toplamTutarField;
    private decimal odenecekTutarField;
    private eArsivRaporuMustahsilMakbuzParaBirimi paraBirimiField;
    private eArsivRaporuMustahsilMakbuzVergiBilgisi vergiBilgisiField;
    private aliciTypeMin mustahsilBilgileriField;
    private eArsivRaporuMustahsilMakbuzYnOkcFisBilgisi[] ynOkcFisBilgisiField;
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
    public eArsivRaporuMustahsilMakbuzParaBirimi paraBirimi
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
    public eArsivRaporuMustahsilMakbuzVergiBilgisi vergiBilgisi
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
    public aliciTypeMin mustahsilBilgileri
    {
        get
        {
            return this.mustahsilBilgileriField;
        }
        set
        {
            this.mustahsilBilgileriField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("ynOkcFisBilgisi")]
    public eArsivRaporuMustahsilMakbuzYnOkcFisBilgisi[] ynOkcFisBilgisi
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