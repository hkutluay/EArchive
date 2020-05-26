//
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
[System.Xml.Serialization.XmlRootAttribute("SignedInfo", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
public partial class SignedInfoType
{
    private CanonicalizationMethodType canonicalizationMethodField;
    private SignatureMethodType signatureMethodField;
    private ReferenceType[] referenceField;
    private string idField;
    public CanonicalizationMethodType CanonicalizationMethod
    {
        get
        {
            return this.canonicalizationMethodField;
        }
        set
        {
            this.canonicalizationMethodField = value;
        }
    }
    public SignatureMethodType SignatureMethod
    {
        get
        {
            return this.signatureMethodField;
        }
        set
        {
            this.signatureMethodField = value;
        }
    }
    [System.Xml.Serialization.XmlElementAttribute("Reference")]
    public ReferenceType[] Reference
    {
        get
        {
            return this.referenceField;
        }
        set
        {
            this.referenceField = value;
        }
    }
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
    public string Id
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}