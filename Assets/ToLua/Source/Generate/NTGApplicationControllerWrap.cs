﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class NTGApplicationControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(NTGApplicationController), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetType", GetType);
		L.RegFunction("SetShowQuality", SetShowQuality);
		L.RegFunction("LuaDoFile", LuaDoFile);
		L.RegFunction("LuaCall", LuaCall);
		L.RegFunction("LuaGetFunction", LuaGetFunction);
		L.RegFunction("LuaGetTable", LuaGetTable);
		L.RegFunction("RemoveTableCache", RemoveTableCache);
		L.RegFunction("LuaReleaseTable", LuaReleaseTable);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Initialized", get_Initialized, set_Initialized);
		L.RegVar("panelRoot", get_panelRoot, set_panelRoot);
		L.RegVar("gameRoot", get_gameRoot, set_gameRoot);
		L.RegVar("standaloneInputModule", get_standaloneInputModule, set_standaloneInputModule);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetType(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(NTGApplicationController)))
			{
				NTGApplicationController obj = (NTGApplicationController)ToLua.ToObject(L, 1);
				System.Type o = obj.GetType();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes(L, 1, typeof(string)))
			{
				string arg0 = ToLua.ToString(L, 1);
				System.Type o = NTGApplicationController.GetType(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: NTGApplicationController.GetType");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetShowQuality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
			NTGApplicationController.SetShowQuality(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaDoFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NTGApplicationController obj = (NTGApplicationController)ToLua.CheckObject(L, 1, typeof(NTGApplicationController));
			string arg0 = ToLua.CheckString(L, 2);
			object[] o = obj.LuaDoFile(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaCall(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			NTGApplicationController obj = (NTGApplicationController)ToLua.CheckObject(L, 1, typeof(NTGApplicationController));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			object[] arg2 = ToLua.ToParamsObject(L, 4, count - 3);
			object[] o = obj.LuaCall(arg0, arg1, arg2);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaGetFunction(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			NTGApplicationController obj = (NTGApplicationController)ToLua.CheckObject(L, 1, typeof(NTGApplicationController));
			string arg0 = ToLua.CheckString(L, 2);
			string arg1 = ToLua.CheckString(L, 3);
			LuaInterface.LuaFunction o = obj.LuaGetFunction(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaGetTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NTGApplicationController obj = (NTGApplicationController)ToLua.CheckObject(L, 1, typeof(NTGApplicationController));
			string arg0 = ToLua.CheckString(L, 2);
			LuaInterface.LuaTable o = obj.LuaGetTable(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveTableCache(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NTGApplicationController obj = (NTGApplicationController)ToLua.CheckObject(L, 1, typeof(NTGApplicationController));
			string arg0 = ToLua.CheckString(L, 2);
			obj.RemoveTableCache(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LuaReleaseTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			NTGApplicationController obj = (NTGApplicationController)ToLua.CheckObject(L, 1, typeof(NTGApplicationController));
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			obj.LuaReleaseTable(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Initialized(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGApplicationController obj = (NTGApplicationController)o;
			bool ret = obj.Initialized;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Initialized on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_panelRoot(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGApplicationController obj = (NTGApplicationController)o;
			UnityEngine.Transform ret = obj.panelRoot;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index panelRoot on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_gameRoot(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGApplicationController obj = (NTGApplicationController)o;
			UnityEngine.Transform ret = obj.gameRoot;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index gameRoot on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_standaloneInputModule(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGApplicationController obj = (NTGApplicationController)o;
			UnityEngine.EventSystems.StandaloneInputModule ret = obj.standaloneInputModule;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index standaloneInputModule on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, NTGApplicationController.Instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Initialized(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGApplicationController obj = (NTGApplicationController)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Initialized = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Initialized on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_panelRoot(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGApplicationController obj = (NTGApplicationController)o;
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
			obj.panelRoot = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index panelRoot on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_gameRoot(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGApplicationController obj = (NTGApplicationController)o;
			UnityEngine.Transform arg0 = (UnityEngine.Transform)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Transform));
			obj.gameRoot = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index gameRoot on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_standaloneInputModule(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			NTGApplicationController obj = (NTGApplicationController)o;
			UnityEngine.EventSystems.StandaloneInputModule arg0 = (UnityEngine.EventSystems.StandaloneInputModule)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.EventSystems.StandaloneInputModule));
			obj.standaloneInputModule = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index standaloneInputModule on a nil value" : e.Message);
		}
	}
}
