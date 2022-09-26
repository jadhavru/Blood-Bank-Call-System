using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BB
{
    public partial class WindowsInputInsertBox : Form
    {
        public string Result1 { get; set; }
        string promptMessage1 = "", promptMessage2 = "", caption = "";
        string val1 = "";

        public WindowsInputInsertBox()
        {
            InitializeComponent();
        }

        public WindowsInputInsertBox(string prompt1, string v1, string capt)
        {
            InitializeComponent();

            promptMessage1 = prompt1;
            val1 = v1;

            caption = capt;
        }

        private void WindowsInputInsertBox_Load(object sender, EventArgs e)
        {
            label1.Text = caption;

            textBoxValue.Text = val1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result1 = textBoxValue.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
