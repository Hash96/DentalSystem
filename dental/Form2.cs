﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DoctorLogin d = new DoctorLogin();
            d.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LabAssistantLogin l = new LabAssistantLogin();
            l.ShowDialog();

        }
    }
}
