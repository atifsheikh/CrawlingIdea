// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "Server\Partials\ResultsView.json"
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
#pragma warning disable 0108
#pragma warning disable 1591

using __ReColumnsL2__ = global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.Input;
using __ReRowsList__ = global::OneKey.Server.Partials.ResultsView.RowsListElementJson;
using __RRoSchema__ = global::OneKey.Server.Partials.ResultsView.RowsListElementJson.JsonByExample.Schema;
using __RRoRowListE__ = global::OneKey.Server.Partials.ResultsView.RowsListElementJson.RowListElementJson;
using __RRRoSchema__ = global::OneKey.Server.Partials.ResultsView.RowsListElementJson.RowListElementJson.JsonByExample.Schema;
using __RRoRowListE1__ = global::OneKey.Server.Partials.ResultsView.RowsListElementJson.RowListElementJson.JsonByExample;
using __RRoRowListE2__ = global::OneKey.Server.Partials.ResultsView.RowsListElementJson.RowListElementJson.Input;
using __RRRoValue__ = global::OneKey.Server.Partials.ResultsView.RowsListElementJson.RowListElementJson.Input.Value;
using __TArray2__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.ResultsView.RowsListElementJson.RowListElementJson>;
using __ReRowsList1__ = global::OneKey.Server.Partials.ResultsView.RowsListElementJson.JsonByExample;
using __Arr1__ = global::Starcounter.Arr<global::OneKey.Server.Partials.ResultsView.RowsListElementJson.RowListElementJson>;
using __ReRowsList2__ = global::OneKey.Server.Partials.ResultsView.RowsListElementJson.Input;
using __TArray3__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.ResultsView.RowsListElementJson>;
using __ResultsV1__ = global::OneKey.Server.Partials.ResultsView.JsonByExample;
using __Arr2__ = global::Starcounter.Arr<global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson>;
using __Arr3__ = global::Starcounter.Arr<global::OneKey.Server.Partials.ResultsView.RowsListElementJson>;
using __TArray1__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson>;
using __ResultsV2__ = global::OneKey.Server.Partials.ResultsView.Input;
using __ReHtml__ = global::OneKey.Server.Partials.ResultsView.Input.Html;
using __ReColumnsL1__ = global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.JsonByExample;
using __ResultsV__ = global::OneKey.Server.Partials.ResultsView;
using __ReSchema__ = global::OneKey.Server.Partials.ResultsView.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __ReColumnsL__ = global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Arr__ = global::Starcounter.Arr<global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.RowListElementJson>;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __RCoRowListE__ = global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.RowListElementJson;
using __RCRoSchema__ = global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.RowListElementJson.JsonByExample.Schema;
using __RCoRowListE1__ = global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.RowListElementJson.JsonByExample;
using __RCoRowListE2__ = global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.RowListElementJson.Input;
using __RCRoValue__ = global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.RowListElementJson.Input.Value;
using __TArray__ = global::Starcounter.Templates.TArray<global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.RowListElementJson>;
using __RCoSchema__ = global::OneKey.Server.Partials.ResultsView.ColumnsListElementJson.JsonByExample.Schema;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ResultsView_json : s::TemplateAttribute {
    
    #line hidden
    public class ColumnsList : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class RowList : s::TemplateAttribute {
        }
        #line default
    }
    #line default
    
    #line hidden
    public class RowsList : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class RowList : s::TemplateAttribute {
        }
        #line default
    }
    #line default
}
#line default

namespace OneKey.Server.Partials {

#line hidden
public partial class ResultsView : Page {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __ReSchema__ DefaultTemplate = new __ReSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ResultsView() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ResultsView(__ReSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __ReSchema__ Template { get { return (__ReSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    private System.String __bf__Html__;
    private __Arr2__ __bf__ColumnsList__;
    private __Arr3__ __bf__RowsList__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : Page.JsonByExample.Schema {
            public Schema()
                : base() {
                InstanceType = typeof(__ResultsV__);
                ClassName = "ResultsView";
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "";
                Html.SetCustomAccessors((_p_) => { return ((__ResultsV__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ResultsV__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                ColumnsList = Add<__TArray1__>("ColumnsList$");
                ColumnsList.SetCustomGetElementType((arr) => { return __ReColumnsL__.DefaultTemplate;});
                ColumnsList.SetCustomAccessors((_p_) => { return ((__ResultsV__)_p_).__bf__ColumnsList__; }, (_p_, _v_) => { ((__ResultsV__)_p_).__bf__ColumnsList__ = (__Arr2__)_v_; }, false);
                RowsList = Add<__TArray3__>("RowsList$");
                RowsList.SetCustomGetElementType((arr) => { return __ReRowsList__.DefaultTemplate;});
                RowsList.SetCustomAccessors((_p_) => { return ((__ResultsV__)_p_).__bf__RowsList__; }, (_p_, _v_) => { ((__ResultsV__)_p_).__bf__RowsList__ = (__Arr3__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ResultsV__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TArray1__ ColumnsList;
            public __TArray3__ RowsList;
        }
        #line default
    }
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
#line 2 "Server\Partials\ResultsView.json"
    get {
#line hidden
        return Template.Html.Getter(this); }
#line 2 "Server\Partials\ResultsView.json"
    set {
#line hidden
        Template.Html.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr2__ ColumnsList {
#line 7 "Server\Partials\ResultsView.json"
    get {
#line hidden
        return Template.ColumnsList.Getter(this); }
#line 7 "Server\Partials\ResultsView.json"
    set {
#line hidden
        Template.ColumnsList.Setter(this, value); } }
#line default

    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr3__ RowsList {
#line 13 "Server\Partials\ResultsView.json"
    get {
#line hidden
        return Template.RowsList.Getter(this); }
#line 13 "Server\Partials\ResultsView.json"
    set {
#line hidden
        Template.RowsList.Setter(this, value); } }
#line default

    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class ColumnsListElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __RCoSchema__ DefaultTemplate = new __RCoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ColumnsListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public ColumnsListElementJson(__RCoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __RCoSchema__ Template { get { return (__RCoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private __Arr__ __bf__RowList__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ReColumnsL__);
                    ClassName = "ColumnsListElementJson";
                    Properties.ClearExposed();
                    RowList = Add<__TArray__>("RowList$");
                    RowList.SetCustomGetElementType((arr) => { return __RCoRowListE__.DefaultTemplate;});
                    RowList.SetCustomAccessors((_p_) => { return ((__ReColumnsL__)_p_).__bf__RowList__; }, (_p_, _v_) => { ((__ReColumnsL__)_p_).__bf__RowList__ = (__Arr__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ReColumnsL__(this) { Parent = parent }; }
                public __TArray__ RowList;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr__ RowList {
#line 6 "Server\Partials\ResultsView.json"
    get {
#line hidden
        return Template.RowList.Getter(this); }
#line 6 "Server\Partials\ResultsView.json"
    set {
#line hidden
        Template.RowList.Setter(this, value); } }
#line default

        
        #line hidden
        public class RowListElementJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __RCRoSchema__ DefaultTemplate = new __RCRoSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public RowListElementJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public RowListElementJson(__RCRoSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __RCRoSchema__ Template { get { return (__RCRoSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.String __bf__Value__;
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class JsonByExample {
                
                #line hidden
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__RCoRowListE__);
                        ClassName = "RowListElementJson";
                        Properties.ClearExposed();
                        Value = Add<__TString__>("Value$");
                        Value.DefaultValue = "";
                        Value.Editable = true;
                        Value.SetCustomAccessors((_p_) => { return ((__RCoRowListE__)_p_).__bf__Value__; }, (_p_, _v_) => { ((__RCoRowListE__)_p_).__bf__Value__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __RCoRowListE__(this) { Parent = parent }; }
                    public __TString__ Value;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Value {
#line 5 "Server\Partials\ResultsView.json"
    get {
#line hidden
        return Template.Value.Getter(this); }
#line 5 "Server\Partials\ResultsView.json"
    set {
#line hidden
        Template.Value.Setter(this, value); } }
#line default

            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class Input {
                
                #line hidden
                public class Value : Input<__RCoRowListE__, __TString__, string> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        public static class Input {
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class RowsListElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __RRoSchema__ DefaultTemplate = new __RRoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public RowsListElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public RowsListElementJson(__RRoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __RRoSchema__ Template { get { return (__RRoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        private __Arr1__ __bf__RowList__;
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__ReRowsList__);
                    ClassName = "RowsListElementJson";
                    Properties.ClearExposed();
                    RowList = Add<__TArray2__>("RowList$");
                    RowList.SetCustomGetElementType((arr) => { return __RRoRowListE__.DefaultTemplate;});
                    RowList.SetCustomAccessors((_p_) => { return ((__ReRowsList__)_p_).__bf__RowList__; }, (_p_, _v_) => { ((__ReRowsList__)_p_).__bf__RowList__ = (__Arr1__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __ReRowsList__(this) { Parent = parent }; }
                public __TArray2__ RowList;
            }
            #line default
        }
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr1__ RowList {
#line 11 "Server\Partials\ResultsView.json"
    get {
#line hidden
        return Template.RowList.Getter(this); }
#line 11 "Server\Partials\ResultsView.json"
    set {
#line hidden
        Template.RowList.Setter(this, value); } }
#line default

        
        #line hidden
        public class RowListElementJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __RRRoSchema__ DefaultTemplate = new __RRRoSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public RowListElementJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public RowListElementJson(__RRRoSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __RRRoSchema__ Template { get { return (__RRRoSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            private System.String __bf__Value__;
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class JsonByExample {
                
                #line hidden
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__RRoRowListE__);
                        ClassName = "RowListElementJson";
                        Properties.ClearExposed();
                        Value = Add<__TString__>("Value$");
                        Value.DefaultValue = "";
                        Value.Editable = true;
                        Value.SetCustomAccessors((_p_) => { return ((__RRoRowListE__)_p_).__bf__Value__; }, (_p_, _v_) => { ((__RRoRowListE__)_p_).__bf__Value__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __RRoRowListE__(this) { Parent = parent }; }
                    public __TString__ Value;
                }
                #line default
            }
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Value {
#line 10 "Server\Partials\ResultsView.json"
    get {
#line hidden
        return Template.Value.Getter(this); }
#line 10 "Server\Partials\ResultsView.json"
    set {
#line hidden
        Template.Value.Setter(this, value); } }
#line default

            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class Input {
                
                #line hidden
                public class Value : Input<__RRoRowListE__, __TString__, string> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        public static class Input {
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__ResultsV__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108