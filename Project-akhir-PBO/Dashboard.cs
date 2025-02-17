﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_akhir_PBO
{
    public partial class Dashboard : Form
    {
        FormDashboard formDashboard;
        FormKelas formKelas;
        FormMapel formMapel;
        FormPegawai formPegawai;
        FormSiswa formSiswa;




        public Dashboard()
        {
            InitializeComponent();
        }

        bool GuruExpand = false;
        bool AdminExpand = false;
        public int tinggi = 100;

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnMapel_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (formDashboard == null)
            {
                formDashboard = new FormDashboard();
                formDashboard.FormClosed += FormDashboard_FormClosed;
                formDashboard.MdiParent = this;
                formDashboard.Dock = DockStyle.Fill;
                formDashboard.Show();
            }
            else
            {
                formDashboard.Activate();
            }
        }

        private void FormDashboard_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formDashboard = null;
        }

        private void btnGuru_Click(object sender, EventArgs e)
        {
            GuruTransition.Start();
        }

        private void GuruTransition_Tick(object sender, EventArgs e)
        {
            if (GuruExpand == false)
            {
                GuruContainer.Height += tinggi;
                GuruTransition.Stop();
                GuruExpand = true;
            }
            else
            {
                GuruContainer.Height -= tinggi;
                GuruTransition.Stop();
                GuruExpand = false;
            }
        }

        private void AdminTransition_Tick(object sender, EventArgs e)
        {
            if (AdminExpand == false)
            {
                AdminContainer.Height += tinggi;
                AdminTransition.Stop();
                AdminExpand = true;
            }
            else
            {
                AdminContainer.Height -= tinggi;
                AdminTransition.Stop();
                AdminExpand = false;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminTransition.Start();
        }

        private void btnKelas_Click(object sender, EventArgs e)
        {
            if (formKelas == null)
            {
                formKelas = new FormKelas();
                formKelas.FormClosed += FormKelas_FormClosed;
                formKelas.MdiParent = this;
                formKelas.Dock = DockStyle.Fill;
                formKelas.Show();
            }
            else
            {
                formKelas.Activate();
            }
        }

        private void FormKelas_FormClosed(object? sender, FormClosedEventArgs e)
        {
            formKelas = null;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
