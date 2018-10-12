namespace SuperLobbyTool
{
	// Token: 0x02000006 RID: 6
	public partial class DialogBoxImportExport : global::System.Windows.Forms.Form
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000033E0 File Offset: 0x000015E0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003400 File Offset: 0x00001600
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.ImportExportPanel = new global::System.Windows.Forms.TableLayoutPanel();
			this.CheckBoxEncryptedText = new global::System.Windows.Forms.CheckBox();
			this.ButtonCancel = new global::System.Windows.Forms.Button();
			this.ButtonImport = new global::System.Windows.Forms.Button();
			this.TextBoxImportExport = new global::System.Windows.Forms.TextBox();
			this.ToolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.ImportExportPanel.SuspendLayout();
			base.SuspendLayout();
			this.ImportExportPanel.ColumnCount = 2;
			this.ImportExportPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.ImportExportPanel.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.ImportExportPanel.Controls.Add(this.CheckBoxEncryptedText, 0, 0);
			this.ImportExportPanel.Controls.Add(this.ButtonCancel, 1, 2);
			this.ImportExportPanel.Controls.Add(this.ButtonImport, 0, 2);
			this.ImportExportPanel.Controls.Add(this.TextBoxImportExport, 0, 1);
			this.ImportExportPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ImportExportPanel.Location = new global::System.Drawing.Point(0, 0);
			this.ImportExportPanel.Name = "ImportExportPanel";
			this.ImportExportPanel.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.ImportExportPanel.RowCount = 3;
			this.ImportExportPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 34f));
			this.ImportExportPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.ImportExportPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 43f));
			this.ImportExportPanel.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.ImportExportPanel.Size = new global::System.Drawing.Size(298, 289);
			this.ImportExportPanel.TabIndex = 4;
			this.CheckBoxEncryptedText.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.CheckBoxEncryptedText.AutoSize = true;
			this.CheckBoxEncryptedText.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxEncryptedText.Location = new global::System.Drawing.Point(3, 3);
			this.CheckBoxEncryptedText.Name = "CheckBoxEncryptedText";
			this.CheckBoxEncryptedText.Padding = new global::System.Windows.Forms.Padding(3);
			this.CheckBoxEncryptedText.Size = new global::System.Drawing.Size(143, 28);
			this.CheckBoxEncryptedText.TabIndex = 5;
			this.CheckBoxEncryptedText.Text = "Encrypted text";
			this.CheckBoxEncryptedText.TextAlign = global::System.Drawing.ContentAlignment.BottomLeft;
			this.ToolTip.SetToolTip(this.CheckBoxEncryptedText, "When selected the text will be encrypted.\r\nIf you are sharing your banlist with someone else who\r\nis using the public edition of Super Lobby Tool, you\r\nmust use this option.");
			this.CheckBoxEncryptedText.UseVisualStyleBackColor = true;
			this.CheckBoxEncryptedText.Click += new global::System.EventHandler(this.CheckBoxEncryptedText_Click);
			this.ButtonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.ButtonCancel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonCancel.Location = new global::System.Drawing.Point(152, 249);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new global::System.Drawing.Size(143, 37);
			this.ButtonCancel.TabIndex = 2;
			this.ButtonCancel.Text = "Cancel/Close";
			this.ToolTip.SetToolTip(this.ButtonCancel, "Close this window.");
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonImport.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.ButtonImport.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonImport.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonImport.Location = new global::System.Drawing.Point(3, 249);
			this.ButtonImport.Name = "ButtonImport";
			this.ButtonImport.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.ButtonImport.Size = new global::System.Drawing.Size(143, 37);
			this.ButtonImport.TabIndex = 1;
			this.ButtonImport.Text = "Import";
			this.ToolTip.SetToolTip(this.ButtonImport, "Import all the players from this list, and close this window.");
			this.ButtonImport.UseVisualStyleBackColor = true;
			this.ImportExportPanel.SetColumnSpan(this.TextBoxImportExport, 2);
			this.TextBoxImportExport.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TextBoxImportExport.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.TextBoxImportExport.Location = new global::System.Drawing.Point(3, 37);
			this.TextBoxImportExport.Multiline = true;
			this.TextBoxImportExport.Name = "TextBoxImportExport";
			this.TextBoxImportExport.ScrollBars = global::System.Windows.Forms.ScrollBars.Both;
			this.TextBoxImportExport.Size = new global::System.Drawing.Size(292, 206);
			this.TextBoxImportExport.TabIndex = 0;
			this.ToolTip.SetToolTip(this.TextBoxImportExport, "Copy/paste your text list here.\r\nIf it is encrypted please make sure to select the\r\n\"Encrypted Text\" checkbox first.");
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.ButtonCancel;
			base.ClientSize = new global::System.Drawing.Size(298, 289);
			base.ControlBox = false;
			base.Controls.Add(this.ImportExportPanel);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "DialogBoxImportExport";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Text Import/Export";
			this.ImportExportPanel.ResumeLayout(false);
			this.ImportExportPanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001F RID: 31
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000020 RID: 32
		internal global::System.Windows.Forms.TableLayoutPanel ImportExportPanel;

		// Token: 0x04000021 RID: 33
		public global::System.Windows.Forms.Button ButtonImport;

		// Token: 0x04000022 RID: 34
		public global::System.Windows.Forms.Button ButtonCancel;

		// Token: 0x04000023 RID: 35
		public global::System.Windows.Forms.TextBox TextBoxImportExport;

		// Token: 0x04000024 RID: 36
		internal global::System.Windows.Forms.CheckBox CheckBoxEncryptedText;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ToolTip ToolTip;
	}
}
