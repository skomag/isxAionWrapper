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

		public CraftingWindow CraftingWindow { get { return new CraftingWindow(); } }

		public SelfRessurectionWindow SelfRessurectionWindow { get { return new SelfRessurectionWindow(); } }

		public RessurectionFromOthersWindow RessurectionFromOthersWindow { get { return new RessurectionFromOthersWindow(); } }

		public ConversationWindow ConversationWindow { get { return new ConversationWindow(); } }

		public TeleportWindow TeleportWindow { get { return new TeleportWindow(); } }

		public CharSelectWindow CharSelectWindow { get { return new CharSelectWindow(); } }

		public PINWindow PINWindow { get { return new PINWindow(); } }

		public EULAWindow EULAWindow { get { return new EULAWindow(); } }

		public LoginWindow LoginWindow { get { return new LoginWindow(); } }

		public ChainSkillWindow ChainSkillWindow { get { return new ChainSkillWindow(); } }

		public LootWindow LootWindow { get { return new LootWindow(); } }

		public QuestionWindow QuestionWindow { get { return new QuestionWindow(); } }

		public Aion Aion { get { return new Aion(); } }

		public Character Me { get { return new Me(); } }

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
		/// </summary>
		public ISXAion isxAion { get { return new ISXAion(); } }
	}
}
