Public Class Form1
    Public hrgMakanan, hrgMinuman As Integer
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblJmlhMakanan.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbLMinuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLMinuman.SelectedIndexChanged
        Select Case cmbLMinuman.Text
            Case "Es Jeruk"
                labelMinuman.Text = "Rp3000"
                hrgMinuman = 3000
            Case "Jus Alpukat"
                labelMinuman.Text = "Rp7000"
                hrgMinuman = 7000
            Case "Es Teh Manis"
                labelMinuman.Text = "Rp4000"
                hrgMinuman = 4000
        End Select
    End Sub

    Private Sub cbxID_CheckedChanged(sender As Object, e As EventArgs) Handles cbxID.CheckedChanged
        If cbxID.Checked = True Then
            cmbLMinuman.Visible = True
            lblJmlhMinuman.Visible = True
            labelMinuman.Visible = True
            lblPMnm.Visible = True
            txtTotalMnm.Visible = True
        ElseIf cbxID.Checked = False Then
            cmbLMinuman.Visible = False
            lblJmlhMinuman.Visible = False
            labelMinuman.Visible = False
            lblPMnm.Visible = False
            txtTotalMnm.Visible = False

            labelMinuman.Text = "Rp0"
            txtTotalMnm.Text = ""
        End If
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        lblTotal.Text = "Rp" & hrgMakanan * Val(txtTotalMkn.Text) + hrgMinuman * Val(txtTotalMnm.Text)
    End Sub

    Private Sub cmbLMakanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbLMakanan.SelectedIndexChanged
        Select Case cmbLMakanan.Text
            Case "Nasi Uduk"
                labelMakanan.Text = "Rp3500"
                hrgMakanan = 3500
            Case "Bakso"
                labelMakanan.Text = "Rp6000"
                hrgMakanan = 6000
            Case "Mie Ayam"
                labelMakanan.Text = "Rp7000"
                hrgMakanan = 7000
        End Select
    End Sub
End Class
