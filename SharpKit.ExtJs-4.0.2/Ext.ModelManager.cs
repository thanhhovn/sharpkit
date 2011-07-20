//***************************************************
//* This file was generated by tool
//* 20/07/2011 17:29:50
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext
namespace Ext
{
    #region ModelManager
    /// <summary>
    /// The ModelManager keeps track of all Ext.data.Model types defined in your application. Creating Model Instances
    /// Model instances can be created by using the create function. It is also possible to do
    /// this by using the Model type directly. The following snippets are equivalent: Ext.define(&#39;User&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [&#39;first&#39;, &#39;last&#39;]
    /// });
    /// // method 1, create through the manager
    /// Ext.ModelManager.create({
    /// first: &#39;Ed&#39;,
    /// last: &#39;Spencer&#39;
    /// }, &#39;User&#39;);
    /// // method 2, create on the type directly
    /// new User({
    /// first: &#39;Ed&#39;,
    /// last: &#39;Spencer&#39;
    /// });
    /// Accessing Model Types
    /// A reference to a Model type can be obtained by using the getModel function. Since models types
    /// are normal classes, you can access the type directly. The following snippets are equivalent: Ext.define(&#39;User&#39;, {
    /// extend: &#39;Ext.data.Model&#39;,
    /// fields: [&#39;first&#39;, &#39;last&#39;]
    /// });
    /// // method 1, access model type through the manager
    /// var UserType = Ext.ModelManager.getModel(&#39;User&#39;);
    /// // method 2, reference the type directly
    /// var UserType = User;
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class ModelManager : AbstractManager
    {
        public JsArray associationStack{get;set;}
    }
    #endregion
    #region ModelManagerConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class ModelManagerConfig
    {
    }
    #endregion
    #region ModelManagerEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class ModelManagerEvents
    {
    }
    #endregion
}
#endregion
