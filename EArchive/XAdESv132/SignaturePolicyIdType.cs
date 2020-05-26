//
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
public partial class SignaturePolicyIdType
{
    private ObjectIdentifierType sigPolicyIdField;
    private TransformType[] transformsField;
    private DigestAlgAndValueType sigPolicyHashField;
    private AnyType[] sigPolicyQualifiersField;
    public ObjectIdentifierType SigPolicyId
    {
        get
        {
            return this.sigPolicyIdField;
        }
        set
        {
            this.sigPolicyIdField = value;
        }
    }
    [System.Xml.Serialization.XmlArrayAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
    public TransformType[] Transforms
    {
        get
        {
            return this.transformsField;
        }
        set
        {
            this.transformsField = value;
        }
    }
    public DigestAlgAndValueType SigPolicyHash
    {
        get
        {
            return this.sigPolicyHashField;
        }
        set
        {
            this.sigPolicyHashField = value;
        }
    }
    [System.Xml.Serialization.XmlArrayItemAttribute("SigPolicyQualifier", IsNullable = false)]
    public AnyType[] SigPolicyQualifiers
    {
        get
        {
            return this.sigPolicyQualifiersField;
        }
        set
        {
            this.sigPolicyQualifiersField = value;
        }
    }
}