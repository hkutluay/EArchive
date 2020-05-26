[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public partial class CertIDType
{
    private DigestAlgAndValueType certDigestField;
    private X509IssuerSerialType issuerSerialField;
    private string uRIField;
    public DigestAlgAndValueType CertDigest
    {
        get
        {
            return this.certDigestField;
        }
        set
        {
            this.certDigestField = value;
        }
    }
    public X509IssuerSerialType IssuerSerial
    {
        get
        {
            return this.issuerSerialField;
        }
        set
        {
            this.issuerSerialField = value;
        }
    }
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "anyURI")]
    public string URI
    {
        get
        {
            return this.uRIField;
        }
        set
        {
            this.uRIField = value;
        }
    }
}