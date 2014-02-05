using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class AbyssRank : LavishScriptObject
	{
		#region Constructors
		public AbyssRank(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		public int Rank { get { return GetMember<int>("Rank"); } }

		public int ID { get { return GetMember<int>("ID"); } }

		public int PointsRequired { get { return GetMember<int>("PointsRequired"); } }

		public int DropPoints { get { return GetMember<int>("DropPoints"); } }

		public int DeathPenalty { get { return GetMember<int>("DeathPenalty"); } }
		#endregion

		#region Methods
		#endregion
	}
}
