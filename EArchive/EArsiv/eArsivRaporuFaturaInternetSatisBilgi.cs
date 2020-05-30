namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivRaporuFaturaInternetSatisBilgi
    {
        private string webAdresiField;
        private string odemeSekliField;
        private string odemeAracisiAdiField;
        private System.DateTime odemeTarihiField;
        private bool odemeTarihiFieldSpecified;
        private eArsivRaporuFaturaInternetSatisBilgiGonderiBilgileri gonderiBilgileriField;
        public string webAdresi
        {
            get
            {
                return this.webAdresiField;
            }
            set
            {
                this.webAdresiField = value;
            }
        }
        public string odemeSekli
        {
            get
            {
                return this.odemeSekliField;
            }
            set
            {
                this.odemeSekliField = value;
            }
        }
        public string odemeAracisiAdi
        {
            get
            {
                return this.odemeAracisiAdiField;
            }
            set
            {
                this.odemeAracisiAdiField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime odemeTarihi
        {
            get
            {
                return this.odemeTarihiField;
            }
            set
            {
                this.odemeTarihiField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool odemeTarihiSpecified
        {
            get
            {
                return this.odemeTarihiFieldSpecified;
            }
            set
            {
                this.odemeTarihiFieldSpecified = value;
            }
        }
        public eArsivRaporuFaturaInternetSatisBilgiGonderiBilgileri gonderiBilgileri
        {
            get
            {
                return this.gonderiBilgileriField;
            }
            set
            {
                this.gonderiBilgileriField = value;
            }
        }
    }
}