using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class SelfRessurectionWindow : AionWindow
	{
		#region Constructors
		public SelfRessurectionWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public SelfRessurectionWindow()
			: base(LavishScript.Objects.GetObject("SelfRessurectionWindow"))
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1979
		public AionUIText Text { get { return new AionUIText(GetMember("Text")); } }

		public AionButton Button1 { get { return new AionButton(GetMember("Button1")); } }

		public AionButton Button2 { get { return new AionButton(GetMember("Button2")); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
