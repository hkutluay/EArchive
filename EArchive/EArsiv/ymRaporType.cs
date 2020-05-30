namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class ymRaporType
    {
        private string ymRaporNoField;
        private ymRaporTypeMukellef mukellefField;
        private okcType okcField;
        private string okcAylikSatisRaporNoField;
        private satisType[] satisField;
        private ymRaporTypeBelgeTutar[] belgeTutarField;
        private ymRaporTypeOdemeTuruTutar[] odemeTuruTutarField;
        private adetTutarType[] bilgiFisField;
        public string ymRaporNo
        {
            get
            {
                return this.ymRaporNoField;
            }
            set
            {
                this.ymRaporNoField = value;
            }
        }
        public ymRaporTypeMukellef mukellef
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
        public okcType okc
        {
            get
            {
                return this.okcField;
            }
            set
            {
                this.okcField = value;
            }
        }
        public string okcAylikSatisRaporNo
        {
            get
            {
                return this.okcAylikSatisRaporNoField;
            }
            set
            {
                this.okcAylikSatisRaporNoField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute("satis")]
        public satisType[] satis
        {
            get
            {
                return this.satisField;
            }
            set
            {
                this.satisField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute("belgeTutar")]
        public ymRaporTypeBelgeTutar[] belgeTutar
        {
            get
            {
                return this.belgeTutarField;
            }
            set
            {
                this.belgeTutarField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute("odemeTuruTutar")]
        public ymRaporTypeOdemeTuruTutar[] odemeTuruTutar
        {
            get
            {
                return this.odemeTuruTutarField;
            }
            set
            {
                this.odemeTuruTutarField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute("bilgiFis")]
        public adetTutarType[] bilgiFis
        {
            get
            {
                return this.bilgiFisField;
            }
            set
            {
                this.bilgiFisField = value;
            }
        }
    }
}