//***************************************************
//* This file was generated by tool
//* SharpKit
//***************************************************
using SharpKit.JavaScript;
#region Ext.chart.series
namespace Ext.chart.series
{
    #region Gauge
    /// <summary>
    /// Creates a Gauge Chart. Gauge Charts are used to show progress in a certain variable. There are two ways of using the Gauge chart.
    /// One is setting a store element into the Gauge and selecting the field to be used from that store. Another one is instanciating the
    /// visualization and using the setValue method to adjust the value you want. A chart/series configuration for the Gauge visualization could look like this: {
    /// xtype: &#39;chart&#39;,
    /// store: store,
    /// axes: [{
    /// type: &#39;gauge&#39;,
    /// position: &#39;gauge&#39;,
    /// minimum: 0,
    /// maximum: 100,
    /// steps: 10,
    /// margin: -10
    /// }],
    /// series: [{
    /// type: &#39;gauge&#39;,
    /// field: &#39;data1&#39;,
    /// donut: false,
    /// colorSet: [&#39;#F49D10&#39;, &#39;#ddd&#39;]
    /// }]
    /// }
    /// In this configuration we create a special Gauge axis to be used with the gauge visualization (describing half-circle markers), and also we&#39;re
    /// setting a maximum, minimum and steps configuration options into the axis. The Gauge series configuration contains the store field to be bound to
    /// the visual display and the color set to be used with the visualization.
    /// </summary>
    [JsType(JsMode.Prototype, Export=false)]
    public partial class Gauge : Series, Ext.util.Observable, Ext.chart.Label, Highlight, Ext.chart.Tip, Callout
    {
        /// <summary>
        /// Draws the series for the current chart. ...
        /// </summary>
        public object drawSeries(){return null;}
        /// <summary>
        /// Returns the color of the series (to be displayed as color for the series legend item). ...
        /// </summary>
        public new object getLegendColor(object item){return null;}
        /// <summary>
        /// Sets the Gauge chart to the current specified value. ...
        /// </summary>
        public object setValue(object value){return null;}
        public Gauge(Ext.chart.series.GaugeConfig config){}
        public Gauge(){}
    }
    #endregion
    #region GaugeConfig
    [JsType(JsMode.Json, Export=false)]
    public partial class GaugeConfig : SeriesConfig
    {
        /// <summary>
        /// The store record field name to be used for the pie angles. ...
        /// </summary>
        public JsString angleField{get;set;}
        /// <summary>
        /// Use the entire disk or just a fraction of it for the gauge. ...
        /// </summary>
        public object donut{get;set;}
        public JsNumber highlightDuration{get;set;}
        /// <summary>
        /// Use the Gauge Series as an area series or add a needle to it. ...
        /// </summary>
        public bool needle{get;set;}
        /// <summary>
        /// Whether to add the pie chart elements as legend items. ...
        /// </summary>
        public new bool showInLegend{get;set;}
        public object style{get;set;}
    }
    #endregion
    #region GaugeEvents
    [JsType(JsMode.Json, Export=false)]
    public partial class GaugeEvents : SeriesEvents
    {
    }
    #endregion
}
#endregion
