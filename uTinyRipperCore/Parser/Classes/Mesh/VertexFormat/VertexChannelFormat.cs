﻿using System;

namespace uTinyRipper.Classes.Meshes
{
	/// <summary>
	/// Less than 2017.1 version
	/// </summary>
	public enum VertexChannelFormat : byte
	{
		Float		= 0,
		Float16		= 1,
		Color		= 2,
		Byte		= 3,
		UInt		= 4,
	}

	public static class VertexChannelFormatV4Extension
	{
		public static VertexFormat ToVertexFormat(this VertexChannelFormat _this)
		{
			switch (_this)
			{
				case VertexChannelFormat.Float:
					return VertexFormat.Float;
				case VertexChannelFormat.Float16:
					return VertexFormat.Float16;
				case VertexChannelFormat.Color:
					return VertexFormat.Color;
				case VertexChannelFormat.Byte:
					return VertexFormat.Byte;
				case VertexChannelFormat.UInt:
					return VertexFormat.Int;

				default:
					throw new Exception(_this.ToString());
			}
		}
	}
}