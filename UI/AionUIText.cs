using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class AionUIText : AionWidget
	{
		#region Constructors
		public AionUIText(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// no html parsing, etc.
		/// </summary>
		public string Raw { get { return GetMember<string>("Raw"); } }
		#endregion

		#region Methods
		#endregion
	}
}
