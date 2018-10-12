using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Overlay.Interface;

namespace SuperLobbyTool
{
	// Token: 0x02000010 RID: 16
	public partial class DialogBoxOverlayColumn : Form
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000A8FB File Offset: 0x00008AFB
		public DialogBoxOverlayColumn()
		{
			this.InitializeComponent();
			this.ComboBoxColumnData.SelectedIndex = 0;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000A915 File Offset: 0x00008B15
		private void ButtonHeaderColourChange_Click(object sender, EventArgs e)
		{
			this.ColourDialogColumn.Color = this.LabelHeaderColourPreview.BackColor;
			if (this.ColourDialogColumn.ShowDialog() == DialogResult.OK)
			{
				this.LabelHeaderColourPreview.BackColor = this.ColourDialogColumn.Color;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000A951 File Offset: 0x00008B51
		private void ButtonDataColourChange_Click(object sender, EventArgs e)
		{
			this.ColourDialogColumn.Color = this.LabelDataColourPreview.BackColor;
			if (this.ColourDialogColumn.ShowDialog() == DialogResult.OK)
			{
				this.LabelDataColourPreview.BackColor = this.ColourDialogColumn.Color;
			}
		}

		// Token: 0x040000A0 RID: 160
		public ColumnStruct Column;
	}
}
