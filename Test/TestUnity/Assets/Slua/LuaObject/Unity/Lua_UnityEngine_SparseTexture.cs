﻿using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_SparseTexture : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			UnityEngine.SparseTexture o;
			if(argc==5){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.TextureFormat a3;
				checkEnum(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				o=new UnityEngine.SparseTexture(a1,a2,a3,a4);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			else if(argc==6){
				System.Int32 a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				UnityEngine.TextureFormat a3;
				checkEnum(l,4,out a3);
				System.Int32 a4;
				checkType(l,5,out a4);
				System.Boolean a5;
				checkType(l,6,out a5);
				o=new UnityEngine.SparseTexture(a1,a2,a3,a4,a5);
				pushValue(l,true);
				pushValue(l,o);
				return 2;
			}
			return error(l,"New object failed.");
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateTile(IntPtr l) {
		try {
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			UnityEngine.Color32[] a4;
			checkArray(l,5,out a4);
			self.UpdateTile(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UpdateTileRaw(IntPtr l) {
		try {
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			System.Byte[] a4;
			checkArray(l,5,out a4);
			self.UpdateTileRaw(a1,a2,a3,a4);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int UnloadTile(IntPtr l) {
		try {
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			System.Int32 a3;
			checkType(l,4,out a3);
			self.UnloadTile(a1,a2,a3);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetNativeTexturePtr(IntPtr l) {
		try {
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			var ret=self.GetNativeTexturePtr();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetInstanceID(IntPtr l) {
		try {
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			var ret=self.GetInstanceID();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tileWidth(IntPtr l) {
		try {
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tileWidth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_tileHeight(IntPtr l) {
		try {
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.tileHeight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_isCreated(IntPtr l) {
		try {
			UnityEngine.SparseTexture self=(UnityEngine.SparseTexture)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.isCreated);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.SparseTexture");
		addMember(l,UpdateTile);
		addMember(l,UpdateTileRaw);
		addMember(l,UnloadTile);
		addMember(l,GetNativeTexturePtr);
		addMember(l,GetInstanceID);
		addMember(l,"tileWidth",get_tileWidth,null,true);
		addMember(l,"tileHeight",get_tileHeight,null,true);
		addMember(l,"isCreated",get_isCreated,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.SparseTexture),typeof(UnityEngine.Texture));
	}
}
