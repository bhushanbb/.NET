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
    public partial class DatabaseProgram : Form
    {
        static DataComponent component = new DataComponent();
        public DatabaseProgram()
        {
            InitializeComponent();
        }

        private void DatabaseProgram_Load(object sender, EventArgs e)
        {
            DataTable table = component.GetAllEmployees();
            grdDetails.DataSource = table;
        }
    }
}
