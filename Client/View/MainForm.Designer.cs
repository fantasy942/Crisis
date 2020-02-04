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
            this.centralPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.sendButton = new System.Windows.Forms.Button();
            this.chatInput = new System.Windows.Forms.TextBox();
            this.chatOutput = new System.Windows.Forms.TextBox();
            this.timePanel = new System.Windows.Forms.TableLayoutPanel();
            this.staffReadyLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.doomsdayLabel = new System.Windows.Forms.Label();
            this.turnTimeLabel = new System.Windows.Forms.Label();
            this.adminReadyLabel = new System.Windows.Forms.Label();
            this.readyCheck = new System.Windows.Forms.CheckBox();
            this.characterPanel = new System.Windows.Forms.Panel();
            this.characterLabel = new System.Windows.Forms.Label();
            this.characterBox = new System.Windows.Forms.TextBox();
            this.roomPanel = new System.Windows.Forms.Panel();
            this.populationLabel = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.roomPeopleBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.turnCountLabel = new System.Windows.Forms.Label();
            this.goalsList = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.objectivesLabel = new System.Windows.Forms.Label();
            this.centralPanel.SuspendLayout();
            this.chatPanel.SuspendLayout();
            this.timePanel.SuspendLayout();
            this.characterPanel.SuspendLayout();
            this.roomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // centralPanel
            // 
            this.centralPanel.ColumnCount = 3;
            this.centralPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.centralPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.centralPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.centralPanel.Controls.Add(this.panel1, 0, 0);
            this.centralPanel.Controls.Add(this.chatPanel, 1, 1);
            this.centralPanel.Controls.Add(this.timePanel, 2, 0);
            this.centralPanel.Controls.Add(this.characterPanel, 0, 1);
            this.centralPanel.Controls.Add(this.roomPanel, 2, 1);
            this.centralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centralPanel.Location = new System.Drawing.Point(0, 0);
            this.centralPanel.Name = "centralPanel";
            this.centralPanel.RowCount = 3;
            this.centralPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.centralPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.centralPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.centralPanel.Size = new System.Drawing.Size(918, 423);
            this.centralPanel.TabIndex = 0;
            // 
            // chatPanel
            // 
            this.chatPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatPanel.Controls.Add(this.sendButton);
            this.chatPanel.Controls.Add(this.chatInput);
            this.chatPanel.Controls.Add(this.chatOutput);
            this.chatPanel.Location = new System.Drawing.Point(203, 143);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(462, 182);
            this.chatPanel.TabIndex = 0;
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(416, 159);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(44, 20);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // chatInput
            // 
            this.chatInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatInput.Location = new System.Drawing.Point(3, 159);
            this.chatInput.Name = "chatInput";
            this.chatInput.Size = new System.Drawing.Size(407, 20);
            this.chatInput.TabIndex = 1;
            this.chatInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatInput_KeyDown);
            // 
            // chatOutput
            // 
            this.chatOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatOutput.Location = new System.Drawing.Point(3, 3);
            this.chatOutput.Multiline = true;
            this.chatOutput.Name = "chatOutput";
            this.chatOutput.ReadOnly = true;
            this.chatOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatOutput.Size = new System.Drawing.Size(457, 150);
            this.chatOutput.TabIndex = 0;
            this.chatOutput.TabStop = false;
            // 
            // timePanel
            // 
            this.timePanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.timePanel.ColumnCount = 2;
            this.timePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.timePanel.Controls.Add(this.staffReadyLabel, 1, 1);
            this.timePanel.Controls.Add(this.timeLabel, 0, 0);
            this.timePanel.Controls.Add(this.doomsdayLabel, 0, 1);
            this.timePanel.Controls.Add(this.turnTimeLabel, 0, 2);
            this.timePanel.Controls.Add(this.adminReadyLabel, 1, 0);
            this.timePanel.Controls.Add(this.readyCheck, 1, 2);
            this.timePanel.Controls.Add(this.turnCountLabel, 0, 3);
            this.timePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timePanel.Location = new System.Drawing.Point(671, 3);
            this.timePanel.Name = "timePanel";
            this.timePanel.RowCount = 4;
            this.timePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.timePanel.Size = new System.Drawing.Size(244, 134);
            this.timePanel.TabIndex = 1;
            // 
            // staffReadyLabel
            // 
            this.staffReadyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffReadyLabel.Location = new System.Drawing.Point(126, 35);
            this.staffReadyLabel.Name = "staffReadyLabel";
            this.staffReadyLabel.Size = new System.Drawing.Size(112, 29);
            this.staffReadyLabel.TabIndex = 4;
            this.staffReadyLabel.Text = "Staff ready\r\n0/80%";
            // 
            // timeLabel
            // 
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Location = new System.Drawing.Point(6, 3);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(111, 29);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Current time\r\n00:00:00";
            // 
            // doomsdayLabel
            // 
            this.doomsdayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doomsdayLabel.Location = new System.Drawing.Point(6, 35);
            this.doomsdayLabel.Name = "doomsdayLabel";
            this.doomsdayLabel.Size = new System.Drawing.Size(111, 29);
            this.doomsdayLabel.TabIndex = 2;
            this.doomsdayLabel.Text = "Turn ends in\r\n00:00:00\r\n";
            // 
            // turnTimeLabel
            // 
            this.turnTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnTimeLabel.Location = new System.Drawing.Point(6, 67);
            this.turnTimeLabel.Name = "turnTimeLabel";
            this.turnTimeLabel.Size = new System.Drawing.Size(111, 29);
            this.turnTimeLabel.TabIndex = 1;
            this.turnTimeLabel.Text = "Turn ends at\r\n00:00:00";
            // 
            // adminReadyLabel
            // 
            this.adminReadyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminReadyLabel.Location = new System.Drawing.Point(126, 3);
            this.adminReadyLabel.Name = "adminReadyLabel";
            this.adminReadyLabel.Size = new System.Drawing.Size(112, 29);
            this.adminReadyLabel.TabIndex = 3;
            this.adminReadyLabel.Text = "Administration ready\r\n0/100%";
            // 
            // readyCheck
            // 
            this.readyCheck.AutoCheck = false;
            this.readyCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readyCheck.Location = new System.Drawing.Point(126, 70);
            this.readyCheck.Name = "readyCheck";
            this.readyCheck.Size = new System.Drawing.Size(112, 23);
            this.readyCheck.TabIndex = 5;
            this.readyCheck.Text = "Ready";
            this.readyCheck.UseVisualStyleBackColor = true;
            // 
            // characterPanel
            // 
            this.characterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.characterPanel.Controls.Add(this.characterLabel);
            this.characterPanel.Controls.Add(this.characterBox);
            this.characterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.characterPanel.Location = new System.Drawing.Point(3, 143);
            this.characterPanel.Name = "characterPanel";
            this.characterPanel.Size = new System.Drawing.Size(194, 182);
            this.characterPanel.TabIndex = 3;
            // 
            // characterLabel
            // 
            this.characterLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.characterLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.characterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterLabel.Location = new System.Drawing.Point(0, 0);
            this.characterLabel.Name = "characterLabel";
            this.characterLabel.Size = new System.Drawing.Size(193, 27);
            this.characterLabel.TabIndex = 3;
            this.characterLabel.Text = "John Doe";
            this.characterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // characterBox
            // 
            this.characterBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.characterBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.characterBox.Location = new System.Drawing.Point(0, 29);
            this.characterBox.Multiline = true;
            this.characterBox.Name = "characterBox";
            this.characterBox.ReadOnly = true;
            this.characterBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.characterBox.Size = new System.Drawing.Size(193, 152);
            this.characterBox.TabIndex = 2;
            this.characterBox.Text = "RANK\r\nClown\r\n\r\nBRANCH\r\nCircus\r\n\r\nFACTION\r\nInternational Alliance of Very Funny Ci" +
    "rcuses Worldwide";
            this.characterBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // roomPanel
            // 
            this.roomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roomPanel.Controls.Add(this.populationLabel);
            this.roomPanel.Controls.Add(this.roomLabel);
            this.roomPanel.Controls.Add(this.roomPeopleBox);
            this.roomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomPanel.Location = new System.Drawing.Point(671, 143);
            this.roomPanel.Name = "roomPanel";
            this.roomPanel.Size = new System.Drawing.Size(244, 182);
            this.roomPanel.TabIndex = 4;
            // 
            // populationLabel
            // 
            this.populationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.populationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.populationLabel.Location = new System.Drawing.Point(3, 29);
            this.populationLabel.Name = "populationLabel";
            this.populationLabel.Size = new System.Drawing.Size(231, 18);
            this.populationLabel.TabIndex = 4;
            this.populationLabel.Text = "People: 4";
            this.populationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roomLabel
            // 
            this.roomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.roomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.Location = new System.Drawing.Point(0, 0);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(243, 27);
            this.roomLabel.TabIndex = 3;
            this.roomLabel.Text = "Circus Office";
            this.roomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roomPeopleBox
            // 
            this.roomPeopleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roomPeopleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.roomPeopleBox.Location = new System.Drawing.Point(3, 50);
            this.roomPeopleBox.Multiline = true;
            this.roomPeopleBox.Name = "roomPeopleBox";
            this.roomPeopleBox.ReadOnly = true;
            this.roomPeopleBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.roomPeopleBox.Size = new System.Drawing.Size(234, 127);
            this.roomPeopleBox.TabIndex = 2;
            this.roomPeopleBox.Text = "John Doe\r\nBob the Builder\r\nDonald Trump\r\nHe-Who-Honketh";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // turnCountLabel
            // 
            this.turnCountLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.turnCountLabel.Location = new System.Drawing.Point(6, 99);
            this.turnCountLabel.Name = "turnCountLabel";
            this.turnCountLabel.Size = new System.Drawing.Size(111, 32);
            this.turnCountLabel.TabIndex = 6;
            this.turnCountLabel.Text = "Current turn\r\n420";
            // 
            // goalsList
            // 
            this.goalsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goalsList.BackColor = System.Drawing.SystemColors.Control;
            this.goalsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.goalsList.FormattingEnabled = true;
            this.goalsList.HorizontalScrollbar = true;
            this.goalsList.Items.AddRange(new object[] {
            "Personal: Find the Secretary General and throw a pie in his face.",
            "Branch: Get the keys of the clown car back.",
            "Faction: Lure children into the severs through grates."});
            this.goalsList.Location = new System.Drawing.Point(3, 28);
            this.goalsList.Name = "goalsList";
            this.goalsList.ScrollAlwaysVisible = true;
            this.goalsList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.goalsList.Size = new System.Drawing.Size(190, 105);
            this.goalsList.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.objectivesLabel);
            this.panel1.Controls.Add(this.goalsList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 134);
            this.panel1.TabIndex = 6;
            // 
            // objectivesLabel
            // 
            this.objectivesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objectivesLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.objectivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectivesLabel.Location = new System.Drawing.Point(0, 0);
            this.objectivesLabel.Name = "objectivesLabel";
            this.objectivesLabel.Size = new System.Drawing.Size(193, 27);
            this.objectivesLabel.TabIndex = 3;
            this.objectivesLabel.Text = "Objectives";
            this.objectivesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 423);
            this.Controls.Add(this.centralPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(16, 430);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Crisis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.centralPanel.ResumeLayout(false);
            this.chatPanel.ResumeLayout(false);
            this.chatPanel.PerformLayout();
            this.timePanel.ResumeLayout(false);
            this.characterPanel.ResumeLayout(false);
            this.characterPanel.PerformLayout();
            this.roomPanel.ResumeLayout(false);
            this.roomPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel centralPanel;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox chatInput;
        private System.Windows.Forms.TextBox chatOutput;
        private System.Windows.Forms.TableLayoutPanel timePanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label doomsdayLabel;
        private System.Windows.Forms.Label turnTimeLabel;
        private System.Windows.Forms.Label adminReadyLabel;
        private System.Windows.Forms.Label staffReadyLabel;
        private System.Windows.Forms.CheckBox readyCheck;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox characterBox;
        private System.Windows.Forms.Panel characterPanel;
        private System.Windows.Forms.Label characterLabel;
        private System.Windows.Forms.Panel roomPanel;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.TextBox roomPeopleBox;
        private System.Windows.Forms.Label populationLabel;
        private System.Windows.Forms.Label turnCountLabel;
        private System.Windows.Forms.CheckedListBox goalsList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label objectivesLabel;
    }
}

