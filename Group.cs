using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class Group : LavishScriptObject
	{
		#region Constructors
		public Group(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.0975
		public int Size { get { return GetMember<int>("Size"); } }

		public uint LeaderID { get { return GetMember<uint>("LeaderID"); } }

		public Entity Leader { get { return GetMember<Entity>("Leader"); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
