# Aplikasi Buku

Aplikasi ini adalah program Windows Forms sederhana yang dibuat menggunakan Visual C#. Aplikasi ini memungkinkan pengguna untuk melakukan operasi CRUD (Create, Read, Update, Delete) pada data buku.

## Fitur

- **Tambah Buku**: Memasukkan data buku baru ke dalam daftar.
- **Edit Buku**: Mengubah informasi buku yang sudah ada.
- **Hapus Buku**: Menghapus buku dari daftar.
- **Tampilkan Data**: Menampilkan daftar buku dalam tabel.

## Tampilan

Form utama terdiri dari:
- Input field: `ID`, `Judul`, `Penerbit`, `Pengarang`, `Tahun Terbit`
- Tombol aksi: `Simpan`, `Edit`, `Hapus`
- DataGridView untuk menampilkan data buku

## Desain Figma

Desain UI untuk aplikasi ini dapat dilihat melalui link berikut:

🔗 [Lihat di Figma](https://www.figma.com/design/6AyXVSx3oRNo8fkmoHivvT/Untitled?node-id=0-1&t=MoUBatyXg2evBbz8-1)

## Cara Menjalankan

1. Buka project di Visual Studio.
2. Jalankan program dengan menekan `Start` atau `F5`.

## Struktur Field

| Field       | Keterangan                 |
|-------------|----------------------------|
| ID          | ID unik untuk buku         |
| Judul       | Judul buku                 |
| Penerbit    | Nama penerbit buku         |
| Pengarang   | Nama pengarang buku        |
| Tahun Terbit| Tahun terbit buku          |

## Catatan

- Data saat ini disimpan secara lokal dalam DataGridView dan belum terhubung ke database.
- Pastikan validasi data dilakukan agar input tidak kosong sebelum disimpan atau diedit.

## Lisensi

Proyek ini bersifat open source dan bebas digunakan untuk pembelajaran.
