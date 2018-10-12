namespace SuperLobbyTool
{
	// Token: 0x0200000B RID: 11
	public partial class DialogBoxLobbyLink : global::System.Windows.Forms.Form
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00005F5D File Offset: 0x0000415D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005F7C File Offset: 0x0000417C
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.ButtonClose = new global::System.Windows.Forms.Button();
			this.tableLayoutPanel19 = new global::System.Windows.Forms.TableLayoutPanel();
			this.TextBoxLink = new global::System.Windows.Forms.TextBox();
			this.ToolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel19.SuspendLayout();
			base.SuspendLayout();
			this.ButtonClose.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.ButtonClose.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.ButtonClose.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonClose.Location = new global::System.Drawing.Point(78, 37);
			this.ButtonClose.Name = "ButtonClose";
			this.ButtonClose.Size = new global::System.Drawing.Size(120, 37);
			this.ButtonClose.TabIndex = 1;
			this.ButtonClose.Text = "Close";
			this.ToolTip.SetToolTip(this.ButtonClose, "Close this window.");
			this.ButtonClose.UseVisualStyleBackColor = true;
			this.tableLayoutPanel19.ColumnCount = 1;
			this.tableLayoutPanel19.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel19.Controls.Add(this.TextBoxLink, 0, 0);
			this.tableLayoutPanel19.Controls.Add(this.ButtonClose, 0, 1);
			this.tableLayoutPanel19.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel19.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel19.Name = "tableLayoutPanel19";
			this.tableLayoutPanel19.Padding = new global::System.Windows.Forms.Padding(3);
			this.tableLayoutPanel19.RowCount = 2;
			this.tableLayoutPanel19.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel19.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 43f));
			this.tableLayoutPanel19.Size = new global::System.Drawing.Size(276, 80);
			this.tableLayoutPanel19.TabIndex = 3;
			this.TextBoxLink.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TextBoxLink.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.TextBoxLink.Location = new global::System.Drawing.Point(6, 6);
			this.TextBoxLink.Multiline = true;
			this.TextBoxLink.Name = "TextBoxLink";
			this.TextBoxLink.ReadOnly = true;
			this.TextBoxLink.Size = new global::System.Drawing.Size(264, 25);
			this.TextBoxLink.TabIndex = 0;
			this.ToolTip.SetToolTip(this.TextBoxLink, "The generated lobby link.\r\nYou can copy/paste from this box.");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.ButtonClose;
			base.ClientSize = new global::System.Drawing.Size(276, 80);
			base.ControlBox = false;
			base.Controls.Add(this.tableLayoutPanel19);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "DialogBoxLobbyLink";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Lobby Link";
			this.tableLayoutPanel19.ResumeLayout(false);
			this.tableLayoutPanel19.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400004E RID: 78
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400004F RID: 79
		internal global::System.Windows.Forms.Button ButtonClose;

		// Token: 0x04000050 RID: 80
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;

		// Token: 0x04000051 RID: 81
		public global::System.Windows.Forms.TextBox TextBoxLink;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.ToolTip ToolTip;
	}
}
