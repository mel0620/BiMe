using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BioMetrixCore
{
    public partial class frm_records : Form
    {
        public frm_records ()
        {
            InitializeComponent();
        }

        public void getFilteredDataFromSyncedTable ()
        {
           // Master master = new Master();
           // master.getFilteredData(dgvRec);
        }

        private void frm_records_Load ( object sender, EventArgs e )
        {
            getFilteredDataFromSyncedTable();
        }

        private void dgvRec_CellContentClick ( object sender, DataGridViewCellEventArgs e )
        {
            
        }

    }
}
