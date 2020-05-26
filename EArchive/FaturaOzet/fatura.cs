
namespace EArchive.FaturaOzet
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class fatura
    {

        private string faturaNoField;

        private System.DateTime duzenlemeTarihiField;

        private System.DateTime sonOdemeTarihiField;

        private faturaDuzenleyen duzenleyenField;

        private faturaAlici aliciField;

        private decimal odenecekTutarField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime duzenlemeTarihi
        {
            get
            {
                return this.duzenlemeTarihiField;
            }
            set
            {
                this.duzenlemeTarihiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime sonOdemeTarihi
        {
            get
            {
                return this.sonOdemeTarihiField;
            }
            set
            {
                this.sonOdemeTarihiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public faturaDuzenleyen duzenleyen
        {
            get
            {
                return this.duzenleyenField;
            }
            set
            {
                this.duzenleyenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public faturaAlici alici
        {
            get
            {
                return this.aliciField;
            }
            set
            {
                this.aliciField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
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
    }
}