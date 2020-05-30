
namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class vergiBilgiTypeVergi
    {

        private decimal matrahField;

        private vergiBilgiTypeVergiVergiKodu vergiKoduField;

        private decimal vergiTutariField;

        private decimal vergiOraniField;

        private bool vergiOraniFieldSpecified;

        /// <remarks/>
        public decimal matrah
        {
            get
            {
                return this.matrahField;
            }
            set
            {
                this.matrahField = value;
            }
        }

        /// <remarks/>
        public vergiBilgiTypeVergiVergiKodu vergiKodu
        {
            get
            {
                return this.vergiKoduField;
            }
            set
            {
                this.vergiKoduField = value;
            }
        }

        /// <remarks/>
        public decimal vergiTutari
        {
            get
            {
                return this.vergiTutariField;
            }
            set
            {
                this.vergiTutariField = value;
            }
        }

        /// <remarks/>
        public decimal vergiOrani
        {
            get
            {
                return this.vergiOraniField;
            }
            set
            {
                this.vergiOraniField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vergiOraniSpecified
        {
            get
            {
                return this.vergiOraniFieldSpecified;
            }
            set
            {
                this.vergiOraniFieldSpecified = value;
            }
        }
    }
}