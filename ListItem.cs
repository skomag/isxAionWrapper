using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class ListItem : ItemInfo
	{
		#region Constructors
		public ListItem(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		#region isxAion-20130626.0193
		public int Index { get { return GetMember<int>("Index"); } }

		public int Quantity { get { return GetMember<int>("Quantity"); } }

		public ItemInfo ItemInfo { get { return new ItemInfo(GetMember("ItemInfo")); } }

		public bool IsAvailable { get { return GetMember<bool>("IsAvailable"); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
