[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"b4790e65-5e0d-4762-a348-d94512309fe1,", Version=@"1.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write6_init(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"init", @"");
                return;
            }
            TopLevelElement();
            Write3_init(@"init", @"", ((global::KeyCloak.Migrations.init)o), true, false);
        }

        public void Write7_temp(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"temp", @"");
                return;
            }
            TopLevelElement();
            Write4_temp(@"temp", @"", ((global::KeyCloak.Migrations.temp)o), true, false);
        }

        public void Write8_Sprint(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Sprint", @"");
                return;
            }
            TopLevelElement();
            Write5_Sprint(@"Sprint", @"", ((global::KeyCloak.Data.Model.Sprint)o), true, false);
        }

        void Write5_Sprint(string n, string ns, global::KeyCloak.Data.Model.Sprint o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::KeyCloak.Data.Model.Sprint)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Sprint", @"");
            WriteElementStringRaw(@"Id", @"", System.Xml.XmlConvert.ToString((global::System.Guid)((global::System.Guid)o.@Id)));
            WriteElementString(@"Name", @"", ((global::System.String)o.@Name));
            WriteElementString(@"Description", @"", ((global::System.String)o.@Description));
            WriteEndElement(o);
        }

        void Write4_temp(string n, string ns, global::KeyCloak.Migrations.temp o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::KeyCloak.Migrations.temp)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"temp", @"");
            WriteElementString(@"ActiveProvider", @"", ((global::System.String)o.@ActiveProvider));
            WriteEndElement(o);
        }

        void Write3_init(string n, string ns, global::KeyCloak.Migrations.init o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::KeyCloak.Migrations.init)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"init", @"");
            WriteElementString(@"ActiveProvider", @"", ((global::System.String)o.@ActiveProvider));
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read6_init() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id1_init && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read3_init(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":init");
            }
            return (object)o;
        }

        public object Read7_temp() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id3_temp && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read4_temp(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":temp");
            }
            return (object)o;
        }

        public object Read8_Sprint() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id4_Sprint && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read5_Sprint(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":Sprint");
            }
            return (object)o;
        }

        global::KeyCloak.Data.Model.Sprint Read5_Sprint(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Sprint && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::KeyCloak.Data.Model.Sprint o;
            o = new global::KeyCloak.Data.Model.Sprint();
            System.Span<bool> paramsRead = stackalloc bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id5_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Id = System.Xml.XmlConvert.ToGuid(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id6_Name && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Name = Reader.ReadElementString();
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id7_Description && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Description = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        UnknownNode((object)o, @":Id, :Name, :Description");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":Id, :Name, :Description");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::KeyCloak.Migrations.temp Read4_temp(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_temp && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::KeyCloak.Migrations.temp o;
            o = new global::KeyCloak.Migrations.temp();
            System.Span<bool> paramsRead = stackalloc bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id8_ActiveProvider && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@ActiveProvider = Reader.ReadElementString();
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        UnknownNode((object)o, @":ActiveProvider");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":ActiveProvider");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        global::KeyCloak.Migrations.init Read3_init(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_init && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::KeyCloak.Migrations.init o;
            o = new global::KeyCloak.Migrations.init();
            System.Span<bool> paramsRead = stackalloc bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id8_ActiveProvider && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@ActiveProvider = Reader.ReadElementString();
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        UnknownNode((object)o, @":ActiveProvider");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":ActiveProvider");
                }
                Reader.MoveToContent();
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id5_Id;
        string id8_ActiveProvider;
        string id7_Description;
        string id1_init;
        string id6_Name;
        string id4_Sprint;
        string id3_temp;
        string id2_Item;

        protected override void InitIDs() {
            id5_Id = Reader.NameTable.Add(@"Id");
            id8_ActiveProvider = Reader.NameTable.Add(@"ActiveProvider");
            id7_Description = Reader.NameTable.Add(@"Description");
            id1_init = Reader.NameTable.Add(@"init");
            id6_Name = Reader.NameTable.Add(@"Name");
            id4_Sprint = Reader.NameTable.Add(@"Sprint");
            id3_temp = Reader.NameTable.Add(@"temp");
            id2_Item = Reader.NameTable.Add(@"");
        }
    }

    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    public sealed class initSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"init", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write6_init(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read6_init();
        }
    }

    public sealed class tempSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"temp", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write7_temp(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read7_temp();
        }
    }

    public sealed class SprintSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Sprint", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write8_Sprint(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read8_Sprint();
        }
    }

    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"KeyCloak.Migrations.init::"] = @"Read6_init";
                    _tmp[@"KeyCloak.Migrations.temp::"] = @"Read7_temp";
                    _tmp[@"KeyCloak.Data.Model.Sprint::"] = @"Read8_Sprint";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"KeyCloak.Migrations.init::"] = @"Write6_init";
                    _tmp[@"KeyCloak.Migrations.temp::"] = @"Write7_temp";
                    _tmp[@"KeyCloak.Data.Model.Sprint::"] = @"Write8_Sprint";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"KeyCloak.Data.Model.Sprint::", new SprintSerializer());
                    _tmp.Add(@"KeyCloak.Migrations.init::", new initSerializer());
                    _tmp.Add(@"KeyCloak.Migrations.temp::", new tempSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::KeyCloak.Migrations.init)) return true;
            if (type == typeof(global::KeyCloak.Migrations.temp)) return true;
            if (type == typeof(global::KeyCloak.Data.Model.Sprint)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::KeyCloak.Migrations.init)) return new initSerializer();
            if (type == typeof(global::KeyCloak.Migrations.temp)) return new tempSerializer();
            if (type == typeof(global::KeyCloak.Data.Model.Sprint)) return new SprintSerializer();
            return null;
        }
    }
}
