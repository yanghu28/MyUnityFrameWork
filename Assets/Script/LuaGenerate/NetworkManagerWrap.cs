﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NetworkManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NetworkManager), typeof(System.Object));
		L.RegFunction("Init", Init);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("SetServer", SetServer);
		L.RegFunction("Connect", Connect);
		L.RegFunction("DisConnect", DisConnect);
		L.RegFunction("SendMessage", SendMessage);
		L.RegFunction("New", _CreateNetworkManager);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("IsConnect", get_IsConnect, set_IsConnect);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateNetworkManager(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				NetworkManager obj = new NetworkManager();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: NetworkManager.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Init(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			NetworkManager.Init(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			NetworkManager.Dispose();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetServer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			string arg0 = ToLua.CheckString(L, 1);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
			NetworkManager.SetServer(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Connect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			NetworkManager.Connect();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DisConnect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			NetworkManager.DisConnect();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SendMessage(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(System.Collections.Generic.Dictionary<string,object>)))
			{
				System.Collections.Generic.Dictionary<string,object> arg0 = (System.Collections.Generic.Dictionary<string,object>)ToLua.ToObject(L, 1);
				NetworkManager.SendMessage(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes(L, 1, typeof(string), typeof(System.Collections.Generic.Dictionary<string,object>)))
			{
				string arg0 = ToLua.ToString(L, 1);
				System.Collections.Generic.Dictionary<string,object> arg1 = (System.Collections.Generic.Dictionary<string,object>)ToLua.ToObject(L, 2);
				NetworkManager.SendMessage(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: NetworkManager.SendMessage");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsConnect(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, NetworkManager.IsConnect);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsConnect(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			NetworkManager.IsConnect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

