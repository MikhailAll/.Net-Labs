using System;
using System.Windows.Forms;
using Lab2.Models;

namespace Lab2.Forms
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Data.Init();
            dgvStudios.DataSource = Data.Studios;
        }

        private void bAddStudio_Click(object sender, EventArgs e)
        {
            using (var addStudioForm = new AddStudioForm())
            {
                addStudioForm.ShowDialog();
            }

        }

        private void bRemoveStudio_Click(object sender, EventArgs e)
        {
            if (dgvStudios.CurrentRow != null)
            {
                Data.Studios.Remove(
                    dgvStudios.CurrentRow.DataBoundItem as Studio);
            }
        }

        private void dgvStudios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();

            using (var manageStudioForm = new ManageStudioForm(
                dgvStudios.CurrentRow.DataBoundItem as Studio))
            {
                manageStudioForm.ShowDialog();
            }

            this.Show();
        }

        private void bCloneStudio_Click(object sender, EventArgs e)
        {
            if (dgvStudios.CurrentRow != null)
            {
                var studio = dgvStudios.CurrentRow.DataBoundItem as Studio;
                Data.Studios.Add(studio.Clone() as Studio);
            }
        }
    }
}