Imports System.Timers

Public Class Avisos


    Private Sub Avisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
        Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)


        'Data de Hoje convertendo   
        MaskedTextBox1.Text = Now.ToString("dd/MM/yyyy")

        '--------------------------------------

        ' Dim TestDateTime As Date = Label2.Text
        '  Dim TestStr As String
        '  TestStr = Format(TestDateTime, "dd/MM/yyyy")

        ' MaskedTextBox1.Text = Now
        'AvisarDia


        Me.Button1.PerformClick()


        'Mensagem de texto ao passar o mouse em cima....................

        ' Cria a ToolTip e associa com o Form container.
        Dim toolTip1 As New ToolTip()
        'cria outra ToolTip e associa ao controle Button
        Dim buttonToolTip As New ToolTip()
        buttonToolTip.ToolTipTitle = "Dica ToolTip para o controle Button"
        buttonToolTip.UseFading = True
        buttonToolTip.UseAnimation = True
        buttonToolTip.IsBalloon = True
        buttonToolTip.ShowAlways = True
        buttonToolTip.AutoPopDelay = 5000
        buttonToolTip.InitialDelay = 1000
        buttonToolTip.ReshowDelay = 500
        buttonToolTip.IsBalloon = True
        ' Define o delay para a ToolTip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500
        ' Força a o texto da ToolTip a ser exibido mesmo que o form não esta ativo
        toolTip1.ShowAlways = True
        ' Define o texto da ToolTip para o Button, TextBox, Checkbox e Label
        'toolTip1.SetToolTip(Me.btnTeste, "Este é o Botão Teste")
        ' Define o texto da ToolTip para o Button, TextBox, Checkbox e Label
        toolTip1.SetToolTip(Me.PictureBox4, "Clique para ver os Lembretes")
        toolTip1.SetToolTip(Me.PictureBox5, "Clique para ver as Prioridades")
        toolTip1.SetToolTip(Me.PictureBox3, "Clique para Atualizar os Dados")

        'FIM DO CODIGO .........................

    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' PESQUISA COM FILTRO POR DATA AVISO
        'FILTRO LAUDO
        Dim FilterA As String
        FilterA = MaskedTextBox1.Text
        LaudosBindingSource.Filter = "AvisarDia like '" & FilterA & "%'"

        'FILTRO  EMPRESA
        Dim FilterB As String
        FilterB = MaskedTextBox1.Text
        EmpresasBindingSource.Filter = "AvisarDia like '" & FilterB & "%'"
    End Sub





    Private Sub EmpresasDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpresasDataGridView.CellContentDoubleClick
        If Application.OpenForms.OfType(Of Legalizacao)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            Legalizacao.Focus()
            Legalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.SelectedCells.Item(0).Value.ToString
            Legalizacao.ComboBoxBuscaEmpresa.Focus()
        Else

            ' novoEmpresa.MdiParent = MDIPrincipal
            Legalizacao.Show()
            Legalizacao.ComboBoxBuscaEmpresa.Text = EmpresasDataGridView.SelectedCells.Item(0).Value.ToString
            Legalizacao.ComboBoxBuscaEmpresa.Focus()
        End If
    End Sub

    Private Sub LaudosDataGridView_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LaudosDataGridView.CellContentDoubleClick


        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            Dim Sair As String
            Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")
            FrmAlvara.Focus()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        Else
            ' novoEmpresa.MdiParent = MDIPrincipal
            FrmAlvara.Show()
            FrmAlvara.ComboBox1.Text = LaudosDataGridView.SelectedCells.Item(0).Value.ToString
            FrmAlvara.ComboBox1.Focus()
        End If
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try



            'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
            'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Laudos'. Você pode movê-la ou removê-la conforme necessário.
            Me.LaudosTableAdapter.Fill(Me.PrinceDBDataSet.Laudos)

            Me.Refresh()
        Finally



        End Try

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If Application.OpenForms.OfType(Of LembreteInicial)().Count() > 0 Then

            LembreteInicial.Focus()
            LembreteInicial.Close()
            LembreteInicial.MdiParent = MDIPrincipal
            LembreteInicial.Show()

        Else

            LembreteInicial.MdiParent = MDIPrincipal
            LembreteInicial.Show()


        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If Application.OpenForms.OfType(Of PrioridadeAviso)().Count() > 0 Then

            PrioridadeAviso.Focus()
            PrioridadeAviso.Close()
            PrioridadeAviso.MdiParent = MDIPrincipal
            PrioridadeAviso.Show()

        Else

            PrioridadeAviso.MdiParent = MDIPrincipal
            PrioridadeAviso.Show()

        End If
    End Sub
End Class