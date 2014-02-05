using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class ChainSkillWindow : AionWindow
	{
		#region Constructors
		public ChainSkillWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public ChainSkillWindow()
			: base(LavishScript.Objects.GetObject("ChainSkillWindow"))
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1568
		/// <summary>
		/// returns the number of skills currently visible
		/// </summary>
		public int SkillsVisible { get { return GetMember<int>("SkillsVisible"); } }

		/// <summary>
		/// index is between 1 and chainskillwindow.SkillsVisible
		/// </summary>
		public ChainSkill SkillIndex(int index)
		{
			return new ChainSkill(GetMember("Skill", index.ToString()));
		}

		public ChainSkill Skill(int skillID)
		{
			return new ChainSkill(GetMember("Skill", "id", skillID.ToString()));
		}
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
