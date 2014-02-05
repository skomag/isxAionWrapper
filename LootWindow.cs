using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class LootWindow : AionWindow
	{
		#region Constructors
		public LootWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public LootWindow()
			: base(LavishScript.Objects.GetObject("LootWindow"))
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1407
		public int LootCount { get { return GetMember<int>("LootCount"); } }

		/// <summary>
		/// index is between 1 and lootwindow.LootCount
		/// </summary>
		public LootItem Loot(int index)
		{
			return new LootItem(GetMember("Loot", index.ToString()));
		}

		/// <summary>
		/// typically "Loot All" or "Cancel", depending upon whether loot is available
		/// </summary>
		public AionButton Button1 { get { return new AionButton(GetMember("Button1")); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
