namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class vergiType
    {
        private vergiTipEnum vergiAdiField;
        private decimal vergiTutarField;
        public vergiTipEnum vergiAdi
        {
            get
            {
                return this.vergiAdiField;
            }
            set
            {
                this.vergiAdiField = value;
            }
        }
        public decimal vergiTutar
        {
            get
            {
                return this.vergiTutarField;
            }
            set
            {
                this.vergiTutarField = value;
            }
        }
    }
}