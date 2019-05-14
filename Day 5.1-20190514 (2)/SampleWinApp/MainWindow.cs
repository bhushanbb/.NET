using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWinApp
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void viewAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatabaseProgram pgrm = new DatabaseProgram();//Instantiate UR Form
            pgrm.MdiParent = this;//Set the MDIParent property as the MainWindow
            pgrm.Show();//Display the form
        }

        private void addNewRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent win = new AddStudent();
            win.MdiParent = this;
            win.Show();
        }
    }
}
