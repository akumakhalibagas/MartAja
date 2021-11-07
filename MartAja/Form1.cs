using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MartAja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.tb_barang' table. You can move, or remove it, as needed.
            this.tb_barangTableAdapter.Fill(this.appData.tb_barang);
            tbbarangBindingSource.DataSource = this.appData.tb_barang;
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Apakah kamu akan menghapus item ini?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    tbbarangBindingSource.RemoveCurrent();
            }
        }

        private void et_cari_KeyPress(object sender, KeyPressEventArgs e)
        {
	     if(e.KeyChar == (char)13)
            {
                if (String.IsNullOrEmpty(tbSearch.Text))
                {
                    dataBarang.DataSource = tableBarangBindingSource;
                }
                else
                {
                    var query = from o in this.databaseBarangDataSet.TableBarang
                                where o.Nama_Barang.Contains(tbSearch.Text) || o.Harga_Barang == tbSearch.Text || o.Jumlah_Barang == tbSearch.Text || o.ID_Barang.Contains(tbSearch.Text)
                                select o;
                    dataBarang.DataSource = query.ToList();

                }
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                et_name.Focus();
                this.appData.tb_barang.Addtb_barangRow(this.appData.tb_barang.Newtb_barangRow());
                tbbarangBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbbarangBindingSource.ResetBindings(false);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            et_name.Focus();
        }

        private void btBatal_Click(object sender, EventArgs e)
        {
            panel.Enabled = false;
            tbbarangBindingSource.ResetBindings(false);
        }

        private void btTambah_Click(object sender, EventArgs e)
        {
            try
            {
                tbbarangBindingSource.EndEdit();
                tb_barangTableAdapter.Update(this.appData.tb_barang);
                panel.Enabled = false;

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbbarangBindingSource.ResetBindings(false);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBox.Image = Image.FromFile(ofd.FileName);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbbarangBindingSource.ResetBindings(false);
            }
        }
    }
}
