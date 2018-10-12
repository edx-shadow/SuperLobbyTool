using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x02000022 RID: 34
	public class PositionElement : ConfigurationElementEx
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000167E0 File Offset: 0x000149E0
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00016818 File Offset: 0x00014A18
		[ConfigurationProperty("X", DefaultValue = 5)]
		public int X
		{
			get
			{
				int result;
				try
				{
					result = (int)base["X"];
				}
				catch
				{
					result = 5;
				}
				return result;
			}
			set
			{
				base["X"] = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000109 RID: 265 RVA: 0x0001682C File Offset: 0x00014A2C
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00016864 File Offset: 0x00014A64
		[ConfigurationProperty("Y", DefaultValue = 5)]
		public int Y
		{
			get
			{
				int result;
				try
				{
					result = (int)base["Y"];
				}
				catch
				{
					result = 5;
				}
				return result;
			}
			set
			{
				base["Y"] = value;
			}
		}
	}
}
