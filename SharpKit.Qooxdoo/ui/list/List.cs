// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;
using qx.ui.virtualx.selection;

namespace qx.ui.list
{
    /// <summary>
	/// <para>The qx.ui.list.List is based on the virtual infrastructure and
	/// supports filtering, sorting, grouping, single selection, multi selection,
	/// data binding and custom rendering.</para>
	/// <para>Using the virtual infrastructure has considerable advantages when there is a
	/// huge amount of model items to render because the virtual infrastructure only
	/// creates widgets for visible items and reuses them. This saves both creation
	/// time and memory.</para>
	/// <para>With the <see cref="qx.ui.list.core.IListDelegate"/> interface it is possible
	/// to configure the list&#8217;s behavior (item and group renderer configuration,
	/// filtering, sorting, grouping, etc.).</para>
	/// <para>Here&#8217;s an example of how to use the widget:</para>
	/// <code>
	/// //create the model data
	/// var rawData = [];
	/// for (var i = 0; i < 2500; i++) {
	/// rawData[i] = "Item No " + i;
	/// }
	/// var model = qx.data.marshal.Json.createModel(rawData);
	/// //create the list
	/// var list = new qx.ui.list.List(model);
	/// //configure the lists's behavior
	/// var delegate = {
	/// sorter : function(a, b) {
	/// return a > b ? 1 : a < b ? -1 : 0;
	/// }
	/// };
	/// list.setDelegate(delegate);
	/// //Pre-Select "Item No 20"
	/// list.getSelection().push(model.getItem(20));
	/// //log selection changes
	/// list.getSelection().addListener("change", function(e) {
	/// this.debug("Selection: " + list.getSelection().getItem(0));
	/// }, this);
	/// </code>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.list.List", OmitOptionalParameters = true, Export = false)]
    public partial class List : qx.ui.virtualx.core.Scroller, qx.data.controller.ISelection
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Delegate"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeDelegate;

		/// <summary>
		/// Fired on change of the property <see cref="Groups"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeGroups;

		/// <summary>
		/// Fired on change of the property <see cref="Model"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeModel;

		/// <summary>
		/// Fired on change of the property <see cref="Selection"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeSelection;

		#endregion Events

		#region Properties

		[JsProperty(Name = "appearance", NativeField = true)]
		public object Appearance { get; set; }

		/// <summary>
		/// <para>Indicates that the list is managing the <see cref="Groups"/> automatically.</para>
		/// </summary>
		[JsProperty(Name = "autoGrouping", NativeField = true)]
		public bool AutoGrouping { get; set; }

		/// <summary>
		/// <para>Delegation object which can have one or more functions defined by the
		/// <see cref="qx.ui.list.core.IListDelegate"/> interface.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "delegate", NativeField = true)]
		public object Delegate { get; set; }

		[JsProperty(Name = "focusable", NativeField = true)]
		public object Focusable { get; set; }

		/// <summary>
		/// <para>A map containing the options for the group label binding. The possible keys
		/// can be found in the <see cref="qx.data.SingleValueBinding"/> documentation.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "groupLabelOptions", NativeField = true)]
		public object GroupLabelOptions { get; set; }

		/// <summary>
		/// <para>The path to the property which holds the information that should be
		/// displayed as a group label. This is only needed if objects are stored in the
		/// model.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "groupLabelPath", NativeField = true)]
		public string GroupLabelPath { get; set; }

		/// <summary>
		/// <para>Contains all groups for data binding, but do only manipulate the array
		/// when the <see cref="AutoGrouping"/> is set to false.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: false
		/// </remarks>
		[JsProperty(Name = "groups", NativeField = true)]
		public qx.data.Array Groups { get; set; }

		[JsProperty(Name = "height", NativeField = true)]
		public object Height { get; set; }

		/// <summary>
		/// <para>A map containing the options for the icon binding. The possible keys
		/// can be found in the <see cref="qx.data.SingleValueBinding"/> documentation.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "iconOptions", NativeField = true)]
		public object IconOptions { get; set; }

		/// <summary>
		/// <para>The path to the property which holds the information that should be
		/// displayed as an icon. This is only needed if objects are stored in the
		/// model and icons should be displayed.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "iconPath", NativeField = true)]
		public string IconPath { get; set; }

		/// <summary>
		/// <para>Default item height</para>
		/// </summary>
		[JsProperty(Name = "itemHeight", NativeField = true)]
		public double ItemHeight { get; set; }

		/// <summary>
		/// <para>A map containing the options for the label binding. The possible keys
		/// can be found in the <see cref="qx.data.SingleValueBinding"/> documentation.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "labelOptions", NativeField = true)]
		public object LabelOptions { get; set; }

		/// <summary>
		/// <para>The path to the property which holds the information that should be
		/// displayed as a label. This is only needed if objects are stored in the
		/// model.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "labelPath", NativeField = true)]
		public string LabelPath { get; set; }

		/// <summary>
		/// <para>Data array containing the data which should be shown in the list.</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "model", NativeField = true)]
		public qx.data.Array Model { get; set; }

		[JsProperty(Name = "width", NativeField = true)]
		public object Width { get; set; }

		/// <summary>
		/// <para>Enable drag selection (multi selection of items through
		/// dragging the mouse in pressed states).</para>
		/// <para>Only possible for the selection modes multi and additive</para>
		/// </summary>
		[JsProperty(Name = "dragSelection", NativeField = true)]
		public bool DragSelection { get; set; }

		/// <summary>
		/// <para>Enable quick selection mode, where no click is needed to change the selection.</para>
		/// <para>Only possible for the modes single and one.</para>
		/// </summary>
		[JsProperty(Name = "quickSelection", NativeField = true)]
		public bool QuickSelection { get; set; }

		/// <summary>
		/// <para>Current selected items</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: false
		/// </remarks>
		[JsProperty(Name = "selection", NativeField = true)]
		public qx.data.Array Selection { get; set; }

		/// <summary>
		/// <para>The selection mode to use.</para>
		/// <see cref="qx.ui.core.selection.Abstract.Mode"/></para>
		/// </summary>
		/// <remarks>
		/// Possible values: "single","multi","additive","one"
		/// </remarks>
		[JsProperty(Name = "selectionMode", NativeField = true)]
		public object SelectionMode { get; set; }

		#endregion Properties

		#region Methods

		public List() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Creates the qx.ui.list.List with the passed model.</para>
		/// </summary>
		/// <param name="model">model for the list.</param>
		public List(qx.data.Array model) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property autoGrouping.</para>
		/// </summary>
		[JsMethod(Name = "getAutoGrouping")]
		public bool GetAutoGrouping() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property delegate.</para>
		/// </summary>
		[JsMethod(Name = "getDelegate")]
		public object GetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property groupLabelOptions.</para>
		/// </summary>
		[JsMethod(Name = "getGroupLabelOptions")]
		public object GetGroupLabelOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property groupLabelPath.</para>
		/// </summary>
		[JsMethod(Name = "getGroupLabelPath")]
		public string GetGroupLabelPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property groups.</para>
		/// </summary>
		[JsMethod(Name = "getGroups")]
		public qx.data.Array GetGroups() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconOptions.</para>
		/// </summary>
		[JsMethod(Name = "getIconOptions")]
		public object GetIconOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property iconPath.</para>
		/// </summary>
		[JsMethod(Name = "getIconPath")]
		public string GetIconPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property itemHeight.</para>
		/// </summary>
		[JsMethod(Name = "getItemHeight")]
		public double GetItemHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property labelOptions.</para>
		/// </summary>
		[JsMethod(Name = "getLabelOptions")]
		public object GetLabelOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property labelPath.</para>
		/// </summary>
		[JsMethod(Name = "getLabelPath")]
		public string GetLabelPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property model.</para>
		/// </summary>
		[JsMethod(Name = "getModel")]
		public qx.data.Array GetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property autoGrouping
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property autoGrouping.</param>
		[JsMethod(Name = "initAutoGrouping")]
		public void InitAutoGrouping(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property delegate
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property delegate.</param>
		[JsMethod(Name = "initDelegate")]
		public void InitDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property groupLabelOptions
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property groupLabelOptions.</param>
		[JsMethod(Name = "initGroupLabelOptions")]
		public void InitGroupLabelOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property groupLabelPath
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property groupLabelPath.</param>
		[JsMethod(Name = "initGroupLabelPath")]
		public void InitGroupLabelPath(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property groups
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property groups.</param>
		[JsMethod(Name = "initGroups")]
		public void InitGroups(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconOptions
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconOptions.</param>
		[JsMethod(Name = "initIconOptions")]
		public void InitIconOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property iconPath
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property iconPath.</param>
		[JsMethod(Name = "initIconPath")]
		public void InitIconPath(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property itemHeight
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property itemHeight.</param>
		[JsMethod(Name = "initItemHeight")]
		public void InitItemHeight(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property labelOptions
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property labelOptions.</param>
		[JsMethod(Name = "initLabelOptions")]
		public void InitLabelOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property labelPath
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property labelPath.</param>
		[JsMethod(Name = "initLabelPath")]
		public void InitLabelPath(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property model
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property model.</param>
		[JsMethod(Name = "initModel")]
		public void InitModel(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property autoGrouping equals true.</para>
		/// </summary>
		[JsMethod(Name = "isAutoGrouping")]
		public void IsAutoGrouping() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Trigger a rebuild from the internal data structure.</para>
		/// </summary>
		[JsMethod(Name = "refresh")]
		public void Refresh() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property autoGrouping.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetAutoGrouping")]
		public void ResetAutoGrouping() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property delegate.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDelegate")]
		public void ResetDelegate() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property groupLabelOptions.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGroupLabelOptions")]
		public void ResetGroupLabelOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property groupLabelPath.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGroupLabelPath")]
		public void ResetGroupLabelPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property groups.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGroups")]
		public void ResetGroups() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconOptions.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconOptions")]
		public void ResetIconOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property iconPath.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetIconPath")]
		public void ResetIconPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property itemHeight.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetItemHeight")]
		public void ResetItemHeight() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property labelOptions.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLabelOptions")]
		public void ResetLabelOptions() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property labelPath.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLabelPath")]
		public void ResetLabelPath() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property model.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetModel")]
		public void ResetModel() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property autoGrouping.</para>
		/// </summary>
		/// <param name="value">New value for property autoGrouping.</param>
		[JsMethod(Name = "setAutoGrouping")]
		public void SetAutoGrouping(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property delegate.</para>
		/// </summary>
		/// <param name="value">New value for property delegate.</param>
		[JsMethod(Name = "setDelegate")]
		public void SetDelegate(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property groupLabelOptions.</para>
		/// </summary>
		/// <param name="value">New value for property groupLabelOptions.</param>
		[JsMethod(Name = "setGroupLabelOptions")]
		public void SetGroupLabelOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property groupLabelPath.</para>
		/// </summary>
		/// <param name="value">New value for property groupLabelPath.</param>
		[JsMethod(Name = "setGroupLabelPath")]
		public void SetGroupLabelPath(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property groups.</para>
		/// </summary>
		/// <param name="value">New value for property groups.</param>
		[JsMethod(Name = "setGroups")]
		public void SetGroups(qx.data.Array value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconOptions.</para>
		/// </summary>
		/// <param name="value">New value for property iconOptions.</param>
		[JsMethod(Name = "setIconOptions")]
		public void SetIconOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property iconPath.</para>
		/// </summary>
		/// <param name="value">New value for property iconPath.</param>
		[JsMethod(Name = "setIconPath")]
		public void SetIconPath(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property itemHeight.</para>
		/// </summary>
		/// <param name="value">New value for property itemHeight.</param>
		[JsMethod(Name = "setItemHeight")]
		public void SetItemHeight(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property labelOptions.</para>
		/// </summary>
		/// <param name="value">New value for property labelOptions.</param>
		[JsMethod(Name = "setLabelOptions")]
		public void SetLabelOptions(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property labelPath.</para>
		/// </summary>
		/// <param name="value">New value for property labelPath.</param>
		[JsMethod(Name = "setLabelPath")]
		public void SetLabelPath(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property model.</para>
		/// </summary>
		/// <param name="value">New value for property model.</param>
		[JsMethod(Name = "setModel")]
		public void SetModel(qx.data.Array value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property autoGrouping.</para>
		/// </summary>
		[JsMethod(Name = "toggleAutoGrouping")]
		public void ToggleAutoGrouping() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property dragSelection.</para>
		/// </summary>
		[JsMethod(Name = "getDragSelection")]
		public bool GetDragSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property quickSelection.</para>
		/// </summary>
		[JsMethod(Name = "getQuickSelection")]
		public bool GetQuickSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Getter for the selection list.</para>
		/// </summary>
		/// <returns>The current selection.</returns>
		[JsMethod(Name = "getSelection")]
		public qx.data.IListData GetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property selectionMode.</para>
		/// </summary>
		[JsMethod(Name = "getSelectionMode")]
		public object GetSelectionMode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property dragSelection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property dragSelection.</param>
		[JsMethod(Name = "initDragSelection")]
		public void InitDragSelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property quickSelection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property quickSelection.</param>
		[JsMethod(Name = "initQuickSelection")]
		public void InitQuickSelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selection
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selection.</param>
		[JsMethod(Name = "initSelection")]
		public void InitSelection(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property selectionMode
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property selectionMode.</param>
		[JsMethod(Name = "initSelectionMode")]
		public void InitSelectionMode(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property dragSelection equals true.</para>
		/// </summary>
		[JsMethod(Name = "isDragSelection")]
		public void IsDragSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Check whether the (computed) value of the boolean property quickSelection equals true.</para>
		/// </summary>
		[JsMethod(Name = "isQuickSelection")]
		public void IsQuickSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property dragSelection.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetDragSelection")]
		public void ResetDragSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property quickSelection.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetQuickSelection")]
		public void ResetQuickSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the selection to its default value.</para>
		/// </summary>
		[JsMethod(Name = "resetSelection")]
		public void ResetSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property selectionMode.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetSelectionMode")]
		public void ResetSelectionMode() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property dragSelection.</para>
		/// </summary>
		/// <param name="value">New value for property dragSelection.</param>
		[JsMethod(Name = "setDragSelection")]
		public void SetDragSelection(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property quickSelection.</para>
		/// </summary>
		/// <param name="value">New value for property quickSelection.</param>
		[JsMethod(Name = "setQuickSelection")]
		public void SetQuickSelection(bool value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Setter for the selection.</para>
		/// </summary>
		/// <param name="value">The data of the selection.</param>
		[JsMethod(Name = "setSelection")]
		public void SetSelection(qx.data.IListData value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property selectionMode.</para>
		/// </summary>
		/// <param name="value">New value for property selectionMode.</param>
		[JsMethod(Name = "setSelectionMode")]
		public void SetSelectionMode(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property dragSelection.</para>
		/// </summary>
		[JsMethod(Name = "toggleDragSelection")]
		public void ToggleDragSelection() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Toggles the (computed) value of the boolean property quickSelection.</para>
		/// </summary>
		[JsMethod(Name = "toggleQuickSelection")]
		public void ToggleQuickSelection() { throw new NotImplementedException(); }

		#endregion Methods
    }
}