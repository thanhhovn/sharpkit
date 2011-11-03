using SharpKit.JavaScript;
//AutoGenerated

namespace org.w3c.dom.events
{

    using Node = org.w3c.dom.Node;

    public interface MutationEvent : Event
    {
        // MutationEvent
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short MODIFICATION = 1;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short ADDITION = 2;
//TODO: Interfaces cannot contain fields in .NET:
//        public static final short REMOVAL = 3;
        Node relatedNode {get;}
        JsString prevValue {get;}
        JsString newValue {get;}
        JsString attrName {get;}
        short attrChange {get;}
        void initMutationEvent(string typeArg, bool canBubbleArg, bool cancelableArg, Node relatedNodeArg, JsString prevValueArg, JsString newValueArg, JsString attrNameArg, short attrChangeArg);
    }

}