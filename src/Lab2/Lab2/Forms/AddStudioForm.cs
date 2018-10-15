using System;
using System.Windows.Forms;
using Lab2.Models;

namespace Lab2.Forms
{
    public partial class AddStudioForm : Form
    {
        public AddStudioForm()
        {
            InitializeComponent();
        }

        private void bAddStudio_Click(object sender, EventArgs e)
        {
            string studioName = tbStudioName.Text;
            string studioAddress = tbStudioAddress.Text;
            double pricePerTrack = (double) nudPricePerTrack.Value;
            double timePerTrack = (double) nudTimePerTrack.Value;
            int instrumentCount = (int) nudInstrumentCount.Value;

            Data.Studios.Add(
                new Studio(studioName, studioAddress, pricePerTrack, timePerTrack, instrumentCount) 
                );

            this.Close();
        }
    }
}