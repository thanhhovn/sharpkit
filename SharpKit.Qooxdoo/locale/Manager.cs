// Generated by SharpKit.QooxDoo.Generator
using System;
using System.Collections.Generic;
using SharpKit.Html;
using SharpKit.JavaScript;

namespace qx.locale
{
    /// <summary>
	/// <para>The qx.locale.Manager provides static translation methods (like tr()) and
	/// general locale information.</para>
	/// </summary>
	[JsType(JsMode.Prototype, Name = "qx.locale.Manager", OmitOptionalParameters = true, Export = false)]
    public partial class Manager : qx.core.Object
    {
		#region Events

		/// <summary>
		/// Fired on change of the property <see cref="Locale"/>.
		/// </summary>
		public event Action<qx.eventx.type.Data> OnChangeLocale;

		#endregion Events

		#region Properties

		/// <summary>
		/// <para>current locale. locale is an language code like de, de_AT, en, en_GB, fr, ...</para>
		/// </summary>
		/// <remarks>
		/// Allow nulls: true
		/// </remarks>
		[JsProperty(Name = "locale", NativeField = true)]
		public string Locale { get; set; }

		#endregion Properties

		#region Methods

		public Manager() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns a singleton instance of this class. On the first call the class
		/// is instantiated by calling the constructor with no arguments. All following
		/// calls will return this instance.</para>
		/// <para>This method has been added by setting the &#8220;type&#8221; key in the class definition
		/// (<see cref="qx.Class.Define"/>) to &#8220;singleton&#8221;.</para>
		/// </summary>
		/// <returns>The singleton instance of this class.</returns>
		[JsMethod(Name = "getInstance")]
		public static qx.locale.Manager GetInstance() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Mark the message for translation but return the original message.</para>
		/// </summary>
		/// <param name="messageId">the message ID</param>
		/// <returns>messageId</returns>
		[JsMethod(Name = "marktr")]
		public static string Marktr(string messageId) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Translate a message</para>
		/// </summary>
		/// <param name="messageId">message id (may contain format strings)</param>
		/// <param name="varargs">variable number of arguments applied to the format string</param>
		/// <returns>The translated message or localized string</returns>
		[JsMethod(Name = "tr")]
		public static object Tr(string messageId, object varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Translate a message with translation hint</para>
		/// </summary>
		/// <param name="hint">hint for the translator of the message. Will be included in the .po file.</param>
		/// <param name="messageId">message id (may contain format strings)</param>
		/// <param name="varargs">variable number of arguments applied to the format string</param>
		/// <returns>The translated message or localized string</returns>
		[JsMethod(Name = "trc")]
		public static object Trc(string hint, string messageId, object varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Translate a plural message</para>
		/// <para>Depending on the third argument the plural or the singular form is chosen.</para>
		/// </summary>
		/// <param name="singularMessageId">message id of the singular form (may contain format strings)</param>
		/// <param name="pluralMessageId">message id of the plural form (may contain format strings)</param>
		/// <param name="count">singular form if equals 1, otherwise plural</param>
		/// <param name="varargs">variable number of arguments applied to the format string</param>
		/// <returns>The translated message or localized string</returns>
		[JsMethod(Name = "trn")]
		public static object Trn(string singularMessageId, string pluralMessageId, double count, object varargs) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a localization to the localization manager.</para>
		/// <para>If localeCode already exists, its map will be updated with
		/// localeMap (new keys will be added, existing keys will be overwritten).</para>
		/// </summary>
		/// <param name="localeCode">locale code of the translation like de, de_AT, en, en_GB, fr, ...</param>
		/// <param name="localeMap">mapping of locale keys to the target locale values, e.g. {&#8220;cldr_date_format_short&#8221; : &#8220;M/d/yy&#8221;}.</param>
		[JsMethod(Name = "addLocale")]
		public void AddLocale(string localeCode, object localeMap) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Add a translation to the translation manager.</para>
		/// <para>If languageCode already exists, its map will be updated with
		/// translationMap (new keys will be added, existing keys will be
		/// overwritten).</para>
		/// </summary>
		/// <param name="languageCode">language code of the translation like de, de_AT, en, en_GB, fr, ...</param>
		/// <param name="translationMap">mapping of message identifiers to message strings in the target language, e.g. {&#8220;greeting_short&#8221; : &#8220;Hello&#8221;}. Plural forms are separate keys.</param>
		[JsMethod(Name = "addTranslation")]
		public void AddTranslation(string languageCode, object translationMap) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Return the available application locales</para>
		/// <para>This corresponds to the LOCALES setting in config.json. Without argument,
		/// it only returns the currently loaded locales, with an argument of true
		/// all locales that went into the build. This is particularly interesting if
		/// locales were generated as dedicated I18N parts, and have to be loaded
		/// explicitly before being available.</para>
		/// </summary>
		/// <param name="includeNonloaded">include locales not yet loaded</param>
		/// <returns>array of available locales</returns>
		[JsMethod(Name = "getAvailableLocales")]
		public string GetAvailableLocales(bool? includeNonloaded = null) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the language code of the current locale</para>
		/// <para>This is the first part of a locale definition. The language for &#8220;de_DE&#8221; would be &#8220;de&#8221;</para>
		/// </summary>
		/// <returns>language code</returns>
		[JsMethod(Name = "getLanguage")]
		public string GetLanguage() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Returns the (computed) value of the property locale.</para>
		/// </summary>
		[JsMethod(Name = "getLocale")]
		public string GetLocale() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Get the territory code of the current locale</para>
		/// <para>This is the second part of a locale definition. The territory for &#8220;de_DE&#8221; would be &#8220;DE&#8221;</para>
		/// </summary>
		/// <returns>territory code</returns>
		[JsMethod(Name = "getTerritory")]
		public string GetTerritory() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Calls the apply method and dispatches the change event of the property locale
		/// with the default value defined by the class developer. This function can
		/// only be called from the constructor of a class.</para>
		/// </summary>
		/// <param name="value">Initial value for property locale.</param>
		[JsMethod(Name = "initLocale")]
		public void InitLocale(object value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Provide localisation (CLDR) data.</para>
		/// <para>Implements the lookup chain locale (e.g. en_US) -> language (e.g. en) ->
		/// default locale (e.g. C). Localizes the arguments if possible and splices
		/// them into the message. If qx.dynlocale is on, returns a {@link
		/// LocalizedString}.</para>
		/// </summary>
		/// <param name="messageId">message id (may contain format strings)</param>
		/// <param name="args">array of objects, which are inserted into the format string</param>
		/// <param name="locale">locale to be used; if not given, defaults to the value of #locale</param>
		/// <returns>translated message or localized string</returns>
		[JsMethod(Name = "localize")]
		public object Localize(string messageId, object args, string locale = "#locale") { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Resets the user value of the property locale.</para>
		/// <para>The computed value falls back to the next available value e.g. appearance, init or
		/// inheritance value depeneding on the property configuration and value availability.</para>
		/// </summary>
		[JsMethod(Name = "resetLocale")]
		public void ResetLocale() { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Sets the user value of the property locale.</para>
		/// </summary>
		/// <param name="value">New value for property locale.</param>
		[JsMethod(Name = "setLocale")]
		public void SetLocale(string value) { throw new NotImplementedException(); }

		/// <summary>
		/// <para>Translate a message using the current locale and apply format string to the arguments.</para>
		/// <para>Implements the lookup chain locale (e.g. en_US) -> language (e.g. en) ->
		/// default locale (e.g. C). Localizes the arguments if possible and splices
		/// them into the message. If qx.dynlocale is on, returns a {@link
		/// LocalizedString}.</para>
		/// </summary>
		/// <param name="messageId">message id (may contain format strings)</param>
		/// <param name="args">array of objects, which are inserted into the format string</param>
		/// <param name="locale">locale to be used; if not given, defaults to the value of #locale</param>
		/// <returns>translated message or localized string</returns>
		[JsMethod(Name = "translate")]
		public object Translate(string messageId, object args, string locale = "#locale") { throw new NotImplementedException(); }

		#endregion Methods
    }
}