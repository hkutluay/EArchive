namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivRaporuMustahsilMakbuzIptal
    {
        private string makbuzNoField;
        private System.DateTime iptalTarihiField;
        private decimal toplamTutarField;
        public string makbuzNo
        {
            get
            {
                return this.makbuzNoField;
            }
            set
            {
                this.makbuzNoField = value;
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