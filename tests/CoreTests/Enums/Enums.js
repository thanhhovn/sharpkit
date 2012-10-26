if (typeof($CreateException)=='undefined') 
{
    var $CreateException = function(ex, error) 
    {
        if(error==null)
            error = new Error();
        if(ex==null)
            ex = new System.Exception.ctor();       
        error.message = ex.message;
        for (var p in ex)
           error[p] = ex[p];
        return error;
    }
}
if (typeof(CoreTests) == "undefined")
    var CoreTests = {};
if (typeof(CoreTests.Enums) == "undefined")
    CoreTests.Enums = {};
CoreTests.Enums.Enums = function ()
{
};
CoreTests.Enums.Enums.prototype.Reflect = function ()
{
    var type =  CoreTests.Enums.Enum1;
    for (var name in type)
    {
        var value = type[name];
        this.alert(name + "=" + value);
    }
};
CoreTests.Enums.Enums.prototype.alert = function (p)
{
    throw $CreateException(new System.NotImplementedException.ctor(), new Error());
};
CoreTests.Enums.Enum1 = {a: 1, b: 2, c: 3};
if (typeof(System) == "undefined")
    var System = {};
if (typeof(System.ComponentModel) == "undefined")
    System.ComponentModel = {};
System.ComponentModel.RefreshProperties = {None: 0, All: 1, Repaint: 2};
