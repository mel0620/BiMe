using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using MySql.Data.MySqlClient;
using Finisar.SQLite;
using zkemkeeper;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using Biometrics;
//using Microsoft.Office.Interop.Excel;
//using ExcelLibrary.CompoundDocumentFormat;
//using ExcelLibrary.SpreadSheet;
//using ExcelLibrary.BinaryDrawingFormat;
//using ExcelLibrary.BinaryFileFormat;

namespace BioMetrixCore
{
    public partial class Master : Form
    {
        DeviceManipulator manipulator = new DeviceManipulator();

        public ZkemClient objZkeeper;
        private bool isDeviceConnected = false;

        public bool IsDeviceConnected
        {
            get { return isDeviceConnected; }
            set
            {
                isDeviceConnected = value;
                if (isDeviceConnected)
                {
                    ShowStatusBar("The device is connected !!", true);
                    btnConnect.Text = "Disconnect";
                    ToggleControls(true);
                }

                else
                {
                    ShowStatusBar("The device is diconnected !!", true);
                    objZkeeper.Disconnect();
                    btnConnect.Text = "Connect";
                    ToggleControls(false);
                }
            }
        }

        public void testing ()
        {
            DateTime dt = new DateTime();
            dt = DateTime.Now;

            MessageBox.Show("Current time is : " + dt.ToString() + "", "Hello");
        }

        private void ToggleControls(bool value)
        {
            btnBeep.Enabled = value;
            btnGetAllUserID.Enabled = value;
            btnUploadUserInfo.Enabled = value;
            btnPost.Enabled = value;
            btnGetLastData.Enabled = value;
            btnGetAllLogData.Enabled = value;
            btnView.Enabled = value;
            btnUserInfo.Enabled = value;
            btnGetLast.Enabled = value;
            btnCountRecords.Enabled = value;
            btnExport.Enabled = value;
            btnToday.Enabled = value;
            btnDeviceTime.Enabled = value;
            btnOff.Enabled = value;
            btnRestart.Enabled = value;
            btnSaveToDB.Enabled = value;
            btnSaveTodayLog.Enabled = value;
            lblFrom.Enabled = value;
            lblTo.Enabled = value;
            dtpFrom.Enabled = value;
            dtpTo.Enabled = value;
            tbxMachineNumber.Enabled = !value;
            tbxPort.Enabled = !value;
            tbxDeviceIP.Enabled = !value;
            send_json_data.Enabled = value;
        }

        /*async static void PostRequest ( string url )
        {

            ICollection<MachineInfo> lstMachineInfo = manipulator.GetTodayLogData(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()));
         
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                //new KeyValuePair<string, string>("Query1", "Digima"),
                //new KeyValuePair<string, string>("Query2", "Web Solutions")

                new KeyValuePair<string, string>("", lstMachineInfo.ToString())
            };
   
            HttpContent q = new FormUrlEncodedContent(queries);

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(url, q))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();
                        HttpContentHeaders headers = content.Headers;

                        //Console.WriteLine(mycontent);
                        MessageBox.Show(mycontent);
                    }
                }
            }
        }*/

        public Master()
        {
            InitializeComponent();
            ToggleControls(false);
            ShowStatusBar(string.Empty, true);
            DisplayEmpty();
        }

        public void getTodayRec()
        {
            try
            {
                ShowStatusBar(string.Empty, true);

                ICollection<MachineInfo> lstMachineInfo = manipulator.GetTodayLogData(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()));

                if (lstMachineInfo != null && lstMachineInfo.Count > 0)
                {
                    BindToGridView(lstMachineInfo);
                    ShowStatusBar(lstMachineInfo.Count + " record/s found !!", true);
                }

                else
                    DisplayListOutput("No record/s found");
            }

            catch (Exception ex)
            {
                DisplayListOutput(ex.Message);
            }
        }

        public void searchDate ()
        {
            try
            {
                ShowStatusBar(string.Empty, true);

                ICollection<MachineInfo> lstMachineInfo = manipulator.GetSearchData(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()), dtpFrom.Value, dtpTo.Value);

                if (lstMachineInfo != null && lstMachineInfo.Count > 0)
                {
                    BindToGridView(lstMachineInfo);
                    ShowStatusBar(lstMachineInfo.Count + " record/s found !!", true);
                }

                else
                    DisplayListOutput("No record/s found");
            }

            catch (Exception ex)
            {
                DisplayListOutput(ex.Message);
            }
        }

        public ICollection<MachineInfo> getFilteredData(DateTime time)
        {
            try
            {
                ShowStatusBar(string.Empty, true);
             
                ICollection<MachineInfo> lstMachineInfo_all = manipulator.GetFilteredData(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()), time);
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
                    ClearGrid();
                    DisplayListOutput("No record/s found");
                    return lstMachineInfo_all;
                }
            }

            catch (Exception ex)
            {
                DisplayListOutput(ex.Message);
               
            }
            return null;
        }

        public void getTimeRec()
        {
            try
            {
                ShowStatusBar(string.Empty, true);

                ICollection<MachineInfo> lstMachineInfo = manipulator.GetLogData(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()));

                if (lstMachineInfo != null && lstMachineInfo.Count > 0)
                {
                    BindToGridView(lstMachineInfo);
                    ShowStatusBar(lstMachineInfo.Count + " record/s found !!", true);
                }

                else
                    DisplayListOutput("No record/s found");
            }

            catch (Exception ex)
            {
                DisplayListOutput(ex.Message);
            }
        }

        private void exportToExcel ()
        {
            DialogResult rslt = MessageBox.Show("Do you really want to export now ??", "Export to Excell", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rslt == DialogResult.Yes)
            {
                try
                {
                    saveFileDialog1.InitialDirectory = "C:";
                    saveFileDialog1.Title = "Save as Excel File";
                    saveFileDialog1.FileName = "";
                    saveFileDialog1.Filter = "Excel Files(2010)|*.xlsx";

                    if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                    {
                        Microsoft.Office.Interop.Excel.Application export = new Microsoft.Office.Interop.Excel.Application();
                        export.Application.Workbooks.Add(Type.Missing);

                        export.Columns.ColumnWidth = 20;

                        // storing header part in Excel  
                        for (int i = 1; i < dgvRecords.Columns.Count + 1; i++)
                        {
                            export.Cells[1, i] = dgvRecords.Columns[i - 1].HeaderText;
                        }

                        // storing Each row and column value to excel sheet  
                        for (int i = 0; i < dgvRecords.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvRecords.Columns.Count; j++)
                            {
                                export.Cells[i + 2, j + 1] = dgvRecords.Rows[i].Cells[j].Value.ToString();
                            }
                        }

                        export.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                        export.ActiveWorkbook.Saved = true;
                        export.Quit();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error!\n" + ex.Message);
                }
            }
        }

        /// <summary>
        /// Your Events will reach here if implemented
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="actionType"></param>
        private void RaiseDeviceEvent(object sender, string actionType)
        {
            switch (actionType)
            {
                case UniversalStatic.acx_Disconnect:
                {
                    ShowStatusBar("The device is switched off", true);
                    DisplayEmpty();
                    btnConnect.Text = "Connect";
                    ToggleControls(false);
                    break;
                }

                default:
                    break;
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                ShowStatusBar(string.Empty, true);

                if (IsDeviceConnected)
                {
                    IsDeviceConnected = false;
                    this.Cursor = Cursors.Default;

                    return;
                }

                string ipAddress = tbxDeviceIP.Text.Trim();
                string port = tbxPort.Text.Trim();
                if (ipAddress == string.Empty || port == string.Empty)
                    throw new Exception("The Device IP Address and Port is mandatory !!");

                int portNumber = 4370;
                if (!int.TryParse(port, out portNumber))
                    throw new Exception("Not a valid port number");

                bool isValidIpA = UniversalStatic.ValidateIP(ipAddress);
                if (!isValidIpA)
                    throw new Exception("The Device IP is invalid !!");

                isValidIpA = UniversalStatic.PingTheDevice(ipAddress);
                if (!isValidIpA)
                    throw new Exception("The device at " + ipAddress + ":" + port + " did not respond!!");

                objZkeeper = new ZkemClient(RaiseDeviceEvent);   
                IsDeviceConnected = objZkeeper.Connect_Net(ipAddress, portNumber);

                getTodayRec();

                //Send Without Click
                timerAuto();

                if (IsDeviceConnected)
                {
                    string deviceInfo = manipulator.FetchDeviceInfo(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()));
                    lblDeviceInfo.Text = deviceInfo;
                }

            }
            catch (Exception ex)
            {
                ShowStatusBar(ex.Message, false);
            }

            this.Cursor = Cursors.Default;

        }

        public void ShowStatusBar(string message, bool type)
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

        private void btnPingDevice_Click(object sender, EventArgs e)
        {
            try
            {
                ShowStatusBar(string.Empty, true);

                string ipAddress = tbxDeviceIP.Text.Trim();

                bool isValidIpA = UniversalStatic.ValidateIP(ipAddress);
                if (!isValidIpA)
                    throw new Exception("The Device IP is invalid !!");

                isValidIpA = UniversalStatic.PingTheDevice(ipAddress);
                if (isValidIpA)
                    ShowStatusBar("The device is active", true);
                else
                    ShowStatusBar("Could not read any response", false);
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGetAllUserID_Click(object sender, EventArgs e)
        {
            try
            {
                ICollection<UserIDInfo> lstUserIDInfo = manipulator.GetAllUserID(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()));

                if (lstUserIDInfo != null && lstUserIDInfo.Count > 0)
                {
                    BindToGridView(lstUserIDInfo);
                    ShowStatusBar(lstUserIDInfo.Count + " record/s found !!", true);
                }

                else
                {
                    DisplayEmpty();
                    DisplayListOutput("No record/s found");
                }

            }
            catch (Exception ex)
            {
                DisplayListOutput(ex.Message);
            }

        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            //objZkeeper.Beep(100);
        }

        private void btnDownloadFingerPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ShowStatusBar(string.Empty, true);

                ICollection<UserInfo> lstFingerPrintTemplates = manipulator.GetAllUserInfo(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()));
                if (lstFingerPrintTemplates != null && lstFingerPrintTemplates.Count > 0)
                {
                    BindToGridView(lstFingerPrintTemplates);
                    ShowStatusBar(lstFingerPrintTemplates.Count + " record/s found !!", true);
                }
                else
                    DisplayListOutput("No record/s found");
            }
            catch (Exception ex)
            {
                DisplayListOutput(ex.Message);
            }

        }

        private void btnPullData_Click(object sender, EventArgs e)
        {
            getTimeRec();
        }

        private void ClearGrid()
        {
            if (dgvRecords.Controls.Count > 2)
            { dgvRecords.Controls.RemoveAt(2); }

            dgvRecords.DataSource = null;
            dgvRecords.Controls.Clear();
            dgvRecords.Rows.Clear();
            dgvRecords.Columns.Clear();
        }

        private void BindToGridView(object list)
        {
            ClearGrid();
            dgvRecords.DataSource = list;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UniversalStatic.ChangeGridProperties(dgvRecords);
        }

        private void DisplayListOutput(string message)
        {
            if (dgvRecords.Controls.Count > 2)
            { dgvRecords.Controls.RemoveAt(2); }

            ShowStatusBar(message, false);
        }

        private void DisplayEmpty()
        {
            ClearGrid();
            dgvRecords.Controls.Add(new DataEmpty());
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        { UniversalStatic.DrawLineInFooter(pnlHeader, Color.FromArgb(204, 204, 204), 2); }

        private void btnPowerOff_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var resultDia = DialogResult.None;
            resultDia = MessageBox.Show("Do you wish to Power Off the Device ??", "Power Off Device", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultDia == DialogResult.Yes)
            {
                bool deviceOff = objZkeeper.PowerOffDevice(int.Parse(tbxMachineNumber.Text.Trim()));

            }

            this.Cursor = Cursors.Default;
        }

        private void btnRestartDevice_Click(object sender, EventArgs e)
        {

            DialogResult rslt = MessageBox.Show("Do you wish to restart the device now ??", "Restart Device", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rslt == DialogResult.Yes)
            {
                if (objZkeeper.RestartDevice(int.Parse(tbxMachineNumber.Text.Trim())))
                    ShowStatusBar("The device is being restarted, Please wait...", true);
                else
                    ShowStatusBar("Operation failed,please try again", false);
            }

        }

        private void btnGetDeviceTime_Click(object sender, EventArgs e)
        {
            int machineNumber = int.Parse(tbxMachineNumber.Text.Trim());
            int dwYear = 0;
            int dwMonth = 0;
            int dwDay = 0;
            int dwHour = 0;
            int dwMinute = 0;
            int dwSecond = 0;

            bool result = objZkeeper.GetDeviceTime(machineNumber, ref dwYear, ref dwMonth, ref dwDay, ref dwHour, ref dwMinute, ref dwSecond);

            string deviceTime = new DateTime(dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond).ToString();

            List<DeviceTimeInfo> lstDeviceInfo = new List<DeviceTimeInfo>();
            
            lstDeviceInfo.Add(new DeviceTimeInfo() { DeviceTime = deviceTime });
            
            BindToGridView(lstDeviceInfo);
        }

        private void btnEnableDevice_Click(object sender, EventArgs e)
        {
            // This is of no use since i implemented zkemKeeper the other way
            bool deviceEnabled = objZkeeper.EnableDevice(int.Parse(tbxMachineNumber.Text.Trim()), true);
        }

        private void btnDisableDevice_Click(object sender, EventArgs e)
        {
            // This is of no use since i implemented zkemKeeper the other way
            bool deviceDisabled = objZkeeper.DisableDeviceWithTimeOut(int.Parse(tbxMachineNumber.Text.Trim()), 3000);
        }

        private void tbxPort_TextChanged(object sender, EventArgs e)
        { UniversalStatic.ValidateInteger(tbxPort); }

        private void tbxMachineNumber_TextChanged(object sender, EventArgs e)
        { UniversalStatic.ValidateInteger(tbxMachineNumber); }

        private void btnUploadUserInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented.");
            // Add you new UserInfo Here and  uncomment the below code
            //List<UserInfo> lstUserInfo = new List<UserInfo>();
            //manipulator.UploadFTPTemplate(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()), lstUserInfo);
        }

        private void btnExportToExcel_Click ( object sender, EventArgs e )
        {
            exportToExcel();
        }

        private void btnToday_Click ( object sender, EventArgs e )
        {
            getTodayRec();
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            searchDate();
        }

        private void btnPost_Click ( object sender, EventArgs e )
        {
            //PostRequest("https://posttestserver.com/post.php");
        }

        private void picbtnSearch_Click ( object sender, EventArgs e )
        {
            searchDate();
        }

        private void picbtnGetAllUserInfo_Click ( object sender, EventArgs e )
        {
            try
            {
                ShowStatusBar(string.Empty, true);

                ICollection<UserInfo> lstFingerPrintTemplates = manipulator.GetAllUserInfo(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()));
                if (lstFingerPrintTemplates != null && lstFingerPrintTemplates.Count > 0)
                {
                    BindToGridView(lstFingerPrintTemplates);
                    ShowStatusBar(lstFingerPrintTemplates.Count + " record/s found !!", true);
                }
                else
                    DisplayListOutput("No record/s found");
            }
            catch (Exception ex)
            {
                DisplayListOutput(ex.Message);
            }
        }

        public void timerAuto ()
        {
            /*DateTime dt = DateTime.Now;

            String.Format(dt.ToLongTimeString());

            if (dt.ToLongTimeString() == "3:37:00 PM")
            {
                MessageBox.Show("Success!");
            }*/

            //MessageBox.Show("The time is: " + dt.ToLongTimeString());

            Timer _tmr = new Timer();

            _tmr.Interval = 10000;  // interval in millisecond

            _tmr.Tick += new EventHandler(tmrReload_Tick);

            _tmr.Start();

        }

        private void Master_Load ( object sender, EventArgs e )
        {
            //System.Diagnostics.Debug.WriteLine("printed");
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnUserInfo, "Get all user info");
            ToolTip1.SetToolTip(this.btnView, "Show");
            ToolTip1.SetToolTip(this.btnGetAllLogData, "Get all log data");
            ToolTip1.SetToolTip(this.btnToday, "Get today's log data");
            ToolTip1.SetToolTip(this.btnDeviceTime, "Get device time");
            ToolTip1.SetToolTip(this.btnExport, "Export to excell");
            ToolTip1.SetToolTip(this.btnRestart, "Restart the device");
            ToolTip1.SetToolTip(this.btnOff, "Power off the device");
            ToolTip1.SetToolTip(this.btnPingDevice, "Ping the device");
        }

        private void picbtnGetAllLog_Click ( object sender, EventArgs e )
        {
            getTimeRec();
        }

        private void picbtnExport_Click ( object sender, EventArgs e )
        {
            exportToExcel();
        }

        private void picbtnTodayLog_Click ( object sender, EventArgs e )
        {
            getTodayRec();
        }

        private void picbtnDeviceTime_Click ( object sender, EventArgs e )
        {
            int machineNumber = int.Parse(tbxMachineNumber.Text.Trim());
            int dwYear = 0;
            int dwMonth = 0;
            int dwDay = 0;
            int dwHour = 0;
            int dwMinute = 0;
            int dwSecond = 0;

            bool result = objZkeeper.GetDeviceTime(machineNumber, ref dwYear, ref dwMonth, ref dwDay, ref dwHour, ref dwMinute, ref dwSecond);

            string deviceTime = new DateTime(dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond).ToString();

            List<DeviceTimeInfo> lstDeviceInfo = new List<DeviceTimeInfo>();

            lstDeviceInfo.Add(new DeviceTimeInfo() { DeviceTime = deviceTime });

            BindToGridView(lstDeviceInfo);
        }

        private void picbtnPowerOff_Click ( object sender, EventArgs e )
        {
            this.Cursor = Cursors.WaitCursor;

            var resultDia = DialogResult.None;
            resultDia = MessageBox.Show("Do you wish to Power Off the Device ??", "Power Off Device", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultDia == DialogResult.Yes)
            {
                bool deviceOff = objZkeeper.PowerOffDevice(int.Parse(tbxMachineNumber.Text.Trim()));

            }

            this.Cursor = Cursors.Default;
        }

        private void picbtnRestart_Click ( object sender, EventArgs e )
        {
            DialogResult rslt = MessageBox.Show("Do you wish to restart the device now ??", "Restart Device", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rslt == DialogResult.Yes)
            {
                if (objZkeeper.RestartDevice(int.Parse(tbxMachineNumber.Text.Trim())))
                    ShowStatusBar("The device is being restarted, Please wait...", true);
                else
                    ShowStatusBar("Operation failed,please try again", false);
            }
        }

        private void btnExport_Click ( object sender, EventArgs e )
        {
            exportToExcel();
        }

        private void btnRestart_Click ( object sender, EventArgs e )
        {
            DialogResult rslt = MessageBox.Show("Do you wish to restart the device now ??", "Restart Device", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rslt == DialogResult.Yes)
            {
                if (objZkeeper.RestartDevice(int.Parse(tbxMachineNumber.Text.Trim())))
                    ShowStatusBar("The device is being restarted, Please wait...", true);
                else
                    ShowStatusBar("Operation failed,please try again", false);
            }
        }

        private void btnOff_Click ( object sender, EventArgs e )
        {
            this.Cursor = Cursors.WaitCursor;

            var resultDia = DialogResult.None;
            resultDia = MessageBox.Show("Do you wish to Power Off the Device ??", "Power Off Device", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultDia == DialogResult.Yes)
            {
                bool deviceOff = objZkeeper.PowerOffDevice(int.Parse(tbxMachineNumber.Text.Trim()));

            }

            this.Cursor = Cursors.Default;
        }

        private void btnDeviceTime_Click ( object sender, EventArgs e )
        {
            int machineNumber = int.Parse(tbxMachineNumber.Text.Trim());
            int dwYear = 0;
            int dwMonth = 0;
            int dwDay = 0;
            int dwHour = 0;
            int dwMinute = 0;
            int dwSecond = 0;

            bool result = objZkeeper.GetDeviceTime(machineNumber, ref dwYear, ref dwMonth, ref dwDay, ref dwHour, ref dwMinute, ref dwSecond);

            string deviceTime = new DateTime(dwYear, dwMonth, dwDay, dwHour, dwMinute, dwSecond).ToString();

            List<DeviceTimeInfo> lstDeviceInfo = new List<DeviceTimeInfo>();

            lstDeviceInfo.Add(new DeviceTimeInfo() { DeviceTime = deviceTime });

            BindToGridView(lstDeviceInfo);
        }

        private void btnToday_Click_1 ( object sender, EventArgs e )
        {
            getTodayRec();
        }

        private void btnGetAllLogData_Click ( object sender, EventArgs e )
        {
            getTimeRec();
        }

        private void btnUserInfo_Click ( object sender, EventArgs e )
        {
            try
            {
                ShowStatusBar(string.Empty, true);

                ICollection<UserInfo> lstFingerPrintTemplates = manipulator.GetAllUserInfo(objZkeeper, int.Parse(tbxMachineNumber.Text.Trim()));

                if (lstFingerPrintTemplates != null && lstFingerPrintTemplates.Count > 0)
                {
                    BindToGridView(lstFingerPrintTemplates);
                    ShowStatusBar(lstFingerPrintTemplates.Count + " record/s found !!", true);
                }
                else
                    DisplayListOutput("No record/s found");
            }
            catch (Exception ex)
            {
                DisplayListOutput(ex.Message);
            }
        }

        private void button1_Click ( object sender, EventArgs e )
        {
            searchDate();
        }

        private void btnGetLastData_Click ( object sender, EventArgs e )
        {
            try
            {
                string machine_num  = (String)dgvRecords[0, dgvRecords.RowCount - 1].Value.ToString();
                string employee_num = (String)dgvRecords[1, dgvRecords.RowCount - 1].Value.ToString();
                string dat_time_rec = (String)dgvRecords[2, dgvRecords.RowCount - 1].Value.ToString();
                string in_out       = (String)dgvRecords[3, dgvRecords.RowCount - 1].Value.ToString();

                MessageBox.Show("Machine Number : " + machine_num + "\n\nEmployee Number : " + employee_num + "\n\nDate and Time : " + dat_time_rec + "\n\n0 - In | 1 - Out : " + in_out, "Last In/Out");

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveToText_Click ( object sender, EventArgs e )
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Text File|*.txt";

            var result = dialog.ShowDialog();

            if (result != DialogResult.OK)
                return;

            StringBuilder builder = new StringBuilder();

            int rowcount = dgvRecords.Rows.Count;

            int columncount = dgvRecords.Columns.Count;

            List<string> headerCols = new List<string>();

            for (int j = 0; j < columncount; j++)
            {
                headerCols.Add(dgvRecords.Columns[j].HeaderText);
            }

            builder.AppendLine(string.Join("\t", headerCols));

            //string last_data = (String)dgvRecords[0, dgvRecords.RowCount - 1].Value.ToString();
            //MessageBox.Show(last_data);

            for (int i = 0; i < rowcount; i++)
            {
                List<string> cols = new List<string>();

                for (int j = 0; j < columncount; j++)
                {
                    cols.Add(dgvRecords.Rows[i].Cells[j].Value.ToString());
                }

                builder.AppendLine(string.Join("\t", cols.ToArray()));
            }

            System.IO.File.WriteAllText(dialog.FileName, builder.ToString());
            MessageBox.Show(@"Text file was created.");
        }

        private void btnSaveToDB_Click ( object sender, EventArgs e )
        {
            getTodayRec();

            var resultDia1 = DialogResult.None;
            resultDia1 = MessageBox.Show("Do you really want to sync??", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultDia1 == DialogResult.Yes)
            {
                try
                {
                    string constring = "datasource=localhost; database=biometrics; port=3306; username=root; password=";

                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO sync_table(last_synced, latest_synced) SELECT latest_synced, NOW() FROM sync_table ORDER BY sync_id DESC LIMIT 1", con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }

                        var resultDia2 = DialogResult.None;
                        resultDia2 = MessageBox.Show("Successfully synced!\nDo you want to show it ??", "Show Sync Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultDia2 == DialogResult.Yes)
                        {
                            Log_Viewer dbviewer = new Log_Viewer();
                            dbviewer.Show();
                        }
                        //MessageBox.Show("Records inserted.");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void btnSaveTodayLog_Click ( object sender, EventArgs e )
        {
            getTodayRec();

            try
            {
                string constring = "datasource=localhost; database=biometrics; port=3306; username=root; password=";

                foreach (DataGridViewRow row in dgvRecords.Rows)
                {
                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("TRUNCATE TABLE employee_logs_tbl", con))
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }

                foreach (DataGridViewRow row in dgvRecords.Rows)
                {
                    using (MySqlConnection con = new MySqlConnection(constring))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("INSERT INTO employee_logs_tbl(employee_id, datetime_record, in_out) VALUES(@employeeid, @datetimerecord, @inout)", con))
                        {
                            cmd.Parameters.AddWithValue("@employeeid", row.Cells["employeeid"].Value);
                            cmd.Parameters.AddWithValue("@datetimerecord", row.Cells["datetimerecord"].Value);
                            cmd.Parameters.AddWithValue("@inout", row.Cells["inout"].Value);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }

                using (MySqlConnection con = new MySqlConnection(constring))
                {
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO temp_tbl(temp_datetime, employee_id, datetime_record, in_out) SELECT now(), employee_id, datetime_record, in_out FROM employee_logs_tbl", con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                var resultDia = DialogResult.None;
                resultDia = MessageBox.Show("Records successfully save!\nDo you want to show it ??", "Show Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               
                if (resultDia == DialogResult.Yes)
                {
                    Log_Viewer dbviewer = new Log_Viewer();
                    dbviewer.Show();
                }

                //MessageBox.Show("Records inserted.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        public DateTime returnLastLog ()
        {
            string myConnection = "datasource=localhost; database=biometrics; port=3306; username=root; password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT latest_synced FROM sync_table ORDER BY sync_id DESC LIMIT 1;";
            MySqlDataReader myReader;

            DateTime dateTime = DateTime.Now;
         
            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();
                
                while (myReader.Read())
                {
                    dateTime = Convert.ToDateTime(myReader[0].ToString());
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            myConn.Close();

            return dateTime;
        }

        public void getLastLog ()
        {

            string myConnection = "datasource=localhost; database=biometrics; port=3306; username=root; password=";
            MySqlConnection myConn = new MySqlConnection(myConnection);
            MySqlCommand command = myConn.CreateCommand();
            command.CommandText = "SELECT latest_synced FROM sync_table ORDER BY sync_id DESC LIMIT 1;";
            MySqlDataReader myReader;

            try
            {
                myConn.Open();
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    MessageBox.Show("Date and Time: " + myReader[0].ToString(), "Last Synced");
                    //lblpartylist1.Text = myReader[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            myConn.Close();
        }

        private void btnGetLast_Click ( object sender, EventArgs e )
        {
            getLastLog();
            //returnLastLog();
        }

        private void btnCountRecords_Click ( object sender, EventArgs e )
        {
            DateTime dateTime = returnLastLog();
            //MessageBox.Show(dateTime+"");
            getFilteredData(dateTime);
        }

        public void sendTest ()
        {
            var dateTime = returnLastLog();
            var syncData = getFilteredData(dateTime);
            var json = JsonConvert.SerializeObject(syncData);//, Formatting.Indented
            send_data(json);
        }

        private void send_json_data_Click(object sender, EventArgs e)
        {
            sendTest();
        }

        public HttpResponseMessage ExecuteWithRetry ( string url, string contentString )
        {
            HttpResponseMessage result = null;
            bool success = false;

            using (var client = new HttpClient())
            {
                do
                {
                    result = client.PostAsync(url, new StringContent(contentString)).Result;
                    success = result.IsSuccessStatusCode;
                }

                while (!success);
            }

            return result;
        } 

        public void send_data(string data_input)
        {
            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();

                var postData = "appkey=" + config.appkey;
                postData += "&appsecret=" + config.appsecret;
                postData += "&branchid=" + config.branchid;
                postData += "&data_input=" + data_input;

                byte[] data = encoding.GetBytes(postData);

                WebRequest request = (HttpWebRequest)WebRequest.Create("http://digimahouse.dev/member/payroll/biometrics/save_data");
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                Stream stream = request.GetRequestStream();
                stream.Write(data, 0, data.Length);
                stream.Close();

                WebResponse response = request.GetResponse();
                stream = response.GetResponseStream();

                StreamReader sr = new StreamReader(stream);

                MessageBox.Show(sr.ReadToEnd());

            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to import data\n" + ex.Message);
            }
        }

        private void bgWorker_DoWork ( object sender, DoWorkEventArgs e )
        {
            sendTest();
        }

        private void bgWorker_ProgressChanged ( object sender, ProgressChangedEventArgs e )
        {

        }

        private void bgWorker_RunWorkerCompleted ( object sender, RunWorkerCompletedEventArgs e )
        {
            MessageBox.Show("Process Completed!");
        }

        private void tmrReload_Tick ( object sender, EventArgs e )
        {
            
            if (DateTime.Now.Hour == 21 && DateTime.Now.Minute == 00)
            {
                bgWorker.RunWorkerAsync();
            }
            //
        }
    }

    //library code
}
