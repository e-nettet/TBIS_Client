﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace FRestgaeld6 {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    [System.Xml.Serialization.XmlRootAttribute("AMORTF", Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/", IsNullable=false)]
    public partial class AMORTF_Type {
        
        private Kodeliste1 onskes_amortoplysningerField;
        
        private bool onskes_amortoplysningerFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste1 Onskes_amortoplysninger {
            get {
                return this.onskes_amortoplysningerField;
            }
            set {
                this.onskes_amortoplysningerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Onskes_amortoplysningerSpecified {
            get {
                return this.onskes_amortoplysningerFieldSpecified;
            }
            set {
                this.onskes_amortoplysningerFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    public enum Kodeliste1 {
        
        /// <remarks/>
        Ja,
        
        /// <remarks/>
        Nej,
        
        /// <remarks/>
        IA,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    [System.Xml.Serialization.XmlRootAttribute("DOCINF", Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/", IsNullable=false)]
    public partial class DOCINF_Type {
        
        private Meddelelsens_navn meddelelsens_navnField;
        
        private Meddelelsens_type meddelelsens_typeField;
        
        private string sender_versionField;
        
        private string modtager_versionField;
        
        private string onsket_versionField;
        
        private string informationsstromnavnField;
        
        private string meddelelsens_nummerField;
        
        private Kodeliste5 meddelelsens_funktionField;
        
        private string datoField;
        
        private string afsender_partidField;
        
        private string iDkodeField;
        
        private string virksomhedsIDField;
        
        private string afdelingsidField;
        
        private string personidField;
        
        private string modtager_partidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Meddelelsens_navn Meddelelsens_navn {
            get {
                return this.meddelelsens_navnField;
            }
            set {
                this.meddelelsens_navnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Meddelelsens_type Meddelelsens_type {
            get {
                return this.meddelelsens_typeField;
            }
            set {
                this.meddelelsens_typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Sender_version {
            get {
                return this.sender_versionField;
            }
            set {
                this.sender_versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Modtager_version {
            get {
                return this.modtager_versionField;
            }
            set {
                this.modtager_versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Onsket_version {
            get {
                return this.onsket_versionField;
            }
            set {
                this.onsket_versionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string informationsstromnavn {
            get {
                return this.informationsstromnavnField;
            }
            set {
                this.informationsstromnavnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Meddelelsens_nummer {
            get {
                return this.meddelelsens_nummerField;
            }
            set {
                this.meddelelsens_nummerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste5 Meddelelsens_funktion {
            get {
                return this.meddelelsens_funktionField;
            }
            set {
                this.meddelelsens_funktionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Dato {
            get {
                return this.datoField;
            }
            set {
                this.datoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Afsender_partid {
            get {
                return this.afsender_partidField;
            }
            set {
                this.afsender_partidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("ID-kode")]
        public string IDkode {
            get {
                return this.iDkodeField;
            }
            set {
                this.iDkodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string VirksomhedsID {
            get {
                return this.virksomhedsIDField;
            }
            set {
                this.virksomhedsIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Afdelingsid {
            get {
                return this.afdelingsidField;
            }
            set {
                this.afdelingsidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Personid {
            get {
                return this.personidField;
            }
            set {
                this.personidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Modtager_partid {
            get {
                return this.modtager_partidField;
            }
            set {
                this.modtager_partidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    public enum Meddelelsens_navn {
        
        /// <remarks/>
        Z06,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    public enum Meddelelsens_type {
        
        /// <remarks/>
        REQDOC,
        
        /// <remarks/>
        MORDOC,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    public enum Kodeliste5 {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    [System.Xml.Serialization.XmlRootAttribute("KTRLKD", Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/", IsNullable=false)]
    public partial class KTRLKD_Type {
        
        private string reference_nrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string Reference_nr {
            get {
                return this.reference_nrField;
            }
            set {
                this.reference_nrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    [System.Xml.Serialization.XmlRootAttribute("EJDMID", Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/", IsNullable=false)]
    public partial class EJDMID_Type {
        
        private KTRLKD_Type kTRLKDField;
        
        private string ejendomsidentField;
        
        /// <remarks/>
        public KTRLKD_Type KTRLKD {
            get {
                return this.kTRLKDField;
            }
            set {
                this.kTRLKDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Ejendomsident {
            get {
                return this.ejendomsidentField;
            }
            set {
                this.ejendomsidentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    [System.Xml.Serialization.XmlRootAttribute("INSTIT", Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/", IsNullable=false)]
    public partial class INSTIT_Type {
        
        private Kodeliste4 institutField;
        
        private bool institutFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste4 Institut {
            get {
                return this.institutField;
            }
            set {
                this.institutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InstitutSpecified {
            get {
                return this.institutFieldSpecified;
            }
            set {
                this.institutFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    public enum Kodeliste4 {
        
        /// <remarks/>
        PRI,
        
        /// <remarks/>
        EJP,
        
        /// <remarks/>
        SKA,
        
        /// <remarks/>
        SPK,
        
        /// <remarks/>
        STA,
        
        /// <remarks/>
        STK,
        
        /// <remarks/>
        BRF,
        
        /// <remarks/>
        DLR,
        
        /// <remarks/>
        DK,
        
        /// <remarks/>
        HKK,
        
        /// <remarks/>
        LRF,
        
        /// <remarks/>
        N,
        
        /// <remarks/>
        RD,
        
        /// <remarks/>
        TOT,
        
        /// <remarks/>
        UNI,
        
        /// <remarks/>
        FK,
        
        /// <remarks/>
        GI,
        
        /// <remarks/>
        IHF,
        
        /// <remarks/>
        IRF,
        
        /// <remarks/>
        JK,
        
        /// <remarks/>
        KI,
        
        /// <remarks/>
        PRF,
        
        /// <remarks/>
        ALL,
        
        /// <remarks/>
        BGK,
        
        /// <remarks/>
        NOR,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    [System.Xml.Serialization.XmlRootAttribute("LAANID", Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/", IsNullable=false)]
    public partial class LAANID_Type {
        
        private string laaneidentifikationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Laaneidentifikation {
            get {
                return this.laaneidentifikationField;
            }
            set {
                this.laaneidentifikationField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    [System.Xml.Serialization.XmlRootAttribute("RESTAN", Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/", IsNullable=false)]
    public partial class RESTAN_Type {
        
        private Kodeliste1 onskes_restanceoplysningerField;
        
        private bool onskes_restanceoplysningerFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Kodeliste1 Onskes_restanceoplysninger {
            get {
                return this.onskes_restanceoplysningerField;
            }
            set {
                this.onskes_restanceoplysningerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Onskes_restanceoplysningerSpecified {
            get {
                return this.onskes_restanceoplysningerFieldSpecified;
            }
            set {
                this.onskes_restanceoplysningerFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/")]
    [System.Xml.Serialization.XmlRootAttribute("FRestgaeld6", Namespace="http://e-nettet.dk/xml/schemas/2007/07/01/", IsNullable=false)]
    public partial class FRestgaeld6_Type {
        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string schemaLocation = "http://www.realkreditnettet.dk/FRestgaeld6 FRestgaeld6.xsd";

        private DOCINF_Type dOCINFField;
        
        private INSTIT_Type iNSTITField;
        
        private EJDMID_Type eJDMIDField;
        
        private LAANID_Type lAANIDField;
        
        private RESTAN_Type rESTANField;
        
        private AMORTF_Type aMORTFField;
        
        /// <remarks/>
        public DOCINF_Type DOCINF {
            get {
                return this.dOCINFField;
            }
            set {
                this.dOCINFField = value;
            }
        }
        
        /// <remarks/>
        public INSTIT_Type INSTIT {
            get {
                return this.iNSTITField;
            }
            set {
                this.iNSTITField = value;
            }
        }
        
        /// <remarks/>
        public EJDMID_Type EJDMID {
            get {
                return this.eJDMIDField;
            }
            set {
                this.eJDMIDField = value;
            }
        }
        
        /// <remarks/>
        public LAANID_Type LAANID {
            get {
                return this.lAANIDField;
            }
            set {
                this.lAANIDField = value;
            }
        }
        
        /// <remarks/>
        public RESTAN_Type RESTAN {
            get {
                return this.rESTANField;
            }
            set {
                this.rESTANField = value;
            }
        }
        
        /// <remarks/>
        public AMORTF_Type AMORTF {
            get {
                return this.aMORTFField;
            }
            set {
                this.aMORTFField = value;
            }
        }
    }
}
