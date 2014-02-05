using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class GatherData : LavishScriptObject
	{
		#region Constructors
		public GatherData(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		public int ID { get { return GetMember<int>("ID"); } }

		public string SourceType { get { return GetMember<string>("SourceType"); } }

		public string HarvestSkill { get { return GetMember<string>("HarvestSkill"); } }

		public int SkillLevel { get { return GetMember<int>("SkillLevel"); } }

		/// <summary>
		/// number is between 1 and 6
		/// </summary>
		public int NormalRate(int number)
		{
			return GetMember<int>("NormalRate", number.ToString());
		}

		/// <summary>
		/// number is between 1 and 6
		/// </summary>
		public string Material(int number)
		{
			return GetMember<string>("Material", number.ToString());
		}

		public int HarvestCount { get { return GetMember<int>("HarvestCount"); } }

		public int SuccessAdj { get { return GetMember<int>("SuccessAdj"); } }

		public int FailureAdj { get { return GetMember<int>("FailureAdj"); } }

		public int AerialAdj { get { return GetMember<int>("AerialAdj"); } }

		public int CaptchaRate { get { return GetMember<int>("CaptchaRate"); } }
		#endregion

		#region Methods
		#endregion
	}
}
