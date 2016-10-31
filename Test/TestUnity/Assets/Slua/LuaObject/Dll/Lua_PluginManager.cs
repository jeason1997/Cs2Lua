﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_PluginManager : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			PluginManager o;
			o=new PluginManager();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateObject(IntPtr l) {
		try {
			PluginManager self=(PluginManager)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CreateObject(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateModule(IntPtr l) {
		try {
			PluginManager self=(PluginManager)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CreateModule(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateStartup(IntPtr l) {
		try {
			PluginManager self=(PluginManager)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CreateStartup(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateTick(IntPtr l) {
		try {
			PluginManager self=(PluginManager)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			var ret=self.CreateTick(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterObjectFactory(IntPtr l) {
		try {
			PluginManager self=(PluginManager)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			IObjectPluginFactory a2;
			checkType(l,3,out a2);
			self.RegisterObjectFactory(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterModuleFactory(IntPtr l) {
		try {
			PluginManager self=(PluginManager)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			IModulePluginFactory a2;
			checkType(l,3,out a2);
			self.RegisterModuleFactory(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterStartupFactory(IntPtr l) {
		try {
			PluginManager self=(PluginManager)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			IStartupPluginFactory a2;
			checkType(l,3,out a2);
			self.RegisterStartupFactory(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int RegisterTickFactory(IntPtr l) {
		try {
			PluginManager self=(PluginManager)checkSelf(l);
			System.String a1;
			checkType(l,2,out a1);
			ITickPluginFactory a2;
			checkType(l,3,out a2);
			self.RegisterTickFactory(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_Instance(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,PluginManager.Instance);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"PluginManager");
		addMember(l,CreateObject);
		addMember(l,CreateModule);
		addMember(l,CreateStartup);
		addMember(l,CreateTick);
		addMember(l,RegisterObjectFactory);
		addMember(l,RegisterModuleFactory);
		addMember(l,RegisterStartupFactory);
		addMember(l,RegisterTickFactory);
		addMember(l,"Instance",get_Instance,null,false);
		createTypeMetatable(l,constructor, typeof(PluginManager));
	}
}
