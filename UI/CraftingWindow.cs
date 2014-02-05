using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class CraftingWindow : AionWindow
	{
		#region Constructors
		public CraftingWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public CraftingWindow()
			: base(LavishScript.Objects.GetObject("CraftingWindow"))
		{
		}
		#endregion

		#region Members
		public AionButton CraftAll { get { return new AionButton(GetMember("CraftAll")); } }

		public ListItem Product { get { return new ListItem(GetMember("Product")); } }

		public ListItem RequiredMaterial(int index)
		{
			return new ListItem(GetMember("RequiredMaterial", index.ToString()));
		}

		public AionWidget WorkOrderList { get { return new AionWidget(GetMember("WorkOrderList")); } }
		#endregion

		#region Methods
		#endregion
	}
}
