using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class AionWidget : LavishScriptObject
	{
		#region Constructors
		public AionWidget(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		public bool IsEnabled { get { return GetMember<bool>("IsEnabled"); } }

		public bool IsOpen { get { return GetMember<bool>("IsOpen"); } }

		public string Text { get { return GetMember<string>("Text"); } }

		public string Type { get { return GetMember<string>("Type"); } }
		#endregion

		#region Methods
		public bool LeftClick()
		{
			return ExecuteMethod("LeftClick");
		}

		public bool SetText(string text)
		{
			return ExecuteMethod("SetText", text);
		}
		#endregion
	}
}
