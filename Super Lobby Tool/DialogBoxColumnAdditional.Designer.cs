namespace SuperLobbyTool
{
	// Token: 0x0200000F RID: 15
	public partial class DialogBoxColumnAdditional : global::System.Windows.Forms.Form
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000090F9 File Offset: 0x000072F9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00009118 File Offset: 0x00007318
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SuperLobbyTool.DialogBoxColumnAdditional));
			this.TableLayoutPanelLobbyDetails = new global::System.Windows.Forms.TableLayoutPanel();
			this.ButtonCancel = new global::System.Windows.Forms.Button();
			this.ButtonConfirm = new global::System.Windows.Forms.Button();
			this.TabControlAdditionalOptions = new global::System.Windows.Forms.TabControl();
			this.LobbyInfoTab = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.CheckBoxShortLobbyInfoNames = new global::System.Windows.Forms.CheckBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.CheckBoxPlayerCount = new global::System.Windows.Forms.CheckBox();
			this.CheckBoxType = new global::System.Windows.Forms.CheckBox();
			this.CheckBoxHost = new global::System.Windows.Forms.CheckBox();
			this.CheckBoxDifficulty = new global::System.Windows.Forms.CheckBox();
			this.CheckBoxEvent = new global::System.Windows.Forms.CheckBox();
			this.CheckBoxTrack = new global::System.Windows.Forms.CheckBox();
			this.CheckBoxId = new global::System.Windows.Forms.CheckBox();
			this.LabelBasicInfo = new global::System.Windows.Forms.Label();
			this.PlayerNameTab = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new global::System.Windows.Forms.TableLayoutPanel();
			this.CheckBoxShortPlayerNames = new global::System.Windows.Forms.CheckBox();
			this.CharacterTab = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.CheckBoxShortCharacterNames = new global::System.Windows.Forms.CheckBox();
			this.ToolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.TableLayoutPanelLobbyDetails.SuspendLayout();
			this.TabControlAdditionalOptions.SuspendLayout();
			this.LobbyInfoTab.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.PlayerNameTab.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.CharacterTab.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanelLobbyDetails.ColumnCount = 2;
			this.TableLayoutPanelLobbyDetails.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanelLobbyDetails.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanelLobbyDetails.Controls.Add(this.ButtonCancel, 1, 1);
			this.TableLayoutPanelLobbyDetails.Controls.Add(this.ButtonConfirm, 0, 1);
			this.TableLayoutPanelLobbyDetails.Controls.Add(this.TabControlAdditionalOptions, 0, 0);
			this.TableLayoutPanelLobbyDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanelLobbyDetails.Location = new global::System.Drawing.Point(0, 0);
			this.TableLayoutPanelLobbyDetails.Name = "TableLayoutPanelLobbyDetails";
			this.TableLayoutPanelLobbyDetails.RowCount = 2;
			this.TableLayoutPanelLobbyDetails.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 89.53168f));
			this.TableLayoutPanelLobbyDetails.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.46832f));
			this.TableLayoutPanelLobbyDetails.Size = new global::System.Drawing.Size(245, 359);
			this.TableLayoutPanelLobbyDetails.TabIndex = 18;
			this.ButtonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.ButtonCancel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonCancel.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonCancel.Location = new global::System.Drawing.Point(125, 324);
			this.ButtonCancel.Name = "ButtonCancel";
			this.ButtonCancel.Size = new global::System.Drawing.Size(117, 32);
			this.ButtonCancel.TabIndex = 9;
			this.ButtonCancel.Text = "Cancel";
			this.ToolTip.SetToolTip(this.ButtonCancel, "Close this window without applying any changes.");
			this.ButtonCancel.UseVisualStyleBackColor = true;
			this.ButtonConfirm.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.ButtonConfirm.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonConfirm.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonConfirm.Location = new global::System.Drawing.Point(3, 324);
			this.ButtonConfirm.Name = "ButtonConfirm";
			this.ButtonConfirm.Size = new global::System.Drawing.Size(116, 32);
			this.ButtonConfirm.TabIndex = 8;
			this.ButtonConfirm.Text = "Confirm";
			this.ToolTip.SetToolTip(this.ButtonConfirm, "Close this window and apply all changes made to these options.");
			this.ButtonConfirm.UseVisualStyleBackColor = true;
			this.TableLayoutPanelLobbyDetails.SetColumnSpan(this.TabControlAdditionalOptions, 2);
			this.TabControlAdditionalOptions.Controls.Add(this.LobbyInfoTab);
			this.TabControlAdditionalOptions.Controls.Add(this.PlayerNameTab);
			this.TabControlAdditionalOptions.Controls.Add(this.CharacterTab);
			this.TabControlAdditionalOptions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TabControlAdditionalOptions.Location = new global::System.Drawing.Point(3, 3);
			this.TabControlAdditionalOptions.Name = "TabControlAdditionalOptions";
			this.TabControlAdditionalOptions.SelectedIndex = 0;
			this.TabControlAdditionalOptions.Size = new global::System.Drawing.Size(239, 315);
			this.TabControlAdditionalOptions.TabIndex = 0;
			this.LobbyInfoTab.Controls.Add(this.tableLayoutPanel1);
			this.LobbyInfoTab.Location = new global::System.Drawing.Point(4, 24);
			this.LobbyInfoTab.Name = "LobbyInfoTab";
			this.LobbyInfoTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.LobbyInfoTab.Size = new global::System.Drawing.Size(231, 287);
			this.LobbyInfoTab.TabIndex = 1;
			this.LobbyInfoTab.Text = "Lobby Info";
			this.LobbyInfoTab.UseVisualStyleBackColor = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Controls.Add(this.CheckBoxShortLobbyInfoNames, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.CheckBoxPlayerCount, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.CheckBoxType, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.CheckBoxHost, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.CheckBoxDifficulty, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.CheckBoxEvent, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.CheckBoxTrack, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.CheckBoxId, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.LabelBasicInfo, 0, 1);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.0001f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.0001f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.0001f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.0001f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.0001f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.0001f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.0001f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.0001f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.0001f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 9.999102f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(225, 281);
			this.tableLayoutPanel1.TabIndex = 4;
			this.CheckBoxShortLobbyInfoNames.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.CheckBoxShortLobbyInfoNames, 2);
			this.CheckBoxShortLobbyInfoNames.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.CheckBoxShortLobbyInfoNames.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxShortLobbyInfoNames.Location = new global::System.Drawing.Point(3, 3);
			this.CheckBoxShortLobbyInfoNames.Name = "CheckBoxShortLobbyInfoNames";
			this.CheckBoxShortLobbyInfoNames.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxShortLobbyInfoNames.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxShortLobbyInfoNames.TabIndex = 14;
			this.CheckBoxShortLobbyInfoNames.Text = "Short names";
			this.CheckBoxShortLobbyInfoNames.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxShortLobbyInfoNames, "When enabled, the following items will have shorter names:\r\nHost name, Lobby type, Track Name, Event Type, Difficulty\r\n");
			this.CheckBoxShortLobbyInfoNames.UseVisualStyleBackColor = true;
			this.label1.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
			this.label1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(3, 171);
			this.label1.Margin = new global::System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Padding = new global::System.Windows.Forms.Padding(3);
			this.label1.Size = new global::System.Drawing.Size(219, 22);
			this.label1.TabIndex = 13;
			this.label1.Text = "Show this game mode info:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.CheckBoxPlayerCount.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.CheckBoxPlayerCount.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.CheckBoxPlayerCount, 2);
			this.CheckBoxPlayerCount.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxPlayerCount.Location = new global::System.Drawing.Point(3, 143);
			this.CheckBoxPlayerCount.Name = "CheckBoxPlayerCount";
			this.CheckBoxPlayerCount.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxPlayerCount.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxPlayerCount.TabIndex = 3;
			this.CheckBoxPlayerCount.Text = "Player Count";
			this.CheckBoxPlayerCount.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxPlayerCount, "Show the number of players in the lobby.\r\nNote: The overlay includes splitscreen players.");
			this.CheckBoxPlayerCount.UseVisualStyleBackColor = true;
			this.CheckBoxType.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.CheckBoxType.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.CheckBoxType, 2);
			this.CheckBoxType.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxType.Location = new global::System.Drawing.Point(3, 87);
			this.CheckBoxType.Name = "CheckBoxType";
			this.CheckBoxType.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxType.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxType.TabIndex = 1;
			this.CheckBoxType.Text = "Lobby Type";
			this.CheckBoxType.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxType, "Show the lobby type.");
			this.CheckBoxType.UseVisualStyleBackColor = true;
			this.CheckBoxHost.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.CheckBoxHost.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.CheckBoxHost, 2);
			this.CheckBoxHost.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxHost.Location = new global::System.Drawing.Point(3, 115);
			this.CheckBoxHost.Name = "CheckBoxHost";
			this.CheckBoxHost.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxHost.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxHost.TabIndex = 2;
			this.CheckBoxHost.Text = "Host Name";
			this.CheckBoxHost.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxHost, "Show the name of the host.");
			this.CheckBoxHost.UseVisualStyleBackColor = true;
			this.CheckBoxDifficulty.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.CheckBoxDifficulty.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.CheckBoxDifficulty, 2);
			this.CheckBoxDifficulty.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxDifficulty.Location = new global::System.Drawing.Point(3, 255);
			this.CheckBoxDifficulty.Name = "CheckBoxDifficulty";
			this.CheckBoxDifficulty.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxDifficulty.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxDifficulty.TabIndex = 6;
			this.CheckBoxDifficulty.Text = "Difficulty";
			this.CheckBoxDifficulty.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxDifficulty, "Show the difficulty, e.g S Class.");
			this.CheckBoxDifficulty.UseVisualStyleBackColor = true;
			this.CheckBoxEvent.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.CheckBoxEvent.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.CheckBoxEvent, 2);
			this.CheckBoxEvent.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxEvent.Location = new global::System.Drawing.Point(3, 227);
			this.CheckBoxEvent.Name = "CheckBoxEvent";
			this.CheckBoxEvent.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxEvent.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxEvent.TabIndex = 4;
			this.CheckBoxEvent.Text = "Event Type";
			this.CheckBoxEvent.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxEvent, "Show the name of the current event, e.g. Normal Race.");
			this.CheckBoxEvent.UseVisualStyleBackColor = true;
			this.CheckBoxTrack.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.CheckBoxTrack.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.CheckBoxTrack, 2);
			this.CheckBoxTrack.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxTrack.Location = new global::System.Drawing.Point(3, 199);
			this.CheckBoxTrack.Name = "CheckBoxTrack";
			this.CheckBoxTrack.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxTrack.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxTrack.TabIndex = 5;
			this.CheckBoxTrack.Text = "Track/Arena Name";
			this.CheckBoxTrack.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxTrack, "Show the name of the track being played.");
			this.CheckBoxTrack.UseVisualStyleBackColor = true;
			this.CheckBoxId.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.CheckBoxId.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.CheckBoxId, 2);
			this.CheckBoxId.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxId.Location = new global::System.Drawing.Point(3, 59);
			this.CheckBoxId.Name = "CheckBoxId";
			this.CheckBoxId.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxId.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxId.TabIndex = 0;
			this.CheckBoxId.Text = "Lobby ID";
			this.CheckBoxId.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxId, "Show the unique identifier of the lobby.");
			this.CheckBoxId.UseVisualStyleBackColor = true;
			this.LabelBasicInfo.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.LabelBasicInfo, 2);
			this.LabelBasicInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelBasicInfo.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelBasicInfo.Location = new global::System.Drawing.Point(3, 31);
			this.LabelBasicInfo.Margin = new global::System.Windows.Forms.Padding(3);
			this.LabelBasicInfo.Name = "LabelBasicInfo";
			this.LabelBasicInfo.Padding = new global::System.Windows.Forms.Padding(3);
			this.LabelBasicInfo.Size = new global::System.Drawing.Size(219, 22);
			this.LabelBasicInfo.TabIndex = 12;
			this.LabelBasicInfo.Text = "Show this basic info:";
			this.LabelBasicInfo.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.PlayerNameTab.Controls.Add(this.tableLayoutPanel3);
			this.PlayerNameTab.Location = new global::System.Drawing.Point(4, 24);
			this.PlayerNameTab.Name = "PlayerNameTab";
			this.PlayerNameTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.PlayerNameTab.Size = new global::System.Drawing.Size(231, 287);
			this.PlayerNameTab.TabIndex = 2;
			this.PlayerNameTab.Text = "Player Name";
			this.PlayerNameTab.UseVisualStyleBackColor = true;
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel3.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel3.Controls.Add(this.CheckBoxShortPlayerNames, 0, 0);
			this.tableLayoutPanel3.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new global::System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 9;
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel3.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel3.Size = new global::System.Drawing.Size(225, 281);
			this.tableLayoutPanel3.TabIndex = 6;
			this.CheckBoxShortPlayerNames.AutoSize = true;
			this.CheckBoxShortPlayerNames.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.CheckBoxShortPlayerNames.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxShortPlayerNames.Location = new global::System.Drawing.Point(3, 3);
			this.CheckBoxShortPlayerNames.Name = "CheckBoxShortPlayerNames";
			this.CheckBoxShortPlayerNames.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxShortPlayerNames.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxShortPlayerNames.TabIndex = 2;
			this.CheckBoxShortPlayerNames.Text = "Short names";
			this.CheckBoxShortPlayerNames.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxShortPlayerNames, "When enabled, player names will have a maximum length of 9 characters.");
			this.CheckBoxShortPlayerNames.UseVisualStyleBackColor = true;
			this.CharacterTab.Controls.Add(this.tableLayoutPanel2);
			this.CharacterTab.Location = new global::System.Drawing.Point(4, 24);
			this.CharacterTab.Name = "CharacterTab";
			this.CharacterTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.CharacterTab.Size = new global::System.Drawing.Size(231, 287);
			this.CharacterTab.TabIndex = 0;
			this.CharacterTab.Text = "Character";
			this.CharacterTab.UseVisualStyleBackColor = true;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.tableLayoutPanel2.Controls.Add(this.CheckBoxShortCharacterNames, 0, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 9;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 11.11111f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(225, 281);
			this.tableLayoutPanel2.TabIndex = 4;
			this.CheckBoxShortCharacterNames.AutoSize = true;
			this.CheckBoxShortCharacterNames.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.CheckBoxShortCharacterNames.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.CheckBoxShortCharacterNames.Location = new global::System.Drawing.Point(3, 3);
			this.CheckBoxShortCharacterNames.Name = "CheckBoxShortCharacterNames";
			this.CheckBoxShortCharacterNames.Padding = new global::System.Windows.Forms.Padding(3, 3, 0, 0);
			this.CheckBoxShortCharacterNames.Size = new global::System.Drawing.Size(219, 22);
			this.CheckBoxShortCharacterNames.TabIndex = 2;
			this.CheckBoxShortCharacterNames.Text = "Short names";
			this.CheckBoxShortCharacterNames.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.CheckBoxShortCharacterNames, "When enabled, character names will have a maximum length of 9 characters.");
			this.CheckBoxShortCharacterNames.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Dpi;
			base.ClientSize = new global::System.Drawing.Size(245, 359);
			base.ControlBox = false;
			base.Controls.Add(this.TableLayoutPanelLobbyDetails);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			//base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "DialogBoxColumnAdditional";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Additional Column Options";
			this.TableLayoutPanelLobbyDetails.ResumeLayout(false);
			this.TabControlAdditionalOptions.ResumeLayout(false);
			this.LobbyInfoTab.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.PlayerNameTab.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.CharacterTab.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000088 RID: 136
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000089 RID: 137
		private global::System.Windows.Forms.TableLayoutPanel TableLayoutPanelLobbyDetails;

		// Token: 0x0400008A RID: 138
		private global::System.Windows.Forms.Button ButtonCancel;

		// Token: 0x0400008B RID: 139
		private global::System.Windows.Forms.Button ButtonConfirm;

		// Token: 0x0400008C RID: 140
		private global::System.Windows.Forms.TabControl TabControlAdditionalOptions;

		// Token: 0x0400008D RID: 141
		private global::System.Windows.Forms.TabPage CharacterTab;

		// Token: 0x0400008E RID: 142
		private global::System.Windows.Forms.TabPage PlayerNameTab;

		// Token: 0x0400008F RID: 143
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x04000090 RID: 144
		public global::System.Windows.Forms.CheckBox CheckBoxShortCharacterNames;

		// Token: 0x04000091 RID: 145
		private global::System.Windows.Forms.TabPage LobbyInfoTab;

		// Token: 0x04000092 RID: 146
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x04000093 RID: 147
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000094 RID: 148
		public global::System.Windows.Forms.CheckBox CheckBoxPlayerCount;

		// Token: 0x04000095 RID: 149
		public global::System.Windows.Forms.CheckBox CheckBoxType;

		// Token: 0x04000096 RID: 150
		public global::System.Windows.Forms.CheckBox CheckBoxHost;

		// Token: 0x04000097 RID: 151
		public global::System.Windows.Forms.CheckBox CheckBoxDifficulty;

		// Token: 0x04000098 RID: 152
		public global::System.Windows.Forms.CheckBox CheckBoxEvent;

		// Token: 0x04000099 RID: 153
		public global::System.Windows.Forms.CheckBox CheckBoxTrack;

		// Token: 0x0400009A RID: 154
		public global::System.Windows.Forms.CheckBox CheckBoxId;

		// Token: 0x0400009B RID: 155
		private global::System.Windows.Forms.Label LabelBasicInfo;

		// Token: 0x0400009C RID: 156
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

		// Token: 0x0400009D RID: 157
		public global::System.Windows.Forms.CheckBox CheckBoxShortPlayerNames;

		// Token: 0x0400009E RID: 158
		public global::System.Windows.Forms.CheckBox CheckBoxShortLobbyInfoNames;

		// Token: 0x0400009F RID: 159
		private global::System.Windows.Forms.ToolTip ToolTip;
	}
}
