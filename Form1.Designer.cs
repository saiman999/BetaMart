
namespace BetaMart5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txt_NamaProduk = new System.Windows.Forms.TextBox();
            this.txt_StokProduk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HargaProduk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Keterangan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Simpan = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.appData = new BetaMart5.AppData();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new BetaMart5.AppDataTableAdapters.EmployeesTableAdapter();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaProdukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gambarDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(21, 116);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(75, 23);
            this.btn_Browse.TabIndex = 0;
            this.btn_Browse.Text = "Cari Gambar";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Produk:";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.namaProdukDataGridViewTextBoxColumn,
            this.stokProdukDataGridViewTextBoxColumn,
            this.hargaProdukDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn,
            this.gambarDataGridViewImageColumn});
            this.dataGridView.DataSource = this.employeesBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 237);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(537, 162);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txt_Keterangan);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.txt_HargaProduk);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.txt_StokProduk);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txt_NamaProduk);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.btn_Browse);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(537, 178);
            this.panel.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.employeesBindingSource, "Gambar", true));
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(110, 107);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txt_NamaProduk
            // 
            this.txt_NamaProduk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "NamaProduk", true));
            this.txt_NamaProduk.Location = new System.Drawing.Point(203, 11);
            this.txt_NamaProduk.Name = "txt_NamaProduk";
            this.txt_NamaProduk.Size = new System.Drawing.Size(229, 20);
            this.txt_NamaProduk.TabIndex = 0;
            // 
            // txt_StokProduk
            // 
            this.txt_StokProduk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "StokProduk", true));
            this.txt_StokProduk.Location = new System.Drawing.Point(203, 37);
            this.txt_StokProduk.Name = "txt_StokProduk";
            this.txt_StokProduk.Size = new System.Drawing.Size(229, 20);
            this.txt_StokProduk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Produk:";
            // 
            // txt_HargaProduk
            // 
            this.txt_HargaProduk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "HargaProduk", true));
            this.txt_HargaProduk.Location = new System.Drawing.Point(203, 63);
            this.txt_HargaProduk.Name = "txt_HargaProduk";
            this.txt_HargaProduk.Size = new System.Drawing.Size(229, 20);
            this.txt_HargaProduk.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Produk:";
            // 
            // txt_Keterangan
            // 
            this.txt_Keterangan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Keterangan", true));
            this.txt_Keterangan.Location = new System.Drawing.Point(203, 89);
            this.txt_Keterangan.Multiline = true;
            this.txt_Keterangan.Name = "txt_Keterangan";
            this.txt_Keterangan.Size = new System.Drawing.Size(331, 86);
            this.txt_Keterangan.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Keterangan:";
            // 
            // txt_Cari
            // 
            this.txt_Cari.Location = new System.Drawing.Point(50, 207);
            this.txt_Cari.Name = "txt_Cari";
            this.txt_Cari.Size = new System.Drawing.Size(499, 20);
            this.txt_Cari.TabIndex = 1;
            this.txt_Cari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Cari_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cari:";
            // 
            // btn_Simpan
            // 
            this.btn_Simpan.Location = new System.Drawing.Point(471, 405);
            this.btn_Simpan.Name = "btn_Simpan";
            this.btn_Simpan.Size = new System.Drawing.Size(75, 23);
            this.btn_Simpan.TabIndex = 5;
            this.btn_Simpan.Text = "Simpan";
            this.btn_Simpan.UseVisualStyleBackColor = true;
            this.btn_Simpan.Click += new System.EventHandler(this.btn_Simpan_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(390, 405);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(309, 405);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Ubah";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_New
            // 
            this.btn_New.Location = new System.Drawing.Point(228, 405);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(75, 23);
            this.btn_New.TabIndex = 2;
            this.btn_New.Text = "Baru";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // appData
            // 
            this.appData.DataSetName = "AppData";
            this.appData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.appData;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            // 
            // namaProdukDataGridViewTextBoxColumn
            // 
            this.namaProdukDataGridViewTextBoxColumn.DataPropertyName = "NamaProduk";
            this.namaProdukDataGridViewTextBoxColumn.HeaderText = "NamaProduk";
            this.namaProdukDataGridViewTextBoxColumn.Name = "namaProdukDataGridViewTextBoxColumn";
            this.namaProdukDataGridViewTextBoxColumn.Width = 120;
            // 
            // stokProdukDataGridViewTextBoxColumn
            // 
            this.stokProdukDataGridViewTextBoxColumn.DataPropertyName = "StokProduk";
            this.stokProdukDataGridViewTextBoxColumn.HeaderText = "StokProduk";
            this.stokProdukDataGridViewTextBoxColumn.Name = "stokProdukDataGridViewTextBoxColumn";
            // 
            // hargaProdukDataGridViewTextBoxColumn
            // 
            this.hargaProdukDataGridViewTextBoxColumn.DataPropertyName = "HargaProduk";
            this.hargaProdukDataGridViewTextBoxColumn.HeaderText = "HargaProduk";
            this.hargaProdukDataGridViewTextBoxColumn.Name = "hargaProdukDataGridViewTextBoxColumn";
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.Width = 200;
            // 
            // gambarDataGridViewImageColumn
            // 
            this.gambarDataGridViewImageColumn.DataPropertyName = "Gambar";
            this.gambarDataGridViewImageColumn.HeaderText = "Gambar";
            this.gambarDataGridViewImageColumn.Name = "gambarDataGridViewImageColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 440);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Simpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cari);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BetaMart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txt_Keterangan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HargaProduk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_StokProduk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NamaProduk;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txt_Cari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Simpan;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_New;
        private AppData appData;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private AppDataTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaProdukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn gambarDataGridViewImageColumn;
    }
}

