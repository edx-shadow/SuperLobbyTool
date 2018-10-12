namespace SuperLobbyTool
{
	// Token: 0x02000011 RID: 17
	public partial class DialogBoxPlayer : global::System.Windows.Forms.Form
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000BDAB File Offset: 0x00009FAB
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000BDCC File Offset: 0x00009FCC
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.TextBoxPlayerSteamID = new System.Windows.Forms.TextBox();
            this.TextBoxPlayerName = new System.Windows.Forms.TextBox();
            this.LabelPlayerSteamID = new System.Windows.Forms.Label();
            this.LabelPlayerName = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LabelPlayerEnabled = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonConfirm = new System.Windows.Forms.Button();
            this.CheckBoxPlayerEnabled = new System.Windows.Forms.CheckBox();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxPlayerSteamID
            // 
            this.TextBoxPlayerSteamID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.SetColumnSpan(this.TextBoxPlayerSteamID, 2);
            this.TextBoxPlayerSteamID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPlayerSteamID.Location = new System.Drawing.Point(77, 57);
            this.TextBoxPlayerSteamID.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPlayerSteamID.Name = "TextBoxPlayerSteamID";
            this.TextBoxPlayerSteamID.Size = new System.Drawing.Size(166, 23);
            this.TextBoxPlayerSteamID.TabIndex = 1;
            this.ToolTip1.SetToolTip(this.TextBoxPlayerSteamID, "The Steam ID of the player.\r\nThis is required to uniquely identify the player.");
            // 
            // TextBoxPlayerName
            // 
            this.TextBoxPlayerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.SetColumnSpan(this.TextBoxPlayerName, 2);
            this.TextBoxPlayerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxPlayerName.Location = new System.Drawing.Point(77, 31);
            this.TextBoxPlayerName.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxPlayerName.Name = "TextBoxPlayerName";
            this.TextBoxPlayerName.Size = new System.Drawing.Size(166, 23);
            this.TextBoxPlayerName.TabIndex = 0;
            this.ToolTip1.SetToolTip(this.TextBoxPlayerName, "The name of the player.");
            // 
            // LabelPlayerSteamID
            // 
            this.LabelPlayerSteamID.AutoSize = true;
            this.LabelPlayerSteamID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPlayerSteamID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelPlayerSteamID.Location = new System.Drawing.Point(5, 55);
            this.LabelPlayerSteamID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPlayerSteamID.Name = "LabelPlayerSteamID";
            this.LabelPlayerSteamID.Size = new System.Drawing.Size(68, 26);
            this.LabelPlayerSteamID.TabIndex = 5;
            this.LabelPlayerSteamID.Text = "Steam ID:";
            this.LabelPlayerSteamID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip1.SetToolTip(this.LabelPlayerSteamID, "The Steam ID of the player.\r\nThis is required to uniquely identify the player.");
            // 
            // LabelPlayerName
            // 
            this.LabelPlayerName.AutoSize = true;
            this.LabelPlayerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPlayerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelPlayerName.Location = new System.Drawing.Point(5, 29);
            this.LabelPlayerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPlayerName.Name = "LabelPlayerName";
            this.LabelPlayerName.Size = new System.Drawing.Size(68, 26);
            this.LabelPlayerName.TabIndex = 6;
            this.LabelPlayerName.Text = "Name:";
            this.LabelPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip1.SetToolTip(this.LabelPlayerName, "The name of the player.");
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.TableLayoutPanel1.SetColumnSpan(this.LabelTitle, 3);
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.Location = new System.Drawing.Point(5, 3);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(238, 26);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Add / edit this player:";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.ColumnCount = 3;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.LabelPlayerEnabled, 0, 3);
            this.TableLayoutPanel1.Controls.Add(this.TextBoxPlayerSteamID, 1, 2);
            this.TableLayoutPanel1.Controls.Add(this.TextBoxPlayerName, 1, 1);
            this.TableLayoutPanel1.Controls.Add(this.LabelPlayerSteamID, 0, 2);
            this.TableLayoutPanel1.Controls.Add(this.LabelPlayerName, 0, 1);
            this.TableLayoutPanel1.Controls.Add(this.LabelTitle, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.ButtonCancel, 1, 4);
            this.TableLayoutPanel1.Controls.Add(this.ButtonConfirm, 0, 4);
            this.TableLayoutPanel1.Controls.Add(this.CheckBoxPlayerEnabled, 1, 3);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.TableLayoutPanel1.RowCount = 5;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(248, 152);
            this.TableLayoutPanel1.TabIndex = 8;
            // 
            // LabelPlayerEnabled
            // 
            this.LabelPlayerEnabled.AutoSize = true;
            this.LabelPlayerEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelPlayerEnabled.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelPlayerEnabled.Location = new System.Drawing.Point(5, 81);
            this.LabelPlayerEnabled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelPlayerEnabled.Name = "LabelPlayerEnabled";
            this.LabelPlayerEnabled.Size = new System.Drawing.Size(68, 26);
            this.LabelPlayerEnabled.TabIndex = 9;
            this.LabelPlayerEnabled.Text = "Enabled:";
            this.LabelPlayerEnabled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolTip1.SetToolTip(this.LabelPlayerEnabled, "When disabled this entry will be ignored, however it will still show on the list." +
        "");
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ButtonCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonCancel.Location = new System.Drawing.Point(125, 109);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(118, 38);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ToolTip1.SetToolTip(this.ButtonCancel, "Close this window.");
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonConfirm
            // 
            this.TableLayoutPanel1.SetColumnSpan(this.ButtonConfirm, 2);
            this.ButtonConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ButtonConfirm.Location = new System.Drawing.Point(5, 109);
            this.ButtonConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(116, 38);
            this.ButtonConfirm.TabIndex = 3;
            this.ButtonConfirm.Text = "Add/Confirm";
            this.ToolTip1.SetToolTip(this.ButtonConfirm, "Add/Confirm changes for this player, and close this window.");
            this.ButtonConfirm.UseVisualStyleBackColor = true;
            // 
            // CheckBoxPlayerEnabled
            // 
            this.CheckBoxPlayerEnabled.AutoSize = true;
            this.CheckBoxPlayerEnabled.Checked = true;
            this.CheckBoxPlayerEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxPlayerEnabled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxPlayerEnabled.Location = new System.Drawing.Point(77, 83);
            this.CheckBoxPlayerEnabled.Margin = new System.Windows.Forms.Padding(2);
            this.CheckBoxPlayerEnabled.Name = "CheckBoxPlayerEnabled";
            this.CheckBoxPlayerEnabled.Size = new System.Drawing.Size(44, 22);
            this.CheckBoxPlayerEnabled.TabIndex = 2;
            this.ToolTip1.SetToolTip(this.CheckBoxPlayerEnabled, "When disabled this entry will be ignored, however it will still show on the list." +
        "\r\n");
            this.CheckBoxPlayerEnabled.UseVisualStyleBackColor = true;
            // 
            // DialogBoxPlayer
            // 
            this.AcceptButton = this.ButtonConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(248, 152);
            this.ControlBox = false;
            this.Controls.Add(this.TableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DialogBoxPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Banlist Editor";
            this.TableLayoutPanel1.ResumeLayout(false);
            this.TableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x040000B9 RID: 185
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000BA RID: 186
		internal global::System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;

		// Token: 0x040000BB RID: 187
		internal global::System.Windows.Forms.Label LabelPlayerSteamID;

		// Token: 0x040000BC RID: 188
		internal global::System.Windows.Forms.Label LabelPlayerName;

		// Token: 0x040000BD RID: 189
		internal global::System.Windows.Forms.Label LabelTitle;

		// Token: 0x040000BE RID: 190
		internal global::System.Windows.Forms.Label LabelPlayerEnabled;

		// Token: 0x040000BF RID: 191
		internal global::System.Windows.Forms.Button ButtonCancel;

		// Token: 0x040000C0 RID: 192
		internal global::System.Windows.Forms.Button ButtonConfirm;

		// Token: 0x040000C1 RID: 193
		public global::System.Windows.Forms.TextBox TextBoxPlayerName;

		// Token: 0x040000C2 RID: 194
		public global::System.Windows.Forms.CheckBox CheckBoxPlayerEnabled;

		// Token: 0x040000C3 RID: 195
		public global::System.Windows.Forms.TextBox TextBoxPlayerSteamID;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.ToolTip ToolTip1;
	}
}
