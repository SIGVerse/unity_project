// Generated by gencs from std_msgs/Int64MultiArray.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.std_msgs;

namespace SIGVerse.RosBridge 
{
	namespace std_msgs 
	{
		[System.Serializable]
		public class Int64MultiArray : RosMessage
		{
			public std_msgs.MultiArrayLayout layout;
			public System.Collections.Generic.List<System.Int64>  data;


			public Int64MultiArray()
			{
				this.layout = new std_msgs.MultiArrayLayout();
				this.data = new System.Collections.Generic.List<System.Int64>();
			}

			public Int64MultiArray(std_msgs.MultiArrayLayout layout, System.Collections.Generic.List<System.Int64>  data)
			{
				this.layout = layout;
				this.data = data;
			}

			new public static string GetMessageType()
			{
				return "std_msgs/Int64MultiArray";
			}

			new public static string GetMD5Hash()
			{
				return "54865aa6c65be0448113a2afc6a49270";
			}
		} // class Int64MultiArray
	} // namespace std_msgs
} // namespace SIGVerse.ROSBridge

