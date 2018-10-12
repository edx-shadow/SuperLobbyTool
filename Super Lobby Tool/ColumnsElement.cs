using System;
using System.Configuration;

namespace SuperLobbyTool
{
	// Token: 0x02000025 RID: 37
	public class ColumnsElement : ConfigurationElementEx
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000118 RID: 280 RVA: 0x000169D4 File Offset: 0x00014BD4
		[ConfigurationProperty("ColumnList")]
		[ConfigurationCollection(typeof(ColumnElement), AddItemName = "Column", CollectionType = ConfigurationElementCollectionType.BasicMap)]
		public GenericConfigurationElementCollection<ColumnElement> ColumnList
		{
			get
			{
				GenericConfigurationElementCollection<ColumnElement> genericConfigurationElementCollection = base["ColumnList"] as GenericConfigurationElementCollection<ColumnElement>;
				if (genericConfigurationElementCollection != null)
				{
					return genericConfigurationElementCollection;
				}
				return new GenericConfigurationElementCollection<ColumnElement>();
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000119 RID: 281 RVA: 0x000169FC File Offset: 0x00014BFC
		[ConfigurationProperty("Additional")]
		public AdditionalElement Additional
		{
			get
			{
				AdditionalElement additionalElement = base["Additional"] as AdditionalElement;
				if (additionalElement != null)
				{
					return additionalElement;
				}
				return new AdditionalElement();
			}
		}
	}
}
