namespace EArchive.XAdESv132
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("UnsignedProperties", Namespace = "http://uri.etsi.org/01903/v1.3.2#", IsNullable = false)]
    public partial class UnsignedPropertiesType
    {
        private UnsignedSignaturePropertiesType unsignedSignaturePropertiesField;
        private UnsignedDataObjectPropertiesType unsignedDataObjectPropertiesField;
        private string idField;
        public UnsignedSignaturePropertiesType UnsignedSignatureProperties
        {
            get
            {
                return this.unsignedSignaturePropertiesField;
            }
            set
            {
                this.unsignedSignaturePropertiesField = value;
            }
        }
        public UnsignedDataObjectPropertiesType UnsignedDataObjectProperties
        {
            get
            {
                return this.unsignedDataObjectPropertiesField;
            }
            set
            {
                this.unsignedDataObjectPropertiesField = value;
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