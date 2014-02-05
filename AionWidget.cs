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
		#region isxAion-20130130.1792
		public bool IsEnabled { get { return GetMember<bool>("IsEnabled"); } }
		#endregion

		#region isxAion-20130130.1717
		public bool IsOpen { get { return GetMember<bool>("IsOpen"); } }
		#endregion

		#region isxAion-20130130.1701
		public string Text { get { return GetMember<string>("Text"); } }

		public string Type { get { return GetMember<string>("Type"); } }

		//isxAion-20130130.1728 Removed the "IsVisible" MEMBER of the 'aionwidget' datatype (for now.)
		//public bool IsVisible { get { return GetMember<bool>("IsVisible"); } }
		#endregion
		#endregion

		#region Methods
		#region isxAion-20130626.0193
		public bool LeftClick()
		{
			return ExecuteMethod("LeftClick");
		}
		#endregion

		#region isxAion-20130130.1701
		public bool SetText(string text)
		{
			return ExecuteMethod("SetText", text);
		}
		#endregion
		#endregion
	}
}
