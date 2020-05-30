namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class ymRaporTypeBelgeTutar
    {
        private decimal tutarField;
        private belgeTutarTipEnum tipField;
        public decimal tutar
        {
            get
            {
                return this.tutarField;
            }
            set
            {
                this.tutarField = value;
            }
        }
        public belgeTutarTipEnum tip
        {
            get
            {
                return this.tipField;
            }
            set
            {
                this.tipField = value;
            }
        }
    }
}