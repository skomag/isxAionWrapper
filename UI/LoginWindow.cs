﻿using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class LoginWindow : AionWindow
	{
		#region Constructors
		public LoginWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public LoginWindow()
			: base(LavishScript.Objects.GetObject("LoginWindow"))
		{
		}
		#endregion

		#region Members
		public AionEditBox Account { get { return new AionEditBox(GetMember("Account")); } }

		public AionEditBox Password { get { return new AionEditBox(GetMember("Password")); } }

		public AionButton OK { get { return new AionButton(GetMember("OK")); } }
		#endregion

		#region Methods
		#endregion
	}
}
