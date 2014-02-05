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
		public int MaxMP { get { return GetMember<int>("MaxMP"); } }

		public int MP { get { return GetMember<int>("MP"); } }

		public int MaxFlightTime { get { return GetMember<int>("MaxFlightTime"); } }

		public int FlightTime { get { return GetMember<int>("FlightTime"); } }

		public bool InFlight { get { return GetMember<bool>("InFlight"); } }

		public bool OutOfRange { get { return GetMember<bool>("OutOfRange"); } }

		public bool Linkdead { get { return GetMember<bool>("Linkdead"); } }
		#endregion

		#region Methods
		#endregion
	}
}
