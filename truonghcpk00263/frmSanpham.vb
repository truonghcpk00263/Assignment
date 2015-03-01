Public Class frmSanpham
    Dim dataclass As New layer_data()
    Private Sub frmSanpham_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadulieu()
    End Sub
    Private Sub loadulieu()
        dataclass.moketnoi()
        dataclass.laydulieu("select * from SanPham")
        dataclass.dongketnoi()
        Dim data As New DataTable
        data = dataclass.datatable
        DataGridView1.DataSource = data
    End Sub

    Private Sub btnxoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxoa.Click
        dataclass.thucthi("delete from SanPham where MaSanPham = '" + txtmasanpham.Text + "'")
        Dim xoa As String
        xoa = dataclass.status
        If xoa = "ok" Then
            MessageBox.Show("Đã xóa thành công")
            loadulieu()
        Else
            MessageBox.Show("Xóa không thành công")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim vitri As Integer = DataGridView1.CurrentCell.RowIndex
        txtmasanpham.Text = DataGridView1.Rows(vitri).Cells(0).Value.ToString
        txttensanpham.Text = DataGridView1.Rows(vitri).Cells(1).Value.ToString
        txtmota.Text = DataGridView1.Rows(vitri).Cells(4).Value.ToString
        txtloaisanpham.Text = DataGridView1.Rows(vitri).Cells(2).Value.ToString
        txtgia.Text = DataGridView1.Rows(vitri).Cells(3).Value.ToString
    End Sub

    Private Sub btnsua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsua.Click
        dataclass.thucthi("update SanPham set TenSanPham = N'" + txttensanpham.Text + "',LoaiSanPham = '" + txtloaisanpham.Text + "',Gia = '" + txtgia.Text + "',MoTa = N'" + txtmota.Text + "' where MaSanPham = '" + txtmasanpham.Text + "'")
        Dim xoa As String = ""
        xoa = dataclass.status
        If xoa = "ok" Then
            MessageBox.Show("Đã sửa thành công")
            loadulieu()
        Else
            MessageBox.Show("Sửa không thành công")
        End If
    End Sub

    Private Sub btnthem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthem.Click
        dataclass.thucthi("insert into SanPham (TenSanPham,LoaiSanPham,Gia,MoTa) values (N'" + txttensanpham.Text + "', '" + txtloaisanpham.Text + "', '" + txtgia.Text + "', N'" + txtmota.Text + "')")
        Dim xoa As String = ""
        xoa = dataclass.status
        If xoa = "ok" Then
            MessageBox.Show("Đã thêm thành công")
            loadulieu()
        Else
            MessageBox.Show("Thêm không thành công")
        End If
    End Sub
End Class