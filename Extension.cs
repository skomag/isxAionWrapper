using System;
using System.Text;
using System.Runtime.InteropServices;
using InnerSpaceAPI;
using LavishScriptAPI;
using LavishVMAPI;

namespace Aion.isxAion
{
	public class Extension
	{
		public Extension()
		{
		}

		#region isxAion-20130626.0193
		public CraftingWindow CraftingWindow { get { return new CraftingWindow(); } }
		#endregion

		#region isxAion-20130130.1979
		public SelfRessurectionWindow SelfRessurectionWindow { get { return new SelfRessurectionWindow(); } }

		public RessurectionFromOthersWindow RessurectionFromOthersWindow { get { return new RessurectionFromOthersWindow(); } }
		#endregion

		#region isxAion-20130130.1808
		public ConversationWindow ConversationWindow { get { return new ConversationWindow(); } }

		public TeleportWindow TeleportWindow { get { return new TeleportWindow(); } }
		#endregion

		#region isxAion-20130130.1792
		public CharSelectWindow CharSelectWindow { get { return new CharSelectWindow(); } }
		
		public PINWindow PINWindow { get { return new PINWindow(); } }
		#endregion

		#region isxAion-20130130.1735
		public EULAWindow EULAWindow { get { return new EULAWindow(); } }
		#endregion

		#region isxAion-20130130.1701
		public LoginWindow LoginWindow { get { return new LoginWindow(); } }
		#endregion

		#region isxAion-20130130.1568
		public ChainSkillWindow ChainSkillWindow { get { return new ChainSkillWindow(); } }
		#endregion

		#region isxAion-20130130.1407
		public LootWindow LootWindow { get { return new LootWindow(); } }
		#endregion

		#region isxAion-20130130.1378
		public QuestionWindow QuestionWindow { get { return new QuestionWindow(); } }
		#endregion

		public Aion Aion()
		{
			return new Aion();
		}

		public Character Me
		{
			get
			{
				return new Me();
			}
		}

		public Entity Entity(int ID)
		{
			return new Entity(ID);
		}

		public Entity Entity(params string[] Args)
		{
			return new Entity(Args);
		}

        /// <summary>
        /// The "isxAion" TLO is now named "ISXAion"
        /// isxAion-1.0.5.11.0601
        /// </summary>
		public ISXAion isxAion
		{
			get
			{
				return new ISXAion();
			}
		}
	}
}