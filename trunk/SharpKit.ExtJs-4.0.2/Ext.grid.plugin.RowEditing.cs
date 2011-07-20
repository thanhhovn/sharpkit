//***************************************************
//* This file was generated by tool
//* 20/07/2011 18:51:26
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.grid.plugin
namespace Ext.grid.plugin
{
    #region RowEditing
    /// <summary>
    /// The Ext.grid.plugin.RowEditing plugin injects editing at a row level for a Grid. When editing begins,
    /// a small floating dialog will be shown for the appropriate row. Each editable column will show a field
    /// for editing. There is a button to save or cancel all changes for the edit. The field that will be used for the editor is defined at the
    /// field. The editor can be a field instance or a field configuration.
    /// If an editor is not specified for a particular column then that column won&#39;t be editable and the value of
    /// the column will be displayed. The editor may be shared for each column in the grid, or a different one may be specified for each column.
    /// An appropriate field type should be chosen to match the data structure that it will be editing. For example,
    /// to edit a date, it would be useful to specify Ext.form.field.Date as the editor.  Example Usage Ext.create(&#39;Ext.data.Store&#39;, {
    /// storeId:&#39;simpsonsStore&#39;,
    /// fields:[&#39;name&#39;, &#39;email&#39;, &#39;phone&#39;],
    /// data:{&#39;items&#39;:[
    /// {&quot;name&quot;:&quot;Lisa&quot;, &quot;email&quot;:&quot;lisa@simpsons.com&quot;, &quot;phone&quot;:&quot;555-111-1224&quot;},
    /// {&quot;name&quot;:&quot;Bart&quot;, &quot;email&quot;:&quot;bart@simpsons.com&quot;, &quot;phone&quot;:&quot;555--222-1234&quot;},
    /// {&quot;name&quot;:&quot;Homer&quot;, &quot;email&quot;:&quot;home@simpsons.com&quot;, &quot;phone&quot;:&quot;555-222-1244&quot;},
    /// {&quot;name&quot;:&quot;Marge&quot;, &quot;email&quot;:&quot;marge@simpsons.com&quot;, &quot;phone&quot;:&quot;555-222-1254&quot;}
    /// ]},
    /// proxy: {
    /// type: &#39;memory&#39;,
    /// reader: {
    /// type: &#39;json&#39;,
    /// root: &#39;items&#39;
    /// }
    /// }
    /// });
    /// Ext.create(&#39;Ext.grid.Panel&#39;, {
    /// title: &#39;Simpsons&#39;,
    /// store: Ext.data.StoreManager.lookup(&#39;simpsonsStore&#39;),
    /// columns: [
    /// {header: &#39;Name&#39;,  dataIndex: &#39;name&#39;, field: &#39;textfield&#39;},
    /// {header: &#39;Email&#39;, dataIndex: &#39;email&#39;, flex:1,
    /// editor: {
    /// xtype:&#39;textfield&#39;,
    /// allowBlank:false
    /// }
    /// },
    /// {header: &#39;Phone&#39;, dataIndex: &#39;phone&#39;}
    /// ],
    /// selType: &#39;rowmodel&#39;,
    /// plugins: [
    /// Ext.create(&#39;Ext.grid.plugin.RowEditing&#39;, {
    /// clicksToEdit: 1
    /// })
    /// ],
    /// height: 200,
    /// width: 400,
    /// renderTo: Ext.getBody()
    /// });
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class RowEditing : Editing, Ext.util.Observable
    {
        /// <summary>
        /// Start editing the specified record, using the specified Column definition to define which field is being edited. ...
        /// </summary>
        public new object startEdit(Ext.data.Model record, Ext.data.Model columnHeader){return null;}
    }
    #endregion
    #region RowEditingConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class RowEditingConfig
    {
        /// <summary>
        /// true to automatically cancel any pending changes when the row editor begins editing a new row. ...
        /// </summary>
        public bool autoCancel{get;set;}
        /// <summary>
        /// The number of clicks to move the row editor to a new row while it is visible and actively editing another row. ...
        /// </summary>
        public JsNumber clicksToMoveEditor{get;set;}
        /// <summary>
        /// true to show a tooltip that summarizes all validation errors present
        /// in the row editor. ...
        /// </summary>
        public bool errorSummary{get;set;}
    }
    #endregion
    #region RowEditingEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class RowEditingEvents
    {
        /// <summary>
        /// Fires before row editing is triggered. ...
        /// </summary>
        public static JsString beforeedit="beforeedit";
        /// <summary>
        /// Fires after a row is edited. ...
        /// </summary>
        public static JsString edit="edit";
        /// <summary>
        /// Fires after a cell is edited, but before the value is set in the record. ...
        /// </summary>
        public static JsString validateedit="validateedit";
    }
    #endregion
}
#endregion
