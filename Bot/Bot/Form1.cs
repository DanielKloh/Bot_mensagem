﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            Thread.Sleep(5000);
            int qtd = int.Parse(txtQtd.Text);

            for(int i =0; i< qtd; i++)
            {
            SendKeys.Send(txtMensagem.Text);
            SendKeys.Send("{Enter}");
            }
            
            return;
            




        }
        
    }
}
