﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace OOP_4SEM_3
{
    public partial class SaveAs : Form
    {
        private string info;

        public SaveAs(string path, string info)
        {
            InitializeComponent();
            this.info = info;
        }

        private void SaveAs_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(FileName.Text))
            {
                stream.Write(info);
                this.Hide();
            }
        }
    }
}
