Public Class VbAvisoPrincipal
    Private Sub VbAvisoPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

        Me.Refresh()
        'LaudosBindingSource.Filter = "BombeiroDataProvisorio <> '0' OR ViabilidadeDataProvisorio <> '0' OR AmbientalDataProvisorio <> '0' OR SanitarioDataProvisorio <> '0' OR SetranDataProvisorio <> '0' "
        MaskedTextBox2.Text = Now
        Button2.PerformClick()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' PESQUISA COM FILTRO POR DATA AVISO
        'FILTRO LAUDO
        Dim FilterA As String
        FilterA = MaskedTextBox2.Text
        LaudosBindingSource.Filter = "BombeiroDataProvisorio = '" & FilterA & "' OR ViabilidadeDataProvisorio = '" & FilterA & "' OR AmbientalDataProvisorio = '" & FilterA & "' OR SanitarioDataProvisorio = '" & FilterA & "' OR SetranDataProvisorio = '" & FilterA & "' "

    End Sub

    Private Sub LaudosDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView1.CellContentDoubleClick
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            FrmAlvara.Focus()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView1.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        Else
            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView1.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        End If
    End Sub
End Class
