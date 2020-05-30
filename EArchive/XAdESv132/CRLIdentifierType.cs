namespace EArchive.XAdESv132
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CRLIdentifierType
    {
        private string issuerField;
        private System.DateTime issueTimeField;
        private string numberField;
        private string uRIField;
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }
        public System.DateTime IssueTime
        {
            get
            {
                return this.issueTimeField;
            }
            set
            {
                this.issueTimeField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
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
}