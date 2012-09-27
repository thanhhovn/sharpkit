//***************************************************
//* This file was generated by tool
//* SharpKit
//* At: 29/08/2012 03:59:40 p.m.
//***************************************************
using SharpKit.JavaScript;
namespace Ext.form.field
{
    #region Checkbox
    /// <inheritdocs />
    /// <summary>
    /// <p>Single checkbox field. Can be used as a direct replacement for traditional checkbox fields. Also serves as a
    /// parent class for <see cref="Ext.form.field.Radio">radio buttons</see>.</p>
    /// <h1>Labeling</h1>
    /// <p>In addition to the <see cref="Ext.form.Labelable">standard field labeling options</see>, checkboxes
    /// may be given an optional <see cref="Ext.form.field.CheckboxConfig.boxLabel">boxLabel</see> which will be displayed immediately after checkbox. Also see
    /// <see cref="Ext.form.CheckboxGroup">Ext.form.CheckboxGroup</see> for a convenient method of grouping related checkboxes.</p>
    /// <h1>Values</h1>
    /// <p>The main value of a checkbox is a boolean, indicating whether or not the checkbox is checked.
    /// The following values will check the checkbox:</p>
    /// <ul>
    /// <li><c>true</c></li>
    /// <li><c>'true'</c></li>
    /// <li><c>'1'</c></li>
    /// <li><c>'on'</c></li>
    /// </ul>
    /// <p>Any other value will uncheck the checkbox.</p>
    /// <p>In addition to the main boolean value, you may also specify a separate <see cref="Ext.form.field.CheckboxConfig.inputValue">inputValue</see>. This will be
    /// sent as the parameter value when the form is <see cref="Ext.form.Basic.submit">submitted</see>. You will want to set
    /// this value if you have multiple checkboxes with the same <see cref="Ext.form.field.CheckboxConfig.name">name</see>. If not specified, the value <c>on</c>
    /// will be used.</p>
    /// <h1>Example usage</h1>
    /// <pre><code><see cref="Ext.ExtContext.create">Ext.create</see>('<see cref="Ext.form.Panel">Ext.form.Panel</see>', {
    /// bodyPadding: 10,
    /// width: 300,
    /// title: 'Pizza Order',
    /// items: [
    /// {
    /// xtype: 'fieldcontainer',
    /// fieldLabel: 'Toppings',
    /// defaultType: 'checkboxfield',
    /// items: [
    /// {
    /// boxLabel  : 'Anchovies',
    /// name      : 'topping',
    /// inputValue: '1',
    /// id        : 'checkbox1'
    /// }, {
    /// boxLabel  : 'Artichoke Hearts',
    /// name      : 'topping',
    /// inputValue: '2',
    /// checked   : true,
    /// id        : 'checkbox2'
    /// }, {
    /// boxLabel  : 'Bacon',
    /// name      : 'topping',
    /// inputValue: '3',
    /// id        : 'checkbox3'
    /// }
    /// ]
    /// }
    /// ],
    /// bbar: [
    /// {
    /// text: 'Select Bacon',
    /// handler: function() {
    /// <see cref="Ext.ExtContext.getCmp">Ext.getCmp</see>('checkbox3').setValue(true);
    /// }
    /// },
    /// '-',
    /// {
    /// text: 'Select All',
    /// handler: function() {
    /// <see cref="Ext.ExtContext.getCmp">Ext.getCmp</see>('checkbox1').setValue(true);
    /// <see cref="Ext.ExtContext.getCmp">Ext.getCmp</see>('checkbox2').setValue(true);
    /// <see cref="Ext.ExtContext.getCmp">Ext.getCmp</see>('checkbox3').setValue(true);
    /// }
    /// },
    /// {
    /// text: 'Deselect All',
    /// handler: function() {
    /// <see cref="Ext.ExtContext.getCmp">Ext.getCmp</see>('checkbox1').setValue(false);
    /// <see cref="Ext.ExtContext.getCmp">Ext.getCmp</see>('checkbox2').setValue(false);
    /// <see cref="Ext.ExtContext.getCmp">Ext.getCmp</see>('checkbox3').setValue(false);
    /// }
    /// }
    /// ],
    /// renderTo: <see cref="Ext.ExtContext.getBody">Ext.getBody</see>()
    /// });
    /// </code></pre>
    /// </summary>
    [JsType(JsMode.Prototype, Export=false, OmitOptionalParameters=true)]
    public partial class Checkbox : Ext.form.field.Base
    {
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// after the box label text. If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object afterBoxLabelTextTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// after the box label element. If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object afterBoxLabelTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// before the box label text. If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object beforeBoxLabelTextTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// before the box label element. If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object beforeBoxLabelTpl;
        /// <summary>
        /// An optional text label that will appear next to the checkbox. Whether it appears before or after the checkbox is
        /// determined by the boxLabelAlign config.
        /// </summary>
        public JsString boxLabel;
        /// <summary>
        /// The position relative to the checkbox where the boxLabel should appear. Recognized values are 'before'
        /// and 'after'.
        /// Defaults to: <c>&quot;after&quot;</c>
        /// </summary>
        public JsString boxLabelAlign;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// inside the box label element (as attributes). If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object boxLabelAttrTpl;
        /// <summary>
        /// The CSS class to be applied to the boxLabel element
        /// Defaults to: <c>&quot;x-form-cb-label&quot;</c>
        /// </summary>
        public JsString boxLabelCls;
        /// <summary>
        /// true if the checkbox should render initially checked
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool @checked;
        /// <summary>
        /// The CSS class added to the component's main element when it is in the checked state.
        /// Defaults to: <c>&quot;x-form-cb-checked&quot;</c>
        /// </summary>
        public JsString checkedCls;
        /// <summary>
        /// A function called when the checked value changes (can be used instead of handling the change event).
        /// </summary>
        public System.Delegate handler;
        /// <summary>
        /// The value that should go into the generated input element's value attribute and should be used as the parameter
        /// value when submitting as part of a form.
        /// Defaults to: <c>&quot;on&quot;</c>
        /// </summary>
        public JsString inputValue;
        /// <summary>
        /// An object to use as the scope ('this' reference) of the handler function.
        /// Defaults to this Checkbox.
        /// </summary>
        public JsObject scope;
        /// <summary>
        /// If configured, this will be submitted as the checkbox's value during form submit if the checkbox is unchecked. By
        /// default this is undefined, which results in nothing being submitted for the checkbox field when the form is
        /// submitted (the default behavior of HTML checkboxes).
        /// </summary>
        public JsString uncheckedValue;
        /// <summary>
        /// A reference to the label element created for the boxLabel. Only present if the component has been
        /// rendered and has a boxLabel configured.
        /// </summary>
        public Ext.dom.Element boxLabelEl{get;set;}
        /// <summary>
        /// Handle click on the checkbox button
        /// </summary>
        /// <param name="e">
        /// </param>
        private void onBoxClick(object e){}
        public Checkbox(CheckboxConfig config){}
        public Checkbox(){}
        public Checkbox(params object[] args){}
    }
    #endregion
    #region CheckboxConfig
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CheckboxConfig : Ext.form.field.BaseConfig
    {
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// after the box label text. If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object afterBoxLabelTextTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// after the box label element. If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object afterBoxLabelTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// before the box label text. If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object beforeBoxLabelTextTpl;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// before the box label element. If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object beforeBoxLabelTpl;
        /// <summary>
        /// An optional text label that will appear next to the checkbox. Whether it appears before or after the checkbox is
        /// determined by the boxLabelAlign config.
        /// </summary>
        public JsString boxLabel;
        /// <summary>
        /// The position relative to the checkbox where the boxLabel should appear. Recognized values are 'before'
        /// and 'after'.
        /// Defaults to: <c>&quot;after&quot;</c>
        /// </summary>
        public JsString boxLabelAlign;
        /// <summary>
        /// An optional string or XTemplate configuration to insert in the field markup
        /// inside the box label element (as attributes). If an XTemplate is used, the component's
        /// subTpl data serves as the context.
        /// </summary>
        public object boxLabelAttrTpl;
        /// <summary>
        /// The CSS class to be applied to the boxLabel element
        /// Defaults to: <c>&quot;x-form-cb-label&quot;</c>
        /// </summary>
        public JsString boxLabelCls;
        /// <summary>
        /// true if the checkbox should render initially checked
        /// Defaults to: <c>false</c>
        /// </summary>
        public bool @checked;
        /// <summary>
        /// The CSS class added to the component's main element when it is in the checked state.
        /// Defaults to: <c>&quot;x-form-cb-checked&quot;</c>
        /// </summary>
        public JsString checkedCls;
        /// <summary>
        /// A function called when the checked value changes (can be used instead of handling the change event).
        /// </summary>
        public System.Delegate handler;
        /// <summary>
        /// The value that should go into the generated input element's value attribute and should be used as the parameter
        /// value when submitting as part of a form.
        /// Defaults to: <c>&quot;on&quot;</c>
        /// </summary>
        public JsString inputValue;
        /// <summary>
        /// An object to use as the scope ('this' reference) of the handler function.
        /// Defaults to this Checkbox.
        /// </summary>
        public JsObject scope;
        /// <summary>
        /// If configured, this will be submitted as the checkbox's value during form submit if the checkbox is unchecked. By
        /// default this is undefined, which results in nothing being submitted for the checkbox field when the form is
        /// submitted (the default behavior of HTML checkboxes).
        /// </summary>
        public JsString uncheckedValue;
        public CheckboxConfig(params object[] args){}
    }
    #endregion
    #region CheckboxEvents
    /// <inheritdocs />
    [JsType(JsMode.Json, Export=false, OmitOptionalParameters=true)]
    public partial class CheckboxEvents : Ext.form.field.BaseEvents
    {
        public CheckboxEvents(params object[] args){}
    }
    #endregion
}