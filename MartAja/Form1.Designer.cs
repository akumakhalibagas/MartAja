
namespace MartAja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.et_cari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btTambah = new System.Windows.Forms.Button();
            this.btBatal = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tbbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appData = new MartAja.AppData();
            this.button5 = new System.Windows.Forms.Button();
            this.et_name = new System.Windows.Forms.TextBox();
            this.et_harga = new System.Windows.Forms.TextBox();
            this.et_jmlh = new System.Windows.Forms.TextBox();
            this.et_decs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMABARANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jUMLAHBARANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hARGABARANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gAMBARBARANGDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.dESKRIPSIBARANGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_barangTableAdapter = new MartAja.AppDataTableAdapters.tb_barangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // et_cari
            // 
            this.et_cari.Location = new System.Drawing.Point(67, 155);
            this.et_cari.Name = "et_cari";
            this.et_cari.Size = new System.Drawing.Size(631, 20);
            this.et_cari.TabIndex = 5;
            this.et_cari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.et_cari_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pencarian";
            // 
            // btTambah
            // 
            this.btTambah.Location = new System.Drawing.Point(652, 429);
            this.btTambah.Name = "btTambah";
            this.btTambah.Size = new System.Drawing.Size(64, 20);
            this.btTambah.TabIndex = 3;
            this.btTambah.Text = "Tambah";
            this.btTambah.UseVisualStyleBackColor = true;
            this.btTambah.Click += new System.EventHandler(this.btTambah_Click);
            // 
            // btBatal
            // 
            this.btBatal.Location = new System.Drawing.Point(582, 429);
            this.btBatal.Name = "btBatal";
            this.btBatal.Size = new System.Drawing.Size(64, 20);
            this.btBatal.TabIndex = 2;
            this.btBatal.Text = "Batal";
            this.btBatal.UseVisualStyleBackColor = true;
            this.btBatal.Click += new System.EventHandler(this.btBatal_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(512, 429);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(64, 20);
            this.btEdit.TabIndex = 1;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(442, 429);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(64, 20);
            this.btNew.TabIndex = 0;
            this.btNew.Text = "Baru";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tbbarangBindingSource, "GAMBAR_BARANG", true));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(86, 94);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tbbarangBindingSource
            // 
            this.tbbarangBindingSource.DataMember = "tb_barang";
            this.tbbarangBindingSource.DataSource = this.appData;
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 20);
            this.button5.TabIndex = 8;
            this.button5.Text = "Foto";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // et_name
            // 
            this.et_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbarangBindingSource, "NAMA_BARANG", true));
            this.et_name.Location = new System.Drawing.Point(187, 3);
            this.et_name.Name = "et_name";
            this.et_name.Size = new System.Drawing.Size(500, 20);
            this.et_name.TabIndex = 4;
            // 
            // et_harga
            // 
            this.et_harga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbarangBindingSource, "HARGA_BARANG", true));
            this.et_harga.Location = new System.Drawing.Point(187, 29);
            this.et_harga.Name = "et_harga";
            this.et_harga.Size = new System.Drawing.Size(500, 20);
            this.et_harga.TabIndex = 5;
            // 
            // et_jmlh
            // 
            this.et_jmlh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbarangBindingSource, "JUMLAH_BARANG", true));
            this.et_jmlh.Location = new System.Drawing.Point(187, 54);
            this.et_jmlh.Multiline = true;
            this.et_jmlh.Name = "et_jmlh";
            this.et_jmlh.Size = new System.Drawing.Size(500, 20);
            this.et_jmlh.TabIndex = 6;
            // 
            // et_decs
            // 
            this.et_decs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbbarangBindingSource, "DESKRIPSI_BARANG", true));
            this.et_decs.Location = new System.Drawing.Point(187, 79);
            this.et_decs.Multiline = true;
            this.et_decs.Name = "et_decs";
            this.et_decs.Size = new System.Drawing.Size(500, 45);
            this.et_decs.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Barang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jumlah Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Harga Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deskripsi Barang";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.et_decs);
            this.panel.Controls.Add(this.et_jmlh);
            this.panel.Controls.Add(this.et_harga);
            this.panel.Controls.Add(this.et_name);
            this.panel.Controls.Add(this.button5);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Enabled = false;
            this.panel.Location = new System.Drawing.Point(11, 11);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(705, 138);
            this.panel.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMABARANGDataGridViewTextBoxColumn,
            this.jUMLAHBARANGDataGridViewTextBoxColumn,
            this.hARGABARANGDataGridViewTextBoxColumn,
            this.gAMBARBARANGDataGridViewImageColumn,
            this.dESKRIPSIBARANGDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.tbbarangBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(11, 186);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(705, 226);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nAMABARANGDataGridViewTextBoxColumn
            // 
            this.nAMABARANGDataGridViewTextBoxColumn.DataPropertyName = "NAMA_BARANG";
            this.nAMABARANGDataGridViewTextBoxColumn.HeaderText = "NAMA_BARANG";
            this.nAMABARANGDataGridViewTextBoxColumn.Name = "nAMABARANGDataGridViewTextBoxColumn";
            this.nAMABARANGDataGridViewTextBoxColumn.Width = 150;
            // 
            // jUMLAHBARANGDataGridViewTextBoxColumn
            // 
            this.jUMLAHBARANGDataGridViewTextBoxColumn.DataPropertyName = "JUMLAH_BARANG";
            this.jUMLAHBARANGDataGridViewTextBoxColumn.HeaderText = "JUMLAH_BARANG";
            this.jUMLAHBARANGDataGridViewTextBoxColumn.Name = "jUMLAHBARANGDataGridViewTextBoxColumn";
            this.jUMLAHBARANGDataGridViewTextBoxColumn.Width = 150;
            // 
            // hARGABARANGDataGridViewTextBoxColumn
            // 
            this.hARGABARANGDataGridViewTextBoxColumn.DataPropertyName = "HARGA_BARANG";
            this.hARGABARANGDataGridViewTextBoxColumn.HeaderText = "HARGA_BARANG";
            this.hARGABARANGDataGridViewTextBoxColumn.Name = "hARGABARANGDataGridViewTextBoxColumn";
            this.hARGABARANGDataGridViewTextBoxColumn.Width = 150;
            // 
            // gAMBARBARANGDataGridViewImageColumn
            // 
            this.gAMBARBARANGDataGridViewImageColumn.DataPropertyName = "GAMBAR_BARANG";
            this.gAMBARBARANGDataGridViewImageColumn.HeaderText = "GAMBAR_BARANG";
            this.gAMBARBARANGDataGridViewImageColumn.Name = "gAMBARBARANGDataGridViewImageColumn";
            this.gAMBARBARANGDataGridViewImageColumn.Width = 200;
            // 
            // dESKRIPSIBARANGDataGridViewTextBoxColumn
            // 
            this.dESKRIPSIBARANGDataGridViewTextBoxColumn.DataPropertyName = "DESKRIPSI_BARANG";
            this.dESKRIPSIBARANGDataGridViewTextBoxColumn.HeaderText = "DESKRIPSI_BARANG";
            this.dESKRIPSIBARANGDataGridViewTextBoxColumn.Name = "dESKRIPSIBARANGDataGridViewTextBoxColumn";
            this.dESKRIPSIBARANGDataGridViewTextBoxColumn.Width = 175;
            // 
            // tb_barangTableAdapter
            // 
            this.tb_barangTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 461);
            this.Controls.Add(this.et_cari);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btTambah);
            this.Controls.Add(this.btBatal);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox et_cari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btTambah;
        private System.Windows.Forms.Button btBatal;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox et_name;
        private System.Windows.Forms.TextBox et_harga;
        private System.Windows.Forms.TextBox et_jmlh;
        private System.Windows.Forms.TextBox et_decs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.DataGridView dataGridView;
        private AppData appData;
        private System.Windows.Forms.BindingSource tbbarangBindingSource;
        private AppDataTableAdapters.tb_barangTableAdapter tb_barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMABARANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jUMLAHBARANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hARGABARANGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn gAMBARBARANGDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESKRIPSIBARANGDataGridViewTextBoxColumn;
    }
}

