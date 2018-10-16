using System;
using System.Windows.Forms;
using Lab2.Models;

namespace Lab2.Forms
{
    public partial class AddRoomForm : Form
    {
        private Studio _scopedStudio;

        public AddRoomForm()
        {
            InitializeComponent();
        }

        public AddRoomForm(Studio studio) : this()
        {
            _scopedStudio = studio;
        }


        private void AddRoomForm_Load(object sender, EventArgs e)
        {
            nudInstrumentCount.Maximum = _scopedStudio.InstrumentCount;
        }

        private void bAddRoom_Click(object sender, EventArgs e)
        {
            if (nudInstrumentCount.Value != 0)
            {
                int roomNumber = (int) nudInstrumentCount.Value;
                int instrumentCount = (int) nudInstrumentCount.Value;

                _scopedStudio.Rooms.Add(
                    new Room(roomNumber, instrumentCount));
                _scopedStudio.InstrumentCount -= instrumentCount;

                this.Close();
            }
        }

    }
}
