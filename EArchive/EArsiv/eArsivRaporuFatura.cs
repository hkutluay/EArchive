namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivRaporuFatura
    {
        private string faturaNoField;
        private eArsivRaporuFaturaGonderimSekli gonderimSekliField;
        private string dosyaAdiField;
        private string ozetDegerField;
        private System.DateTime duzenlenmeTarihiField;
        private System.DateTime duzenlenmeZamaniField;
        private decimal toplamTutarField;
        private decimal odenecekTutarField;
        private eArsivRaporuFaturaParaBirimi paraBirimiField;
        private eArsivRaporuFaturaVergiBilgisi vergiBilgisiField;
        private aliciType aliciBilgileriField;
        private eArsivRaporuFaturaInternetSatisBilgi internetSatisBilgiField;
        private eArsivRaporuFaturaYnOkcFisBilgisi[] ynOkcFisBilgisiField;
        private System.DateTime imzaZamaniField;
        private bool imzaZamaniFieldSpecified;
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
        public eArsivRaporuFaturaGonderimSekli gonderimSekli
        {
            get
            {
                return this.gonderimSekliField;
            }
            set
            {
                this.gonderimSekliField = value;
            }
        }
        public string dosyaAdi
        {
            get
            {
                return this.dosyaAdiField;
            }
            set
            {
                this.dosyaAdiField = value;
            }
        }
        public string ozetDeger
        {
            get
            {
                return this.ozetDegerField;
            }
            set
            {
                this.ozetDegerField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime duzenlenmeTarihi
        {
            get
            {
                return this.duzenlenmeTarihiField;
            }
            set
            {
                this.duzenlenmeTarihiField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime duzenlenmeZamani
        {
            get
            {
                return this.duzenlenmeZamaniField;
            }
            set
            {
                this.duzenlenmeZamaniField = value;
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
        public decimal odenecekTutar
        {
            get
            {
                return this.odenecekTutarField;
            }
            set
            {
                this.odenecekTutarField = value;
            }
        }
        public eArsivRaporuFaturaParaBirimi paraBirimi
        {
            get
            {
                return this.paraBirimiField;
            }
            set
            {
                this.paraBirimiField = value;
            }
        }
        public eArsivRaporuFaturaVergiBilgisi vergiBilgisi
        {
            get
            {
                return this.vergiBilgisiField;
            }
            set
            {
                this.vergiBilgisiField = value;
            }
        }
        public aliciType aliciBilgileri
        {
            get
            {
                return this.aliciBilgileriField;
            }
            set
            {
                this.aliciBilgileriField = value;
            }
        }
        public eArsivRaporuFaturaInternetSatisBilgi internetSatisBilgi
        {
            get
            {
                return this.internetSatisBilgiField;
            }
            set
            {
                this.internetSatisBilgiField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute("ynOkcFisBilgisi")]
        public eArsivRaporuFaturaYnOkcFisBilgisi[] ynOkcFisBilgisi
        {
            get
            {
                return this.ynOkcFisBilgisiField;
            }
            set
            {
                this.ynOkcFisBilgisiField = value;
            }
        }
        public System.DateTime imzaZamani
        {
            get
            {
                return this.imzaZamaniField;
            }
            set
            {
                this.imzaZamaniField = value;
            }
        }
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool imzaZamaniSpecified
        {
            get
            {
                return this.imzaZamaniFieldSpecified;
            }
            set
            {
                this.imzaZamaniFieldSpecified = value;
            }
        }
    }
}