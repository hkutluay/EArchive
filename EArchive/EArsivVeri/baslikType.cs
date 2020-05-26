namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class baslikType
    {

        private vknTcknType mukellefField;

        private vknTcknType hazirlayanField;

        /// <remarks/>
        public vknTcknType mukellef
        {
            get
            {
                return this.mukellefField;
            }
            set
            {
                this.mukellefField = value;
            }
        }

        /// <remarks/>
        public vknTcknType hazirlayan
        {
            get
            {
                return this.hazirlayanField;
            }
            set
            {
                this.hazirlayanField = value;
            }
        }
    }
}