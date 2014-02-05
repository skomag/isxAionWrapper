using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
    public class Aion : LavishScriptObject
	{
		#region Constructors
        public Aion(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public Aion()
            : base(LavishScript.Objects.GetObject("Aion"))
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1583
		public string GetLocalizedString(string stringIdentifier)
		{
			return GetMember<string>("GetLocalizedString", stringIdentifier);
		}
		#endregion

		#region isxAion-20130130.1465
		public bool Is3DRenderingDisabled { get { return GetMember<bool>("Is3DRenderingDisabled"); } }
		#endregion

		#region isxAion-20130130.1407
		/// <summary>
		///  All information from the 'iteminfo' datatype is taken from the sqlite3 database that isxAion creates and uses.  Therefore, all information
		///  from this datatype is available at all times, regardless of whether the item in question is available.   This MEMBER of the 'aion' 
		///  datatype allows you to retrieve this information at any time (as long as you know the items's ID#.  FYI, all items in the game are 
		///  accessible as an abilityinfo datatype.
		/// </summary>
		public ItemInfo ItemInfo(int itemID)
		{
			return new ItemInfo(GetMember("ItemInfo", itemID.ToString()));
		}
		#endregion

		#region isxAion-20130130.1099
		/// <summary>
		/// All information from the 'npcinfo' datatype is taken from the sqlite3 database that isxAion creates and uses.  Therefore, all information
        ///  from this datatype is available at all times, regardless of whether the NPC in question is within range.   This MEMBER of the 'aion' 
        ///  datatype allows you to retrieve this information at any time (as long as you know the NPC's SubTypeID#.
		/// </summary>
		public NPCInfo NPCInfo(int subTypeID)
		{
			return new NPCInfo(GetMember("NPCInfo", subTypeID.ToString()));
		}

		/// <summary>
		/// All information from the 'abilityinfo' datatype is taken from the sqlite3 database that isxAion creates and uses.  Therefore, all information 
        ///  from this datatype is available at all times, regardless of whether the player has access to the ability or not.  This MEMBER of the 'aion'
        ///  datatype allows you to retrieve this information at any time (as long as you know the ability's ID#.   FYI, all abilities in the game are 
        ///  accessible as an abilityinfo datatype.
		/// </summary>
		public AbilityInfo AbilityInfo(int abilityID)
		{
			return new AbilityInfo(GetMember("AbilityInfo", abilityID.ToString()));
		}
		#endregion

		#region isxAion-20130130.0912
		public uint ZoneID { get { return GetMember<uint>("ZoneID"); } }

		/// <summary>
		/// Current location
		/// </summary>
		public string LocationLink()
		{
			return GetMember<string>("LocationLink");
		}

		/// <summary>
		/// current zone at X,Y
		/// </summary>
		public string LocationLink(int X, int Y)
		{
			return GetMember<string>("LocationLink", X.ToString(), Y.ToString());
		}

		/// <summary>
		/// ZoneID at X,Y
		/// </summary>
		public string LocationLink(int ZoneID, int X, int Y)
		{
			return GetMember<string>("LocationLink", ZoneID.ToString(), X.ToString(), Y.ToString());
		}
		#endregion

		public bool BlockingAntiAFK
        {
            get
            {
                return GetMember<bool>("BlockingAntiAFK");
            }
        }
        /// <summary>
        /// The heading from you to (ToX,ToY,...)
        /// </summary>
        public float HeadingTo(float ToX, float ToY)
        {
            return GetMember<float>("HeadingTo",ToX.ToString(),ToY.ToString());
        }
        /// <summary>
        /// The heading from you to (ToX,ToY,...)
        /// </summary>
        public float Bearing(float ToX, float ToY)
        {
            return GetMember<float>("Bearing", ToX.ToString(), ToY.ToString());
        }
        /// <summary>
        /// The heading from (FromX,FromY,...) to (ToX,ToY,...)
        /// </summary>
        public float HeadingTo(float FromX, float FromY, float ToX, float ToY)
        {
            return GetMember<float>("HeadingTo", FromX.ToString(), FromY.ToString(), ToX.ToString(), ToY.ToString());
        }
        /// <summary>
        /// The heading from (FromX,FromY,...) to (ToX,ToY,...)
        /// </summary>
        public float Bearing(float FromX, float FromY, float ToX, float ToY)
        {
            return GetMember<float>("Bearing", FromX.ToString(), FromY.ToString(), ToX.ToString(), ToY.ToString());
        }
        #endregion

		#region Methods 
		#region isxAion-20130130.1762
		/// <summary>
		/// The first parameter is the number of frames to render, and the second argument is how often (in number of frames.)
		/// For example, [10,100] would set isxAion to allow the game to render 10 frames every 100 frames.
		/// Setting the values to [0,0] or using the method with no arguments will disable the feature entirely (allowing the game to render normally.)
		/// Please note that although your screen may look like your lagging, etc. this method ONLY affects the game rendering on your screen.
		/// So, from the perspective of the game, your character is still moving/acting as usual.
		/// </summary>
		public bool Set3DRendering(int count = 0, int frequency = 0)
		{
			return ExecuteMethod("Set3DRendering", count.ToString(), frequency.ToString());
		}
		#endregion

		#region isxAion-20130130.1465
		/// <summary>
		/// This method stops 3D rendering in the game; however, there are some UI elements that will still 
		/// render (and look disconcerting.)  It is highly suggested to turn off the UI (hit F12 in game) before
		/// using this method.   (NOTE:  This method does not affect any other action in the game, nor does it
		/// affect innerspace scripts or console input.)
		/// </summary>
		public bool Disable3DRendering()
		{
			return ExecuteMethod("Disable3DRendering");
		}
		#endregion

		/// <summary>
        /// *TOGGLE*  This setting is persistant.
        /// </summary>
        public bool BlockAntiAFK()
        {
            return ExecuteMethod("BlockAntiAFK");
        }
        /// <summary>
        /// If no optional parameters are used, then the given List is filled with an array 
        /// of entities visible to the client at the point of creation (sorted by distance.) 
        /// The optional parameters can be anything typically used with the entity search 
        /// routines (including 'sorting' parameters).
        /// </summary>
        public List<Entity> GetEntities(params string[] Args)
        {
            return Util.GetListFromMethod<Entity>(this, "GetEntities", "entity", Args);
        }
        #endregion
    }
}
