namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivRaporuFaturaIptal
    {
        private string faturaNoField;
        private System.DateTime iptalTarihiField;
        private decimal toplamTutarField;
        public string faturaNo
        {
            get
            {
                return this.faturaNoField;
            }
            set
            {
                this.faturaNoField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime iptalTarihi
        {
            get
            {
                return this.iptalTarihiField;
            }
            set
            {
                this.iptalTarihiField = value;
            }
        }
        public decimal toplamTutar
        {
            get
            {
                return this.toplamTutarField;
            }
            set
            {
                this.toplamTutarField = value;
            }
        }
    }
}