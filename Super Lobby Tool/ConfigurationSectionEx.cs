using System;
using System.Configuration;
using System.Xml;

namespace SuperLobbyTool
{
	// Token: 0x0200001A RID: 26
	public class ConfigurationSectionEx : ConfigurationSection
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x0001639B File Offset: 0x0001459B
		protected override bool OnDeserializeUnrecognizedAttribute(string attribute, string value)
		{
			ErrorMessage.UnrecognisedConfigOption(attribute, value);
			return true;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000163A5 File Offset: 0x000145A5
		protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader)
		{
			ErrorMessage.UnrecognisedConfigSection(elementName, reader);
			return true;
		}
	}
}
