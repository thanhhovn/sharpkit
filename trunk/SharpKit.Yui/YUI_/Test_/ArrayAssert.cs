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
    /// The ArrayAssert object provides functions to test JavaScript array objects
    /// for a variety of cases.
    /// </summary>
    public partial class ArrayAssert
    {
        /// <summary>
        /// Asserts that a value is present in an array. This uses the triple equals
        /// sign so no type coercion may occur.
        /// </summary>
        public void contains(object needle, YUI_.Array haystack, object message){}
        /// <summary>
        /// Asserts that a set of values are present in an array. This uses the triple
        /// equals
        /// sign so no type coercion may occur. For this assertion to pass, all values must
        /// be found.
        /// </summary>
        public void containsItems(object needles, YUI_.Array haystack, object message){}
        /// <summary>
        /// Asserts that a value matching some condition is present in an array. This uses
        /// a function to determine a match.
        /// </summary>
        public void containsMatch(JsAction matcher, YUI_.Array haystack, object message){}
        /// <summary>
        /// Asserts that a value is not present in an array. This uses the triple equals
        /// Asserts that a value is not present in an array. This uses the triple equals
        /// sign so no type coercion may occur.
        /// </summary>
        public void doesNotContain(object needle, YUI_.Array haystack, object message){}
        /// <summary>
        /// Asserts that a set of values are not present in an array. This uses the triple
        /// equals
        /// sign so no type coercion may occur. For this assertion to pass, all values must
        /// not be found.
        /// </summary>
        public void doesNotContainItems(object needles, YUI_.Array haystack, object message){}
        /// <summary>
        /// Asserts that no values matching a condition are present in an array. This uses
        /// a function to determine a match.
        /// </summary>
        public void doesNotContainMatch(JsAction matcher, YUI_.Array haystack, object message){}
        /// <summary>
        /// Asserts that the given value is contained in an array at the specified index.
        /// This uses the triple equals sign so no type coercion will occur.
        /// </summary>
        public void indexOf(object needle, YUI_.Array haystack, object index, object message){}
        /// <summary>
        /// Asserts that an array is empty.
        /// </summary>
        public void isEmpty(YUI_.Array actual, object message){}
        /// <summary>
        /// Asserts that an array is not empty.
        /// </summary>
        public void isNotEmpty(YUI_.Array actual, object message){}
        /// <summary>
        /// Asserts that the values in an array are equal, and in the same position,
        /// as values in another array. This uses the double equals sign
        /// so type coercion may occur. Note that the array objects themselves
        /// need not be the same for this test to pass.
        /// </summary>
        public void itemsAreEqual(YUI_.Array expected, YUI_.Array actual, object message){}
        /// <summary>
        /// Asserts that the values in an array are equivalent, and in the same position,
        /// as values in another array. This uses a function to determine if the values
        /// are equivalent. Note that the array objects themselves
        /// need not be the same for this test to pass.
        /// </summary>
        public object itemsAreEquivalent(YUI_.Array expected, YUI_.Array actual, JsAction comparator, object message){return null;}
        /// <summary>
        /// Asserts that the values in an array are the same, and in the same position,
        /// as values in another array. This uses the triple equals sign
        /// so no type coercion will occur. Note that the array objects themselves
        /// need not be the same for this test to pass.
        /// </summary>
        public void itemsAreSame(YUI_.Array expected, YUI_.Array actual, object message){}
        /// <summary>
        /// Asserts that the given value is contained in an array at the specified index,
        /// starting from the back of the array.
        /// This uses the triple equals sign so no type coercion will occur.
        /// </summary>
        public void lastIndexOf(object needle, YUI_.Array haystack, object index, object message){}
    }
}
