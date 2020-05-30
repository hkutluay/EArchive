
namespace EArchive.EArsiv
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]

    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://earsiv.efatura.gov.tr")]
    public partial class aliciTypeGercekKisi
    {
        private string tcknField;
        private string adiSoyadiField;
        public string tckn
        {
            get
            {
                return this.tcknField;
            }
            set
            {
                this.tcknField = value;
            }
        }
        public string adiSoyadi
        {
            get
            {
                return this.adiSoyadiField;
            }
            set
            {
                this.adiSoyadiField = value;
            }
        }
    }
}