//
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
public partial class mRaporType
{
    private string mRaporNoField;
    private string okcSicilNoField;
    private decimal satisTutarField;
    private vergiType[] vergiField;
    public string mRaporNo
    {
        get
        {
            return this.mRaporNoField;
        }
        set
        {
            this.mRaporNoField = value;
        }
    }
    public string okcSicilNo
    {
        get
        {
            return this.okcSicilNoField;
        }
        set
        {
            this.okcSicilNoField = value;
        }
    }
    public decimal satisTutar
    {
        get
        {
            return this.satisTutarField;
        }
        set
        {
            this.satisTutarField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("vergi")]
    public vergiType[] vergi
    {
        get
        {
            return this.vergiField;
        }
        set
        {
            this.vergiField = value;
        }
    }
}