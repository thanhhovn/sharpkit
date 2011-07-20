//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:50:53
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region DirectStore
    /// <summary>
    /// Small helper class to create an Ext.data.Store configured with an
    /// Ext.data.proxy.Direct and Ext.data.reader.Json to make interacting
    /// with an Ext.Direct Server-side Provider easier.
    /// To create a different proxy/reader combination create a basic Ext.data.Store
    /// configured as needed. *Note: Although they are not listed, this class inherits all of the config options of:  Store   JsonReader  root idProperty totalProperty  DirectProxy  directFn paramOrder paramsAsHash
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class DirectStore : Ext.data.Store, Ext.util.Observable, Ext.util.Sortable
    {
        /// <summary>
        /// ...
        /// </summary>
        public new object constructor(object config=null){return null;}
    }
    #endregion
    #region DirectStoreConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class DirectStoreConfig
    {
    }
    #endregion
    #region DirectStoreEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class DirectStoreEvents
    {
    }
    #endregion
}
#endregion
