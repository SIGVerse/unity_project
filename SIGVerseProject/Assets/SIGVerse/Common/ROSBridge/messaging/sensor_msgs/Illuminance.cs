// Generated by gencs from sensor_msgs/Illuminance.msg
// DO NOT EDIT THIS FILE BY HAND!

using System;
using System.Collections;
using System.Collections.Generic;
using SIGVerse.RosBridge;
using UnityEngine;

using SIGVerse.RosBridge.std_msgs;

namespace SIGVerse.RosBridge 
{
	namespace sensor_msgs 
	{
		[System.Serializable]
		public class Illuminance : RosMessage
		{
			public std_msgs.Header header;
			public double illuminance;
			public double variance;


			public Illuminance()
			{
				this.header = new std_msgs.Header();
				this.illuminance = 0.0;
				this.variance = 0.0;
			}

			public Illuminance(std_msgs.Header header, double illuminance, double variance)
			{
				this.header = header;
				this.illuminance = illuminance;
				this.variance = variance;
			}

			new public static string GetMessageType()
			{
				return "sensor_msgs/Illuminance";
			}

			new public static string GetMD5Hash()
			{
				return "8cf5febb0952fca9d650c3d11a81a188";
			}
		} // class Illuminance
	} // namespace sensor_msgs
} // namespace SIGVerse.ROSBridge

