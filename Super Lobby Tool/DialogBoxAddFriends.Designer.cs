namespace SuperLobbyTool
{
	// Token: 0x02000005 RID: 5
	public partial class DialogBoxAddFriends : global::System.Windows.Forms.Form
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002D66 File Offset: 0x00000F66
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002D88 File Offset: 0x00000F88
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.LabelHelp = new global::System.Windows.Forms.Label();
			this.ButtonCancel = new global::System.Windows.Forms.Button();
			this.ButtonConfirm = new global::System.Windows.Forms.Button();
			this.ToolTip = new global::System.Windows.Forms.ToolTip(this.components);
            this.ListView = new global::System.Windows.Forms.ListView();
            this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.tableLayoutPanel1.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.LabelHelp, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ButtonCancel, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.ButtonConfirm, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.ListView, 0, 0);
            this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 22f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 45f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(231, 451);
			this.tableLayoutPanel1.TabIndex = 37;
			this.LabelHelp.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.LabelHelp, 2);
			this.LabelHelp.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelHelp.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelHelp.Location = new global::System.Drawing.Point(3, 387);
			this.LabelHelp.Margin = new global::System.Windows.Forms.Padding(3);
			this.LabelHelp.Name = "LabelHelp";
			this.LabelHelp.Size = new global::System.Drawing.Size(225, 16);
			this.LabelHelp.TabIndex = 36;
			this.LabelHelp.Text = "Hold Ctrl to select multiple friends.";
			this.LabelHelp.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.ButtonCancel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonCancel.Location = new global::System.Drawing.Point(118, 409);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new global::System.Drawing.Size(110, 39);
			this.ButtonCancel.TabIndex = 35;
			this.ButtonCancel.Text = "Cancel";
			this.ToolTip.SetToolTip(this.ButtonCancel, "Close this window, without adding any friends.");
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonConfirm.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.ButtonConfirm.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonConfirm.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonConfirm.Location = new global::System.Drawing.Point(3, 409);
			this.ButtonConfirm.Name = "ButtonConfirm";
			this.ButtonConfirm.Size = new global::System.Drawing.Size(109, 39);
			this.ButtonConfirm.TabIndex = 34;
			this.ButtonConfirm.Text = "Add";
			this.ToolTip.SetToolTip(this.ButtonConfirm, "Add the selected friends, and close this window.");
			this.ButtonConfirm.UseVisualStyleBackColor = true;
			this.ListView.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1
			});
			this.tableLayoutPanel1.SetColumnSpan(this.ListView, 2);
			this.ListView.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ListView.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.ListView.FullRowSelect = true;
			this.ListView.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ListView.HideSelection = false;
			this.ListView.Location = new global::System.Drawing.Point(3, 3);
			this.ListView.Name = "ListView";
			this.ListView.Size = new global::System.Drawing.Size(225, 378);
			this.ListView.TabIndex = 2;
			this.ToolTip.SetToolTip(this.ListView, "List of all your Steam friends.");
			this.ListView.UseCompatibleStateImageBehavior = false;
			this.ListView.View = global::System.Windows.Forms.View.Details;
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 204;
			base.AcceptButton = this.ButtonConfirm;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.ButtonCancel;
			base.ClientSize = new global::System.Drawing.Size(231, 451);
			base.ControlBox = false;
			base.Controls.Add(this.tableLayoutPanel1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "DialogBoxAddFriends";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add Friends";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000017 RID: 23
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000019 RID: 25
		public global::System.Windows.Forms.Button ButtonCancel;

		// Token: 0x0400001A RID: 26
		public global::System.Windows.Forms.Button ButtonConfirm;

		// Token: 0x0400001B RID: 27
		public global::System.Windows.Forms.ListView ListView;

		// Token: 0x0400001C RID: 28
		internal global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label LabelHelp;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolTip ToolTip;
	}
}
