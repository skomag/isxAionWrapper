using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class GroupMember : Entity
	{
		#region Constructors
		public GroupMember(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.0975
		public int MaxMP { get { return GetMember<int>("MaxMP"); } }

		public int MP { get { return GetMember<int>("MP"); } }

		public int MaxFlightTime { get { return GetMember<int>("MaxFlightTime"); } }

		public int FlightTime { get { return GetMember<int>("FlightTime"); } }

		public bool InFlight { get { return GetMember<bool>("InFlight"); } }

		public bool OutOfRange { get { return GetMember<bool>("OutOfRange"); } }

		public bool Linkdead { get { return GetMember<bool>("Linkdead"); } }

		//isxAion-20130130.1433 NumBuffs moved to Entity
		//public int NumBuffs { get { return GetMember<int>("NumBuffs"); } }

		//isxAion-20130130.1433 Buff moved to Entity
		///// <summary>
		///// index is between 1 and groupmember.NumBuffs
		///// </summary>
		//public Buff Buff(int index)
		//{
		//	return new Buff(GetMember("Buff", index.ToString()));
		//}
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
