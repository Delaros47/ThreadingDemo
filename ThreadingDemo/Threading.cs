using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingDemo
{
    public partial class Threading : Form
    {
        public Threading()
        {
            InitializeComponent();
            MessageBox.Show($"Thread No : {Thread.CurrentThread.ManagedThreadId}");
        }

        Thread thread;
        private void btnProcessI_Click(object sender, EventArgs e)
        {
            thread = new Thread(ProcessI);
            thread.Start();
        }

        private void ProcessI()
        {
            MessageBox.Show($"Thread No : {Thread.CurrentThread.ManagedThreadId}");
        }

        private void ProcessII()
        {
            MessageBox.Show($"Thread No : {Thread.CurrentThread.ManagedThreadId}");
        }

        private void btnProcessII_Click(object sender, EventArgs e)
        {
            thread = new Thread(ProcessII);
            thread.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
