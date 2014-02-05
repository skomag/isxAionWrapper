using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class NPCInfo : LavishScriptObject
	{
		#region Constructors
		public NPCInfo(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1948
		/// <summary>
		/// This is the "ID" used in client_npcs.xml
		/// </summary>
		public int SubTypeID { get { return GetMember<int>("SubTypeID"); } }
		#endregion

		#region isxAion-1.5.1.7.0151
		public int ID { get { return GetMember<int>("ID"); } }

		public string Description { get { return GetMember<string>("Description"); } }

		public string Name { get { return GetMember<string>("Name"); } }

		public string DiskType { get { return GetMember<string>("DiskType"); } }

		public string UIType { get { return GetMember<string>("UIType"); } }

		public string CursorType { get { return GetMember<string>("CursorType"); } }

		public string FXCType { get { return GetMember<string>("FXCType"); } }

		public string UIRaceType { get { return GetMember<string>("UIRaceType"); } }

		public string NPCType { get { return GetMember<string>("NPCType"); } }

		public string AbyssNPCType { get { return GetMember<string>("AbyssNPCType"); } }

		public string BindstoneType { get { return GetMember<string>("BindstoneType"); } }

		public int BindstoneCapacity { get { return GetMember<int>("BindstoneCapacity"); } }

		public int BindstoneUseCount { get { return GetMember<int>("BindstoneUseCount"); } }

		public int Scale { get { return GetMember<int>("Scale"); } }

		public float Altitude { get { return GetMember<float>("Altitude"); } }

		public float NormalWalkSpeed { get { return GetMember<float>("NormalWalkSpeed"); } }

		public float NormalRunSpeed { get { return GetMember<float>("NormalRunSpeed"); } }

		public float CombatRunSpeed { get { return GetMember<float>("CombatRunSpeed"); } }

		public int HPGaugeLevel { get { return GetMember<int>("HPGaugeLevel"); } }

		public int AmmoSpeed { get { return GetMember<int>("AmmoSpeed"); } }

		/// <summary>
		/// unused by Aion at the moment
		/// </summary>
		public int MagicalSkillBoost { get { return GetMember<int>("MagicalSkillBoost"); } }

		public string GameLanguage { get { return GetMember<string>("GameLanguage"); } }

		public string AIName { get { return GetMember<string>("AIName"); } }

		public string QuestAIName { get { return GetMember<string>("QuestAIName"); } }

		public string Tribe { get { return GetMember<string>("Tribe"); } }

		public int SensoryRange { get { return GetMember<int>("SensoryRange"); } }

		public int AttackRange { get { return GetMember<int>("AttackRange"); } }

		public int AttackRate { get { return GetMember<int>("AttackRate"); } }

		public int TalkingDistance { get { return GetMember<int>("TalkingDistance"); } }

		public bool Undetectable { get { return GetMember<bool>("Undetectable"); } }

		public bool GiveItemProc { get { return GetMember<bool>("GiveItemProc"); } }

		public bool RemoveItemOption { get { return GetMember<bool>("RemoveItemOption"); } }

		public int ArtifactID { get { return GetMember<int>("ArtifactID"); } }

		public string UserAnimation { get { return GetMember<string>("UserAnimation"); } }

		public string SpawnAnimation { get { return GetMember<string>("SpawnAnimation"); } }
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
