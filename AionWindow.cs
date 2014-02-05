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
		#region isxAion-20130130.1378
		public bool IsOpen { get { return GetMember<bool>("IsOpen"); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
