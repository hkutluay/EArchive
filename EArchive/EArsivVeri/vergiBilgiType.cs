namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]

    public partial class vergiBilgiType
    {

        private decimal vergilerToplamiField;

        private vergiBilgiTypeVergi[] vergiField;

        private vergiBilgiTypeTevkifat[] tevkifatField;

     
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
        public vergiBilgiTypeVergi[] vergi
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
        public vergiBilgiTypeTevkifat[] tevkifat
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
