using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class QuestionWindow : AionWindow
	{
		#region Constructors
		public QuestionWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public QuestionWindow()
			: base(LavishScript.Objects.GetObject("QuestionWindow"))
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1378
		/// <summary>
		/// typically "OK", "Yes", etc.
		/// isxAion will ensure that the window is OPEN before returning
		/// </summary>
		public AionButton Button1 { get { return new AionButton(GetMember("Button1")); } }

		/// <summary>
		/// typically "Cancel", "No", etc..
		/// isxAion will ensure that the window is OPEN before returning
		/// </summary>
		public AionButton Button2 { get { return new AionButton(GetMember("Button2")); } }

		/// <summary>
		/// isxAion will ensure that the window is OPEN before returning
		/// </summary>
		public AionUIText Text { get { return new AionUIText(GetMember("Text")); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
