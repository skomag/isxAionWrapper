using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class AionButton : AionWidget
	{
		#region Constructors
		public AionButton(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1378
		///// <summary>
		///// raw text; no html parsing, etc.
		///// </summary>
		//public string Text { get { return GetMember<string>("Text"); } }
		#endregion
		#endregion

		#region Methods
		#region isxAion-20130130.1378
		//isxAion-20130626.0193 Moved the "LeftClick" METHOD from the 'aionbutton' datatype to the 'aionwidget' datatype
		//public bool LeftClick()
		//{
		//	return ExecuteMethod("LeftClick");
		//}
		#endregion
		#endregion
	}
}
