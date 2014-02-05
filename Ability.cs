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
		#region isxAion-20130130.1162
		/// <summary>
		/// This is the level of the ability, not the level at which you receive the ability.
		/// </summary>
		public int Level { get { return GetMember<int>("Level"); } }
		#endregion

		#region isxAion-20130130.0949
		//isxAion-20130130.1099 The 'ability' datatype now inherits all members/methods of the 'abilityinfo' datatype.
		//public int ID { get { return GetMember<int>("ID"); } }

		//isxAion-20130130.1099 The 'ability' datatype now inherits all members/methods of the 'abilityinfo' datatype.
		//public string Name { get { return GetMember<string>("Name"); } }

		/// <summary>
		/// in seconds
		/// </summary>
		public float Cooldown { get { return GetMember<float>("Cooldown"); } }

		//isxAion-20130130.1099 The 'ability' datatype now inherits all members/methods of the 'abilityinfo' datatype.
		///// <summary>
		///// in seconds
		///// </summary>
		//public float CastTime { get { return GetMember<float>("CastTime"); } }

		public bool IsReady { get { return GetMember<bool>("IsReady"); } }

		/// <summary>
		/// in seconds
		/// </summary>
		public float ReadyIn { get { return GetMember<float>("ReadyIn"); } }
		#endregion
		#endregion

		#region Methods
		#region isxAion-20130130.0949
		/// <summary>
		/// If you try to 'Use' an ability that is not ready, isxAion will do nothing.
		/// </summary>
		public bool Use()
		{
			return ExecuteMethod("Use");
		}
		#endregion
		#endregion
	}
}
