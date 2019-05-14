using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SampleWinApp.Models;
namespace SampleWinApp
{
    public partial class AddStudent : Form
    {
        DataComponent com = new DataComponent();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string address = txtAddress.Text;
                com.AddNewStudent(id, name, address);
                MessageBox.Show("Added");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Canceled");
            this.Close();
        }
    }
}
