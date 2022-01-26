Public Class FrmBuscaEmpresas


	Private Ultimabusca As Integer = 0

	Private Sub FrmBuscaEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)

    End Sub

    Private Sub txtPesquisa_TextChanged(sender As Object, e As EventArgs) Handles txtPesquisa.TextChanged




    End Sub

    Private Sub MaskedCNPJ_TextChanged(sender As Object, e As EventArgs) Handles MaskedCNPJ.TextChanged

        Dim texto As String = Nothing
        Dim celula As DataGridViewCell
        Dim contagem As Integer

        'percorre cada linha do DataGridView
        For Each linha As DataGridViewRow In EmpresasDataGridView.Rows
            celula = linha.Cells(1) 'Índice 1 = coluna nome

            texto = celula.Value.ToString().ToLower()

            'se o texto informado estiver contido na célula então seleciona toda linha
            If texto.Contains(txtPesquisa.Text) Then
                'seleciona a linha
                EmpresasDataGridView.CurrentCell = celula
                Exit Sub
            End If
            contagem = contagem + 1
            If contagem = EmpresasDataGridView.RowCount - 1 Then
                Exit Sub
            End If
        Next
    End Sub
End Class