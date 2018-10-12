namespace SuperLobbyTool
{
	// Token: 0x0200000D RID: 13
	public partial class DialogBoxChangelog : global::System.Windows.Forms.Form
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00008D0F File Offset: 0x00006F0F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00008D30 File Offset: 0x00006F30
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.TextBoxChangelog = new global::System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel19 = new global::System.Windows.Forms.TableLayoutPanel();
			this.ButtonClose = new global::System.Windows.Forms.Button();
			this.ToolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel19.SuspendLayout();
			base.SuspendLayout();
			this.TextBoxChangelog.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TextBoxChangelog.Location = new global::System.Drawing.Point(6, 6);
			this.TextBoxChangelog.Name = "TextBoxChangelog";
			this.TextBoxChangelog.ReadOnly = true;
			this.TextBoxChangelog.Size = new global::System.Drawing.Size(515, 508);
			this.TextBoxChangelog.TabIndex = 0;
			this.TextBoxChangelog.Text = "[Changelog]";
			this.ToolTip.SetToolTip(this.TextBoxChangelog, "Detailed list of changed made to Super Lobby Tool.");
			this.tableLayoutPanel19.ColumnCount = 1;
			this.tableLayoutPanel19.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel19.Controls.Add(this.TextBoxChangelog, 0, 0);
			this.tableLayoutPanel19.Controls.Add(this.ButtonClose, 0, 1);
			this.tableLayoutPanel19.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel19.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel19.Name = "tableLayoutPanel19";
			this.tableLayoutPanel19.Padding = new global::System.Windows.Forms.Padding(3);
			this.tableLayoutPanel19.RowCount = 2;
			this.tableLayoutPanel19.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel19.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 43f));
			this.tableLayoutPanel19.Size = new global::System.Drawing.Size(527, 563);
			this.tableLayoutPanel19.TabIndex = 2;
			this.ButtonClose.Anchor = global::System.Windows.Forms.AnchorStyles.Top;
			this.ButtonClose.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.ButtonClose.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonClose.Location = new global::System.Drawing.Point(181, 520);
			this.ButtonClose.Name = "ButtonClose";
			this.ButtonClose.Size = new global::System.Drawing.Size(165, 37);
			this.ButtonClose.TabIndex = 1;
			this.ButtonClose.Text = "Close";
			this.ToolTip.SetToolTip(this.ButtonClose, "Close the changelog.");
			this.ButtonClose.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.ButtonClose;
			base.ClientSize = new global::System.Drawing.Size(527, 563);
			base.ControlBox = false;
			base.Controls.Add(this.tableLayoutPanel19);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "DialogBoxChangelog";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Changelog";
			this.tableLayoutPanel19.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000081 RID: 129
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000082 RID: 130
		internal global::System.Windows.Forms.RichTextBox TextBoxChangelog;

		// Token: 0x04000083 RID: 131
		internal global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;

		// Token: 0x04000084 RID: 132
		internal global::System.Windows.Forms.Button ButtonClose;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.ToolTip ToolTip;
	}
}
