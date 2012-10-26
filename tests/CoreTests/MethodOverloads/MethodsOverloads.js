if (typeof($CreateDelegate)=='undefined'){
    if(typeof($iKey)=='undefined') var $iKey = 0;
    if(typeof($pKey)=='undefined') var $pKey = String.fromCharCode(1);
    var $CreateDelegate = function(target, func){
        if (target == null || func == null) 
            return func;
        if(func.target==target && func.func==func)
            return func;
        if (target.$delegateCache == null)
            target.$delegateCache = {};
        if (func.$key == null)
            func.$key = $pKey + String(++$iKey);
        var delegate;
        if(target.$delegateCache!=null)
            delegate = target.$delegateCache[func.$key];
        if (delegate == null){
            delegate = function(){
                return func.apply(target, arguments);
            };
            delegate.func = func;
            delegate.target = target;
            delegate.isDelegate = true;
            if(target.$delegateCache!=null)
                target.$delegateCache[func.$key] = delegate;
        }
        return delegate;
    }
}
if (typeof(JsTypes) == "undefined")
    var JsTypes = [];
var CoreTests$Methods$MethodOverloads =
{
    fullname: "CoreTests.Methods.MethodOverloads",
    baseTypeName: "System.Object",
    assemblyName: "CoreTests",
    Kind: "Class",
    definition:
    {
        ctor: function ()
        {
            System.Object.ctor.call(this);
        },
        Main: function ()
        {
            this.JsAct$$JsAction($CreateDelegate(this, this.Test));
            this.JsAct$$JsAction($CreateDelegate(this, this.TestString));
            this.JsAct$$JsAction($CreateDelegate(this, this.TestInt));
            this.Act$$Action($CreateDelegate(this, this.Test));
            this.Act$$Action$1$String($CreateDelegate(this, this.TestString));
            this.Act$$Action$1$Int32($CreateDelegate(this, this.TestInt));
        },
        Test: function ()
        {
        },
        TestString: function (s)
        {
        },
        TestInt: function (x)
        {
        },
        JsAct$$JsAction: function (callback)
        {
        },
        Act$$Action: function (callback)
        {
        },
        Act$$Action$1$String: function (callback)
        {
        },
        Act$$Action$1$Int32: function (callback)
        {
        }
    }
};
JsTypes.push(CoreTests$Methods$MethodOverloads);
