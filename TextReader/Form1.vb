Imports System.IO
Public Class Form1

    Private Sub Abrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Abrir.Click
        Dim sr As StreamReader
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                sr = New StreamReader(OpenFileDialog1.FileName)
                lblNomeArquivo.Text += " " + OpenFileDialog1.FileName
                txtOutput.Text = sr.ReadToEnd()
            Catch ex As Exception
                txtOutput.Text = ex.Message
            Finally
                sr.Dispose()
            End Try
        End If
    End Sub
End Class
