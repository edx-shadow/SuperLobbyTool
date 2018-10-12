namespace SuperLobbyTool
{
	// Token: 0x0200000C RID: 12
	public partial class DialogBoxLobbyDetails : global::System.Windows.Forms.Form
	{
		// Token: 0x06000059 RID: 89 RVA: 0x00006779 File Offset: 0x00004979
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006798 File Offset: 0x00004998
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.TableLayoutPanelLobbyDetails = new global::System.Windows.Forms.TableLayoutPanel();
			this.ButtonRefresh = new global::System.Windows.Forms.Button();
			this.ButtonClose = new global::System.Windows.Forms.Button();
			this.TabControlLobbyDetails = new global::System.Windows.Forms.TabControl();
			this.TabPageInfo = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new global::System.Windows.Forms.TableLayoutPanel();
			this.GroupBoxMatchMode = new global::System.Windows.Forms.GroupBox();
			this.TableLayoutPanelMatchMode = new global::System.Windows.Forms.TableLayoutPanel();
			this.LabelDifficultyValue = new global::System.Windows.Forms.Label();
			this.LabelTrackValue = new global::System.Windows.Forms.Label();
			this.LabelEventValue = new global::System.Windows.Forms.Label();
			this.LabelActivityValue = new global::System.Windows.Forms.Label();
			this.LabelDifficulty = new global::System.Windows.Forms.Label();
			this.LabelTrack = new global::System.Windows.Forms.Label();
			this.LabelEvent = new global::System.Windows.Forms.Label();
			this.LabelActivity = new global::System.Windows.Forms.Label();
			this.GroupBoxBasicInfo = new global::System.Windows.Forms.GroupBox();
			this.TableLayoutPanelBasicInfo = new global::System.Windows.Forms.TableLayoutPanel();
			this.LabelCreatorValue = new global::System.Windows.Forms.Label();
			this.LabelCreator = new global::System.Windows.Forms.Label();
			this.LabelPlayerCountValue = new global::System.Windows.Forms.Label();
			this.LabelTypeValue = new global::System.Windows.Forms.Label();
			this.LabelIdValue = new global::System.Windows.Forms.Label();
			this.LabelPlayerCount = new global::System.Windows.Forms.Label();
			this.LabelType = new global::System.Windows.Forms.Label();
			this.LabelId = new global::System.Windows.Forms.Label();
			this.TabPageHostDetails = new global::System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new global::System.Windows.Forms.TableLayoutPanel();
			this.LabelSLTProtectedValue = new global::System.Windows.Forms.Label();
			this.LabelSLTProtected = new global::System.Windows.Forms.Label();
			this.LabelHostSteamIdValue = new global::System.Windows.Forms.Label();
			this.LabelHostSteamId = new global::System.Windows.Forms.Label();
			this.LabelHostNameValue = new global::System.Windows.Forms.Label();
			this.LabelHostName = new global::System.Windows.Forms.Label();
			this.TabPagePlayerList = new global::System.Windows.Forms.TabPage();
			this.TableLayoutPanelPlayers = new global::System.Windows.Forms.TableLayoutPanel();
			this.LabelPlayerTotal = new global::System.Windows.Forms.Label();
			this.LabelBannedPlayers = new global::System.Windows.Forms.Label();
			this.LabelFriends = new global::System.Windows.Forms.Label();
            this.ListViewPlayers = new global::System.Windows.Forms.ListView();
			this.ColumnName = new global::System.Windows.Forms.ColumnHeader();
			this.ColumnSteamId = new global::System.Windows.Forms.ColumnHeader();
			this.ButtonViewProfile = new global::System.Windows.Forms.Button();
			this.ToolTip = new global::System.Windows.Forms.ToolTip(this.components);
			this.TableLayoutPanelLobbyDetails.SuspendLayout();
			this.TabControlLobbyDetails.SuspendLayout();
			this.TabPageInfo.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.GroupBoxMatchMode.SuspendLayout();
			this.TableLayoutPanelMatchMode.SuspendLayout();
			this.GroupBoxBasicInfo.SuspendLayout();
			this.TableLayoutPanelBasicInfo.SuspendLayout();
			this.TabPageHostDetails.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.TabPagePlayerList.SuspendLayout();
			this.TableLayoutPanelPlayers.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanelLobbyDetails.ColumnCount = 2;
			this.TableLayoutPanelLobbyDetails.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanelLobbyDetails.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanelLobbyDetails.Controls.Add(this.ButtonRefresh, 0, 1);
			this.TableLayoutPanelLobbyDetails.Controls.Add(this.ButtonClose, 1, 1);
			this.TableLayoutPanelLobbyDetails.Controls.Add(this.TabControlLobbyDetails, 0, 0);
			this.TableLayoutPanelLobbyDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanelLobbyDetails.Location = new global::System.Drawing.Point(0, 0);
			this.TableLayoutPanelLobbyDetails.Name = "TableLayoutPanelLobbyDetails";
			this.TableLayoutPanelLobbyDetails.RowCount = 2;
			this.TableLayoutPanelLobbyDetails.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 89.53168f));
			this.TableLayoutPanelLobbyDetails.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10.46832f));
			this.TableLayoutPanelLobbyDetails.Size = new global::System.Drawing.Size(321, 366);
			this.TableLayoutPanelLobbyDetails.TabIndex = 7;
			this.ButtonRefresh.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonRefresh.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonRefresh.Location = new global::System.Drawing.Point(3, 330);
			this.ButtonRefresh.Name = "ButtonRefresh";
			this.ButtonRefresh.Size = new global::System.Drawing.Size(154, 33);
			this.ButtonRefresh.TabIndex = 3;
			this.ButtonRefresh.Text = "Refresh";
			this.ToolTip.SetToolTip(this.ButtonRefresh, "Refresh the details of this lobby.\r\nNote: This also refreshes the lobby list.");
			this.ButtonRefresh.UseVisualStyleBackColor = true;
			this.ButtonRefresh.Click += new global::System.EventHandler(this.ButtonRefresh_Click);
			this.ButtonClose.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.ButtonClose.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ButtonClose.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonClose.Location = new global::System.Drawing.Point(163, 330);
			this.ButtonClose.Name = "ButtonClose";
			this.ButtonClose.Size = new global::System.Drawing.Size(155, 33);
			this.ButtonClose.TabIndex = 4;
			this.ButtonClose.Text = "Close";
			this.ToolTip.SetToolTip(this.ButtonClose, "Close this window.");
			this.ButtonClose.UseVisualStyleBackColor = true;
			this.TableLayoutPanelLobbyDetails.SetColumnSpan(this.TabControlLobbyDetails, 2);
			this.TabControlLobbyDetails.Controls.Add(this.TabPageInfo);
			this.TabControlLobbyDetails.Controls.Add(this.TabPageHostDetails);
			this.TabControlLobbyDetails.Controls.Add(this.TabPagePlayerList);
			this.TabControlLobbyDetails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TabControlLobbyDetails.Location = new global::System.Drawing.Point(3, 3);
			this.TabControlLobbyDetails.Name = "TabControlLobbyDetails";
			this.TabControlLobbyDetails.SelectedIndex = 0;
			this.TabControlLobbyDetails.Size = new global::System.Drawing.Size(315, 321);
			this.TabControlLobbyDetails.TabIndex = 0;
			this.ToolTip.SetToolTip(this.TabControlLobbyDetails, "Number of players in this lobby that are on your Steam friend list.\r\nThese players are highlighted in green in the above list.");
			this.TabPageInfo.Controls.Add(this.tableLayoutPanel1);
			this.TabPageInfo.Location = new global::System.Drawing.Point(4, 24);
			this.TabPageInfo.Name = "TabPageInfo";
			this.TabPageInfo.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPageInfo.Size = new global::System.Drawing.Size(307, 293);
			this.TabPageInfo.TabIndex = 1;
			this.TabPageInfo.Text = "Information";
			this.TabPageInfo.UseVisualStyleBackColor = true;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel1.Controls.Add(this.GroupBoxMatchMode, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.GroupBoxBasicInfo, 0, 0);
			this.tableLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new global::System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.tableLayoutPanel1.Size = new global::System.Drawing.Size(301, 287);
			this.tableLayoutPanel1.TabIndex = 0;
			this.GroupBoxMatchMode.Controls.Add(this.TableLayoutPanelMatchMode);
			this.GroupBoxMatchMode.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBoxMatchMode.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBoxMatchMode.Location = new global::System.Drawing.Point(3, 146);
			this.GroupBoxMatchMode.Name = "GroupBoxMatchMode";
			this.GroupBoxMatchMode.Size = new global::System.Drawing.Size(295, 138);
			this.GroupBoxMatchMode.TabIndex = 1;
			this.GroupBoxMatchMode.TabStop = false;
			this.GroupBoxMatchMode.Text = "Match Mode";
			this.ToolTip.SetToolTip(this.GroupBoxMatchMode, "Information about the current state of this lobby.");
			this.TableLayoutPanelMatchMode.ColumnCount = 2;
			this.TableLayoutPanelMatchMode.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 88f));
			this.TableLayoutPanelMatchMode.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanelMatchMode.Controls.Add(this.LabelDifficultyValue, 1, 3);
			this.TableLayoutPanelMatchMode.Controls.Add(this.LabelTrackValue, 1, 2);
			this.TableLayoutPanelMatchMode.Controls.Add(this.LabelEventValue, 1, 1);
			this.TableLayoutPanelMatchMode.Controls.Add(this.LabelActivityValue, 1, 0);
			this.TableLayoutPanelMatchMode.Controls.Add(this.LabelDifficulty, 0, 3);
			this.TableLayoutPanelMatchMode.Controls.Add(this.LabelTrack, 0, 2);
			this.TableLayoutPanelMatchMode.Controls.Add(this.LabelEvent, 0, 1);
			this.TableLayoutPanelMatchMode.Controls.Add(this.LabelActivity, 0, 0);
			this.TableLayoutPanelMatchMode.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanelMatchMode.Location = new global::System.Drawing.Point(3, 19);
			this.TableLayoutPanelMatchMode.Name = "TableLayoutPanelMatchMode";
			this.TableLayoutPanelMatchMode.RowCount = 4;
			this.TableLayoutPanelMatchMode.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25.00006f));
			this.TableLayoutPanelMatchMode.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25.00007f));
			this.TableLayoutPanelMatchMode.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25.00007f));
			this.TableLayoutPanelMatchMode.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 24.99982f));
			this.TableLayoutPanelMatchMode.Size = new global::System.Drawing.Size(289, 116);
			this.TableLayoutPanelMatchMode.TabIndex = 0;
			this.LabelDifficultyValue.AutoSize = true;
			this.LabelDifficultyValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelDifficultyValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelDifficultyValue.Location = new global::System.Drawing.Point(91, 87);
			this.LabelDifficultyValue.Name = "LabelDifficultyValue";
			this.LabelDifficultyValue.Size = new global::System.Drawing.Size(195, 29);
			this.LabelDifficultyValue.TabIndex = 11;
			this.LabelDifficultyValue.Text = "Unknown";
			this.LabelDifficultyValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelDifficultyValue, "Event difficulty.");
			this.LabelTrackValue.AutoSize = true;
			this.LabelTrackValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelTrackValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelTrackValue.Location = new global::System.Drawing.Point(91, 58);
			this.LabelTrackValue.Name = "LabelTrackValue";
			this.LabelTrackValue.Size = new global::System.Drawing.Size(195, 29);
			this.LabelTrackValue.TabIndex = 10;
			this.LabelTrackValue.Text = "Unknown";
			this.LabelTrackValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelTrackValue, "Name of the track/arena being played.");
			this.LabelEventValue.AutoSize = true;
			this.LabelEventValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelEventValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelEventValue.Location = new global::System.Drawing.Point(91, 29);
			this.LabelEventValue.Name = "LabelEventValue";
			this.LabelEventValue.Size = new global::System.Drawing.Size(195, 29);
			this.LabelEventValue.TabIndex = 9;
			this.LabelEventValue.Text = "Unknown";
			this.LabelEventValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelEventValue, "Name of the current lobby event.");
			this.LabelActivityValue.AutoSize = true;
			this.LabelActivityValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelActivityValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelActivityValue.Location = new global::System.Drawing.Point(91, 0);
			this.LabelActivityValue.Name = "LabelActivityValue";
			this.LabelActivityValue.Size = new global::System.Drawing.Size(195, 29);
			this.LabelActivityValue.TabIndex = 8;
			this.LabelActivityValue.Text = "Unknown";
			this.LabelActivityValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelActivityValue, "Shows what is currently going on in the lobby.");
			this.LabelDifficulty.AutoSize = true;
			this.LabelDifficulty.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelDifficulty.Location = new global::System.Drawing.Point(3, 87);
			this.LabelDifficulty.Name = "LabelDifficulty";
			this.LabelDifficulty.Size = new global::System.Drawing.Size(82, 29);
			this.LabelDifficulty.TabIndex = 6;
			this.LabelDifficulty.Text = "Difficulty:";
			this.LabelDifficulty.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelDifficulty, "Event difficulty.");
			this.LabelTrack.AutoSize = true;
			this.LabelTrack.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelTrack.Location = new global::System.Drawing.Point(3, 58);
			this.LabelTrack.Name = "LabelTrack";
			this.LabelTrack.Size = new global::System.Drawing.Size(82, 29);
			this.LabelTrack.TabIndex = 5;
			this.LabelTrack.Text = "Track:";
			this.LabelTrack.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelTrack, "Name of the track/arena being played.");
			this.LabelEvent.AutoSize = true;
			this.LabelEvent.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelEvent.Location = new global::System.Drawing.Point(3, 29);
			this.LabelEvent.Name = "LabelEvent";
			this.LabelEvent.Size = new global::System.Drawing.Size(82, 29);
			this.LabelEvent.TabIndex = 4;
			this.LabelEvent.Text = "Event:";
			this.LabelEvent.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelEvent, "Name of the current lobby event.");
			this.LabelActivity.AutoSize = true;
			this.LabelActivity.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelActivity.Location = new global::System.Drawing.Point(3, 0);
			this.LabelActivity.Name = "LabelActivity";
			this.LabelActivity.Size = new global::System.Drawing.Size(82, 29);
			this.LabelActivity.TabIndex = 3;
			this.LabelActivity.Text = "Activity:";
			this.LabelActivity.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelActivity, "Shows what is currently going on in the lobby.");
			this.GroupBoxBasicInfo.Controls.Add(this.TableLayoutPanelBasicInfo);
			this.GroupBoxBasicInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.GroupBoxBasicInfo.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GroupBoxBasicInfo.Location = new global::System.Drawing.Point(3, 3);
			this.GroupBoxBasicInfo.Name = "GroupBoxBasicInfo";
			this.GroupBoxBasicInfo.Size = new global::System.Drawing.Size(295, 137);
			this.GroupBoxBasicInfo.TabIndex = 0;
			this.GroupBoxBasicInfo.TabStop = false;
			this.GroupBoxBasicInfo.Text = "Basic Info";
			this.ToolTip.SetToolTip(this.GroupBoxBasicInfo, "Basic informatin about this lobby.");
			this.TableLayoutPanelBasicInfo.ColumnCount = 2;
			this.TableLayoutPanelBasicInfo.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 88f));
			this.TableLayoutPanelBasicInfo.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanelBasicInfo.Controls.Add(this.LabelCreatorValue, 1, 2);
			this.TableLayoutPanelBasicInfo.Controls.Add(this.LabelCreator, 0, 2);
			this.TableLayoutPanelBasicInfo.Controls.Add(this.LabelPlayerCountValue, 1, 3);
			this.TableLayoutPanelBasicInfo.Controls.Add(this.LabelTypeValue, 1, 1);
			this.TableLayoutPanelBasicInfo.Controls.Add(this.LabelIdValue, 1, 0);
			this.TableLayoutPanelBasicInfo.Controls.Add(this.LabelPlayerCount, 0, 3);
			this.TableLayoutPanelBasicInfo.Controls.Add(this.LabelType, 0, 1);
			this.TableLayoutPanelBasicInfo.Controls.Add(this.LabelId, 0, 0);
			this.TableLayoutPanelBasicInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanelBasicInfo.Location = new global::System.Drawing.Point(3, 19);
			this.TableLayoutPanelBasicInfo.Name = "TableLayoutPanelBasicInfo";
			this.TableLayoutPanelBasicInfo.RowCount = 4;
			this.TableLayoutPanelBasicInfo.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.TableLayoutPanelBasicInfo.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.TableLayoutPanelBasicInfo.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.TableLayoutPanelBasicInfo.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 25f));
			this.TableLayoutPanelBasicInfo.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanelBasicInfo.Size = new global::System.Drawing.Size(289, 115);
			this.TableLayoutPanelBasicInfo.TabIndex = 0;
			this.LabelCreatorValue.AutoSize = true;
			this.LabelCreatorValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelCreatorValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelCreatorValue.Location = new global::System.Drawing.Point(91, 56);
			this.LabelCreatorValue.Name = "LabelCreatorValue";
			this.LabelCreatorValue.Size = new global::System.Drawing.Size(195, 28);
			this.LabelCreatorValue.TabIndex = 9;
			this.LabelCreatorValue.Text = "Unknown";
			this.LabelCreatorValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelCreatorValue, "The name of the player who originally created this lobby.");
			this.LabelCreator.AutoSize = true;
			this.LabelCreator.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelCreator.Location = new global::System.Drawing.Point(3, 56);
			this.LabelCreator.Name = "LabelCreator";
			this.LabelCreator.Size = new global::System.Drawing.Size(82, 28);
			this.LabelCreator.TabIndex = 8;
			this.LabelCreator.Text = "Creator:";
			this.LabelCreator.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelCreator, "The name of the player who originally created this lobby.");
			this.LabelPlayerCountValue.AutoSize = true;
			this.LabelPlayerCountValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelPlayerCountValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelPlayerCountValue.Location = new global::System.Drawing.Point(91, 84);
			this.LabelPlayerCountValue.Name = "LabelPlayerCountValue";
			this.LabelPlayerCountValue.Size = new global::System.Drawing.Size(195, 31);
			this.LabelPlayerCountValue.TabIndex = 7;
			this.LabelPlayerCountValue.Text = "Unknown";
			this.LabelPlayerCountValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelPlayerCountValue, "The number of players in this lobby.\r\nNote: This does not count splitscreen players.");
			this.LabelTypeValue.AutoSize = true;
			this.LabelTypeValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelTypeValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelTypeValue.Location = new global::System.Drawing.Point(91, 28);
			this.LabelTypeValue.Name = "LabelTypeValue";
			this.LabelTypeValue.Size = new global::System.Drawing.Size(195, 28);
			this.LabelTypeValue.TabIndex = 5;
			this.LabelTypeValue.Text = "Unknown";
			this.LabelTypeValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelTypeValue, "The lobby type.");
			this.LabelIdValue.AutoSize = true;
			this.LabelIdValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelIdValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelIdValue.Location = new global::System.Drawing.Point(91, 0);
			this.LabelIdValue.Name = "LabelIdValue";
			this.LabelIdValue.Size = new global::System.Drawing.Size(195, 28);
			this.LabelIdValue.TabIndex = 4;
			this.LabelIdValue.Text = "Unknown";
			this.LabelIdValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelIdValue, "Unique identifier of this lobby.");
			this.LabelPlayerCount.AutoSize = true;
			this.LabelPlayerCount.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelPlayerCount.Location = new global::System.Drawing.Point(3, 84);
			this.LabelPlayerCount.Name = "LabelPlayerCount";
			this.LabelPlayerCount.Size = new global::System.Drawing.Size(82, 31);
			this.LabelPlayerCount.TabIndex = 3;
			this.LabelPlayerCount.Text = "Player Count:";
			this.LabelPlayerCount.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelPlayerCount, "The number of players in this lobby.\r\nNote: This does not count splitscreen players.");
			this.LabelType.AutoSize = true;
			this.LabelType.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelType.Location = new global::System.Drawing.Point(3, 28);
			this.LabelType.Name = "LabelType";
			this.LabelType.Size = new global::System.Drawing.Size(82, 28);
			this.LabelType.TabIndex = 1;
			this.LabelType.Text = "Type:";
			this.LabelType.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelType, "The lobby type.");
			this.LabelId.AutoSize = true;
			this.LabelId.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelId.Location = new global::System.Drawing.Point(3, 0);
			this.LabelId.Name = "LabelId";
			this.LabelId.Size = new global::System.Drawing.Size(82, 28);
			this.LabelId.TabIndex = 0;
			this.LabelId.Text = "ID:";
			this.LabelId.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelId, "Unique identifier of this lobby.");
			this.TabPageHostDetails.Controls.Add(this.tableLayoutPanel2);
			this.TabPageHostDetails.Location = new global::System.Drawing.Point(4, 24);
			this.TabPageHostDetails.Name = "TabPageHostDetails";
			this.TabPageHostDetails.Size = new global::System.Drawing.Size(307, 293);
			this.TabPageHostDetails.TabIndex = 2;
			this.TabPageHostDetails.Text = "Host Details";
			this.TabPageHostDetails.UseVisualStyleBackColor = true;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Absolute, 95f));
			this.tableLayoutPanel2.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.tableLayoutPanel2.Controls.Add(this.LabelSLTProtectedValue, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.LabelSLTProtected, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.LabelHostSteamIdValue, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.LabelHostSteamId, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.LabelHostNameValue, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.LabelHostName, 0, 0);
			this.tableLayoutPanel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new global::System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 10;
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 10f));
			this.tableLayoutPanel2.Size = new global::System.Drawing.Size(307, 293);
			this.tableLayoutPanel2.TabIndex = 1;
			this.LabelSLTProtectedValue.AutoSize = true;
			this.LabelSLTProtectedValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelSLTProtectedValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelSLTProtectedValue.Location = new global::System.Drawing.Point(98, 58);
			this.LabelSLTProtectedValue.Name = "LabelSLTProtectedValue";
			this.LabelSLTProtectedValue.Size = new global::System.Drawing.Size(206, 29);
			this.LabelSLTProtectedValue.TabIndex = 10;
			this.LabelSLTProtectedValue.Text = "Unknown";
			this.LabelSLTProtectedValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelSLTProtectedValue, "Shows whether the current host is using Super Lobby Tool.");
			this.LabelSLTProtected.AutoSize = true;
			this.LabelSLTProtected.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelSLTProtected.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelSLTProtected.Location = new global::System.Drawing.Point(3, 58);
			this.LabelSLTProtected.Name = "LabelSLTProtected";
			this.LabelSLTProtected.Size = new global::System.Drawing.Size(89, 29);
			this.LabelSLTProtected.TabIndex = 9;
			this.LabelSLTProtected.Text = "SLT Protected:";
			this.LabelSLTProtected.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelSLTProtected, "Shows if the current host is using Super Lobby Tool.");
			this.LabelHostSteamIdValue.AutoSize = true;
			this.LabelHostSteamIdValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelHostSteamIdValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelHostSteamIdValue.Location = new global::System.Drawing.Point(98, 29);
			this.LabelHostSteamIdValue.Name = "LabelHostSteamIdValue";
			this.LabelHostSteamIdValue.Size = new global::System.Drawing.Size(206, 29);
			this.LabelHostSteamIdValue.TabIndex = 8;
			this.LabelHostSteamIdValue.Text = "Unknown";
			this.LabelHostSteamIdValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelHostSteamIdValue, "Steam ID of the host.");
			this.LabelHostSteamId.AutoSize = true;
			this.LabelHostSteamId.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelHostSteamId.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelHostSteamId.Location = new global::System.Drawing.Point(3, 29);
			this.LabelHostSteamId.Name = "LabelHostSteamId";
			this.LabelHostSteamId.Size = new global::System.Drawing.Size(89, 29);
			this.LabelHostSteamId.TabIndex = 7;
			this.LabelHostSteamId.Text = "Steam ID:";
			this.LabelHostSteamId.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelHostSteamId, "Steam ID of the host.");
			this.LabelHostNameValue.AutoSize = true;
			this.LabelHostNameValue.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelHostNameValue.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelHostNameValue.Location = new global::System.Drawing.Point(98, 0);
			this.LabelHostNameValue.Name = "LabelHostNameValue";
			this.LabelHostNameValue.Size = new global::System.Drawing.Size(206, 29);
			this.LabelHostNameValue.TabIndex = 6;
			this.LabelHostNameValue.Text = "Unknown";
			this.LabelHostNameValue.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelHostNameValue, "Name of the host.");
			this.LabelHostName.AutoSize = true;
			this.LabelHostName.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelHostName.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelHostName.Location = new global::System.Drawing.Point(3, 0);
			this.LabelHostName.Name = "LabelHostName";
			this.LabelHostName.Size = new global::System.Drawing.Size(89, 29);
			this.LabelHostName.TabIndex = 2;
			this.LabelHostName.Text = "Name:";
			this.LabelHostName.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.ToolTip.SetToolTip(this.LabelHostName, "Name of the host.");
			this.TabPagePlayerList.Controls.Add(this.TableLayoutPanelPlayers);
			this.TabPagePlayerList.Location = new global::System.Drawing.Point(4, 24);
			this.TabPagePlayerList.Name = "TabPagePlayerList";
			this.TabPagePlayerList.Padding = new global::System.Windows.Forms.Padding(3);
			this.TabPagePlayerList.Size = new global::System.Drawing.Size(307, 293);
			this.TabPagePlayerList.TabIndex = 0;
			this.TabPagePlayerList.Text = "Player List";
			this.TabPagePlayerList.UseVisualStyleBackColor = true;
			this.TableLayoutPanelPlayers.ColumnCount = 2;
			this.TableLayoutPanelPlayers.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanelPlayers.ColumnStyles.Add(new global::System.Windows.Forms.ColumnStyle(global::System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanelPlayers.Controls.Add(this.LabelPlayerTotal, 0, 3);
			this.TableLayoutPanelPlayers.Controls.Add(this.LabelBannedPlayers, 0, 2);
			this.TableLayoutPanelPlayers.Controls.Add(this.LabelFriends, 0, 1);
			this.TableLayoutPanelPlayers.Controls.Add(this.ListViewPlayers, 0, 0);
			this.TableLayoutPanelPlayers.Controls.Add(this.ButtonViewProfile, 1, 1);
			this.TableLayoutPanelPlayers.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanelPlayers.Location = new global::System.Drawing.Point(3, 3);
			this.TableLayoutPanelPlayers.Name = "TableLayoutPanelPlayers";
			this.TableLayoutPanelPlayers.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.TableLayoutPanelPlayers.RowCount = 4;
			this.TableLayoutPanelPlayers.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Percent, 100f));
			this.TableLayoutPanelPlayers.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 21f));
			this.TableLayoutPanelPlayers.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 21f));
			this.TableLayoutPanelPlayers.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 21f));
			this.TableLayoutPanelPlayers.RowStyles.Add(new global::System.Windows.Forms.RowStyle(global::System.Windows.Forms.SizeType.Absolute, 20f));
			this.TableLayoutPanelPlayers.Size = new global::System.Drawing.Size(301, 287);
			this.TableLayoutPanelPlayers.TabIndex = 6;
			this.LabelPlayerTotal.AutoSize = true;
			this.LabelPlayerTotal.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelPlayerTotal.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelPlayerTotal.Location = new global::System.Drawing.Point(3, 266);
			this.LabelPlayerTotal.Name = "LabelPlayerTotal";
			this.LabelPlayerTotal.Padding = new global::System.Windows.Forms.Padding(3);
			this.LabelPlayerTotal.Size = new global::System.Drawing.Size(144, 21);
			this.LabelPlayerTotal.TabIndex = 34;
			this.LabelPlayerTotal.Text = "Player Total:";
			this.LabelPlayerTotal.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelPlayerTotal, "Total number of players in this lobby.\r\nNote: This does not count splitscreen players.");
			this.LabelBannedPlayers.AutoSize = true;
			this.LabelBannedPlayers.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelBannedPlayers.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelBannedPlayers.ForeColor = global::System.Drawing.Color.Red;
			this.LabelBannedPlayers.Location = new global::System.Drawing.Point(3, 245);
			this.LabelBannedPlayers.Name = "LabelBannedPlayers";
			this.LabelBannedPlayers.Padding = new global::System.Windows.Forms.Padding(3);
			this.LabelBannedPlayers.Size = new global::System.Drawing.Size(144, 21);
			this.LabelBannedPlayers.TabIndex = 33;
			this.LabelBannedPlayers.Text = "Banned Players:";
			this.LabelBannedPlayers.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelBannedPlayers, "Number of players in this lobby that are on your banlist.\r\nThese players are highlighted in red in the above list.");
			this.LabelFriends.AutoSize = true;
			this.LabelFriends.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.LabelFriends.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.LabelFriends.ForeColor = global::System.Drawing.Color.Green;
			this.LabelFriends.Location = new global::System.Drawing.Point(3, 224);
			this.LabelFriends.Name = "LabelFriends";
			this.LabelFriends.Padding = new global::System.Windows.Forms.Padding(3);
			this.LabelFriends.Size = new global::System.Drawing.Size(144, 21);
			this.LabelFriends.TabIndex = 32;
			this.LabelFriends.Text = "Friends:";
			this.LabelFriends.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.ToolTip.SetToolTip(this.LabelFriends, "Number of players in this lobby that are on your Steam friend list.");
			this.ListViewPlayers.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.ColumnName,
				this.ColumnSteamId
			});
			this.TableLayoutPanelPlayers.SetColumnSpan(this.ListViewPlayers, 2);
			this.ListViewPlayers.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ListViewPlayers.Font = new global::System.Drawing.Font("Segoe UI", 9f, global::System.Drawing.FontStyle.Bold);
			this.ListViewPlayers.FullRowSelect = true;
			this.ListViewPlayers.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.ListViewPlayers.HideSelection = false;
			this.ListViewPlayers.Location = new global::System.Drawing.Point(3, 3);
			this.ListViewPlayers.Name = "ListViewPlayers";
			this.ListViewPlayers.Size = new global::System.Drawing.Size(295, 218);
			this.ListViewPlayers.TabIndex = 1;
			this.ToolTip.SetToolTip(this.ListViewPlayers, "List of players in this lobby.\r\nNote: This does not show all splitscreen players.");
			this.ListViewPlayers.UseCompatibleStateImageBehavior = false;
			this.ListViewPlayers.View = global::System.Windows.Forms.View.Details;
			this.ColumnName.Text = "Name";
			this.ColumnName.Width = 157;
			this.ColumnSteamId.Text = "Steam Id";
			this.ColumnSteamId.Width = 134;
			this.ButtonViewProfile.Anchor = (global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.ButtonViewProfile.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.ButtonViewProfile.Location = new global::System.Drawing.Point(153, 236);
			this.ButtonViewProfile.Name = "ButtonViewProfile";
			this.TableLayoutPanelPlayers.SetRowSpan(this.ButtonViewProfile, 3);
			this.ButtonViewProfile.Size = new global::System.Drawing.Size(145, 39);
			this.ButtonViewProfile.TabIndex = 2;
			this.ButtonViewProfile.Text = "View Profile";
			this.ToolTip.SetToolTip(this.ButtonViewProfile, "View the steam profiles of the currently selected players.");
			this.ButtonViewProfile.UseVisualStyleBackColor = true;
			this.ButtonViewProfile.Click += new global::System.EventHandler(this.ButtonViewProfile_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 15f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.ButtonClose;
			base.ClientSize = new global::System.Drawing.Size(321, 366);
			base.ControlBox = false;
			base.Controls.Add(this.TableLayoutPanelLobbyDetails);
			this.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "DialogBoxLobbyDetails";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Lobby Details";
			base.Shown += new global::System.EventHandler(this.DialogBoxLobbyDetails_Shown);
			this.TableLayoutPanelLobbyDetails.ResumeLayout(false);
			this.TabControlLobbyDetails.ResumeLayout(false);
			this.TabPageInfo.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.GroupBoxMatchMode.ResumeLayout(false);
			this.TableLayoutPanelMatchMode.ResumeLayout(false);
			this.TableLayoutPanelMatchMode.PerformLayout();
			this.GroupBoxBasicInfo.ResumeLayout(false);
			this.TableLayoutPanelBasicInfo.ResumeLayout(false);
			this.TableLayoutPanelBasicInfo.PerformLayout();
			this.TabPageHostDetails.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.TabPagePlayerList.ResumeLayout(false);
			this.TableLayoutPanelPlayers.ResumeLayout(false);
			this.TableLayoutPanelPlayers.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000054 RID: 84
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.TableLayoutPanel TableLayoutPanelLobbyDetails;

		// Token: 0x04000056 RID: 86
		public global::System.Windows.Forms.Button ButtonClose;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.TabControl TabControlLobbyDetails;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.TabPage TabPageInfo;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.GroupBox GroupBoxMatchMode;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.GroupBox GroupBoxBasicInfo;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.TabPage TabPagePlayerList;

		// Token: 0x0400005D RID: 93
		internal global::System.Windows.Forms.TableLayoutPanel TableLayoutPanelPlayers;

		// Token: 0x0400005E RID: 94
		internal global::System.Windows.Forms.Label LabelPlayerTotal;

		// Token: 0x0400005F RID: 95
		internal global::System.Windows.Forms.Label LabelBannedPlayers;

		// Token: 0x04000060 RID: 96
		internal global::System.Windows.Forms.Label LabelFriends;

		// Token: 0x04000061 RID: 97
		internal global::System.Windows.Forms.ListView ListViewPlayers;

		// Token: 0x04000062 RID: 98
		internal global::System.Windows.Forms.ColumnHeader ColumnName;

		// Token: 0x04000063 RID: 99
		internal global::System.Windows.Forms.ColumnHeader ColumnSteamId;

		// Token: 0x04000064 RID: 100
		public global::System.Windows.Forms.Button ButtonViewProfile;

		// Token: 0x04000065 RID: 101
		public global::System.Windows.Forms.Button ButtonRefresh;

		// Token: 0x04000066 RID: 102
		private global::System.Windows.Forms.TableLayoutPanel TableLayoutPanelBasicInfo;

		// Token: 0x04000067 RID: 103
		private global::System.Windows.Forms.TableLayoutPanel TableLayoutPanelMatchMode;

		// Token: 0x04000068 RID: 104
		private global::System.Windows.Forms.Label LabelEvent;

		// Token: 0x04000069 RID: 105
		private global::System.Windows.Forms.Label LabelActivity;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Forms.Label LabelPlayerCount;

		// Token: 0x0400006B RID: 107
		private global::System.Windows.Forms.Label LabelType;

		// Token: 0x0400006C RID: 108
		private global::System.Windows.Forms.Label LabelId;

		// Token: 0x0400006D RID: 109
		private global::System.Windows.Forms.Label LabelTrack;

		// Token: 0x0400006E RID: 110
		private global::System.Windows.Forms.Label LabelDifficulty;

		// Token: 0x0400006F RID: 111
		private global::System.Windows.Forms.Label LabelPlayerCountValue;

		// Token: 0x04000070 RID: 112
		private global::System.Windows.Forms.Label LabelTypeValue;

		// Token: 0x04000071 RID: 113
		private global::System.Windows.Forms.Label LabelIdValue;

		// Token: 0x04000072 RID: 114
		private global::System.Windows.Forms.Label LabelDifficultyValue;

		// Token: 0x04000073 RID: 115
		private global::System.Windows.Forms.Label LabelTrackValue;

		// Token: 0x04000074 RID: 116
		private global::System.Windows.Forms.Label LabelEventValue;

		// Token: 0x04000075 RID: 117
		private global::System.Windows.Forms.Label LabelActivityValue;

		// Token: 0x04000076 RID: 118
		private global::System.Windows.Forms.Label LabelCreatorValue;

		// Token: 0x04000077 RID: 119
		private global::System.Windows.Forms.Label LabelCreator;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.TabPage TabPageHostDetails;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.Label LabelHostNameValue;

		// Token: 0x0400007B RID: 123
		private global::System.Windows.Forms.Label LabelHostName;

		// Token: 0x0400007C RID: 124
		private global::System.Windows.Forms.Label LabelSLTProtectedValue;

		// Token: 0x0400007D RID: 125
		private global::System.Windows.Forms.Label LabelSLTProtected;

		// Token: 0x0400007E RID: 126
		private global::System.Windows.Forms.Label LabelHostSteamIdValue;

		// Token: 0x0400007F RID: 127
		private global::System.Windows.Forms.Label LabelHostSteamId;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.ToolTip ToolTip;
	}
}
