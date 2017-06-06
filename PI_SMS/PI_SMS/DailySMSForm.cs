using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PI_SMS
{
    public partial class DailySMSForm : Form
    {
        public DailySMSForm()
        {
            InitializeComponent();
            //label1.MouseDown = new MouseEventHandler(label1_MouseDown);
            //textBox1.AllowDrop = true;
            //textBox1.DragEnter = new DragEventHandler(textBox1_DragEnter);
            //textBox1.DragDrop += new DragEventHandler(textBox1_DragDrop);
        }

        private void DailySMSForm_Load(object sender, EventArgs e)
        {
            //ControlExtension.Draggable(label1,true);
        }

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            textBox1.Text += e.Data.GetData(DataFormats.OemText).ToString();
            //if (e.Data.GetDataPresent(DataFormats.Text))
            //{
            //    e.Effect = DragDropEffects.All;
            //    textBox1.Text = e.Data.GetData(DataFormats.Text).ToString();
            //}

        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            //DoDragDrop(label1.Text, DragDropEffects.Copy);
        }

    }
}
