namespace EArchive.XAdESv132
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("ObjectIdentifier", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class ObjectIdentifierType
    {
        private IdentifierType identifierField;
        private string descriptionField;
        private DocumentationReferencesType documentationReferencesField;
        public IdentifierType Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        public DocumentationReferencesType DocumentationReferences
        {
            get
            {
                return this.documentationReferencesField;
            }
            set
            {
                this.documentationReferencesField = value;
            }
        }
    }
}