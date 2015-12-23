// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\WebPublicationsView.json"
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

using __WVaSchema1__ = global::OneKey.Server.Partials.WebPublicationsView.VariableTypeListElementJson.JsonByExample.Schema;
using __SSeVariable1__ = global::OneKey.Server.Partials.SelectedActionView.SelectedVariableJson.Input.VariableValue;
using __Selected6__ = global::OneKey.Server.Partials.SelectedActionView.Input;
using __SeName__ = global::OneKey.Server.Partials.SelectedActionView.Input.Name;
using __SeActionUr__ = global::OneKey.Server.Partials.SelectedActionView.Input.ActionUrl;
using __SeHttpBody__ = global::OneKey.Server.Partials.SelectedActionView.Input.HttpBody;
using __SeHttpType__ = global::OneKey.Server.Partials.SelectedActionView.Input.HttpType;
using __SeOrderInF__ = global::OneKey.Server.Partials.SelectedActionView.Input.OrderInFeature;
using __SePagging__ = global::OneKey.Server.Partials.SelectedActionView.Input.Pagging;
using __SePaggingU__ = global::OneKey.Server.Partials.SelectedActionView.Input.PaggingUrlParameters;
using __SeSelected3__ = global::OneKey.Server.Partials.SelectedActionView.Input.SelectedVariableId;
using __Selected7__ = global::OneKey.Server.Partials.SelectedFeatureView.Input;
using __SeName1__ = global::OneKey.Server.Partials.SelectedFeatureView.Input.Name;
using __SeSelected4__ = global::OneKey.Server.Partials.SelectedFeatureView.Input.SelectedActionID;
using __Selected8__ = global::OneKey.Server.Partials.SelectedWebPublicationView.Input;
using __SeName2__ = global::OneKey.Server.Partials.SelectedWebPublicationView.Input.Name;
using __SSeRegex__ = global::OneKey.Server.Partials.SelectedActionView.SelectedVariableJson.Input.Regex;
using __SeUrl__ = global::OneKey.Server.Partials.SelectedWebPublicationView.Input.Url;
using __SSeVariable__ = global::OneKey.Server.Partials.SelectedActionView.SelectedVariableJson.Input.VariableType;
using __SeSelected2__ = global::OneKey.Server.Partials.SelectedActionView.SelectedVariableJson.Input;
using __WVaVariable__ = global::OneKey.Server.Partials.WebPublicationsView.VariableTypeListElementJson.Input.VariableType;
using __TArray7__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationsView.VariableTypeListElementJson>;
using __WebPubli1__ = global::OneKey.Server.Partials.WebPublicationsView.JsonByExample;
using __Arr__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationsView.WebPublicationsElementJson>;
using __Selected__ = global::OneKey.Server.Partials.SelectedWebPublicationView;
using __Selected1__ = global::OneKey.Server.Partials.SelectedWebPublicationView.JsonByExample;
using __Arr1__ = global::Starcounter.Arr<global::OneKey.Server.Partials.FeaturesView>;
using __Selected2__ = global::OneKey.Server.Partials.SelectedFeatureView;
using __Selected3__ = global::OneKey.Server.Partials.SelectedFeatureView.JsonByExample;
using __Arr2__ = global::Starcounter.Arr<global::OneKey.Server.Partials.ActionsView>;
using __Selected4__ = global::OneKey.Server.Partials.SelectedActionView;
using __Selected5__ = global::OneKey.Server.Partials.SelectedActionView.JsonByExample;
using __Arr3__ = global::Starcounter.Arr<global::OneKey.Server.Partials.VariablesView>;
using __SeSelected__ = global::OneKey.Server.Partials.SelectedActionView.SelectedVariableJson;
using __SeSelected1__ = global::OneKey.Server.Partials.SelectedActionView.SelectedVariableJson.JsonByExample;
using __SSeName__ = global::OneKey.Server.Partials.SelectedActionView.SelectedVariableJson.Input.Name;
using __SeDescript__ = global::OneKey.Server.Partials.SelectedWebPublicationView.Input.Description;
using __SeSelected5__ = global::OneKey.Server.Partials.SelectedWebPublicationView.Input.SelectedFeatureID;
using __Arr4__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationsView.FeatureNameListElementJson>;
using __WeNewVaria1__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewVariableNameOther;
using __WeNewVaria2__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewVariableName;
using __WeNewVaria3__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewVariableTypeOther;
using __WeNewVaria4__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewVariableType;
using __WeNewVaria5__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewVariableRegex;
using __WeAddWebSi__ = global::OneKey.Server.Partials.WebPublicationsView.Input.AddWebSite;
using __WeDeleteWe__ = global::OneKey.Server.Partials.WebPublicationsView.Input.DeleteWebSite;
using __WeUpdateWe__ = global::OneKey.Server.Partials.WebPublicationsView.Input.UpdateWebSite;
using __WeAddFeatu__ = global::OneKey.Server.Partials.WebPublicationsView.Input.AddFeature;
using __WeDeleteFe__ = global::OneKey.Server.Partials.WebPublicationsView.Input.DeleteFeature;
using __WeUpdateFe__ = global::OneKey.Server.Partials.WebPublicationsView.Input.UpdateFeature;
using __WeAddActio__ = global::OneKey.Server.Partials.WebPublicationsView.Input.AddAction;
using __WeDeleteAc__ = global::OneKey.Server.Partials.WebPublicationsView.Input.DeleteAction;
using __WeUpdateAc__ = global::OneKey.Server.Partials.WebPublicationsView.Input.UpdateAction;
using __WeAddVaria__ = global::OneKey.Server.Partials.WebPublicationsView.Input.AddVariable;
using __WeNewVaria__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewVariableValue;
using __WeNewActio5__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewActionOrderInFeature;
using __WeNewActio4__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewActionHttpBody;
using __WeNewActio3__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewActionHttpType;
using __Arr5__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationsView.ActionNameListElementJson>;
using __Arr6__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationsView.VariableNameListElementJson>;
using __Arr7__ = global::Starcounter.Arr<global::OneKey.Server.Partials.WebPublicationsView.VariableTypeListElementJson>;
using __WebPubli2__ = global::OneKey.Server.Partials.WebPublicationsView.Input;
using __WeHtml__ = global::OneKey.Server.Partials.WebPublicationsView.Input.Html;
using __WeSelected__ = global::OneKey.Server.Partials.WebPublicationsView.Input.SelectedWebPublicationID;
using __WeNewWebPu__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewWebPublicationName;
using __WeVariable5__ = global::OneKey.Server.Partials.WebPublicationsView.VariableTypeListElementJson.Input;
using __WeNewWebPu1__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewWebPublicationUrl;
using __WeNewFeatu__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewFeatureNameOther;
using __WeNewFeatu1__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewFeatureName;
using __WeNewActio__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewActionNameOther;
using __WePagging__ = global::OneKey.Server.Partials.WebPublicationsView.Input.Pagging;
using __WePaggingU__ = global::OneKey.Server.Partials.WebPublicationsView.Input.PaggingUrlParameters;
using __WeNewActio1__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewActionName;
using __WeNewActio2__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewActionUrl;
using __WeNewWebPu2__ = global::OneKey.Server.Partials.WebPublicationsView.Input.NewWebPublicationDescription;
using __WeVariable4__ = global::OneKey.Server.Partials.WebPublicationsView.VariableTypeListElementJson.JsonByExample;
using __WeUpdateVa__ = global::OneKey.Server.Partials.WebPublicationsView.Input.UpdateVariable;
using __WeVariable3__ = global::OneKey.Server.Partials.WebPublicationsView.VariableTypeListElementJson;
using __AcHttpBody__ = global::OneKey.Server.Partials.ActionsView.Input.HttpBody;
using __WeDeleteVa__ = global::OneKey.Server.Partials.WebPublicationsView.Input.DeleteVariable;
using __AcName__ = global::OneKey.Server.Partials.ActionsView.Input.Name;
using __AcFeatureN__ = global::OneKey.Server.Partials.ActionsView.Input.FeatureName;
using __AcWebPubli__ = global::OneKey.Server.Partials.ActionsView.Input.WebPublicationName;
using __ActionsV2__ = global::OneKey.Server.Partials.ActionsView.Input;
using __ActionsV1__ = global::OneKey.Server.Partials.ActionsView.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __AcSchema__ = global::OneKey.Server.Partials.ActionsView.JsonByExample.Schema;
using __ActionsV__ = global::OneKey.Server.Partials.ActionsView;
using __SeSchema1__ = global::OneKey.Server.Partials.SelectedFeatureView.JsonByExample.Schema;
using __TArray1__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.FeaturesView>;
using __FeName__ = global::OneKey.Server.Partials.FeaturesView.Input.Name;
using __FeWebPubli__ = global::OneKey.Server.Partials.FeaturesView.Input.WebPublicationName;
using __Features2__ = global::OneKey.Server.Partials.FeaturesView.Input;
using __Features1__ = global::OneKey.Server.Partials.FeaturesView.JsonByExample;
using __FeSchema__ = global::OneKey.Server.Partials.FeaturesView.JsonByExample.Schema;
using __WebPubli__ = global::OneKey.Server.Partials.WebPublicationsView;
using __WeSchema__ = global::OneKey.Server.Partials.WebPublicationsView.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __WeWebPubli__ = global::OneKey.Server.Partials.WebPublicationsView.WebPublicationsElementJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __AcHttpType__ = global::OneKey.Server.Partials.ActionsView.Input.HttpType;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __WeWebPubli1__ = global::OneKey.Server.Partials.WebPublicationsView.WebPublicationsElementJson.JsonByExample;
using __WeWebPubli2__ = global::OneKey.Server.Partials.WebPublicationsView.WebPublicationsElementJson.Input;
using __WWeName__ = global::OneKey.Server.Partials.WebPublicationsView.WebPublicationsElementJson.Input.Name;
using __TArray__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationsView.WebPublicationsElementJson>;
using __SeSchema__ = global::OneKey.Server.Partials.SelectedWebPublicationView.JsonByExample.Schema;
using __Features__ = global::OneKey.Server.Partials.FeaturesView;
using __WWeSchema__ = global::OneKey.Server.Partials.WebPublicationsView.WebPublicationsElementJson.JsonByExample.Schema;
using __AcOrderInF__ = global::OneKey.Server.Partials.ActionsView.Input.OrderInFeature;
using __AcActionUr__ = global::OneKey.Server.Partials.ActionsView.Input.ActionUrl;
using __SeSchema2__ = global::OneKey.Server.Partials.SelectedActionView.JsonByExample.Schema;
using __WFeName__ = global::OneKey.Server.Partials.WebPublicationsView.FeatureNameListElementJson.Input.Name;
using __TArray2__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.ActionsView>;
using __WeActionNa__ = global::OneKey.Server.Partials.WebPublicationsView.ActionNameListElementJson;
using __WAcSchema__ = global::OneKey.Server.Partials.WebPublicationsView.ActionNameListElementJson.JsonByExample.Schema;
using __WeActionNa1__ = global::OneKey.Server.Partials.WebPublicationsView.ActionNameListElementJson.JsonByExample;
using __WeActionNa2__ = global::OneKey.Server.Partials.WebPublicationsView.ActionNameListElementJson.Input;
using __WeFeatureN2__ = global::OneKey.Server.Partials.WebPublicationsView.FeatureNameListElementJson.Input;
using __WAcName__ = global::OneKey.Server.Partials.WebPublicationsView.ActionNameListElementJson.Input.Name;
using __WeVariable__ = global::OneKey.Server.Partials.WebPublicationsView.VariableNameListElementJson;
using __WVaSchema__ = global::OneKey.Server.Partials.WebPublicationsView.VariableNameListElementJson.JsonByExample.Schema;
using __WeVariable1__ = global::OneKey.Server.Partials.WebPublicationsView.VariableNameListElementJson.JsonByExample;
using __WeVariable2__ = global::OneKey.Server.Partials.WebPublicationsView.VariableNameListElementJson.Input;
using __WVaName__ = global::OneKey.Server.Partials.WebPublicationsView.VariableNameListElementJson.Input.Name;
using __TArray6__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationsView.VariableNameListElementJson>;
using __TArray5__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationsView.ActionNameListElementJson>;
using __WeFeatureN1__ = global::OneKey.Server.Partials.WebPublicationsView.FeatureNameListElementJson.JsonByExample;
using __TArray4__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.WebPublicationsView.FeatureNameListElementJson>;
using __WeFeatureN__ = global::OneKey.Server.Partials.WebPublicationsView.FeatureNameListElementJson;
using __TBool__ = global::Starcounter.Templates.TBool;
using __Variable__ = global::OneKey.Server.Partials.VariablesView;
using __VaSchema__ = global::OneKey.Server.Partials.VariablesView.JsonByExample.Schema;
using __WFeSchema__ = global::OneKey.Server.Partials.WebPublicationsView.FeatureNameListElementJson.JsonByExample.Schema;
using __Variable2__ = global::OneKey.Server.Partials.VariablesView.Input;
using __VaWebPubli__ = global::OneKey.Server.Partials.VariablesView.Input.WebPublicationName;
using __VaFeatureN__ = global::OneKey.Server.Partials.VariablesView.Input.FeatureName;
using __Variable1__ = global::OneKey.Server.Partials.VariablesView.JsonByExample;
using __VaName__ = global::OneKey.Server.Partials.VariablesView.Input.Name;
using __VaVariable__ = global::OneKey.Server.Partials.VariablesView.Input.VariableType;
using __VaRegex__ = global::OneKey.Server.Partials.VariablesView.Input.Regex;
using __VaVariable1__ = global::OneKey.Server.Partials.VariablesView.Input.VariableValue;
using __TArray3__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.VariablesView>;
using __SSeSchema__ = global::OneKey.Server.Partials.SelectedActionView.SelectedVariableJson.JsonByExample.Schema;
using __VaActionNa__ = global::OneKey.Server.Partials.VariablesView.Input.ActionName;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class WebPublicationsView_json : s::TemplateAttribute {
    
    #line hidden
    public class WebPublications : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class SelectedWebPublication : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Features : s::TemplateAttribute {
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class SelectedFeature : s::TemplateAttribute {
            
            #line hidden
            public class Actions : s::TemplateAttribute {
            }
            #line default
            
            #line hidden
            public class SelectedAction : s::TemplateAttribute {
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class Variables : s::TemplateAttribute {
                }
                #line default
                
                #line hidden
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public class SelectedVariable : s::TemplateAttribute {
                }
                #line default
            }
            #line default
        }
        #line default
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
public partial class VariablesView : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __VaSchema__ DefaultTemplate = new __VaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public VariablesView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public VariablesView(__VaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __VaSchema__ Template { get { return (__VaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__WebPublicationName__;
    private System.String __bf__FeatureName__;
    private System.String __bf__ActionName__;
    private System.String __bf__Name__;
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
                ClassName = "VariablesView";
                Properties.ClearExposed();
                WebPublicationName = Add<__TString__>("WebPublicationName$", bind:"SelectedWebPublicationName_");
                WebPublicationName.DefaultValue = "";
                WebPublicationName.Editable = true;
                WebPublicationName.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__WebPublicationName__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__WebPublicationName__ = (System.String)_v_; }, false);
                FeatureName = Add<__TString__>("FeatureName$", bind:"SelectedFeatureName_");
                FeatureName.DefaultValue = "";
                FeatureName.Editable = true;
                FeatureName.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__FeatureName__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__FeatureName__ = (System.String)_v_; }, false);
                ActionName = Add<__TString__>("ActionName$", bind:"SelectedActionName_");
                ActionName.DefaultValue = "";
                ActionName.Editable = true;
                ActionName.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__ActionName__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__ActionName__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Variable__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Variable__)_p_).__bf__Name__ = (System.String)_v_; }, false);
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
            public __TString__ WebPublicationName;
            public __TString__ FeatureName;
            public __TString__ ActionName;
            public __TString__ Name;
            public __TString__ VariableType;
            public __TString__ Regex;
            public __TString__ VariableValue;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String WebPublicationName {
#line 52 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.WebPublicationName.Getter(this); }
#line 52 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.WebPublicationName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FeatureName {
#line 54 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.FeatureName.Getter(this); }
#line 54 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.FeatureName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ActionName {
#line 56 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.ActionName.Getter(this); }
#line 56 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.ActionName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 58 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 58 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String VariableType {
#line 59 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.VariableType.Getter(this); }
#line 59 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.VariableType.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Regex {
#line 60 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Regex.Getter(this); }
#line 60 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Regex.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String VariableValue {
#line 62 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.VariableValue.Getter(this); }
#line 62 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.VariableValue.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class WebPublicationName : Input<__Variable__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FeatureName : Input<__Variable__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ActionName : Input<__Variable__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Variable__, __TString__, string> {
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
public partial class SelectedActionView : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SeSchema2__ DefaultTemplate = new __SeSchema2__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SelectedActionView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SelectedActionView(__SeSchema2__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SeSchema2__ Template { get { return (__SeSchema2__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Name__;
    private System.String __bf__ActionUrl__;
    private System.String __bf__HttpBody__;
    private System.String __bf__HttpType__;
    private System.Int64 __bf__OrderInFeature__;
    private System.Boolean __bf__Pagging__;
    private System.String __bf__PaggingUrlParameters__;
    private __Arr3__ __bf__Variables__;
    private System.String __bf__SelectedVariableId__;
    private __SeSelected__ __bf__SelectedVariable__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Selected4__);
                ClassName = "SelectedActionView";
                Properties.ClearExposed();
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                ActionUrl = Add<__TString__>("ActionUrl$");
                ActionUrl.DefaultValue = "";
                ActionUrl.Editable = true;
                ActionUrl.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__ActionUrl__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__ActionUrl__ = (System.String)_v_; }, false);
                HttpBody = Add<__TString__>("HttpBody$");
                HttpBody.DefaultValue = "";
                HttpBody.Editable = true;
                HttpBody.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__HttpBody__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__HttpBody__ = (System.String)_v_; }, false);
                HttpType = Add<__TString__>("HttpType$");
                HttpType.DefaultValue = "";
                HttpType.Editable = true;
                HttpType.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__HttpType__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__HttpType__ = (System.String)_v_; }, false);
                OrderInFeature = Add<__TLong__>("OrderInFeature$");
                OrderInFeature.DefaultValue = 0L;
                OrderInFeature.Editable = true;
                OrderInFeature.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__OrderInFeature__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__OrderInFeature__ = (System.Int64)_v_; }, false);
                Pagging = Add<__TBool__>("Pagging$");
                Pagging.DefaultValue = false;
                Pagging.Editable = true;
                Pagging.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__Pagging__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__Pagging__ = (System.Boolean)_v_; }, false);
                PaggingUrlParameters = Add<__TString__>("PaggingUrlParameters$");
                PaggingUrlParameters.DefaultValue = "";
                PaggingUrlParameters.Editable = true;
                PaggingUrlParameters.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__PaggingUrlParameters__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__PaggingUrlParameters__ = (System.String)_v_; }, false);
                Variables = Add<__TArray3__>("Variables$");
                Variables.SetCustomGetElementType((arr) => { return __Variable__.DefaultTemplate;});
                Variables.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__Variables__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__Variables__ = (__Arr3__)_v_; }, false);
                SelectedVariableId = Add<__TString__>("SelectedVariableId$");
                SelectedVariableId.DefaultValue = "";
                SelectedVariableId.Editable = true;
                SelectedVariableId.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__SelectedVariableId__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__SelectedVariableId__ = (System.String)_v_; }, false);
                SelectedVariable = Add<__SSeSchema__>("SelectedVariable$");
                SelectedVariable.Editable = true;
                SelectedVariable.SetCustomAccessors((_p_) => { return ((__Selected4__)_p_).__bf__SelectedVariable__; }, (_p_, _v_) => { ((__Selected4__)_p_).__bf__SelectedVariable__ = (__SeSelected__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Selected4__(this) { Parent = parent }; }
            public __TString__ Name;
            public __TString__ ActionUrl;
            public __TString__ HttpBody;
            public __TString__ HttpType;
            public __TLong__ OrderInFeature;
            public __TBool__ Pagging;
            public __TString__ PaggingUrlParameters;
            public __TArray3__ Variables;
            public __TString__ SelectedVariableId;
            public __SSeSchema__ SelectedVariable;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 42 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 42 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ActionUrl {
#line 43 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.ActionUrl.Getter(this); }
#line 43 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.ActionUrl.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HttpBody {
#line 44 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.HttpBody.Getter(this); }
#line 44 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.HttpBody.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HttpType {
#line 45 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.HttpType.Getter(this); }
#line 45 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.HttpType.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 OrderInFeature {
#line 46 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.OrderInFeature.Getter(this); }
#line 46 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.OrderInFeature.Setter(this, value); } }
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
#line 48 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.PaggingUrlParameters.Getter(this); }
#line 48 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.PaggingUrlParameters.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr3__ Variables {
#line 63 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Variables.Getter(this); }
#line 63 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Variables.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedVariableId {
#line 64 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.SelectedVariableId.Getter(this); }
#line 64 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.SelectedVariableId.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __SeSelected__ SelectedVariable {
#line 71 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return (__SeSelected__)Template.SelectedVariable.Getter(this); }
#line 71 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.SelectedVariable.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class SelectedVariableJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __SSeSchema__ DefaultTemplate = new __SSeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SelectedVariableJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public SelectedVariableJson(__SSeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __SSeSchema__ Template { get { return (__SSeSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private System.String __bf__Name__;
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
                    InstanceType = typeof(__SeSelected__);
                    ClassName = "SelectedVariableJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__SeSelected__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__SeSelected__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    VariableType = Add<__TString__>("VariableType$");
                    VariableType.DefaultValue = "";
                    VariableType.Editable = true;
                    VariableType.SetCustomAccessors((_p_) => { return ((__SeSelected__)_p_).__bf__VariableType__; }, (_p_, _v_) => { ((__SeSelected__)_p_).__bf__VariableType__ = (System.String)_v_; }, false);
                    Regex = Add<__TString__>("Regex$");
                    Regex.DefaultValue = "";
                    Regex.Editable = true;
                    Regex.SetCustomAccessors((_p_) => { return ((__SeSelected__)_p_).__bf__Regex__; }, (_p_, _v_) => { ((__SeSelected__)_p_).__bf__Regex__ = (System.String)_v_; }, false);
                    VariableValue = Add<__TString__>("VariableValue$");
                    VariableValue.DefaultValue = "";
                    VariableValue.Editable = true;
                    VariableValue.SetCustomAccessors((_p_) => { return ((__SeSelected__)_p_).__bf__VariableValue__; }, (_p_, _v_) => { ((__SeSelected__)_p_).__bf__VariableValue__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __SeSelected__(this) { Parent = parent }; }
                public __TString__ Name;
                public __TString__ VariableType;
                public __TString__ Regex;
                public __TString__ VariableValue;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 67 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 67 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String VariableType {
#line 68 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.VariableType.Getter(this); }
#line 68 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.VariableType.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Regex {
#line 69 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Regex.Getter(this); }
#line 69 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Regex.Setter(this, value); } }
#line default

        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String VariableValue {
#line 71 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.VariableValue.Getter(this); }
#line 71 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.VariableValue.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__SeSelected__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class VariableType : Input<__SeSelected__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Regex : Input<__SeSelected__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class VariableValue : Input<__SeSelected__, __TString__, string> {
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
        public class Name : Input<__Selected4__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ActionUrl : Input<__Selected4__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HttpBody : Input<__Selected4__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HttpType : Input<__Selected4__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class OrderInFeature : Input<__Selected4__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Pagging : Input<__Selected4__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class PaggingUrlParameters : Input<__Selected4__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedVariableId : Input<__Selected4__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class ActionsView : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __AcSchema__ DefaultTemplate = new __AcSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ActionsView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ActionsView(__AcSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __AcSchema__ Template { get { return (__AcSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__WebPublicationName__;
    private System.String __bf__FeatureName__;
    private System.String __bf__Name__;
    private System.String __bf__ActionUrl__;
    private System.String __bf__HttpBody__;
    private System.String __bf__HttpType__;
    private System.Int64 __bf__OrderInFeature__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ActionsV__);
                ClassName = "ActionsView";
                Properties.ClearExposed();
                WebPublicationName = Add<__TString__>("WebPublicationName$", bind:"SelectedWebPublicationName_");
                WebPublicationName.DefaultValue = "";
                WebPublicationName.Editable = true;
                WebPublicationName.SetCustomAccessors((_p_) => { return ((__ActionsV__)_p_).__bf__WebPublicationName__; }, (_p_, _v_) => { ((__ActionsV__)_p_).__bf__WebPublicationName__ = (System.String)_v_; }, false);
                FeatureName = Add<__TString__>("FeatureName$", bind:"SelectedFeatureName_");
                FeatureName.DefaultValue = "";
                FeatureName.Editable = true;
                FeatureName.SetCustomAccessors((_p_) => { return ((__ActionsV__)_p_).__bf__FeatureName__; }, (_p_, _v_) => { ((__ActionsV__)_p_).__bf__FeatureName__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__ActionsV__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__ActionsV__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                ActionUrl = Add<__TString__>("ActionUrl$");
                ActionUrl.DefaultValue = "";
                ActionUrl.Editable = true;
                ActionUrl.SetCustomAccessors((_p_) => { return ((__ActionsV__)_p_).__bf__ActionUrl__; }, (_p_, _v_) => { ((__ActionsV__)_p_).__bf__ActionUrl__ = (System.String)_v_; }, false);
                HttpBody = Add<__TString__>("HttpBody$");
                HttpBody.DefaultValue = "";
                HttpBody.Editable = true;
                HttpBody.SetCustomAccessors((_p_) => { return ((__ActionsV__)_p_).__bf__HttpBody__; }, (_p_, _v_) => { ((__ActionsV__)_p_).__bf__HttpBody__ = (System.String)_v_; }, false);
                HttpType = Add<__TString__>("HttpType$");
                HttpType.DefaultValue = "";
                HttpType.Editable = true;
                HttpType.SetCustomAccessors((_p_) => { return ((__ActionsV__)_p_).__bf__HttpType__; }, (_p_, _v_) => { ((__ActionsV__)_p_).__bf__HttpType__ = (System.String)_v_; }, false);
                OrderInFeature = Add<__TLong__>("OrderInFeature$");
                OrderInFeature.DefaultValue = 0L;
                OrderInFeature.Editable = true;
                OrderInFeature.SetCustomAccessors((_p_) => { return ((__ActionsV__)_p_).__bf__OrderInFeature__; }, (_p_, _v_) => { ((__ActionsV__)_p_).__bf__OrderInFeature__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ActionsV__(this) { Parent = parent }; }
            public __TString__ WebPublicationName;
            public __TString__ FeatureName;
            public __TString__ Name;
            public __TString__ ActionUrl;
            public __TString__ HttpBody;
            public __TString__ HttpType;
            public __TLong__ OrderInFeature;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String WebPublicationName {
#line 28 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.WebPublicationName.Getter(this); }
#line 28 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.WebPublicationName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String FeatureName {
#line 30 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.FeatureName.Getter(this); }
#line 30 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.FeatureName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 31 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 31 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ActionUrl {
#line 32 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.ActionUrl.Getter(this); }
#line 32 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.ActionUrl.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HttpBody {
#line 33 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.HttpBody.Getter(this); }
#line 33 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.HttpBody.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HttpType {
#line 34 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.HttpType.Getter(this); }
#line 34 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.HttpType.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 OrderInFeature {
#line 36 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.OrderInFeature.Getter(this); }
#line 36 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.OrderInFeature.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class WebPublicationName : Input<__ActionsV__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class FeatureName : Input<__ActionsV__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__ActionsV__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ActionUrl : Input<__ActionsV__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HttpBody : Input<__ActionsV__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HttpType : Input<__ActionsV__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class OrderInFeature : Input<__ActionsV__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class SelectedFeatureView : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SeSchema1__ DefaultTemplate = new __SeSchema1__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SelectedFeatureView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SelectedFeatureView(__SeSchema1__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SeSchema1__ Template { get { return (__SeSchema1__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Name__;
    private __Arr2__ __bf__Actions__;
    private System.String __bf__SelectedActionID__;
    private __Selected4__ __bf__SelectedAction__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Selected2__);
                ClassName = "SelectedFeatureView";
                Properties.ClearExposed();
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Selected2__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Selected2__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Actions = Add<__TArray2__>("Actions$");
                Actions.SetCustomGetElementType((arr) => { return __ActionsV__.DefaultTemplate;});
                Actions.SetCustomAccessors((_p_) => { return ((__Selected2__)_p_).__bf__Actions__; }, (_p_, _v_) => { ((__Selected2__)_p_).__bf__Actions__ = (__Arr2__)_v_; }, false);
                SelectedActionID = Add<__TString__>("SelectedActionID$");
                SelectedActionID.DefaultValue = "";
                SelectedActionID.Editable = true;
                SelectedActionID.SetCustomAccessors((_p_) => { return ((__Selected2__)_p_).__bf__SelectedActionID__; }, (_p_, _v_) => { ((__Selected2__)_p_).__bf__SelectedActionID__ = (System.String)_v_; }, false);
                SelectedAction = Add<__SeSchema2__>("SelectedAction$");
                SelectedAction.Editable = true;
                SelectedAction.SetCustomAccessors((_p_) => { return ((__Selected2__)_p_).__bf__SelectedAction__; }, (_p_, _v_) => { ((__Selected2__)_p_).__bf__SelectedAction__ = (__Selected4__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Selected2__(this) { Parent = parent }; }
            public __TString__ Name;
            public __TArray2__ Actions;
            public __TString__ SelectedActionID;
            public __SeSchema2__ SelectedAction;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 24 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 24 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr2__ Actions {
#line 37 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Actions.Getter(this); }
#line 37 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Actions.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedActionID {
#line 39 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.SelectedActionID.Getter(this); }
#line 39 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.SelectedActionID.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Selected4__ SelectedAction {
#line 72 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return (__Selected4__)Template.SelectedAction.Getter(this); }
#line 72 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.SelectedAction.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Name : Input<__Selected2__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedActionID : Input<__Selected2__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class FeaturesView : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FeSchema__ DefaultTemplate = new __FeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FeaturesView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FeaturesView(__FeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FeSchema__ Template { get { return (__FeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__WebPublicationName__;
    private System.String __bf__Name__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Features__);
                ClassName = "FeaturesView";
                Properties.ClearExposed();
                WebPublicationName = Add<__TString__>("WebPublicationName$", bind:"SelectedWebPublicationName_");
                WebPublicationName.DefaultValue = "";
                WebPublicationName.Editable = true;
                WebPublicationName.SetCustomAccessors((_p_) => { return ((__Features__)_p_).__bf__WebPublicationName__; }, (_p_, _v_) => { ((__Features__)_p_).__bf__WebPublicationName__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Features__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Features__)_p_).__bf__Name__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Features__(this) { Parent = parent }; }
            public __TString__ WebPublicationName;
            public __TString__ Name;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String WebPublicationName {
#line 18 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.WebPublicationName.Getter(this); }
#line 18 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.WebPublicationName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 20 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 20 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class WebPublicationName : Input<__Features__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Features__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class SelectedWebPublicationView : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SeSchema__ DefaultTemplate = new __SeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SelectedWebPublicationView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SelectedWebPublicationView(__SeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SeSchema__ Template { get { return (__SeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Name__;
    private System.String __bf__Url__;
    private System.String __bf__Description__;
    private __Arr1__ __bf__Features__;
    private System.String __bf__SelectedFeatureID__;
    private __Selected2__ __bf__SelectedFeature__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Selected__);
                ClassName = "SelectedWebPublicationView";
                Properties.ClearExposed();
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "Facebook.com";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Selected__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Selected__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Url = Add<__TString__>("Url$");
                Url.DefaultValue = "www.facebook.com";
                Url.Editable = true;
                Url.SetCustomAccessors((_p_) => { return ((__Selected__)_p_).__bf__Url__; }, (_p_, _v_) => { ((__Selected__)_p_).__bf__Url__ = (System.String)_v_; }, false);
                Description = Add<__TString__>("Description$");
                Description.DefaultValue = "DescriptionDescription";
                Description.Editable = true;
                Description.SetCustomAccessors((_p_) => { return ((__Selected__)_p_).__bf__Description__; }, (_p_, _v_) => { ((__Selected__)_p_).__bf__Description__ = (System.String)_v_; }, false);
                Features = Add<__TArray1__>("Features$");
                Features.SetCustomGetElementType((arr) => { return __Features__.DefaultTemplate;});
                Features.SetCustomAccessors((_p_) => { return ((__Selected__)_p_).__bf__Features__; }, (_p_, _v_) => { ((__Selected__)_p_).__bf__Features__ = (__Arr1__)_v_; }, false);
                SelectedFeatureID = Add<__TString__>("SelectedFeatureID$");
                SelectedFeatureID.DefaultValue = "";
                SelectedFeatureID.Editable = true;
                SelectedFeatureID.SetCustomAccessors((_p_) => { return ((__Selected__)_p_).__bf__SelectedFeatureID__; }, (_p_, _v_) => { ((__Selected__)_p_).__bf__SelectedFeatureID__ = (System.String)_v_; }, false);
                SelectedFeature = Add<__SeSchema1__>("SelectedFeature$");
                SelectedFeature.Editable = true;
                SelectedFeature.SetCustomAccessors((_p_) => { return ((__Selected__)_p_).__bf__SelectedFeature__; }, (_p_, _v_) => { ((__Selected__)_p_).__bf__SelectedFeature__ = (__Selected2__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Selected__(this) { Parent = parent }; }
            public __TString__ Name;
            public __TString__ Url;
            public __TString__ Description;
            public __TArray1__ Features;
            public __TString__ SelectedFeatureID;
            public __SeSchema1__ SelectedFeature;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
#line 12 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 12 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Url {
#line 13 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Url.Getter(this); }
#line 13 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Url.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Description {
#line 14 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Description.Getter(this); }
#line 14 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Description.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr1__ Features {
#line 21 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Features.Getter(this); }
#line 21 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Features.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedFeatureID {
#line 22 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.SelectedFeatureID.Getter(this); }
#line 22 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.SelectedFeatureID.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Selected2__ SelectedFeature {
#line 73 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return (__Selected2__)Template.SelectedFeature.Getter(this); }
#line 73 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.SelectedFeature.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Name : Input<__Selected__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Url : Input<__Selected__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Description : Input<__Selected__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SelectedFeatureID : Input<__Selected__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class WebPublicationsView : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __WeSchema__ DefaultTemplate = new __WeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public WebPublicationsView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public WebPublicationsView(__WeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __WeSchema__ Template { get { return (__WeSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Html__;
    private __Arr__ __bf__WebPublications__;
    private System.String __bf__SelectedWebPublicationID__;
    private __Selected__ __bf__SelectedWebPublication__;
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
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__WebPubli__);
                ClassName = "WebPublicationsView";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "";
                Html.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                WebPublications = Add<__TArray__>("WebPublications$", bind:"WebPublications_");
                WebPublications.SetCustomGetElementType((arr) => { return __WeWebPubli__.DefaultTemplate;});
                WebPublications.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__WebPublications__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__WebPublications__ = (__Arr__)_v_; }, false);
                SelectedWebPublicationID = Add<__TString__>("SelectedWebPublicationID$");
                SelectedWebPublicationID.DefaultValue = "";
                SelectedWebPublicationID.Editable = true;
                SelectedWebPublicationID.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__SelectedWebPublicationID__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__SelectedWebPublicationID__ = (System.String)_v_; }, false);
                SelectedWebPublication = Add<__SeSchema__>("SelectedWebPublication$");
                SelectedWebPublication.Editable = true;
                SelectedWebPublication.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__SelectedWebPublication__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__SelectedWebPublication__ = (__Selected__)_v_; }, false);
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
                AddWebSite.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddWebSite() { App = (WebPublicationsView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsView)pup).Handle((Input.AddWebSite)input); });
                DeleteWebSite = Add<__TLong__>("DeleteWebSite$");
                DeleteWebSite.DefaultValue = 0L;
                DeleteWebSite.Editable = true;
                DeleteWebSite.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__DeleteWebSite__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__DeleteWebSite__ = (System.Int64)_v_; }, false);
                DeleteWebSite.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteWebSite() { App = (WebPublicationsView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsView)pup).Handle((Input.DeleteWebSite)input); });
                UpdateWebSite = Add<__TLong__>("UpdateWebSite$");
                UpdateWebSite.DefaultValue = 0L;
                UpdateWebSite.Editable = true;
                UpdateWebSite.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__UpdateWebSite__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__UpdateWebSite__ = (System.Int64)_v_; }, false);
                AddFeature = Add<__TLong__>("AddFeature$");
                AddFeature.DefaultValue = 0L;
                AddFeature.Editable = true;
                AddFeature.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__AddFeature__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__AddFeature__ = (System.Int64)_v_; }, false);
                AddFeature.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddFeature() { App = (WebPublicationsView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsView)pup).Handle((Input.AddFeature)input); });
                DeleteFeature = Add<__TLong__>("DeleteFeature$");
                DeleteFeature.DefaultValue = 0L;
                DeleteFeature.Editable = true;
                DeleteFeature.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__DeleteFeature__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__DeleteFeature__ = (System.Int64)_v_; }, false);
                DeleteFeature.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteFeature() { App = (WebPublicationsView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsView)pup).Handle((Input.DeleteFeature)input); });
                UpdateFeature = Add<__TLong__>("UpdateFeature$");
                UpdateFeature.DefaultValue = 0L;
                UpdateFeature.Editable = true;
                UpdateFeature.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__UpdateFeature__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__UpdateFeature__ = (System.Int64)_v_; }, false);
                AddAction = Add<__TLong__>("AddAction$");
                AddAction.DefaultValue = 0L;
                AddAction.Editable = true;
                AddAction.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__AddAction__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__AddAction__ = (System.Int64)_v_; }, false);
                AddAction.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddAction() { App = (WebPublicationsView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsView)pup).Handle((Input.AddAction)input); });
                DeleteAction = Add<__TLong__>("DeleteAction$");
                DeleteAction.DefaultValue = 0L;
                DeleteAction.Editable = true;
                DeleteAction.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__DeleteAction__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__DeleteAction__ = (System.Int64)_v_; }, false);
                DeleteAction.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteAction() { App = (WebPublicationsView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsView)pup).Handle((Input.DeleteAction)input); });
                UpdateAction = Add<__TLong__>("UpdateAction$");
                UpdateAction.DefaultValue = 0L;
                UpdateAction.Editable = true;
                UpdateAction.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__UpdateAction__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__UpdateAction__ = (System.Int64)_v_; }, false);
                AddVariable = Add<__TLong__>("AddVariable$");
                AddVariable.DefaultValue = 0L;
                AddVariable.Editable = true;
                AddVariable.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__AddVariable__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__AddVariable__ = (System.Int64)_v_; }, false);
                AddVariable.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.AddVariable() { App = (WebPublicationsView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsView)pup).Handle((Input.AddVariable)input); });
                DeleteVariable = Add<__TLong__>("DeleteVariable$");
                DeleteVariable.DefaultValue = 0L;
                DeleteVariable.Editable = true;
                DeleteVariable.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__DeleteVariable__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__DeleteVariable__ = (System.Int64)_v_; }, false);
                DeleteVariable.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.DeleteVariable() { App = (WebPublicationsView)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((WebPublicationsView)pup).Handle((Input.DeleteVariable)input); });
                UpdateVariable = Add<__TLong__>("UpdateVariable$");
                UpdateVariable.DefaultValue = 0L;
                UpdateVariable.Editable = true;
                UpdateVariable.SetCustomAccessors((_p_) => { return ((__WebPubli__)_p_).__bf__UpdateVariable__; }, (_p_, _v_) => { ((__WebPubli__)_p_).__bf__UpdateVariable__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __WebPubli__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray__ WebPublications;
            public __TString__ SelectedWebPublicationID;
            public __SeSchema__ SelectedWebPublication;
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
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
#line 2 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Html.Getter(this); }
#line 2 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Html.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ WebPublications {
#line 8 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.WebPublications.Getter(this); }
#line 8 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.WebPublications.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SelectedWebPublicationID {
#line 9 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.SelectedWebPublicationID.Getter(this); }
#line 9 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.SelectedWebPublicationID.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Selected__ SelectedWebPublication {
#line 74 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return (__Selected__)Template.SelectedWebPublication.Getter(this); }
#line 74 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.SelectedWebPublication.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr4__ FeatureNameList {
#line 79 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.FeatureNameList.Getter(this); }
#line 79 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.FeatureNameList.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr5__ ActionNameList {
#line 84 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.ActionNameList.Getter(this); }
#line 84 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.ActionNameList.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr6__ VariableNameList {
#line 89 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.VariableNameList.Getter(this); }
#line 89 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.VariableNameList.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr7__ VariableTypeList {
#line 94 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.VariableTypeList.Getter(this); }
#line 94 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.VariableTypeList.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewWebPublicationName {
#line 96 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewWebPublicationName.Getter(this); }
#line 96 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewWebPublicationName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewWebPublicationUrl {
#line 97 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewWebPublicationUrl.Getter(this); }
#line 97 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewWebPublicationUrl.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewWebPublicationDescription {
#line 98 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewWebPublicationDescription.Getter(this); }
#line 98 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewWebPublicationDescription.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewFeatureNameOther {
#line 99 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewFeatureNameOther.Getter(this); }
#line 99 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewFeatureNameOther.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewFeatureName {
#line 100 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewFeatureName.Getter(this); }
#line 100 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewFeatureName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionNameOther {
#line 101 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewActionNameOther.Getter(this); }
#line 101 "Server\Partials\WebPublicationsView.json"
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
#line 103 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.PaggingUrlParameters.Getter(this); }
#line 103 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.PaggingUrlParameters.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionName {
#line 104 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewActionName.Getter(this); }
#line 104 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewActionName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionUrl {
#line 105 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewActionUrl.Getter(this); }
#line 105 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewActionUrl.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionHttpType {
#line 106 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewActionHttpType.Getter(this); }
#line 106 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewActionHttpType.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewActionHttpBody {
#line 107 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewActionHttpBody.Getter(this); }
#line 107 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewActionHttpBody.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 NewActionOrderInFeature {
#line 108 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewActionOrderInFeature.Getter(this); }
#line 108 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewActionOrderInFeature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableValue {
#line 109 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewVariableValue.Getter(this); }
#line 109 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewVariableValue.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableNameOther {
#line 110 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewVariableNameOther.Getter(this); }
#line 110 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewVariableNameOther.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableName {
#line 111 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewVariableName.Getter(this); }
#line 111 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewVariableName.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableTypeOther {
#line 112 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewVariableTypeOther.Getter(this); }
#line 112 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewVariableTypeOther.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableType {
#line 113 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewVariableType.Getter(this); }
#line 113 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewVariableType.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewVariableRegex {
#line 114 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.NewVariableRegex.Getter(this); }
#line 114 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.NewVariableRegex.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddWebSite {
#line 115 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.AddWebSite.Getter(this); }
#line 115 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.AddWebSite.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteWebSite {
#line 116 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.DeleteWebSite.Getter(this); }
#line 116 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.DeleteWebSite.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 UpdateWebSite {
#line 117 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.UpdateWebSite.Getter(this); }
#line 117 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.UpdateWebSite.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddFeature {
#line 118 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.AddFeature.Getter(this); }
#line 118 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.AddFeature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteFeature {
#line 119 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.DeleteFeature.Getter(this); }
#line 119 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.DeleteFeature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 UpdateFeature {
#line 120 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.UpdateFeature.Getter(this); }
#line 120 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.UpdateFeature.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddAction {
#line 121 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.AddAction.Getter(this); }
#line 121 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.AddAction.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteAction {
#line 122 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.DeleteAction.Getter(this); }
#line 122 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.DeleteAction.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 UpdateAction {
#line 123 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.UpdateAction.Getter(this); }
#line 123 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.UpdateAction.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 AddVariable {
#line 124 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.AddVariable.Getter(this); }
#line 124 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.AddVariable.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 DeleteVariable {
#line 125 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.DeleteVariable.Getter(this); }
#line 125 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.DeleteVariable.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 UpdateVariable {
#line 127 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.UpdateVariable.Getter(this); }
#line 127 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.UpdateVariable.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class WebPublicationsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __WWeSchema__ DefaultTemplate = new __WWeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public WebPublicationsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public WebPublicationsElementJson(__WWeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WWeSchema__ Template { get { return (__WWeSchema__)base.Template; } set { base.Template = value; } }
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
                    InstanceType = typeof(__WeWebPubli__);
                    ClassName = "WebPublicationsElementJson";
                    Properties.ClearExposed();
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__WeWebPubli__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__WeWebPubli__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __WeWebPubli__(this) { Parent = parent }; }
                public __TString__ Name;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
#line 7 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 7 "Server\Partials\WebPublicationsView.json"
    set {
#line hidden
        Template.Name.Setter(this, value); } }
#line default

        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__WeWebPubli__, __TString__, string> {
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
        public static __WFeSchema__ DefaultTemplate = new __WFeSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FeatureNameListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public FeatureNameListElementJson(__WFeSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WFeSchema__ Template { get { return (__WFeSchema__)base.Template; } set { base.Template = value; } }
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
#line 78 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 78 "Server\Partials\WebPublicationsView.json"
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
        public static __WAcSchema__ DefaultTemplate = new __WAcSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ActionNameListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ActionNameListElementJson(__WAcSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WAcSchema__ Template { get { return (__WAcSchema__)base.Template; } set { base.Template = value; } }
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
#line 83 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 83 "Server\Partials\WebPublicationsView.json"
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
        public static __WVaSchema__ DefaultTemplate = new __WVaSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableNameListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableNameListElementJson(__WVaSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WVaSchema__ Template { get { return (__WVaSchema__)base.Template; } set { base.Template = value; } }
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
#line 88 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.Name.Getter(this); }
#line 88 "Server\Partials\WebPublicationsView.json"
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
        public static __WVaSchema1__ DefaultTemplate = new __WVaSchema1__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableTypeListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public VariableTypeListElementJson(__WVaSchema1__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __WVaSchema1__ Template { get { return (__WVaSchema1__)base.Template; } set { base.Template = value; } }
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
#line 93 "Server\Partials\WebPublicationsView.json"
    get {
#line hidden
        return Template.VariableType.Getter(this); }
#line 93 "Server\Partials\WebPublicationsView.json"
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
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108