// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\WebPublicationsViewNew.json"
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using st=Starcounter.Templates;
using s=Starcounter;
using _GEN1_=System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_=System.CodeDom.Compiler.GeneratedCodeAttribute;
using _ScTemplate_=Starcounter.Templates.Template;
using System.Linq;
using OneKey.Database;
#pragma warning disable 0108
#pragma warning disable 1591

using __WVaSchema2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableTypeListElementJson.JsonByExample.Schema;
using __WeActionJs2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.Input;
using __WAcName1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.Input.Name;
using __WAcObId__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.Input.ObId;
using __WAcActionUr__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.Input.ActionUrl;
using __WAcHttpBody__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.Input.HttpBody;
using __WAcHttpType__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.Input.HttpType;
using __WAcOrderInF__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.Input.OrderInFeature;
using __Arr3__ = global::Starcounter.Arr<global::OneKey.Server.Partials.VariableObject>;
using __WAcPagging__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.Input.Pagging;
using __WeVariable6__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableJson;
using __WeVariable7__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableJson.JsonByExample;
using __WeVariable8__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableJson.Input;
using __WVaName1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableJson.Input.Name;
using __WVaObId__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableJson.Input.ObId;
using __WVaVariable1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableJson.Input.VariableType;
using __WVaRegex__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableJson.Input.Regex;
using __WAcPaggingU__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.Input.PaggingUrlParameters;
using __WVaVariable2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableJson.Input.VariableValue;
using __WeActionJs1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.JsonByExample;
using __WFeName1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureJson.Input.Name;
using __WeVariable5__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableTypeListElementJson.Input;
using __WVaVariable__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableTypeListElementJson.Input.VariableType;
using __TArray7__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationsViewNew.VariableTypeListElementJson>;
using __WebPubli4__ = global::OneKey.Server.Partials.WebPublicationsViewNew.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationObject>;
using __WeWebPubli__ = global::OneKey.Server.Partials.WebPublicationsViewNew.WebPublicationJson;
using __WeWebPubli1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.WebPublicationJson.JsonByExample;
using __WeActionJs__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson;
using __Arr1__ = global::Starcounter.Arr<global::OneKey.Server.Partials.FeatureObject>;
using __WWeName__ = global::OneKey.Server.Partials.WebPublicationsViewNew.WebPublicationJson.Input.Name;
using __WWeUrl__ = global::OneKey.Server.Partials.WebPublicationsViewNew.WebPublicationJson.Input.Url;
using __WWeDescript__ = global::OneKey.Server.Partials.WebPublicationsViewNew.WebPublicationJson.Input.Description;
using __WeFeatureJ__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureJson;
using __WeFeatureJ1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureJson.JsonByExample;
using __Arr2__ = global::Starcounter.Arr<global::OneKey.Server.Partials.ActionObject>;
using __WeFeatureJ2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureJson.Input;
using __WeWebPubli2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.WebPublicationJson.Input;
using __Arr4__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureNameListElementJson>;
using __Arr5__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationsViewNew.ActionNameListElementJson>;
using __Arr6__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationsViewNew.VariableNameListElementJson>;
using __WeNewVaria1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewVariableNameOther;
using __WeNewVaria2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewVariableName;
using __WeNewVaria3__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewVariableTypeOther;
using __WeNewVaria4__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewVariableType;
using __WeNewVaria5__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewVariableRegex;
using __WeAddWebSi__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.AddWebSite;
using __WeDeleteWe__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.DeleteWebSite;
using __WeNewVaria__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewVariableValue;
using __WeUpdateWe__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.UpdateWebSite;
using __WeDeleteFe__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.DeleteFeature;
using __WeUpdateFe__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.UpdateFeature;
using __WeAddActio__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.AddAction;
using __WeDeleteAc__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.DeleteAction;
using __WeUpdateAc__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.UpdateAction;
using __WeAddVaria__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.AddVariable;
using __WeDeleteVa__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.DeleteVariable;
using __WeAddFeatu__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.AddFeature;
using __WeNewActio5__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewActionOrderInFeature;
using __WeNewActio4__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewActionHttpBody;
using __WeNewActio3__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewActionHttpType;
using __Arr7__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationsViewNew.VariableTypeListElementJson>;
using __WebPubli5__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input;
using __WeHtml__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.Html;
using __WeSelected__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.SelectedWebPublicationID;
using __WeSelected1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.SelectedFeatureID;
using __WeSelected2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.SelectedActionID;
using __WeSelected3__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.SelectedVariableID;
using __WeNewWebPu__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewWebPublicationName;
using __WeNewWebPu1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewWebPublicationUrl;
using __WeNewWebPu2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewWebPublicationDescription;
using __WeNewFeatu__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewFeatureNameOther;
using __WeNewFeatu1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewFeatureName;
using __WeNewActio__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewActionNameOther;
using __WePagging__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.Pagging;
using __WePaggingU__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.PaggingUrlParameters;
using __WeNewActio1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewActionName;
using __WeNewActio2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.NewActionUrl;
using __WeVariable4__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableTypeListElementJson.JsonByExample;
using __WeUpdateVa__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.UpdateVariable;
using __WeFetchWeb__ = global::OneKey.Server.Partials.WebPublicationsViewNew.Input.FetchWebPublications;
using __TArray6__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationsViewNew.VariableNameListElementJson>;
using __FeSchema__ = global::OneKey.Server.Partials.FeatureObject.JsonByExample.Schema;
using __FeatureO1__ = global::OneKey.Server.Partials.FeatureObject.JsonByExample;
using __FeatureO2__ = global::OneKey.Server.Partials.FeatureObject.Input;
using __FeUpdate__ = global::OneKey.Server.Partials.FeatureObject.Input.Update;
using __FeName__ = global::OneKey.Server.Partials.FeatureObject.Input.Name;
using __FeObId__ = global::OneKey.Server.Partials.FeatureObject.Input.ObId;
using __TArray1__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.FeatureObject>;
using __WFeSchema__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureJson.JsonByExample.Schema;
using __ActionOb__ = global::OneKey.Server.Partials.ActionObject;
using __AcSchema__ = global::OneKey.Server.Partials.ActionObject.JsonByExample.Schema;
using __TBool__ = global::Starcounter.Templates.TBool;
using __ActionOb1__ = global::OneKey.Server.Partials.ActionObject.JsonByExample;
using __ActionOb2__ = global::OneKey.Server.Partials.ActionObject.Input;
using __AcUpdate__ = global::OneKey.Server.Partials.ActionObject.Input.Update;
using __WeVariable3__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableTypeListElementJson;
using __FeatureO__ = global::OneKey.Server.Partials.FeatureObject;
using __AcObId__ = global::OneKey.Server.Partials.ActionObject.Input.ObId;
using __WWeSchema__ = global::OneKey.Server.Partials.WebPublicationsViewNew.WebPublicationJson.JsonByExample.Schema;
using __WeDescript__ = global::OneKey.Server.Partials.WebPublicationObject.Input.Description;
using __WebPubli__ = global::OneKey.Server.Partials.WebPublicationsViewNew;
using __WeSchema__ = global::OneKey.Server.Partials.WebPublicationsViewNew.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __WebPubli1__ = global::OneKey.Server.Partials.WebPublicationObject;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __WeSchema1__ = global::OneKey.Server.Partials.WebPublicationObject.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __WebPubli2__ = global::OneKey.Server.Partials.WebPublicationObject.JsonByExample;
using __WebPubli3__ = global::OneKey.Server.Partials.WebPublicationObject.Input;
using __WeUpdate__ = global::OneKey.Server.Partials.WebPublicationObject.Input.Update;
using __WeName__ = global::OneKey.Server.Partials.WebPublicationObject.Input.Name;
using __WeObId__ = global::OneKey.Server.Partials.WebPublicationObject.Input.ObId;
using __WeUrl__ = global::OneKey.Server.Partials.WebPublicationObject.Input.Url;
using __TArray__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationObject>;
using __AcActionUr__ = global::OneKey.Server.Partials.ActionObject.Input.ActionUrl;
using __AcName__ = global::OneKey.Server.Partials.ActionObject.Input.Name;
using __AcHttpType__ = global::OneKey.Server.Partials.ActionObject.Input.HttpType;
using __AcHttpBody__ = global::OneKey.Server.Partials.ActionObject.Input.HttpBody;
using __WeFeatureN2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureNameListElementJson.Input;
using __WFeName__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureNameListElementJson.Input.Name;
using __TArray4__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureNameListElementJson>;
using __WeActionNa__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionNameListElementJson;
using __WAcSchema1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionNameListElementJson.JsonByExample.Schema;
using __WeActionNa1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionNameListElementJson.JsonByExample;
using __WeActionNa2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionNameListElementJson.Input;
using __WAcName__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionNameListElementJson.Input.Name;
using __TArray5__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationsViewNew.ActionNameListElementJson>;
using __WeVariable__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableNameListElementJson;
using __WVaSchema1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableNameListElementJson.JsonByExample.Schema;
using __WeVariable1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableNameListElementJson.JsonByExample;
using __WeVariable2__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableNameListElementJson.Input;
using __WVaName__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableNameListElementJson.Input.Name;
using __WFeSchema1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureNameListElementJson.JsonByExample.Schema;
using __WeFeatureN__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureNameListElementJson;
using __WeFeatureN1__ = global::OneKey.Server.Partials.WebPublicationsViewNew.FeatureNameListElementJson.JsonByExample;
using __TArray3__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.VariableObject>;
using __AcOrderInF__ = global::OneKey.Server.Partials.ActionObject.Input.OrderInFeature;
using __AcPagging__ = global::OneKey.Server.Partials.ActionObject.Input.Pagging;
using __AcPaggingU__ = global::OneKey.Server.Partials.ActionObject.Input.PaggingUrlParameters;
using __TArray2__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.ActionObject>;
using __WVaSchema__ = global::OneKey.Server.Partials.WebPublicationsViewNew.VariableJson.JsonByExample.Schema;
using __Variable__ = global::OneKey.Server.Partials.VariableObject;
using __VaSchema__ = global::OneKey.Server.Partials.VariableObject.JsonByExample.Schema;
using __WAcSchema__ = global::OneKey.Server.Partials.WebPublicationsViewNew.ActionJson.JsonByExample.Schema;
using __Variable2__ = global::OneKey.Server.Partials.VariableObject.Input;
using __VaUpdate__ = global::OneKey.Server.Partials.VariableObject.Input.Update;
using __VaName__ = global::OneKey.Server.Partials.VariableObject.Input.Name;
using __VaObId__ = global::OneKey.Server.Partials.VariableObject.Input.ObId;
using __VaVariable__ = global::OneKey.Server.Partials.VariableObject.Input.VariableType;
using __VaRegex__ = global::OneKey.Server.Partials.VariableObject.Input.Regex;
using __VaVariable1__ = global::OneKey.Server.Partials.VariableObject.Input.VariableValue;
using __Variable1__ = global::OneKey.Server.Partials.VariableObject.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class WebPublicationsViewNew_json : s::TemplateAttribute {
    
    #line hidden
    public class WebPublications : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class WebPublication : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Features : s::TemplateAttribute {
        }
        #line default
    }
    #line default
    
    #line hidden
    public class Feature : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Actions : s::TemplateAttribute {
        }
        #line default
    }
    #line default
    
    #line hidden
    public class Action : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Variables : s::TemplateAttribute {
        }
        #line default
    }
    #line default
    
    #line hidden
    public class Variable : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class FeatureNameList : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class ActionNameList : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class VariableNameList : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class VariableTypeList : s::TemplateAttribute {
    }
    #line default
}
#line default

namespace OneKey.Server.Partials {

#line hidden
public partial class VariableObject : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __VaSchema__ DefaultTemplate = new __VaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public VariableObject() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public VariableObject(__VaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __VaSchema__ Template { get { return (__VaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.Int64 __bf__Update__;
    private System.String __bf__Name__;
    private System.String __bf__ObId__;
    private System.String __bf__VariableType__;
    private System.String __bf__Regex__;
    private System.String __bf__VariableValue__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Variable__);
                ClassName = "VariableObject";
                Properties.ClearExposed();
                Update = Add<__TLong__>("Update$");
                Update.DefaultValue = 0L;
                Update.Editable = true;
                Update.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__Update__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__Update__ = (System.Int64)_v_; }, false);
                Update.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Update() { App = (VariableObject)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((VariableObject)pup).Handle((Input.Update)input); });
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                ObId = Add<__TString__>("ObId");
                ObId.DefaultValue = "";
                ObId.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__ObId__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__ObId__ = (System.String)_v_; }, false);
                VariableType = Add<__TString__>("VariableType$");
                VariableType.DefaultValue = "";
                VariableType.Editable = true;
                VariableType.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__VariableType__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__VariableType__ = (System.String)_v_; }, false);
                Regex = Add<__TString__>("Regex$");
                Regex.DefaultValue = "";
                Regex.Editable = true;
                Regex.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__Regex__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__Regex__ = (System.String)_v_; }, false);
                VariableValue = Add<__TString__>("VariableValue$");
                VariableValue.DefaultValue = "";
                VariableValue.Editable = true;
                VariableValue.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__VariableValue__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__VariableValue__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Variable__(this) { Parent = parent }; }
            public __TLong__ Update;
            public __TString__ Name;
            public __TString__ ObId;
            public __TString__ VariableType;
            public __TString__ Regex;
            public __TString__ VariableValue;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Update {
#line 69 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Update.Getter(this); }
#line 69 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Update.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 70 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 70 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ObId {
#line 71 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.ObId.Getter(this); }
#line 71 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.ObId.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String VariableType {
#line 72 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.VariableType.Getter(this); }
#line 72 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.VariableType.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Regex {
#line 73 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Regex.Getter(this); }
#line 73 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Regex.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String VariableValue {
#line 75 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.VariableValue.Getter(this); }
#line 75 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.VariableValue.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Update : Input<__Variable__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Variable__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ObId : Input<__Variable__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class VariableType : Input<__Variable__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Regex : Input<__Variable__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class VariableValue : Input<__Variable__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class ActionObject : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __AcSchema__ DefaultTemplate = new __AcSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ActionObject() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ActionObject(__AcSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __AcSchema__ Template { get { return (__AcSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.Int64 __bf__Update__;
    private System.String __bf__Name__;
    private System.String __bf__ObId__;
    private System.String __bf__ActionUrl__;
    private System.String __bf__HttpBody__;
    private System.String __bf__HttpType__;
    private System.Int64 __bf__OrderInFeature__;
    private System.Boolean __bf__Pagging__;
    private System.String __bf__PaggingUrlParameters__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ActionOb__);
                ClassName = "ActionObject";
                Properties.ClearExposed();
                Update = Add<__TLong__>("Update$");
                Update.DefaultValue = 0L;
                Update.Editable = true;
                Update.SetCustomAccessors((_p_) => { return ((__ActionOb__)_p_).__bf__Update__; }, (_p_, _v_) => { ((__ActionOb__)_p_).__bf__Update__ = (System.Int64)_v_; }, false);
                Update.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Update() { App = (ActionObject)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((ActionObject)pup).Handle((Input.Update)input); });
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__ActionOb__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__ActionOb__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                ObId = Add<__TString__>("ObId");
                ObId.DefaultValue = "";
                ObId.SetCustomAccessors((_p_) => { return ((__ActionOb__)_p_).__bf__ObId__; }, (_p_, _v_) => { ((__ActionOb__)_p_).__bf__ObId__ = (System.String)_v_; }, false);
                ActionUrl = Add<__TString__>("ActionUrl$");
                ActionUrl.DefaultValue = "";
                ActionUrl.Editable = true;
                ActionUrl.SetCustomAccessors((_p_) => { return ((__ActionOb__)_p_).__bf__ActionUrl__; }, (_p_, _v_) => { ((__ActionOb__)_p_).__bf__ActionUrl__ = (System.String)_v_; }, false);
                HttpBody = Add<__TString__>("HttpBody$");
                HttpBody.DefaultValue = "";
                HttpBody.Editable = true;
                HttpBody.SetCustomAccessors((_p_) => { return ((__ActionOb__)_p_).__bf__HttpBody__; }, (_p_, _v_) => { ((__ActionOb__)_p_).__bf__HttpBody__ = (System.String)_v_; }, false);
                HttpType = Add<__TString__>("HttpType$");
                HttpType.DefaultValue = "";
                HttpType.Editable = true;
                HttpType.SetCustomAccessors((_p_) => { return ((__ActionOb__)_p_).__bf__HttpType__; }, (_p_, _v_) => { ((__ActionOb__)_p_).__bf__HttpType__ = (System.String)_v_; }, false);
                OrderInFeature = Add<__TLong__>("OrderInFeature$");
                OrderInFeature.DefaultValue = 0L;
                OrderInFeature.Editable = true;
                OrderInFeature.SetCustomAccessors((_p_) => { return ((__ActionOb__)_p_).__bf__OrderInFeature__; }, (_p_, _v_) => { ((__ActionOb__)_p_).__bf__OrderInFeature__ = (System.Int64)_v_; }, false);
                Pagging = Add<__TBool__>("Pagging$");
                Pagging.DefaultValue = true;
                Pagging.Editable = true;
                Pagging.SetCustomAccessors((_p_) => { return ((__ActionOb__)_p_).__bf__Pagging__; }, (_p_, _v_) => { ((__ActionOb__)_p_).__bf__Pagging__ = (System.Boolean)_v_; }, false);
                PaggingUrlParameters = Add<__TString__>("PaggingUrlParameters$");
                PaggingUrlParameters.DefaultValue = "";
                PaggingUrlParameters.Editable = true;
                PaggingUrlParameters.SetCustomAccessors((_p_) => { return ((__ActionOb__)_p_).__bf__PaggingUrlParameters__; }, (_p_, _v_) => { ((__ActionOb__)_p_).__bf__PaggingUrlParameters__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ActionOb__(this) { Parent = parent }; }
            public __TLong__ Update;
            public __TString__ Name;
            public __TString__ ObId;
            public __TString__ ActionUrl;
            public __TString__ HttpBody;
            public __TString__ HttpType;
            public __TLong__ OrderInFeature;
            public __TBool__ Pagging;
            public __TString__ PaggingUrlParameters;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Update {
#line 42 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Update.Getter(this); }
#line 42 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Update.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 43 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 43 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ObId {
#line 44 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.ObId.Getter(this); }
#line 44 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.ObId.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ActionUrl {
#line 45 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.ActionUrl.Getter(this); }
#line 45 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.ActionUrl.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HttpBody {
#line 46 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.HttpBody.Getter(this); }
#line 46 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.HttpBody.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HttpType {
#line 47 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.HttpType.Getter(this); }
#line 47 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.HttpType.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 OrderInFeature {
#line 48 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.OrderInFeature.Getter(this); }
#line 48 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.OrderInFeature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean Pagging {
#line 123 "JOCKE3"
    get {
#line hidden
        return Template.Pagging.Getter(this); }
#line 123 "JOCKE3"
    set {
#line hidden
        Template.Pagging.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String PaggingUrlParameters {
#line 51 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.PaggingUrlParameters.Getter(this); }
#line 51 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.PaggingUrlParameters.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Update : Input<__ActionOb__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__ActionOb__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ObId : Input<__ActionOb__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ActionUrl : Input<__ActionOb__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HttpBody : Input<__ActionOb__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HttpType : Input<__ActionOb__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class OrderInFeature : Input<__ActionOb__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Pagging : Input<__ActionOb__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class PaggingUrlParameters : Input<__ActionOb__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class FeatureObject : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FeSchema__ DefaultTemplate = new __FeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FeatureObject() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FeatureObject(__FeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FeSchema__ Template { get { return (__FeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.Int64 __bf__Update__;
    private System.String __bf__Name__;
    private System.String __bf__ObId__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__FeatureO__);
                ClassName = "FeatureObject";
                Properties.ClearExposed();
                Update = Add<__TLong__>("Update$");
                Update.DefaultValue = 0L;
                Update.Editable = true;
                Update.SetCustomAccessors((_p_) => { return ((__FeatureO__)_p_).__bf__Update__; }, (_p_, _v_) => { ((__FeatureO__)_p_).__bf__Update__ = (System.Int64)_v_; }, false);
                Update.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Update() { App = (FeatureObject)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FeatureObject)pup).Handle((Input.Update)input); });
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__FeatureO__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__FeatureO__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                ObId = Add<__TString__>("ObId");
                ObId.DefaultValue = "";
                ObId.SetCustomAccessors((_p_) => { return ((__FeatureO__)_p_).__bf__ObId__; }, (_p_, _v_) => { ((__FeatureO__)_p_).__bf__ObId__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __FeatureO__(this) { Parent = parent }; }
            public __TLong__ Update;
            public __TString__ Name;
            public __TString__ ObId;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Update {
#line 28 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Update.Getter(this); }
#line 28 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Update.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 29 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 29 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ObId {
#line 31 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.ObId.Getter(this); }
#line 31 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.ObId.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Update : Input<__FeatureO__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__FeatureO__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ObId : Input<__FeatureO__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class WebPublicationObject : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __WeSchema1__ DefaultTemplate = new __WeSchema1__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public WebPublicationObject() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public WebPublicationObject(__WeSchema1__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __WeSchema1__ Template { get { return (__WeSchema1__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.Int64 __bf__Update__;
    private System.String __bf__Name__;
    private System.String __bf__ObId__;
    private System.String __bf__Url__;
    private System.String __bf__Description__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__WebPubli1__);
                ClassName = "WebPublicationObject";
                Properties.ClearExposed();
                Update = Add<__TLong__>("Update$");
                Update.DefaultValue = 0L;
                Update.Editable = true;
                Update.SetCustomAccessors((_p_) => { return ((__WebPubli1__)_p_).__bf__Update__; }, (_p_, _v_) => { ((__WebPubli1__)_p_).__bf__Update__ = (System.Int64)_v_; }, false);
                Update.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.Update() { App = (WebPublicationObject)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationObject)pup).Handle((Input.Update)input); });
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__WebPubli1__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__WebPubli1__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                ObId = Add<__TString__>("ObId");
                ObId.DefaultValue = "";
                ObId.SetCustomAccessors((_p_) => { return ((__WebPubli1__)_p_).__bf__ObId__; }, (_p_, _v_) => { ((__WebPubli1__)_p_).__bf__ObId__ = (System.String)_v_; }, false);
                Url = Add<__TString__>("Url$");
                Url.DefaultValue = "www.facebook.com";
                Url.Editable = true;
                Url.SetCustomAccessors((_p_) => { return ((__WebPubli1__)_p_).__bf__Url__; }, (_p_, _v_) => { ((__WebPubli1__)_p_).__bf__Url__ = (System.String)_v_; }, false);
                Description = Add<__TString__>("Description$");
                Description.DefaultValue = "DescriptionDescription";
                Description.Editable = true;
                Description.SetCustomAccessors((_p_) => { return ((__WebPubli1__)_p_).__bf__Description__; }, (_p_, _v_) => { ((__WebPubli1__)_p_).__bf__Description__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __WebPubli1__(this) { Parent = parent }; }
            public __TLong__ Update;
            public __TString__ Name;
            public __TString__ ObId;
            public __TString__ Url;
            public __TString__ Description;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Update {
#line 6 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Update.Getter(this); }
#line 6 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Update.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 7 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 7 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ObId {
#line 8 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.ObId.Getter(this); }
#line 8 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.ObId.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Url {
#line 9 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Url.Getter(this); }
#line 9 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Url.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Description {
#line 11 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Description.Getter(this); }
#line 11 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Description.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Update : Input<__WebPubli1__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__WebPubli1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ObId : Input<__WebPubli1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Url : Input<__WebPubli1__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Description : Input<__WebPubli1__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class WebPublicationsViewNew : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __WeSchema__ DefaultTemplate = new __WeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public WebPublicationsViewNew() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public WebPublicationsViewNew(__WeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __WeSchema__ Template { get { return (__WeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Html__;
    private __Arr__ __bf__WebPublications__;
    private System.String __bf__SelectedWebPublicationID__;
    private __WeWebPubli__ __bf__WebPublication__;
    private System.String __bf__SelectedFeatureID__;
    private __WeFeatureJ__ __bf__Feature__;
    private System.String __bf__SelectedActionID__;
    private __WeActionJs__ __bf__Action__;
    private System.String __bf__SelectedVariableID__;
    private __WeVariable6__ __bf__Variable__;
    private __Arr4__ __bf__FeatureNameList__;
    private __Arr5__ __bf__ActionNameList__;
    private __Arr6__ __bf__VariableNameList__;
    private __Arr7__ __bf__VariableTypeList__;
    private System.String __bf__NewWebPublicationName__;
    private System.String __bf__NewWebPublicationUrl__;
    private System.String __bf__NewWebPublicationDescription__;
    private System.String __bf__NewFeatureNameOther__;
    private System.String __bf__NewFeatureName__;
    private System.String __bf__NewActionNameOther__;
    private System.Boolean __bf__Pagging__;
    private System.String __bf__PaggingUrlParameters__;
    private System.String __bf__NewActionName__;
    private System.String __bf__NewActionUrl__;
    private System.String __bf__NewActionHttpType__;
    private System.String __bf__NewActionHttpBody__;
    private System.Int64 __bf__NewActionOrderInFeature__;
    private System.String __bf__NewVariableValue__;
    private System.String __bf__NewVariableNameOther__;
    private System.String __bf__NewVariableName__;
    private System.String __bf__NewVariableTypeOther__;
    private System.String __bf__NewVariableType__;
    private System.String __bf__NewVariableRegex__;
    private System.Int64 __bf__AddWebSite__;
    private System.Int64 __bf__DeleteWebSite__;
    private System.Int64 __bf__UpdateWebSite__;
    private System.Int64 __bf__AddFeature__;
    private System.Int64 __bf__DeleteFeature__;
    private System.Int64 __bf__UpdateFeature__;
    private System.Int64 __bf__AddAction__;
    private System.Int64 __bf__DeleteAction__;
    private System.Int64 __bf__UpdateAction__;
    private System.Int64 __bf__AddVariable__;
    private System.Int64 __bf__DeleteVariable__;
    private System.Int64 __bf__UpdateVariable__;
    private System.Int64 __bf__FetchWebPublications__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__WebPubli__);
                ClassName = "WebPublicationsViewNew";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "";
                Html.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                WebPublications = Add<__TArray__>("WebPublications$", bind:"WebPublications_");
                WebPublications.SetCustomGetElementType((arr) => { return __WebPubli1__.DefaultTemplate;});
                WebPublications.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__WebPublications__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__WebPublications__ = (__Arr__)_v_; }, false);
                SelectedWebPublicationID = Add<__TString__>("SelectedWebPublicationID$");
                SelectedWebPublicationID.DefaultValue = "";
                SelectedWebPublicationID.Editable = true;
                SelectedWebPublicationID.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__SelectedWebPublicationID__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__SelectedWebPublicationID__ = (System.String)_v_; }, false);
                WebPublication = Add<__WWeSchema__>("WebPublication$", bind:"SelectedWebPublication_");
                WebPublication.Editable = true;
                WebPublication.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__WebPublication__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__WebPublication__ = (__WeWebPubli__)_v_; }, false);
                SelectedFeatureID = Add<__TString__>("SelectedFeatureID$");
                SelectedFeatureID.DefaultValue = "";
                SelectedFeatureID.Editable = true;
                SelectedFeatureID.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__SelectedFeatureID__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__SelectedFeatureID__ = (System.String)_v_; }, false);
                Feature = Add<__WFeSchema__>("Feature$", bind:"SelectedFeature_");
                Feature.Editable = true;
                Feature.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__Feature__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__Feature__ = (__WeFeatureJ__)_v_; }, false);
                SelectedActionID = Add<__TString__>("SelectedActionID$");
                SelectedActionID.DefaultValue = "";
                SelectedActionID.Editable = true;
                SelectedActionID.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__SelectedActionID__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__SelectedActionID__ = (System.String)_v_; }, false);
                Action = Add<__WAcSchema__>("Action$", bind:"SelectedAction_");
                Action.Editable = true;
                Action.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__Action__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__Action__ = (__WeActionJs__)_v_; }, false);
                SelectedVariableID = Add<__TString__>("SelectedVariableID$");
                SelectedVariableID.DefaultValue = "";
                SelectedVariableID.Editable = true;
                SelectedVariableID.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__SelectedVariableID__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__SelectedVariableID__ = (System.String)_v_; }, false);
                Variable = Add<__WVaSchema__>("Variable$", bind:"SelectedVariable_");
                Variable.Editable = true;
                Variable.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__Variable__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__Variable__ = (__WeVariable6__)_v_; }, false);
                FeatureNameList = Add<__TArray4__>("FeatureNameList$", bind:"NewFeatureNameList_");
                FeatureNameList.SetCustomGetElementType((arr) => { return __WeFeatureN__.DefaultTemplate;});
                FeatureNameList.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__FeatureNameList__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__FeatureNameList__ = (__Arr4__)_v_; }, false);
                ActionNameList = Add<__TArray5__>("ActionNameList$", bind:"NewActionNameList_");
                ActionNameList.SetCustomGetElementType((arr) => { return __WeActionNa__.DefaultTemplate;});
                ActionNameList.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__ActionNameList__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__ActionNameList__ = (__Arr5__)_v_; }, false);
                VariableNameList = Add<__TArray6__>("VariableNameList$", bind:"NewVariableNameList_");
                VariableNameList.SetCustomGetElementType((arr) => { return __WeVariable__.DefaultTemplate;});
                VariableNameList.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__VariableNameList__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__VariableNameList__ = (__Arr6__)_v_; }, false);
                VariableTypeList = Add<__TArray7__>("VariableTypeList$", bind:"NewVariableTypeList_");
                VariableTypeList.SetCustomGetElementType((arr) => { return __WeVariable3__.DefaultTemplate;});
                VariableTypeList.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__VariableTypeList__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__VariableTypeList__ = (__Arr7__)_v_; }, false);
                NewWebPublicationName = Add<__TString__>("NewWebPublicationName$");
                NewWebPublicationName.DefaultValue = "";
                NewWebPublicationName.Editable = true;
                NewWebPublicationName.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewWebPublicationName__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewWebPublicationName__ = (System.String)_v_; }, false);
                NewWebPublicationUrl = Add<__TString__>("NewWebPublicationUrl$");
                NewWebPublicationUrl.DefaultValue = "";
                NewWebPublicationUrl.Editable = true;
                NewWebPublicationUrl.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewWebPublicationUrl__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewWebPublicationUrl__ = (System.String)_v_; }, false);
                NewWebPublicationDescription = Add<__TString__>("NewWebPublicationDescription$");
                NewWebPublicationDescription.DefaultValue = "";
                NewWebPublicationDescription.Editable = true;
                NewWebPublicationDescription.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewWebPublicationDescription__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewWebPublicationDescription__ = (System.String)_v_; }, false);
                NewFeatureNameOther = Add<__TString__>("NewFeatureNameOther$");
                NewFeatureNameOther.DefaultValue = "";
                NewFeatureNameOther.Editable = true;
                NewFeatureNameOther.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewFeatureNameOther__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewFeatureNameOther__ = (System.String)_v_; }, false);
                NewFeatureName = Add<__TString__>("NewFeatureName$");
                NewFeatureName.DefaultValue = "";
                NewFeatureName.Editable = true;
                NewFeatureName.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewFeatureName__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewFeatureName__ = (System.String)_v_; }, false);
                NewActionNameOther = Add<__TString__>("NewActionNameOther$");
                NewActionNameOther.DefaultValue = "";
                NewActionNameOther.Editable = true;
                NewActionNameOther.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewActionNameOther__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewActionNameOther__ = (System.String)_v_; }, false);
                Pagging = Add<__TBool__>("Pagging$");
                Pagging.DefaultValue = false;
                Pagging.Editable = true;
                Pagging.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__Pagging__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__Pagging__ = (System.Boolean)_v_; }, false);
                PaggingUrlParameters = Add<__TString__>("PaggingUrlParameters$");
                PaggingUrlParameters.DefaultValue = "";
                PaggingUrlParameters.Editable = true;
                PaggingUrlParameters.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__PaggingUrlParameters__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__PaggingUrlParameters__ = (System.String)_v_; }, false);
                NewActionName = Add<__TString__>("NewActionName$");
                NewActionName.DefaultValue = "";
                NewActionName.Editable = true;
                NewActionName.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewActionName__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewActionName__ = (System.String)_v_; }, false);
                NewActionUrl = Add<__TString__>("NewActionUrl$");
                NewActionUrl.DefaultValue = "";
                NewActionUrl.Editable = true;
                NewActionUrl.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewActionUrl__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewActionUrl__ = (System.String)_v_; }, false);
                NewActionHttpType = Add<__TString__>("NewActionHttpType$");
                NewActionHttpType.DefaultValue = "";
                NewActionHttpType.Editable = true;
                NewActionHttpType.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewActionHttpType__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewActionHttpType__ = (System.String)_v_; }, false);
                NewActionHttpBody = Add<__TString__>("NewActionHttpBody$");
                NewActionHttpBody.DefaultValue = "";
                NewActionHttpBody.Editable = true;
                NewActionHttpBody.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewActionHttpBody__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewActionHttpBody__ = (System.String)_v_; }, false);
                NewActionOrderInFeature = Add<__TLong__>("NewActionOrderInFeature$");
                NewActionOrderInFeature.DefaultValue = 0L;
                NewActionOrderInFeature.Editable = true;
                NewActionOrderInFeature.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewActionOrderInFeature__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewActionOrderInFeature__ = (System.Int64)_v_; }, false);
                NewVariableValue = Add<__TString__>("NewVariableValue$");
                NewVariableValue.DefaultValue = "";
                NewVariableValue.Editable = true;
                NewVariableValue.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewVariableValue__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewVariableValue__ = (System.String)_v_; }, false);
                NewVariableNameOther = Add<__TString__>("NewVariableNameOther$");
                NewVariableNameOther.DefaultValue = "";
                NewVariableNameOther.Editable = true;
                NewVariableNameOther.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewVariableNameOther__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewVariableNameOther__ = (System.String)_v_; }, false);
                NewVariableName = Add<__TString__>("NewVariableName$");
                NewVariableName.DefaultValue = "";
                NewVariableName.Editable = true;
                NewVariableName.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewVariableName__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewVariableName__ = (System.String)_v_; }, false);
                NewVariableTypeOther = Add<__TString__>("NewVariableTypeOther$");
                NewVariableTypeOther.DefaultValue = "";
                NewVariableTypeOther.Editable = true;
                NewVariableTypeOther.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewVariableTypeOther__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewVariableTypeOther__ = (System.String)_v_; }, false);
                NewVariableType = Add<__TString__>("NewVariableType$");
                NewVariableType.DefaultValue = "";
                NewVariableType.Editable = true;
                NewVariableType.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewVariableType__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewVariableType__ = (System.String)_v_; }, false);
                NewVariableRegex = Add<__TString__>("NewVariableRegex$");
                NewVariableRegex.DefaultValue = "";
                NewVariableRegex.Editable = true;
                NewVariableRegex.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__NewVariableRegex__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__NewVariableRegex__ = (System.String)_v_; }, false);
                AddWebSite = Add<__TLong__>("AddWebSite$");
                AddWebSite.DefaultValue = 0L;
                AddWebSite.Editable = true;
                AddWebSite.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__AddWebSite__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__AddWebSite__ = (System.Int64)_v_; }, false);
                AddWebSite.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddWebSite() { App = (WebPublicationsViewNew)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsViewNew)pup).Handle((Input.AddWebSite)input); });
                DeleteWebSite = Add<__TLong__>("DeleteWebSite$");
                DeleteWebSite.DefaultValue = 0L;
                DeleteWebSite.Editable = true;
                DeleteWebSite.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__DeleteWebSite__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__DeleteWebSite__ = (System.Int64)_v_; }, false);
                DeleteWebSite.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteWebSite() { App = (WebPublicationsViewNew)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsViewNew)pup).Handle((Input.DeleteWebSite)input); });
                UpdateWebSite = Add<__TLong__>("UpdateWebSite$");
                UpdateWebSite.DefaultValue = 0L;
                UpdateWebSite.Editable = true;
                UpdateWebSite.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__UpdateWebSite__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__UpdateWebSite__ = (System.Int64)_v_; }, false);
                AddFeature = Add<__TLong__>("AddFeature$");
                AddFeature.DefaultValue = 0L;
                AddFeature.Editable = true;
                AddFeature.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__AddFeature__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__AddFeature__ = (System.Int64)_v_; }, false);
                AddFeature.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddFeature() { App = (WebPublicationsViewNew)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsViewNew)pup).Handle((Input.AddFeature)input); });
                DeleteFeature = Add<__TLong__>("DeleteFeature$");
                DeleteFeature.DefaultValue = 0L;
                DeleteFeature.Editable = true;
                DeleteFeature.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__DeleteFeature__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__DeleteFeature__ = (System.Int64)_v_; }, false);
                DeleteFeature.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteFeature() { App = (WebPublicationsViewNew)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsViewNew)pup).Handle((Input.DeleteFeature)input); });
                UpdateFeature = Add<__TLong__>("UpdateFeature$");
                UpdateFeature.DefaultValue = 0L;
                UpdateFeature.Editable = true;
                UpdateFeature.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__UpdateFeature__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__UpdateFeature__ = (System.Int64)_v_; }, false);
                AddAction = Add<__TLong__>("AddAction$");
                AddAction.DefaultValue = 0L;
                AddAction.Editable = true;
                AddAction.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__AddAction__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__AddAction__ = (System.Int64)_v_; }, false);
                AddAction.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddAction() { App = (WebPublicationsViewNew)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsViewNew)pup).Handle((Input.AddAction)input); });
                DeleteAction = Add<__TLong__>("DeleteAction$");
                DeleteAction.DefaultValue = 0L;
                DeleteAction.Editable = true;
                DeleteAction.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__DeleteAction__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__DeleteAction__ = (System.Int64)_v_; }, false);
                DeleteAction.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteAction() { App = (WebPublicationsViewNew)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsViewNew)pup).Handle((Input.DeleteAction)input); });
                UpdateAction = Add<__TLong__>("UpdateAction$");
                UpdateAction.DefaultValue = 0L;
                UpdateAction.Editable = true;
                UpdateAction.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__UpdateAction__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__UpdateAction__ = (System.Int64)_v_; }, false);
                AddVariable = Add<__TLong__>("AddVariable$");
                AddVariable.DefaultValue = 0L;
                AddVariable.Editable = true;
                AddVariable.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__AddVariable__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__AddVariable__ = (System.Int64)_v_; }, false);
                AddVariable.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddVariable() { App = (WebPublicationsViewNew)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsViewNew)pup).Handle((Input.AddVariable)input); });
                DeleteVariable = Add<__TLong__>("DeleteVariable$");
                DeleteVariable.DefaultValue = 0L;
                DeleteVariable.Editable = true;
                DeleteVariable.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__DeleteVariable__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__DeleteVariable__ = (System.Int64)_v_; }, false);
                DeleteVariable.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteVariable() { App = (WebPublicationsViewNew)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsViewNew)pup).Handle((Input.DeleteVariable)input); });
                UpdateVariable = Add<__TLong__>("UpdateVariable$");
                UpdateVariable.DefaultValue = 0L;
                UpdateVariable.Editable = true;
                UpdateVariable.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__UpdateVariable__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__UpdateVariable__ = (System.Int64)_v_; }, false);
                FetchWebPublications = Add<__TLong__>("FetchWebPublications$");
                FetchWebPublications.DefaultValue = 0L;
                FetchWebPublications.Editable = true;
                FetchWebPublications.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__FetchWebPublications__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__FetchWebPublications__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __WebPubli__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ WebPublications;
            public __TString__ SelectedWebPublicationID;
            public __WWeSchema__ WebPublication;
            public __TString__ SelectedFeatureID;
            public __WFeSchema__ Feature;
            public __TString__ SelectedActionID;
            public __WAcSchema__ Action;
            public __TString__ SelectedVariableID;
            public __WVaSchema__ Variable;
            public __TArray4__ FeatureNameList;
            public __TArray5__ ActionNameList;
            public __TArray6__ VariableNameList;
            public __TArray7__ VariableTypeList;
            public __TString__ NewWebPublicationName;
            public __TString__ NewWebPublicationUrl;
            public __TString__ NewWebPublicationDescription;
            public __TString__ NewFeatureNameOther;
            public __TString__ NewFeatureName;
            public __TString__ NewActionNameOther;
            public __TBool__ Pagging;
            public __TString__ PaggingUrlParameters;
            public __TString__ NewActionName;
            public __TString__ NewActionUrl;
            public __TString__ NewActionHttpType;
            public __TString__ NewActionHttpBody;
            public __TLong__ NewActionOrderInFeature;
            public __TString__ NewVariableValue;
            public __TString__ NewVariableNameOther;
            public __TString__ NewVariableName;
            public __TString__ NewVariableTypeOther;
            public __TString__ NewVariableType;
            public __TString__ NewVariableRegex;
            public __TLong__ AddWebSite;
            public __TLong__ DeleteWebSite;
            public __TLong__ UpdateWebSite;
            public __TLong__ AddFeature;
            public __TLong__ DeleteFeature;
            public __TLong__ UpdateFeature;
            public __TLong__ AddAction;
            public __TLong__ DeleteAction;
            public __TLong__ UpdateAction;
            public __TLong__ AddVariable;
            public __TLong__ DeleteVariable;
            public __TLong__ UpdateVariable;
            public __TLong__ FetchWebPublications;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
#line 2 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Html.Getter(this); }
#line 2 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Html.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ WebPublications {
#line 12 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.WebPublications.Getter(this); }
#line 12 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.WebPublications.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedWebPublicationID {
#line 19 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.SelectedWebPublicationID.Getter(this); }
#line 19 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.SelectedWebPublicationID.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __WeWebPubli__ WebPublication {
#line 33 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return (__WeWebPubli__)Template.WebPublication.Getter(this); }
#line 33 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.WebPublication.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedFeatureID {
#line 35 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.SelectedFeatureID.Getter(this); }
#line 35 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.SelectedFeatureID.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __WeFeatureJ__ Feature {
#line 53 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return (__WeFeatureJ__)Template.Feature.Getter(this); }
#line 53 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Feature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedActionID {
#line 55 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.SelectedActionID.Getter(this); }
#line 55 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.SelectedActionID.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __WeActionJs__ Action {
#line 77 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return (__WeActionJs__)Template.Action.Getter(this); }
#line 77 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Action.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedVariableID {
#line 79 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.SelectedVariableID.Getter(this); }
#line 79 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.SelectedVariableID.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __WeVariable6__ Variable {
#line 88 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return (__WeVariable6__)Template.Variable.Getter(this); }
#line 88 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Variable.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr4__ FeatureNameList {
#line 93 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.FeatureNameList.Getter(this); }
#line 93 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.FeatureNameList.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr5__ ActionNameList {
#line 98 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.ActionNameList.Getter(this); }
#line 98 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.ActionNameList.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr6__ VariableNameList {
#line 103 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.VariableNameList.Getter(this); }
#line 103 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.VariableNameList.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr7__ VariableTypeList {
#line 108 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.VariableTypeList.Getter(this); }
#line 108 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.VariableTypeList.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewWebPublicationName {
#line 110 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewWebPublicationName.Getter(this); }
#line 110 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewWebPublicationName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewWebPublicationUrl {
#line 111 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewWebPublicationUrl.Getter(this); }
#line 111 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewWebPublicationUrl.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewWebPublicationDescription {
#line 112 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewWebPublicationDescription.Getter(this); }
#line 112 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewWebPublicationDescription.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewFeatureNameOther {
#line 113 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewFeatureNameOther.Getter(this); }
#line 113 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewFeatureNameOther.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewFeatureName {
#line 114 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewFeatureName.Getter(this); }
#line 114 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewFeatureName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionNameOther {
#line 115 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewActionNameOther.Getter(this); }
#line 115 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewActionNameOther.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean Pagging {
#line 123 "JOCKE4"
    get {
#line hidden
        return Template.Pagging.Getter(this); }
#line 123 "JOCKE4"
    set {
#line hidden
        Template.Pagging.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String PaggingUrlParameters {
#line 117 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.PaggingUrlParameters.Getter(this); }
#line 117 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.PaggingUrlParameters.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionName {
#line 118 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewActionName.Getter(this); }
#line 118 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewActionName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionUrl {
#line 119 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewActionUrl.Getter(this); }
#line 119 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewActionUrl.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionHttpType {
#line 120 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewActionHttpType.Getter(this); }
#line 120 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewActionHttpType.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionHttpBody {
#line 121 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewActionHttpBody.Getter(this); }
#line 121 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewActionHttpBody.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewActionOrderInFeature {
#line 122 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewActionOrderInFeature.Getter(this); }
#line 122 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewActionOrderInFeature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableValue {
#line 123 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewVariableValue.Getter(this); }
#line 123 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewVariableValue.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableNameOther {
#line 124 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewVariableNameOther.Getter(this); }
#line 124 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewVariableNameOther.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableName {
#line 125 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewVariableName.Getter(this); }
#line 125 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewVariableName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableTypeOther {
#line 126 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewVariableTypeOther.Getter(this); }
#line 126 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewVariableTypeOther.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableType {
#line 127 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewVariableType.Getter(this); }
#line 127 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewVariableType.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableRegex {
#line 128 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.NewVariableRegex.Getter(this); }
#line 128 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.NewVariableRegex.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddWebSite {
#line 129 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.AddWebSite.Getter(this); }
#line 129 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.AddWebSite.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteWebSite {
#line 130 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.DeleteWebSite.Getter(this); }
#line 130 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.DeleteWebSite.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 UpdateWebSite {
#line 131 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.UpdateWebSite.Getter(this); }
#line 131 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.UpdateWebSite.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddFeature {
#line 132 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.AddFeature.Getter(this); }
#line 132 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.AddFeature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteFeature {
#line 133 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.DeleteFeature.Getter(this); }
#line 133 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.DeleteFeature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 UpdateFeature {
#line 134 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.UpdateFeature.Getter(this); }
#line 134 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.UpdateFeature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddAction {
#line 135 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.AddAction.Getter(this); }
#line 135 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.AddAction.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteAction {
#line 136 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.DeleteAction.Getter(this); }
#line 136 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.DeleteAction.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 UpdateAction {
#line 137 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.UpdateAction.Getter(this); }
#line 137 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.UpdateAction.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddVariable {
#line 138 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.AddVariable.Getter(this); }
#line 138 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.AddVariable.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteVariable {
#line 139 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.DeleteVariable.Getter(this); }
#line 139 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.DeleteVariable.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 UpdateVariable {
#line 140 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.UpdateVariable.Getter(this); }
#line 140 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.UpdateVariable.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 FetchWebPublications {
#line 142 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.FetchWebPublications.Getter(this); }
#line 142 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.FetchWebPublications.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class WebPublicationJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WWeSchema__ DefaultTemplate = new __WWeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public WebPublicationJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public WebPublicationJson(__WWeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WWeSchema__ Template { get { return (__WWeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Name__;
        private System.String __bf__Url__;
        private System.String __bf__Description__;
        private __Arr1__ __bf__Features__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeWebPubli__);
                    ClassName = "WebPublicationJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "Facebook.com";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__WeWebPubli__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__WeWebPubli__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Url = Add<__TString__>("Url$");
                    Url.DefaultValue = "www.facebook.com";
                    Url.Editable = true;
                    Url.SetCustomAccessors((_p_) => { return ((__WeWebPubli__)_p_).__bf__Url__; }, (_p_, _v_) => { ((__WeWebPubli__)_p_).__bf__Url__ = (System.String)_v_; }, false);
                    Description = Add<__TString__>("Description$");
                    Description.DefaultValue = "DescriptionDescription";
                    Description.Editable = true;
                    Description.SetCustomAccessors((_p_) => { return ((__WeWebPubli__)_p_).__bf__Description__; }, (_p_, _v_) => { ((__WeWebPubli__)_p_).__bf__Description__ = (System.String)_v_; }, false);
                    Features = Add<__TArray1__>("Features$");
                    Features.SetCustomGetElementType((arr) => { return __FeatureO__.DefaultTemplate;});
                    Features.SetCustomAccessors((_p_) => { return ((__WeWebPubli__)_p_).__bf__Features__; }, (_p_, _v_) => { ((__WeWebPubli__)_p_).__bf__Features__ = (__Arr1__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeWebPubli__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TString__ Url;
                public __TString__ Description;
                public __TArray1__ Features;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 23 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 23 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Url {
#line 24 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Url.Getter(this); }
#line 24 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Url.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Description {
#line 25 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Description.Getter(this); }
#line 25 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Description.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr1__ Features {
#line 33 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Features.Getter(this); }
#line 33 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Features.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__WeWebPubli__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Url : Input<__WeWebPubli__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Description : Input<__WeWebPubli__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class FeatureJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WFeSchema__ DefaultTemplate = new __WFeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FeatureJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FeatureJson(__WFeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WFeSchema__ Template { get { return (__WFeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Name__;
        private __Arr2__ __bf__Actions__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeFeatureJ__);
                    ClassName = "FeatureJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__WeFeatureJ__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__WeFeatureJ__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Actions = Add<__TArray2__>("Actions$");
                    Actions.SetCustomGetElementType((arr) => { return __ActionOb__.DefaultTemplate;});
                    Actions.SetCustomAccessors((_p_) => { return ((__WeFeatureJ__)_p_).__bf__Actions__; }, (_p_, _v_) => { ((__WeFeatureJ__)_p_).__bf__Actions__ = (__Arr2__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeFeatureJ__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TArray2__ Actions;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 39 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 39 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr2__ Actions {
#line 53 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Actions.Getter(this); }
#line 53 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Actions.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__WeFeatureJ__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class ActionJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WAcSchema__ DefaultTemplate = new __WAcSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ActionJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ActionJson(__WAcSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WAcSchema__ Template { get { return (__WAcSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Name__;
        private System.String __bf__ObId__;
        private System.String __bf__ActionUrl__;
        private System.String __bf__HttpBody__;
        private System.String __bf__HttpType__;
        private System.Int64 __bf__OrderInFeature__;
        private System.Boolean __bf__Pagging__;
        private System.String __bf__PaggingUrlParameters__;
        private __Arr3__ __bf__Variables__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeActionJs__);
                    ClassName = "ActionJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__WeActionJs__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__WeActionJs__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    ObId = Add<__TString__>("ObId");
                    ObId.DefaultValue = "";
                    ObId.SetCustomAccessors((_p_) => { return ((__WeActionJs__)_p_).__bf__ObId__; }, (_p_, _v_) => { ((__WeActionJs__)_p_).__bf__ObId__ = (System.String)_v_; }, false);
                    ActionUrl = Add<__TString__>("ActionUrl$");
                    ActionUrl.DefaultValue = "";
                    ActionUrl.Editable = true;
                    ActionUrl.SetCustomAccessors((_p_) => { return ((__WeActionJs__)_p_).__bf__ActionUrl__; }, (_p_, _v_) => { ((__WeActionJs__)_p_).__bf__ActionUrl__ = (System.String)_v_; }, false);
                    HttpBody = Add<__TString__>("HttpBody$");
                    HttpBody.DefaultValue = "";
                    HttpBody.Editable = true;
                    HttpBody.SetCustomAccessors((_p_) => { return ((__WeActionJs__)_p_).__bf__HttpBody__; }, (_p_, _v_) => { ((__WeActionJs__)_p_).__bf__HttpBody__ = (System.String)_v_; }, false);
                    HttpType = Add<__TString__>("HttpType$");
                    HttpType.DefaultValue = "";
                    HttpType.Editable = true;
                    HttpType.SetCustomAccessors((_p_) => { return ((__WeActionJs__)_p_).__bf__HttpType__; }, (_p_, _v_) => { ((__WeActionJs__)_p_).__bf__HttpType__ = (System.String)_v_; }, false);
                    OrderInFeature = Add<__TLong__>("OrderInFeature$");
                    OrderInFeature.DefaultValue = 0L;
                    OrderInFeature.Editable = true;
                    OrderInFeature.SetCustomAccessors((_p_) => { return ((__WeActionJs__)_p_).__bf__OrderInFeature__; }, (_p_, _v_) => { ((__WeActionJs__)_p_).__bf__OrderInFeature__ = (System.Int64)_v_; }, false);
                    Pagging = Add<__TBool__>("Pagging$");
                    Pagging.DefaultValue = true;
                    Pagging.Editable = true;
                    Pagging.SetCustomAccessors((_p_) => { return ((__WeActionJs__)_p_).__bf__Pagging__; }, (_p_, _v_) => { ((__WeActionJs__)_p_).__bf__Pagging__ = (System.Boolean)_v_; }, false);
                    PaggingUrlParameters = Add<__TString__>("PaggingUrlParameters$");
                    PaggingUrlParameters.DefaultValue = "";
                    PaggingUrlParameters.Editable = true;
                    PaggingUrlParameters.SetCustomAccessors((_p_) => { return ((__WeActionJs__)_p_).__bf__PaggingUrlParameters__; }, (_p_, _v_) => { ((__WeActionJs__)_p_).__bf__PaggingUrlParameters__ = (System.String)_v_; }, false);
                    Variables = Add<__TArray3__>("Variables$");
                    Variables.SetCustomGetElementType((arr) => { return __Variable__.DefaultTemplate;});
                    Variables.SetCustomAccessors((_p_) => { return ((__WeActionJs__)_p_).__bf__Variables__; }, (_p_, _v_) => { ((__WeActionJs__)_p_).__bf__Variables__ = (__Arr3__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeActionJs__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TString__ ObId;
                public __TString__ ActionUrl;
                public __TString__ HttpBody;
                public __TString__ HttpType;
                public __TLong__ OrderInFeature;
                public __TBool__ Pagging;
                public __TString__ PaggingUrlParameters;
                public __TArray3__ Variables;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 59 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 59 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ObId {
#line 60 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.ObId.Getter(this); }
#line 60 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.ObId.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ActionUrl {
#line 61 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.ActionUrl.Getter(this); }
#line 61 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.ActionUrl.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String HttpBody {
#line 62 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.HttpBody.Getter(this); }
#line 62 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.HttpBody.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String HttpType {
#line 63 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.HttpType.Getter(this); }
#line 63 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.HttpType.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 OrderInFeature {
#line 64 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.OrderInFeature.Getter(this); }
#line 64 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.OrderInFeature.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Boolean Pagging {
#line 123 "JOCKE3"
    get {
#line hidden
        return Template.Pagging.Getter(this); }
#line 123 "JOCKE3"
    set {
#line hidden
        Template.Pagging.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String PaggingUrlParameters {
#line 66 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.PaggingUrlParameters.Getter(this); }
#line 66 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.PaggingUrlParameters.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr3__ Variables {
#line 77 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Variables.Getter(this); }
#line 77 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Variables.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__WeActionJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ObId : Input<__WeActionJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ActionUrl : Input<__WeActionJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class HttpBody : Input<__WeActionJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class HttpType : Input<__WeActionJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class OrderInFeature : Input<__WeActionJs__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Pagging : Input<__WeActionJs__, __TBool__, bool> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class PaggingUrlParameters : Input<__WeActionJs__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class VariableJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WVaSchema__ DefaultTemplate = new __WVaSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableJson(__WVaSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WVaSchema__ Template { get { return (__WVaSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Name__;
        private System.String __bf__ObId__;
        private System.String __bf__VariableType__;
        private System.String __bf__Regex__;
        private System.String __bf__VariableValue__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeVariable6__);
                    ClassName = "VariableJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__WeVariable6__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__WeVariable6__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    ObId = Add<__TString__>("ObId");
                    ObId.DefaultValue = "";
                    ObId.SetCustomAccessors((_p_) => { return ((__WeVariable6__)_p_).__bf__ObId__; }, (_p_, _v_) => { ((__WeVariable6__)_p_).__bf__ObId__ = (System.String)_v_; }, false);
                    VariableType = Add<__TString__>("VariableType$");
                    VariableType.DefaultValue = "";
                    VariableType.Editable = true;
                    VariableType.SetCustomAccessors((_p_) => { return ((__WeVariable6__)_p_).__bf__VariableType__; }, (_p_, _v_) => { ((__WeVariable6__)_p_).__bf__VariableType__ = (System.String)_v_; }, false);
                    Regex = Add<__TString__>("Regex$");
                    Regex.DefaultValue = "";
                    Regex.Editable = true;
                    Regex.SetCustomAccessors((_p_) => { return ((__WeVariable6__)_p_).__bf__Regex__; }, (_p_, _v_) => { ((__WeVariable6__)_p_).__bf__Regex__ = (System.String)_v_; }, false);
                    VariableValue = Add<__TString__>("VariableValue$");
                    VariableValue.DefaultValue = "";
                    VariableValue.Editable = true;
                    VariableValue.SetCustomAccessors((_p_) => { return ((__WeVariable6__)_p_).__bf__VariableValue__; }, (_p_, _v_) => { ((__WeVariable6__)_p_).__bf__VariableValue__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeVariable6__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TString__ ObId;
                public __TString__ VariableType;
                public __TString__ Regex;
                public __TString__ VariableValue;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 83 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 83 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ObId {
#line 84 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.ObId.Getter(this); }
#line 84 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.ObId.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String VariableType {
#line 85 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.VariableType.Getter(this); }
#line 85 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.VariableType.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Regex {
#line 86 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Regex.Getter(this); }
#line 86 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Regex.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String VariableValue {
#line 88 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.VariableValue.Getter(this); }
#line 88 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.VariableValue.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__WeVariable6__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ObId : Input<__WeVariable6__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class VariableType : Input<__WeVariable6__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Regex : Input<__WeVariable6__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class VariableValue : Input<__WeVariable6__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class FeatureNameListElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WFeSchema1__ DefaultTemplate = new __WFeSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FeatureNameListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FeatureNameListElementJson(__WFeSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WFeSchema1__ Template { get { return (__WFeSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Name__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeFeatureN__);
                    ClassName = "FeatureNameListElementJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__WeFeatureN__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__WeFeatureN__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeFeatureN__(this) { Parent = parent }; }
                public __TString__ Name;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 92 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 92 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__WeFeatureN__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class ActionNameListElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WAcSchema1__ DefaultTemplate = new __WAcSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ActionNameListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ActionNameListElementJson(__WAcSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WAcSchema1__ Template { get { return (__WAcSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Name__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeActionNa__);
                    ClassName = "ActionNameListElementJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__WeActionNa__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__WeActionNa__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeActionNa__(this) { Parent = parent }; }
                public __TString__ Name;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 97 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 97 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__WeActionNa__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class VariableNameListElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WVaSchema1__ DefaultTemplate = new __WVaSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableNameListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableNameListElementJson(__WVaSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WVaSchema1__ Template { get { return (__WVaSchema1__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Name__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeVariable__);
                    ClassName = "VariableNameListElementJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__WeVariable__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__WeVariable__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeVariable__(this) { Parent = parent }; }
                public __TString__ Name;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 102 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 102 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__WeVariable__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class VariableTypeListElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WVaSchema2__ DefaultTemplate = new __WVaSchema2__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableTypeListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableTypeListElementJson(__WVaSchema2__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WVaSchema2__ Template { get { return (__WVaSchema2__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__VariableType__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__WeVariable3__);
                    ClassName = "VariableTypeListElementJson";
                    Properties.ClearExposed();
                    VariableType = Add<__TString__>("VariableType$");
                    VariableType.DefaultValue = "";
                    VariableType.Editable = true;
                    VariableType.SetCustomAccessors((_p_) => { return ((__WeVariable3__)_p_).__bf__VariableType__; }, (_p_, _v_) => { ((__WeVariable3__)_p_).__bf__VariableType__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeVariable3__(this) { Parent = parent }; }
                public __TString__ VariableType;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String VariableType {
#line 107 "Server\Partials\WebPublicationsViewNew.json"
    get {
#line hidden
        return Template.VariableType.Getter(this); }
#line 107 "Server\Partials\WebPublicationsViewNew.json"
    set {
#line hidden
        Template.VariableType.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class VariableType : Input<__WeVariable3__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedWebPublicationID : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedFeatureID : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedActionID : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedVariableID : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewWebPublicationName : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewWebPublicationUrl : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewWebPublicationDescription : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewFeatureNameOther : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewFeatureName : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewActionNameOther : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Pagging : Input<__WebPubli__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class PaggingUrlParameters : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewActionName : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewActionUrl : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewActionHttpType : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewActionHttpBody : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewActionOrderInFeature : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewVariableValue : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewVariableNameOther : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewVariableName : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewVariableTypeOther : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewVariableType : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewVariableRegex : Input<__WebPubli__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class AddWebSite : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class DeleteWebSite : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class UpdateWebSite : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AddFeature : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class DeleteFeature : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class UpdateFeature : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AddAction : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class DeleteAction : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class UpdateAction : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AddVariable : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class DeleteVariable : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class UpdateVariable : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class FetchWebPublications : Input<__WebPubli__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108