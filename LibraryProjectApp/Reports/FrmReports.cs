using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProjectApp.Reports
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        EscrowBookManager _escBookManager = new EscrowBookManager(new EfEscrowBookDal());
        private void btnBring_Click(object sender, EventArgs e)
        {
            var result = _escBookManager.GetEscrowBookSearchDate(dtFirstDate.Value,dtSecondDate.Value);
            if (result.Success)
            {
                dataGridView1.DataSource = result.Data;
            }
            else
            {
                MessageBox.Show(result.Message);
            }
        }
    }
}
