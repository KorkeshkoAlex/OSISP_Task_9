using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace OSISP_Task_9
{
    public partial class Form1 : Form
    {
        private int i = 0;
        private int ii = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Method1()
        {
            Thread.Sleep(1000);
            this.BeginInvoke(new Action(delegate() { this.labelText.Text = "Обновлён " + (i++); }));
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Thread tread = new Thread(Method1);         
            tread.Start();
            this.labelText2.Text = "Запись " + (ii++);
        }
    }
}
