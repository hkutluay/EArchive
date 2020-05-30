namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class eArsivVeriSerbestMeslekMakbuzMalHizmet
    {

        private string adField;

        private vergiBilgiType vergiBilgisiField;

        private decimal burutUcretField;

        /// <remarks/>
        public string ad
        {
            get
            {
                return this.adField;
            }
            set
            {
                this.adField = value;
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
        public decimal burutUcret
        {
            get
            {
                return this.burutUcretField;
            }
            set
            {
                this.burutUcretField = value;
            }
        }
    }
}