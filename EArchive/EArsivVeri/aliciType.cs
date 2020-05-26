namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class aliciType
    {

        private object itemField;

        private aliciTypeAdres adresField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("gercekKisi", typeof(aliciTypeGercekKisi))]
        [System.Xml.Serialization.XmlElementAttribute("tuzelKisi", typeof(aliciTypeTuzelKisi))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public aliciTypeAdres adres
        {
            get
            {
                return this.adresField;
            }
            set
            {
                this.adresField = value;
            }
        }
    }
}