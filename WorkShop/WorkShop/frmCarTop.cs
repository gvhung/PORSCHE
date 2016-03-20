using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Workshop
{
    public partial class frmCarTop : Form
    {
        public frmCarTop(int recordid)
        {
            InitializeComponent();
            RecordID = recordid;
        }
        int RecordID = -1;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbPreSA.Text))
            {
                MessageBox.Show("接车人不能为空。");
                return;
            }
            string sqlstring = "Update A set A.CarTopNo='" + textBox1.Text + "',A.Receiver='" + cmbPreSA.Text + "',A.PlanOutTime='" + dateTimePicker1.Text + " " + numericUpDown1.Value.ToString() + ":" + numericUpDown2.Value.ToString() + "'";
            sqlstring += " ,State='正式',Success=1,ComeTime='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "'";
            sqlstring += " From Booking A,(Select CarNo,BookTime From Booking Where ID=" + RecordID + ") B";
            sqlstring += " Where A.CarNo=B.CarNo And substring(convert(nvarchar(50),A.booktime,120),1,10)=substring(convert(nvarchar(50),B.booktime,120),1,10)";
           try
           {
               if (SQLDbHelper.ExecuteSql(sqlstring) > 0)
               {
                   SQLDbHelper.ExecuteSql("Exec Sp_SetIsBook");
                   ClsBLL.AddSysLog(RecordID, "预约接车，车牌号码:" + SQLDbHelper.ExecuteScalar("Select CarNo from Booking Where ID=" + RecordID).ToString());
                   this.DialogResult = DialogResult.OK;
               }
               this.Close();
           }
           catch(Exception Err)
           {
               MessageBox.Show(Err.Message);
           }
        }

        private void frmCarTop_Load(object sender, EventArgs e)
        {
            ClsBLL.IniCombox(cmbPreSA, "SA");
            string sqlstring = "Select ServiceHour,PreSA From Booking Where ID="+RecordID;
            try
            {
                DataSet dataSet = SQLDbHelper.Query(sqlstring);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    double hours = double.Parse(dataSet.Tables[0].Rows[0][0].ToString());
                    numericUpDown1.Value = DateTime.Now.AddHours(hours).Hour;

                    cmbPreSA.Text = dataSet.Tables[0].Rows[0][1].ToString();
                }
            }
            catch (Exception Err)
            {
                MessageBox.Show(Err.Message);
            }
            textBox1.Focus();
        }

        private void frmCarTop_Activated(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}