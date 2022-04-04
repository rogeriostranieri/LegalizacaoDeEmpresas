Imports System.Drawing.Text

Public Class FrmAnotacoes




    Private Sub FrmAnotacoes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Anotacoes'. Você pode movê-la ou removê-la conforme necessário.
        Me.AnotacoesTableAdapter.Fill(Me.PrinceDBDataSet.Anotacoes)

        'carrega fonte
        Fontesinstaladas()

        'carrega

        RichTextBoxAnotacao.Visible = False
        lblMudaTexto.Visible = False


        cbotamanho.DropDownStyle = ComboBoxStyle.DropDownList


        ' Dim Tamanhos As String = "6, 7, 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72"


        Dim Tamanhos As String = ("6, 7, 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72")

        cbotamanho.Items.AddRange(Tamanhos.Split(","))

        cbotamanho.SelectedIndex = 6

    End Sub


    Private Sub Fontesinstaladas()
        Dim InstalledFonts = New InstalledFontCollection
        Dim FontFamilies() As FontFamily = InstalledFonts.Families
        For Each Font As FontFamily In FontFamilies
            cbofonte.Items.Add(Font.Name)
        Next
        ''THE END USER WONT BE ABOUT TO EDIT THE INSTALLED ITEMS IN THE COMBOBOX
        ''THE STARTING FONT IS CONSOLAS
        cbofonte.DropDownStyle = ComboBoxStyle.DropDownList
        cbofonte.Text = "Arial"
    End Sub



    '=================================================================================
    'Editores de texto
    '=================================================================================

    Private Sub MudarCorBotao_Click(sender As Object, e As EventArgs) Handles MudarCorBotao.Click
        Dim MinhasCores As ColorDialog = New ColorDialog
        'selecionar uma cor customizada
        MinhasCores.AllowFullOpen = False
        'Permite o usuário obter ajuda 
        MinhasCores.ShowHelp = True
        'Define a cor inicial selecionada para a cor atual
        MinhasCores.Color = RichTextBoxAnotacao.ForeColor
        'pinta a seleção do texto

        If (MinhasCores.ShowDialog() = DialogResult.OK) Then
            If RichTextBoxAnotacao.SelectedText.Length > 0 Then
                RichTextBoxAnotacao.SelectionColor = MinhasCores.Color
            Else
                RichTextBoxAnotacao.SelectionColor = MinhasCores.Color
                'RichTextBoxAnotacao.ForeColor = MinhasCores.Color
            End If

        End If

    End Sub

    Private Sub Mudafonte()
        Dim fonte As String = cbofonte.Text
        Dim tamanho As Integer = cbotamanho.Text 'cbofonte.SelectedIndex + 1
        Dim estilo As FontStyle = FontStyle.Regular

        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionFont = New Font(fonte, tamanho, estilo)
        Else
            RichTextBoxAnotacao.SelectionFont = New Font(fonte, tamanho, estilo)

            'RichTextBoxAnotacao.Font = New Font(fonte, tamanho, estilo)
        End If

        'RichTextBoxAnotacao.SelectionFont = New Font(fonte, tamanho, estilo)
    End Sub
    Private Sub cbofonte_DropDownClosed(sender As Object, e As EventArgs) Handles cbofonte.DropDownClosed
        Mudafonte()
    End Sub
    Private Sub cbotamanho_DropDownClosed(sender As Object, e As EventArgs) Handles cbotamanho.DropDownClosed
        Mudafonte()
    End Sub


    Private Sub BtnNegrito_Click(sender As Object, e As EventArgs) Handles BtnNegrito.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Bold)
        Else
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Bold)
        End If

    End Sub

    Private Sub BtnItalico_Click(sender As Object, e As EventArgs) Handles BtnItalico.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Italic)
        Else
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Italic)
        End If
    End Sub

    Private Sub BtnSublinhado_Click(sender As Object, e As EventArgs) Handles BtnSublinhado.Click
        If RichTextBoxAnotacao.SelectedText.Length > 0 Then
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Underline)
        Else
            RichTextBoxAnotacao.SelectionFont = New Font(RichTextBoxAnotacao.SelectionFont, FontStyle.Underline)
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
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Inicial"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Inicial"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonLegalizacao_Click(sender As Object, e As EventArgs) Handles ButtonLegalizacao.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Legalização"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Legalizacao"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonFederal_Click(sender As Object, e As EventArgs) Handles ButtonFederal.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Receita Federal"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Federal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonEstadual_Click(sender As Object, e As EventArgs) Handles ButtonEstadual.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Receita Estadual"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Estadual"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonPrefeitura_Click(sender As Object, e As EventArgs) Handles ButtonPrefeitura.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Prefeitura Municipal"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Municipal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub ButtonDemais_Click(sender As Object, e As EventArgs) Handles ButtonDemais.Click
        Try
            RichTextBoxAnotacao.Visible = True
            lblMudaTexto.Visible = True

            lblMudaTexto.Text = "Demais Assuntos"
            RichTextBoxAnotacao.DataBindings.Clear()
            RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", AnotacoesBindingSource, "Demais"))
        Catch ex As Exception
            MsgBox("Erro! " & vbCrLf & ex.Message)
        End Try
    End Sub







    '=================================================================================
    'FIM botões
    '=================================================================================



End Class