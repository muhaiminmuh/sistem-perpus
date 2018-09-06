Imports System.Data.Odbc

Public Class Form3
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=dataperpus"
        con.Open()
    End Sub

    Sub simpan()
        koneksi()
        Dim sql As String = "insert into tabel_peminjaman values('" & tkode_peminjaman.Text & "','" & cb1.Text & "','" & cb2.Text & "','" & date1.Text & "','" & date2.Text & "','" & tlama.Text & "','" & tbiaya.Text & "','" & ttotal.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from tabel_peminjaman order by kode_peminjaman asc",
            con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Sub tampilpeminjam()
        cmd = New OdbcCommand("select id_peminjam from data_peminjam", con)
        dr = cmd.ExecuteReader
        cb1.Items.Clear()
        Do While dr.Read
            cb1.Items.Add(dr.Item("id_peminjam"))
        Loop
    End Sub

    Sub tampilbuku()
        cmd = New OdbcCommand("select kode from tabel_buku", con)
        dr = cmd.ExecuteReader
        cb2.Items.Clear()
        Do While dr.Read
            cb2.Items.Add(dr.Item("kode"))
        Loop
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tampil()
        tampilpeminjam()
        tampilbuku()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cb1.Text = "-pilih-"
        tnama_peminjam.Text = ""
        talamat.Text = ""
        cb2.Text = "-pilih"
        tjudul.Text = ""
        tpengarang.Text = ""
        tpenerbit.Text = ""
        ttahun.Text = ""
        tkode_peminjaman.Text = ""
        date1.Text = ""
        date2.Text = ""
        tlama.Text = "0"
        tbiaya.Text = "0"
        ttotal.Text = "0"
        cb1.Focus()

    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        simpan()
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        tampil()
    End Sub
    Private Sub tbiaya_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbiaya.TextChanged
        Dim lama As Integer
        Dim biaya_adm As Integer
        Dim total_biaya As Single
        lama = CInt(tlama.Text)
        biaya_adm = CInt(tbiaya.Text)
        total_biaya = CSng((lama * biaya_adm))
        ttotal.Text = total_biaya
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Peminjam yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan kode_peminjaman=" & a &
            "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) =
            Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from tabel_peminjaman where kode_peminjaman='" & a &
                "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub cb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.SelectedIndexChanged
        cmd = New OdbcCommand("select *from data_peminjam where id_peminjam='" & cb1.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tnama_peminjam.Text = dr.Item("nama_peminjam")
            talamat.Text = dr.Item("alamat")
        Else
            MsgBox("Nama Peminjam tidak ada")
        End If
    End Sub

    Private Sub cb2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb2.SelectedIndexChanged
        cmd = New OdbcCommand("select *from tabel_buku where kode='" & cb2.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tjudul.Text = dr.Item("judul")
            tpengarang.Text = dr.Item("pengarang")
            tpenerbit.Text = dr.Item("penerbit")
            ttahun.Text = dr.Item("tahun")
        Else
            MsgBox("Kode Buku tidak ada")
        End If
    End Sub

    Private Sub Form3_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        tampilpeminjam()
        tampilbuku()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form6.Show()
    End Sub
End Class
