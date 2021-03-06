﻿using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class EULAWindow : AionWindow
	{
		#region Constructors
		public EULAWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public EULAWindow()
			: base(LavishScript.Objects.GetObject("EULAWindow"))
		{
		}
		#endregion

		#region Members
		public AionButton Accept { get { return new AionButton(GetMember("Accept")); } }
		#endregion

		#region Methods
		#endregion
	}
}
