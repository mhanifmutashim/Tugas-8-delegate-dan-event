﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FormCalculator : Form
    {
        // deklarasi tipe data untuk event OnCreate dan OnUpdate
        public delegate void CreateUpdateEventHandler(ClassOperasi cal);

        // deklarasi event ketika terjadi proses input data baru
        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        // deklarasi field untuk meyimpan objek mahasiswa
        private ClassOperasi cal;

        public FormCalculator()
        {
            InitializeComponent();
        }

        public FormCalculator(string title) : this()
        {
            this.Text = title;
        }

        private void bttnHitung_Click(object sender, EventArgs e)
        {
            if (isNewData) cal = new ClassOperasi();
            if (txtNilaiA.Text == "" || txtNilaiB.Text == "")
            {
                MessageBox.Show("Data belum diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNilaiA.Focus();
            }
            else if (cmbOperasi.Text == "")
            {
                MessageBox.Show("Pilih Operasi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbOperasi.Focus();
            }
            else
            {
                if (cmbOperasi.Text == "Penjumlahan")
                {
                    cal.Hasil = "Hasil Penjumlahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) + int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Pengurangan")
                {
                    cal.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) - int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Perkalian")
                {
                    cal.Hasil = "Hasil Perkalian " + txtNilaiA.Text + " x " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) * int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Pembagian")
                {
                    cal.Hasil = "Hasil Pembagian " + txtNilaiA.Text + " : " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) / int.Parse(txtNilaiB.Text));
                }
                if (isNewData) // data baru
                {
                    OnCreate(cal);
                }
                else // update
                {
                    OnUpdate(cal); // panggil event OnUpdate
                    this.Close();
                }

                OnUpdate(cal); // panggil event OnUpdate
                this.Close();

            }
        }

        private void bttnProses_Click(object sender, EventArgs e)
        {
            if (isNewData) cal = new ClassOperasi();
            if (txtNilaiA.Text == "" || txtNilaiB.Text == "")
            {
                MessageBox.Show("Data belum diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNilaiA.Focus();
            }
            else if (cmbOperasi.Text == "")
            {
                MessageBox.Show("Pilih Operasi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbOperasi.Focus();
            }
            else
            {
                if (cmbOperasi.Text == "Penjumlahan")
                {
                    cal.Hasil = "Hasil Penjumlahan " + txtNilaiA.Text + " + " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) + int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Pengurangan")
                {
                    cal.Hasil = "Hasil Pengurangan " + txtNilaiA.Text + " - " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) - int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Perkalian")
                {
                    cal.Hasil = "Hasil Perkalian " + txtNilaiA.Text + " x " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) * int.Parse(txtNilaiB.Text));
                }
                else if (cmbOperasi.Text == "Pembagian")
                {
                    cal.Hasil = "Hasil Pembagian " + txtNilaiA.Text + " : " + txtNilaiB.Text + " = " + (int.Parse(txtNilaiA.Text) / int.Parse(txtNilaiB.Text));
                }
                if (isNewData) // data baru
                {
                    OnCreate(cal);
                }
                else // update
                {
                    OnUpdate(cal); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void cmbOperasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNilaiA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNilaiB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
