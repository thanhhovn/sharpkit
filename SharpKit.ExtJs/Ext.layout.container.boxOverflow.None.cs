//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:41 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.layout.container.boxOverflow
{
    #region None
    /// <inheritdocs />
    /// <summary>
    /// <p><strong>NOTE</strong> This is a private utility class for internal use by the framework. Don't rely on its existence.</p><p>Base class for Box Layout overflow handlers. These specialized classes are invoked when a Box Layout
    /// (either an HBox or a VBox) has child items that are either too wide (for HBox) or too tall (for VBox)
    /// for its container.</p>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class None : Ext.Base
    {
        /// <summary>
        /// Normalizes an item reference, string id or numerical index into a reference to the item
        /// </summary>
        /// <param name="item"><p>The item reference, id or index</p>
        /// </param>
        /// <returns>
        /// <span><see cref="Ext.Component">Ext.Component</see></span><div><p>The item</p>
        /// </div>
        /// </returns>
        private Ext.Component getItem(object item){return null;}
        public None(NoneConfig config){}
        public None(){}
        public None(params object[] args){}
    }
    #endregion
    #region NoneConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NoneConfig : Ext.BaseConfig
    {
        public NoneConfig(params object[] args){}
    }
    #endregion
    #region NoneEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class NoneEvents : Ext.BaseEvents
    {
        public NoneEvents(params object[] args){}
    }
    #endregion
}
