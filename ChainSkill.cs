using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class ChainSkill : AbilityInfo
	{
		#region Constructors
		public ChainSkill(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		#region #region isxAion-20130130.1568
		//public uint ID { get { return GetMember<uint>("ID"); } }

		/// <summary>
		/// i.e., the skill is still visible (greyed) but you waited too long or started another chain
		/// </summary>
		public bool IsExpired { get { return GetMember<bool>("IsExpired"); } }

		/// <summary>
		/// the length of time the skill has been visible, in seconds
		/// </summary>
		public float TimeVisible { get { return GetMember<float>("TimeVisible"); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
