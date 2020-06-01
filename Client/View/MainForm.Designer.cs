namespace Crisis.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CentralPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ObjectivesPanel = new System.Windows.Forms.Panel();
            this.ObjectivesLabel = new System.Windows.Forms.Label();
            this.GoalsList = new System.Windows.Forms.CheckedListBox();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.SendButton = new System.Windows.Forms.Button();
            this.ChatInput = new System.Windows.Forms.TextBox();
            this.ChatOutput = new System.Windows.Forms.TextBox();
            this.TimePanel = new System.Windows.Forms.TableLayoutPanel();
            this.StaffReadyLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.DoomsdayLabel = new System.Windows.Forms.Label();
            this.TurnTimeLabel = new System.Windows.Forms.Label();
            this.AdminReadyLabel = new System.Windows.Forms.Label();
            this.ReadyCheck = new System.Windows.Forms.CheckBox();
            this.TurnCountLabel = new System.Windows.Forms.Label();
            this.GMButton = new System.Windows.Forms.Button();
            this.CharacterPanel = new System.Windows.Forms.Panel();
            this.CharacterLabel = new System.Windows.Forms.Label();
            this.CharacterLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FactionLabel = new System.Windows.Forms.Label();
            this.FactionDescLabel = new System.Windows.Forms.Label();
            this.RankLabel = new System.Windows.Forms.Label();
            this.BranchLabel = new System.Windows.Forms.Label();
            this.BranchDescLabel = new System.Windows.Forms.Label();
            this.RankDescLabel = new System.Windows.Forms.Label();
            this.RoomPanel = new System.Windows.Forms.Panel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.PopulationLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.RoomPeopleBox = new System.Windows.Forms.TextBox();
            this.TravelSplit = new System.Windows.Forms.SplitContainer();
            this.TravelRoomList = new System.Windows.Forms.ListBox();
            this.TravelRoomLabel = new System.Windows.Forms.Label();
            this.TravelAreaInfoLabel = new System.Windows.Forms.Label();
            this.TravelAreaInfo = new System.Windows.Forms.Label();
            this.AreaBox = new System.Windows.Forms.ComboBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolstripSystem = new System.Windows.Forms.ToolStripDropDownButton();
            this.ToolstripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.CentralPanel.SuspendLayout();
            this.ObjectivesPanel.SuspendLayout();
            this.ChatPanel.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.CharacterPanel.SuspendLayout();
            this.CharacterLayout.SuspendLayout();
            this.RoomPanel.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TravelSplit)).BeginInit();
            this.TravelSplit.Panel1.SuspendLayout();
            this.TravelSplit.Panel2.SuspendLayout();
            this.TravelSplit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CentralPanel
            // 
            this.CentralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CentralPanel.ColumnCount = 3;
            this.CentralPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
            this.CentralPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CentralPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 333F));
            this.CentralPanel.Controls.Add(this.ObjectivesPanel, 0, 0);
            this.CentralPanel.Controls.Add(this.ChatPanel, 1, 1);
            this.CentralPanel.Controls.Add(this.TimePanel, 2, 0);
            this.CentralPanel.Controls.Add(this.CharacterPanel, 0, 1);
            this.CentralPanel.Controls.Add(this.RoomPanel, 2, 1);
            this.CentralPanel.Controls.Add(this.TravelSplit, 1, 0);
            this.CentralPanel.Location = new System.Drawing.Point(0, 29);
            this.CentralPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.RowCount = 2;
            this.CentralPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.CentralPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CentralPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CentralPanel.Size = new System.Drawing.Size(1249, 598);
            this.CentralPanel.TabIndex = 0;
            // 
            // ObjectivesPanel
            // 
            this.ObjectivesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObjectivesPanel.Controls.Add(this.ObjectivesLabel);
            this.ObjectivesPanel.Controls.Add(this.GoalsList);
            this.ObjectivesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ObjectivesPanel.Location = new System.Drawing.Point(4, 4);
            this.ObjectivesPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ObjectivesPanel.Name = "ObjectivesPanel";
            this.ObjectivesPanel.Size = new System.Drawing.Size(259, 164);
            this.ObjectivesPanel.TabIndex = 6;
            // 
            // ObjectivesLabel
            // 
            this.ObjectivesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ObjectivesLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ObjectivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObjectivesLabel.Location = new System.Drawing.Point(0, 0);
            this.ObjectivesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ObjectivesLabel.Name = "ObjectivesLabel";
            this.ObjectivesLabel.Size = new System.Drawing.Size(258, 33);
            this.ObjectivesLabel.TabIndex = 3;
            this.ObjectivesLabel.Text = "Objectives";
            this.ObjectivesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoalsList
            // 
            this.GoalsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoalsList.BackColor = System.Drawing.SystemColors.Control;
            this.GoalsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GoalsList.FormattingEnabled = true;
            this.GoalsList.HorizontalScrollbar = true;
            this.GoalsList.Items.AddRange(new object[] {
            "Personal: Find the Secretary General and throw a pie in his face.",
            "Branch: Get the keys of the clown car back.",
            "Faction: Lure children into the severs through grates."});
            this.GoalsList.Location = new System.Drawing.Point(4, 34);
            this.GoalsList.Margin = new System.Windows.Forms.Padding(4);
            this.GoalsList.Name = "GoalsList";
            this.GoalsList.ScrollAlwaysVisible = true;
            this.GoalsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.GoalsList.Size = new System.Drawing.Size(254, 119);
            this.GoalsList.TabIndex = 5;
            // 
            // ChatPanel
            // 
            this.ChatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatPanel.Controls.Add(this.SendButton);
            this.ChatPanel.Controls.Add(this.ChatInput);
            this.ChatPanel.Controls.Add(this.ChatOutput);
            this.ChatPanel.Location = new System.Drawing.Point(271, 176);
            this.ChatPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(641, 418);
            this.ChatPanel.TabIndex = 0;
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Location = new System.Drawing.Point(578, 390);
            this.SendButton.Margin = new System.Windows.Forms.Padding(4);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(59, 24);
            this.SendButton.TabIndex = 2;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // ChatInput
            // 
            this.ChatInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatInput.Location = new System.Drawing.Point(4, 390);
            this.ChatInput.Margin = new System.Windows.Forms.Padding(4);
            this.ChatInput.Name = "ChatInput";
            this.ChatInput.Size = new System.Drawing.Size(566, 22);
            this.ChatInput.TabIndex = 1;
            this.ChatInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatInput_KeyDown);
            // 
            // ChatOutput
            // 
            this.ChatOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChatOutput.Location = new System.Drawing.Point(4, 4);
            this.ChatOutput.Margin = new System.Windows.Forms.Padding(4);
            this.ChatOutput.Multiline = true;
            this.ChatOutput.Name = "ChatOutput";
            this.ChatOutput.ReadOnly = true;
            this.ChatOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatOutput.Size = new System.Drawing.Size(633, 378);
            this.ChatOutput.TabIndex = 0;
            this.ChatOutput.TabStop = false;
            // 
            // TimePanel
            // 
            this.TimePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.TimePanel.ColumnCount = 2;
            this.TimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TimePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TimePanel.Controls.Add(this.StaffReadyLabel, 1, 1);
            this.TimePanel.Controls.Add(this.TimeLabel, 0, 0);
            this.TimePanel.Controls.Add(this.DoomsdayLabel, 0, 1);
            this.TimePanel.Controls.Add(this.TurnTimeLabel, 0, 2);
            this.TimePanel.Controls.Add(this.AdminReadyLabel, 1, 0);
            this.TimePanel.Controls.Add(this.ReadyCheck, 1, 2);
            this.TimePanel.Controls.Add(this.TurnCountLabel, 0, 3);
            this.TimePanel.Controls.Add(this.GMButton, 1, 3);
            this.TimePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimePanel.Location = new System.Drawing.Point(920, 4);
            this.TimePanel.Margin = new System.Windows.Forms.Padding(4);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.RowCount = 4;
            this.TimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TimePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TimePanel.Size = new System.Drawing.Size(325, 164);
            this.TimePanel.TabIndex = 1;
            // 
            // StaffReadyLabel
            // 
            this.StaffReadyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaffReadyLabel.Location = new System.Drawing.Point(168, 43);
            this.StaffReadyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaffReadyLabel.Name = "StaffReadyLabel";
            this.StaffReadyLabel.Size = new System.Drawing.Size(150, 37);
            this.StaffReadyLabel.TabIndex = 4;
            this.StaffReadyLabel.Text = "Staff ready\r\n0/80%";
            // 
            // TimeLabel
            // 
            this.TimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeLabel.Location = new System.Drawing.Point(7, 3);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(150, 37);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "Current time\r\n00:00:00";
            // 
            // DoomsdayLabel
            // 
            this.DoomsdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoomsdayLabel.Location = new System.Drawing.Point(7, 43);
            this.DoomsdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoomsdayLabel.Name = "DoomsdayLabel";
            this.DoomsdayLabel.Size = new System.Drawing.Size(150, 37);
            this.DoomsdayLabel.TabIndex = 2;
            this.DoomsdayLabel.Text = "Turn ends in\r\n00:00:00\r\n";
            // 
            // TurnTimeLabel
            // 
            this.TurnTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TurnTimeLabel.Location = new System.Drawing.Point(7, 83);
            this.TurnTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TurnTimeLabel.Name = "TurnTimeLabel";
            this.TurnTimeLabel.Size = new System.Drawing.Size(150, 37);
            this.TurnTimeLabel.TabIndex = 1;
            this.TurnTimeLabel.Text = "Turn ends at\r\n00:00:00";
            // 
            // AdminReadyLabel
            // 
            this.AdminReadyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminReadyLabel.Location = new System.Drawing.Point(168, 3);
            this.AdminReadyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdminReadyLabel.Name = "AdminReadyLabel";
            this.AdminReadyLabel.Size = new System.Drawing.Size(150, 37);
            this.AdminReadyLabel.TabIndex = 3;
            this.AdminReadyLabel.Text = "Heads ready\r\n0/100%";
            // 
            // ReadyCheck
            // 
            this.ReadyCheck.AutoCheck = false;
            this.ReadyCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReadyCheck.Location = new System.Drawing.Point(168, 87);
            this.ReadyCheck.Margin = new System.Windows.Forms.Padding(4);
            this.ReadyCheck.Name = "ReadyCheck";
            this.ReadyCheck.Size = new System.Drawing.Size(150, 29);
            this.ReadyCheck.TabIndex = 5;
            this.ReadyCheck.Text = "Ready";
            this.ReadyCheck.UseVisualStyleBackColor = true;
            this.ReadyCheck.Click += new System.EventHandler(this.ReadyCheck_Click);
            // 
            // TurnCountLabel
            // 
            this.TurnCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TurnCountLabel.Location = new System.Drawing.Point(7, 123);
            this.TurnCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TurnCountLabel.Name = "TurnCountLabel";
            this.TurnCountLabel.Size = new System.Drawing.Size(150, 38);
            this.TurnCountLabel.TabIndex = 6;
            this.TurnCountLabel.Text = "Current turn\r\n420";
            // 
            // GMButton
            // 
            this.GMButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GMButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GMButton.Location = new System.Drawing.Point(167, 126);
            this.GMButton.Name = "GMButton";
            this.GMButton.Size = new System.Drawing.Size(152, 32);
            this.GMButton.TabIndex = 7;
            this.GMButton.Text = "Gamemaster";
            this.GMButton.UseVisualStyleBackColor = true;
            this.GMButton.Visible = false;
            this.GMButton.Click += new System.EventHandler(this.GMButton_Click);
            // 
            // CharacterPanel
            // 
            this.CharacterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CharacterPanel.Controls.Add(this.CharacterLabel);
            this.CharacterPanel.Controls.Add(this.CharacterLayout);
            this.CharacterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CharacterPanel.Location = new System.Drawing.Point(4, 176);
            this.CharacterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.CharacterPanel.Name = "CharacterPanel";
            this.CharacterPanel.Size = new System.Drawing.Size(259, 418);
            this.CharacterPanel.TabIndex = 3;
            // 
            // CharacterLabel
            // 
            this.CharacterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharacterLabel.Location = new System.Drawing.Point(0, 0);
            this.CharacterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CharacterLabel.Name = "CharacterLabel";
            this.CharacterLabel.Size = new System.Drawing.Size(258, 33);
            this.CharacterLabel.TabIndex = 3;
            this.CharacterLabel.Text = "Character Name";
            this.CharacterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharacterLayout
            // 
            this.CharacterLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterLayout.ColumnCount = 1;
            this.CharacterLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CharacterLayout.Controls.Add(this.FactionLabel, 0, 5);
            this.CharacterLayout.Controls.Add(this.FactionDescLabel, 0, 4);
            this.CharacterLayout.Controls.Add(this.RankLabel, 0, 1);
            this.CharacterLayout.Controls.Add(this.BranchLabel, 0, 3);
            this.CharacterLayout.Controls.Add(this.BranchDescLabel, 0, 2);
            this.CharacterLayout.Controls.Add(this.RankDescLabel, 0, 0);
            this.CharacterLayout.Location = new System.Drawing.Point(3, 36);
            this.CharacterLayout.Name = "CharacterLayout";
            this.CharacterLayout.RowCount = 6;
            this.CharacterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CharacterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CharacterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CharacterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CharacterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CharacterLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.CharacterLayout.Size = new System.Drawing.Size(251, 377);
            this.CharacterLayout.TabIndex = 7;
            // 
            // FactionLabel
            // 
            this.FactionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactionLabel.Location = new System.Drawing.Point(3, 110);
            this.FactionLabel.Name = "FactionLabel";
            this.FactionLabel.Size = new System.Drawing.Size(245, 30);
            this.FactionLabel.TabIndex = 12;
            this.FactionLabel.Text = "FACTION ERROR";
            this.FactionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FactionDescLabel
            // 
            this.FactionDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FactionDescLabel.Location = new System.Drawing.Point(3, 90);
            this.FactionDescLabel.Name = "FactionDescLabel";
            this.FactionDescLabel.Size = new System.Drawing.Size(245, 20);
            this.FactionDescLabel.TabIndex = 11;
            this.FactionDescLabel.Text = "Faction";
            this.FactionDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RankLabel
            // 
            this.RankLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankLabel.Location = new System.Drawing.Point(3, 20);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(245, 20);
            this.RankLabel.TabIndex = 10;
            this.RankLabel.Text = "RANK ERROR";
            this.RankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BranchLabel
            // 
            this.BranchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BranchLabel.Location = new System.Drawing.Point(3, 60);
            this.BranchLabel.Name = "BranchLabel";
            this.BranchLabel.Size = new System.Drawing.Size(245, 30);
            this.BranchLabel.TabIndex = 8;
            this.BranchLabel.Text = "BRANCH ERROR";
            this.BranchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BranchDescLabel
            // 
            this.BranchDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BranchDescLabel.Location = new System.Drawing.Point(3, 40);
            this.BranchDescLabel.Name = "BranchDescLabel";
            this.BranchDescLabel.Size = new System.Drawing.Size(245, 20);
            this.BranchDescLabel.TabIndex = 7;
            this.BranchDescLabel.Text = "Branch";
            this.BranchDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RankDescLabel
            // 
            this.RankDescLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RankDescLabel.Location = new System.Drawing.Point(3, 0);
            this.RankDescLabel.Name = "RankDescLabel";
            this.RankDescLabel.Size = new System.Drawing.Size(245, 20);
            this.RankDescLabel.TabIndex = 9;
            this.RankDescLabel.Text = "Rank";
            this.RankDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoomPanel
            // 
            this.RoomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RoomPanel.Controls.Add(this.statusStrip2);
            this.RoomPanel.Controls.Add(this.RoomLabel);
            this.RoomPanel.Controls.Add(this.AreaLabel);
            this.RoomPanel.Controls.Add(this.RoomPeopleBox);
            this.RoomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomPanel.Location = new System.Drawing.Point(920, 176);
            this.RoomPanel.Margin = new System.Windows.Forms.Padding(4);
            this.RoomPanel.Name = "RoomPanel";
            this.RoomPanel.Size = new System.Drawing.Size(325, 418);
            this.RoomPanel.TabIndex = 4;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PopulationLabel});
            this.statusStrip2.Location = new System.Drawing.Point(0, 390);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip2.Size = new System.Drawing.Size(323, 26);
            this.statusStrip2.TabIndex = 6;
            this.statusStrip2.Text = "RoomStrip";
            // 
            // PopulationLabel
            // 
            this.PopulationLabel.Name = "PopulationLabel";
            this.PopulationLabel.Size = new System.Drawing.Size(17, 20);
            this.PopulationLabel.Text = "0";
            // 
            // RoomLabel
            // 
            this.RoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomLabel.Location = new System.Drawing.Point(0, 20);
            this.RoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(324, 40);
            this.RoomLabel.TabIndex = 5;
            this.RoomLabel.Text = "Room Name";
            this.RoomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AreaLabel
            // 
            this.AreaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AreaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLabel.Location = new System.Drawing.Point(0, 0);
            this.AreaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(324, 20);
            this.AreaLabel.TabIndex = 3;
            this.AreaLabel.Text = "Area Name";
            this.AreaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RoomPeopleBox
            // 
            this.RoomPeopleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomPeopleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RoomPeopleBox.Location = new System.Drawing.Point(4, 64);
            this.RoomPeopleBox.Margin = new System.Windows.Forms.Padding(4);
            this.RoomPeopleBox.Multiline = true;
            this.RoomPeopleBox.Name = "RoomPeopleBox";
            this.RoomPeopleBox.ReadOnly = true;
            this.RoomPeopleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RoomPeopleBox.Size = new System.Drawing.Size(312, 326);
            this.RoomPeopleBox.TabIndex = 2;
            this.RoomPeopleBox.Text = "Empty";
            // 
            // TravelSplit
            // 
            this.TravelSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TravelSplit.IsSplitterFixed = true;
            this.TravelSplit.Location = new System.Drawing.Point(270, 3);
            this.TravelSplit.Name = "TravelSplit";
            // 
            // TravelSplit.Panel1
            // 
            this.TravelSplit.Panel1.Controls.Add(this.TravelRoomList);
            this.TravelSplit.Panel1.Controls.Add(this.TravelRoomLabel);
            // 
            // TravelSplit.Panel2
            // 
            this.TravelSplit.Panel2.Controls.Add(this.TravelAreaInfoLabel);
            this.TravelSplit.Panel2.Controls.Add(this.TravelAreaInfo);
            this.TravelSplit.Panel2.Controls.Add(this.AreaBox);
            this.TravelSplit.Size = new System.Drawing.Size(643, 166);
            this.TravelSplit.SplitterDistance = 321;
            this.TravelSplit.TabIndex = 7;
            // 
            // TravelRoomList
            // 
            this.TravelRoomList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelRoomList.FormattingEnabled = true;
            this.TravelRoomList.IntegralHeight = false;
            this.TravelRoomList.ItemHeight = 16;
            this.TravelRoomList.Items.AddRange(new object[] {
            "Error room 1",
            "Error room 2",
            "Error room 3"});
            this.TravelRoomList.Location = new System.Drawing.Point(3, 38);
            this.TravelRoomList.Name = "TravelRoomList";
            this.TravelRoomList.Size = new System.Drawing.Size(315, 125);
            this.TravelRoomList.TabIndex = 2;
            // 
            // TravelRoomLabel
            // 
            this.TravelRoomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelRoomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelRoomLabel.Location = new System.Drawing.Point(3, 4);
            this.TravelRoomLabel.Name = "TravelRoomLabel";
            this.TravelRoomLabel.Size = new System.Drawing.Size(315, 31);
            this.TravelRoomLabel.TabIndex = 1;
            this.TravelRoomLabel.Text = "Travel to Room:";
            this.TravelRoomLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // TravelAreaInfoLabel
            // 
            this.TravelAreaInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelAreaInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelAreaInfoLabel.Location = new System.Drawing.Point(4, 44);
            this.TravelAreaInfoLabel.Name = "TravelAreaInfoLabel";
            this.TravelAreaInfoLabel.Size = new System.Drawing.Size(311, 73);
            this.TravelAreaInfoLabel.TabIndex = 4;
            this.TravelAreaInfoLabel.Text = "At the end of the turn\r\nyou will travel to:";
            this.TravelAreaInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TravelAreaInfo
            // 
            this.TravelAreaInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TravelAreaInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelAreaInfo.Location = new System.Drawing.Point(3, 4);
            this.TravelAreaInfo.Name = "TravelAreaInfo";
            this.TravelAreaInfo.Size = new System.Drawing.Size(312, 31);
            this.TravelAreaInfo.TabIndex = 3;
            this.TravelAreaInfo.Text = "Travel to Area:";
            this.TravelAreaInfo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // AreaBox
            // 
            this.AreaBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AreaBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaBox.Items.AddRange(new object[] {
            "Nowhere"});
            this.AreaBox.Location = new System.Drawing.Point(29, 121);
            this.AreaBox.Name = "AreaBox";
            this.AreaBox.Size = new System.Drawing.Size(261, 24);
            this.AreaBox.TabIndex = 2;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1249, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolstripSystem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1249, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolstripSystem
            // 
            this.ToolstripSystem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolstripSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolstripExit});
            this.ToolstripSystem.Name = "ToolstripSystem";
            this.ToolstripSystem.ShowDropDownArrow = false;
            this.ToolstripSystem.Size = new System.Drawing.Size(60, 24);
            this.ToolstripSystem.Text = "System";
            // 
            // ToolstripExit
            // 
            this.ToolstripExit.Name = "ToolstripExit";
            this.ToolstripExit.Size = new System.Drawing.Size(116, 26);
            this.ToolstripExit.Text = "Exit";
            this.ToolstripExit.Click += new System.EventHandler(this.ToolstripExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 653);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.CentralPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Crisis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.CentralPanel.ResumeLayout(false);
            this.ObjectivesPanel.ResumeLayout(false);
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.TimePanel.ResumeLayout(false);
            this.CharacterPanel.ResumeLayout(false);
            this.CharacterLayout.ResumeLayout(false);
            this.RoomPanel.ResumeLayout(false);
            this.RoomPanel.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.TravelSplit.Panel1.ResumeLayout(false);
            this.TravelSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TravelSplit)).EndInit();
            this.TravelSplit.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CentralPanel;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox ChatInput;
        private System.Windows.Forms.TextBox ChatOutput;
        private System.Windows.Forms.TableLayoutPanel TimePanel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DoomsdayLabel;
        private System.Windows.Forms.Label TurnTimeLabel;
        private System.Windows.Forms.Label AdminReadyLabel;
        private System.Windows.Forms.Label StaffReadyLabel;
        private System.Windows.Forms.CheckBox ReadyCheck;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel CharacterPanel;
        private System.Windows.Forms.Label CharacterLabel;
        private System.Windows.Forms.Panel RoomPanel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.TextBox RoomPeopleBox;
        private System.Windows.Forms.Label TurnCountLabel;
        private System.Windows.Forms.CheckedListBox GoalsList;
        private System.Windows.Forms.Panel ObjectivesPanel;
        private System.Windows.Forms.Label ObjectivesLabel;
        private System.Windows.Forms.Button GMButton;
        private System.Windows.Forms.Label RoomLabel;
        private System.Windows.Forms.TableLayoutPanel CharacterLayout;
        private System.Windows.Forms.Label BranchLabel;
        private System.Windows.Forms.Label BranchDescLabel;
        private System.Windows.Forms.Label FactionLabel;
        private System.Windows.Forms.Label FactionDescLabel;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.Label RankDescLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ToolstripSystem;
        private System.Windows.Forms.ToolStripMenuItem ToolstripExit;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel PopulationLabel;
        private System.Windows.Forms.Label TravelRoomLabel;
        private System.Windows.Forms.ComboBox AreaBox;
        private System.Windows.Forms.SplitContainer TravelSplit;
        private System.Windows.Forms.ListBox TravelRoomList;
        private System.Windows.Forms.Label TravelAreaInfo;
        private System.Windows.Forms.Label TravelAreaInfoLabel;
    }
}

