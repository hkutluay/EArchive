namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class aliciTypeMinTuzelKisi
    {

        private string vknField;

        private string unvanField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string vkn
        {
            get
            {
                return this.vknField;
            }
            set
            {
                this.vknField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string unvan
        {
            get
            {
                return this.unvanField;
            }
            set
            {
                this.unvanField = value;
            }
        }
    }
}