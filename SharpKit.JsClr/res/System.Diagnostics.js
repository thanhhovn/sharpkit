/*@Generated by SharpKit v4.21.8000*/
if(typeof($CreateDelegate)=='undefined'){var $fki=0;var $fkp=String.fromCharCode(1);$CreateDelegate=function(a,b){if(a==null) return b;var c=a.$delegateCache;if(c==null){c={};a.$delegateCache=c;}if(b.$fk==null) {$fki++;b.$fk=$fkp+String($fki);}var d=c[b.$fk];if(d==null){ d=function(){return arguments.callee.func.apply(arguments.callee.target, arguments);};d.func=b;d.target=a;d.isDelegate=true;c[b.$fk]=d;}return d;}}
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push({
    fullname:"System.Diagnostics.Debugger",
    baseTypeName:"System.Object",
    staticDefinition:{
        Break:function()
        {
            debugger;
        }
        
    }
    ,
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:{
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
        
    }
}
);
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
JsTypes.push({
    fullname:"System.Diagnostics.Trace",
    baseTypeName:"System.Object",
    staticDefinition:{
        cctor:function()
        {
            System.Diagnostics.Trace.Warnings = null;
            System.Diagnostics.Trace.Enabled = false;
        }
        ,
        TraceWarning$$String:function(msg)
        {
            if(!System.Diagnostics.Trace.Enabled)
                return;
            if(System.Diagnostics.Trace.Warnings == null)
                System.Diagnostics.Trace.Warnings = new System.Collections.Generic.List$1.ctor(System.String);
            System.Diagnostics.Trace.Warnings.Add(msg);
        }
        ,
        TraceWarning$$String$$Object$Array:function(format,args)
        {
            if(!System.Diagnostics.Trace.Enabled)
                return;
            System.Diagnostics.Trace.TraceWarning$$String(System.String.Format$$String$$Object$Array(format,args));
        }
    }
    ,
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:{
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
        
    }
}
);
