using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class EquipmentItem : ItemInfo
	{
		#region Constructors
		public EquipmentItem(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1548
		/// <summary>
		/// Note:  This member does not require a call to the server or the DB.
		/// </summary>
		//public string Name { get { return GetMember<string>("Name"); } }

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
		#endregion

		#region Methods
		#region isxAion-20130130.1548
		public bool Use()
		{
			return ExecuteMethod("Use");
		}
		#endregion
		#endregion
	}
}
