namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivRaporuSerbestMeslekMakbuzVergiBilgisiTevkifat
    {
        private string tevkifatKoduField;
        private decimal tevkifatTutariField;
        private decimal tevkifatOraniField;
        public string tevkifatKodu
        {
            get
            {
                return this.tevkifatKoduField;
            }
            set
            {
                this.tevkifatKoduField = value;
            }
        }
        public decimal tevkifatTutari
        {
            get
            {
                return this.tevkifatTutariField;
            }
            set
            {
                this.tevkifatTutariField = value;
            }
        }
        public decimal tevkifatOrani
        {
            get
            {
                return this.tevkifatOraniField;
            }
            set
            {
                this.tevkifatOraniField = value;
            }
        }
    }
}