Public Class frmChitiethoadon
    Dim dataclass As New layer_data()

    Private Sub frmChitiethoadon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddulieu()
    End Sub
    Private Sub loaddulieu()
        dataclass.moketnoi()
        dataclass.laydulieu("select * from ChiTietHoaDon")
        dataclass.dongketnoi()
        Dim data As New DataTable
        data = dataclass.datatable
        DataGridView1.DataSource = data
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        dataclass.thucthi("insert into ChiTietHoaDon (HoaDon,SanPham,SoLuong,DonGia) values ('" + txthoadon.Text + "','" + txtsanpham.Text + "','" + txtsoluong.Text + "','" + txtdongia.Text + "')")
        If dataclass.status = "ok" Then
            MessageBox.Show("Đã thêm thành công")
            loaddulieu()
        Else
            MessageBox.Show("Thêm không thành công")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim vitri As Integer = DataGridView1.CurrentCell.RowIndex
        txtmachitiethoadon.Text = DataGridView1.Rows(vitri).Cells(0).Value.ToString
        txthoadon.Text = DataGridView1.Rows(vitri).Cells(1).Value.ToString
        txtsanpham.Text = DataGridView1.Rows(vitri).Cells(2).Value.ToString
        txtsoluong.Text = DataGridView1.Rows(vitri).Cells(3).Value.ToString
        txtdongia.Text = DataGridView1.Rows(vitri).Cells(4).Value.ToString
    End Sub

    
    Private Sub btnXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa.Click
        dataclass.thucthi("delete from ChiTietHoaDon where MaChiTietHD = '" & txtmachitiethoadon.Text & "'")
        Dim xoa As String
        xoa = dataclass.status
        If xoa = "ok" Then
            MessageBox.Show("Đã xóa thành công")
            loaddulieu()
        Else
            MessageBox.Show("Xóa không thành công")
        End If
    End Sub

    Private Sub btnSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSua.Click
        dataclass.thucthi("update ChiTietHoaDon set HoaDon='" & txthoadon.Text & "',SanPham='" & txtsanpham.Text & "',SoLuong='" & txtsoluong.Text & "',DonGia='" & txtdongia.Text & "'where MaChiTietHD= '" + txtmachitiethoadon.Text + "'")
        Dim sua As String
        sua = dataclass.status
        If sua = "ok" Then
            MessageBox.Show("Đã Sửa Thành công")
            loaddulieu()
        Else
            MessageBox.Show("Sửa không thành công")
        End If
    End Sub
End Class
