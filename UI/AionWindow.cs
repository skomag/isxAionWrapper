using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class AionWindow : LavishScriptObject
	{
		#region Constructors
		public AionWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		public bool IsOpen { get { return GetMember<bool>("IsOpen"); } }
		#endregion

		#region Methods
		#endregion
	}
}
