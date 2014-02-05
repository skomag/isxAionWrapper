using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class RessurectionFromOthersWindow : AionWindow
	{
		#region Constructors
		public RessurectionFromOthersWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public RessurectionFromOthersWindow()
			: base(LavishScript.Objects.GetObject("RessurectionFromOthersWindow"))
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1979
		public AionUIText Text { get { return new AionUIText(GetMember("Text")); } }

		public AionButton Accept { get { return new AionButton(GetMember("Accept")); } }

		public AionButton Decline { get { return new AionButton(GetMember("Decline")); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
