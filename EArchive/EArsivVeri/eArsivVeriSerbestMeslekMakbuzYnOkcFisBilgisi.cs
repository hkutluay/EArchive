namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivVeriSerbestMeslekMakbuzYnOkcFisBilgisi
    {

        private string okcSeriNoField;

        private string zNoField;

        private string fisNoField;

        private eArsivVeriSerbestMeslekMakbuzYnOkcFisBilgisiFisTip fisTipField;

        private System.DateTime fisTarihField;

        private System.DateTime fisZamanField;

        private bool fisZamanFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string okcSeriNo
        {
            get
            {
                return this.okcSeriNoField;
            }
            set
            {
                this.okcSeriNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string zNo
        {
            get
            {
                return this.zNoField;
            }
            set
            {
                this.zNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string fisNo
        {
            get
            {
                return this.fisNoField;
            }
            set
            {
                this.fisNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public eArsivVeriSerbestMeslekMakbuzYnOkcFisBilgisiFisTip fisTip
        {
            get
            {
                return this.fisTipField;
            }
            set
            {
                this.fisTipField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "date")]
        public System.DateTime fisTarih
        {
            get
            {
                return this.fisTarihField;
            }
            set
            {
                this.fisTarihField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified, DataType = "time")]
        public System.DateTime fisZaman
        {
            get
            {
                return this.fisZamanField;
            }
            set
            {
                this.fisZamanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fisZamanSpecified
        {
            get
            {
                return this.fisZamanFieldSpecified;
            }
            set
            {
                this.fisZamanFieldSpecified = value;
            }
        }
    }
}