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
    /// Provides support for using CSS selectors to query the DOM
    /// </summary>
    public partial class Selector
    {
        /// <summary>
        /// A convenience function to emulate Y.Node's aNode.ancestor(selector).
        /// </summary>
        public object ancestor(object element, object selector, object testSelf){return null;}
        /// <summary>
        /// Retrieves a set of nodes based on a given CSS selector.
        /// </summary>
        public YUI_.Array query(object selector, object root, object firstOnly){return null;}
        /// <summary>
        /// Sets the height of the element to the given size, regardless
        /// of box model, border, padding, etc.
        /// </summary>
        public void setHeight(object element, object size){}
        /// <summary>
        /// Sets the width of the element to the given size, regardless
        /// of box model, border, padding, etc.
        /// </summary>
        public void setWidth(object element, object size){}
        /// <summary>
        /// List of operators and corresponding boolean functions.
        /// These functions are passed the attribute and the current node's value of the attribute.
        /// </summary>
        public object operators{get;set;}
        /// <summary>
        /// Mapping of shorthand tokens to corresponding attribute selector
        /// </summary>
        public object shorthand{get;set;}
    }
}
