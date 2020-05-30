namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class kisiTypeTuzelKisi
    {
        private string vknField;
        private string unvanField;
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