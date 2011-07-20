//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:52:01
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region Number
    /// <summary>
    /// A collection of useful static methods to deal with numbers
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Number
    {
        /// <summary>
        /// Checks whether or not the passed number is within a desired range. ...
        /// </summary>
        public JsNumber constrain(JsNumber number, JsNumber min, JsNumber max){return null;}
        /// <summary>
        /// Validate that a value is numeric and convert it to a number if necessary. ...
        /// </summary>
        public JsNumber from(object value, JsNumber defaultValue){return null;}
        /// <summary>
        /// Snaps the passed number between stopping points based upon a passed increment value. ...
        /// </summary>
        public JsNumber snap(JsNumber value, JsNumber increment, JsNumber minValue, JsNumber maxValue){return null;}
        /// <summary>
        /// Formats a number using fixed-point notation ...
        /// </summary>
        public object toFixed(JsNumber value, JsNumber precision){return null;}
    }
    #endregion
    #region NumberConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class NumberConfig
    {
    }
    #endregion
    #region NumberEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class NumberEvents
    {
    }
    #endregion
}
#endregion
