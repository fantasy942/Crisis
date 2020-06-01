using System;
using System.Windows.Forms;
using Crisis.Model;
using Crisis.Messages.Client;
using System.Collections.Generic;

namespace Crisis.View
{
    public partial class MainForm : Form
    {

        private DateTime serverTime = DateTime.MinValue; //Approx
        private DateTime doomsdayTime = DateTime.MinValue;

        private readonly CrisisModel model;
        private readonly GMForm gmForm;

        private readonly List<string> people = new List<string>();

        public MainForm(CrisisModel model)
        {
            this.model = model;
            RegisterModelEvents();
            gmForm = new GMForm(model);
            InitializeComponent();
            AreaBox.SelectedIndex = 0;
            AreaBox.SelectedIndexChanged += AreaBox_SelectedIndexChanged;
            TravelRoomList.SelectedIndexChanged += TravelRoomList_SelectedIndexChanged;
        }

        private void RegisterModelEvents()
        {
            model.OnHear += (name, rank, text, time) => ChatOutput.AppendText($"{Environment.NewLine}{rank} {name} | {time}{Environment.NewLine}{text}");
            
            model.OnGmChanged += x =>
            {
                if (!(GMButton.Visible = x))
                {
                    gmForm.Hide();
                }
            };

            model.OnTimeTurn += (time, turnend, turn) =>
            {
                serverTime = time;
                doomsdayTime = turnend;
                TurnCountLabel.Text = $"Current turn{Environment.NewLine}{turn}";
                TurnTimeLabel.Text = $"Turn ends at{Environment.NewLine}{turnend:HH:mm:ss}";
            };

            model.OnCharacterChanged += (name, rank, branch, faction, ready) =>
            {
                if (name != null) CharacterLabel.Text = name;
                if (rank != null) RankLabel.Text = rank;
                if (branch != null) BranchLabel.Text = branch;
                if (faction != null) FactionLabel.Text = faction;
                if (ready != null) ReadyCheck.Checked = ready.Value;
            };

            model.OnReadinessUpdated += (staffready, staffneeded, officerready, officerneeded) =>
            {
                AdminReadyLabel.Text = $"Heads ready{Environment.NewLine}{officerready}/{officerneeded}%";
                StaffReadyLabel.Text = $"Staff ready{Environment.NewLine}{staffready}/{staffneeded}%";
            };

            model.OnRoomChanged += (name) =>
            {
                RoomLabel.Text = name;
                SetRoomIndex(TravelRoomList.Items.IndexOf(name));
            };

            model.OnAreaChanged += (name, rooms) =>
            {
                AreaLabel.Text = name;
                TravelRoomList.Items.Clear();
                TravelRoomList.Items.AddRange(rooms);
            };

            model.OnPeopleOverride += (people) =>
            {
                this.people.Clear();
                this.people.AddRange(people);
                ChangePeople();
            };

            model.OnPeopleArrive += (people) =>
            {
                this.people.AddRange(people);
                ChangePeople();
            };

            model.OnPeopleLeave += (people) =>
            {
                foreach (var item in people)
                {
                    this.people.Remove(item);
                }
                ChangePeople();
            };
        }

        private void ChangePeople()
        {
            if (people.Count == 0)
            {
                RoomPeopleBox.Text = "Empty.";
            }
            else
            {
                RoomPeopleBox.Text = string.Join(Environment.NewLine, people);
            }
        }

        private void SetRoomIndex(int ind)
        {
            TravelRoomList.SelectedIndexChanged -= TravelRoomList_SelectedIndexChanged;
            TravelRoomList.SelectedIndex = ind;
            TravelRoomList.SelectedIndexChanged += TravelRoomList_SelectedIndexChanged;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            model.Send(new SpeechMessage(ChatInput.Text));
            ChatInput.Text = string.Empty;
        }

        private void ChatInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendButton_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            serverTime = serverTime.AddMilliseconds(Timer.Interval);
            TimeLabel.Text = $"Current time{Environment.NewLine}{serverTime:HH:mm:ss}";
            DoomsdayLabel.Text = $"Turn ends in{Environment.NewLine}{doomsdayTime - serverTime:hh\\:mm\\:ss}";
        }

        private void GMButton_Click(object sender, EventArgs e)
        {
            gmForm.Show();
        }

        private void ReadyCheck_Click(object sender, EventArgs e)
        {
            model.Send(new ReadyMessage(!ReadyCheck.Checked));
        }

        private void ToolstripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TravelRoomList_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Send(new RoomTravelMessage(TravelRoomList.SelectedItem.ToString()));
        }

        private void AreaBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
