/*Generated by SharpKit 5 v4.29.0000*/
var NamespaceSample=
{
    Namespace1:{},
    Namespace2:{}
};
function btn_onclick()
{
    var c1=new NamespaceSample.Namespace1.SomeClass();
    alert("new NamespaceSample.Namespace1.SomeClass() returned:" + c1);
    var c2=new NamespaceSample.Namespace2.SomeClass();
    alert("new NamespaceSample.Namespace2.SomeClass() returned:" + c2);
};
if(typeof(NamespaceSample) == "undefined")
    var NamespaceSample={};
if(typeof(NamespaceSample.Namespace1) == "undefined")
    NamespaceSample.Namespace1 = {};
NamespaceSample.Namespace1.SomeClass = function()
{
    this.Prop1 = null;
};
if(typeof(NamespaceSample.Namespace2) == "undefined")
    NamespaceSample.Namespace2 = {};
NamespaceSample.Namespace2.SomeClass = function()
{
};
