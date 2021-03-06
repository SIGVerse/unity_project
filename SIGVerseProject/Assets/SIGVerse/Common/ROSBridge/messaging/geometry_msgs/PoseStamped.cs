// Generated by gencs from geometry_msgs/PoseStamped.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.std_msgs;
using SIGVerse.RosBridge.geometry_msgs;

namespace SIGVerse.RosBridge 
{
	namespace geometry_msgs 
	{
		[System.Serializable]
		public class PoseStamped : RosMessage
		{
			public std_msgs.Header header;
			public geometry_msgs.Pose pose;


			public PoseStamped()
			{
				this.header = new std_msgs.Header();
				this.pose = new geometry_msgs.Pose();
			}

			public PoseStamped(std_msgs.Header header, geometry_msgs.Pose pose)
			{
				this.header = header;
				this.pose = pose;
			}

			new public static string GetMessageType()
			{
				return "geometry_msgs/PoseStamped";
			}

			new public static string GetMD5Hash()
			{
				return "d3812c3cbc69362b77dc0b19b345f8f5";
			}
		} // class PoseStamped
	} // namespace geometry_msgs
} // namespace SIGVerse.ROSBridge

