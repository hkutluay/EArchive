namespace EArchive.EArsivVeri
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class aliciTypeMin
    {

        private aliciTypeMinTuzelKisi tuzelKisiField;

        private aliciTypeMinGercekKisi gercekKisiField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public aliciTypeMinTuzelKisi tuzelKisi
        {
            get
            {
                return this.tuzelKisiField;
            }
            set
            {
                this.tuzelKisiField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public aliciTypeMinGercekKisi gercekKisi
        {
            get
            {
                return this.gercekKisiField;
            }
            set
            {
                this.gercekKisiField = value;
            }
        }
    }
}