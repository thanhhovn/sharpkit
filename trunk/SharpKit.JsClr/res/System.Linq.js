/*Generated by SharpKit 5 v4.29.8000*/
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
if (typeof(JsTypes) == "undefined") var JsTypes = [];
var System$Linq$Enumerable = {
    fullname: "System.Linq.Enumerable",
    baseTypeName: "System.Object",
    staticDefinition: {
        
        CombinePredicates$1: function (TSource, predicate1, predicate2) {
            return function (x) {
                return predicate1(x) && predicate2(x);
            };
        },
        
        CombineSelectors$3: function (TSource, TMiddle, TResult, selector1, selector2) {
            return function (x) {
                return selector2(selector1(x));
            };
        },
        
        First$1$$IEnumerable$1: function (TSource, source) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            var list = As(source, System.Collections.Generic.IList$1.ctor);
            if (list != null ) {
                if (list.get_Count() > 0) {
                    return list.get_Item$$Int32(0);
                }
            }
            else {
                var enumerator = source.GetEnumerator();
                try {
                    if (enumerator.MoveNext()) {
                        return enumerator.get_Current();
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
            throw $CreateException(System.Linq.Error.NoElements(), new Error());
        },
        
        First$1$$IEnumerable$1$$Func$2: function (TSource, source, predicate) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            if (predicate == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("predicate"), new Error());
            }
            var $it2 = source.GetEnumerator();
            while ($it2.MoveNext()) {
                var local = $it2.get_Current();
                if (predicate(local)) {
                    return local;
                }
            }
            throw $CreateException(System.Linq.Error.NoMatch(), new Error());
        },
        
        FirstOrDefault$1$$IEnumerable$1: function (TSource, source) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            var list = As(source, System.Collections.Generic.IList$1.ctor);
            if (list != null ) {
                if (list.get_Count() > 0) {
                    return list.get_Item$$Int32(0);
                }
            }
            else {
                var enumerator = source.GetEnumerator();
                try {
                    if (enumerator.MoveNext()) {
                        return enumerator.get_Current();
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
            return Default(TSource);
        },
        
        FirstOrDefault$1$$IEnumerable$1$$Func$2: function (TSource, source, predicate) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            if (predicate == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("predicate"), new Error());
            }
            var $it3 = source.GetEnumerator();
            while ($it3.MoveNext()) {
                var local = $it3.get_Current();
                if (predicate(local)) {
                    return local;
                }
            }
            return Default(TSource);
        },
        
        Last$1$$IEnumerable$1: function (TSource, source) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            var list = As(source, System.Collections.Generic.IList$1.ctor);
            if (list != null ) {
                var count = list.get_Count();
                if (count > 0) {
                    return list.get_Item$$Int32(count - 1);
                }
            }
            else {
                var enumerator = source.GetEnumerator();
                try {
                    if (enumerator.MoveNext()) {
                        var current;
                        do {
                            current = enumerator.get_Current();
                        }
                        while (enumerator.MoveNext())
                        return current;
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
            throw $CreateException(System.Linq.Error.NoElements(), new Error());
        },
        
        Last$1$$IEnumerable$1$$Func$2: function (TSource, source, predicate) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            if (predicate == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("predicate"), new Error());
            }
            var local = Default(TSource);
            var flag = false;
            var $it4 = source.GetEnumerator();
            while ($it4.MoveNext()) {
                var local2 = $it4.get_Current();
                if (predicate(local2)) {
                    local = local2;
                    flag = true;
                }
            }
            if (!flag) {
                throw $CreateException(System.Linq.Error.NoMatch(), new Error());
            }
            return local;
        },
        
        LastOrDefault$1$$IEnumerable$1: function (TSource, source) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            var list = As(source, System.Collections.Generic.IList$1.ctor);
            if (list != null ) {
                var count = list.get_Count();
                if (count > 0) {
                    return list.get_Item$$Int32(count - 1);
                }
            }
            else {
                var enumerator = source.GetEnumerator();
                try {
                    if (enumerator.MoveNext()) {
                        var current;
                        do {
                            current = enumerator.get_Current();
                        }
                        while (enumerator.MoveNext())
                        return current;
                    }
                }
                finally {
                    enumerator.Dispose();
                }
            }
            return Default(TSource);
        },
        
        LastOrDefault$1$$IEnumerable$1$$Func$2: function (TSource, source, predicate) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            if (predicate == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("predicate"), new Error());
            }
            var local = Default(TSource);
            var $it5 = source.GetEnumerator();
            while ($it5.MoveNext()) {
                var local2 = $it5.get_Current();
                if (predicate(local2)) {
                    local = local2;
                }
            }
            return local;
        },
        
        Where$1$$IEnumerable$1$$Func$2: function (TSource, source, predicate) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            if (predicate == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("predicate"), new Error());
            }
            if (Is(source, System.Linq.Enumerable.Iterator.ctor)) {
                return (Cast(source, System.Linq.Enumerable.Iterator.ctor)).Where(predicate);
            }
            if (Is(source, Array)) {
                return new System.Linq.Enumerable.WhereArrayIterator.ctor(TSource, Cast(source, Array), predicate);
            }
            if (Is(source, System.Collections.Generic.List$1.ctor)) {
                return new System.Linq.Enumerable.WhereListIterator.ctor(TSource, Cast(source, System.Collections.Generic.List$1.ctor), predicate);
            }
            return new System.Linq.Enumerable.WhereEnumerableIterator.ctor(TSource, source, predicate);
        },
        
        Where$1$$IEnumerable$1$$Func$3: function (TSource, source, predicate) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            if (predicate == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("predicate"), new Error());
            }
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        
        Contains$1$$IEnumerable$1$$TSource: function (TSource, source, value) {
            if (source == null ) throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            var is2 = As(source, System.Collections.Generic.ICollection$1.ctor);
            if (is2 != null ) return is2.Contains(value);
            var $it6 = source.GetEnumerator();
            while ($it6.MoveNext()) {
                var local = $it6.get_Current();
                if (local == value) return true;
            }
            return false;
        },
        
        Contains$1$$IEnumerable$1$$TSource$$IEqualityComparer$1: function (TSource, source, value, comparer) {
            if (comparer == null ) {
                return System.Linq.Enumerable.Contains$1$$IEnumerable$1$$TSource(TSource, source, value);
            }
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            var $it7 = source.GetEnumerator();
            while ($it7.MoveNext()) {
                var local = $it7.get_Current();
                if (comparer.Equals$$T$$T(local, value)) {
                    return true;
                }
            }
            return false;
        },
        
        Any$1$$IEnumerable$1: function (TSource, source) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            var enumerator = source.GetEnumerator();
            try {
                if (enumerator.MoveNext()) {
                    return true;
                }
            }
            finally {
                enumerator.Dispose();
            }
            return false;
        },
        
        Any$1$$IEnumerable$1$$Func$2: function (TSource, source, predicate) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            if (predicate == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("predicate"), new Error());
            }
            var $it8 = source.GetEnumerator();
            while ($it8.MoveNext()) {
                var local = $it8.get_Current();
                if (predicate(local)) {
                    return true;
                }
            }
            return false;
        },
        
        Count$1$$IEnumerable$1: function (TSource, source) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            var is2 = As(source, System.Collections.Generic.ICollection$1.ctor);
            if (is2 != null ) {
                return is2.get_Count();
            }
            var num = 0;
            var enumerator = source.GetEnumerator();
            try {
                while (enumerator.MoveNext()) {
                    num++;
                }
            }
            finally {
                enumerator.Dispose();
            }
            return num;
        },
        
        Count$1$$IEnumerable$1$$Func$2: function (TSource, source, predicate) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            if (predicate == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("predicate"), new Error());
            }
            var num = 0;
            var $it9 = source.GetEnumerator();
            while ($it9.MoveNext()) {
                var local = $it9.get_Current();
                if (predicate(local)) {
                    num++;
                }
            }
            return num;
        },
        
        OfType$1: function (TResult, source) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            return new System.Linq.OfTypeIterator.ctor(TResult, source);
        },
        
        Select$2$$IEnumerable$1$$Func$2: function (TSource, TResult, source, selector) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            if (selector == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("selector"), new Error());
            }
            if (Is(source, System.Linq.Enumerable.Iterator.ctor)) {
                return (Cast(source, System.Linq.Enumerable.Iterator.ctor)).Select$1(TResult, selector);
            }
            if (Is(source, Array)) {
                return new System.Linq.Enumerable.WhereSelectArrayIterator.ctor(TSource, TResult, Cast(source, Array), null , selector);
            }
            if (Is(source, System.Collections.Generic.List$1.ctor)) {
                return new System.Linq.Enumerable.WhereSelectListIterator.ctor(TSource, TResult, Cast(source, System.Collections.Generic.List$1.ctor), null , selector);
            }
            return new System.Linq.Enumerable.WhereSelectEnumerableIterator.ctor(TSource, TResult, source, null , selector);
        },
        
        Select$2$$IEnumerable$1$$Func$3: function (TSource, TResult, source, selector) {
            throw $CreateException(new System.NotImplementedException.ctor(), new Error());
        },
        
        Take$1: function (TSource, source, count) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            return System.Linq.Enumerable.TakeIterator$1(TSource, source, count);
        },
        
        TakeIterator$1: function (TSource, source, count) {
            var d__ = new SharpKit.JavaScript.Private.JsImplTakeIterator$1.ctor(TSource, -2);
            d__._Source = source;
            d__._Count = count;
            return d__;
        },
        
        ToArray$1: function (TSource, source) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            var arr =  [];
            var $it10 = source.GetEnumerator();
            while ($it10.MoveNext()) {
                var obj = $it10.get_Current();
                arr.push(obj);
            }
            return arr;
        },
        
        ToList$1: function (TSource, source) {
            if (source == null ) {
                throw $CreateException(System.Linq.Error.ArgumentNull("source"), new Error());
            }
            return new System.Collections.Generic.List$1.ctor$$IEnumerable$1(TSource, source);
        }
        
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        
        ctor: function () {
            System.Object.ctor.call(this);
        }
        
    }
};
JsTypes.push(System$Linq$Enumerable);
var System$Linq$Enumerable$Iterator = {
    fullname: "System.Linq.Enumerable.Iterator",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collections.Generic.IEnumerable$1", "System.Collections.IEnumerable", "System.Collections.Generic.IEnumerator$1", "System.IDisposable", "System.Collections.IEnumerator"],
    Kind: "Class",
    definition: {
        
        ctor: function (TSource) {
            this.TSource = TSource;
            this.state = 0;
            this.current = null;
            System.Object.ctor.call(this);
        },
        
        Current$$: "`0",
        
        get_Current: function () {
            return this.current;
        },
        
        Dispose: function () {
            this.current = Default(this.TSource);
            this.state = -1;
        },
        
        GetEnumerator: function () {
            if (this.state == 0) {
                this.state = 1;
                return this;
            }
            var iterator = this.Clone();
            iterator.state = 1;
            return iterator;
        }
        
    }
};
JsTypes.push(System$Linq$Enumerable$Iterator);
var System$Linq$Enumerable$WhereArrayIterator = {
    fullname: "System.Linq.Enumerable.WhereArrayIterator",
    baseTypeName: "System.Linq.Enumerable.Iterator",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        
        ctor: function (TSource, source, predicate) {
            this.TSource = TSource;
            this.source = null;
            this.predicate = null;
            this.index = 0;
            System.Linq.Enumerable.Iterator.ctor.call(this, this.TSource);
            this.source = source;
            this.predicate = predicate;
        },
        
        Clone: function () {
            return new System.Linq.Enumerable.WhereArrayIterator.ctor(this.TSource, this.source, this.predicate);
        },
        
        MoveNext: function () {
            if (this.state == 1) {
                while (this.index < this.source.length) {
                    var tSource = this.source[this.index];
                    this.index++;
                    if (this.predicate(tSource)) {
                        this.current = tSource;
                        return true;
                    }
                }
                this.Dispose();
            }
            return false;
        },
        
        Select$1: function (TResult, selector) {
            return new System.Linq.Enumerable.WhereSelectArrayIterator.ctor(this.TSource, TResult, this.source, this.predicate, selector);
        },
        
        Where: function (predicate) {
            return new System.Linq.Enumerable.WhereArrayIterator.ctor(this.TSource, this.source, System.Linq.Enumerable.CombinePredicates$1(this.TSource, this.predicate, predicate));
        }
        
    }
};
JsTypes.push(System$Linq$Enumerable$WhereArrayIterator);
var System$Linq$Enumerable$WhereEnumerableIterator = {
    fullname: "System.Linq.Enumerable.WhereEnumerableIterator",
    baseTypeName: "System.Linq.Enumerable.Iterator",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        
        ctor: function (TSource, source, predicate) {
            this.TSource = TSource;
            this.source = null;
            this.predicate = null;
            this.enumerator = null;
            System.Linq.Enumerable.Iterator.ctor.call(this, this.TSource);
            this.source = source;
            this.predicate = predicate;
        },
        
        Clone: function () {
            return new System.Linq.Enumerable.WhereEnumerableIterator.ctor(this.TSource, this.source, this.predicate);
        },
        
        Dispose: function () {
            if (this.enumerator != null ) {
                this.enumerator.Dispose();
            }
            this.enumerator = null;
            System.Linq.Enumerable.Iterator.commonPrototype.Dispose.call(this);
        },
        
        MoveNext: function () {
            switch (this.state) {
                case 1:
                    this.enumerator = this.source.GetEnumerator();
                    this.state = 2;
                    break;
                case 2:
                    break;
                default :
                    return false;
            }
            while (this.enumerator.MoveNext()) {
                var current = this.enumerator.get_Current();
                if (this.predicate(current)) {
                    this.current = current;
                    return true;
                }
            }
            this.Dispose();
            return false;
        },
        
        Select$1: function (TResult, selector) {
            return new System.Linq.Enumerable.WhereSelectEnumerableIterator.ctor(this.TSource, TResult, this.source, this.predicate, selector);
        },
        
        Where: function (predicate) {
            return new System.Linq.Enumerable.WhereEnumerableIterator.ctor(this.TSource, this.source, System.Linq.Enumerable.CombinePredicates$1(this.TSource, this.predicate, predicate));
        }
        
    }
};
JsTypes.push(System$Linq$Enumerable$WhereEnumerableIterator);
var System$Linq$Enumerable$WhereListIterator = {
    fullname: "System.Linq.Enumerable.WhereListIterator",
    baseTypeName: "System.Linq.Enumerable.Iterator",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        
        ctor: function (TSource, source, predicate) {
            this.TSource = TSource;
            this.source = null;
            this.predicate = null;
            this.enumerator = null;
            System.Linq.Enumerable.Iterator.ctor.call(this, this.TSource);
            this.source = source;
            this.predicate = predicate;
        },
        
        Clone: function () {
            return new System.Linq.Enumerable.WhereListIterator.ctor(this.TSource, this.source, this.predicate);
        },
        
        MoveNext: function () {
            switch (this.state) {
                case 1:
                    this.enumerator = this.source.GetEnumerator();
                    this.state = 2;
                    break;
                case 2:
                    break;
                default :
                    return false;
            }
            while (this.enumerator.MoveNext()) {
                var current = this.enumerator.get_Current();
                if (this.predicate(current)) {
                    this.current = current;
                    return true;
                }
            }
            this.Dispose();
            return false;
        },
        
        Select$1: function (TResult, selector) {
            return new System.Linq.Enumerable.WhereSelectListIterator.ctor(this.TSource, TResult, this.source, this.predicate, selector);
        },
        
        Where: function (predicate) {
            return new System.Linq.Enumerable.WhereListIterator.ctor(this.TSource, this.source, System.Linq.Enumerable.CombinePredicates$1(this.TSource, this.predicate, predicate));
        }
        
    }
};
JsTypes.push(System$Linq$Enumerable$WhereListIterator);
var System$Linq$Enumerable$WhereSelectArrayIterator = {
    fullname: "System.Linq.Enumerable.WhereSelectArrayIterator",
    baseTypeName: "System.Linq.Enumerable.Iterator",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        
        ctor: function (TSource, TResult, source, predicate, selector) {
            this.TSource = TSource;
            this.TResult = TResult;
            this.source = null;
            this.predicate = null;
            this.selector = null;
            this.index = 0;
            System.Linq.Enumerable.Iterator.ctor.call(this, this.TResult);
            this.source = source;
            this.predicate = predicate;
            this.selector = selector;
        },
        
        Clone: function () {
            return new System.Linq.Enumerable.WhereSelectArrayIterator.ctor(this.TSource, this.TResult, this.source, this.predicate, this.selector);
        },
        
        MoveNext: function () {
            if (this.state == 1) {
                while (this.index < this.source.length) {
                    var arg = this.source[this.index];
                    this.index++;
                    if (this.predicate == null || this.predicate(arg)) {
                        this.current = this.selector(arg);
                        return true;
                    }
                }
                this.Dispose();
            }
            return false;
        },
        
        Select$1: function (TResult2, selector) {
            return new System.Linq.Enumerable.WhereSelectArrayIterator.ctor(this.TSource, TResult2, this.source, this.predicate, System.Linq.Enumerable.CombineSelectors$3(this.TSource, this.TResult, TResult2, this.selector, selector));
        },
        
        Where: function (predicate) {
            return new System.Linq.Enumerable.WhereEnumerableIterator.ctor(this.TResult, this, predicate);
        }
        
    }
};
JsTypes.push(System$Linq$Enumerable$WhereSelectArrayIterator);
var System$Linq$Enumerable$WhereSelectEnumerableIterator = {
    fullname: "System.Linq.Enumerable.WhereSelectEnumerableIterator",
    baseTypeName: "System.Linq.Enumerable.Iterator",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        
        ctor: function (TSource, TResult, source, predicate, selector) {
            this.TSource = TSource;
            this.TResult = TResult;
            this.source = null;
            this.predicate = null;
            this.selector = null;
            this.enumerator = null;
            System.Linq.Enumerable.Iterator.ctor.call(this, this.TResult);
            this.source = source;
            this.predicate = predicate;
            this.selector = selector;
        },
        
        Clone: function () {
            return new System.Linq.Enumerable.WhereSelectEnumerableIterator.ctor(this.TSource, this.TResult, this.source, this.predicate, this.selector);
        },
        
        Dispose: function () {
            if (this.enumerator != null ) {
                this.enumerator.Dispose();
            }
            this.enumerator = null;
            System.Linq.Enumerable.Iterator.commonPrototype.Dispose.call(this);
        },
        
        MoveNext: function () {
            switch (this.state) {
                case 1:
                    this.enumerator = this.source.GetEnumerator();
                    this.state = 2;
                    break;
                case 2:
                    break;
                default :
                    return false;
            }
            while (this.enumerator.MoveNext()) {
                var current = this.enumerator.get_Current();
                if (this.predicate == null || this.predicate(current)) {
                    this.current = this.selector(current);
                    return true;
                }
            }
            this.Dispose();
            return false;
        },
        
        Select$1: function (TResult2, selector) {
            return new System.Linq.Enumerable.WhereSelectEnumerableIterator.ctor(this.TSource, TResult2, this.source, this.predicate, System.Linq.Enumerable.CombineSelectors$3(this.TSource, this.TResult, TResult2, this.selector, selector));
        },
        
        Where: function (predicate) {
            return new System.Linq.Enumerable.WhereEnumerableIterator.ctor(this.TResult, this, predicate);
        }
        
    }
};
JsTypes.push(System$Linq$Enumerable$WhereSelectEnumerableIterator);
var System$Linq$Enumerable$WhereSelectListIterator = {
    fullname: "System.Linq.Enumerable.WhereSelectListIterator",
    baseTypeName: "System.Linq.Enumerable.Iterator",
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        
        ctor: function (TSource, TResult, source, predicate, selector) {
            this.TSource = TSource;
            this.TResult = TResult;
            this.source = null;
            this.predicate = null;
            this.selector = null;
            this.enumerator = null;
            System.Linq.Enumerable.Iterator.ctor.call(this, this.TResult);
            this.source = source;
            this.predicate = predicate;
            this.selector = selector;
        },
        
        Clone: function () {
            return new System.Linq.Enumerable.WhereSelectListIterator.ctor(this.TSource, this.TResult, this.source, this.predicate, this.selector);
        },
        
        MoveNext: function () {
            switch (this.state) {
                case 1:
                    this.enumerator = this.source.GetEnumerator();
                    this.state = 2;
                    break;
                case 2:
                    break;
                default :
                    return false;
            }
            while (this.enumerator.MoveNext()) {
                var current = this.enumerator.get_Current();
                if (this.predicate == null || this.predicate(current)) {
                    this.current = this.selector(current);
                    return true;
                }
            }
            this.Dispose();
            return false;
        },
        
        Select$1: function (TResult2, selector) {
            return new System.Linq.Enumerable.WhereSelectListIterator.ctor(this.TSource, TResult2, this.source, this.predicate, System.Linq.Enumerable.CombineSelectors$3(this.TSource, this.TResult, TResult2, this.selector, selector));
        },
        
        Where: function (predicate) {
            return new System.Linq.Enumerable.WhereEnumerableIterator.ctor(this.TResult, this, predicate);
        }
        
    }
};
JsTypes.push(System$Linq$Enumerable$WhereSelectListIterator);
var System$Linq$Error = {
    fullname: "System.Linq.Error",
    baseTypeName: "System.Object",
    staticDefinition: {
        
        ArgumentNull: function (p) {
            return new System.Exception.ctor$$String("ArgumentNull " + p);
        },
        
        NoElements: function () {
            return new System.Exception.ctor$$String("NoElements");
        },
        
        NoMatch: function () {
            return new System.Exception.ctor$$String("NoMatch");
        }
        
    },
    assemblyName: "SharpKit.JsClr",
    Kind: "Class",
    definition: {
        
        ctor: function () {
            System.Object.ctor.call(this);
        }
        
    }
};
JsTypes.push(System$Linq$Error);
var System$Linq$OfTypeIterator = {
    fullname: "System.Linq.OfTypeIterator",
    baseTypeName: "System.Object",
    assemblyName: "SharpKit.JsClr",
    interfaceNames: ["System.Collections.Generic.IEnumerator$1", "System.Collections.Generic.IEnumerable$1"],
    Kind: "Class",
    definition: {
        
        ctor: function (T, source) {
            this.T = T;
            this.Source = null;
            this.SourceEnumerator = null;
            System.Object.ctor.call(this);
            this.Source = source;
        },
        
        Reset: function () {
            if (this.SourceEnumerator != null ) this.SourceEnumerator.Reset();
        },
        
        Current$$: "`0",
        
        get_Current: function () {
            return this.SourceEnumerator.get_Current();
        },
        
        MoveNext: function () {
            if (this.SourceEnumerator == null ) this.SourceEnumerator = this.Source.GetEnumerator();
            while (true) {
                if (!this.SourceEnumerator.MoveNext()) return false;
                var item = this.SourceEnumerator.get_Current();
                if (Is(item, this.T)) return true;
            }
        },
        
        Dispose: function () {
            this.Source = null;
            this.SourceEnumerator = null;
        },
        
        GetEnumerator: function () {
            return this;
        }
        
    }
};
JsTypes.push(System$Linq$OfTypeIterator);
