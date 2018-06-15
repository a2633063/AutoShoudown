using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 自动关机Cmd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateTime dt = System.DateTime.Now;
            labTiem.Text = dt.ToString("yyyy年M月d日 HH:mm:ss");
            dtpDate.MinDate = dt;
            //dtpTime.MinDate = dt;
            dtpDate.Value = dt;
            dtpTime.Value = dt.AddHours(1);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            labTiem.Text = dt.ToString("yyyy年M月d日 HH:mm:ss");

        }

        private void radioButton_Time_CheckedChanged(object sender, EventArgs e)
        {
            panelTime0.Enabled = rdbTime0.Checked;
            panelTime1.Enabled = rdbTime1.Checked;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int time = 315360000;
            if (rdbTime0.Checked)
            {
                DateTime dt1 = System.DateTime.Now;
                DateTime dt2 = new DateTime(dtpDate.Value.Year, dtpDate.Value.Month, dtpDate.Value.Day, dtpTime.Value.Hour, dtpTime.Value.Minute, dtpTime.Value.Second);
                TimeSpan ts = dt2.Subtract(dt1);
                if (ts.TotalSeconds < 0)
                {
                    MessageBox.Show("时间设置异常!");
                    return;
                }
                time = (int)ts.TotalSeconds;
            }
            else if (rdbTime1.Checked)
            {
                time = (int)nudHour.Value * 60 + (int)nudMin.Value;
                time *= 60;
            }
                String cmd = "";
                if (rabShutdown0.Checked)
                {
                    cmd = @"/s";
                }
                else if(rabShutdown1.Checked)
                {
                    cmd = @"/r";
                }else if (rabShutdown2.Checked)
                {
                    cmd = @"/l";
                }
                else if(rabShutdown3.Checked)
                {
                    cmd = @"/h";
                }
            cmd += @" /t " + time;
                Console.WriteLine(cmd);
                    Cmd(cmd);
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cmd(@"/a");            
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            //dtpTime.Value
            
        }


        String Cmd(String cmd)
        {
            Process p = new Process();
            p.StartInfo.FileName = "shutdown";           //设定程序名   
            p.StartInfo.Arguments = cmd;// folderpath; //ls命令  foldername:"storage/emulated/0"
            p.StartInfo.UseShellExecute = false;        //关闭Shell的使用   
            p.StartInfo.RedirectStandardInput = true;   //重定向标准输入   
            p.StartInfo.RedirectStandardOutput = true;  //重定向标准输出   
            p.StartInfo.RedirectStandardError = true;   //重定向错误输出   
            p.StartInfo.CreateNoWindow = true;          //设置不显示窗口   
            p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            p.Start();

            String result = p.StandardOutput.ReadToEnd();
            String error = p.StandardError.ReadToEnd();
            p.Close();
            return result+";"+ error;
        }


    }
}
