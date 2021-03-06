namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivRaporuFaturaVergiBilgisi
    {
        private decimal vergilerToplamiField;
        private eArsivRaporuFaturaVergiBilgisiVergi[] vergiField;
        private eArsivRaporuFaturaVergiBilgisiTevkifat[] tevkifatField;
        public decimal vergilerToplami
        {
            get
            {
                return this.vergilerToplamiField;
            }
            set
            {
                this.vergilerToplamiField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute("vergi")]
        public eArsivRaporuFaturaVergiBilgisiVergi[] vergi
        {
            get
            {
                return this.vergiField;
            }
            set
            {
                this.vergiField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute("tevkifat")]
        public eArsivRaporuFaturaVergiBilgisiTevkifat[] tevkifat
        {
            get
            {
                return this.tevkifatField;
            }
            set
            {
                this.tevkifatField = value;
            }
        }
    }
}