//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using System;
using System.Collections.Generic;
using SharpKit.JavaScript;
namespace YUI_.DataSchema_
{
    /// <summary>
    /// Provides a DataSchema implementation which can be used to work with JSON data.
    /// See the `apply` method for usage.
    /// </summary>
    public partial class JSON : YUI_.DataSchema_.Base
    {
        /// <summary>
        /// Get field data values out of list of full results
        /// </summary>
        protected object _getFieldValues(YUI_.Array fields, YUI_.Array array_in, object data_out){return null;}
        /// <summary>
        /// Parses results data according to schema
        /// </summary>
        protected object _parseMeta(object metaFields, object json_in, object data_out){return null;}
        /// <summary>
        /// Schema-parsed list of results from full data
        /// </summary>
        protected object _parseResults(object schema, object json_in, object data_out){return null;}
        /// <summary>
        /// Applies a schema to an array of data located in a JSON structure, returning
        /// a normalized object with results in the `results` property. Additional
        /// information can be parsed out of the JSON for inclusion in the `meta`
        /// property of the response object.  If an error is encountered during
        /// processing, an `error` property will be added.
        /// The input _data_ is expected to be an object or array.  If it is a string,
        /// it will be passed through `Y.JSON.parse()`.
        /// If _data_ contains an array of data records to normalize, specify the
        /// _schema.resultListLocator_ as a dot separated path string just as you would
        /// reference it in JavaScript.  So if your _data_ object has a record array at
        /// _data.response.results_, use _schema.resultListLocator_ =
        /// "response.results". Bracket notation can also be used for array indices or
        /// object properties (e.g. "response['results']");  This is called a "path
        /// locator"
        /// Field data in the result list is extracted with field identifiers in
        /// _schema.resultFields_.  Field identifiers are objects with the following
        /// properties:
        /// * `key`   : <strong>(required)</strong> The path locator (String)
        /// * `parser`: A function or the name of a function on `Y.Parsers` used
        /// to convert the input value into a normalized type.  Parser
        /// functions are passed the value as input and are expected to
        /// return a value.
        /// If no value parsing is needed, you can use path locators (strings)
        /// instead of field identifiers (objects) -- see example below.
        /// If no processing of the result list array is needed, _schema.resultFields_
        /// can be omitted; the `response.results` will point directly to the array.
        /// If the result list contains arrays, `response.results` will contain an
        /// array of objects with key:value pairs assuming the fields in
        /// _schema.resultFields_ are ordered in accordance with the data array
        /// values.
        /// If the result list contains objects, the identified _schema.resultFields_
        /// will be used to extract a value from those objects for the output result.
        /// To extract additional information from the JSON, include an array of
        /// path locators in _schema.metaFields_.  The collected values will be
        /// stored in `response.meta`.
        /// </summary>
        public object apply(object data){return null;}
        /// <summary>
        /// Applies a schema to an array of data located in a JSON structure, returning
        /// a normalized object with results in the `results` property. Additional
        /// information can be parsed out of the JSON for inclusion in the `meta`
        /// property of the response object.  If an error is encountered during
        /// processing, an `error` property will be added.
        /// The input _data_ is expected to be an object or array.  If it is a string,
        /// it will be passed through `Y.JSON.parse()`.
        /// If _data_ contains an array of data records to normalize, specify the
        /// _schema.resultListLocator_ as a dot separated path string just as you would
        /// reference it in JavaScript.  So if your _data_ object has a record array at
        /// _data.response.results_, use _schema.resultListLocator_ =
        /// "response.results". Bracket notation can also be used for array indices or
        /// object properties (e.g. "response['results']");  This is called a "path
        /// locator"
        /// Field data in the result list is extracted with field identifiers in
        /// _schema.resultFields_.  Field identifiers are objects with the following
        /// properties:
        /// * `key`   : <strong>(required)</strong> The path locator (String)
        /// * `parser`: A function or the name of a function on `Y.Parsers` used
        /// to convert the input value into a normalized type.  Parser
        /// functions are passed the value as input and are expected to
        /// return a value.
        /// If no value parsing is needed, you can use path locators (strings)
        /// instead of field identifiers (objects) -- see example below.
        /// If no processing of the result list array is needed, _schema.resultFields_
        /// can be omitted; the `response.results` will point directly to the array.
        /// If the result list contains arrays, `response.results` will contain an
        /// array of objects with key:value pairs assuming the fields in
        /// _schema.resultFields_ are ordered in accordance with the data array
        /// values.
        /// If the result list contains objects, the identified _schema.resultFields_
        /// will be used to extract a value from those objects for the output result.
        /// To extract additional information from the JSON, include an array of
        /// path locators in _schema.metaFields_.  The collected values will be
        /// stored in `response.meta`.
        /// </summary>
        public object apply(object schema, object data){return null;}
        /// <summary>
        /// Serializes a Date instance as a UTC date string.  Used internally by
        /// stringify.  Override this method if you need Dates serialized in a
        /// different format.
        /// </summary>
        public object dateToString(YUI_.DataType_.Date d){return null;}
        /// <summary>
        /// Utility function to walk a path and return the value located there.
        /// </summary>
        public object getLocationValue(object path, object data){return null;}
        /// <summary>
        /// Utility function converts JSON locator strings into walkable paths
        /// </summary>
        public object getPath(object locator){return null;}
        /// <summary>
        /// Parse a JSON string, returning the native JavaScript representation.
        /// </summary>
        public object parse(object s, JsAction reviver){return null;}
        /// <summary>
        /// <p>Converts an arbitrary value to a JSON string representation.</p>
        /// <p>Objects with cyclical references will trigger an exception.</p>
        /// <p>If a whitelist is provided, only matching object keys will be
        /// included.  Alternately, a replacer function may be passed as the
        /// second parameter.  This function is executed on every value in the
        /// input, and its return value will be used in place of the original value.
        /// This is useful to serialize specialized objects or class instances.</p>
        /// <p>If a positive integer or non-empty string is passed as the third
        /// parameter, the output will be formatted with carriage returns and
        /// indentation for readability.  If a String is passed (such as "\t") it
        /// will be used once for each indentation level.  If a number is passed,
        /// that number of spaces will be used.</p>
        /// </summary>
        public object stringify(object o, object w, object ind){return null;}
    }
}
