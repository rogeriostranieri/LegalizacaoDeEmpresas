Public Class FrmBuscaAnotacoes

    Private Sub FrmBuscaAnotacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim index As Integer = 0
        'Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find((TextBoxLocalizar.Text, RichTextBoxFinds.Reverse)
        Dim lastIndex As Integer = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizar.Text, 0, RichTextBoxFinds.Reverse)
        While index < lastIndex
            index = FrmAnotacoes.RichTextBoxAnotacao.Find(TextBoxLocalizar.Text, index, RichTextBoxFinds.None)
            FrmAnotacoes.RichTextBoxAnotacao.SelectionBackColor = Color.Yellow
            FrmAnotacoes.RichTextBoxAnotacao.SelectionColor = Color.Red
            index += 1
        End While
    End Sub
End Class