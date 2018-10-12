using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x0200001F RID: 31
	public class PlayerListElement : ConfigurationElementEx
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000165C4 File Offset: 0x000147C4
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x000165FC File Offset: 0x000147FC
		[ConfigurationProperty("Enabled", DefaultValue = false)]
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

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00016610 File Offset: 0x00014810
		[ConfigurationProperty("Players")]
		[ConfigurationCollection(typeof(PlayerElement), AddItemName = "Entry", CollectionType = ConfigurationElementCollectionType.BasicMap)]
		public GenericConfigurationElementCollection<PlayerElement> Players
		{
			get
			{
				GenericConfigurationElementCollection<PlayerElement> genericConfigurationElementCollection = base["Players"] as GenericConfigurationElementCollection<PlayerElement>;
				if (genericConfigurationElementCollection != null)
				{
					return genericConfigurationElementCollection;
				}
				return new GenericConfigurationElementCollection<PlayerElement>();
			}
		}
	}
}
