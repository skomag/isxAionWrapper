using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class CharSelectWindow : AionWindow
	{
		#region Constructors
		public CharSelectWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public CharSelectWindow()
			: base(LavishScript.Objects.GetObject("CharSelectWindow"))
		{
		}
		#endregion

		#region Members
		public AionButton Start { get { return new AionButton(GetMember("Start")); } }

		public AionButton Character(int id)
		{
			return new AionButton(GetMember("Character", id.ToString()));
		}

		public AionButton Character(string name)
		{
			return new AionButton(GetMember("Character", name));
		}
		#endregion

		#region Methods
		#endregion
	}
}
