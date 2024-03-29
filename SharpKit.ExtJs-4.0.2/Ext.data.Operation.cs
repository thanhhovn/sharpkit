//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.data
namespace Ext.data
{
    #region Operation
    /// <summary>
    /// Represents a single read or write operation performed by a Proxy.
    /// Operation objects are used to enable communication between Stores and Proxies. Application
    /// developers should rarely need to interact with Operation objects directly. Several Operations can be batched together in a batch.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Operation
    {
        /// <summary>
        /// Creates new Operation object. ...
        /// </summary>
        public Operation(object config=null){}
        /// <summary>
        /// Checks whether this operation should cause writing to occur. ...
        /// </summary>
        public bool allowWrite(){return false;}
        /// <summary>
        /// Returns the error string or object that was set using setException ...
        /// </summary>
        public object getError(){return null;}
        /// <summary>
        /// Returns an array of Ext.data.Model instances as set by the Proxy. ...
        /// </summary>
        public JsArray getRecords(){return null;}
        /// <summary>
        /// Returns the ResultSet object (if set by the Proxy). ...
        /// </summary>
        public ResultSet getResultSet(){return null;}
        /// <summary>
        /// Returns true if this Operation encountered an exception (see also getError) ...
        /// </summary>
        public bool hasException(){return false;}
        /// <summary>
        /// Returns true if the Operation has been completed ...
        /// </summary>
        public bool isComplete(){return false;}
        /// <summary>
        /// Returns true if the Operation has been started but has not yet completed. ...
        /// </summary>
        public bool isRunning(){return false;}
        /// <summary>
        /// Returns true if the Operation has been started. ...
        /// </summary>
        public bool isStarted(){return false;}
        /// <summary>
        /// Marks the Operation as completed ...
        /// </summary>
        public object setCompleted(){return null;}
        /// <summary>
        /// Marks the Operation as having experienced an exception. ...
        /// </summary>
        public object setException(object error){return null;}
        /// <summary>
        /// Marks the Operation as started ...
        /// </summary>
        public object setStarted(){return null;}
        /// <summary>
        /// Marks the Operation as successful ...
        /// </summary>
        public object setSuccessful(){return null;}
        /// <summary>
        /// Returns true if the Operation has completed and was successful ...
        /// </summary>
        public bool wasSuccessful(){return false;}
        public Operation(OperationConfig config){}
    }
    #endregion
    #region OperationConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class OperationConfig
    {
        /// <summary>
        /// The action being performed by this Operation. ...
        /// </summary>
        public JsString action{get;set;}
        public Batch batch{get;set;}
        /// <summary>
        /// Optional array of filter objects. ...
        /// </summary>
        public JsArray filters{get;set;}
        /// <summary>
        /// Optional grouping configuration. ...
        /// </summary>
        public object group{get;set;}
        /// <summary>
        /// The number of records to load. ...
        /// </summary>
        public JsNumber limit{get;set;}
        /// <summary>
        /// Optional array of sorter objects. ...
        /// </summary>
        public JsArray sorters{get;set;}
        public JsNumber start{get;set;}
        /// <summary>
        /// True if this Operation is to be executed synchronously (defaults to true). ...
        /// </summary>
        public bool synchronous{get;set;}
    }
    #endregion
    #region OperationEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class OperationEvents
    {
    }
    #endregion
}
#endregion
