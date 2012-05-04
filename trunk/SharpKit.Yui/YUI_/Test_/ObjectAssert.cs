//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_.Test_
{
    /// <summary>
    /// The ObjectAssert object provides functions to test JavaScript objects
    /// for a variety of cases.
    /// </summary>
    public partial class ObjectAssert
    {
        /// <summary>
        /// Asserts that an object has all of the same properties
        /// and property values as the other.
        /// </summary>
        public void areEqual(object expected, object actual, object message){}
        /// <summary>
        /// Asserts that an object has a property with the given name.
        /// </summary>
        public void hasKey(object propertyName, object @object, object message){}
        /// <summary>
        /// Asserts that an object has all properties of a reference object.
        /// </summary>
        public void hasKeys(YUI_.Array properties, object @object, object message){}
        /// <summary>
        /// Asserts that a property with the given name exists on an object's prototype.
        /// </summary>
        public void inheritsKey(object propertyName, object @object, object message){}
        /// <summary>
        /// Asserts that all properties exist on an object prototype.
        /// </summary>
        public void inheritsKeys(YUI_.Array properties, object @object, object message){}
        /// <summary>
        /// Asserts that a property with the given name exists on an object instance (not on its prototype).
        /// </summary>
        public void ownsKey(object propertyName, object @object, object message){}
        /// <summary>
        /// Asserts that all properties exist on an object instance (not on its prototype).
        /// </summary>
        public void ownsKeys(YUI_.Array properties, object @object, object message){}
        /// <summary>
        /// Asserts that an object owns no properties.
        /// </summary>
        public void ownsNoKeys(object @object, object message){}
        /// <summary>
        /// Asserts that an object has a property with the given name.
        /// </summary>
        public void ownsOrInheritsKey(object propertyName, object @object, object message){}
        /// <summary>
        /// Asserts that an object has all properties of a reference object.
        /// </summary>
        public void ownsOrInheritsKeys(YUI_.Array properties, object @object, object message){}
    }
}
