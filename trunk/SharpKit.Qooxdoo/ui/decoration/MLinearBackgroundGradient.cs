// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.ui.decoration
{
    /// <summary>
	/// <para>Mixin for the linear background gradient CSS property.
	/// This mixin is usually used by <see cref="qx.ui.decoration.DynamicDecorator"/>.</para>
	/// <para>Keep in mind that this is not supported by all browsers:</para>
	/// <list type="bullet">
	/// <item>Safari 4.0+</item>
	/// <item>Chrome 4.0+</item>
	/// <item>Firefox 3.6+</item>
	/// <item>Opera 11.1+</item>
	/// <item>IE 10+</item>
	/// <item>IE 5.5+ (with limitations)</item>
	/// </list
	/// <para>For IE 5.5 to IE 9,this class uses the filter rules to create the gradient. This
	/// has some limitations: The start and end position property can not be used. For
	/// more details, see the original documentation:
	/// http://msdn.microsoft.com/en-us/library/ms532997(v=vs.85).aspx</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.ui.decoration.MLinearBackgroundGradient", OmitOptionalParameters = true, Export = false)]
    public partial class MLinearBackgroundGradient 
    {
		#region Properties

		/// <summary>
		/// <para>Defines if the given positions are in % or px.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "px","%"
		/// </remarks>
		[JsProperty(Name = "colorPositionUnit", NativeField = true)]
		public object ColorPositionUnit { get; set; }

		/// <summary>
		/// <para>End end color of the background</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "endColor", NativeField = true)]
		public string EndColor { get; set; }

		/// <summary>
		/// <para>Position in percent where to start the color.</para>
		/// </summary>
		[JsProperty(Name = "endColorPosition", NativeField = true)]
		public double EndColorPosition { get; set; }

		/// <summary>
		/// <para>Property group to set the end color including its end position.</para>
		/// </summary>
		[JsProperty(Name = "gradientEnd", NativeField = true)]
		public object GradientEnd { get; set; }

		/// <summary>
		/// <para>Property group to set the start color including its start position.</para>
		/// </summary>
		[JsProperty(Name = "gradientStart", NativeField = true)]
		public object GradientStart { get; set; }

		/// <summary>
		/// <para>The orientation of the gradient.</para>
		/// </summary>
		/// <remarks>
		/// Possible values: "horizontal","vertical"
		/// </remarks>
		[JsProperty(Name = "orientation", NativeField = true)]
		public object Orientation { get; set; }

		/// <summary>
		/// <para>Start start color of the background</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "startColor", NativeField = true)]
		public string StartColor { get; set; }

		/// <summary>
		/// <para>Position in percent where to start the color.</para>
		/// </summary>
		[JsProperty(Name = "startColorPosition", NativeField = true)]
		public double StartColorPosition { get; set; }

		#endregion Properties

		#region Methods

		public MLinearBackgroundGradient() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property colorPositionUnit.</para>
		/// </summary>
		[JsMethod(Name = "getColorPositionUnit")]
		public object GetColorPositionUnit() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property endColor.</para>
		/// </summary>
		[JsMethod(Name = "getEndColor")]
		public string GetEndColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property endColorPosition.</para>
		/// </summary>
		[JsMethod(Name = "getEndColorPosition")]
		public double GetEndColorPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property orientation.</para>
		/// </summary>
		[JsMethod(Name = "getOrientation")]
		public object GetOrientation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property startColor.</para>
		/// </summary>
		[JsMethod(Name = "getStartColor")]
		public string GetStartColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property startColorPosition.</para>
		/// </summary>
		[JsMethod(Name = "getStartColorPosition")]
		public double GetStartColorPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property colorPositionUnit
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property colorPositionUnit.</param>
		[JsMethod(Name = "initColorPositionUnit")]
		public void InitColorPositionUnit(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property endColor
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property endColor.</param>
		[JsMethod(Name = "initEndColor")]
		public void InitEndColor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property endColorPosition
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property endColorPosition.</param>
		[JsMethod(Name = "initEndColorPosition")]
		public void InitEndColorPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property orientation
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property orientation.</param>
		[JsMethod(Name = "initOrientation")]
		public void InitOrientation(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property startColor
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property startColor.</param>
		[JsMethod(Name = "initStartColor")]
		public void InitStartColor(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property startColorPosition
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property startColorPosition.</param>
		[JsMethod(Name = "initStartColorPosition")]
		public void InitStartColorPosition(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property colorPositionUnit.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetColorPositionUnit")]
		public void ResetColorPositionUnit() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property endColor.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetEndColor")]
		public void ResetEndColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property endColorPosition.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetEndColorPosition")]
		public void ResetEndColorPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property gradientEnd.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGradientEnd")]
		public void ResetGradientEnd() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property gradientStart.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetGradientStart")]
		public void ResetGradientStart() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property orientation.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetOrientation")]
		public void ResetOrientation() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property startColor.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetStartColor")]
		public void ResetStartColor() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property startColorPosition.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetStartColorPosition")]
		public void ResetStartColorPosition() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property colorPositionUnit.</para>
		/// </summary>
		/// <param name="value">New value for property colorPositionUnit.</param>
		[JsMethod(Name = "setColorPositionUnit")]
		public void SetColorPositionUnit(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property endColor.</para>
		/// </summary>
		/// <param name="value">New value for property endColor.</param>
		[JsMethod(Name = "setEndColor")]
		public void SetEndColor(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property endColorPosition.</para>
		/// </summary>
		/// <param name="value">New value for property endColorPosition.</param>
		[JsMethod(Name = "setEndColorPosition")]
		public void SetEndColorPosition(double value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group gradientEnd.</para>
		/// <para>This setter supports a shorthand mode compatible with the way margins and paddins are set in CSS.</para>
		/// </summary>
		/// <param name="endColor">Sets the value of the property #endColor.</param>
		/// <param name="endColorPosition">Sets the value of the property #endColorPosition.</param>
		[JsMethod(Name = "setGradientEnd")]
		public void SetGradientEnd(object endColor, object endColorPosition) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the values of the property group gradientStart.</para>
		/// <para>This setter supports a shorthand mode compatible with the way margins and paddins are set in CSS.</para>
		/// </summary>
		/// <param name="startColor">Sets the value of the property #startColor.</param>
		/// <param name="startColorPosition">Sets the value of the property #startColorPosition.</param>
		[JsMethod(Name = "setGradientStart")]
		public void SetGradientStart(object startColor, object startColorPosition) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property orientation.</para>
		/// </summary>
		/// <param name="value">New value for property orientation.</param>
		[JsMethod(Name = "setOrientation")]
		public void SetOrientation(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property startColor.</para>
		/// </summary>
		/// <param name="value">New value for property startColor.</param>
		[JsMethod(Name = "setStartColor")]
		public void SetStartColor(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property startColorPosition.</para>
		/// </summary>
		/// <param name="value">New value for property startColorPosition.</param>
		[JsMethod(Name = "setStartColorPosition")]
		public void SetStartColorPosition(double value) { throw new NotImplementedException(); }

		#endregion Methods
    }
}