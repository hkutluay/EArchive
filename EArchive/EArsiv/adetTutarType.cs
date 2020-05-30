namespace EArchive.EArsiv
{

    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class adetTutarType
    {
        private decimal tutarField;
        private string adetField;
        private bilgiFisTipEnum tipField;
        public decimal tutar
        {
            get
            {
                return this.tutarField;
            }
            set
            {
                this.tutarField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "integer")]
        public string adet
        {
            get
            {
                return this.adetField;
            }
            set
            {
                this.adetField = value;
            }
        }
        public bilgiFisTipEnum tip
        {
            get
            {
                return this.tipField;
            }
            set
            {
                this.tipField = value;
            }
        }
    }
}