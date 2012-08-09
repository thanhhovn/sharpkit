﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpKit.JavaScript;
using SharpKit.KendoUI.Web;
using SharpKit.Html4;


namespace SharpKit.jQuery
{
    [JsType(JsMode.Prototype, Export = false)]
    public static partial class KendoUIWebExtensions
    {

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoAutoComplete(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoAutoComplete(this jQuery query, AutoCompleteConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoCalendar(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoCalendar(this jQuery query, ComboBoxConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoComboBox(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoComboBox(this jQuery query, CalendarConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDatePicker(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDatePicker(this jQuery query, DatePickerConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDateTimePicker(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDateTimePicker(this jQuery query, DateTimePickerConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDropDownList(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoDropDownList(this jQuery query, DropDownListConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoEditor(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoEditor(this jQuery query, EditorConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoGrid(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoGrid(this jQuery query, GridConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoListView(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoListView(this jQuery query, ListViewConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoMenu(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoMenu(this jQuery query, MenuConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoNumericTextBox(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoNumericTextBox(this jQuery query, NumericTextBoxConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoPager(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoPager(this jQuery query, PagerConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoPanelBar(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoPanelBar(this jQuery query, PanelBarConfiguration configuration) { return null; }


        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoRangeSlider(this jQuery query) { return null; }

        [JsMethod(ExtensionImplementedInInstance = true)]
        public static jQuery kendoRangeSlider(this jQuery query, RangeSliderConfiguration configuration) { return null; }
    }

}

namespace SharpKit.KendoUI.Web
{

    public class AutoComplete
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        ///autocomplete.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var autocomplete = $("#autocomplete").data("kendoAutoComplete");
        /// // get the dataItem corresponding to the passed index.
        ///var dataItem = autocomplete.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enable/Disable the autocomplete widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI AutoComplete
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // re-render the items in drop-down list.
        ///autocomplete.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Filters dataSource using the provided parameter and rebinds drop-down list.
        /// </summary>
        /// <param name="word">The filter value.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // Searches for item which has "Inception" in the name.
        ///autocomplete.search("Inception");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the text of the autocomplete.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // selects by jQuery object
        ///autocomplete.select(autocomplete.ul.children().eq(0));
        ///</code>
        ///</example>
        public void select(jQuery.jQuery li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"
        /// <summary>
        /// Selects drop-down list item and sets the text of the autocomplete.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // selects by jQuery object
        ///autocomplete.select(autocomplete.ul.children().eq(0));
        ///</code>
        ///</example>
        public void select(object li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"

        /// <summary>
        /// Forces a suggestion onto the text of the AutoComplete.
        /// </summary>
        /// <param name="value">Characters to force a suggestion.</param>
        ///<example>
        ///usage
        ///<code>
        /// // note that this suggest is not the same as the configuration method
        /// // suggest which enables/disables auto suggesting for the AutoComplete
        /// //
        /// // get a referenence to the Kendo UI AutoComplete
        ///var autoComplete = $("#autoComplete").data("kendoAutoComplete");
        /// // force a suggestion to the item with the name "Inception"
        ///autoComplete.suggest("Inception");
        ///</code>
        ///</example>
        public void suggest(JsString value) { }

        /// <summary>
        /// Gets/Sets the value of the autocomplete.
        /// </summary>
        /// <param name="value">The value to set.</param>
        /// <returns>The value of the autocomplete.</returns>
        public JsString value(JsString value) { return null; }

        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var autoComplete = $("#autoComplete").data("kendoAutoComplete");
        ///$("#autoComplete").data("kendoAutoComplete").bind("change", function(e) {
        ///    // handle event
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    open: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> open { add { } remove { } }


        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        ///var onSelect = function(e) {
        ///    // access the selected item via e.item (jQuery object)
        ///};
        ///
        /// // attach select event handler during initialization
        ///var autocomplete = $("#autocomplete").kendoAutoComplete({
        ///    select: onSelect
        ///});
        ///
        /// // detach select event handler via unbind()
        ///autocomplete.data("kendoAutoComplete").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<SelectEventData> selectEvent { add { } remove { } }
        //TODO: event name is select

    }

    public class AutoCompleteConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn of the animation.
        /// </summary>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// The set of data that the AutoComplete will be bound to. Either a local JavaScript object, or an instance of the Kendo UI DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }
        /// <summary>
        /// The set of data that the AutoComplete will be bound to. Either a local JavaScript object, or an instance of the Kendo UI DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: null) Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { ID: 1, Name: "Item 1" }, { ID: 2, Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({
        ///    dataSource: items,
        ///    dataTextField: "Name"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        ///(default: 200) Specifies the delay in ms after which the AutoComplete will start filtering the dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the delay to 500 milliseconds
        ///$("#autoComplete").kendoAutoComplete({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the AutoComplete should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // disable the autocomplete when it is created (enabled by default)
        ///$("#autoComplete").kendoAutoComplete({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: "startswith") Defines the type of filtration. This value is handled by the remote data source.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // send a filter value of 'contains' to the server
        ///$("#autoComplete").kendoAutoComplete({
        ///    filter: 'contains'
        ///});
        ///</code>
        ///</example>
        public JsString filter { get; set; }

        /// <summary>
        /// (default: 200) Sets the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the height of the drop-down list that appears when the autocomplete is activated to 500px
        ///$("#autoComplete").kendoAutoComplete({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Controls whether the first item will be automatically highlighted.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autocomplete").kendoAutoComplete({
        ///    highlightFirst: false //no of the suggested items will be highlighted
        ///});
        ///</code>
        ///</example>
        public bool highlightFirst { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#autoComplete").kendoAutoComplete({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public JsString ignoreCase { get; set; }
        //TODO: seems like they have a mistake. if default: true should it be boolean?

        /// <summary>
        /// (default: 1) Specifies the minimum number of characters that should be typed before the AutoComplete queries the dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // wait until the user types 3 characters before querying the server
        ///$("#autoComplete").kendoAutoComplete({
        ///    minLength: 3
        ///});
        ///</code>
        ///</example>
        public JsNumber minLength { get; set; }

        /// <summary>
        /// (default: "")A string that appears in the textbox when it has no value.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //autocomplete initialization
        ///&lt;script>
        ///    $("#autocomplete").kendoAutoComplete({
        ///        dataSource: dataSource,
        ///        placeholder: "Enter value..."
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString placeholder { get; set; }

        /// <summary>
        /// (default: "")Sets the separator for completion. Empty by default, allowing for only one completion.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set completion separator to ,
        ///$("#autoComplete").kendoAutoComplete({
        ///    separator: ", "
        ///});
        ///</code>
        ///</example> 
        public JsString separator { get; set; }

        /// <summary>
        /// (default: false)Controls whether the AutoComplete should automatically auto-type the rest of text.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // turn on auto-typing (off by default)
        ///$("#autoComplete").kendoAutoComplete({
        ///    suggest: true
        ///});
        ///</code>
        ///</example>
        public bool suggest { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        /// //autocomplete initialization
        /// &lt;script>
        ///     $("#autocomplete").kendoAutoComplete({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         template: kendo.template($("#template").html())
        ///     });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

    }

    public class EmptyEventData
    {
    }

    public class SelectEventData
    {
        /// <summary>
        /// The selected item chosen by a user.
        /// </summary>
        public jQuery.jQuery item { get; set; }
    }

    public class Calendar
    {
        /// <summary>
        /// Sets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the calendar.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Navigates to view
        /// </summary>
        /// <param name="value">Desired date</param>
        /// <param name="view">Desired view</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to the desired date
        ///calendar.navigate(value, view);
        ///</code>
        ///</example>
        public void navigate(JsDate value, JsString view) { }

        /// <summary>
        /// Navigates to the lower view
        /// </summary>
        /// <param name="value">Desired date</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate down
        ///calendar.navigateDown(value);
        ///</code>
        ///</example>
        public void navigateDown(JsDate value) { }

        /// <summary>
        /// Navigates to the future
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to future
        ///calendar.navigateToFuture();
        ///</code>
        ///</example>
        public void navigateToFuture() { }

        /// <summary>
        /// Navigates to the past
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate to past
        ///calendar.navigateToPast();
        ///</code>
        ///</example>
        public void navigateToPast() { }

        /// <summary>
        /// Navigates to the upper view
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // navigate up
        ///calendar.navigateUp();
        ///</code>
        ///</example>
        public void navigateUp() { }

        /// <summary>
        /// Sets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void value(JsDate value) { }

        /// <summary>
        /// Sets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the calendar.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the value of the calendar.
        ///var value = calendar.value();
        /// // set the value of the calendar.
        ///calendar.value(new Date());
        ///</code>
        ///</example>
        public JsDate value() { return null; }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the Kendo UI calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // bind to the change event
        ///calendar.bind("change", function(e) {
        ///     // handle event
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when navigate
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    navigate: function(e) {
        ///         // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> navigateEvent { add { } remove { } }
        //TODO: event name is navigate
    }

    public class CalendarConfiguration
    {

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies a list of dates, which will be passed to the month template.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    dates: [new Date(2000, 10, 10, 10, 0, 0), new Date(2000, 10, 10, 30, 0)] //can manipulate month template depending on this array.
        ///});
        ///</code>
        ///</example>
        public JsArray dates { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    depth: "year"
        ///});
        ///</code>
        ///</example>
        public JsString depth { get; set; }

        /// <summary>
        /// Can be boolean or string. Specifies the content of the footer. If false, the footer will not be rendered.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // change the footer text from the default current date
        ///$("#calendar").kendoCalendar({
        ///    footer = "My Custom Footer"
        ///});
        ///</code>
        ///</example>
        public object footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public MonthConfiguration month { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    start: "year"
        ///});
        ///</code>
        ///</example>\
        public StartDepthOptions start { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected date to Jan 1st. 2012
        ///$("#calendar").kendoCalendar({
        ///    value: new Date(2012, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }
    }

    public class MonthConfiguration
    {
        /// <summary>
        /// Template to be used for rendering the cells in the "month" view, which are in range.
        /// </summary>
        public JsString content { get; set; }

        /// <summary>
        /// Template to be used for rendering the cells in the "month" view, which are not in the min/max range.
        /// </summary>
        public JsString empty { get; set; }
    }

    public class ComboBox
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index. If the index is not specified, the selected index will be used.
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the dataItem corresponding to the selectedIndex.
        /// var dataItem = combobox.dataItem();
        /// // get the dataItem corresponding to the passed index.
        /// var dataItem = combobox.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enables/disables the combobox widget
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Opens the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI ComboBox
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // re-render the items of the drop-down list.
        ///combobox.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Filters dataSource using the provided parameter and rebinds drop-down list.
        /// </summary>
        /// <param name="word">The filter value.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // Searches for item which has "In" in the name.
        /// combobox.search("In");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the combobox.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public void select(jQuery.jQuery li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the combobox.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public void select(object li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"\
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the combobox.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public void select(JsAction li, jQuery.jQuery item) { }
        //TODO: "item" was writen "e.item"

        /// <summary>
        /// Forces a suggestion onto the text of the ComboBox.
        /// </summary>
        /// <param name="value">Characters to force a suggestion.</param>
        ///<example>
        ///usage
        ///<code>
        /// // note that this suggest is not the same as the configuration method
        /// // suggest which enables/disables auto suggesting for the ComboBox
        /// //
        /// // get a referenence to the Kendo UI ComboBox
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // force a suggestion to the item with the name "Inception"
        /// combobox.suggest("Inception");
        ///</code>
        ///</example>
        public void suggest(JsString value) { }

        /// <summary>
        /// Sets the text of the ComboBox.
        /// </summary>
        /// <param name="text">The text to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public void text(JsString text) { }

        /// <summary>
        /// Gets the text of the ComboBox.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public JsString text() { return null; }

        /// <summary>
        /// Toggles the drop-down list between opened and closed state.
        /// </summary>
        /// <param name="toggle">Defines the whether to open/close the drop-down list.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // toggles the open state of the drop-down list.
        /// combobox.toggle();
        ///</code>
        ///</example>
        public void toggle(bool toggle) { }

        /// <summary>
        /// Sets the value of the combobox. If the value is undefined, text of the data item will be used.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the combobox. If the value is undefined, text of the data item will be used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }


        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> openEvent { add { } remove { } }
        //TODO: event name is open

        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<SelectEventData> selectEvent { add { } remove { } }
        //TODO: event name is select

    }

    public class ComboBoxConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// Controls whether to bind the widget to the DataSource on initialization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    autoBind: false
        ///});
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// Use it to set the Id of the parent DropDownList.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist1").kendoDropDownList();
        ///$("#dropdownlist2").kendoDropDownList({
        ///    cascadeFrom: "dropdownlist1"
        ///});
        ///</code>
        ///</example>
        public JsString cascadeFrom { get; set; }

        /// <summary>
        /// A local JavaScript object or instance of DataSource or the data that the ComboBox will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }

        /// <summary>
        /// A local JavaScript object or instance of DataSource or the data that the ComboBox will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the value content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataValueField { get; set; }

        /// <summary>
        /// (default: 200) Specifies the delay in ms after which the ComboBox will start filtering dataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the ComboBox should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: "none") Defines the type of filtration. If "none" the ComboBox will not filter the items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    filter: "startswith"
        ///});
        ///</code>
        ///</example>
        public JsString filter { get; set; }

        /// <summary>
        /// (default: 200) Define the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Controls whether the first item will be automatically highlighted.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    highLightFirst: true
        ///});
        ///</code>
        ///</example>   
        public bool highlightFirst { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public JsString ignoreCase { get; set; }

        /// <summary>
        /// (default: -1) Defines the initial selected item.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataSource: items,
        ///    index: 1 // 0 based from the start of the collection of objects. this selects "Item 2".
        ///});
        ///</code>
        ///</example>
        public JsNumber index { get; set; }

        /// <summary>
        /// (default: 1) Specifies the minimum characters that should be typed before the ComboBox activates
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    minLength: 3
        ///});
        ///</code>
        ///</example>
        public JsNumber minLength { get; set; }

        /// <summary>
        /// (default: "") A string that appears in the textbox when the combobox has no value.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///    $("#combobox").kendoComboBox({
        ///        dataSource: dataSource,
        ///        placeholder: "Select..."
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public JsString placeholder { get; set; }

        /// <summary>
        /// (default: false) Controls whether the ComboBox should automatically auto-type the rest of text.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    suggest: false
        ///});
        ///</code>
        ///</example>
        public bool suggest { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        ///
        /// //combobox initialization
        /// &lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         dataValueField: "Id",
        ///         template: kendo.template($("#template").html())
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// (default: "") Define the text of the widget, when the autoBind is set to false.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     autoBind: false,
        ///     text: "Chai"
        ///});
        ///</code>
        ///</example>
        public JsString text { get; set; }

        /// <summary>
        /// (default: "") Define the value of the widget
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     dataSource: ["Item1", "Item2"],
        ///     value: "Item1"
        ///});
        ///</code>
        ///</example>
        public JsString value { get; set; }
    }

    public class AnimationConfiguration
    {
        /// <summary>
        /// Animation to be used for closing of the popup
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///    $("#combobox").kendoComboBox({
        ///        dataSource: dataSource,
        ///        animation: {
        ///           close: {
        ///               effects: "fadeOut",
        ///               duration: 300,
        ///               hide: true
        ///               show: false
        ///           }
        ///        }
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public object close { get; set; }

        /// <summary>
        /// Animation to be used for opening of the popup.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         animation: {
        ///            open: {
        ///                effects: "fadeIn",
        ///                duration: 300,
        ///                show: true
        ///            }
        ///         }
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public object open { get; set; }

    }

    public class DatePicker
    {
        /// <summary>
        /// Closes the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        ///autocomplete.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Enable/Disable the datePicker widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Sets the max value of the datePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the datePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the datePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the datePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the datePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the datePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Opens the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Sets the value of the datePicker.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the datePicker.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }

        /// <summary>
        /// Fires when the selected date is changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the calendar is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the calendar is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<ViewOptions> openEvent { add { } remove { } }
        //TODO: event name is open
    }

    public class DatePickerConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade",
        ///    depth: "year" // the datePicker will only go to the year level
        ///});
        ///</code>
        ///</example>
        public StartDepthOptions depth { get; set; }

        /// <summary>
        /// Template to be used for rendering the footer of the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // DatePicker initialization
        /// &lt;script>
        ///     $("#datePicker").kendoDatePicker({
        ///         footer: "Today - #=kendo.toString(data, 'd') #"
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public MonthConfiguration month { get; set; }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with value() method or by direct input.
        /// If not set the value of the format will be used. Note that value of the format option is always used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    format: "yyyy/MM/dd",
        ///    parseFormats: ["MMMM yyyy"] //format also will be added to parseFormats
        ///});
        ///</code>
        ///</example>
        public JsArray parseFormats { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade" // the datePicker will start with a decade display
        ///});
        ///</code>
        ///</example> 
        public StartDepthOptions start { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected value to January 1st, 2011
        ///$("#datePicker").kendoDatePicker({
        /// value: new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }


    }

    public enum StartDepthOptions
    {
        /// <summary>
        /// shows the days of the month
        /// </summary>
        month,
        /// <summary>
        /// shows the months of the year
        /// </summary>
        year,
        /// <summary>
        /// shows the years of the decade
        /// </summary>
        decade,
        /// <summary>
        /// shows the decades from the centery
        /// </summary>
        century,
    }

    public class DateTimePicker
    {

        /// <summary>
        /// Closes the calendar or the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Closes the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date".</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").close("date");
        ///</code>
        ///</example>
        public void close(ViewOptions view) { }

        /// <summary>
        /// Enables or disables a DateTimePicker.
        /// </summary>
        /// <param name="enable">Enables (true or undefined) or disables (false) a DateTimePicker.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the autocomplete widget
        ///var autocomplete = $("autocomplete").data("kendoAutoComplete");
        /// // disables the autocomplete
        ///autocomplete.enable(false);
        /// // enables the autocomplete
        ///autocomplete.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Sets the max value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsDate value) { }

        /// <summary>
        /// Sets the max value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }

        /// <summary>
        /// Gets the max value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The max date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsDate max() { return null; }

        /// <summary>
        /// Sets the min value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///calendar.min(new Date(1900, 0, 1));
        ///</code>
        ///</example>
        public void min(JsDate value) { }

        /// <summary>
        /// Sets the min value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }

        /// <summary>
        /// Gets the min value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The min  date to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsDate min() { return null; }

        /// <summary>
        /// Opens the calendar or the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("dateTimePicker").data("kendoDateTimePicker").open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Opens the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date"</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").open("date");
        ///</code>
        ///</example>
        public void open(ViewOptions view) { }

        /// <summary>
        /// Toggles the calendar or the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").toggle("date");
        ///</code>
        ///</example>
        public void toggle() { }

        /// <summary>
        /// Toggles the calendar or the time drop-down list.
        /// </summary>
        /// <param name="view">The view of the DateTimePicker, expressed as a string. Available views are "time" and "date".</param>
        ///<example>
        ///usage
        ///<code>
        ///$("dateTimePicker").data("kendoDateTimePicker").toggle("date");
        ///</code>
        ///</example>
        public void toggle(ViewOptions view) { }

        /// <summary>
        /// Sets the value of the DateTimePicker.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }

        /// <summary>
        /// Gets the value of the DateTimePicker.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }

        /// <summary>
        /// Triggered when the underlying value of a DateTimePicker is changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the calendar or the time drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the calendar or the time drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<ViewOptions> openEvent { add { } remove { } }
        //TODO: event name is open
    }

    public class DateTimePickerConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: en-US) Specifies the culture info used by the widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// Specifies a list of dates, which are shown in the time drop-down list. If not set, the DateTimePicker will auto-generate the available times.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    dates: [new Date(2000, 10, 10, 10, 0, 0), new Date(2000, 10, 10, 30, 0)] //the drop-down list will consist only two entries - "10:00 AM" and "10:30 AM"
        ///});
        ///</code>
        ///</example>
        public JsArray dates { get; set; }

        /// <summary>
        /// Specifies the navigation depth.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade",
        ///    depth: "year" // the datePicker will only go to the year level
        ///});
        ///</code>
        ///</example>
        public StartDepthOptions depth { get; set; }

        /// <summary>
        /// Template to be used for rendering the footer of the calendar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // DatePicker initialization
        /// &lt;script>
        ///     $("#datePicker").kendoDatePicker({
        ///         footer: "Today - #=kendo.toString(data, 'd') #"
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString footer { get; set; }

        /// <summary>
        /// (default: MM/dd/yyyy) Specifies the format, which is used to parse value set with value() method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    format: "yyyy/MM/dd"
        ///});
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: 30) Specifies the interval, between values in the popup list, in minutes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    interval: 15
        ///});
        ///</code>
        ///</example>
        public JsNumber interval { get; set; }

        /// <summary>
        /// (default: Date(2099, 11, 31)) Specifies the maximum date, which the calendar can show.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#calendar").kendoCalendar({
        ///    max = new Date(2013, 0, 1);
        ///});
        ///</code>
        ///</example>
        public JsDate max { get; set; }

        /// <summary>
        /// (default: Date(1900, 0, 1)) Specifies the minimum date, which the calendar can show.
        ///<example>
        ///usage
        ///<code>
        /// // set the min date to Jan 1st, 2011
        ///$("#calendar").kendoCalendar({
        ///    min = new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate min { get; set; }

        /// <summary>
        /// Templates for the cells rendered in the "month" view.
        /// </summary>
        public MonthConfiguration month { get; set; }

        /// <summary>
        /// Specifies the formats, which are used to parse the value set with value() method or by direct input.
        /// If not set the value of the format will be used. Note that value of the format option is always used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    format: "yyyy/MM/dd",
        ///    parseFormats: ["MMMM yyyy"] //format also will be added to parseFormats
        ///});
        ///</code>
        ///</example>
        public JsArray parseFormats { get; set; }

        /// <summary>
        /// (default: month) Specifies the start view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#datePicker").kendoDatePicker({
        ///    start: "decade" // the datePicker will start with a decade display
        ///});
        ///</code>
        ///</example> 
        public StartDepthOptions start { get; set; }

        /// <summary>
        /// (default: h:mm tt) Specifies the format, which is used to format the values in the time drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dateTimePicker").kendoDateTimePicker({
        ///    timeFormat: "HH:mm" //24 hours format
        ///});
        ///</code>
        ///</example>
        public JsString timeFormat { get; set; }

        /// <summary>
        /// (default: null) Specifies the selected date.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // set the selected value to January 1st, 2011
        ///$("#datePicker").kendoDatePicker({
        /// value: new Date(2011, 0, 1)
        ///});
        ///</code>
        ///</example>
        public JsDate value { get; set; }

    }

    public class OpenEventData
    {
        public ViewOptions view { get; set; }
    }

    public enum ViewOptions
    {
        date,
        time,
    }

    public class DropDownList
    {
        /// <summary>
        /// Closes the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.close();
        ///</code>
        ///</example>
        public void close() { }

        /// <summary>
        /// Returns the raw data record at the specified index. If the index is not specified, the selected index will be used.
        /// </summary>
        /// <param name="index">The zero-based index of the data record</param>
        /// <returns>Object The raw data record. Returns undefined if no data.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the dataItem corresponding to the selectedIndex.
        /// var dataItem = combobox.dataItem();
        /// // get the dataItem corresponding to the passed index.
        /// var dataItem = combobox.dataItem(1);
        ///</code>
        ///</example>
        public object dataItem(JsNumber index) { return null; }

        /// <summary>
        /// Enables/disables the dropdownlist widget
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Opens the drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        ///combobox.open();
        ///</code>
        ///</example>
        public void open() { }

        /// <summary>
        /// Re-render the items in drop-down list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a referenence to the Kendo UI ComboBox
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // re-render the items of the drop-down list.
        ///combobox.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Selects item, which starts with the provided parameter.
        /// </summary>
        /// <param name="word">The search value.</param>
        ///<example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // Searches for item which has "In" in the name.
        /// combobox.search("In");
        ///</code>
        ///</example>
        public void search(JsString word) { }

        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(jQuery.jQuery li, jQuery.jQuery item) { return null; }
        //TODO: "item" was writen "e.item"
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(JsNumber li, jQuery.jQuery item) { return null; }
        //TODO: "item" was writen "e.item"\
        /// <summary>
        /// Selects drop-down list item and sets the value and the text of the dropdownlist.
        /// </summary>
        /// <param name="li">The LI element.</param>
        /// <param name="item">The selected item chosen by a user.</param>
        /// <returns>The index of the selected LI element.</returns>
        /// <example>
        ///usage
        ///<code>
        /// var combobox = $("#combobox").data("kendoComboBox");
        /// // selects by jQuery object
        /// combobox.select(combobox.ul.children().eq(0));
        /// // selects by index
        /// combobox.select(1);
        /// // selects item if its text is equal to "test" using predicate function
        /// combobox.select(function(dataItem) {
        ///     return dataItem.text === "test";
        /// });
        ///</code>
        ///</example>
        public JsNumber select(JsAction li, jQuery.jQuery item) { return null; }
        //TODO: "item" was writen "e.item"

        /// <summary>
        /// Sets the text of the dropdownlist.
        /// </summary>
        /// <param name="text">The text to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public void text(JsString text) { }
        /// <summary>
        /// Gets the text of the dropdownlist.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the text of the combobox.
        /// var text = combobox.text();
        ///</code>
        ///</example>
        public JsString text() { return null; }

        /// <summary>
        /// Toggles the drop-down list between opened and closed state.
        /// </summary>
        /// <param name="toggle">Defines the whether to open/close the drop-down list.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // toggles the open state of the drop-down list.
        /// combobox.toggle();
        ///</code>
        ///</example>
        public void toggle(bool toggle) { }

        /// <summary>
        /// Sets the value of the dropdownlist. The value will not be set if there is no item with such value. If value is undefined, text of the data item is used.
        /// </summary>
        /// <param name="value">The value to set.</param>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public void value(JsString value) { }
        /// <summary>
        /// Gets the value of the dropdownlist. The value will not be set if there is no item with such value. If value is undefined, text of the data item is used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var combobox = $("#combobox").data("kendoComboBox");
        /// // get the value of the combobox.
        /// var value = combobox.value();
        /// // set the value of the combobox.
        /// combobox.value("1"); //looks for item which has value "1"
        ///</code>
        ///</example>
        public JsString value() { return null; }


        /// <summary>
        /// Fires when the value has been changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the drop-down list is closed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires when the drop-down list is opened
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> openEvent { add { } remove { } }
        //TODO: event name is open

        /// <summary>
        /// Triggered when a Li element is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<SelectEventData> selectEvent { add { } remove { } }
        //TODO: event name is select

    }

    public class DropDownListConfiguration
    {
        /// <summary>
        /// Animations to be used for opening/closing the popup. Setting to false will turn off the animation.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    animation: false
        ///});
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: true) Controls whether to bind the widget on initialization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    autoBind: false
        ///});
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// Use it to set the Id of the parent DropDownList.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist1").kendoDropDownList();
        ///$("#dropdownlist2").kendoDropDownList({
        ///    cascadeFrom: "dropdownlist1"
        ///});
        ///</code>
        ///</example>
        public JsString cascadeFrom { get; set; }

        /// <summary>
        /// Instance of DataSource or the data that the DropDownList will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }

        /// <summary>
        /// Instance of DataSource or the data that the DropDownList will be bound to.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "text",
        ///    dataValueField: "value",
        ///    dataSource: items
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the text content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataTextField { get; set; }

        /// <summary>
        /// (default: "") Sets the field of the data item that provides the value content of the list items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    dataTextField: "Name",
        ///    dataValueField: "ID"
        ///});
        ///</code>
        ///</example>
        public JsString dataValueField { get; set; }

        /// <summary>
        /// (default: 500) Specifies the delay in ms before the search text typed by the end user is cleared.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    delay: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber delay { get; set; }

        /// <summary>
        /// (default: true) Controls whether the DropDownList  should be initially enabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    enable: false
        ///});
        ///</code>
        ///</example>
        public bool enable { get; set; }

        /// <summary>
        /// (default: 200) Define the height of the drop-down list in pixels.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    height: 500
        ///});
        ///</code>
        ///</example>
        public JsNumber height { get; set; }

        /// <summary>
        /// (default: true) Defines whether the filtration should be case sensitive.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///    filter: 'contains',
        ///    ignoreCase: false //now filtration will be case sensitive
        ///});
        ///</code>
        ///</example>
        public JsString ignoreCase { get; set; }
        //todo: if (default: true) why string and not boolean?

        /// <summary>
        /// (default: 0) Defines the initial selected item.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [{ text: "Item 1", value: "1" }, { text: "Item 2", value: "2" }];
        ///$("#comboBox").kendoComboBox({
        ///    dataSource: items,
        ///    index: 1 // 0 based from the start of the collection of objects. this selects "Item 2".
        ///});
        ///</code>
        ///</example>
        public JsNumber index { get; set; }

        /// <summary>
        /// Define the text of the default empty item. If the value is an object, then the widget will use it directly.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist").kendoDropDownList({
        ///    optionLabel: "Select An Option"
        ///});
        ///</code>
        ///</example>
        public object optionLabel { get; set; }

        /// <summary>
        /// Define the text of the default empty item. If the value is an object, then the widget will use it directly.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#dropdownlist").kendoDropDownList({
        ///    optionLabel: "Select An Option"
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "optionLabel")]
        public JsString optionLabelString { get; set; }

        /// <summary>
        /// Template to be used for rendering the items in the list.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        ///&lt;script id="template" type="text/x-kendo-tmpl">
        ///      # if (data.BoxArt.SmallUrl) { #
        ///          &lt;img src="${ data.BoxArt.SmallUrl }" alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } else { #
        ///          &lt;img alt="${ data.Name }" />Title:${ data.Name }, Year: ${ data.Name }
        ///      # } #
        /// &lt;/script>
        ///
        /// //combobox initialization
        /// &lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         dataTextField: "Name",
        ///         dataValueField: "Id",
        ///         template: kendo.template($("#template").html())
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// (default: "") Define the text of the widget, when the autoBind is set to false.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     autoBind: false,
        ///     text: "Chai"
        ///});
        ///</code>
        ///</example>
        public JsString text { get; set; }

        /// <summary>
        /// (default: "") Define the value of the widget
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#combobox").kendoComboBox({
        ///     dataSource: ["Item1", "Item2"],
        ///     value: "Item1"
        ///});
        ///</code>
        ///</example>
        public JsString value { get; set; }
    }

    public class Editor
    {
        /// <summary>
        /// Creates a W3C-compatible Range object.
        /// </summary>
        /// <param name="document">The document that the range is associated with. If ommited, the document of the editor editing area will be used.</param>
        /// <returns>Range. The created Range object.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///var range = editor.createRange();
        ///</code>
        ///</example>
        public HtmlTextRange createRange(HtmlDocument document) { return null; }

        /// <summary>
        /// Gets the HTML encoded value of the editor.
        /// </summary>
        /// <returns></returns>
        public JsString encodedValue() { return null; }

        /// <summary>
        /// Executes an editor command on the currently selected text.
        /// </summary>
        /// <param name="name">The name of the command to be executed.</param>
        /// <param name="params">The parameters for the executed command.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///editor.exec("bold");
        ///editor.exec("undo");
        ///editor.exec("foreColor", { value: "#ff0000" });
        ///</code>
        ///</example>
        public void exec(JsString name, JsString @params) { }
        //TODO: params optinal?

        /// <summary>
        /// Focuses the editable area.
        /// </summary>
        public void focus() { }

        /// <summary>
        /// Gets a Range object form the editable area.
        /// </summary>
        /// <returns>Range A W3C-compatible Range object that represents the currently selected text in the editor area.</returns>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///var range = editor.getRange();
        ///</code>
        ///</example>
        public object getRange() { return null; }
        //TODO: return type?

        /// <summary>
        /// Gets a W3C-compatible Selection object form the editable area.
        /// </summary>
        /// <returns></returns>
        public object getSelection() { return null; }
        //TODO: return type?

        /// <summary>
        /// Pastes HTML into the editable area.
        /// </summary>
        /// <param name="html">The HTML to be pasted.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor");
        ///editor.paste("<p>new content</p>");
        ///</code>
        ///</example>
        public void paste(JsString html) { }

        /// <summary>
        /// Serializes the currently selected text to a XHTML string.
        /// </summary>
        /// <returns>String The selectied text as valid XHTML.</returns>
        public JsString selectedHtml() { return null; }

        /// <summary>
        /// Focuses the editable area and selects the range described by the range parameter.
        /// </summary>
        /// <param name="range">The Range object that describes the new selection.</param>
        ///<example>
        ///usage
        ///<code>
        ///var editor = $("#editor").data("kendoEditor"),
        ///    range = editor.createRange();
        ///range.selectNodeContents(editor.body);
        ///editor.selectRange(range);
        ///</code>
        ///</example>
        public void selectRange(HtmlTextRange range) { }

        //TODO: update


    }

    public class EditorConfiguration
    {
        /// <summary>
        /// (default: true) Indicates whether the Editor should submit encoded HTML tags.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#editor").kendoEditor({
        ///    encoded: false
        ///});
        ///</code>
        ///</example>
        public bool encoded { get; set; }

        /// <summary>
        /// Allows custom stylesheets to be included within the editing area.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#editor").kendoEditor({
        ///     stylesheets: [
        ///         "common-styles.css",
        ///         "green-theme.css",
        ///     ]
        /// });
        ///</code>
        ///</example>
        public JsArray stylesheets { get; set; }

        /// <summary>
        /// A collection of tools that should render a button, combobox, etc, to interact with the Editor.
        /// Custom tools are defined as a collection of required properties, while the insertHtml tool requires a collection of text-value pairs
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#editor").kendoEditor({
        ///    tools: [
        ///        "bold",
        ///        "italic",
        ///        "underline",
        ///        "strikethrough",
        ///        "fontName",
        ///        "fontSize",
        ///        "foreColor",
        ///        "backColor",
        ///        "justifyLeft",
        ///        "justifyCenter",
        ///        "justifyRight",
        ///        "justifyFull",
        ///        "insertUnorderedList",
        ///        "insertOrderedList",
        ///        "indent",
        ///        "outdent",
        ///        "formatBlock",
        ///        "createLink",
        ///        "unlink",
        ///        "insertImage",
        ///        "insertHtml",
        ///        "viewHtml",
        ///        {
        ///            name: "customTool",
        ///            tooltip: "Custom Tool",
        ///            exec: function(e) {
        ///                var editor = $(this).data("kendoEditor");
        ///                // ...
        ///            }
        ///        }
        ///    ],
        ///    insertHtml: [
        ///        { text: "label 1", value: "<p>snippet 1</p>" },
        ///        { text: "label 2", value: "<p>snippet 2</p>" }
        ///    ]
        ///});
        ///</code>
        ///</example>
        public JsArray tools { get; set; }
    }

    public class Grid
    {
        /// <summary>
        /// Adds a new empty table row in edit mode. The addRow method triggers edit event.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.addRow();
        ///</code>
        ///</example>
        public void addRow() { }

        /// <summary>
        /// Cancels any pending changes during. Deleted rows are restored. Inserted rows are removed. Updated rows are restored to their original values.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.cancelChanges();
        ///</code>
        ///</example>
        public void cancelChanges() { }

        /// <summary>
        /// Switch the current edited row into display mode and revert changes made to the data
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.cancelRow();
        ///</code>
        ///</example>
        public void cancelRow() { }

        /// <summary>
        /// Returns the index of the cell in the grid item skipping group and hierarchy cells.
        /// </summary>
        /// <param name="cell">Target cell.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // get the index of the row
        /// // TODO: add specific function call here
        ///</code>
        ///</example>
        public JsNumber cellIndex(JsAction cell) { return null; }
        /// <summary>
        /// Returns the index of the cell in the grid item skipping group and hierarchy cells.
        /// </summary>
        /// <param name="cell">Target cell.</param>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // get the index of the row
        /// // TODO: add specific function call here
        ///</code>
        ///</example>
        public JsNumber cellIndex(HtmlElement cell) { return null; }

        /// <summary>
        /// Clears currently selected items.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        /// // clear the selection of items in the grid
        ///grid.clearSelection();
        ///</code>
        ///</example>
        public void clearSelection() { }

        /// <summary>
        /// Closes current edited cell.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        /// // close the cell being edited
        ///grid.closeCell();
        ///</code>
        ///</example>
        public void closeCell() { }

        /// <summary>
        /// Collapses specified group.
        /// </summary>
        /// <param name="group">Target group item to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first group item
        /// grid.collapseGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void collapseGroup(JsAction group) { }
        /// <summary>
        /// Collapses specified group.
        /// </summary>
        /// <param name="group">Target group item to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first group item
        /// grid.collapseGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void collapseGroup(HtmlElement group) { }

        /// <summary>
        /// Collapses specified master row.
        /// </summary>
        /// <param name="row ">Target master row to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first master row
        /// grid.collapseRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void collapseRow(JsAction row) { }
        /// <summary>
        /// Collapses specified master row.
        /// </summary>
        /// <param name="row ">Target master row to collapse.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // collapses first master row
        /// grid.collapseRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void collapseRow(HtmlElement row) { }

        /// <summary>
        /// Returns the data item to which a given table row (tr DOM element) is bound.
        /// </summary>
        /// <param name="tr  ">Target row.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // returns the data item for first row
        /// grid.dataItem(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public object dataItem(JsAction tr) { return null; }
        /// <summary>
        /// Returns the data item to which a given table row (tr DOM element) is bound.
        /// </summary>
        /// <param name="tr  ">Target row.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // returns the data item for first row
        /// grid.dataItem(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public object dataItem(HtmlElement tr) { return null; }

        /// <summary>
        /// Puts the specified table cell in edit mode. It requires a jQuery object representing the cell. The editCell method triggers edit event.
        /// </summary>
        /// <param name="cell">Cell to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        /// // edit first table cell
        ///grid.editCell(grid.tbody.find(">tr>td:first"));
        ///</code>
        ///</example>
        public void editCell(JsAction cell) { }

        /// <summary>
        /// Switches the specified row from the grid into edit mode. The editRow method triggers edit event.
        /// </summary>
        /// <param name="row ">Row to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // edit first table row
        /// grid.editRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void editRow(JsAction row) { }
        /// <summary>
        /// Switches the specified row from the grid into edit mode. The editRow method triggers edit event.
        /// </summary>
        /// <param name="row ">Row to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // edit first table row
        /// grid.editRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void editRow(HtmlElement row) { }

        /// <summary>
        /// Expands specified group.
        /// </summary>
        /// <param name="group">Target group item to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first group item
        /// grid.expandGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void expandGroup(JsAction group) { }
        /// <summary>
        /// Expands specified group.
        /// </summary>
        /// <param name="group">Target group item to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first group item
        /// grid.expandGroup(grid.tbody.find(">tr.k-grouping-row:first"));
        ///</code>
        ///</example>
        public void expandGroup(HtmlElement group) { }

        /// <summary>
        /// Expands specified master row.
        /// </summary>
        /// <param name="row ">Target master row to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first master row
        /// grid.expandRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void expandRow(JsAction row) { }
        /// <summary>
        /// Expands specified master row.
        /// </summary>
        /// <param name="row ">Target master row to expand.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // expands first master row
        /// grid.expandRow(grid.tbody.find(">tr.k-master-row:first"));
        ///</code>
        ///</example>
        public void expandRow(HtmlElement row) { }

        /// <summary>
        /// Redraws the grid using the current data of the DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // refreshes the grid
        /// grid.refresh();
        ///</code>
        ///</example>
        public void refresh() { }

        /// <summary>
        /// Removes the specified row from the grid. The removeRow method triggers remove event. (Note: In inline or popup edit modes the changes will be automatically synced)
        /// </summary>
        /// <param name="row ">Row to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // remove first table row
        /// grid.removeRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void removeRow(JsAction row) { }
        /// <summary>
        /// Removes the specified row from the grid. The removeRow method triggers remove event. (Note: In inline or popup edit modes the changes will be automatically synced)
        /// </summary>
        /// <param name="row ">Row to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // remove first table row
        /// grid.removeRow(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void removeRow(HtmlElement row) { }

        /// <summary>
        /// Calls DataSource sync to submit any pending changes if state is valid. The saveChanges method triggers saveChanges event.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.saveChanges();
        ///</code>
        ///</example>
        public void saveChanges() { }

        /// <summary>
        /// Switch the current edited row into dislay mode and save changes made to the data (Note: the changes will be automatically synced)
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        ///var grid = $("#grid").data("kendoGrid");
        ///grid.saveRow();
        ///</code>
        ///</example>
        public void saveRow() { }

        /// <summary>
        /// Selects the specified Grid rows/cells. If called without arguments - returns the selected rows/cells.
        /// </summary>
        /// <param name="items ">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // selects first grid item
        /// grid.select(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void select(JsAction items) { }
        /// <summary>
        /// Selects the specified Grid rows/cells. If called without arguments - returns the selected rows/cells.
        /// </summary>
        /// <param name="items ">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the grid widget
        /// var grid = $("#grid").data("kendoGrid");
        /// // selects first grid item
        /// grid.select(grid.tbody.find(">tr:first"));
        ///</code>
        ///</example>
        public void select(HtmlElement items) { }


        /// <summary>
        /// Fires when the grid selection has changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the grid has received data from the data source.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     dataBound: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> dataBound { add { } remove { } }

        /// <summary>
        /// Fires when the grid detail row is collapsed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///  $("#grid").kendoGrid({
        ///     detailCollapse: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridDetailCollapseEventData> detailCollapse { add { } remove { } }

        /// <summary>
        /// Fires when the grid detail row is expanded.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     detailExpand: function(e) {
        ///         // handle event
        ///     }
        /// });
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridDetailCollapseEventData> detailExpand { add { } remove { } }

        /// <summary>
        /// Fires when the grid detail is initialized.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     detailInit: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridDetailInitEventData> detailInit { add { } remove { } }

        /// <summary>
        /// Fires when the grid enters edit mode.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     edit: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridEditEventData> edit { add { } remove { } }

        /// <summary>
        /// Fires before the grid item is removed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     remove: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridRemoveEventData> remove { add { } remove { } }

        /// <summary>
        /// Fires before the grid item is changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     save: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<GridSaveEventData> save { add { } remove { } }

        /// <summary>
        /// Fires before the grid calls DataSource sync.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     saveChanges: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> saveChangesEvent { add { } remove { } }
        //TODO: event name is saveChanges
    }

    public class GridConfiguration
    {

        /// <summary>
        /// Indicates whether the grid will call read on the DataSource initially.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: sharedDataSource,
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     autoBind: false // the grid will not be populated with data until read() is called on the sharedDataSource
        /// });
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// A collection of column objects or collection of strings that represents the name of the fields.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var sharedDataSource = new kendo.data.DataSource({
        ///     data: [{title: "Star Wars: A New Hope", year: 1977}, {title: "Star Wars: The Empire Strikes Back", year: 1980}],
        ///     pageSize: 1
        ///});
        ///$("#grid").kendoGrid({
        ///    dataSource: sharedDataSource,
        ///    columns: [ { title: "Action", command: "destroy" }, // creates a column with delete buttons
        ///               { title: "Title", field: "title", width: 200, template: "<div id='title'>${ title }</div>" },
        ///               { title: "Year", field: "year", filterable: false, sortable: true, format: "{0:dd/MMMM/yyyy}" } ];
        ///});
        ///</code>
        ///</example>
        public GridColumnsConfiguration columns { get; set; }
        /// <summary>
        /// A collection of column objects or collection of strings that represents the name of the fields.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var sharedDataSource = new kendo.data.DataSource({
        ///     data: [{title: "Star Wars: A New Hope", year: 1977}, {title: "Star Wars: The Empire Strikes Back", year: 1980}],
        ///     pageSize: 1
        ///});
        ///$("#grid").kendoGrid({
        ///    dataSource: sharedDataSource,
        ///    columns: [ { title: "Action", command: "destroy" }, // creates a column with delete buttons
        ///               { title: "Title", field: "title", width: 200, template: "<div id='title'>${ title }</div>" },
        ///               { title: "Year", field: "year", filterable: false, sortable: true, format: "{0:dd/MMMM/yyyy}" } ];
        ///});
        ///</code>
        ///</example>
        [JsProperty(Name = "columns")]
        public JsArray columnsArray { get; set; }
        //TODO: not sure if needed

        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }
        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// Template to be used for rendering the detail rows in the grid. See the Detail Template example.
        /// </summary>
        public JsAction detailTemplate { get; set; }

        /// <summary>
        /// Indicates whether editing is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ]
        ///     toolbar: [
        ///         "create",
        ///         { name: "save", text: "Save This Record" },
        ///         { name: "cancel", template: "&lt;img src="icons/cancel.png' rel='cancel' />" }
        ///     ],
        ///     editable: {
        ///         update: true, // puts the row in edit mode when it is clicked
        ///         destroy: false, // does not remove the row when it is deleted, but marks it for deletion
        ///         confirmation: "Are you sure you want to remove this item?"
        ///     }
        /// });
        ///</code>
        ///</example>   
        public GridEditableConfiguration editable { get; set; }

        /// <summary>
        /// (default: false) Indicates whether grouping is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     groupable: true
        /// });
        ///</code>
        ///</example>
        public bool groupable { get; set; }

        /// <summary>
        /// (default: false) Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     navigatable: true
        /// });
        ///</code>
        ///</example>
        public bool navigatable { get; set; }

        /// <summary>
        /// (default: false) Indicates whether paging is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     pageable: true
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "pageable")]
        public bool pageableBoolean { get; set; }

        /// <summary>
        /// (default: false) Indicates whether paging is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     pageable: true
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "pageable")]
        public object pageableObject { get; set; }

        /// <summary>
        /// (default: false) Indicates whether paging is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     pageable: true
        /// });
        ///</code>
        ///</example>
        public GridPageableConfiguration pageable { get; set; }

        /// <summary>
        /// Template to be used for rendering the rows in the grid.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //template
        /// &lt;script id="rowTemplate" type="text/x-kendo-tmpl">
        ///     &lt;tr>
        ///         &lt;td>
        ///             &lt;img src="${ BoxArt.SmallUrl }" alt="${ Name }" />
        ///         &lt;/td>
        ///         &lt;td>
        ///             ${ Name }
        ///         &lt;/td>
        ///         &lt;td>
        ///             ${ AverageRating }
        ///         &lt;/td>
        ///     &lt;/tr>
        /// &lt;/script>
        ///
        /// //grid intialization
        /// &lt;script>PO details informaiton
        ///     $("#grid").kendoGrid({
        ///         dataSource: dataSource,
        ///         rowTemplate: kendo.template($("#rowTemplate").html()),
        ///         height: 200
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public JsAction rowTemplate { get; set; }

        /// <summary>
        /// (default: true) Enable/disable grid scrolling. Possible values:
        /// true
        ///Enables grid vertical scrolling
        ///false
        ///Disables grid vertical scrolling
        ///{ virtual: false }
        ///Enables grid vertical scrolling without data virtualization. Same as first option.
        ///{ virtual: true }
        ///Enables grid vertical scrolling with data virtualization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     scrollable: {
        ///         virtual: true //false
        ///     }
        /// });
        ///</code>
        ///</example>
        public bool scrollable { get; set; }
        /// <summary>
        /// (default: true) Enable/disable grid scrolling. Possible values:
        /// true
        ///Enables grid vertical scrolling
        ///false
        ///Disables grid vertical scrolling
        ///{ virtual: false }
        ///Enables grid vertical scrolling without data virtualization. Same as first option.
        ///{ virtual: true }
        ///Enables grid vertical scrolling with data virtualization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     scrollable: {
        ///         virtual: true //false
        ///     }
        /// });
        ///</code>
        ///</example>
        [JsProperty(Name = "scrollable")]
        public object scrollableObject { get; set; }

        /// <summary>
        /// (default: undefined) Indicates whether selection is enabled/disabled. 
        /// </summary>
        public GridSelectableOptions selectable { get; set; }

        /// <summary>
        /// Defines whether grid columns are sortable.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     sortable: true
        /// });
        /// //
        /// // or
        /// //
        /// $("#grid").kendoGrid({
        ///     sortable: {
        ///         mode: "multiple", // enables multi-column sorting
        ///         allowUnsort: true
        /// });
        ///</code>
        ///</example>
        public GridSortableConfiguration sortable { get; set; }

        /// <summary>
        /// This is a list of commands for which the corresponding buttons will be rendered. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        public GridSortableToolbarConfiguration toolbar { get; set; }

        /// <summary>
        /// This is a list of commands for which the corresponding buttons will be rendered. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        [JsProperty(Name = "toolbar")]
        public GridSortableToolbarCommandsOptions toolbarBuildInCommands { get; set; }
        //TODO: check if neeeded 



    }

    public enum GridSelectableOptions
    {
        /// <summary>
        /// Single row selection.
        /// </summary>
        row,
        /// <summary>
        /// Single cell selection.
        /// </summary>
        cell,
        /// <summary>
        /// Multiple row selection.
        /// </summary>
        multipleRow,
        /// <summary>
        /// Multiple cell selection.
        /// </summary>
        multipleCell

    }

    public class GridColumnsConfiguration
    {
        /// <summary>
        /// Definition of command column. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        public ColumnsCommandOptions command { get; set; }
        /// <summary>
        /// Definition of command column. The supported built-in commands are: "create", "cancel", "save", "destroy".
        /// </summary>
        [JsProperty(Name = "command")]
        public JsString commandString { get; set; }
        //TODO: not sure if needed

        /// <summary>
        /// Provides a way to specify custom editor for this column.
        /// </summary>
        public ColumnsEditorConfiguration editor { get; set; }
        /// <summary>
        /// Provides a way to specify custom editor for this column.
        /// </summary>
        [JsProperty(Name = "editor")]
        public JsAction editorFunction { get; set; }
        //TODO: not sure if needed

        /// <summary>
        /// (default: true) Specified whether the column content is escaped. Disable encoding if the data contains HTML markup.
        /// </summary>
        public bool encoded { get; set; }

        /// <summary>
        /// The field from the datasource that will be displayed in the column.
        /// </summary>
        public JsString field { get; set; }

        /// <summary>
        /// (default: true) Specifies whether given column is filterable.
        /// </summary>
        public bool filterable { get; set; }

        /// <summary>
        /// The format that will be applied on the column cells.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             format: "{0:dd/MMMM/yyyy}"
        ///        }
        ///     ]
        ///  });
        ///</code>
        ///</example>
        public JsString format { get; set; }

        /// <summary>
        /// (default: true) Specifies whether given column is sortable.
        /// </summary>
        public bool sortable { get; set; }

        /// <summary>
        /// The template for column's cells.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ]
        ///  });
        ///</code>
        ///</example>
        public JsString template { get; set; }

        /// <summary>
        /// The text that will be displayed in the column header.
        /// </summary>
        public JsString title { get; set; }

        /// <summary>
        /// The width of the column.
        /// </summary>
        public JsString width { get; set; }

    }

    public enum ColumnsCommandOptions
    {
        create,
        cancel,
        save,
        destroy,

    }

    public class ColumnsEditorConfiguration
    {
        /// <summary>
        /// The container in which the editor must be added.
        /// </summary>
        public object container { get; set; }

        /// <summary>
        /// Additional options.
        /// </summary>
        public ColumnsEditorOptionsConfiguration options { get; set; }
    }
    public class ColumnsEditorOptionsConfiguration
    {
        /// <summary>
        /// The field for the editor.
        /// </summary>
        public JsString field { get; set; }

        /// <summary>
        /// The model for the editor.
        /// </summary>
        public object model { get; set; }
    }

    public class GridEditableConfiguration
    {
        /// <summary>
        /// Defines the text that will be used in confirmation box when delete an item.
        /// </summary>
        public bool confirmation { get; set; }
        /// <summary>
        /// Defines the text that will be used in confirmation box when delete an item.
        /// </summary>
        [JsProperty(Name = "confirmation")]
        public JsString confirmationString { get; set; }

        /// <summary>
        /// Indicates whether item should be deleted when click on delete button.
        /// </summary>
        public bool destroy { get; set; }

        /// <summary>
        /// Indicates which of the available edit modes(incell(default)/inline/popup) will be used
        /// </summary>
        public JsString mode { get; set; }

        /// <summary>
        /// Template which will be use during popup editing
        /// </summary>
        public JsString template { get; set; }

        /// <summary>
        /// Indicates whether item should be switched to edit mode on click.
        /// </summary>
        public bool update { get; set; }
    }

    public class GridPageableConfiguration
    {
        /// <summary>
        /// Defines the number of records which will be displyed.
        /// </summary>
        public JsNumber pageSize { get; set; }

        /// <summary>
        /// (default: true) Defines if buttons for navigating to the first, last, previous and next pages will be shown.
        /// </summary>
        public bool previousNext { get; set; }

        /// <summary>
        /// (default: true) Defines if numeric portion of the pager will be shown.
        /// </summary>
        public bool numeric { get; set; }

        /// <summary>
        /// (default: 10) Defines the number of buttons displayed in the numeric pager.
        /// </summary>
        public JsNumber buttonCount { get; set; }

        /// <summary>
        /// (default: false) Defines if an input element which allows the user to navigate to given page will be displayed.
        /// </summary>
        public bool input { get; set; }

        /// <summary>
        /// (default: false)Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        public bool pageSizes { get; set; }
        /// <summary>
        /// (default: [5,10,20])Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        [JsProperty(Name = "pageSizes")]
        public JsArray pageSizesArray { get; set; }

        /// <summary>
        /// (default: false) Defines if a refresh button will be displayed.
        /// </summary>
        public bool refresh { get; set; }

        /// <summary>
        /// (default: true) Defines if a label showing current paging information will be displayed.
        /// </summary>
        public bool info { get; set; }

        /// <summary>
        /// Defines texts shown within the pager.
        /// </summary>
        public GridPageableMessagesConfiguration messages { get; set; }

    }

    public class GridPageableMessagesConfiguration
    {
        /// <summary>
        /// (default: "{0} - {1} of {2} items"), Defines the info text.
        /// </summary>
        public JsString display { get; set; }

        /// <summary>
        /// (default: "No items to display"), Defines the info text shown when there are no records to be displayed.
        /// </summary>
        public JsString empty { get; set; }

        /// <summary>
        /// (default: "Page"), Defines the first part of the text of the input option.
        /// </summary>
        public JsString page { get; set; }

        /// <summary>
        /// (default: "of {0}"), Defines the last part of the text of the input option.
        /// </summary>
        public JsString of { get; set; }

        /// <summary>
        /// (default: "items per page"), Defines the text displayed after the select element of the pageSizes mode.
        /// </summary>
        public JsString itemsPerPage { get; set; }

        /// <summary>
        /// (default: "Go to the first page"), Defines the text of the first page button tooltip.
        /// </summary>
        public JsString first { get; set; }

        /// <summary>
        /// (default: "Go to the previous page"), Defines the text of the previous page button tooltip.
        /// </summary>
        public JsString previous { get; set; }

        /// <summary>
        /// (default: "Go to the next page"), Defines the text of the next page button tooltip.
        /// </summary>
        public JsString next { get; set; }

        /// <summary>
        /// (default: "Go to the last page"), Defines the text of the last page button tooltip.
        /// </summary>
        public JsString last { get; set; }

        /// <summary>
        /// (default: "Refresh"), Defines the text of the refresh button tooltip.
        /// </summary>
        public JsString refresh { get; set; }
    }

    public class GridSortableConfiguration
    {
        /// <summary>
        /// (default: false) Defines whether column can have unsorted state.
        /// </summary>
        public bool allowUnsort { get; set; }

        public GridSortableModeOptions mode { get; set; }

    }

    public enum GridSortableModeOptions
    {
        /// <summary>
        /// Defines that only once column can be sorted at a time.
        /// </summary>
        single,
        /// <summary>
        /// Defines that multiple columns can be sorted at a time.
        /// </summary>
        multiple,
    }
    public enum GridSortableToolbarCommandsOptions
    {
        create,
        cancel,
        save,
        destroy,
    }

    public class GridSortableToolbarConfiguration
    {
        /// <summary>
        /// The name of the command. One of the predefined or a custom.
        /// </summary>
        public JsString name { get; set; }

        /// <summary>
        /// The template for the command button.
        /// </summary>
        public JsString template { get; set; }

        /// <summary>
        /// The text of the command that will be set on the button.
        /// </summary>
        public JsString text { get; set; }

    }

    public class GridDetailCollapseEventData
    {
        /// <summary>
        /// The jQuery element representing master row.
        /// </summary>
        public object masterRow { get; set; }

        /// <summary>
        /// The jQuery element representing detail row.
        /// </summary>
        public object detailRow { get; set; }
    }

    public class GridDetailInitEventData
    {
        /// <summary>
        /// The jQuery element representing master row.
        /// </summary>
        public object masterRow { get; set; }

        /// <summary>
        /// The jQuery element representing detail row.
        /// </summary>
        public object detailRow { get; set; }

        /// <summary>
        /// The jQuery element representing detail cell.
        /// </summary>
        public object detailCell { get; set; }

        /// <summary>
        /// The data for the master row.
        /// </summary>
        public object data { get; set; }

    }

    public class GridEditEventData
    {
        /// <summary>
        /// The jQuery element to be edited.
        /// </summary>
        public object container { get; set; }

        /// <summary>
        /// The model to be edited.
        /// </summary>
        public object model { get; set; }
    }

    public class GridRemoveEventData
    {
        /// <summary>
        /// The row element to be deleted.
        /// </summary>
        public object row { get; set; }

        /// <summary>
        /// The model which to be deleted.
        /// </summary>
        public object model { get; set; }
    }

    public class GridSaveEventData
    {
        /// <summary>
        /// The values entered by the user.
        /// </summary>
        public object values { get; set; }

        /// <summary>
        /// The jQuery element which is in edit mode.
        /// </summary>
        public object container { get; set; }

        /// <summary>
        /// The edited model.
        /// </summary>
        public object model { get; set; }
    }

    public class ListView
    {

        /// <summary>
        /// Inserts empty item as first item on the current view and prepare it for editing.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        ///var listView = $("#listView").data("kendoListView");
        /// // add item
        ///listView.add();
        ///</code>
        ///</example>
        public void add() { }

        /// <summary>
        /// Cancels changes in currently edited item.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // cancel changes in currently edited item
        /// listView.cancel();
        ///</code>
        ///</example>
        public void cancel() { }

        /// <summary>
        /// Clears ListView selected items and triggers change event.
        /// </summary>
        public void clearSelection() { }

        /// <summary>
        /// Edit specified ListView item. Triggers edit event.
        /// </summary>
        /// <param name="item">jQuery object containing the item to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.edit(listView.element.children().first());
        ///</code>
        ///</example>
        public void edit(jQuery.jQuery item) { }
        /// <summary>
        /// Edit specified ListView item. Triggers edit event.
        /// </summary>
        /// <param name="item">jQuery object containing the item to be edited.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.edit(listView.element.children().first());
        ///</code>
        ///</example>
        public void edit(Model item) { }
        //TODO: danel not sure. d.check

        /// <summary>
        /// Reloads the data and repaints the list view.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var listView = $("#listView").data("kendoListView");
        /// // refreshes the list view
        /// listView.refresh();
        ///</code>
        ///</example>   
        public void refresh() { }

        /// <summary>
        /// Removes specified ListView item. Triggers remove event and if not prevented calls DataSource sync method.
        /// </summary>
        /// <param name="item">jQuery object containing the item to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.remove(listView.element.children().first());
        ///</code>
        ///</example>
        public void remove(jQuery.jQuery item) { }
        /// <summary>
        /// Removes specified ListView item. Triggers remove event and if not prevented calls DataSource sync method.
        /// </summary>
        /// <param name="item">jQuery object containing the item to be removed.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.remove(listView.element.children().first());
        ///</code>
        ///</example>
        public void remove(Model item) { }
        //TODO: danel not sure. d.check

        /// <summary>
        /// Saves edited ListView item. If validation succeeds will call DataSource sync method.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // edit first list view item
        /// listView.edit(listView.element.children().first());
        /// // save edited item
        /// listView.save();
        ///</code>
        ///</example>   
        public void save() { }

        /// <summary>
        /// Selects the specified ListView item. If called without arguments - returns the selected items.
        /// </summary>
        /// <param name="items">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // selects first list view item
        /// listView.select(listView.element.children().first());
        ///</code>
        ///</example>
        public void select(JsAction items) { }
        //TODO: "If called without arguments - returns the selected items." (?)
        /// <summary>
        /// Selects the specified ListView item. If called without arguments - returns the selected items.
        /// </summary>
        /// <param name="items">Items to select.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the list view widget
        /// var listView = $("#listView").data("kendoListView");
        /// // selects first list view item
        /// listView.select(listView.element.children().first());
        ///</code>
        ///</example>
        public void select(JsArray items) { }
        //TODO: "If called without arguments - returns the selected items." (?)


        /// <summary>
        /// Fires when the list view selection has changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the list view has received data from the data source. and is about to render it.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     dataBound: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> dataBound { add { } remove { } }

        /// <summary>
        /// Fires when the grid enters edit mode.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     edit: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<ListViewEditEventData> editEvent { add { } remove { } }
        //TODO: event name is edit

        /// <summary>
        /// Fires when the list view  item is removed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// $("#grid").kendoGrid({
        ///     remove: function(e) {
        ///         // handle event
        /// });
        ///</code>
        ///</example>
        public event JsAction<ListViewRemoveEventData> removeEvent { add { } remove { } }
        //TODO: event name is remove
    }

    public class ListViewConfiguration
    {

        /// <summary>
        /// (default: true) Indicates whether the list view will call read on the DataSource initially.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: sharedDataSource,
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     autoBind: false // the grid will not be populated with data until read() is called on the sharedDataSource
        /// });
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }
        /// <summary>
        /// Instance of DataSource or Object with DataSource configuration.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var items = [ { Name: "Item 1" }, { Name: "Item 2"} ];
        ///$("#autoComplete").kendoAutoComplete({ dataSource: items });
        ///</code>
        ///</example>
        [JsProperty(Name = "dataSource")]
        public object dataSourceObject { get; set; }

        /// <summary>
        /// Specifies ListView item template in edit mode.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#listView").kendoListView({
        ///     dataSource: {
        ///         data: createRandomData(50)
        ///     },
        ///     template: kendo.template($("#template").html()),
        ///     editTemplate: kendo.template($("#editTemplate").html())
        /// });
        ///</code>
        ///</example>
        public JsAction editTemplate { get; set; }

        /// <summary>
        /// (default: false) Indicates whether keyboard navigation is enabled/disabled.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: {
        ///         data: createRandomData(50),
        ///         pageSize: 10
        ///     },
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     navigatable: true
        /// });
        ///</code>
        ///</example>
        public bool navigatable { get; set; }

        /// <summary>
        /// (default: undefined) Indicates whether selection is enabled/disabled. 
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///&lt;script type="text/x-kendo-tmpl" id="template">
        ///     &lt;div>
        ///       &lt;dl>
        ///         &lt;dt>Name</dt> <dd>${Name}</dd>
        ///         &lt;dt>Birth Date</dt> <dd>${BirdthDate}</dd>
        ///       &lt;/dl>
        ///     &lt;/div>
        /// &lt;/script>
        ///</code>
        ///</example>
        public GridSelectableOptions selectable { get; set; }
    }

    public class ListViewEditEventData
    {
        /// <summary>
        /// The jQuery element to be edited.
        /// </summary>
        public object item { get; set; }

        /// <summary>
        /// The model to be edited.
        /// </summary>
        public object model { get; set; }
    }

    public class ListViewRemoveEventData
    {
        /// <summary>
        /// The item element to be deleted.
        /// </summary>
        public object item { get; set; }

        /// <summary>
        /// The model which to be deleted.
        /// </summary>
        public object model { get; set; }
    }

    public class Menu
    {
        /// <summary>
        /// Appends an item to a Menu in the specified referenceItem's sub menu.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.append(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu append(JsAction item, object referenceItem) { return null; }
        /// <summary>
        /// Appends an item to a Menu in the specified referenceItem's sub menu.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.append(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu append(JsArray item, object referenceItem) { return null; }

        /// <summary>
        /// Closes a sub-menu of a specified item(s) in a Menu.
        /// </summary>
        /// <param name="element">Target item selector.</param>
        /// <param name="item">The closed item</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // close the sub menu of "Item1"
        /// menu.close("#Item1");
        ///</code>
        ///</example>
        public Menu close(JsAction element, HtmlElement item) { return null; }

        /// <summary>
        /// Enables or disables an item of a Menu. This can optionally be accomplished on initialization by setting the disabled="disabled" on the desired menu item html element.
        /// </summary>
        /// <param name="element">Target element</param>
        /// <param name="enable">Desired state</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // disable the li menu item with the id "secondItem"
        /// menu.enable("#secondItem", false);
        ///</code>
        ///</example>
        public Menu enable(JsAction element, bool enable) { return null; }

        /// <summary>
        /// Inserts an item into a Menu after the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertAfter(JsAction item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts an item into a Menu after the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertAfter(object item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts an item into a Menu after the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertAfter(JsArray<object> item, object referenceItem) { return null; }
        //TODO: chack all 3 of them

        /// <summary>
        /// Inserts an item into a Menu before the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertBefore(JsAction item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts an item into a Menu before the specified referenceItem.
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. Can also handle an array of such objects.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public Menu insertBefore(JsAction item, JsArray referenceItem) { return null; }

        /// <summary>
        /// Opens a sub-menu of a specified item(s) in a Menu.
        /// </summary>
        /// <param name="element">Target item selector.</param>
        /// <param name="item">The opened item</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // open the sub menu of "Item1"
        /// menu.open("#Item1");
        ///</code>
        ///</example>
        public Menu open(JsAction element, HtmlElement item) { return null; }

        /// <summary>
        /// Removes a specified item(s) from a Menu.
        /// </summary>
        /// <param name="element">Target item selector.</param>
        /// <returns>Returns the Menu object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // remove the item with the id "Item1"
        /// menu.remove("#Item1");
        ///</code>
        ///</example>
        public Menu remove(JsAction element) { return null; }


        /// <summary>
        /// Fires after a sub menu gets closed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    close: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> closeEvent { add { } remove { } }
        //TODO: event name is close

        /// <summary>
        /// Fires before a sub menu gets opened.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    open: function(e) {
        ///            // handle event
        ///        }
        ///});
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> openEvent { add { } remove { } }
        //TODO: event name is open

        /// <summary>
        /// Fires when a menu item gets selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> selectEvent { add { } remove { } }
        //TODO: event name is select
    }

    public class OneItemEventData
    {
        /// <summary>
        /// The selected  item
        /// </summary>
        public HtmlElement item { get; set; }
    }

    public class MenuConfiguration
    {
        /// <summary>
        /// A collection of Animation objects, used to change default animations. A value of false will disable all animations in the widget.
        /// Available animations for the Menu are listed below. Each animation has a reverse options which is used for the close effect by default,
        /// but can be over-ridden by setting the close animation. Each animation also has a direction which can be set off the animation (i.e. slideIn:Down).
        /// slideIn:
        /// Menu content slides in from the top
        /// fadeIn:
        /// Menu content fades in
        /// expand:
        /// Menu content expands from the top down. Similar to slideIn.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     animation: { open: { effects: "fadeIn" } }
        /// });
        ///</code>
        ///</example>
        public AnimationConfiguration animation { get; set; }

        /// <summary>
        /// (default: true) Specifies that sub menus should close after item selection (provided they won't navigate).
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///    closeOnClick: false
        ///});
        ///</code>
        ///</example>
        public bool closeOnClick { get; set; }

        /// <summary>
        /// (default: "default") Specifies Menu opening direction. Can be "top", "bottom", "left", "right".
        /// You can also specify different direction for root and sub menu items, separating them with space.
        /// The example below will initialize the root menu to open upwards and its sub menus to the left.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     direction: "top left"
        /// });
        ///</code>
        ///</example>
        public JsString direction { get; set; }

        /// <summary>
        /// (default: 100) Specifies the delay in ms before the menu is opened/closed - used to avoid accidental closure on leaving.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     hoverDelay: 200
        /// });
        ///</code>
        ///</example>
        public JsNumber hoverDelay { get; set; }

        /// <summary>
        /// (default: false) Specifies that the root sub menus will be opened on item click.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     openOnClick: true
        /// });
        ///</code>
        ///</example>
        public bool openOnClick { get; set; }

        /// <summary>
        /// (default: "horizontal") Root menu orientation. Could be horizontal or vertical.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     orientation: "vertical"
        /// });
        ///</code>
        ///</example>
        public JsString orientation { get; set; }

        /// <summary>
        /// Specifies how Menu should adjust to screen boundaries. By default the strategy is "fit" for a sub menu with a horizontal parent,
        /// meaning it will move to fit in screen boundaries in all directions, and "fit flip" for a sub menu with vertical parent,
        /// meaning it will fit vertically and flip over its parent horizontally.]
        /// You can also switch off the screen boundary detection completely if you set the popupCollision to false.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#menu").kendoMenu({
        ///     popupCollision: false
        /// });
        ///</code>
        ///</example>
        public JsString popupCollision { get; set; }

    }

    public class NumericTextBox
    {

        /// <summary>
        /// Enable/Disable the numerictextbox widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the autocomplete.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to instance of the Kendo UI ComboBox
        ///var combobox = $("#comboBox").data("kendoComboBox");
        /// // disables the combobox
        ///combobox.enable(false);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// Sets the max value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The max value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public void max(JsString value) { }
        /// <summary>
        /// Sets the max value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The max value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        /// // get the max value of the calendar.
        ///var max = calendar.max();
        /// // set the max value of the calendar.
        ///calendar.max(new Date(2100, 0, 1));
        ///</code>
        ///</example>
        public JsNumber max() { return null; }

        /// <summary>
        /// Sets the min value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The min value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public void min(JsString value) { }
        /// <summary>
        /// Sets the min value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The min value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the calendar widget
        ///var calendar = $("#calendar").data("kendoCalendar");
        ///
        /// // get the min value of the calendar.
        ///var min = calendar.min();
        ///
        /// // set the min value of the calendar.
        ///</code>
        ///</example>
        public JsNumber min() { return null; }

        /// <summary>
        /// Sets the step value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The step value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the NumericTextBox widget
        /// var numerictextbox = $("#numerictextbox").data("kendoNumericTextBox");
        /// 
        /// // get the step value of the numerictextbox.
        /// var step = numerictextbox.step();
        /// 
        /// // set the step value of the numerictextbox.
        /// numerictextbox.step(0.1);
        ///</code>
        ///</example>
        public void step(JsNumber value) { }
        /// <summary>
        /// Sets the step value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The step value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the NumericTextBox widget
        /// var numerictextbox = $("#numerictextbox").data("kendoNumericTextBox");
        /// 
        /// // get the step value of the numerictextbox.
        /// var step = numerictextbox.step();
        /// 
        /// // set the step value of the numerictextbox.
        /// numerictextbox.step(0.1);
        ///</code>
        ///</example>
        public void step(JsString value) { }
        /// <summary>
        /// Gets the step value of the NumericTextBox.
        /// </summary>
        /// <param name="value">The step value to set.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the NumericTextBox widget
        /// var numerictextbox = $("#numerictextbox").data("kendoNumericTextBox");
        /// 
        /// // get the step value of the numerictextbox.
        /// var step = numerictextbox.step();
        /// 
        /// // set the step value of the numerictextbox.
        /// numerictextbox.step(0.1);
        ///</code>
        ///</example>
        public JsNumber step() { return null; }

        ///// <summary>
        ///// Sets the value of the numerictextbox.
        ///// </summary>
        ///// <param name="value">The value to set.</param>
        /////<example>
        /////usage
        /////<code>
        ///// // get a referene to the numeric textbox
        ///// var numerictextbox = $("#textbox").data("kendoNumericTextBox");
        ///// 
        ///// // get the value of the numerictextbox.
        ///// var value = numerictextbox.value();
        ///// 
        ///// // set the value of the numerictextbox.
        ///// numerictextbox.value("10.20");
        /////</code>
        /////</example>
        //public void step(JsNumber value) { }
        ///// <summary>
        ///// Sets the value of the numerictextbox.
        ///// </summary>
        ///// <param name="value">The value to set.</param>
        /////<example>
        /////usage
        /////<code>
        ///// // get a referene to the numeric textbox
        ///// var numerictextbox = $("#textbox").data("kendoNumericTextBox");
        ///// 
        ///// // get the value of the numerictextbox.
        ///// var value = numerictextbox.value();
        ///// 
        ///// // set the value of the numerictextbox.
        ///// numerictextbox.value("10.20");
        /////</code>
        /////</example>
        //public void step(JsString value) { }
        ///// <summary>
        ///// Gets the value of the numerictextbox.
        ///// </summary>
        ///// <param name="value">The value to set.</param>
        /////<example>
        /////usage
        /////<code>
        ///// // get a referene to the numeric textbox
        ///// var numerictextbox = $("#textbox").data("kendoNumericTextBox");
        ///// 
        ///// // get the value of the numerictextbox.
        ///// var value = numerictextbox.value();
        ///// 
        ///// // set the value of the numerictextbox.
        ///// numerictextbox.value("10.20");
        /////</code>
        /////</example>
        //public JsNumber step() { return null; }
        //TODO: Error	1	Type 'SharpKit.KendoUI.Web.NumericTextBox' already defines a member called 'step' with the same parameter types	C:\Users\May\Documents\Visual Studio 2010\Projects\SharpKit_SDK\SharpKit.KendoUI.Web\kendo-web-2012.2.710.cs	5622	21	SharpKit.KendoUI.Web



        /// <summary>
        /// Fires when the value is changed
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the value is changed from the spin buttons
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#numeric").kendoNumericTextBox({
        ///     spin: function(e) {
        ///         // handle event
        ///     }
        /// });
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> spin { add { } remove { } }


    }

    public class NumericTextBoxConfiguration
    {
        /// <summary>
        /// (default: en-US) Specifies the culture info used by the NumericTextBox widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        ///$("#calendar").kendoCalendar({
        ///    culture: "de-DE"
        ///});
        ///</code>
        ///</example>
        public JsString culture { get; set; }

        /// <summary>
        /// (default: null) Specifies the number precision. If not set precision defined by current culture is used.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 1,
        ///     step: 0.1,
        ///     decimals: 1
        /// });
        ///</code>
        ///</example>
        public JsNumber decimals { get; set; }

        /// <summary>
        /// (default: Decrease value) Specifies the text of the tooltip on the down arrow.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50,
        ///     upArrowText: "More",
        ///     downArrowText: "Less"
        /// });
        ///</code>
        ///</example>
        public JsString downArrowText { get; set; }

        /// <summary>
        /// (default: n) Specifies the format of the number. Any valid number format is allowed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#numeric").kendoNumericTextBox({
        ///    format: "p0", // format as percentage with % sign
        ///    min: 0,
        ///    max: 1,
        ///    step: 0.01
        /// });
        ///</code>
        ///</example>   
        public JsString format { get; set; }

        /// <summary>
        /// (default: null) Specifies the largest value the user can enter.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify in the HTML
        /// &lt;input id="numeric" value="10" type="number" min="-100" max="100" step="10"/>
        /// &lt;br />
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50
        /// });
        ///</code>
        ///</example>
        public JsNumber max { get; set; }

        /// <summary>
        /// (default: null) Specifies the smallest value the user can enter.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify in the HTML
        /// &lt;input id="numeric" value="10" type="number" min="-100" max="100" step="10"/>
        /// &lt;br />
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50
        /// });
        ///</code>
        ///</example>
        public JsNumber min { get; set; }

        /// <summary>
        /// (default: "") Specifies the text displayed when the input is empty.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50,
        ///     placeholder: "Select A Value"
        /// });
        ///</code>
        ///</example>   
        public JsString placeholder { get; set; }

        /// <summary>
        /// (default: 1) Specifies the increment/decrement step.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify in the HTML
        /// &lt;input id="numeric" value="10" type="number" />
        /// &lt;br />
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 1,
        ///     step: 0.1
        /// });
        ///</code>
        ///</example>
        public JsNumber step { get; set; }

        /// <summary>
        /// (default: Increase value) Specifies the text of the tooltip on the up arrow.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50,
        ///     upArrowText: "More",
        ///     downArrowText: "Less"
        /// });
        ///</code>
        ///</example>
        public JsString upArrowText { get; set; }

        /// <summary>
        /// (default: null) Specifies the value of the NumericTextBox widget.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // specify in the HTML
        /// &lt;input id="numeric" value="10" type="number" min="-100" max="100" step="10"/>
        /// 
        /// // specify on widget initialization
        /// $("#numeric").kendoNumericTextBox({
        ///     min: 0,
        ///     max: 100,
        ///     value: 50
        /// });
        ///</code>
        ///</example>
        public JsNumber value { get; set; }
    }

    public class Pager
    {
        /// <summary>
        /// Returns the number of pages.
        /// </summary>
        /// <returns></returns>
        public JsNumber totalPages() { return null; }

        /// <summary>
        /// Returns the page size - maximum number of items allowed on one page.
        /// </summary>
        /// <returns></returns>
        public JsNumber pageSize() { return null; }

        /// <summary>
        /// Set the specified page as a current page. If called without arguments - returns the current page.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var currentPage = pager.page();
        ///</code>
        ///</example>   
        public JsNumber page() { return null; }
        /// <summary>
        /// Set the specified page as a current page. If called without arguments - returns the current page.
        /// </summary>
        /// <example>
        ///usage
        ///<code>
        ///pager.page(2);
        ///</code>
        ///</example>   
        public void page(JsNumber page) { }

        /// <summary>
        /// Updates all values of pager elements so that these values fit the values of DataSource.
        /// This method is automaticaly called after DataSource change event is fired.
        /// </summary>
        public void refresh() { }

        /// <summary>
        /// Unbinds all callbacks created within pager initialization. This method doesn't remove pager element from DOM.
        /// </summary>
        public void destroy() { }

        /// <summary>
        /// Fires when the current page has changed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#comboBox").kendoComboBox({
        ///    change: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<EmptyEventData> change { add { } remove { } }
    }

    public class PagerConfiguration
    {
        /// <summary>
        /// (default: true) Indicates whether the pager refresh method will be called within its initialization.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#grid").kendoGrid({
        ///     dataSource: sharedDataSource,
        ///     columns: [
        ///         {
        ///             field: "Name"
        ///         },
        ///         {
        ///             field: "BirthDate",
        ///             title: "Birth Date",
        ///             template: '#= kendo.toString(BirthDate,"dd MMMM yyyy") #'
        ///        }
        ///     ],
        ///     autoBind: false // the grid will not be populated with data until read() is called on the sharedDataSource
        /// });
        ///</code>
        ///</example>
        public bool autoBind { get; set; }

        /// <summary>
        /// (default: 10) Defines the number of buttons displayed in the numeric pager.
        /// </summary>
        public JsNumber buttonCount { get; set; }

        /// <summary>
        /// Instance of kendo DataSource. See the kendo.data.DataSource. This option is mandatory because the Pager is tightly connected with DataSource.
        /// The pager is UI widget for managing paging over the DataSource. The Pager gets values like page size or total count of items from DataSource.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#pager").kendoPager({
        ///     dataSource: new kendo.data.DataSource({
        ///         data: [
        ///             {title: "Star Wars: A New Hope", year: 1977},
        ///             {title: "Star Wars: The Empire Strikes Back", year: 1980}
        ///         ],
        ///         pageSize: 25
        ///     });
        ///     pageSizes: [10, 25, 50]
        /// });
        ///</code>
        ///</example>
        public DataSource dataSource { get; set; }

        /// <summary>
        /// The template for selectbox with predefined page sizes.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#pager").kendoPager({
        ///     dataSource: sharedDataSource,
        ///     selectTemplate: '&lt;li>&lt;span class="k-state-selected">#=text#&lt;/span>&lt;/li>'
        /// });
        ///</code>
        ///</example>
        public JsString selectTemplate { get; set; }

        /// <summary>
        /// The template for page number links.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#pager").kendoPager({
        ///     dataSource: sharedDataSource,
        ///     linkTemplate: '&lt;li>&lt;a href="\\#" class="k-link" data-#=ns#page="#=idx#">#=text#&lt;/a>&lt;/li>'
        /// });
        ///</code>
        ///</example>
        public JsString linkTemplate { get; set; }

        /// <summary>
        /// (default: true) Defines if a label showing current paging information will be displayed.
        /// </summary>
        public bool info { get; set; }

        /// <summary>
        /// (default: false) Defines if an input element which allows the user to navigate to given page will be displayed.
        /// </summary>
        public bool input { get; set; }

        /// <summary>
        /// (default: true) Defines if numeric portion of the pager will be shown.
        /// </summary>
        public bool numeric { get; set; }

        /// <summary>
        /// (default: false)Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        public bool pageSizes { get; set; }
        /// <summary>
        /// (default: [5,10,20])Displayes a list with predefined page sizes. An array of values to be displayed can be provided.
        /// </summary>
        [JsProperty(Name = "pageSizes")]
        public JsArray pageSizesArray { get; set; }

        /// <summary>
        /// (default: true) Defines if buttons for navigating to the first, last, previous and next pages will be shown.
        /// </summary>
        public bool previousNext { get; set; }

        /// <summary>
        /// (default: false) Defines if a refresh button will be displayed.
        /// </summary>
        public bool refresh { get; set; }

        /// <summary>
        /// Defines texts shown within the pager.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#pager").kendoPager({
        ///    dataSource: sharedDataSource,
        ///    messages: {
        ///        display: "{0} - {1} of {2} items",
        ///        empty: "No items to display",
        ///        page: "Page",
        ///        of: "of {0}",
        ///        itemsPerPage: "items per page",
        ///        first: "Go to the first page",
        ///        previous: "Go to the previous page",
        ///        next: "Go to the next page",
        ///        last: "Go to the last page",
        ///        refresh: "Refresh"
        ///    }
        ///});
        ///</code>
        ///</example>
        public GridPageableMessagesConfiguration messages { get; set; }
    }

    public class PanelBar
    {
        /// <summary>
        /// Appends an item to the PanelBar.
        /// </summary>
        /// <param name="item">Target item, specified as the JSON representation of an object. You can pass item text, content or contentUrl here.
        /// Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns> Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.append(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar append(JsAction item, object referenceItem) { return null; }
        /// <summary>
        /// Appends an item to the PanelBar.
        /// </summary>
        /// <param name="item">Target item, specified as the JSON representation of an object. You can pass item text, content or contentUrl here.
        /// Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns> Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.append(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar append(JsString item, object referenceItem) { return null; }
        /// <summary>
        /// Appends an item to the PanelBar.
        /// </summary>
        /// <param name="item">Target item, specified as the JSON representation of an object. You can pass item text, content or contentUrl here.
        /// Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns> Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// //
        /// menu.append(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                                 // Allows use of HTML for item text
        ///         content: "text"                                 // content within an item
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         items: [{                                    // Sub item collection
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar append(JsArray item, object referenceItem) { return null; }

        /// <summary>
        /// Collapses the specified item(s) of a PanelBar. Temporarily enables (true) or disables (false) any visual animation(s) when collapsing items.
        /// </summary>
        /// <param name="element">The PanelBar item(s) to be collapsed, expressed as a string containing a selector expression or represented by a jQuery selector.</param>
        /// <param name="useAnimation">_optional, default: _</param>
        /// <param name="item">The collapsing item of the PanelBar.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        public PanelBar collapse(JsString element, bool useAnimation, HtmlElement item) { return null; }

        /// <summary>
        ///Enables (true) or disables (false) the specified item(s) of the PanelBar.
        /// </summary>
        /// <param name="element">The PanelBar item(s) to be enabled (true) or disabled (false),
        /// expressed as a string containing a selector expression or represented by a jQuery selector.</param>
        /// <param name="enable">The desired state - enabled (true) or disabled (false) - of the target element(s).</param>
        ///<example>
        ///usage
        ///<code>
        /// // access an existing PanelBar instance
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // enable the item of the PanelBar with ID, "item1"
        /// panelBar.enable($("#item1"), true);
        /// // disable the currently selected item of the PanelBar
        /// var item = panelBar.select();
        /// panelBar.enable(item, false);
        /// // disable all list items that start with ID, "item"
        /// panelBar.enable($('[id^="item"]'), false);
        ///</code>
        ///</example>
        public void enable(JsAction element, bool enable) { }
        /// <summary>
        ///Enables (true) or disables (false) the specified item(s) of the PanelBar.
        /// </summary>
        /// <param name="element">The PanelBar item(s) to be enabled (true) or disabled (false),
        /// expressed as a string containing a selector expression or represented by a jQuery selector.</param>
        /// <param name="enable">The desired state - enabled (true) or disabled (false) - of the target element(s).</param>
        ///<example>
        ///usage
        ///<code>
        /// // access an existing PanelBar instance
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // enable the item of the PanelBar with ID, "item1"
        /// panelBar.enable($("#item1"), true);
        /// // disable the currently selected item of the PanelBar
        /// var item = panelBar.select();
        /// panelBar.enable(item, false);
        /// // disable all list items that start with ID, "item"
        /// panelBar.enable($('[id^="item"]'), false);
        ///</code>
        ///</example>
        public void enable(JsString element, bool enable) { }

        /// <summary>
        /// Expands the specified item(s) of a PanelBar. Temporariliy enables (true) or disables (false) any visual animation(s) when expanding items.
        /// </summary>
        /// <param name="element">The PanelBar item(s) to be expanded, expressed as a selector.</param>
        /// <param name="useAnimation">_optional, default: _</param>
        /// <param name="item">The expanding item of the PanelBar.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        /// // access an existing PanelBar instance
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // expand the element with ID, "item1"
        /// panelBar.expand($("#item1"));
        /// // expand the element with ID, "item2" without visual animations
        /// panelBar.expand($("#item2"), false);
        /// // expand all list items that start with ID, "item"
        /// panelBar.expand($('[id^="item"]'));
        ///</code>
        ///</example>
        public PanelBar expand(JsString element, bool useAnimation, HtmlElement item) { return null; }

        /// <summary>
        /// Inserts a PanelBar item after the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to insert the new item after</param>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public void insertAfter(JsAction item, object referenceItem) { }
        /// <summary>
        /// Inserts a PanelBar item after the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to insert the new item after</param>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public void insertAfter(JsString item, object referenceItem) { }
        /// <summary>
        /// Inserts a PanelBar item after the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an HTML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to insert the new item after</param>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertAfter(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public void insertAfter(JsArray<JsString> item, object referenceItem) { }

        /// <summary>
        /// Inserts a PanelBar item before the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an TML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar insertBefore(JsAction item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts a PanelBar item before the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an TML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar insertBefore(JsString item, object referenceItem) { return null; }
        /// <summary>
        /// Inserts a PanelBar item before the specified referenceItem
        /// </summary>
        /// <param name="item">Target item, specified as a JSON object. You can pass item text, content or contentUrl here. Can handle an TML string or array of such strings or JSON.</param>
        /// <param name="referenceItem">A reference item to append the new item in.</param>
        /// <returns>Returns the PanelBar object to support chaining.</returns>
        ///<example>
        ///usage
        ///<code>
        ///panelBar.insertBefore(
        ///     [{
        ///         text: "Item 1",
        ///         url: "http://www.kendoui.com"                // Link URL if navigation is needed, optional.
        ///     },
        ///     {
        ///         text: "<b>Item 2</b>",
        ///         encoded: false,                              // Allows use of HTML for item text
        ///         content: "text"                              // Content for the content element
        ///     },
        ///     {
        ///         text: "Item 3",
        ///         contentUrl: "partialContent.html"            // From where to load the item content
        ///     },
        ///     {
        ///         text: "Item 4",
        ///         imageUrl: "http://www.kendoui.com/test.jpg", // Item image URL, optional.
        ///         expanded: true,                              // item is rendered expanded
        ///         items: [{                                    // Sub item collection.
        ///              text: "Sub Item 1"
        ///         },
        ///         {
        ///              text: "Sub Item 2"
        ///         }]
        ///     },
        ///     {
        ///         text: "Item 5",
        ///         spriteCssClass: "imageClass3"                // Item image sprite CSS class, optional.
        ///     }],
        ///     referenceItem
        /// );
        ///</code>
        ///</example>
        public PanelBar insertBefore(JsArray<JsString> item, object referenceItem) { return null; }

        /// <summary>
        /// Reloads the content of a PanelBar from an AJAX request.
        /// </summary>
        /// <param name="element">Target element</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the panel bar
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // reload the panel basr
        /// panelBar.reload();
        ///</code>
        ///</example>
        public void reload(JsAction element) { }

        /// <summary>
        /// Removes the specified PanelBar item(s).
        /// </summary>
        /// <param name="element">Target item selector.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the menu widget
        /// var menu = $("#menu").data("kendoMenu");
        /// // remove the item with the id "Item1"
        /// menu.remove("#Item1");
        ///</code>
        ///</example>
        public void remove(JsAction element) { }

        /// <summary>
        /// Selects the specified item of the PanelBar. If this method is invoked without arguments, it returns the currently selected item.
        /// </summary>
        /// <param name="element">The PanelBar item to be selected, expressed as a string containing a selector expression or represented by a jQuery selector.</param>
        /// <param name="item">The selected item of the PanelBar.</param>
        ///<example>
        ///usage
        ///<code>
        /// // access an existing PanelBar instance
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // select the item with ID, "item1"
        /// panelBar.select("#item1");
        ///</code>
        ///</example>
        public void select(JsAction element, HtmlElement item) { }
        /// <summary>
        /// Selects the specified item of the PanelBar. If this method is invoked without arguments, it returns the currently selected item.
        /// </summary>
        /// <param name="element">The PanelBar item to be selected, expressed as a string containing a selector expression or represented by a jQuery selector.</param>
        /// <param name="item">The selected item of the PanelBar.</param>
        ///<example>
        ///usage
        ///<code>
        /// // access an existing PanelBar instance
        /// var panelBar = $("#panelBar").data("kendoPanelBar");
        /// // select the item with ID, "item1"
        /// panelBar.select("#item1");
        ///</code>
        ///</example>
        public void select(JsString element, HtmlElement item) { }


        /// <summary>
        /// Triggered when an item of a PanelBar is activated.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for activate
        /// var onActivate = function(e) {
        ///     // access the activated item via e.item (HTMLElement)
        /// };
        /// 
        /// // attach activate event handler during initialization
        /// var panelBar = $("#panelBar").kendoPanelBar({
        ///     activate: onActivate
        /// });
        /// 
        /// // detach activate event handler via unbind()
        /// panelBar.data("kendoPanelBar").unbind("activate", onActivate);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> activate { add { } remove { } }

        /// <summary>
        /// Triggered when an item of a PanelBar is collapsed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for collapse
        /// var onCollapse = function(e) {
        ///     // access the collapsed item via e.item (HTMLElement)
        /// };
        /// 
        /// // attach collapse event handler during initialization
        /// var panelBar = $("#panelBar").kendoPanelBar({
        ///     collapse: onCollapse
        /// });
        /// 
        /// // detach collapse event handler via unbind()
        /// panelBar.data("kendoPanelBar").unbind("collapse", onCollapse);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> collapseEvent { add { } remove { } }
        //TODO: event name is collapse

        /// <summary>
        /// Fires when content is fetched from an AJAX request.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    contentLoad: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<PanelBarContentLoadEventData> contentLoad { add { } remove { } }

        /// <summary>
        /// Fires when AJAX request results in an error.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    error: function(e) {
        ///        // handle event
        ///    }
        ///});
        ///</code>
        ///</example>
        public event JsAction<PanelBarErrorEventData> error { add { } remove { } }

        /// <summary>
        /// Triggered when an item of a PanelBar is expanded.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for expand
        /// var onExpand = function(e) {
        ///     // access the expanded item via e.item (HTMLElement)
        /// };
        /// 
        /// // attach expand event handler during initialization
        /// var panelBar = $("#panelBar").kendoPanelBar({
        ///     expand: onExpand
        /// });
        /// 
        /// // detach expand event handler via unbind()
        /// panelBar.data("kendoPanelBar").unbind("expand", onExpand);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> expandEvent { add { } remove { } }
        //TODO: event name is expand

        /// <summary>
        /// Triggered when an item of a PanelBar is selected.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // event handler for select
        /// var onSelect = function(e) {
        ///     // access the selected item via e.item (jQuery object)
        /// };
        /// 
        /// // attach select event handler during initialization
        /// var combobox = $("#combobox").kendoComboBox({
        ///     select: onSelect
        /// });
        /// 
        /// // detach select event handler via unbind()
        /// combobox.data("kendoComboBox").unbind("select", onSelect);
        ///</code>
        ///</example>
        public event JsAction<OneItemEventData> selectEvent { add { } remove { } }
        //TODO: event name is select
    }

    public class PanelBarConfiguration
    {
        /// <summary>
        /// A collection of visual animations used when PanelBar items are opened or closed through user interactions. Setting this option to false will disable all animations.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        // fade-out closing items over 1000 milliseconds
        ///        close: {
        ///            duration: 1000,
        ///            effects: "fadeOut"
        ///        },
        ///       // fade-in and expand opening items over 500 milliseconds
        ///       open: {
        ///           duration: 500,
        ///           effects: "expandVertical fadeIn"
        ///       }
        ///   }
        ///});
        ///</code>
        ///</example>
        public PanelBarAnimationConfiguration animation { get; set; }

        /// <summary>
        /// Specifies how the PanelBar items are displayed when opened and closed. The following values are available:
        /// "single"
        /// Display one item at a time when an item is opened; opening an item will close the previously opened item.
        /// "multiple"
        /// Display multiple values at one time; opening an item has no visual impact on any other items in the PanelBar.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    expandMode: "single"
        ///});
        ///</code>
        ///</example>
        public PanelBarExpandModeOptions expandMode { get; set; }
    }

    public class PanelBarAnimationConfiguration
    {
        /// <summary>
        /// The visual animation(s) that will be used when PanelBar items are closed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///    $("#combobox").kendoComboBox({
        ///        dataSource: dataSource,
        ///        animation: {
        ///           close: {
        ///               effects: "fadeOut",
        ///               duration: 300,
        ///               hide: true
        ///               show: false
        ///           }
        ///        }
        ///    });
        ///&lt;/script>
        ///</code>
        ///</example>
        public PanelBarAnimationCloseConfiguration close { get; set; }

        /// <summary>
        /// Animation to be used for opening of the popup.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// //combobox initialization
        ///&lt;script>
        ///     $("#combobox").kendoComboBox({
        ///         dataSource: dataSource,
        ///         animation: {
        ///            open: {
        ///                effects: "fadeIn",
        ///                duration: 300,
        ///                show: true
        ///            }
        ///         }
        ///     });
        /// &lt;/script>
        ///</code>
        ///</example>
        public PanelBarAnimationOpenConfiguration open { get; set; }

    }

    public class PanelBarAnimationCloseConfiguration
    {
        /// <summary>
        /// (default: 200) The number of milliseconds used for the visual animation when a PanelBar item is closed.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        close: {
        ///
        ///                   duration: 1000
        ///
        ///               }
        ///  }
        ///});
        ///</code>
        ///</example>
        public JsNumber duration { get; set; }

        /// <summary>
        /// A whitespace-delimited string of animation effects that are utilized when a PanelBar item is closed. Options include "fadeOut".
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        close: {
        ///            duration: 1000,
        ///            effects: "fadeOut"
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsString effects { get; set; }

    }

    public class PanelBarAnimationOpenConfiguration
    {
        /// <summary>
        /// (default: 200) The number of milliseconds used for the visual animation when an item is opened.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        open: {
        ///
        ///                   duration: 1000
        ///
        ///               }
        ///  }
        ///});
        ///</code>
        ///</example>
        public JsNumber duration { get; set; }

        /// <summary>
        /// (default: "expandVertical") A whitespace-delimited string of animation effects that are used when an item is expanded. Options include "expandVertical" and "fadeIn".
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///$("#panelBar").kendoPanelBar({
        ///    animation: {
        ///        close: {
        ///            duration: 1000,
        ///            effects: "fadeOut"
        ///        }
        ///    }
        ///});
        ///</code>
        ///</example>
        public JsString effects { get; set; }

        /// <summary>
        /// (default: true)
        /// </summary>
        public bool show { get; set; }

    }

    public enum PanelBarExpandModeOptions
    {
        /// <summary>
        /// Display one item at a time when an item is opened; opening an item will close the previously opened item.
        /// </summary>
        single,
        /// <summary>
        /// Display multiple values at one time; opening an item has no visual impact on any other items in the PanelBar.
        /// </summary>
        multiple,
    }

    public class PanelBarContentLoadEventData
    {
        /// <summary>
        /// The selected item
        /// </summary>
        public HtmlElement item { get; set; }

        /// <summary>
        /// The loaded content element
        /// </summary>
        public HtmlElement contentElement { get; set; }
    }

    public class PanelBarErrorEventData
    {
        /// <summary>
        /// The jqXHR object used to load the content
        /// </summary>
        public object xhr { get; set; }
        //TODO: xhr type is jqXHR

        /// <summary>
        /// The returned status.
        /// </summary>
        public JsString status { get; set; }
    }

    public class RangeSlider
    {

        /// <summary>
        /// Prepares the RangeSlider for safe removal from the DOM.
        /// Detaches event handlers and removes data entries in order to avoid memory leaks.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        /// // deatach events
        /// $("#rangeSlider").data("kendoRangeSlider").destroy();
        /// 
        /// // remove slider html from DOM
        /// $("#rangeSlider").closest(".k-slider").remove();
        ///</code>
        ///</example>
        public void destroy() { }

        /// <summary>
        /// Enable/Disable the RangeSlider widget.
        /// </summary>
        /// <param name="enable">The argument, which defines whether to enable/disable the RangeSlider.</param>
        ///<example>
        ///usage
        ///<code>
        /// // get a reference to the range slider widget
        /// var rangeSlider = $("#rangeSlider").data("kendoRangeSlider");
        /// 
        /// // disables the range slider
        /// rangeSlider.enable(false);
        /// 
        /// // enables the range slider
        /// rangeSlider.enable(true);
        ///</code>
        ///</example>
        public void enable(bool enable) { }

        /// <summary>
        /// The value method gets or sets the start and end values of the RangeSlider.
        /// It accepts an array as parameter, and returns an object array with the start and end selection values.
        /// </summary>
        /// <returns></returns>
        ///<example>
        ///usage
        ///<code>
        ///var rangeSider = $("#rangeSlider").data("kendoRangeSlider");
        /// rangeSlider.value();
        ///</code>
        ///</example>
        public JsArray<object> value() { return null; }
        /// <summary>
        /// The value method gets or sets the start and end values of the RangeSlider.
        /// It accepts an array as parameter, and returns an object array with the start and end selection values.
        /// </summary>
        ///<example>
        ///usage
        ///<code>
        ///var rangeSider = $("#rangeSlider").data("kendoRangeSlider");
        /// rangeSlider.value();
        ///</code>
        ///</example>
        public void value(JsArray value) { }
        //TODO: danel check

        /// <summary>
        /// Fires when the rangeSlider value changes as a result of selecting a new value with one of the drag handles or the keyboard.
        /// </summary>
        public event JsAction<RangeSliderEventData> change { add { } remove { } }

        /// <summary>
        /// Fires when the user drags the drag handle to a new position.
        /// </summary>
        public event JsAction<RangeSliderEventData> slide { add { } remove { } }
    }

    public class RangeSliderConfiguration
    {
        /// <summary>
        /// (default: 5) The delta with which the value will change when the user presses the Page Up or Page Down key (the drag handle must be focused).
        /// Note: The allied largeStep will also set large tick for every large step.
        /// </summary>
        public JsNumber largeStep { get; set; }

        /// <summary>
        /// (default: 10) The maximum value of the RangeSlider.
        /// </summary>
        public JsNumber max { get; set; }

        /// <summary>
        /// (default: 0) The minimum value of the RangeSlider.
        /// </summary>
        public JsNumber min { get; set; }

        /// <summary>
        /// (default: "horizontal") F The orientation of a RangeSlider; "horizontal" or "vertical".
        /// </summary>
        public JsString orientation { get; set; }

        /// <summary>
        /// The selection end value of the RangeSlider.
        /// </summary>
        public JsNumber selectionEnd { get; set; }

        /// <summary>
        /// The selection start value of the RangeSlider.
        /// </summary>
        public JsNumber selectionStart { get; set; }

        /// <summary>
        /// (default: 1) The small step value of the RangeSlider. The underlying value will be changed when the end user (1) clicks on the increase
        /// or decrease buttons of the RangeSlider, (2) presses the arrow keys (the drag handle must be focused), or (3) drags the drag handle.
        /// </summary>
        public JsNumber smallStep { get; set; }

        /// <summary>
        /// (default: "both")
        /// Denotes the location of the tick marks in the RangeSlider. The available options are:
        /// "topLeft"
        /// Tick marks are located on the top of the horizontal widget or on the left of the vertical widget.
        /// "bottomRight"
        /// Tick marks are located on the bottom of the horizontal widget or on the right side of the vertical widget.
        /// "both"
        /// Tick marks are located on both sides of the widget.
        /// "none"
        /// Tick marks are not visible.
        /// </summary>
        public RangeSliderTickPlacementOptions tickPlacement { get; set; }

        /// <summary>
        /// Configuration of the RangeSlider tooltip.
        /// </summary>
        public RangeSliderTooltipConfiguration tooltip { get; set; }
    }

    public enum RangeSliderTickPlacementOptions
    {
        /// <summary>
        /// Tick marks are located on the top of the horizontal widget or on the left of the vertical widget.
        /// </summary>
        topLeft,
        /// <summary>
        /// Tick marks are located on the bottom of the horizontal widget or on the right side of the vertical widget.
        /// </summary>
        bottomRight,
        /// <summary>
        /// Tick marks are located on both sides of the widget.
        /// </summary>
        both,
        /// <summary>
        /// Tick marks are not visible.
        /// </summary>
        none,
    }
    public class RangeSliderTooltipConfiguration
    {
        /// <summary>
        /// (default: true) Disables (false) or enables (true) the tooltip of the RangeSlider.
        /// </summary>
        public bool enabled { get; set; }

        /// <summary>
        /// (default: "{0}") Format string for the text of the tooltip. Note: The applied format will also influence the appearance of the RangeSlider tick labels.
        /// </summary>
        public JsString format { get; set; }
    }

    public class RangeSliderEventData
    {
        /// <summary>
        /// Represents the updated array of values of the first and second drag handle.
        /// </summary>
        public JsNumber value { get; set; }
    }

    //TODO: must check all animation Configuration in all classes!!!
}
