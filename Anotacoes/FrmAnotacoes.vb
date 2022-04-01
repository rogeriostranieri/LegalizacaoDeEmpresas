Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class FrmAnotacoes

    Dim AnotacoesTable As New DataTable
    Dim AnotacoesBS As New BindingSource
    Dim SQLCONEX As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"



    Private Sub AnotacoesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AnotacoesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

    End Sub

    Private Sub FrmAnotacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Anotacoes'. Você pode movê-la ou removê-la conforme necessário.
        Me.AnotacoesTableAdapter.Fill(Me.PrinceDBDataSet.Anotacoes)

        'carrega
        

    End Sub

    'RichTextBoxAnotacao
    Private Sub AlterarInicial()

    End Sub

    Private Sub MudarCorBotao_Click(sender As Object, e As EventArgs) Handles MudarCorBotao.Click
        Dim minhasCores As ColorDialog = New ColorDialog
        ' // Não permite ao usuário selecionar uma cor customizada
        minhasCores.AllowFullOpen = False
        '   // Permite o usuário obter ajuda 
        minhasCores.ShowHelp = True
        '   // Define a cor inicial selecionada para a cor atual
        minhasCores.Color = RichTextBoxAnotacao.ForeColor
        '   // Atualiza a cor no TextBox 
        If (minhasCores.ShowDialog() = DialogResult.OK) Then
            ' RichTextBoxAnotacao.ForeColor = minhasCores.Color
            RichTextBoxAnotacao.SelectionColor = minhasCores.Color

        End If

    End Sub



    '=================================================================================
    'Salvar
    '=================================================================================

    Private Sub ButtonSalvar_Click(sender As Object, e As EventArgs) Handles ButtonSalvar.Click
        Me.Validate()
        Me.AnotacoesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

    End Sub

    '=================================================================================
    'INICIAL botões
    '=================================================================================

    Private Sub ButtonInicial_Click(sender As Object, e As EventArgs) Handles ButtonInicial.Click
        Try
            lblMudaTexto.Text = "Inicial"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Inicial"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonLegalizacao_Click(sender As Object, e As EventArgs) Handles ButtonLegalizacao.Click
        Try
            lblMudaTexto.Text = "Legalização"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Legalizacao"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonFederal_Click(sender As Object, e As EventArgs) Handles ButtonFederal.Click
        Try
            lblMudaTexto.Text = "Receita Federal"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Federal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonEstadual_Click(sender As Object, e As EventArgs) Handles ButtonEstadual.Click
        Try
            lblMudaTexto.Text = "Receita Estadual"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Estadual"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonPrefeitura_Click(sender As Object, e As EventArgs) Handles ButtonPrefeitura.Click
        Try
            lblMudaTexto.Text = "Prefeitura Municipal"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Municipal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonDemais_Click(sender As Object, e As EventArgs) Handles ButtonDemais.Click
        Try
            lblMudaTexto.Text = "Demais Assuntos"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Demais"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    '=================================================================================
    'FIM botões
    '=================================================================================

End Class