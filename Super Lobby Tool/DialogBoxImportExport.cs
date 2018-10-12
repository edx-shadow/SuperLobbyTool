using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace SuperLobbyTool
{
	// Token: 0x02000006 RID: 6
	public partial class DialogBoxImportExport : Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000333E File Offset: 0x0000153E
		public DialogBoxImportExport()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000334C File Offset: 0x0000154C
		private void CheckBoxEncryptedText_Click(object sender, EventArgs e)
		{
			if (this.CheckBoxEncryptedText.Checked)
			{
				this.EncryptTextBox();
			}
			else
			{
				this.DecryptTextBox();
			}
			this.TextBoxImportExport.Select();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003374 File Offset: 0x00001574
		public void EncryptTextBox()
		{
			this.TextBoxImportExport.Lines = new string[]
			{
				RijndaelManagedEncryption.EncryptRijndael(string.Join("\n", this.TextBoxImportExport.Lines))
			};
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000033A4 File Offset: 0x000015A4
		public void DecryptTextBox()
		{
			if (this.TextBoxImportExport.Lines.Length != 0)
			{
				this.TextBoxImportExport.Lines = RijndaelManagedEncryption.DecryptRijndael(this.TextBoxImportExport.Lines[0]).Split("\n".ToCharArray());
			}
		}
	}
}
