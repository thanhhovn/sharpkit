/*@Generated by SharpKit v4.23.4000*/
if(typeof(JsTypes) == "undefined")
    JsTypes = [];
var System$ComponentModel$ListSortDirection=
{
    fullname:"System.ComponentModel.ListSortDirection",
    staticDefinition:{Ascending:"Ascending",Descending:"Descending"},
    Kind:"Enum"
};
JsTypes.push(System$ComponentModel$ListSortDirection);
var System$Math=
{
    fullname:"System.Math",
    baseTypeName:"System.Object",
    staticDefinition:
    {
        cctor:function()
        {
            System.Math.PI = Math.PI;
        },
        Abs$$Number:function(value)
        {
            return Math.abs(value);
        },
        Abs$$Double:function(value)
        {
            return Math.abs(value);
        },
        Abs$$Int32:function(value)
        {
            return Math.abs(value);
        },
        Abs$$Int64:function(value)
        {
            return Math.abs(Cast(value,System.Decimal));
        },
        Abs$$Single:function(value)
        {
            return Math.abs(value);
        },
        AbsHelper$$Int16:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        AbsHelper$$Int32:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        AbsHelper$$Int64:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        AbsHelper$$SByte:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Acos:function(d)
        {
            return Math.acos(d);
        },
        Asin:function(d)
        {
            return Math.asin(d);
        },
        Atan:function(d)
        {
            return Math.atan(d);
        },
        Atan2:function(y,x)
        {
            return Math.atan2(y,x);
        },
        BigMul:function(a,b)
        {
            throw new System.NotImplementedException.ctor();
        },
        Ceiling$$Decimal:function(d)
        {
            return Math.ceil(d);
        },
        Ceiling$$Double:function(a)
        {
            return Math.ceil(a);
        },
        Cos:function(d)
        {
            return Math.cos(d);
        },
        Cosh:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        DivRem$$Int32$$Int32$$Int32:function(a,b,result)
        {
            throw new System.NotImplementedException.ctor();
        },
        DivRem$$Int64$$Int64$$Int64:function(a,b,result)
        {
            throw new System.NotImplementedException.ctor();
        },
        Exp:function(d)
        {
            return Math.exp(d);
        },
        Floor$$Decimal:function(d)
        {
            return Math.floor(d);
        },
        Floor$$Double:function(d)
        {
            return Math.floor(d);
        },
        IEEERemainder:function(x,y)
        {
            throw new System.NotImplementedException.ctor();
        },
        InternalRound:function(value,digits,mode)
        {
            throw new System.NotImplementedException.ctor();
        },
        InternalTruncate:function(d)
        {
            throw new System.NotImplementedException.ctor();
        },
        Log$$Double:function(d)
        {
            return Math.log(d);
        },
        Log$$Double$$Double:function(a,newBase)
        {
            throw new System.NotImplementedException.ctor();
        },
        Log10:function(d)
        {
            throw new System.NotImplementedException.ctor();
        },
        Max$$Decimal$$Decimal:function(val1,val2)
        {
            return Math.max(val1,val2);
        },
        Max$$Double$$Double:function(val1,val2)
        {
            return Math.max(val1,val2);
        },
        Max$$Int32$$Int32:function(val1,val2)
        {
            return Math.max(val1,val2);
        },
        Max$$Int64$$Int64:function(val1,val2)
        {
            return Math.max(Cast(val1,System.Decimal),Cast(val2,System.Decimal));
        },
        Max$$SByte$$SByte:function(val1,val2)
        {
            return Math.max(val1,val2);
        },
        Max$$Single$$Single:function(val1,val2)
        {
            return Math.max(val1,val2);
        },
        Max$$UInt32$$UInt32:function(val1,val2)
        {
            return Math.max(Cast(val1,System.Decimal),Cast(val2,System.Decimal));
        },
        Max$$UInt64$$UInt64:function(val1,val2)
        {
            return Math.max(Cast(val1,System.Decimal),Cast(val2,System.Decimal));
        },
        Min$$Decimal$$Decimal:function(val1,val2)
        {
            return Math.min(val1,val2);
        },
        Min$$Double$$Double:function(val1,val2)
        {
            return Math.min(val1,val2);
        },
        Min$$Int32$$Int32:function(val1,val2)
        {
            return Math.min(val1,val2);
        },
        Min$$Int64$$Int64:function(val1,val2)
        {
            return Math.min(Cast(val1,System.Decimal),Cast(val2,System.Decimal));
        },
        Min$$SByte$$SByte:function(val1,val2)
        {
            return Math.min(val1,val2);
        },
        Min$$Single$$Single:function(val1,val2)
        {
            return Math.min(val1,val2);
        },
        Min$$UInt32$$UInt32:function(val1,val2)
        {
            return Math.min(Cast(val1,System.Decimal),Cast(val2,System.Decimal));
        },
        Min$$UInt64$$UInt64:function(val1,val2)
        {
            return Math.min(Cast(val1,System.Decimal),Cast(val2,System.Decimal));
        },
        Pow:function(x,y)
        {
            return Math.pow(x,y);
        },
        Round$$Decimal:function(d)
        {
            return Math.round(d);
        },
        Round$$Double:function(a)
        {
            return Math.round(a);
        },
        Round$$Decimal$$Int32:function(d,decimals)
        {
            return Math.round(d);
        },
        Round$$Decimal$$MidpointRounding:function(d,mode)
        {
            throw new System.NotImplementedException.ctor();
        },
        Round$$Double$$Int32:function(value,digits)
        {
            throw new System.NotImplementedException.ctor();
        },
        Round$$Double$$MidpointRounding:function(value,mode)
        {
            throw new System.NotImplementedException.ctor();
        },
        Round$$Decimal$$Int32$$MidpointRounding:function(d,decimals,mode)
        {
            throw new System.NotImplementedException.ctor();
        },
        Round$$Double$$Int32$$MidpointRounding:function(value,digits,mode)
        {
            throw new System.NotImplementedException.ctor();
        },
        Sign$$Decimal:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Sign$$Double:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Sign$$Int16:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Sign$$Int32:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Sign$$Int64:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Sign$$SByte:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Sign$$Single:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Sin:function(a)
        {
            return Math.sin(a);
        },
        Sinh:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Sqrt:function(d)
        {
            return Math.sqrt(d);
        },
        Tan:function(a)
        {
            return Math.tan(a);
        },
        Tanh:function(value)
        {
            throw new System.NotImplementedException.ctor();
        },
        Truncate$$Decimal:function(d)
        {
            throw new System.NotImplementedException.ctor();
        },
        Truncate$$Double:function(d)
        {
            throw new System.NotImplementedException.ctor();
        }
    },
    assemblyName:"SharpKit.JsClr",
    Kind:"Class",
    definition:
    {
        ctor:function()
        {
            System.Object.ctor.call(this);
        }
    }
};
JsTypes.push(System$Math);
