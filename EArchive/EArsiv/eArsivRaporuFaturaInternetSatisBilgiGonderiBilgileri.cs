namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivRaporuFaturaInternetSatisBilgiGonderiBilgileri
    {
        private System.DateTime gonderimTarihiField;
        private kisiType gonderiTasiyanField;
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime gonderimTarihi
        {
            get
            {
                return this.gonderimTarihiField;
            }
            set
            {
                this.gonderimTarihiField = value;
            }
        }
        public kisiType gonderiTasiyan
        {
            get
            {
                return this.gonderiTasiyanField;
            }
            set
            {
                this.gonderiTasiyanField = value;
            }
        }
    }
}