Public Class frmQLbanhang
    Dim dataclass As New layer_data()

    Private Sub SảnPhẩmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SảnPhẩmToolStripMenuItem.Click
        frmSanpham.Show()
    End Sub

    Private Sub KháchHàngToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub HóaĐơnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HóaĐơnToolStripMenuItem.Click
        frmHoadon.Show()
    End Sub

    Private Sub ThoátToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ThoátToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ChiTiếtHóaĐơnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChiTiếtHóaĐơnToolStripMenuItem.Click
        frmChitiethoadon.Show()

    End Sub

    Private Sub frmQLbanhang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
