﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankMap.Views
{
    public partial class AddBank : Form
    {
        public AddBank()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Вы не ввели имя.", "Ошибка заполнения поля");
            }
            else
            {
                Program.db.AddBankAsync(textBox1.Text);
                Close();
            }
        }
    }
}
