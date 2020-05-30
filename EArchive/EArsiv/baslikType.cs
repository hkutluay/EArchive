using EArchive.XmlDSig;

namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class baslikType
    {
        private string versiyonField;
        private vknTcknType mukellefField;
        private vknTcknType hazirlayanField;
        private string raporNoField;
        private System.DateTime donemBaslangicTarihiField;
        private System.DateTime donemBitisTarihiField;
        private System.DateTime bolumBaslangicTarihiField;
        private System.DateTime bolumBitisTarihiField;
        private int bolumNoField;
        private SignatureType signatureField;
        public string versiyon
        {
            get
            {
                return this.versiyonField;
            }
            set
            {
                this.versiyonField = value;
            }
        }
        public vknTcknType mukellef
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
        public vknTcknType hazirlayan
        {
            get
            {
                return this.hazirlayanField;
            }
            set
            {
                this.hazirlayanField = value;
            }
        }
        public string raporNo
        {
            get
            {
                return this.raporNoField;
            }
            set
            {
                this.raporNoField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime donemBaslangicTarihi
        {
            get
            {
                return this.donemBaslangicTarihiField;
            }
            set
            {
                this.donemBaslangicTarihiField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime donemBitisTarihi
        {
            get
            {
                return this.donemBitisTarihiField;
            }
            set
            {
                this.donemBitisTarihiField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime bolumBaslangicTarihi
        {
            get
            {
                return this.bolumBaslangicTarihiField;
            }
            set
            {
                this.bolumBaslangicTarihiField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime bolumBitisTarihi
        {
            get
            {
                return this.bolumBitisTarihiField;
            }
            set
            {
                this.bolumBitisTarihiField = value;
            }
        }
        public int bolumNo
        {
            get
            {
                return this.bolumNoField;
            }
            set
            {
                this.bolumNoField = value;
            }
        }
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }
}