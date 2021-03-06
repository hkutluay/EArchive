namespace EArchive.XAdESv132
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("CompleteRevocationRefs", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class CompleteRevocationRefsType
    {
        private CRLRefType[] cRLRefsField;
        private OCSPRefType[] oCSPRefsField;
        private AnyType[] otherRefsField;
        private string idField;
        [System.Xml.Serialization.XmlArrayItemAttribute("CRLRef", IsNullable = false)]
        public CRLRefType[] CRLRefs
        {
            get
            {
                return this.cRLRefsField;
            }
            set
            {
                this.cRLRefsField = value;
            }
        }
        [System.Xml.Serialization.XmlArrayItemAttribute("OCSPRef", IsNullable = false)]
        public OCSPRefType[] OCSPRefs
        {
            get
            {
                return this.oCSPRefsField;
            }
            set
            {
                this.oCSPRefsField = value;
            }
        }
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherRef", IsNullable = false)]
        public AnyType[] OtherRefs
        {
            get
            {
                return this.otherRefsField;
            }
            set
            {
                this.otherRefsField = value;
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
}
