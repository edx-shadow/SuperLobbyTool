namespace SuperLobbyTool
{
	// Token: 0x02000010 RID: 16
	public partial class DialogBoxOverlayColumn : global::System.Windows.Forms.Form
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0000A98D File Offset: 0x00008B8D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000A9AC File Offset: 0x00008BAC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SuperLobbyTool.DialogBoxOverlayColumn));
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.GroupBoxColumnBasic = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel3 = new global::System.Windows.Forms.TableLayoutPanel();
			this.CheckBoxShowHeader = new global::System.Windows.Forms.CheckBox();
			this.LabelShowHeader = new global::System.Windows.Forms.Label();
			this.ComboBoxColumnData = new global::System.Windows.Forms.ComboBox();
			this.LabelColumnData = new global::System.Windows.Forms.Label();
			this.NumericUpDownColumnWidth = new global::System.Windows.Forms.NumericUpDown();
			this.LabelColumnWidth = new global::System.Windows.Forms.Label();
			this.CheckboxColumnEnabled = new global::System.Windows.Forms.CheckBox();
			this.LableColumnEnabled = new global::System.Windows.Forms.Label();
			this.GroupBoxColumnColours = new global::System.Windows.Forms.GroupBox();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.LabelDataColourPreview = new global::System.Windows.Forms.Label();
			this.LabelHeaderColour = new global::System.Windows.Forms.Label();
			this.LabelDataColour = new global::System.Windows.Forms.Label();
			this.ButtonHeaderColourChange = new global::System.Windows.Forms.Button();
			this.ButtonDataColourChange = new global::System.Windows.Forms.Button();
			this.LabelHeaderColourPreview = new global::System.Windows.Forms.Label();
			this.ButtonColumnCancel = new global::System.Windows.Forms.Button();
			this.ButtonColumnConfirm = new global::System.Windows.Forms.Button();
			this.ColourDialogColumn = new global::System.Windows.Forms.ColorDialog();
			this.ToolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.GroupBoxColumnBasic.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDownColumnWidth).BeginInit();
			this.GroupBoxColumnColours.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.Controls.Add(this.GroupBoxColumnBasic, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.GroupBoxColumnColours, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ButtonColumnCancel, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.ButtonColumnConfirm, 0, 2);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new global::System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 155f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 41f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(230, 319);
			this.tableLayoutPanel1.TabIndex = 17;
			this.tableLayoutPanel1.SetColumnSpan(this.GroupBoxColumnBasic, 2);
			this.GroupBoxColumnBasic.Controls.Add(this.tableLayoutPanel3);
			this.GroupBoxColumnBasic.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBoxColumnBasic.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBoxColumnBasic.Location = new global::System.Drawing.Point(5, 5);
			this.GroupBoxColumnBasic.Name = "GroupBoxColumnBasic";
			this.GroupBoxColumnBasic.Size = new global::System.Drawing.Size(220, 149);
			this.GroupBoxColumnBasic.TabIndex = 0;
			this.GroupBoxColumnBasic.TabStop = false;
			this.GroupBoxColumnBasic.Text = "Basic";
			this.ToolTip.SetToolTip(this.GroupBoxColumnBasic, "Basic options for this column.");
			this.tableLayoutPanel3.ColumnCount = 3;
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 86f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 19f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel3.Controls.Add(this.CheckBoxShowHeader, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.LabelShowHeader, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.ComboBoxColumnData, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.LabelColumnData, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.NumericUpDownColumnWidth, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.LabelColumnWidth, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.CheckboxColumnEnabled, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.LableColumnEnabled, 0, 0);
			this.tableLayoutPanel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.Padding = new global::System.Windows.Forms.Padding(3);
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.tableLayoutPanel3.Size = new global::System.Drawing.Size(214, 127);
			this.tableLayoutPanel3.TabIndex = 17;
			this.CheckBoxShowHeader.AutoSize = true;
			this.CheckBoxShowHeader.Checked = true;
			this.CheckBoxShowHeader.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.CheckBoxShowHeader.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CheckBoxShowHeader.Location = new global::System.Drawing.Point(92, 96);
			this.CheckBoxShowHeader.Name = "CheckBoxShowHeader";
			this.CheckBoxShowHeader.Size = new global::System.Drawing.Size(13, 25);
			this.CheckBoxShowHeader.TabIndex = 8;
			this.ToolTip.SetToolTip(this.CheckBoxShowHeader, "When enabled, the header of this column will be shown.");
			this.CheckBoxShowHeader.UseVisualStyleBackColor = true;
			this.LabelShowHeader.AutoSize = true;
			this.LabelShowHeader.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelShowHeader.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.LabelShowHeader.Location = new global::System.Drawing.Point(6, 93);
			this.LabelShowHeader.Name = "LabelShowHeader";
			this.LabelShowHeader.Size = new global::System.Drawing.Size(80, 31);
			this.LabelShowHeader.TabIndex = 7;
			this.LabelShowHeader.Text = "Show Header:";
			this.LabelShowHeader.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelShowHeader, "When enabled, the header of this column will be shown.");
			this.ComboBoxColumnData.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel3.SetColumnSpan(this.ComboBoxColumnData, 2);
			this.ComboBoxColumnData.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxColumnData.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ComboBoxColumnData.FormattingEnabled = true;
			this.ComboBoxColumnData.Items.AddRange(new object[]
			{
				"Nothing (Divider)",
				"Lobby Info",
				"Rating/Score",
				"Player ID",
				"Player Name",
				"Steam ID",
				"Character",
				"Ping",
				"Position"
			});
			this.ComboBoxColumnData.Location = new global::System.Drawing.Point(92, 66);
			this.ComboBoxColumnData.Name = "ComboBoxColumnData";
			this.ComboBoxColumnData.Size = new global::System.Drawing.Size(116, 23);
			this.ComboBoxColumnData.TabIndex = 6;
			this.ToolTip.SetToolTip(this.ComboBoxColumnData, "The information to be displayed in this column.");
			this.LabelColumnData.AutoSize = true;
			this.LabelColumnData.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelColumnData.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.LabelColumnData.Location = new global::System.Drawing.Point(6, 63);
			this.LabelColumnData.Name = "LabelColumnData";
			this.LabelColumnData.Size = new global::System.Drawing.Size(80, 30);
			this.LabelColumnData.TabIndex = 5;
			this.LabelColumnData.Text = "Data:";
			this.LabelColumnData.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelColumnData, "The data to be displayed in this column.");
			this.NumericUpDownColumnWidth.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.tableLayoutPanel3.SetColumnSpan(this.NumericUpDownColumnWidth, 2);
			this.NumericUpDownColumnWidth.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.NumericUpDownColumnWidth.Location = new global::System.Drawing.Point(92, 36);
			global::System.Windows.Forms.NumericUpDown numericUpDownColumnWidth = this.NumericUpDownColumnWidth;
			int[] array = new int[4];
			array[0] = 9999999;
			numericUpDownColumnWidth.Maximum = new decimal(array);
			this.NumericUpDownColumnWidth.Name = "NumericUpDownColumnWidth";
			this.NumericUpDownColumnWidth.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.NumericUpDownColumnWidth.Size = new global::System.Drawing.Size(116, 23);
			this.NumericUpDownColumnWidth.TabIndex = 4;
			this.ToolTip.SetToolTip(this.NumericUpDownColumnWidth, "The width of the column.\r\nFor automatic width, set this to zero.");
			this.LabelColumnWidth.AutoSize = true;
			this.LabelColumnWidth.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelColumnWidth.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.LabelColumnWidth.Location = new global::System.Drawing.Point(6, 33);
			this.LabelColumnWidth.Name = "LabelColumnWidth";
			this.LabelColumnWidth.Size = new global::System.Drawing.Size(80, 30);
			this.LabelColumnWidth.TabIndex = 3;
			this.LabelColumnWidth.Text = "Width:";
			this.LabelColumnWidth.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelColumnWidth, "The width of the column.\r\nFor automatic width, set this to zero.");
			this.CheckboxColumnEnabled.AutoSize = true;
			this.CheckboxColumnEnabled.Checked = true;
			this.CheckboxColumnEnabled.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.CheckboxColumnEnabled.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.CheckboxColumnEnabled.Location = new global::System.Drawing.Point(92, 6);
			this.CheckboxColumnEnabled.Name = "CheckboxColumnEnabled";
			this.CheckboxColumnEnabled.Size = new global::System.Drawing.Size(13, 24);
			this.CheckboxColumnEnabled.TabIndex = 2;
			this.ToolTip.SetToolTip(this.CheckboxColumnEnabled, "When enabled, this column will be shown.");
			this.CheckboxColumnEnabled.UseVisualStyleBackColor = true;
			this.LableColumnEnabled.AutoSize = true;
			this.LableColumnEnabled.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LableColumnEnabled.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.LableColumnEnabled.Location = new global::System.Drawing.Point(6, 3);
			this.LableColumnEnabled.Name = "LableColumnEnabled";
			this.LableColumnEnabled.Size = new global::System.Drawing.Size(80, 30);
			this.LableColumnEnabled.TabIndex = 1;
			this.LableColumnEnabled.Text = "Enabled:";
			this.LableColumnEnabled.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LableColumnEnabled, "When enabled, this column will be shown.");
			this.tableLayoutPanel1.SetColumnSpan(this.GroupBoxColumnColours, 2);
			this.GroupBoxColumnColours.Controls.Add(this.tableLayoutPanel2);
			this.GroupBoxColumnColours.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBoxColumnColours.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBoxColumnColours.Location = new global::System.Drawing.Point(5, 160);
			this.GroupBoxColumnColours.Name = "GroupBoxColumnColours";
			this.GroupBoxColumnColours.Size = new global::System.Drawing.Size(220, 113);
			this.GroupBoxColumnColours.TabIndex = 9;
			this.GroupBoxColumnColours.TabStop = false;
			this.GroupBoxColumnColours.Text = "Colours";
			this.ToolTip.SetToolTip(this.GroupBoxColumnColours, "Colours to be used for the text.");
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 27.22772f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 24.25743f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 48.0198f));
			this.tableLayoutPanel2.Controls.Add(this.LabelDataColourPreview, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.LabelHeaderColour, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.LabelDataColour, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.ButtonHeaderColourChange, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.ButtonDataColourChange, 2, 1);
			this.tableLayoutPanel2.Controls.Add(this.LabelHeaderColourPreview, 1, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(3, 19);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(214, 91);
			this.tableLayoutPanel2.TabIndex = 17;
			this.LabelDataColourPreview.AutoSize = true;
			this.LabelDataColourPreview.BackColor = global::System.Drawing.Color.Fuchsia;
			this.LabelDataColourPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelDataColourPreview.Location = new global::System.Drawing.Point(62, 45);
			this.LabelDataColourPreview.Name = "LabelDataColourPreview";
			this.LabelDataColourPreview.Size = new global::System.Drawing.Size(44, 43);
			this.LabelDataColourPreview.TabIndex = 14;
			this.ToolTip.SetToolTip(this.LabelDataColourPreview, "Preview of the colour used for the data.");
			this.LabelHeaderColour.AutoSize = true;
			this.LabelHeaderColour.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelHeaderColour.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.LabelHeaderColour.Location = new global::System.Drawing.Point(6, 3);
			this.LabelHeaderColour.Name = "LabelHeaderColour";
			this.LabelHeaderColour.Size = new global::System.Drawing.Size(50, 42);
			this.LabelHeaderColour.TabIndex = 10;
			this.LabelHeaderColour.Text = "Header:";
			this.LabelHeaderColour.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelHeaderColour, "Preview of the colour used for the header.");
			this.LabelDataColour.AutoSize = true;
			this.LabelDataColour.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelDataColour.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.LabelDataColour.Location = new global::System.Drawing.Point(6, 45);
			this.LabelDataColour.Name = "LabelDataColour";
			this.LabelDataColour.Size = new global::System.Drawing.Size(50, 43);
			this.LabelDataColour.TabIndex = 13;
			this.LabelDataColour.Text = "Data:";
			this.LabelDataColour.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelDataColour, "Preview of the colour used for the data.");
			this.ButtonHeaderColourChange.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonHeaderColourChange.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonHeaderColourChange.Location = new global::System.Drawing.Point(112, 6);
			this.ButtonHeaderColourChange.Name = "ButtonHeaderColourChange";
			this.ButtonHeaderColourChange.Size = new global::System.Drawing.Size(96, 36);
			this.ButtonHeaderColourChange.TabIndex = 12;
			this.ButtonHeaderColourChange.Text = "Change";
			this.ToolTip.SetToolTip(this.ButtonHeaderColourChange, "Change the colour used for the header.");
			this.ButtonHeaderColourChange.UseVisualStyleBackColor = true;
			this.ButtonHeaderColourChange.Click += new global::System.EventHandler(this.ButtonHeaderColourChange_Click);
			this.ButtonDataColourChange.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonDataColourChange.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonDataColourChange.Location = new global::System.Drawing.Point(112, 48);
			this.ButtonDataColourChange.Name = "ButtonDataColourChange";
			this.ButtonDataColourChange.Size = new global::System.Drawing.Size(96, 37);
			this.ButtonDataColourChange.TabIndex = 15;
			this.ButtonDataColourChange.Text = "Change";
			this.ToolTip.SetToolTip(this.ButtonDataColourChange, "Change the colour used for the data.");
			this.ButtonDataColourChange.UseVisualStyleBackColor = true;
			this.ButtonDataColourChange.Click += new global::System.EventHandler(this.ButtonDataColourChange_Click);
			this.LabelHeaderColourPreview.AutoSize = true;
			this.LabelHeaderColourPreview.BackColor = global::System.Drawing.Color.Red;
			this.LabelHeaderColourPreview.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelHeaderColourPreview.Location = new global::System.Drawing.Point(62, 3);
			this.LabelHeaderColourPreview.Name = "LabelHeaderColourPreview";
			this.LabelHeaderColourPreview.Size = new global::System.Drawing.Size(44, 42);
			this.LabelHeaderColourPreview.TabIndex = 11;
			this.ToolTip.SetToolTip(this.LabelHeaderColourPreview, "Preview of the colour used for the header.");
			this.ButtonColumnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.ButtonColumnCancel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonColumnCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonColumnCancel.Location = new global::System.Drawing.Point(118, 279);
			this.ButtonColumnCancel.Name = "ButtonColumnCancel";
			this.ButtonColumnCancel.Size = new global::System.Drawing.Size(107, 35);
			this.ButtonColumnCancel.TabIndex = 17;
			this.ButtonColumnCancel.Text = "Cancel";
			this.ToolTip.SetToolTip(this.ButtonColumnCancel, "Close this window.");
			this.ButtonColumnCancel.UseVisualStyleBackColor = true;
			this.ButtonColumnConfirm.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.ButtonColumnConfirm.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonColumnConfirm.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonColumnConfirm.Location = new global::System.Drawing.Point(5, 279);
			this.ButtonColumnConfirm.Name = "ButtonColumnConfirm";
			this.ButtonColumnConfirm.Size = new global::System.Drawing.Size(107, 35);
			this.ButtonColumnConfirm.TabIndex = 16;
			this.ButtonColumnConfirm.Text = "Add/Confirm";
			this.ToolTip.SetToolTip(this.ButtonColumnConfirm, "Add/confirm the options for this column, and close this window.");
			this.ButtonColumnConfirm.UseVisualStyleBackColor = true;
			base.AcceptButton = this.ButtonColumnConfirm;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			base.CancelButton = this.ButtonColumnCancel;
			base.ClientSize = new global::System.Drawing.Size(230, 319);
			base.ControlBox = false;
			base.Controls.Add(this.tableLayoutPanel1);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "DialogBoxOverlayColumn";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Column Editor";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.GroupBoxColumnBasic.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.NumericUpDownColumnWidth).EndInit();
			this.GroupBoxColumnColours.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000A1 RID: 161
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A2 RID: 162
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x040000A3 RID: 163
		private global::System.Windows.Forms.Button ButtonColumnCancel;

		// Token: 0x040000A4 RID: 164
		private global::System.Windows.Forms.GroupBox GroupBoxColumnColours;

		// Token: 0x040000A5 RID: 165
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Forms.Label LabelHeaderColour;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Label LabelDataColour;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Forms.Button ButtonHeaderColourChange;

		// Token: 0x040000A9 RID: 169
		private global::System.Windows.Forms.Button ButtonDataColourChange;

		// Token: 0x040000AA RID: 170
		private global::System.Windows.Forms.ColorDialog ColourDialogColumn;

		// Token: 0x040000AB RID: 171
		public global::System.Windows.Forms.Label LabelDataColourPreview;

		// Token: 0x040000AC RID: 172
		public global::System.Windows.Forms.Label LabelHeaderColourPreview;

		// Token: 0x040000AD RID: 173
		public global::System.Windows.Forms.Button ButtonColumnConfirm;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.GroupBox GroupBoxColumnBasic;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

		// Token: 0x040000B0 RID: 176
		public global::System.Windows.Forms.CheckBox CheckBoxShowHeader;

		// Token: 0x040000B1 RID: 177
		private global::System.Windows.Forms.Label LabelShowHeader;

		// Token: 0x040000B2 RID: 178
		public global::System.Windows.Forms.ComboBox ComboBoxColumnData;

		// Token: 0x040000B3 RID: 179
		private global::System.Windows.Forms.Label LabelColumnData;

		// Token: 0x040000B4 RID: 180
		public global::System.Windows.Forms.NumericUpDown NumericUpDownColumnWidth;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.Label LabelColumnWidth;

		// Token: 0x040000B6 RID: 182
		public global::System.Windows.Forms.CheckBox CheckboxColumnEnabled;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Label LableColumnEnabled;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.ToolTip ToolTip;
	}
}
