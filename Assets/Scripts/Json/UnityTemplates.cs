using UnityEngine;

namespace Matt.Json
{
	public static partial class JsonTemplates
	{
		/*
		 * Vector2
		 */
		public static Vector2 ToVector2(JsonObject obj)
		{
			float x = obj["x"] ? obj["x"].f : 0;
			float y = obj["y"] ? obj["y"].f : 0;
			return new Vector2(x, y);
		}
		public static JsonObject ToJson(Vector2 v)
		{
			JsonObject vdata = JsonObject.obj;
			if (v.x != 0) vdata.AddField("x", v.x);
			if (v.y != 0) vdata.AddField("y", v.y);
			return vdata;
		}
		/*
		 * Vector3
		 */
		public static Vector3 ToVector3(JsonObject obj)
		{
			float x = obj["x"] ? obj["x"].f : 0;
			float y = obj["y"] ? obj["y"].f : 0;
			float z = obj["z"] ? obj["z"].f : 0;
			return new Vector3(x, y, z);
		}
		public static JsonObject ToJson(Vector3 v)
		{
			JsonObject vdata = JsonObject.obj;
			if (v.x != 0) vdata.AddField("x", v.x);
			if (v.y != 0) vdata.AddField("y", v.y);
			if (v.z != 0) vdata.AddField("z", v.z);
			return vdata;
		}
		/*
		 * Vector4
		 */
		public static Vector4 ToVector4(JsonObject obj)
		{
			float x = obj["x"] ? obj["x"].f : 0;
			float y = obj["y"] ? obj["y"].f : 0;
			float z = obj["z"] ? obj["z"].f : 0;
			float w = obj["w"] ? obj["w"].f : 0;
			return new Vector4(x, y, z, w);
		}
		public static JsonObject ToJson(Vector4 v)
		{
			JsonObject vdata = JsonObject.obj;
			if (v.x != 0) vdata.AddField("x", v.x);
			if (v.y != 0) vdata.AddField("y", v.y);
			if (v.z != 0) vdata.AddField("z", v.z);
			if (v.w != 0) vdata.AddField("w", v.w);
			return vdata;
		}
		/*
		 * Matrix4x4
		 */
		public static Matrix4x4 ToMatrix4x4(JsonObject obj)
		{
			Matrix4x4 result = new Matrix4x4();
			if (obj["m00"]) result.m00 = obj["m00"].f;
			if (obj["m01"]) result.m01 = obj["m01"].f;
			if (obj["m02"]) result.m02 = obj["m02"].f;
			if (obj["m03"]) result.m03 = obj["m03"].f;
			if (obj["m10"]) result.m10 = obj["m10"].f;
			if (obj["m11"]) result.m11 = obj["m11"].f;
			if (obj["m12"]) result.m12 = obj["m12"].f;
			if (obj["m13"]) result.m13 = obj["m13"].f;
			if (obj["m20"]) result.m20 = obj["m20"].f;
			if (obj["m21"]) result.m21 = obj["m21"].f;
			if (obj["m22"]) result.m22 = obj["m22"].f;
			if (obj["m23"]) result.m23 = obj["m23"].f;
			if (obj["m30"]) result.m30 = obj["m30"].f;
			if (obj["m31"]) result.m31 = obj["m31"].f;
			if (obj["m32"]) result.m32 = obj["m32"].f;
			if (obj["m33"]) result.m33 = obj["m33"].f;
			return result;
		}
		public static JsonObject ToJson(Matrix4x4 m)
		{
			JsonObject mdata = JsonObject.obj;
			if (m.m00 != 0) mdata.AddField("m00", m.m00);
			if (m.m01 != 0) mdata.AddField("m01", m.m01);
			if (m.m02 != 0) mdata.AddField("m02", m.m02);
			if (m.m03 != 0) mdata.AddField("m03", m.m03);
			if (m.m10 != 0) mdata.AddField("m10", m.m10);
			if (m.m11 != 0) mdata.AddField("m11", m.m11);
			if (m.m12 != 0) mdata.AddField("m12", m.m12);
			if (m.m13 != 0) mdata.AddField("m13", m.m13);
			if (m.m20 != 0) mdata.AddField("m20", m.m20);
			if (m.m21 != 0) mdata.AddField("m21", m.m21);
			if (m.m22 != 0) mdata.AddField("m22", m.m22);
			if (m.m23 != 0) mdata.AddField("m23", m.m23);
			if (m.m30 != 0) mdata.AddField("m30", m.m30);
			if (m.m31 != 0) mdata.AddField("m31", m.m31);
			if (m.m32 != 0) mdata.AddField("m32", m.m32);
			if (m.m33 != 0) mdata.AddField("m33", m.m33);
			return mdata;
		}
		/*
		 * Quaternion
		 */
		public static Quaternion ToQuaternion(JsonObject obj)
		{
			float x = obj["x"] ? obj["x"].f : 0;
			float y = obj["y"] ? obj["y"].f : 0;
			float z = obj["z"] ? obj["z"].f : 0;
			float w = obj["w"] ? obj["w"].f : 0;
			return new Quaternion(x, y, z, w);
		}
		public static JsonObject ToJson(Quaternion q)
		{
			JsonObject qdata = JsonObject.obj;
			if (q.w != 0) qdata.AddField("w", q.w);
			if (q.x != 0) qdata.AddField("x", q.x);
			if (q.y != 0) qdata.AddField("y", q.y);
			if (q.z != 0) qdata.AddField("z", q.z);
			return qdata;
		}
		/*
		 * Colour
		 */
		public static Color ToColour(JsonObject obj)
		{
			Color c = new Color();
			for (int i = 0; i < obj.Count; i++)
			{
				switch (obj.keys[i])
				{
					case "r": c.r = obj[i].f; break;
					case "g": c.g = obj[i].f; break;
					case "b": c.b = obj[i].f; break;
					case "a": c.a = obj[i].f; break;
				}
			}
			return c;
		}
		public static JsonObject ToColour(Color c)
		{
			JsonObject cdata = JsonObject.obj;
			if (c.r != 0) cdata.AddField("r", c.r);
			if (c.g != 0) cdata.AddField("g", c.g);
			if (c.b != 0) cdata.AddField("b", c.b);
			if (c.a != 0) cdata.AddField("a", c.a);
			return cdata;
		}
		/*
		 * Layer Mask
		 */
		public static LayerMask ToLayerMask(JsonObject obj)
		{
			LayerMask l = new LayerMask { value = (int)obj["value"].n };
			return l;
		}
		public static JsonObject ToJson(LayerMask l)
		{
			JsonObject result = JsonObject.obj;
			result.AddField("value", l.value);
			return result;
		}
		/*
		 * Rect
		 */
		public static Rect ToRect(JsonObject obj)
		{
			Rect r = new Rect();
			for (int i = 0; i < obj.Count; i++)
			{
				switch (obj.keys[i])
				{
					case "x": r.x = obj[i].f; break;
					case "y": r.y = obj[i].f; break;
					case "height": r.height = obj[i].f; break;
					case "width": r.width = obj[i].f; break;
				}
			}
			return r;
		}
		public static JsonObject ToJson(Rect r)
		{
			JsonObject result = JsonObject.obj;
			if (r.x != 0) result.AddField("x", r.x);
			if (r.y != 0) result.AddField("y", r.y);
			if (r.height != 0) result.AddField("height", r.height);
			if (r.width != 0) result.AddField("width", r.width);
			return result;
		}
		/*
		 * Rect Offset
		 */
		public static RectOffset ToRectOffset(JsonObject obj)
		{
			RectOffset r = new RectOffset();
			for (int i = 0; i < obj.Count; i++)
			{
				switch (obj.keys[i])
				{
					case "bottom": r.bottom = (int)obj[i].n; break;
					case "left": r.left = (int)obj[i].n; break;
					case "right": r.right = (int)obj[i].n; break;
					case "top": r.top = (int)obj[i].n; break;
				}
			}
			return r;
		}
		public static JsonObject ToJson(RectOffset r)
		{
			JsonObject result = JsonObject.obj;
			if (r.bottom != 0) result.AddField("bottom", r.bottom);
			if (r.left != 0) result.AddField("left", r.left);
			if (r.right != 0) result.AddField("right", r.right);
			if (r.top != 0) result.AddField("top", r.top);
			return result;
		}
		/*
		 * Animation Curve
		 */
		public static AnimationCurve ToAnimationCurve(JsonObject obj)
		{
			AnimationCurve a = new AnimationCurve();
			if (obj.HasField("keys"))
			{
				JsonObject keys = obj.GetField("keys");
				for (int i = 0; i < keys.list.Count; i++)
				{
					a.AddKey(ToKeyframe(keys[i]));
				}
			}
			if (obj.HasField("preWrapMode"))
				a.preWrapMode = (WrapMode)((int)obj.GetField("preWrapMode").n);
			if (obj.HasField("postWrapMode"))
				a.postWrapMode = (WrapMode)((int)obj.GetField("postWrapMode").n);
			return a;
		}
		public static JsonObject ToJson(AnimationCurve a)
		{
			JsonObject result = JsonObject.obj;
			result.AddField("preWrapMode", a.preWrapMode.ToString());
			result.AddField("postWrapMode", a.postWrapMode.ToString());
			if (a.keys.Length > 0)
			{
				JsonObject keysJSON = JsonObject.Create();
				for (int i = 0; i < a.keys.Length; i++)
				{
					keysJSON.Add(ToJson(a.keys[i]));
				}
				result.AddField("keys", keysJSON);
			}
			return result;
		}
		/*
		 * Key Frame
		 */
		public static Keyframe ToKeyframe(JsonObject obj)
		{
			Keyframe k = new Keyframe(obj.HasField("time") ? obj.GetField("time").n : 0, obj.HasField("value") ? obj.GetField("value").n : 0);
			if (obj.HasField("inTangent")) k.inTangent = obj.GetField("inTangent").n;
			if (obj.HasField("outTangent")) k.outTangent = obj.GetField("outTangent").n;
			if (obj.HasField("tangentMode")) k.tangentMode = (int)obj.GetField("tangentMode").n;

			return k;
		}
		public static JsonObject ToJson(Keyframe k)
		{
			JsonObject result = JsonObject.obj;
			if (k.inTangent != 0) result.AddField("inTangent", k.inTangent);
			if (k.outTangent != 0) result.AddField("outTangent", k.outTangent);
			if (k.tangentMode != 0) result.AddField("tangentMode", k.tangentMode);
			if (k.time != 0) result.AddField("time", k.time);
			if (k.value != 0) result.AddField("value", k.value);
			return result;
		}
	}
}
