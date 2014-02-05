using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Character : Entity
	{
		#region Constructors
        public Character(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public Character()
            : base(LavishScript.Objects.GetObject("Me"))
		{
		}
		#endregion

		#region Members
		public Entity Following { get { return new Entity(GetMember("Following")); } }

		public uint FollowingID { get { return GetMember<uint>("FollowingID", "ID"); } }

		public bool OnFastTrackServer { get { return GetMember<bool>("OnFastTrackServer"); } }

		public Inventory Inventory { get { return new Inventory(GetMember("Inventory")); } }

		/// <summary>
		/// index between 1 and inventory.Used
		/// </summary>
		public InventoryItem InventoryByIndex(int index)
		{
			return new InventoryItem(GetMember("Inventory", index.ToString()));
		}

		public InventoryItem InventoryByID(int itemID)
		{
			return new InventoryItem(GetMember("Inventory", "id", itemID.ToString()));
		}

		/// <summary>
		/// case insensitive
		/// </summary>
		public InventoryItem InventoryByName(string itemName)
		{
			return new InventoryItem(GetMember("Inventory", itemName.ToString()));
		}

		/// <summary>
		/// Returns the first item that contains partialName in the name
		/// case insensitive
		/// </summary>
		public InventoryItem InventoryByContains(string partialName)
		{
			return new InventoryItem(GetMember("Inventory", "NameContains", partialName.ToString()));
		}

		public Inventory Equipment { get { return new Inventory(GetMember("Equipment")); } }

		/// <summary>
		/// index between 1 and inventory.Used
		/// </summary>
		public InventoryItem EquipmentByIndex(int index)
		{
			return new InventoryItem(GetMember("Equipment", index.ToString()));
		}

		public InventoryItem EquipmentByID(int itemID)
		{
			return new InventoryItem(GetMember("Equipment", "id", itemID.ToString()));
		}

		/// <summary>
		/// case insensitive
		/// </summary>
		public InventoryItem EquipmentByName(string itemName)
		{
			return new InventoryItem(GetMember("Equipment", itemName.ToString()));
		}

		/// <summary>
		/// Returns the first item that contains partialName in the name
		/// case insensitive
		/// </summary>
		public InventoryItem EquipmentByContains(string partialName)
		{
			return new InventoryItem(GetMember("Equipment", "NameContains", partialName.ToString()));
		}

		public Inventory SpecialCube { get { return new Inventory(GetMember("SpecialCube")); } }

		/// <summary>
		/// index between 1 and inventory.Used
		/// </summary>
		public InventoryItem SpecialCubeByIndex(int index)
		{
			return new InventoryItem(GetMember("SpecialCube", index.ToString()));
		}

		public InventoryItem SpecialCubeByID(int itemID)
		{
			return new InventoryItem(GetMember("SpecialCube", "id", itemID.ToString()));
		}

		/// <summary>
		/// case insensitive
		/// </summary>
		public InventoryItem SpecialCubeByName(string itemName)
		{
			return new InventoryItem(GetMember("SpecialCube", itemName.ToString()));
		}

		/// <summary>
		/// Returns the first item that contains partialName in the name
		/// case insensitive
		/// </summary>
		public InventoryItem SpecialCubeByContains(string partialName)
		{
			return new InventoryItem(GetMember("SpecialCube", "NameContains", partialName.ToString()));
		}

		public Inventory Warehouse { get { return new Inventory(GetMember("Warehouse")); } }

		/// <summary>
		/// index between 1 and inventory.Used
		/// </summary>
		public InventoryItem WarehouseByIndex(int index)
		{
			return new InventoryItem(GetMember("Warehouse", index.ToString()));
		}

		public InventoryItem WarehouseByID(int itemID)
		{
			return new InventoryItem(GetMember("Warehouse", "id", itemID.ToString()));
		}

		/// <summary>
		/// case insensitive
		/// </summary>
		public InventoryItem WarehouseByName(string itemName)
		{
			return new InventoryItem(GetMember("Warehouse", itemName.ToString()));
		}

		/// <summary>
		/// Returns the first item that contains partialName in the name
		/// case insensitive
		/// </summary>
		public InventoryItem WarehouseByContains(string partialName)
		{
			return new InventoryItem(GetMember("Warehouse", "NameContains", partialName.ToString()));
		}

		/// <summary>
		/// Flight time percent
		/// </summary>
		public float FlightTimePct { get { return GetMember<float>("FlightTime", "pct"); } }

		/// <summary>
		/// Mana percent
		/// </summary>
		public float MPPct { get { return GetMember<float>("MP", "pct"); } }

		/// <summary>
		/// Experience percent
		/// </summary>
		public float XPPct { get { return GetMember<float>("XP", "pct"); } }

		/// <summary>
		/// Divine points percent
		/// </summary>
		public float DPPct { get { return GetMember<float>("DP", "pct"); } }

		public bool IsFollowing { get { return GetMember<bool>("IsFollowing"); } }

		/// <summary>
		/// TRUE while the "gathering window" is visible
		/// </summary>
		public bool IsGathering { get { return GetMember<bool>("IsGathering"); } }

		public Group Group { get { return new Group(GetMember("Group")); } }

		/// <summary>
		/// index is between 1 and Group.Size
		/// </summary>
		public GroupMember GroupMember(int index)
		{
			return new GroupMember(GetMember("Group", index.ToString()));
		}

		/// <summary>
		/// name is the name of the group member
		/// Case insensitive
		/// </summary>
		public GroupMember GroupMember(string name)
		{
			return new GroupMember(GetMember("Group", name.ToString()));
		}

		public int NumAbilities { get { return GetMember<int>("NumAbilities"); } }

		/// <summary>
		/// Retrieving abilities by ID is the most efficient, due to how things are handled.  However, there are no
		/// server calls for retrieving abilities by index or name and the differences in retrieval methods are negligible.
		/// index between 1 and character.NumAbilities
		/// </summary>
		public Ability AbilityIndex(int index)
		{
			return new Ability(GetMember("Ability", index.ToString()));
		}

		/// <summary>
		/// Retrieving abilities by ID is the most efficient, due to how things are handled.  However, there are no
		/// server calls for retrieving abilities by index or name and the differences in retrieval methods are negligible.
		/// </summary>
		public Ability Ability(int abilityID)
		{
			return new Ability(GetMember("Ability", "id", abilityID.ToString()));
		}

		/// <summary>
		/// Retrieving abilities by ID is the most efficient, due to how things are handled.  However, there are no
		/// server calls for retrieving abilities by index or name and the differences in retrieval methods are negligible.
		/// Case insensitive
		/// </summary>
		public Ability Ability(string abilityName)
		{
			return new Ability(GetMember("Ability", abilityName.ToString()));
		}

        /// <summary>
        /// Seconds you have been casting the current spell/ability
        /// </summary>
        public float CastTimeSoFar
        {
            get
            {
                return GetMember<float>("CastTimeSoFar");
            }
        }

        public int MP
        {
            get
            {
                return GetMember<int>("MP");
            }
        }

        public int MaxMP
        {
            get
            {
                return GetMember<int>("MaxMP");
            }
        }

        public int DP
        {
            get
            {
                return GetMember<int>("DP");
            }
        }

        public int MaxDP
        {
            get
            {
                return GetMember<int>("MaxDP");
            }
        }

        public int XP
        {
            get
            {
                return GetMember<int>("XP");
            }
        }
        /// <summary>
        /// XP to next level would be Me.MaxXP-Me.XP
        /// </summary>
        public int MaxXP
        {
            get
            {
                return GetMember<int>("MaxXP");
            }
        }

        /// <summary>
        /// in seconds
        /// </summary>
        public float FlightTime
        {
            get
            {
                return GetMember<float>("FlightTime");
            }
        }

        /// <summary>
        /// in seconds
        /// </summary>
        public float MaxFlightTime
        {
            get
            {
                return GetMember<float>("MaxFlightTime");
            }
        }

        public int Kinah
        {
            get
            {
                return GetMember<int>("Kinah");
            }
        }

        public int OpenCubeSlots
        {
            get
            {
                return GetMember<int>("OpenCubeSlots");
            }
        }

        public int UsedCubeSlots
        {
            get
            {
                return GetMember<int>("UsedCubeSlots");
            }
        }

        public int MaxCubeSlots
        {
            get
            {
                return GetMember<int>("MaxCubeSlots");
            }
        }

		/// <summary>
		/// Also return TRUE if you're using an item or entity
		/// </summary>
        public bool IsCasting
        {
            get
            {
                return GetMember<bool>("IsCasting");
            }
        }
        #endregion

		#region Methods
		/// <summary>
		/// It is safe to use this method at any point.  If the character is not currently on 'auto follow' the method will do nothing.
		/// </summary>
		/// <returns></returns>
		public bool StopAutoFollow()
		{
			return ExecuteMethod("StopAutoFollow");
		}

		public bool Quit()
		{
			return ExecuteMethod("Quit");
		}

		public bool Logout()
		{
			return ExecuteMethod("Logout");
		}

		public bool Characters()
		{
			return ExecuteMethod("Characters");
		}

		/// <summary>
		///  This method will avoid the annoying popup window; however, it will still do all of the appropriate checks.
		///  Therefore, the script will need to check for failure by accessing entity.IsMentor.
		/// </summary>
		public bool MentorTarget()
		{
			return ExecuteMethod("MentorTarget");
		}

		/// <summary>
		/// This method will silently fail if the character is not currently mentoring.
		/// i.e., you do not have to check "IsMentor" before calling this method.
		/// </summary>
		public bool StopMentoring()
		{
			return ExecuteMethod("StopMentoring");
		}

		/// <summary>
		/// Toggle auto-follow on your current target
		/// </summary>
		public new bool Follow()
		{
			return ExecuteMethod("Follow");
		}

		/// <summary>
		/// Toggle auto-follow on the ID# of the player you wish to follow.
		/// </summary>
		public bool Follow(int id)
		{
			return ExecuteMethod("Follow", id.ToString());
		}

		public bool InviteToGroup(string name)
		{
			return ExecuteMethod("InviteToGroup", name);
		}

		/// <summary>
		/// ~ This function duplicates the action that occurs when you click on an entity after it has already been targetted.
		///   For non-attackable types, it will move you to the target and interact with it.  For attackable targets, it will
		///   move you to the target and begin auto-attack.  
		/// ~ If the "No Interaction" parameter is used, then for NON-attackable types, you will simply move to the target and stop.
		/// ~ This method currently works for PCs, NPCs, gatherables, lootables, and most all interactable objects that can be 
		///   targeted.
		/// ~ Unlike the in-game mechanics, if you try to "ClickTarget" on a corpse that you cannot loot, or a gatherable that is
		///   above your level, the method will do nothing.
		/// </summary>
		public bool ClickTarget(bool noInteraction = false)
		{
			if (noInteraction)
				return ExecuteMethod("ClickTarget", "No Interaction");
			else
				return ExecuteMethod("ClickTarget");
		}

		/// <summary>
		/// 'uses' the ability (in your abilities list) called "Toggle Rest"
		/// </summary>
		public bool ToggleResting()
        {
            return ExecuteMethod("ToggleResting");
        }

		/// <summary>
		/// 'uses' the ability (in your abilities list) called "Toggle Combat"
		/// </summary>
        public bool ToggleCombat()
        {
            return ExecuteMethod("ToggleCombat");
        }

		/// <summary>
		/// 'uses' the ability (in your abilities list) called "Change Weapon"
		/// </summary>
        public bool ChangeWeapon()
        {
            return ExecuteMethod("ChangeWeapon");
        }

		public bool ClearTarget()
        {
            return ExecuteMethod("ClearTarget");
        }

        /// <summary>
        /// Start Riseing. Or use Rise("tap") to just tap the Raise key
        /// </summary>
        public bool Rise(string tap)
        {
            if (tap == "tap")
                return ExecuteMethod("Rise", "tap");

            return ExecuteMethod("Rise");
        }

        /// <summary>
        /// Start Falling. Or use Fall("tap") to just tap the Fall key
        /// </summary>
        public bool Fall(string tap)
        {
            if (tap == "tap")
                return ExecuteMethod("Fall", "tap");

            return ExecuteMethod("Fall");
        }

        /// <summary>
        /// Move(direction) Continuous Movement in that direction
        /// Move(direction,"tap") one single tap of the "movement key"
        /// 'direction' can be:  Forward, Backward, Left, Right, LeftForward, RightForward, LeftBackward, RightBackward
        /// </summary>
        public bool Move(string direction, string tap)
        {
            if (tap == "tap")
                return ExecuteMethod("Move", direction, "tap");

            return ExecuteMethod("Move", direction);
        }

        /// <summary>
        /// Stop all movement
        /// </summary>
        public bool StopMoving()
        {
            return ExecuteMethod("StopMoving");
        }

        /// <summary>
        /// Spread wings and take flight
		/// 'uses' the ability (in your abilities list) called "Toggle Flight/Landing"
        /// </summary>
        public bool TakeOff()
        {
            return ExecuteMethod("TakeOff");
        }

        /// <summary>
        /// Stop flying/Put your wings away
		/// 'uses' the ability (in your abilities list) called "Toggle Flight/Landing"
        /// </summary>
        public bool Land()
        {
            return ExecuteMethod("Land");
        }
        #endregion
	}

	public class Me : Character
	{
		public Me()
			: base()
		{
		}
	}
}
