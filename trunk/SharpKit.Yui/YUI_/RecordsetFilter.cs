//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_
{
    /// <summary>
    /// Plugin that provides the ability to filter through a recordset.
    /// Uses the filter methods available on Y.Array (see arrayextras submodule) to filter the recordset.
    /// </summary>
    public partial class RecordsetFilter
    {
        /// <summary>
        /// Filter through the recordset with a custom filter function, or a key-value
        /// pair.
        /// </summary>
        public Recordset filter(object filter){return null;}
        /// <summary>
        /// Filter through the recordset with a custom filter function, or a key-value
        /// pair.
        /// </summary>
        public Recordset filter(object filter, object value){return null;}
        /// <summary>
        /// Iterates over the Recordset, returning a new Recordset of all the elements
        /// that match the supplied regular expression
        /// </summary>
        public Recordset grep(object pattern){return null;}
        /// <summary>
        /// The inverse of filter. Executes the supplied function on each item. Returns
        /// a new Recordset containing the items that the supplied function returned
        /// `false` for.
        /// </summary>
        public Recordset reject(JsAction filter){return null;}
    }
}
