namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivVeriSerbestMeslekMakbuz
    {

        private string makbuzNoField;

        private string eTTNField;

        private eArsivVeriSerbestMeslekMakbuzGonderimSekli gonderimSekliField;

        private string dosyaAdiField;

        private System.DateTime belgeTarihiField;

        private System.DateTime belgeZamaniField;

        private bool belgeZamaniFieldSpecified;

        private decimal toplamTutarField;

        private decimal odenecekTutarField;

        private eArsivVeriSerbestMeslekMakbuzParaBirimi paraBirimiField;

        private object kurField;

        private vergiBilgiType vergiBilgisiField;

        private aliciType aliciBilgileriField;

        private eArsivVeriSerbestMeslekMakbuzYnOkcFisBilgisi[] ynOkcFisBilgisiField;

        private eArsivVeriSerbestMeslekMakbuzMalHizmet[] malHizmetBilgisiField;

        /// <remarks/>
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

        /// <remarks/>
        public string ETTN
        {
            get
            {
                return this.eTTNField;
            }
            set
            {
                this.eTTNField = value;
            }
        }

        /// <remarks/>
        public eArsivVeriSerbestMeslekMakbuzGonderimSekli gonderimSekli
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

        /// <remarks/>
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime belgeTarihi
        {
            get
            {
                return this.belgeTarihiField;
            }
            set
            {
                this.belgeTarihiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime belgeZamani
        {
            get
            {
                return this.belgeZamaniField;
            }
            set
            {
                this.belgeZamaniField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool belgeZamaniSpecified
        {
            get
            {
                return this.belgeZamaniFieldSpecified;
            }
            set
            {
                this.belgeZamaniFieldSpecified = value;
            }
        }

        /// <remarks/>
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

        /// <remarks/>
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

        /// <remarks/>
        public eArsivVeriSerbestMeslekMakbuzParaBirimi paraBirimi
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

        /// <remarks/>
        public object kur
        {
            get
            {
                return this.kurField;
            }
            set
            {
                this.kurField = value;
            }
        }

        /// <remarks/>
        public vergiBilgiType vergiBilgisi
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

        /// <remarks/>
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ynOkcFisBilgisi")]
        public eArsivVeriSerbestMeslekMakbuzYnOkcFisBilgisi[] ynOkcFisBilgisi
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("malHizmet", IsNullable = false)]
        public eArsivVeriSerbestMeslekMakbuzMalHizmet[] malHizmetBilgisi
        {
            get
            {
                return this.malHizmetBilgisiField;
            }
            set
            {
                this.malHizmetBilgisiField = value;
            }
        }
    }
}