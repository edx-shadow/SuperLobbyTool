using System;
using System.Configuration;
using System.Drawing;

namespace SuperLobbyTool
{
	// Token: 0x02000023 RID: 35
	public class BackgroundElement : ConfigurationElementEx
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00016878 File Offset: 0x00014A78
		// (set) Token: 0x0600010D RID: 269 RVA: 0x000165FC File Offset: 0x000147FC
		[ConfigurationProperty("Enabled", DefaultValue = true)]
		public bool Enabled
		{
			get
			{
				bool result;
				try
				{
					result = (bool)base["Enabled"];
				}
				catch
				{
					result = true;
				}
				return result;
			}
			set
			{
				base["Enabled"] = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000168B0 File Offset: 0x00014AB0
		// (set) Token: 0x0600010F RID: 271 RVA: 0x000168EC File Offset: 0x00014AEC
		[ConfigurationProperty("Colour")]
		public Color Colour
		{
			get
			{
				Color result;
				try
				{
					result = (Color)base["Colour"];
				}
				catch
				{
					result = Color.Purple;
				}
				return result;
			}
			set
			{
				base["Colour"] = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00016900 File Offset: 0x00014B00
		// (set) Token: 0x06000111 RID: 273 RVA: 0x00016938 File Offset: 0x00014B38
		[ConfigurationProperty("Opacity", DefaultValue = 100)]
		[IntegerValidator(MinValue = 0, MaxValue = 255, ExcludeRange = false)]
		public int Opacity
		{
			get
			{
				int result;
				try
				{
					result = (int)base["Opacity"];
				}
				catch
				{
					result = 100;
				}
				return result;
			}
			set
			{
				base["Opacity"] = value;
			}
		}
	}
}
