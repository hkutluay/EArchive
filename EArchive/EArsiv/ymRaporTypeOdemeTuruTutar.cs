//
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
public partial class ymRaporTypeOdemeTuruTutar
{
    private decimal tutarField;
    private odemeTuruTipEnum tipField;
    public decimal tutar
    {
        get
        {
            return this.tutarField;
        }
        set
        {
            this.tutarField = value;
        }
    }
    public odemeTuruTipEnum tip
    {
        get
        {
            return this.tipField;
        }
        set
        {
            this.tipField = value;
        }
    }
}