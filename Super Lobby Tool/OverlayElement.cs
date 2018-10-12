using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x02000021 RID: 33
	public class OverlayElement : ConfigurationElementEx
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00016708 File Offset: 0x00014908
		// (set) Token: 0x06000101 RID: 257 RVA: 0x000165FC File Offset: 0x000147FC
		[ConfigurationProperty("Enabled", DefaultValue = "true")]
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

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00016740 File Offset: 0x00014940
		[ConfigurationProperty("Position")]
		public PositionElement Position
		{
			get
			{
				PositionElement positionElement = base["Position"] as PositionElement;
				if (positionElement != null)
				{
					return positionElement;
				}
				return new PositionElement();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00016768 File Offset: 0x00014968
		[ConfigurationProperty("Background")]
		public BackgroundElement Background
		{
			get
			{
				BackgroundElement backgroundElement = base["Background"] as BackgroundElement;
				if (backgroundElement != null)
				{
					return backgroundElement;
				}
				return new BackgroundElement();
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00016790 File Offset: 0x00014990
		[ConfigurationProperty("Fonts")]
		public FontsElement Fonts
		{
			get
			{
				FontsElement fontsElement = base["Fonts"] as FontsElement;
				if (fontsElement != null)
				{
					return fontsElement;
				}
				return new FontsElement();
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000105 RID: 261 RVA: 0x000167B8 File Offset: 0x000149B8
		[ConfigurationProperty("Columns")]
		public ColumnsElement Columns
		{
			get
			{
				ColumnsElement columnsElement = base["Columns"] as ColumnsElement;
				if (columnsElement != null)
				{
					return columnsElement;
				}
				return new ColumnsElement();
			}
		}
	}
}
