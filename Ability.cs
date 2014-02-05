using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class Ability : AbilityInfo
	{
		#region Constructors
		public Ability(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// This is the level of the ability, not the level at which you receive the ability.
		/// </summary>
		public int Level { get { return GetMember<int>("Level"); } }

		/// <summary>
		/// in seconds
		/// </summary>
		public float Cooldown { get { return GetMember<float>("Cooldown"); } }

		public bool IsReady { get { return GetMember<bool>("IsReady"); } }

		/// <summary>
		/// in seconds
		/// </summary>
		public float ReadyIn { get { return GetMember<float>("ReadyIn"); } }
		#endregion

		#region Methods
		/// <summary>
		/// If you try to 'Use' an ability that is not ready, isxAion will do nothing.
		/// </summary>
		public bool Use()
		{
			return ExecuteMethod("Use");
		}
		#endregion
	}
}
