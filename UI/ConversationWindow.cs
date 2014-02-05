using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace Aion.isxAion
{
	public class ConversationWindow : AionWindow
	{
		#region Constructors
		public ConversationWindow(LavishScriptObject Obj)
			: base(Obj)
		{
		}

		public ConversationWindow()
			: base(LavishScript.Objects.GetObject("ConversationWindow"))
		{
		}
		#endregion

		#region Members
		public int NumResponses { get { return GetMember<int>("NumResponses"); } }

		/// <summary>
		/// index is between 1 and conversationwindow.NumButtons
		/// </summary>
		public AionButton Response(int index)
		{
			return new AionButton(GetMember("Response", index.ToString()));
		}

		public AionButton Response(string label)
		{
			return new AionButton(GetMember("Response", label));
		}

		public int NumButtons { get { return GetMember<int>("NumButtons"); } }

		/// <summary>
		/// index is between 1 and conversationwindow.NumButtons
		/// </summary>
		public AionButton Button(int index)
		{
			return new AionButton(GetMember("Button", index.ToString()));
		}

		public AionButton Button(string label)
		{
			return new AionButton(GetMember("Button", label));
		}

		public AionUIText Dialog { get { return new AionUIText(GetMember("Dialog")); } }
		#endregion

		#region Methods
		/// <summary>
		/// This method will enable all of the buttons on the window, avoiding the need for the player to "scroll down" the
		/// text just to click Accept/OK.  However, at this point, isxAion does not handle quest reward selection, so care should
		/// be taken when using the method on a conversation window in which a reward must be selected before clicking accept/OK.
		/// </summary>
		/// <returns></returns>
		public bool EnableAllButtons()
		{
			return ExecuteMethod("EnableAllButtons");
		}
		#endregion
	}
}
