namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class okcType
    {
        private string markaField;
        private string modelField;
        private string sicilNoField;
        public string marka
        {
            get
            {
                return this.markaField;
            }
            set
            {
                this.markaField = value;
            }
        }
        public string model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }
        public string sicilNo
        {
            get
            {
                return this.sicilNoField;
            }
            set
            {
                this.sicilNoField = value;
            }
        }
    }
}