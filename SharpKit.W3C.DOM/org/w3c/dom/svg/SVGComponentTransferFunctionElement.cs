//Generated by a tool of Sebastian Loncar

namespace org.w3c.dom.svg
{

using SharpKit.JavaScript;

[JsType(JsMode.Prototype, Export = false, PropertiesAsFields=true, OmitCasts = true)]
public partial class SVGComponentTransferFunctionElement : SVGElement
{

	// SVGComponentTransferFunctionElement
	public static short SVG_FECOMPONENTTRANSFER_TYPE_UNKNOWN = 0;
	public static short SVG_FECOMPONENTTRANSFER_TYPE_IDENTITY = 1;
	public static short SVG_FECOMPONENTTRANSFER_TYPE_TABLE = 2;
	public static short SVG_FECOMPONENTTRANSFER_TYPE_DISCRETE = 3;
	public static short SVG_FECOMPONENTTRANSFER_TYPE_LINEAR = 4;
	public static short SVG_FECOMPONENTTRANSFER_TYPE_GAMMA = 5;
	public SVGAnimatedEnumeration type {get { return default(SVGAnimatedEnumeration); } }
	public SVGAnimatedNumberList tableValues {get { return default(SVGAnimatedNumberList); } }
	public SVGAnimatedNumber slope {get { return default(SVGAnimatedNumber); } }
	public SVGAnimatedNumber intercept {get { return default(SVGAnimatedNumber); } }
	public SVGAnimatedNumber amplitude {get { return default(SVGAnimatedNumber); } }
	public SVGAnimatedNumber exponent {get { return default(SVGAnimatedNumber); } }
	public SVGAnimatedNumber offset {get { return default(SVGAnimatedNumber); } }
}

}