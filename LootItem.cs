using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class LootItem : ItemInfo
	{
		#region Constructors
		public LootItem(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1407
		public int Index { get { return GetMember<int>("Index"); } }

		public int Quantity { get { return GetMember<int>("Quantity"); } }

		public ItemInfo ItemInfo { get { return new ItemInfo(GetMember("ItemInfo")); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
