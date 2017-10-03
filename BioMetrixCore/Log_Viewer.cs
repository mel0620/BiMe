using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BioMetrixCore
{
    public partial class Log_Viewer : Form
    {
        DeviceManipulator manipulator = new DeviceManipulator();
        Master master = new Master();

        public ZkemClient objZkeeper;

        public Log_Viewer ()
        {
            InitializeComponent();
        }

        DataTable table;

        public void BindToGridView1 ()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UniversalStatic.ChangeGridProperties(dataGridView1);
        }

        public void BindToGridView (object list )
        {
            dgvSyncedData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UniversalStatic.ChangeGridProperties(dgvSyncedData);
        }

        public ICollection<MachineInfo> GetSyncData ( DateTime dfrom )
        {
            string dtfrom = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            dfrom = DateTime.Parse(dtfrom);

            try
            {
                ShowStatusBar(string.Empty, true);

                ICollection<MachineInfo> lstMachineInfo_all = manipulator.GetSyncedData(objZkeeper, int.Parse(master.tbxMachineNumber.Text.Trim()), dfrom);
                ICollection<MachineInfo> lstMachineInfo_employee = new List<MachineInfo>();

                if (lstMachineInfo_all != null && lstMachineInfo_all.Count > 0)
                {
                    foreach (var i in lstMachineInfo_all)
                    {
                        lstMachineInfo_employee.Add(i);
                    }

                    BindToGridView(lstMachineInfo_all);
                    ShowStatusBar(lstMachineInfo_all.Count + " record/s found !!", true);
                    return lstMachineInfo_all;
                }

                else
                {
                    MessageBox.Show("No record/s found");
                    return lstMachineInfo_all;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");

            }
            return null;
        }

        public void ShowStatusBar ( string message, bool type )
        {
            if (message.Trim() == string.Empty)
            {
                lblStatus.Visible = false;
                return;
            }

            lblStatus.Visible = true;
            lblStatus.Text = message;
            lblStatus.ForeColor = Color.White;

            if (type)
                lblStatus.BackColor = Color.FromArgb(0, 81, 255);
            else
                lblStatus.BackColor = Color.FromArgb(255, 77, 77);
        }

        /*public void load_employee_log_table ()
        {
            string connection = "datasource=localhost; database=biometrics; port=3306; username=root; password=";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM emp_log_view;", mycon);
            ShowStatusBar(string.Empty, true);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);

                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = source;
                adap.Update(table);
                BindToGridView();
                ShowStatusBar(dataGridView1.RowCount - 1 + " records found !!", true);
                mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        /*public void load_temp_table ()
        {
            string connection = "datasource=localhost; database=biometrics; port=3306; username=root; password=";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM temp_view;", mycon);
            ShowStatusBar(string.Empty, true);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);

                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = source;
                adap.Update(table);
                BindToGridView();
                ShowStatusBar(dataGridView1.RowCount - 1 + " records found !!", true);
                mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/

        public void load_sync_table ()
        {
            string connection = "datasource=localhost; database=biometrics; port=3306; username=root; password=";
            MySqlConnection mycon = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM sync_table_view;", mycon);
            ShowStatusBar(string.Empty, true);

            try
            {
                mycon.Open();

                MySqlDataAdapter adap = new MySqlDataAdapter();
                adap.SelectCommand = cmd;
                table = new DataTable();
                adap.Fill(table);

                BindingSource source = new BindingSource();
                source.DataSource = table;
                dataGridView1.DataSource = source;
                adap.Update(table);
                BindToGridView1();
                ShowStatusBar(dataGridView1.RowCount - 1 + " record/s found !!", true);
                mycon.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSyncOffline_Click ( object sender, EventArgs e )
        {
            try
            {
                string constring = "datasource=localhost; database=biometrics; port=3306; username=root; password=";

                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO temp_tbl(temp_datetime) SELECT datetime_record FROM employee_logs_tbl", con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Records inserted.","Synced");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void DB_Viewer_Load ( object sender, EventArgs e )
        {
            load_sync_table();
        }
        
        private void dataGridView1_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            DateTime dateTime = master.returnLastLog();
            GetSyncData(dateTime);
        }

    }
}
