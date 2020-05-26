namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class aliciTypeTuzelKisi
    {

        private string vknField;

        private string unvanField;

        /// <remarks/>
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