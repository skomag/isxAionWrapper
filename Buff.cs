using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class Buff : LavishScriptObject
	{
		#region Constructors
		public Buff(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		/// <summary>
		/// This MEMBER does require a call to the sqlite3 db.  Although the performance hit should be minimal, you would notice it if you used
		/// this member as part of a UI or anything that would call it over and over again quickly (i.e., every frame.)
		/// </summary>
		public string Name { get { return GetMember<string>("Name"); } }

		public AbilityInfo AbilityInfo { get { return new AbilityInfo(GetMember("AbilityInfo")); } }

		public uint AbilityID { get { return GetMember<uint>("AbilityID"); } }

		public uint CasterID { get { return GetMember<uint>("CasterID"); } }

		public int Type { get { return GetMember<int>("Type"); } }

		/// <summary>
		/// In seconds
		/// </summary>
		public float Duration { get { return GetMember<float>("Duration"); } }
		#endregion

		#region Methods
		#endregion
	}
}
