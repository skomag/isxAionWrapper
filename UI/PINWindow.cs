using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class PINWindow : AionWindow
	{
		#region Constructors
		public PINWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public PINWindow()
			: base(LavishScript.Objects.GetObject("PINWindow"))
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// number can be 0-9 or -1 for C
		/// </summary>
		public AionButton Number(int number = -1)
		{
			if (number == -1)
				return new AionButton(GetMember("Number", "C"));
			else
				return new AionButton(GetMember("Number", number.ToString()));
		}

		public AionButton OK { get { return new AionButton(GetMember("OK")); } }

		public AionButton Cancel { get { return new AionButton(GetMember("Cancel")); } }
		#endregion

		#region Methods
		#endregion
	}
}
