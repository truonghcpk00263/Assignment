Public Class frmHoadon
    Dim dataclass As New layer_data()


    Private Sub frmHoadon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddulieu()
    End Sub
    Private Sub loaddulieu()
        dataclass.moketnoi()
        dataclass.laydulieu("select * from HoaDon")
        dataclass.dongketnoi()
        Dim data As New DataTable
        data = dataclass.datatable
        DataGridView1.DataSource = data
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        dataclass.thucthi("insert into HoaDon (KhachHang,NgayXuat,NhanVien,GhiChu) values ('" + txtkhachhang.Text + "','" + DateTimePicker1.Text + "','" + txtnhanvien.Text + "',N'" + txtghichu.Text + "')  ")
        If dataclass.status = "ok" Then
            MessageBox.Show("Đã thêm thành công")
            loaddulieu()
        Else
            MessageBox.Show("Thêm không thành công")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim vitri As Integer = DataGridView1.CurrentCell.RowIndex
        txtmahoadon.Text = DataGridView1.Rows(vitri).Cells(0).Value.ToString
        txtkhachhang.Text = DataGridView1.Rows(vitri).Cells(1).Value.ToString
        txtghichu.Text = DataGridView1.Rows(vitri).Cells(4).Value.ToString
        ' DateTimePicker1.Text = Convert.ToDateTime(DataGridView1.Rows(vitri).Cells(3).Value)
        txtnhanvien.Text = DataGridView1.Rows(vitri).Cells(3).Value.ToString
    End Sub

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        dataclass.thucthi("delete from HoaDon where MaHoaDon = '" + txtmahoadon.Text + "'")
        Dim xoa As String
        xoa = dataclass.status
        If xoa = "ok" Then
            MessageBox.Show("Đã xóa thành công")
            loaddulieu()
        Else
            MessageBox.Show("Xóa không thành công")
        End If
    End Sub

    Private Sub btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua.Click
        dataclass.thucthi("update HoaDon set KhachHang='" + txtkhachhang.Text + "',NgayXuat= '" + DateTimePicker1.Text + "',NhanVien='" + txtnhanvien.Text + "',GhiChu= '" + txtghichu.Text + "'where MaHoaDon = '" + txtmahoadon.Text + "'")
        Dim sua As String
        sua = dataclass.status
        If sua = "ok" Then
            MessageBox.Show("Đã sửa thành công")
            loaddulieu()
        Else
            MessageBox.Show("Sửa không thành công")
        End If
    End Sub
End Class