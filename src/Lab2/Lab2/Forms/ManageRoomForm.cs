using System;
using System.Windows.Forms;
using Lab2.Models;

namespace Lab2.Forms
{
    public partial class ManageRoomForm : Form
    {
        private Room _scopedRoom;

        public ManageRoomForm()
        {
            InitializeComponent();
        }

        public ManageRoomForm(Room room) : this()
        {
            _scopedRoom = room;
        }

        private void ManageRoomForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = _scopedRoom.AssignedEmployees;
        }

        private void bRemoveEmployeeFromRoom_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                var employee = dgvEmployees.CurrentRow.DataBoundItem as Employee;
                _scopedRoom.AssignedEmployees.Remove(employee);
                employee.IsFree = true;
            }
        }

    }
}
