using System;
using System.ComponentModel;
using System.Windows.Forms;
using Lab2.Models;

namespace Lab2.Forms
{
    public partial class ManageStudioForm : Form
    {
        private Studio _scopedStudio;

        public ManageStudioForm()
        {
            InitializeComponent();
        }

        public ManageStudioForm(Studio studio) : this()
        {
            _scopedStudio = studio;
        }

        private void ManageStudioForm_Load(object sender, EventArgs e)
        {
            tbStudioName.Text = _scopedStudio.StudioName;
            tbStudioAddress.Text = _scopedStudio.StudioAddress;
            nudPricePerTrack.Text = _scopedStudio.PricePerTrack.ToString();
            nudTimePerTrack.Text = _scopedStudio.TimePerTrack.ToString();
            nudInstrumentCount.Text = _scopedStudio.InstrumentCount.ToString(); 

            dgvRooms.DataSource = _scopedStudio.Rooms;
            dgvEmployees.DataSource = _scopedStudio.Employees;
            RecalculateStudioSalary();
            _scopedStudio.Employees.ListChanged += OnEmployeesListChanged;       
        }

        private void bAddRoom_Click(object sender, EventArgs e)
        {
            using (var addRoomForm = new AddRoomForm(_scopedStudio))
            {
                addRoomForm.ShowDialog();
            }
        }

        private void bAddEmployee_Click(object sender, EventArgs e)
        {
            using (var addEmployeeForm = new AddEmpolyeeForm(_scopedStudio))
            {
                addEmployeeForm.ShowDialog();
            }
        }

        private void OnEmployeesListChanged(object sender, ListChangedEventArgs e)
        {
            RecalculateStudioSalary();
        }

        private void RecalculateStudioSalary()
        {
            string labelRecalculatedText = $"Общая зарплата сотрудников студии: {_scopedStudio.StudioSalary.ToString()}";
            lStudioSalary.Text = labelRecalculatedText;
        }

        private void bRemoveEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                _scopedStudio.Employees.Remove(
                    dgvEmployees.CurrentRow.DataBoundItem as Employee);
            }
        }

        private void bRemoveRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow != null)
            {
                _scopedStudio.Rooms.Remove(
                    dgvRooms.CurrentRow.DataBoundItem as Room);
            }
        }

        private void bAddEmployeeToRoom_Click(object sender, EventArgs e)
        {
            if (dgvRooms.CurrentRow != null && dgvEmployees != null)
            {
                var room = dgvRooms.CurrentRow.DataBoundItem as Room;
                var employee = dgvEmployees.CurrentRow.DataBoundItem as Employee;

                if (employee.IsFree)
                {
                    room.AssignedEmployees.Add(employee);
                    employee.IsFree = false;
                    dgvRooms.DataSource = _scopedStudio.Rooms;
                }
            }
        }

        private void dgvRooms_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRooms.CurrentRow != null)
            {
                using (var manageRoomForm = new ManageRoomForm(
                    dgvRooms.CurrentRow.DataBoundItem as Room))
                {
                    manageRoomForm.ShowDialog();
                }
            }
        }
    }
}
