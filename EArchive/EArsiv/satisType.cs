//
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
public partial class satisType
{
    private vergiTipEnum vergiAdiField;
    private decimal vergiTutarField;
    private satisTypeVergiDetay[] vergiDetayField;
    public vergiTipEnum vergiAdi
    {
        get
        {
            return this.vergiAdiField;
        }
        set
        {
            this.vergiAdiField = value;
        }
    }
    public decimal vergiTutar
    {
        get
        {
            return this.vergiTutarField;
        }
        set
        {
            this.vergiTutarField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("vergiDetay")]
    public satisTypeVergiDetay[] vergiDetay
    {
        get
        {
            return this.vergiDetayField;
        }
        set
        {
            this.vergiDetayField = value;
        }
    }
}