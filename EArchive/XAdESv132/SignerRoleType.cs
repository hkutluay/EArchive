namespace EArchive.XAdESv132
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("SignerRole", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class SignerRoleType
    {
        private AnyType[] claimedRolesField;
        private EncapsulatedPKIDataType[] certifiedRolesField;
        [System.Xml.Serialization.XmlArrayItemAttribute("ClaimedRole", IsNullable = false)]
        public AnyType[] ClaimedRoles
        {
            get
            {
                return this.claimedRolesField;
            }
            set
            {
                this.claimedRolesField = value;
            }
        }
        [System.Xml.Serialization.XmlArrayItemAttribute("CertifiedRole", IsNullable = false)]
        public EncapsulatedPKIDataType[] CertifiedRoles
        {
            get
            {
                return this.certifiedRolesField;
            }
            set
            {
                this.certifiedRolesField = value;
            }
        }
    }
}