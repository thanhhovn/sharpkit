﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SharpKit.Html4;
using SharpKit.JavaScript;


namespace THREE
{
    [JsType(JsMode.Prototype, Export = false)]
    public class Vector3
    {
        public Vector3(JsNumber x, JsNumber y, JsNumber z, JsNumber w) { }

        public JsNumber x { get; set; }
        public JsNumber y { get; set; }
        public JsNumber z { get; set; }
        public JsNumber w { get; set; }

        public Vector3 set(JsNumber x, JsNumber y, JsNumber z, JsNumber w) { return null; }
        public Vector3 setX(JsNumber x) { return null; }
        public Vector3 setY(JsNumber y) { return null; }
        public Vector3 setZ(JsNumber z) { return null; }
        public Vector3 copy(Vector3 v) { return null; }
        public Vector3 clone() { return null; }
        public Vector3 add(Vector3 v1, Vector3 v2) { return null; }
        public Vector3 addSelf(Vector3 v) { return null; }
        public Vector3 addScalar(JsNumber s) { return null; }
        public Vector3 sub(Vector3 v1, Vector3 v2) { return null; }
        public Vector3 subSelf(Vector3 v) { return null; }
        public Vector3 multiplySelf(Vector3 v) { return null; }
        public Vector3 multiplyScalar(JsNumber s) { return null; }
        public Vector3 divideSelf(Vector3 v) { return null; }
        public Vector3 divideScalar(JsNumber s) { return null; }
        public Vector3 negate(Vector3 v) { return null; }
        public JsNumber dot(Vector3 v) { return 0; }
        public JsNumber lengthSq() { return 0; }
        public JsNumber length() { return 0; }
        public JsNumber lengthManhattan() { return 0; }
        public Vector3 normalize() { return null; }
        public Vector3 setLength(JsNumber l) { return null; }
        public Vector3 lerpSelf(Vector3 v, JsNumber a) { return null; }
        public Vector3 cross(Vector3 a, Vector3 b) { return null; }
        public Vector3 crossSelf(Vector3 v) { return null; }
        public JsNumber distanceTo(Vector3 v) { return 0; }
        public JsNumber distanceToSquared(Vector3 v) { return 0; }
        public Vector3 getPositionFromMatrix(Matrix4 v) { return null; }
        public Vector3 getRotationFromMatrix(Matrix4 v) { return null; }
        public Vector3 getScaleFromMatrix(Matrix4 v) { return null; }
        public JsBoolean equals(Vector3 v) { return true; }
        public JsBoolean isZero() { return true; }
    }
}