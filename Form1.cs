using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetaMart5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.appData.Employees);
            employeesBindingSource.DataSource = this.appData.Employees;
        }

        private void txt_Cari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {                
                if (string.IsNullOrEmpty(txt_Cari.Text))
                {
                    this.employeesTableAdapter.Fill(this.appData.Employees);
                    employeesBindingSource.DataSource = this.appData.Employees;
                    //dataGridView.DataSource = employeesBindingSource;
                }
                else
                {
                    var query = from o in this.appData.Employees
                                where o.NamaProduk.Contains(txt_Cari.Text) || o.StokProduk == txt_Cari.Text || o.HargaProduk == txt_Cari.Text || o.Keterangan.Contains(txt_Cari.Text)
                                select o;
                    employeesBindingSource.DataSource = query.ToList();
                    //dataGridView.DataSource = query.ToList();
                }
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Apakah anda yakin ingin menghapus ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    employeesBindingSource.RemoveCurrent();
            }
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_New_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txt_NamaProduk.Focus();
                this.appData.Employees.AddEmployeesRow(this.appData.Employees.NewEmployeesRow());
                employeesBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeesBindingSource.ResetBindings(false);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txt_NamaProduk.Focus();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            employeesBindingSource.ResetBindings(false);
        }

        private void btn_Simpan_Click(object sender, EventArgs e)
        {
            try
            {
                employeesBindingSource.EndEdit();
                employeesTableAdapter.Update(this.appData.Employees);
                panel.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                employeesBindingSource.ResetBindings(false);
            }
        }
    }
}
