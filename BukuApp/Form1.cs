using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BukuApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler untuk Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=buku_db;password=;";

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open(); // Mencoba membuka koneksi

                // Jika koneksi berhasil
                MessageBox.Show("Koneksi Berhasil ke Database!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mengisi DataGridView dengan data buku dari database
                LoadData();
            }
            catch (Exception ex)
            {
                // Jika koneksi gagal
                MessageBox.Show("Koneksi ke database gagal: " + ex.Message, "Koneksi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Menutup koneksi
            }
        }

        // Fungsi untuk mengisi DataGridView dengan data buku
        private void LoadData()
        {
            string connectionString = "server=localhost;user=root;database=buku_db;password=;";

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                // Query untuk mengambil data buku
                string query = "SELECT * FROM data_buku";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, conn);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                dataAdapter.Fill(dataTable);

                // Menampilkan data di DataGridView
                dataGridViewBuku.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Event handler untuk tombol Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=buku_db;password=;";

            // Ambil data dari TextBox
            string id = txtID.Text;
            string judul = txtJudul.Text;
            string penerbit = txtPenerbit.Text;
            string pengarang = txtPengarang.Text;
            string tahunTerbit = txtTahunTerbit.Text;

            // Koneksi ke database
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                // Query untuk menyimpan data buku ke database
                string query = "INSERT INTO data_buku (id, judul, penerbit, pengarang, tahun_terbit) VALUES (@id, @judul, @penerbit, @pengarang, @tahunTerbit)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@judul", judul);
                cmd.Parameters.AddWithValue("@penerbit", penerbit);
                cmd.Parameters.AddWithValue("@pengarang", pengarang);
                cmd.Parameters.AddWithValue("@tahunTerbit", tahunTerbit);

                cmd.ExecuteNonQuery();

                // Menampilkan pesan sukses
                MessageBox.Show("Data Buku berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields setelah simpan
                txtID.Clear();
                txtJudul.Clear();
                txtPenerbit.Clear();
                txtPengarang.Clear();
                txtTahunTerbit.Clear();

                // Mengupdate DataGridView dengan data terbaru
                LoadData();
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika gagal
                MessageBox.Show("Gagal menyimpan data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Event handler untuk tombol Edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=buku_db;password=;";

            // Ambil data dari TextBox
            string id = txtID.Text;
            string judul = txtJudul.Text;
            string penerbit = txtPenerbit.Text;
            string pengarang = txtPengarang.Text;
            string tahunTerbit = txtTahunTerbit.Text;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                // Query untuk mengupdate data buku di database
                string query = "UPDATE data_buku SET judul=@judul, penerbit=@penerbit, pengarang=@pengarang, tahun_terbit=@tahunTerbit WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@judul", judul);
                cmd.Parameters.AddWithValue("@penerbit", penerbit);
                cmd.Parameters.AddWithValue("@pengarang", pengarang);
                cmd.Parameters.AddWithValue("@tahunTerbit", tahunTerbit);

                cmd.ExecuteNonQuery();

                // Menampilkan pesan sukses
                MessageBox.Show("Data Buku berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields setelah update
                txtID.Clear();
                txtJudul.Clear();
                txtPenerbit.Clear();
                txtPengarang.Clear();
                txtTahunTerbit.Clear();

                // Mengupdate DataGridView dengan data terbaru
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengupdate data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Event handler untuk tombol Hapus
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=buku_db;password=;";

            string id = txtID.Text;

            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                // Query untuk menghapus data buku dari database
                string query = "DELETE FROM data_buku WHERE id=@id";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                // Menampilkan pesan sukses
                MessageBox.Show("Data Buku berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields setelah hapus
                txtID.Clear();
                txtJudul.Clear();
                txtPenerbit.Clear();
                txtPengarang.Clear();
                txtTahunTerbit.Clear();

                // Mengupdate DataGridView dengan data terbaru
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal menghapus data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Event handler untuk memilih data dari DataGridView
        private void dataGridViewBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Ambil data dari sel yang diklik dan masukkan ke TextBox
                DataGridViewRow row = dataGridViewBuku.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtJudul.Text = row.Cells[1].Value.ToString();
                txtPenerbit.Text = row.Cells[2].Value.ToString();
                txtPengarang.Text = row.Cells[3].Value.ToString();
                txtTahunTerbit.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
