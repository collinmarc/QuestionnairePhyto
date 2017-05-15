Public Class frmProtect

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim oProtect As New Protection()

        tbResult.Text = oProtect.encode(DateTimePicker1.Text)
    End Sub

    Private Sub frmProtect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String = My.Settings.check
        Dim oProtect As New Protection
        oProtect.decode(str)
        DateTimePicker1.Text = oProtect.decode(str)


    End Sub
End Class