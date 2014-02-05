using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class Entity : NPCInfo
    {
        #region Constructors
        public Entity(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Entity(int ID)
            : base(LavishScript.Objects.GetObject("Entity", ID.ToString()))
        {
        }

        public Entity(string name)
            : base(LavishScript.Objects.GetObject("Entity", name))
        {
        }

        public Entity(params string[] Args)
            : base(LavishScript.Objects.GetObject("Entity", Args))
        {
        }
        #endregion


        #region Members
		public bool IsCrafting { get { return GetMember<bool>("IsCrafting"); } }

		public Entity Pet { get { return new Entity(GetMember("Pet")); } }

		/// <summary>
		/// Pleae note that this will not be TRUE if you're on a moving transport (elevator, etc.)
		/// </summary>
		public bool IsMoving { get { return GetMember<bool>("IsMoving"); } }

		/// <summary>
		/// TRUE when falling from a distance that would cause damage
		/// </summary>
		public bool IsFalling { get { return GetMember<bool>("IsFalling"); } }

		/// <summary>
		/// i.e., spacebar instigated gliding
		/// </summary>
		public bool IsGliding { get { return GetMember<bool>("IsGliding"); } }

		/// <summary>
		/// "Soaring" is when you are gliding and hold the forward movement key
		/// </summary>
		public bool IsSoaring { get { return GetMember<bool>("IsSoaring"); } }

		/// <summary>
		/// i.e., taking a ride via the "Flight Transporter"
		/// </summary>
		public bool IsInFlightTransport { get { return GetMember<bool>("IsInFlightTransport"); } }

		public bool IsMentor { get { return GetMember<bool>("IsMentor"); } }

		public Buff BuffByID(int abilityID)
		{
			return new Buff(GetMember("Buff", "id", abilityID.ToString()));
		}

		/// <summary>
		/// Health percent
		/// </summary>
		public float HPPct { get { return GetMember<float>("HP", "pct"); } }

		public int NumBuffs { get { return GetMember<int>("NumBuffs"); } }

		/// <summary>
		/// index is between 1 and groupmember.NumBuffs
		/// </summary>
		public Buff Buff(int index)
		{
			return new Buff(GetMember("Buff", index.ToString()));
		}

		public string LocationLink { get { return GetMember<string>("LocationLink"); } }

		/// <summary>
		/// The magenta link (and mini-map "x") that appears when you use the "locate" feature (i.e.,
        /// in the quest journal.)  Also, just like those magenta links, when used with non-named creatures it will 
		/// actually point to the nearest entity that matches the 'type' of the one you used to create the link.
		/// </summary>
		public string WhereLink { get { return GetMember<string>("WhereLink"); } }

		public GatherData GatherData { get { return new GatherData(GetMember("GatherData")); } }

		public AbyssRank AbyssRank
        {
            get
            {
                return new AbyssRank(GetMember("AbyssRank"));
            }
        }

		/// <summary>
        /// Used primarily to indicate PCs on your faction 
        /// </summary>
        public bool IsFriendly
        {
            get
            {
                return GetMember<bool>("IsFriendly");
            }
        }

        public bool InCombat
        {
            get
            {
                return GetMember<bool>("InCombat");
            }
        }

        public bool IsResting
        {
            get
            {
                return GetMember<bool>("IsResting");
            }
        }

        /// <summary>
        /// This primarily refers to PC flying
        /// </summary>
        public bool IsFlying
        {
            get
            {
                return GetMember<bool>("IsFlying");
            }
        }

        /// <summary>
        /// The single blue/yellow arrow indicating new quest available
        /// </summary>
        public bool OffersNewQuest
        {
            get
            {
                return GetMember<bool>("OffersNewQuest");
            }
        }

        /// <summary>
        /// Quest icon is visible, but greyed out
        /// </summary>
        public bool OffersNewQuestNextLevel
        {
            get
            {
                return GetMember<bool>("OffersNewQuestNextLevel");
            }
        }

        /// <summary>
        /// The double blue/yellow arrow indicating that the quest step is completed
        /// </summary>
        public bool QuestInProgress
        {
            get
            {
                return GetMember<bool>("QuestInProgress");
            }
        }

        /// <summary>
        /// The 'star' blue/yellow icon indicating quest is finished
        /// </summary>
        public bool QuestComplete
        {
            get
            {
                return GetMember<bool>("QuestComplete");
            }
        }

        public string Class
        {
            get
            {
                return GetMember<string>("Class");
            }
        }

		/// <summary>
        /// 'FALSE' on non-gatherables and gatherables for which your skill is too low 
        /// </summary>
        public bool CanGather
        {
            get
            {
                return GetMember<bool>("CanGather");
            }
        }

        public bool IsCorpse
        {
            get
            {
                return GetMember<bool>("IsCorpse");
            }
        }

        /// <summary>
        ///  i.e., a corpse that is lootable for you
        /// </summary>
        public bool IsLootable
        {
            get
            {
                return GetMember<bool>("IsLootable");
            }
        }

        /// <summary>
        /// Only useful for NPCs
        /// </summary>
        public bool CanChat
        {
            get
            {
                return GetMember<bool>("CanChat");
            }
        }

        /// <summary>
        /// Only useful for NPCs
        /// </summary>
        public bool CanShop
        {
            get
            {
                return GetMember<bool>("CanShop");
            }
        }

        public bool CanAttack
        {
            get
            {
                return GetMember<bool>("CanAttack");
            }
        }

        /// <summary>
        /// i.e., has the "gear" icon for interaction
        /// </summary>
        public bool IsUsable
        {
            get
            {
                return GetMember<bool>("IsUsable");
            }
        }

        public bool IsAggro
        {
            get
            {
                return GetMember<bool>("IsAggro");
            }
        }

		/// <summary>
        /// This is a signed integer!  Most NPCs/PCs have negative EntityIDs. All entities have an "EntityID" while only spawns capable of true interaction have an "ID".
        /// </summary>
        public int EntityID
        {
            get
            {
                return GetMember<int>("EntityID");
            }
        }

		/// <summary>
        /// Possible Types (as of 11/2009):  Me, NPC, PC, Resource, Special, Unknown, Chair, Birds, SoundSpot, Random Ambient Sound, Bugs, Portal, Object, Milestone, Pet, ToyPet
        /// </summary>
        public string Type
        {
            get
            {
                return GetMember<string>("Type");
            }
        }
        public float X
        {
            get
            {
                return GetMember<float>("X");
            }
        }
        public float Y
        {
            get
            {
                return GetMember<float>("Y");
            }
        }
        public float Z
        {
            get
            {
                return GetMember<float>("Z");
            }
        }
        public Point3f Location
        {
            get
            {
                return GetMember<Point3f>("Location");
            }
        }
        public float Distance
        {
            get
            {
                return GetMember<float>("Distance");
            }
        }
        public float Radius
        {
            get
            {
                return GetMember<float>("Radius");
            }
        }
        /// <summary>
        /// Please note that for PCs, HP is returned as a percentage.  However, for NPCs and "Me" (the current player), it is returned as actual health points.
        /// </summary>
        public int HP
        {
            get
            {
                return GetMember<int>("HP");
            }
        }
        /// <summary>
        /// Please note that for PCs, MaxHP is returned as a percentage.  However, for NPCs and "Me" (the current player), it is returned as actual health points.
        /// </summary>
        public int MaxHP
        {
            get
            {
                return GetMember<int>("MaxHP");
            }
        }
        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }
        /// <summary>
        /// The speed at which an entity will travel when moving
        /// </summary>
        public float Speed
        {
            get
            {
                return GetMember<float>("Speed");
            }
        }
        /// <summary>
        /// The distance from which you can travel from the entity and still have access to it via isxAion
        /// </summary>
        public float ValidDistance
        {
            get
            {
                return GetMember<float>("ValidDistance");
            }
        }
        public float Heading
        {
            get
            {
                return GetMember<float>("Heading");
            }
        }
        /// <summary>
        /// The heading from you TO the entity
        /// </summary>
        public float HeadingTo
        {
            get
            {
                return GetMember<float>("HeadingTo");
            }
        }
        /// <summary>
        /// currently only works for PCs
        /// </summary>
        public string Legion
        {
            get
            {
                return GetMember<string>("Legion");
            }
        }
        public Entity Target
        {
            get
            {
                return new Entity(GetMember("Target"));
            }
        }
        #endregion

        #region Methods
		public bool Follow()
		{
			return ExecuteMethod("Follow");
		}

		public bool DoTarget()
        {
            return ExecuteMethod("DoTarget");
        }
        #endregion
    }
}
