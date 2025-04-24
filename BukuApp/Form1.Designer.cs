namespace BukuApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblJudul = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.lblPenerbit = new System.Windows.Forms.Label();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.lblPengarang = new System.Windows.Forms.Label();
            this.txtPengarang = new System.Windows.Forms.TextBox();
            this.lblTahunTerbit = new System.Windows.Forms.Label();
            this.txtTahunTerbit = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewBuku = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).BeginInit();
            this.SuspendLayout();

            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";

            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 20);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 1;

            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Location = new System.Drawing.Point(20, 60);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(39, 13);
            this.lblJudul.TabIndex = 2;
            this.lblJudul.Text = "Judul:";

            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(100, 60);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(200, 20);
            this.txtJudul.TabIndex = 3;

            // 
            // lblPenerbit
            // 
            this.lblPenerbit.AutoSize = true;
            this.lblPenerbit.Location = new System.Drawing.Point(20, 100);
            this.lblPenerbit.Name = "lblPenerbit";
            this.lblPenerbit.Size = new System.Drawing.Size(50, 13);
            this.lblPenerbit.TabIndex = 4;
            this.lblPenerbit.Text = "Penerbit:";

            // 
            // txtPenerbit
            // 
            this.txtPenerbit.Location = new System.Drawing.Point(100, 100);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Size = new System.Drawing.Size(200, 20);
            this.txtPenerbit.TabIndex = 5;

            // 
            // lblPengarang
            // 
            this.lblPengarang.AutoSize = true;
            this.lblPengarang.Location = new System.Drawing.Point(20, 140);
            this.lblPengarang.Name = "lblPengarang";
            this.lblPengarang.Size = new System.Drawing.Size(64, 13);
            this.lblPengarang.TabIndex = 6;
            this.lblPengarang.Text = "Pengarang:";

            // 
            // txtPengarang
            // 
            this.txtPengarang.Location = new System.Drawing.Point(100, 140);
            this.txtPengarang.Name = "txtPengarang";
            this.txtPengarang.Size = new System.Drawing.Size(200, 20);
            this.txtPengarang.TabIndex = 7;

            // 
            // lblTahunTerbit
            // 
            this.lblTahunTerbit.AutoSize = true;
            this.lblTahunTerbit.Location = new System.Drawing.Point(20, 180);
            this.lblTahunTerbit.Name = "lblTahunTerbit";
            this.lblTahunTerbit.Size = new System.Drawing.Size(74, 13);
            this.lblTahunTerbit.TabIndex = 8;
            this.lblTahunTerbit.Text = "Tahun Terbit:";

            // 
            // txtTahunTerbit
            // 
            this.txtTahunTerbit.Location = new System.Drawing.Point(100, 180);
            this.txtTahunTerbit.Name = "txtTahunTerbit";
            this.txtTahunTerbit.Size = new System.Drawing.Size(200, 20);
            this.txtTahunTerbit.TabIndex = 9;

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(120, 220);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(220, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // dataGridViewBuku
            // 
            this.dataGridViewBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuku.Location = new System.Drawing.Point(20, 260);
            this.dataGridViewBuku.Name = "dataGridViewBuku";
            this.dataGridViewBuku.Size = new System.Drawing.Size(500, 150);
            this.dataGridViewBuku.TabIndex = 13;
            this.dataGridViewBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuku_CellClick);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.dataGridViewBuku);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTahunTerbit);
            this.Controls.Add(this.lblTahunTerbit);
            this.Controls.Add(this.txtPengarang);
            this.Controls.Add(this.lblPengarang);
            this.Controls.Add(this.txtPenerbit);
            this.Controls.Add(this.lblPenerbit);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "Form1";
            this.Text = "CRUD Buku";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label lblPenerbit;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.Label lblPengarang;
        private System.Windows.Forms.TextBox txtPengarang;
        private System.Windows.Forms.Label lblTahunTerbit;
        private System.Windows.Forms.TextBox txtTahunTerbit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewBuku;
    }
}
