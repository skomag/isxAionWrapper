using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class InventoryItem : ItemInfo
	{
		#region Constructors
		public InventoryItem(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		public int Quantity { get { return GetMember<int>("Quantity"); } }

		/// <summary>
		/// in seconds
		/// NOTE:  "Cooldown" will work as a synonym for "Reuse" in order to provide continuity between this datatype and the 'ability' datatype.
		/// </summary>
		public float Reuse { get { return GetMember<float>("Reuse"); } }

		/// <summary>
		/// in seconds
		/// NOTE:  "Cooldown" will work as a synonym for "Reuse" in order to provide continuity between this datatype and the 'ability' datatype.
		/// </summary>
		public float Cooldown { get { return GetMember<float>("Cooldown"); } }

		/// <summary>
		/// in seconds
		/// </summary>
		public float ReadyIn { get { return GetMember<float>("ReadyIn"); } }

		public bool IsReady { get { return GetMember<bool>("IsReady"); } }

		public ItemInfo ItemInfo { get { return new ItemInfo(GetMember("ItemInfo")); } }
		#endregion

		#region Methods
		public bool Use()
		{
			return ExecuteMethod("Use");
		}
		#endregion
	}
}
