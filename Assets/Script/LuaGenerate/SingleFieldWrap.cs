﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class SingleFieldWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(SingleField), typeof(System.Object));
		L.RegFunction("Reset", Reset);
		L.RegFunction("GetShowString", GetShowString);
		L.RegFunction("GetInt", GetInt);
		L.RegFunction("GetFloat", GetFloat);
		L.RegFunction("GetBool", GetBool);
		L.RegFunction("GetString", GetString);
		L.RegFunction("GetStringArray", GetStringArray);
		L.RegFunction("GetVector2", GetVector2);
		L.RegFunction("GetVector3", GetVector3);
		L.RegFunction("GetColor", GetColor);
		L.RegFunction("GetEnum", GetEnum);
		L.RegFunction("GetEnumType", GetEnumType);
		L.RegFunction("New", _CreateSingleField);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("m_type", get_m_type, set_m_type);
		L.RegVar("m_content", get_m_content, set_m_content);
		L.RegVar("m_enumType", get_m_enumType, set_m_enumType);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateSingleField(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				SingleField obj = new SingleField();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Vector2)))
			{
				UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 1);
				SingleField obj = new SingleField(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Vector3)))
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				SingleField obj = new SingleField(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(UnityEngine.Color)))
			{
				UnityEngine.Color arg0 = ToLua.ToColor(L, 1);
				SingleField obj = new SingleField(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(bool)))
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				SingleField obj = new SingleField(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.CheckString(L, 1);
				SingleField obj = new SingleField(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(float)))
			{
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 1);
				SingleField obj = new SingleField(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes(L, 1, typeof(FieldType), typeof(string), typeof(string)))
			{
				FieldType arg0 = (FieldType)ToLua.CheckObject(L, 1, typeof(FieldType));
				string arg1 = ToLua.CheckString(L, 2);
				string arg2 = ToLua.CheckString(L, 3);
				SingleField obj = new SingleField(arg0, arg1, arg2);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: SingleField.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			obj.Reset();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetShowString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			string o = obj.GetShowString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetInt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			int o = obj.GetInt();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetFloat(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			float o = obj.GetFloat();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBool(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			bool o = obj.GetBool();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetString(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			string o = obj.GetString();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetStringArray(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			string[] o = obj.GetStringArray();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVector2(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			UnityEngine.Vector2 o = obj.GetVector2();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetVector3(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			UnityEngine.Vector3 o = obj.GetVector3();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetColor(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			UnityEngine.Color o = obj.GetColor();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnum(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			System.Enum o = obj.GetEnum();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetEnumType(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			SingleField obj = (SingleField)ToLua.CheckObject(L, 1, typeof(SingleField));
			System.Type o = obj.GetEnumType();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SingleField obj = (SingleField)o;
			FieldType ret = obj.m_type;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_type on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_content(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SingleField obj = (SingleField)o;
			string ret = obj.m_content;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_content on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_m_enumType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SingleField obj = (SingleField)o;
			string ret = obj.m_enumType;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_enumType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SingleField obj = (SingleField)o;
			FieldType arg0 = (FieldType)ToLua.CheckObject(L, 2, typeof(FieldType));
			obj.m_type = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_type on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_content(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SingleField obj = (SingleField)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.m_content = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_content on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_m_enumType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			SingleField obj = (SingleField)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.m_enumType = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index m_enumType on a nil value" : e.Message);
		}
	}
}

