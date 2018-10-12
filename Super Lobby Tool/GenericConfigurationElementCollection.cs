using System;
using System.Configuration;
using System.Xml;

namespace SuperLobbyTool
{
	// Token: 0x0200001C RID: 28
	public class GenericConfigurationElementCollection<T> : ConfigurationElementCollection where T : ConfigurationElementEx, new()
	{
		// Token: 0x060000DE RID: 222 RVA: 0x0001639B File Offset: 0x0001459B
		protected override bool OnDeserializeUnrecognizedAttribute(string attribute, string value)
		{
			ErrorMessage.UnrecognisedConfigOption(attribute, value);
			return true;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000163BF File Offset: 0x000145BF
		protected override bool OnDeserializeUnrecognizedElement(string elementName, XmlReader reader)
		{
			if (!base.OnDeserializeUnrecognizedElement(elementName, reader))
			{
				ErrorMessage.UnrecognisedConfigSection(elementName, reader);
			}
			return true;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000163D3 File Offset: 0x000145D3
		protected override ConfigurationElement CreateNewElement()
		{
			return Activator.CreateInstance<T>();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000163DF File Offset: 0x000145DF
		protected override object GetElementKey(ConfigurationElement element)
		{
			return (T)((object)element);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000163EC File Offset: 0x000145EC
		public void Add(T element)
		{
			this.BaseAdd(element);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000163FA File Offset: 0x000145FA
		public void AddAt(int index, T element)
		{
			this.BaseAdd(index, element);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00016409 File Offset: 0x00014609
		public void Clear()
		{
			base.BaseClear();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00016411 File Offset: 0x00014611
		public int IndexOf(T element)
		{
			return base.BaseIndexOf(element);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0001641F File Offset: 0x0001461F
		public void Remove(T element)
		{
			if (base.BaseIndexOf(element) >= 0)
			{
				base.BaseRemove(element);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0001643C File Offset: 0x0001463C
		public void RemoveAt(int index)
		{
			base.BaseRemoveAt(index);
		}

		// Token: 0x17000001 RID: 1
		public T this[int index]
		{
			get
			{
				return (T)((object)base.BaseGet(index));
			}
			set
			{
				if (base.BaseGet(index) != null)
				{
					base.BaseRemoveAt(index);
				}
				this.BaseAdd(index, value);
			}
		}
	}
}
