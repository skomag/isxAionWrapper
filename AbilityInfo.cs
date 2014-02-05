using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class AbilityInfo : LavishScriptObject
	{
		#region Constructors
		public AbilityInfo(LavishScriptObject Obj)
			: base(Obj)
		{
		}
		#endregion

		#region Members
		#region isxAion-20130130.1099
		public int ID { get { return GetMember<int>("ID"); } }

		/// <summary>
		/// localized via ClientStrings
		/// </summary>
		public string Name { get { return GetMember<string>("Name"); } }

		/// <summary>
		/// localized via ClientStrings
		/// </summary>
		public string Description { get { return GetMember<string>("Description"); } }

		/// <summary>
		/// in seconds
		/// </summary>
		public float CastTime { get { return GetMember<float>("CastTime"); } }

		/// <summary>
		/// This MEMBER returns any of the fields found in the "ClientSkills" table of the AionInfo.sql3 database located in your 
		/// /innerspace/Extensions/isxAion/ClientData folder.   I suggest http://sqlitebrowser.sourceforge.net for a quick/easy way
		/// to view the contents of AionInfo.sql3.  Also, although the DB does not contain all of the fields found in the
		/// /innerspace/Extensions/isxAion/ClientData/Aion_ClientSkills.xml file, you still might find it useful as a reference (as it would be 
		/// easier to read.
		/// </summary>
		public int GetFieldValueInt(string fieldName)
		{
			return GetMember<int>("GetFieldValue", fieldName);
		}

		/// <summary>
		/// This MEMBER returns any of the fields found in the "ClientSkills" table of the AionInfo.sql3 database located in your 
		/// /innerspace/Extensions/isxAion/ClientData folder.   I suggest http://sqlitebrowser.sourceforge.net for a quick/easy way
		/// to view the contents of AionInfo.sql3.  Also, although the DB does not contain all of the fields found in the
		/// /innerspace/Extensions/isxAion/ClientData/Aion_ClientSkills.xml file, you still might find it useful as a reference (as it would be 
		/// easier to read.
		/// </summary>
		public float GetFieldValueFloat(string fieldName)
		{
			return GetMember<float>("GetFieldValue", fieldName);
		}

		/// <summary>
		/// This MEMBER returns any of the fields found in the "ClientSkills" table of the AionInfo.sql3 database located in your 
		/// /innerspace/Extensions/isxAion/ClientData folder.   I suggest http://sqlitebrowser.sourceforge.net for a quick/easy way
		/// to view the contents of AionInfo.sql3.  Also, although the DB does not contain all of the fields found in the
		/// /innerspace/Extensions/isxAion/ClientData/Aion_ClientSkills.xml file, you still might find it useful as a reference (as it would be 
		/// easier to read.
		/// </summary>
		public string GetFieldValueString(string fieldName)
		{
			return GetMember<string>("GetFieldValue", fieldName);
		}
		#endregion
		#endregion

		#region Methods
		#endregion
	}
}
