﻿using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class Inventory : LavishScriptObject
	{
		#region Constructors
		public Inventory(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		public int Used { get { return GetMember<int>("Used"); } }

		public int Size { get { return GetMember<int>("Size"); } }
		#endregion

		#region Methods
		#endregion
	}
}
