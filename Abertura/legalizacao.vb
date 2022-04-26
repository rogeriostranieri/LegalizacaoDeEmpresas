﻿Imports System.Data.SqlClient
Imports System.IO

Public Class Legalizacao
    'ESPAÇO para os DIM GERAL

    'Bloqueando para edição
    Private Sub Bloquear()
        Dim o As Object
        For Each o In Me.Controls
            If TypeOf o Is TextBox Then
                DirectCast(o, TextBox).Enabled = False
            End If
        Next
    End Sub

    Private Sub Desbloquear()
        Dim o As Object
        For Each o In Me.Controls
            If TypeOf o Is TextBox Then
                DirectCast(o, TextBox).Enabled = True
            End If
        Next
    End Sub

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then Me.Close()
    End Sub




    Private Sub Salvar()

        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.EmpresasBindingSource.EndEdit()
        changedRecords = PrinceDBDataSet.Empresas.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            'MOSTRA MENSAGM BOX
            'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)

            'mostra mensagem box SIM OU NAO OU CANCELA
            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                ' e.Cancel = True
            ElseIf result = DialogResult.No Then
                BtnEditar.Text = "Editar"
                BtnExcluir.Enabled = True
                GroupBox2.Enabled = False
                GroupBox10.Enabled = False
                'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Naturezajuridica'. Você pode movê-la ou removê-la conforme necessário.
                Me.NaturezajuridicaTableAdapter.Fill(Me.PrinceDBDataSet.Naturezajuridica)
                'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
                Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)

            ElseIf result = DialogResult.Yes Then


                Try

                    'Salva alterações
                    Me.Validate()
                    Me.EmpresasBindingSource.EndEdit()
                    Me.EmpresasTableAdapter.Update(Me.PrinceDBDataSet.Empresas)


                    If BtnEditar.Text = "Editar" Then
                        Editar()

                    ElseIf BtnEditar.Text = "Cancelar" Then
                        'Modifica bloqueando td novamente
                        ' BtnEditar.Text = "Editar"
                        ' BtnExcluir.Enabled = True
                        ' GroupBox2.Enabled = False
                        ' GroupBox10.Enabled = False
                        Editar()
                    End If


                    Dim NomeEmpresa As String = RazaoSocialTextBox.Text
                    ComboBoxBuscaEmpresa.Text = NomeEmpresa
                    ComboBoxBuscaEmpresa.Focus()
                    RazaoSocialTextBox.Focus()



                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            End If

        Else

            BtnEditar.Text = "Editar"
            GroupBox2.Enabled = False
            GroupBox10.Enabled = False

            Dim NomeEmpresa As String = RazaoSocialTextBox.Text
            'Salvar() nao precisa pq nao houve alteração em nada
            ComboBoxBuscaEmpresa.Text = NomeEmpresa
            ComboBoxBuscaEmpresa.Focus()
            RazaoSocialTextBox.Focus()

            BtnExcluir.Enabled = True

        End If




    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.CADstatus'. Você pode movê-la ou removê-la conforme necessário.
        Me.CADstatusTableAdapter.Fill(Me.PrinceDBDataSet.CADstatus)
        '//// calendario 
        'Dim Calendario As New MonthCalendar  ' VER ISSO E COLOCA COMO PADRAO
        Calendar1.Visible = False
        Calendar1.Location = New Point(65, 59)
        '////// fim calencario
        Try

            'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Naturezajuridica'. Você pode movê-la ou removê-la conforme necessário.
            Me.NaturezajuridicaTableAdapter.Fill(Me.PrinceDBDataSet.Naturezajuridica)
            'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)

            BtnEditar.Text = "Cancelar"
            Editar()

            'chama combobox status
            '   ModCombobox.ComboboxLegalizacao()
            ModCombobox.ComboboxLegalizacaoProcesso()

            'Ficar focado no campo busca
            Me.ComboBoxBuscaEmpresa.Focus()

        Finally

            'nao faz nada

        End Try

    End Sub



    Private Sub ProcessoMudar()
        If ProcessoComboBox.Text = "Abertura" Then
            'MotivoRichTextBox.Visible = False
            ' MotivoLabel.Visible = False
            NAlteracaoComboBox.Visible = False
            NAlteracaoLabel.Visible = False
            AltConsolidadaComboBox.Visible = False
            LabelConsolidar.Visible = False
            LinkLabel9.Visible = False
            GroupBox5.Visible = False

            NovaRazaoSocialLabel.Visible = False
            NovaRazaoSocialComboBox.Visible = False

        ElseIf ProcessoComboBox.Text = "Alteração" Then
            NAlteracaoComboBox.Visible = True
            NAlteracaoLabel.Visible = True
            AltConsolidadaComboBox.Visible = True
            LabelConsolidar.Visible = True
            LinkLabel9.Visible = True
            GroupBox5.Visible = True


            NovaRazaoSocialLabel.Visible = True
            NovaRazaoSocialComboBox.Visible = True


        ElseIf ProcessoComboBox.Text = "Baixa" Then
            ' MotivoRichTextBox.Visible = False
            ' MotivoLabel.Visible = False
            NAlteracaoComboBox.Visible = False
            NAlteracaoLabel.Visible = False
            AltConsolidadaComboBox.Visible = False
            LabelConsolidar.Visible = False
            LinkLabel9.Visible = False
            GroupBox5.Visible = True

            NovaRazaoSocialLabel.Visible = False
            NovaRazaoSocialComboBox.Visible = False


        Else
            'MotivoRichTextBox.Visible = True
            'MotivoLabel.Visible = True
            NAlteracaoComboBox.Visible = True
            NAlteracaoLabel.Visible = True
            AltConsolidadaComboBox.Visible = True
            LabelConsolidar.Visible = True
            LinkLabel9.Visible = True

            NovaRazaoSocialLabel.Visible = True
            NovaRazaoSocialComboBox.Visible = True

        End If
    End Sub
    Private Sub StatusMudar()

        Select Case StatusComboBox.Text'.Trim()

            Case "Finalizado"
                If SistemaExternoComboBox.Text = "Não" Then
                    If MsgBox("Foi alterado no seu Sistema Particular?", MsgBoxStyle.YesNo, "Notificação") = MsgBoxResult.Yes Then
                        If ProcessoComboBox.Text = "Baixa" Then
                            StatusComboBox.BackColor = System.Drawing.Color.Green
                            StatusComboBox.ForeColor = System.Drawing.Color.White
                            AvisarDiaMaskedTextBox.Text = ""
                            PictureBox1.Image = My.Resources.check
                            PictureBox2.Image = My.Resources.fechadaempresa
                            SistemaExternoComboBox.SelectedItem = "Sim"


                        ElseIf ProcessoComboBox.Text = "Finalizado" Then
                            StatusComboBox.BackColor = System.Drawing.Color.Green
                            StatusComboBox.ForeColor = System.Drawing.Color.White
                            AvisarDiaMaskedTextBox.Text = ""
                            PictureBox1.Image = My.Resources.check
                            PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA
                            SistemaExternoComboBox.SelectedItem = "Sim"

                        Else

                            StatusComboBox.BackColor = System.Drawing.Color.Green
                            StatusComboBox.ForeColor = System.Drawing.Color.White
                            AvisarDiaMaskedTextBox.Text = ""
                            PictureBox1.Image = My.Resources.check
                            PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA
                            SistemaExternoComboBox.SelectedItem = "Sim"

                        End If
                    Else
                        StatusComboBox.Text = "Pêndencia Sistema Externo"
                        StatusComboBox.BackColor = System.Drawing.Color.Red
                        StatusComboBox.ForeColor = System.Drawing.Color.Black
                        ' AvisarDiaMaskedTextBox.Text = ""
                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = Nothing
                        ' SistemaExternoComboBox.SelectedText = "Não"
                    End If
                ElseIf SistemaExternoComboBox.Text = "Sim" Then

                    If ProcessoComboBox.Text = "Baixa" Then
                        StatusComboBox.BackColor = System.Drawing.Color.Green
                        StatusComboBox.ForeColor = System.Drawing.Color.White

                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = My.Resources.fechadaempresa
                        SistemaExternoComboBox.SelectedItem = "Sim"

                    ElseIf ProcessoComboBox.Text = "Finalizado" Then
                        StatusComboBox.BackColor = System.Drawing.Color.Green
                        StatusComboBox.ForeColor = System.Drawing.Color.White
                        AvisarDiaMaskedTextBox.Text = ""
                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA
                        SistemaExternoComboBox.SelectedItem = "Sim"

                    Else
                        StatusComboBox.BackColor = System.Drawing.Color.Green
                        StatusComboBox.ForeColor = System.Drawing.Color.White
                        AvisarDiaMaskedTextBox.Text = ""
                        PictureBox1.Image = My.Resources.check
                        PictureBox2.Image = My.Resources.ABERTURA_DE_EMPRESA
                        SistemaExternoComboBox.SelectedItem = "Sim"

                    End If

                Else
                    'Antigo codigo
                    StatusComboBox.BackColor = System.Drawing.Color.Green
                    StatusComboBox.ForeColor = System.Drawing.Color.White
                    AvisarDiaMaskedTextBox.Text = ""
                    PictureBox1.Image = My.Resources.check
                End If



            Case "Pêndencia Sistema Externo"
                StatusComboBox.BackColor = System.Drawing.Color.Red
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                ' AvisarDiaMaskedTextBox.Text = ""
                PictureBox1.Image = My.Resources.check
                PictureBox2.Image = Nothing
               ' SistemaExternoComboBox.SelectedText = "Não"

            Case "Paralisado"
                StatusComboBox.BackColor = System.Drawing.Color.Red
                StatusComboBox.ForeColor = System.Drawing.Color.White
                AvisarDiaMaskedTextBox.Text = ""
                PictureBox1.Image = My.Resources._Stop
                PictureBox2.Image = Nothing

            Case "Cancelado"
                StatusComboBox.BackColor = System.Drawing.Color.Red
                StatusComboBox.ForeColor = System.Drawing.Color.White
                AvisarDiaMaskedTextBox.Text = ""
                PictureBox1.Image = My.Resources.Cancel
                PictureBox2.Image = Nothing

            Case "Em Andamento"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = My.Resources.empresa_facil
                PictureBox1.Image = My.Resources.emandamento

            Case "Aguardando Pagamento das Taxas"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox1.Image = My.Resources.emandamento
                PictureBox2.Image = My.Resources.pagamento

                '//////////////////////////////////////////////
                ' JUNTA COMERCIAL
                '//////////////////////////////////////////////
            Case "Junta Comercial - Prefeitura: EM ANÁLISE"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = My.Resources.empresa_facil
                PictureBox1.Image = My.Resources.emandamento
            Case "Junta Comercial - Busca de Nome"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = My.Resources.empresa_facil
                PictureBox1.Image = My.Resources.emandamento
            Case "Junta Comercial - Aguardando Atualização"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = My.Resources.empresa_facil
                PictureBox1.Image = My.Resources.emandamento
            Case "Junta Comercial - Protocolado"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = My.Resources.empresa_facil
                PictureBox1.Image = My.Resources.emandamento


            Case "Receita Federal - DBE"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = My.Resources.redeSim_Divulgação
                PictureBox1.Image = My.Resources.emandamento

            Case "Receita Estadual - Protocolado"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = My.Resources.governo2019_400x173px
                PictureBox1.Image = My.Resources.emandamento



            Case "Receita Estadual - Em Andamento"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = My.Resources.governo2019_400x173px
                PictureBox1.Image = My.Resources.emandamento
                '

            Case "Simples Nacional - Protocolado"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = My.Resources.logo_simples_nacional_810x455
                PictureBox1.Image = My.Resources.emandamento

            Case "Prefeitura/Alvará - Em Andamento"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox1.Image = My.Resources.emandamento
                PictureBox2.Image = My.Resources.alvara

                '
            Case "Aguardando Cliente"
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox1.Image = My.Resources.emandamento
                PictureBox2.Image = Nothing

            Case "Receita Federal - e-Processo"

                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox2.Image = Nothing
                PictureBox1.Image = My.Resources.emandamento

            Case Else
                StatusComboBox.BackColor = System.Drawing.Color.White
                StatusComboBox.ForeColor = System.Drawing.Color.Black
                PictureBox1.Image = Nothing
                PictureBox2.Image = Nothing
                'Protocolado Receita Estadual



        End Select
    End Sub






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnConsultaJunta.Click

        System.Diagnostics.Process.Start("https://www.empresafacil.pr.gov.br/sigfacil/processo/acompanhar/co_protocolo/" + ProtocoloJuntaComercialTextBox.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Application.OpenForms.OfType(Of BoxConsultaCNPJEmpresa)().Count() > 0 Then
            BoxConsultaCNPJEmpresa.Focus()
        Else
            BoxConsultaCNPJEmpresa.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Using WS = New WSCorreios.AtendeClienteClient()
            Try
                'Using WS = New WSCorreios.AtendeClienteClient()
                Dim Resultado = WS.consultaCEP(EndCEPMaskedTextBox.Text)
                EnderecoTextBox.Text = Resultado.[end]
                'EndComplementoTextBox.Text = Resultado.complemento
                EndComplementoTextBox.Text = Resultado.complemento2
                EndCidadeTextBox.Text = Resultado.cidade
                EndBairroTextBox.Text = Resultado.bairro
                EndEstadoTextBox.Text = Resultado.uf
                ' mgs de erro

            Catch Ex As Exception
                ' MessageBox.Show(Ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.[Error])

                If MsgBox(" Deseja Buscar CEP correto no site dos correios?", MsgBoxStyle.YesNo, "Busca CEP") = MsgBoxResult.Yes Then
                    System.Diagnostics.Process.Start("https://buscacepinter.correios.com.br/app/endereco/index.php")
                Else

                End If
            End Try

        End Using

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Maximized

        '  Dim CNAEWEB As New CNAEWEB()
        'Set the Parent Form of the Child window.
        BuscaCNAE.MdiParent = MDIPrincipal
        'Display the new form.
        BuscaCNAE.Show()
    End Sub




    '  Private Sub Legalizacao_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    '   If MsgBox("Tem certeza que deseja salvar e sair?", vbYesNo, "Confirmação") = vbYes Then

    '      Me.Validate()
    '      Me.EmpresasBindingSource.EndEdit()
    '     Me.EmpresasTableAdapter.Update(Me.PrinceDBDataSet.Empresas)
    ' Me.Close()
    '  Else
    'Me.Close()
    ' End If



    ' End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            'EmpCriadoMaskedTextBox

            'MessageBox.Show(DateTime.Now.ToLongDateString())

            Dim a As DateTime
            a = EmpCriadoMaskedTextBox.Text

            'just show time only
            '  MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim a As DateTime
            a = DataProtJuntaComercialMaskedTextBox.Text

            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)

        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Dim a As DateTime

            a = DataProtREDESIMMaskedTextBox.Text
            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)
        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        System.Diagnostics.Process.Start("https://concla.ibge.gov.br/busca-online-cnae.html")
        'BuscaCNAE.Show() mto problema com site

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TabControle.SelectTab(2)
        TabControl1.SelectTab(0)



        Try

            'Soma de data e ano bisexto 

            Dim iDias, iMes, iAno As Integer
            Dim sData As String

            'Compara a data atual com uma data anterior, no caso utilizei 01/01/1990 e vê a quantidade de 
            'dias do intervalo
            iDias = DateDiff("d", "01/01/1990", NireDataMaskedTextBox.Text)

            'Soma a quantidade de dias que quer somar e adiciona mais 1 para que de certo
            iDias = iDias + 1 + txtDataASomar.Text

            'coloca o ano que foi indicado acima na variavel que vai armazenar o ano
            iAno = 1990

            'faz um loop para saber quantos anos existem dentro da quantidade de dias achados
            Do While iDias >= 365
                iDias -= 365
                iAno += 1
                've se o ano é bissexto
                If iAno Mod 4 = 0 Then
                    iDias -= 1
                End If
            Loop

            'adiciona 1 na variavel que vai receber o mes
            iMes = 1

            'faz a mesma coisa que no ano, com um case no meio para ver os meses que não tem 31 dias
            'e corrigir as quantidades de dias a subtrair
            Do While iDias > 31
                iDias -= 31
                iMes += 1
                Select Case iMes
                    Case 3
                        If iAno Mod 4 = 0 Then
                            iDias += 2
                        Else
                            iDias += 3
                        End If
                    Case 5
                        iDias += 1
                    Case 7
                        iDias += 1
                    Case 8
                        iDias += 1
                    Case 10
                        iDias += 1
                    Case 12
                        iDias += 1
                End Select
            Loop

            'aqui pega os resultados e transforma em data.
            sData = iDias & "/" & iMes & "/" & iAno
            '& Format(sData, "dd/mm/yy")

            ' PrazoSimplesMaskedTextBox.Text = sData

            PrazoSimplesMaskedTextBox.Text = CDate(sData).ToString("dd/MM/yyyy")
            TabControle.SelectTab(5)

        Catch
            MessageBox.Show(" Data do NIRE está vazia! ", "Prince Ajuda")
            TabControle.SelectTab(2)
            TabControl1.SelectTab(0)

        End Try

    End Sub
    Private Sub Ajuda1()
        MessageBox.Show(" LEI 8934/94
Dispõe sobre o Registro Público de Empresas Mercantis e Atividades Afins e dá outras providências.
Art. 60. A firma individual ou a sociedade que não proceder a qualquer arquivamento no período de 10 (dez) anos consecutivos deverá comunicar à junta comercial que deseja manter-se em funcionamento.

§ 1º Na ausência dessa comunicação, a empresa mercantil será considerada inativa, promovendo a junta comercial o cancelamento do registro, com a perda automática da proteção ao nome empresarial.

§ 2º A empresa mercantil deverá ser notificada previamente pela junta comercial, mediante comunicação direta ou por edital, para os fins deste artigo.

§ 3º A junta comercial fará comunicação do cancelamento às autoridades arrecadadoras, no prazo de até dez dias.

§ 4º A reativação da empresa obedecerá aos mesmos procedimentos requeridos para sua constituição. ", "Prince Ajuda")
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Ajuda1()
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles BtnConsultaRedeSim.Click

        TabControle.SelectTab(2)
        TabControle.SelectTab(3)

        If Trim(ProtocoloREDESIMTextBox.Text) = "" Then



            If Trim(ProtocoloJuntaComercialTextBox.Text) = "" Then

                MsgBox("Protocolo VAZIO e abrindo site para Solicitar...", MsgBoxStyle.Information, "Prince Sistemas Informa!")

                System.Diagnostics.Process.Start("https://www.gov.br/empresas-e-negocios/pt-br/redesim/abra-sua-pessoa-juridica")


            Else

                ' Clipboard.SetText(ProtocoloJuntaComercialTextBox.Text)
                ProtocoloREDESIMTextBox.Text = ProtocoloJuntaComercialTextBox.Text
                Clipboard.SetText(ProtocoloREDESIMTextBox.Text)

                MsgBox("Protocolo Copiado da Junta Comercial e abrindo site...", MsgBoxStyle.Information, "Prince Sistemas Informa!")

                System.Diagnostics.Process.Start("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/consulta.asp?_ga=2.158688954.1840779760.1611238476-1712582906.1584021811")

            End If


        Else


            Clipboard.SetText(ProtocoloREDESIMTextBox.Text)
            MsgBox("Protocolo REDESIM Copiado e abrindo site...", MsgBoxStyle.Information, "Prince Sistemas Informa!")

            System.Diagnostics.Process.Start("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/consulta.asp")

        End If






    End Sub

    Private Sub Ajuda2()
        MessageBox.Show(" Foi informado um dos eventos de viabilidade abaixo?

*Alteração de endereço dentro do mesmo município
*Alteração do nome empresarial
*Alteração de natureza jurídica
*Alteração de atividades econômicas (principal e secundárias)
*Alteração do tipo de unidade
*Alteração da forma de atuação

Se for SIM, 
Precisa do Protocolo de Viabilidade da Junta Comercial", "Prince Ajuda")
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Ajuda2()
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Ajuda1()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Ajuda2()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click



        ' MsgBox("Protocolo Copiado e abrindo site...", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        ' Clipboard.SetText(ProtocoloREDESIMTextBox.Text)
        System.Diagnostics.Process.Start("http://www.fazenda.pr.gov.br/")

    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked

        System.Diagnostics.Process.Start("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=40")

    End Sub

    Private Sub LinkLabel7_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel7.LinkClicked

        System.Diagnostics.Process.Start("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/GeraCodigo.aspx")

    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked

        System.Diagnostics.Process.Start("http://www8.receita.fazenda.gov.br/SimplesNacional/Servicos/Grupo.aspx?grp=t&area=1")

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TabControle.SelectTab(1)
        TabControl2.SelectTab(0)

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TabControle.SelectTab(1)
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Try
            System.Diagnostics.Process.Start(ArquivoContratoTextBox.Text)
        Catch
            MsgBox("Campo Vazio", MsgBoxStyle.Critical, "Prince Sistemas")
        End Try
    End Sub








    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        Dim Arquivo As String
        Dim Local As String

        Try
            OpenFileDialog1.ShowDialog()
            Arquivo = OpenFileDialog1.SafeFileName
            Local = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
            OpenFileDialog1.FileName = ""
            ArquivoContratoTextBox.Text = Local


        Catch ex As Exception
            MsgBox("ERRO, Selecione algum arquivo para salvar o local da pasta", MsgBoxStyle.Critical, "Prince Sistemas")
            ArquivoContratoTextBox.Text = ""
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        If BtnEditar.Text = "Editar" Then

            If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
                Me.Validate()
                Me.EmpresasBindingSource.AddNew()
                'unchek lembrete

                LembreteCheckBox.CheckState = CheckState.Unchecked
                PrioridadeCheckBox.CheckState = CheckState.Unchecked

                'Cadastro
                TipoDeEmpresaComboBox.SelectedIndex = -1
                PorteDaEmpresaComboBox.SelectedIndex = -1
                RegimeFederalComboBox.SelectedIndex = -1
                NaturezaJuridicaComboBox.SelectedIndex = -1

                'que faltou
                'RegimeFederalComboBox.SelectedText = "Pendência"
                RegimeFederalComboBox.SelectedIndex = 4


                'procedimentos
                'StatusComboBox.SelectedIndex = -1
                'StatusComboBox.SelectedText = "Não Iniciado"
                StatusComboBox.SelectedIndex = 0
                ProcessoComboBox.SelectedIndex = -1
                'SistemaExternoComboBox.SelectedText = "Não"
                SistemaExternoComboBox.SelectedIndex = 1
                EmpCriadoMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
                AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
                Editar()
            Else

            End If

        ElseIf BtnEditar.Text = "Cancelar" Then
            If MsgBox(" Deseja criar um novo registro?", MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
                Me.Validate()
                Me.EmpresasBindingSource.AddNew()
                'unchek lembrete

                LembreteCheckBox.CheckState = CheckState.Unchecked
                PrioridadeCheckBox.CheckState = CheckState.Unchecked

                'Cadastro
                TipoDeEmpresaComboBox.SelectedIndex = -1
                PorteDaEmpresaComboBox.SelectedIndex = -1
                RegimeFederalComboBox.SelectedIndex = -1
                NaturezaJuridicaComboBox.SelectedIndex = -1

                'que faltou
                'RegimeFederalComboBox.SelectedText = "Pendência"
                RegimeFederalComboBox.SelectedIndex = 4


                'procedimentos
                'StatusComboBox.SelectedIndex = -1
                'StatusComboBox.SelectedText = "Não Iniciado"
                StatusComboBox.SelectedIndex = 0
                ProcessoComboBox.SelectedIndex = -1
                'SistemaExternoComboBox.SelectedText = "Não"
                SistemaExternoComboBox.SelectedIndex = 1
                EmpCriadoMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
                AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
            Else

            End If

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        If MsgBox(" Deseja apagar o registo ?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then
            Me.Validate()
            Me.EmpresasBindingSource.RemoveCurrent()
            Me.EmpresasTableAdapter.Update(Me.PrinceDBDataSet.Empresas)
            Me.EmpresasTableAdapter.Fill(Me.PrinceDBDataSet.Empresas)
            MessageBox.Show("Voltando ao início dos registros !", "Informativo - Prince Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        'If MsgBox(" Deseja salvar as alterações?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
        Salvar()
        ' Else

        ' End If


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles BtnFechar.Click
        Me.Close()
    End Sub

    Private Sub ProcessoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProcessoComboBox.SelectedIndexChanged

        ProcessoMudar()
        StatusMudar()

    End Sub


    Private Sub StatusComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StatusComboBox.SelectedIndexChanged

        ProcessoMudar()
        StatusMudar()


    End Sub



    Private Sub Legalizacao_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' Dim result As Integer = MessageBox.Show("Deseja Salvar as Alterações antes de fechar?", "Prince Alerta", MessageBoxButtons.YesNoCancel)
        ' If result = DialogResult.Cancel Then
        '    e.Cancel = True
        'ElseIf result = DialogResult.No Then

        ' ElseIf result = DialogResult.Yes Then
        '    Me.Validate()
        'Me.EmpresasBindingSource.EndEdit()
        ' Me.EmpresasTableAdapter.Update(Me.PrinceDBDataSet.Empresas)

        ' End If


        Dim changedRecords As System.Data.DataTable
        ' changedRecords = PrinceDBDataSet.Telefones.GetChanges()
        Me.EmpresasBindingSource.EndEdit()


        changedRecords = PrinceDBDataSet.Empresas.GetChanges()


        If Not (changedRecords Is Nothing) AndAlso (changedRecords.Rows.Count > 0) Then

            Dim message As String

            'message = String.Format("Você realizou = {0} alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)
            message = String.Format("Você realizou alguma(s) alterações(s)." + vbCrLf + "Deseja Salvar estas alterações?", changedRecords.Rows.Count)


            Dim result As Integer = MessageBox.Show(message, "Prince Alerta", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Try

                    EmpresasTableAdapter.Update(PrinceDBDataSet.Empresas)

                Catch exc As Exception

                    MessageBox.Show("Ocorreu um Erro ao atualizar" + vbCrLf + exc.Message + vbCrLf + vbCrLf + "Linha em vermelho com erro", "Prince Sistemas Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End Try

            End If


        End If


    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TabControle.SelectTab(2)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TabControle.SelectTab(3)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TabControle.SelectTab(5)
    End Sub



    Private Sub LinkLabel9_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel9.LinkClicked
        MessageBox.Show("Verificar se o contrato antigo não está na forma digital.


Caso o contrato não esteja em sua forma digital (antigo), recomenda-se:

* Nova alteração com consolidação para forma digital, anulando contratos atigos em papel", "ATENÇÃO")
    End Sub


    Private Sub ProcessoComboBox_Validated(sender As Object, e As EventArgs) Handles ProcessoComboBox.Validated
        If ProcessoComboBox.Text = "Alteração" Then
            MessageBox.Show("Verificar se o contrato antigo não está na forma digital.


Caso o contrato não esteja em sua forma digital (antigo), recomenda-se:

* Nova alteração com consolidação para forma digital, anulando contratos atigos em papel", "ATENÇÃO")

        Else
            'não faz nd
        End If

        If ProcessoComboBox.Text = "Abertura" Then
            SistemaExternoLabel.Text = "Cadastro no Sistema Externo:"
        Else
            SistemaExternoLabel.Text = "Atualização no Sistema Externo:"

        End If
    End Sub


    Private Sub LinkLabel10_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel10.LinkClicked
        System.Diagnostics.Process.Start("https://www.correios.com.br")

    End Sub


    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        System.Diagnostics.Process.Start("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor")

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Try
            Dim a As DateTime
            a = DataPedidoIEMaskedTextBox.Text

            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)

        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        System.Diagnostics.Process.Start("https://www.gov.br/empresas-e-negocios/pt-br/empreendedor/quero-ser-mei/atividades-permitidas")
    End Sub

    Private Sub TipoDeEmpresaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TipoDeEmpresaComboBox.SelectedIndexChanged
        If TipoDeEmpresaComboBox.Text = "Microempreendedor Indivual ( MEI )" Then
            Button24.Visible = True
            Button20.Visible = False
            Button25.Visible = True

        Else
            Button24.Visible = False
            Button20.Visible = True
            Button25.Visible = False
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TabControle.SelectTab(5)
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        TabControle.SelectTab(4)
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        TabControle.SelectTab(6)
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click



        If Trim(IETextBox.Text) = "" Then

            Dim CNPJ As String = CNPJMaskedTextBox.Text
            CNPJ = CNPJ.Replace("/", "").Replace(".", "-")

            Clipboard.SetText(CNPJ)
            MsgBox("CNPJ copiado e abrindo site para consulta IE", MsgBoxStyle.Information, "Prince Sistemas Informa!")

            System.Diagnostics.Process.Start("https://www.arinternet.pr.gov.br/cadicms/lecadicms.asp?eCad=")

        Else
            '  Clipboard.SetText(CNPJMaskedTextBox.Text)
            ' MsgBox("CNPJ copiado e abrindo site para consulta completa", MsgBoxStyle.Information, "Prince Sistemas Informa!")

            System.Diagnostics.Process.Start("https://www.arinternet.pr.gov.br/cadicms/lecadicms.asp?eCad=" + IETextBox.Text)


        End If


    End Sub

    Private Sub IEjuntaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IEjuntaComboBox.SelectedIndexChanged
        If IEjuntaComboBox.Text = "Vinculado na Junta Comercial" Then
            GroupBox12.Visible = False
            Button33.Visible = True


        Else
            GroupBox12.Visible = True
            Button33.Visible = False

        End If
    End Sub

    Private Sub BombeiroJuntaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BombeiroJuntaComboBox.SelectedIndexChanged
        If BombeiroJuntaComboBox.Text = "Vinculado na Junta Comercial" Then

            Button32.Visible = False

        Else

            Button32.Visible = True
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Try
            Dim a As DateTime
            a = ProtJuntaFinalMaskedTextBox.Text

            'just show time only
            ' MsgBox(a.ToLongTimeString)

            'just show date only
            MsgBox(a.ToLongDateString)

        Catch
            MessageBox.Show(" Data está vazia! ", "Prince Ajuda")
        End Try
    End Sub



    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click

        Call ConexaoLaudo()

    End Sub


    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        TabControle.SelectTab(2)

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click


        If Trim(CNPJMaskedTextBox.Text) = "" Then

            MsgBox("O Campo CNPJ está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        Else

            Dim CNPJ As String = CNPJMaskedTextBox.Text

            Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
            ' MsgBox("CNPJ Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        End If


    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click

        TabControle.SelectTab(1)
        TabControl2.SelectTab(0)
        If Trim(CPFResponsavelMaskedTextBox.Text) = "" Then

            MsgBox("O Campo CPF está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            TabControle.SelectTab(5)
        Else

            Dim CPF As String = CPFResponsavelMaskedTextBox.Text

            Clipboard.SetText(CPF.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
            TabControle.SelectTab(5)
            ' MsgBox("CPF Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        End If


    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click


        If Trim(CodigoSimplesTextBox.Text) = "" Then

            MsgBox("O Campo Código do Simples Nacional está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        Else

            Dim CodSimples As String = CodigoSimplesTextBox.Text

            Clipboard.SetText(CodSimples.Replace("/", "").Replace(",", "").Replace("-", "").Replace(" ", ""))
            ' MsgBox("Código do Simples Nacional Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        End If



    End Sub
    Private Sub BtnCopiaDataDeNasc_Click(sender As Object, e As EventArgs) Handles BtnCopiaDataDeNasc.Click

        TabControle.SelectTab(1)
        TabControl2.SelectTab(0)
        If Trim(RespDataNascMaskedTextBox.Text) = "" Then

            MsgBox("O Campo Data de Nascimento está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            TabControle.SelectTab(5)
        Else

            Dim DATANASC As String = RespDataNascMaskedTextBox.Text

            Clipboard.SetText(DATANASC.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", ""))
            TabControle.SelectTab(5)
        End If


    End Sub


    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click

        TabControle.SelectTab(1)
        TabControl2.SelectTab(0)
        If Trim(TituloeleitorTextBox.Text) = "" Then

            MsgBox("O Campo Título de Eleitor está vazio!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            TabControle.SelectTab(5)
        Else

            Dim TituloDeEleitor As String = TituloeleitorTextBox.Text

            Clipboard.SetText(TituloDeEleitor.Replace("/", "").Replace(",", "").Replace("-", "").Replace(" ", ""))
            TabControle.SelectTab(5)
            ' MsgBox("Título de Eleitor Copiado!", MsgBoxStyle.Information, "Prince Sistemas Informa!")
        End If
    End Sub

    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked

        System.Diagnostics.Process.Start("https://www8.receita.fazenda.gov.br/SimplesNacional/controleAcesso/Autentica.aspx?id=39")

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim Arquivo As String
        Dim Local As String

        'GetDirectoryName pega o diretorio apenas e nao o arquivo
        Try
            MsgBox("Selecione um arquivo para salvar o local da Pasta", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            OpenFileDialog1.ShowDialog()


            Arquivo = OpenFileDialog1.SafeFileName
            Local = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName)

            PastaDocumentosTextBox.Text = Local




        Catch ex As Exception
            MsgBox("ERRO, Selecione algum arquivo para salvar o local da pasta", MsgBoxStyle.Critical, "Prince Sistemas")
            PastaDocumentosTextBox.Text = ""
        End Try
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Try
            System.Diagnostics.Process.Start(PastaDocumentosTextBox.Text)
        Catch
            MsgBox("Campo Vazio", MsgBoxStyle.Critical, "Prince Sistemas")
            ' MessageBox.Show("Campo Vazio", "Prince Alerta")
        End Try
    End Sub

    Private Sub BtnAlteracao_Click(sender As Object, e As EventArgs) Handles BtnAlteracao.Click


        If MsgBox("Limpar o Procedimento e salvar no Histórico?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then

            TabControle.SelectTab(0)
            TabControle.SelectTab(2)
            TabControle.SelectTab(3)
            TabControle.SelectTab(4)
            TabControle.SelectTab(7)




            Try
                Dim A = NAlteracaoComboBox.Text.ToString()
                Dim B = ProcessoComboBox.Text.ToString()
                Dim C = EmpCriadoMaskedTextBox.Text.ToString()
                Dim D = MotivoRichTextBox.Text.ToString()
                Dim F = ProtocoloJuntaComercialTextBox.Text.ToString()
                Dim G = ProtocoloREDESIMTextBox.Text.ToString()


                HistoricoRichTextBox.SelectedText &=
"Histórico anterior, Salvo Dia: " & Format(Now, "dd/MM/yyyy") & " as " & Format(Now, "HH:mm") & ", com as seguintes informações:
Processo :  " & A & " " & B & ". 
Iniciado o processo em: " & C & ". 
Motivo: " & D & ".
Protocolo Junta Comercial= " & F & ".
Protocolo RedeSim= " & G & ".

//-----------------//-----------------//-----------------//-----------------//
"



                MessageBox.Show("Dados Principais Salvo no Histórico", "Prince Avisa")
                'Corpo
                ProcessoComboBox.Text = ""
                EmpCriadoMaskedTextBox.Text = ""
                MotivoRichTextBox.Text = ""
                NAlteracaoComboBox.Text = ""
                StatusComboBox.Text = ""

                'Geral
                GeralRichTextBox.Text = ""
                ProcedimentoRichTextBox.Text = ""
                AvisarDiaMaskedTextBox.Text = ""

                'Junta Comercial
                DataProtJuntaComercialMaskedTextBox.Text = ""
                ProtocoloJuntaComercialTextBox.Text = ""
                ProtJuntaFinalMaskedTextBox.Text = ""
                JuntaObsRichTextBox.Text = ""

                'RedeSim
                DataProtREDESIMMaskedTextBox.Text = ""
                ProtocoloREDESIMTextBox.Text = ""
                RedeSimObsRichTextBox.Text = ""

                'Estadual
                IEjuntaComboBox.Text = ""
                DataPedidoIEMaskedTextBox.Text = ""
                IEInicioAtividadeMaskedTextBox.Text = ""
                IEComprovanteTextBox.Text = ""
                IEVencPedidoMaskedTextBox.Text = ""
                EstadualObsRichTextBox.Text = ""

                'procedimentos
                StatusComboBox.SelectedIndex = -1
                ProcessoComboBox.SelectedIndex = -1

                'Preencher data
                EmpCriadoMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
                AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()

                LembreteCheckBox.CheckState = CheckState.Unchecked
                PrioridadeCheckBox.CheckState = CheckState.Unchecked


                SistemaExternoComboBox.SelectedIndex = 1

            Catch ex As System.InvalidCastException
                MessageBox.Show("ERRO", "Prince Avisa")

            End Try

        Else

        End If


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TabControle.SelectTab(0)
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        System.Diagnostics.Process.Start("http://www.tse.jus.br/eleitor/titulo-e-local-de-votacao/consulta-por-nome")

    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        PastaDocumentosTextBox.Text = ""
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        ArquivoContratoTextBox.Text = ""
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Dim CNPJ As String = CNPJMaskedTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '

    End Sub

    Private Sub LinkLabel12_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel12.LinkClicked
        System.Diagnostics.Process.Start("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/alteracao-cadastral")
    End Sub

    Private Sub LinkLabel8_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel8.LinkClicked
        System.Diagnostics.Process.Start("https://www.gov.br/empresas-e-negocios/pt-br/redesim/abra-sua-pessoa-juridica")

    End Sub

    Private Sub LinkLabel13_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel13.LinkClicked
        System.Diagnostics.Process.Start("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/consulta.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")

    End Sub

    Private Sub LinkLabel14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel14.LinkClicked
        System.Diagnostics.Process.Start("http://www.receita.fazenda.gov.br/PessoaJuridica/CNPJ/fcpj/cancela.asp?_ga=2.182421287.1840779760.1611238476-1712582906.1584021811")

    End Sub

    Private Sub LinkLabel15_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel15.LinkClicked
        System.Diagnostics.Process.Start("https://www.gov.br/empresas-e-negocios/pt-br/redesim/ja-possuo-pessoa-juridica/baixa")

    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Dim CNPJ As String = CPFResponsavelMaskedTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(CNPJ.Replace("/", "").Replace(",", "").Replace("-", "").Replace(".", "")) '

    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        If Application.OpenForms.OfType(Of FrmProcuracao)().Count() > 0 Then

            FrmProcuracao.Focus()
            FrmProcuracao.Close()
            FrmProcuracao.Show()

        Else

            FrmProcuracao.Show()

        End If
    End Sub

    Private Sub LinkLabel16_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel16.LinkClicked
        MessageBox.Show(" Anúncio por 03 ( três) dias em jornal ou (3 vias) da declaração de extravio registrada em cartório - conforme modelo", "Prince Ajuda")
    End Sub


    Private Sub BtnVerEventos_Click(sender As Object, e As EventArgs) Handles BtnVerEventos.Click, Button48.Click, Button47.Click
        TabControle.SelectTab(0)

    End Sub

    Private Sub BtnListaEventos_Click(sender As Object, e As EventArgs) Handles BtnListaEventos.Click
        If Application.OpenForms.OfType(Of FrmEventos)().Count() > 0 Then
            FrmEventos.Focus()
        Else
            FrmEventos.Show()
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click

        'limpar

        MotivoRichTextBox.Clear()


    End Sub

    Private Sub NomeFantasiaTextBox_TextChanged(sender As Object, e As EventArgs) Handles NomeFantasiaTextBox.TextChanged
        Try
            NomeFantasiaTextBox1.Text = NomeFantasiaTextBox.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub NomeFantasiaTextBox1_TextChanged(sender As Object, e As EventArgs) Handles NomeFantasiaTextBox1.TextChanged
        Try
            NomeFantasiaTextBox.Text = NomeFantasiaTextBox1.Text

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnCopiarSenhaGov_Click(sender As Object, e As EventArgs) Handles BtnCopiarSenhaGov.Click
        Dim Senha As String = SenhaGovTextBox.Text
        'CNPJ = CNPJ.Replace("/", ",").Replace(".", "-")
        Clipboard.SetText(Senha) '
    End Sub



    Private Sub Editar()
        If BtnEditar.Text = "Editar" Then
            BtnEditar.Text = "Cancelar"
            GroupBox2.Enabled = True
            GroupBox10.Enabled = True

            BtnExcluir.Enabled = False

            BtnAlteracao.Enabled = True

        ElseIf BtnEditar.Text = "Cancelar" Then

            BtnEditar.Text = "Editar"
            GroupBox2.Enabled = False
            GroupBox10.Enabled = False

            Dim NomeEmpresa As String = RazaoSocialTextBox.Text
            Salvar()
            ComboBoxBuscaEmpresa.Text = NomeEmpresa
            ComboBoxBuscaEmpresa.Focus()
            RazaoSocialTextBox.Focus()

            BtnExcluir.Enabled = True
            BtnAlteracao.Enabled = False
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Editar()


    End Sub

    Private Sub NovaRazaoSocialComboBox_TextChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocialComboBox.TextChanged
        ' RazaoSocialTextBox
        ' NovaRazaoSocialFinalTextBox

        Select Case NovaRazaoSocialComboBox.Text'.Trim()
            Case "Abertura"
                ' RazaoSocialLabel.BackColor = System.Drawing.Color.Green
                ' If NovaRazaoSocialFinalTextBox.Text = NovaRazaoSocialFinalTextBox.Text Then

                'RazaoSocialLabel.ForeColor = System.Drawing.Color.Black
                'PictureBox6.Image = My.Resources.V
                ' Else
                RazaoSocialLabel.ForeColor = System.Drawing.Color.Red
                PictureBox6.Image = My.Resources._Stop
                ' End If
                LabelNovaRazaoFinal.Visible = True
                NovaRazaoSocialFinalTextBox.Visible = True
                LinkLabelMudarRazaoSocial.Visible = True


            Case "Alteração"

                RazaoSocialLabel.ForeColor = System.Drawing.Color.Red
                PictureBox6.Image = My.Resources.refresh_512

                LabelNovaRazaoFinal.Visible = True
                NovaRazaoSocialFinalTextBox.Visible = True
                LinkLabelMudarRazaoSocial.Visible = True


            Case "Não Mudar"
                'RazaoSocialLabel.BackColor = System.Drawing.Color.Green
                RazaoSocialLabel.ForeColor = System.Drawing.Color.Black

                PictureBox6.Image = My.Resources.V

                LabelNovaRazaoFinal.Visible = False
                NovaRazaoSocialFinalTextBox.Visible = False
                LinkLabelMudarRazaoSocial.Visible = True

            Case Else


                'RazaoSocialLabel.BackColor = System.Drawing.Color.Green
                RazaoSocialLabel.ForeColor = System.Drawing.Color.Black
                PictureBox6.Image = My.Resources.V

                LabelNovaRazaoFinal.Visible = False
                NovaRazaoSocialFinalTextBox.Visible = False
                LinkLabelMudarRazaoSocial.Visible = False
        End Select

    End Sub

    Private Sub ProtocoloJuntaComercialTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProtocoloJuntaComercialTextBox.TextChanged
        If ProtocoloJuntaComercialTextBox.Text = "" Then

            BtnConsultaJunta.Text = "Solicitar"

        Else
            BtnConsultaJunta.Text = "Consultar"
        End If
    End Sub

    Private Sub LinkLabel17_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelMudarRazaoSocial.LinkClicked
        RazaoSocialTextBox.Text = NovaRazaoSocialFinalTextBox.Text
    End Sub

    Private Sub ProtocoloREDESIMTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProtocoloREDESIMTextBox.TextChanged
        'BtnConsultaRedeSim

        If ProtocoloREDESIMTextBox.Text = "" Then

            BtnConsultaRedeSim.Text = "Solicitar"

        Else
            BtnConsultaRedeSim.Text = "Consultar"
        End If
    End Sub


    Private Sub IETipoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IETipoComboBox.SelectedIndexChanged

        Select Case IETipoComboBox.Text
            Case "Abertura"
                DatadeInicioIE.Visible = True
                IEInicioAtividadeMaskedTextBox.Visible = True

            Case "Alteração"
                DatadeInicioIE.Visible = False
                IEInicioAtividadeMaskedTextBox.Visible = False

            Case "Baixa"
                DatadeInicioIE.Visible = False
                IEInicioAtividadeMaskedTextBox.Visible = False

            Case "Reativação"
                DatadeInicioIE.Visible = True
                IEInicioAtividadeMaskedTextBox.Visible = True

        End Select

    End Sub

    Private Sub CnaeSimples_Click(sender As Object, e As EventArgs) Handles CnaeSimples.Click
        System.Diagnostics.Process.Start("https://www.contabeis.com.br/ferramentas/simples-nacional/")
    End Sub

    Private Sub BtnData1_Click(sender As Object, e As EventArgs) Handles BtnData1.Click
        AvisarDiaMaskedTextBox.Text = DateTime.Now.ToString()
    End Sub

    Private Sub BtnData2_Click(sender As Object, e As EventArgs) Handles BtnData2.Click
        DataProtJuntaComercialMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub BtnData3_Click(sender As Object, e As EventArgs) Handles BtnData3.Click
        ProtJuntaFinalMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()

        StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact("Junta Comercial - Protocolado")

    End Sub

    Private Sub BtnData4_Click(sender As Object, e As EventArgs) Handles BtnData4.Click
        DataProtREDESIMMaskedTextBox.Text = DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString()
    End Sub

    Private Sub BtnConsultaeProcessoEstado_Click(sender As Object, e As EventArgs) Handles BtnConsultaeProcessoEstado.Click

        If Trim(IEeProcNumTextBox.Text) = "" Then
            MsgBox("abrindo site para solicitação...", MsgBoxStyle.Information, "Prince Sistemas Informa!")
            System.Diagnostics.Process.Start("https://www.eprotocolo.pr.gov.br/spiweb/telaInicial.do?action=iniciarProcesso")

        Else
            System.Diagnostics.Process.Start("https://www.eprotocolo.pr.gov.br/spiweb/consultarProtocoloDigital.do?action=pesquisar&numeroProtocolo=" + IEeProcNumTextBox.Text)


        End If
    End Sub

    Private Sub IEeProcNumTextBox_TextChanged(sender As Object, e As EventArgs) Handles IEeProcNumTextBox.TextChanged
        If Trim(IEeProcNumTextBox.Text) = "" Then
            BtnConsultaeProcessoEstado.Text = "Solicitar"

        Else
            BtnConsultaeProcessoEstado.Text = "Consultar"

        End If
    End Sub


    Private Sub AjudaSimples()
        MessageBox.Show(" 2.8. A ME ou a EPP que iniciar sua atividade em outro mês que não o de janeiro poderá optar pelo Simples Nacional?
Após efetuar a inscrição no CNPJ, bem como obter as suas inscrições municipal e estadual, caso exigível (ver Pergunta 2.11), se quiser que a opção pelo Simples Nacional produza efeitos retroativos à abertura do CNPJ, a ME ou a EPP precisa observar ao mesmo tempo dois prazos para solicitá-la:
-> até 30 dias contados do último deferimento de inscrição (seja a estadual ou a municipal), e 
-> para empresas com data de abertura constante no CNPJ:
   *o até 31 de dezembro de 2020: até 180 dias contados da inscrição no CNPJ; ou 
   *o a partir de 1º de janeiro de 2021: até 60 dias contados da inscrição no CNPJ.

    Observações:
 Os prazos não são somados. Ou seja, não existe um prazo de 210 dias contados da inscrição no CNPJ para empresas abertas até 2020, nem um
prazo de 90 dias para empresas abertas a partir de 2021.
 A inscrição municipal é sempre exigível. A inscrição estadual é exigida para a empresa que exerça atividades sujeitas ao ICMS 

    Após o fim desse prazo para opção como empresa em início de atividade, a opção somente será possível no mês de janeiro do ano-calendário seguinte, produzindo efeitos a partir desse mês e não mais desde a abertura do CNPJ

(Base normativa: art. 2º, IV, art. 6º, § 5º, I, da Resolução CGSN nº 140, de 2018; art. 5º da Resolução CGSN nº 150, de 2019; art. 2º da Resolução CGSN nº 155, de 2020.) ", "Prince Ajuda")
    End Sub
    Private Sub LinkLabel17_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel17.LinkClicked
        AjudaSimples()

    End Sub



    Private Sub SistemaExternoComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SistemaExternoComboBox.SelectedIndexChanged
        SistemaExternoComboBox.Font = New Font(SistemaExternoComboBox.Font, FontStyle.Bold)


        If Me.SistemaExternoComboBox.Text = "Sim" Then
            Me.SistemaExternoComboBox.BackColor = Color.Green
            'Me.SistemaExternoComboBox.Font = Ita
            Me.SistemaExternoComboBox.ForeColor = Color.White
            PictureBoxSistemaExterno.Image = My.Resources.check



        End If


        If Me.SistemaExternoComboBox.Text = "Não" Then
            Me.SistemaExternoComboBox.BackColor = Color.Red
            ' Me.SistemaExternoComboBox.Font = Bold
            Me.SistemaExternoComboBox.ForeColor = Color.White
            PictureBoxSistemaExterno.Image = My.Resources.Cancel

        End If
    End Sub

    Private Sub RegimeFederalComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegimeFederalComboBox.SelectedIndexChanged
        '        RegimeFederalComboBox.Font = New Font(RegimeFederalComboBox.Font, FontStyle.Bold)

        If RegimeFederalComboBox.Text = "Pendência" Then
            RegimeFederalComboBox.BackColor = Color.Yellow
            RegimeFederalComboBox.ForeColor = Color.Black


        Else
            RegimeFederalComboBox.BackColor = Color.Green
            RegimeFederalComboBox.ForeColor = Color.White


        End If
    End Sub

    Private Sub BtnAdicionarSocio_Click(sender As Object, e As EventArgs) Handles BtnAdicionarSocio.Click
        If QuantidadeSociosTextBox.Text = "" Then
            QuantidadeSociosTextBox.Text = "1"
        Else
            QuantidadeSociosTextBox.Text = QuantidadeSociosTextBox.Text + 1
        End If

        DadosSociosRichTextBox.SelectedText &=
" Sócio Nº " & QuantidadeSociosTextBox.Text & "  //////////////////////////////////////////////////////////

Nome Completo =
Solteiro(a)? =
Data de nascimento =
. . . Endereço residencial . . .
Rua =
Nº =
Bairro =
CEP = 
Cidade/Estado =
RG =
Orgão Emissor/Estado = 
CPF = 

////////////////////////////////////////////////
"

    End Sub

    Private Sub BtnLimparSocio_Click(sender As Object, e As EventArgs) Handles BtnLimparSocio.Click
        If QuantidadeSociosTextBox.Text = "" Then
            QuantidadeSociosTextBox.Text = "0"
        Else
            QuantidadeSociosTextBox.Text = QuantidadeSociosTextBox.Text - 1

        End If

        If QuantidadeSociosTextBox.Text < "0" Then
            QuantidadeSociosTextBox.Text = "0"
        End If
    End Sub



    Private Sub BtnLimparSocios_Click(sender As Object, e As EventArgs) Handles BtnLimparSocios.Click
        If MsgBox("Deseja limpar todos Sócios?", MsgBoxStyle.YesNo, "Salvar") = MsgBoxResult.Yes Then
            DadosSociosRichTextBox.Text = ""
            QuantidadeSociosTextBox.Text = "0"
        End If
    End Sub


    '/////////// Inicio do codigo de mostrar calendario
    '///// TEM MAIS NO LOAD 
    Private Sub AvisarDiaMaskedTextBox_Click(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Click
        Calendar1.Visible = True

        'AvisarDiaMaskedTextBox.Text = Calendar1.SelectionStart.ToShortDateString()
        'Calendar1.Visible = False
    End Sub



    Private Sub AvisarDiaMaskedTextBox_Leave(sender As Object, e As EventArgs) Handles AvisarDiaMaskedTextBox.Leave
        Calendar1.Visible = False

    End Sub

    Private Sub Calendar1_Leave(sender As Object, e As EventArgs) Handles Calendar1.Leave
        Calendar1.Visible = False

    End Sub

    Private Sub Calendar1_MouseLeave(sender As Object, e As EventArgs) Handles Calendar1.MouseLeave
        Calendar1.Visible = False

    End Sub

    Private Sub Calendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar1.DateSelected
        AvisarDiaMaskedTextBox.Text = Calendar1.SelectionStart
        Calendar1.Visible = False
    End Sub


    '/////////// fim do codigo de mostrar calendario

    Private Sub LinkLabel18_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel18.LinkClicked
        System.Diagnostics.Process.Start("https://www8.receita.fazenda.gov.br/simplesnacional/aplicacoes.aspx?id=21")

    End Sub

    Private Sub BtnLocalizar_Click(sender As Object, e As EventArgs) Handles BtnLocalizar.Click
        If Application.OpenForms.OfType(Of FrmAtalhoBuscadores)().Count() > 0 Then

            FrmAtalhoBuscadores.Focus()
            FrmAtalhoBuscadores.Close()
            ' FrmAtalhoBuscadores.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAtalhoBuscadores.Show()
            'Me.Close()

        Else

            'FrmAtalhoBuscadores.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmAtalhoBuscadores.Show()
            ' Me.Close()
        End If
    End Sub

    Private Sub BtnContador_Click(sender As Object, e As EventArgs) Handles BtnContador.Click
        If Application.OpenForms.OfType(Of Contador)().Count() > 0 Then
            Contador.Focus()
            '   Contador.MdiParent = MDIPrincipal

        Else
            ' Contador.MdiParent = MDIPrincipal
            Contador.Show()
        End If
    End Sub

    Private Sub BtnFedJunta_Click(sender As Object, e As EventArgs) Handles BtnFedJunta.Click

        TabControle.SelectTab(2)
        TabControle.SelectTab(3)
        ProtocoloREDESIMTextBox.Text = ProtocoloJuntaComercialTextBox.Text
    End Sub

    Private Sub SistemaExternoComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles SistemaExternoComboBox.SelectionChangeCommitted
        If SistemaExternoComboBox.SelectedIndex = 0 Then
            'selecionar o index 0 que seria o SIM
            SistemaExternoComboBox.Text = "Sim"


            If MsgBox(" Deseja enviar por e-mail toda alteração feita?", MsgBoxStyle.YesNo, "Apagar") = MsgBoxResult.Yes Then

                If Application.OpenForms.OfType(Of FrmMail)().Count() > 0 Then
                    Dim Sair As String
                    Sair = MsgBox("O e-Mail ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

                    FrmMail.MdiParent = MDIPrincipal
                    FrmMail.Show()



                    'abrir a automação
                    ModeMail.Enviaremaillegalizao()

                Else

                    FrmMail.MdiParent = MDIPrincipal
                    FrmMail.Show()
                    ModeMail.Enviaremaillegalizao()

                End If
            End If
        End If
    End Sub

    Private Sub ButtoneMail_Click(sender As Object, e As EventArgs) Handles ButtoneMail.Click
        If Application.OpenForms.OfType(Of FrmMail)().Count() > 0 Then

            FrmMail.Focus()
            FrmMail.Close()
            FrmMail.MdiParent = MDIPrincipal
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmMail.Show()


        Else

            FrmMail.MdiParent = MDIPrincipal
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmMail.Show()

        End If
    End Sub

    Private Sub NovaRazaoSocialComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NovaRazaoSocialComboBox.SelectedIndexChanged
        'RazaoSocialTextBox.Text = NovaRazaoSocialFinalTextBox.Text
        'LinkLabel17
        If NovaRazaoSocialComboBox.Text = "Sim" Then
            NovaRazaoSocialFinalTextBox.Visible = True
            LinkLabel17.Visible = True
            LabelNovaRazaoFinal.Visible = True
            LinkLabelMudarRazaoSocial.Visible = True

        Else
            NovaRazaoSocialFinalTextBox.Visible = False
            LinkLabel17.Visible = False
            LabelNovaRazaoFinal.Visible = False
            LinkLabelMudarRazaoSocial.Visible = False
        End If


    End Sub

    Private Sub BtnAnotacoesLEgalizacao_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesLEgalizacao.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()

        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Legalização"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Legalizacao"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesFederal_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesFederal.Click, BtnAnotacoesSimples.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()

        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Receita Federal"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Federal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesEstadual_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesEstadual.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()

        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Receita Estadual"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Estadual"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesPrefeitura_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesPrefeitura.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()

        End If

        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Prefeitura Municipal"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Municipal"))
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub BtnAnotacoesDemais_Click(sender As Object, e As EventArgs) Handles BtnAnotacoesDemais.Click
        If Application.OpenForms.OfType(Of FrmAnotacoes)().Count() > 0 Then

            FrmAnotacoes.Focus()
            FrmAnotacoes.Close()
            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()
            FrmAnotacoes.Focus()

        Else

            FrmAnotacoes.MdiParent = MDIPrincipal
            FrmAnotacoes.Show()

        End If
        Try
            FrmAnotacoes.RichTextBoxAnotacao.Visible = True
            FrmAnotacoes.lblMudaTexto.Visible = True

            FrmAnotacoes.lblMudaTexto.Text = "Demais Assuntos"
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Clear()
            FrmAnotacoes.RichTextBoxAnotacao.DataBindings.Add(New Binding("RTF", FrmAnotacoes.AnotacoesBindingSource, "Demais"))
        Catch ex As Exception
            MsgBox("Erro! " & vbCrLf & ex.Message)
        End Try

    End Sub




    'anexar documento

    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private ReadOnly da As SqlDataAdapter
    Private dr As SqlDataReader
    Private Sub BtnSalvarDoc_Click(sender As Object, e As EventArgs) Handles BtnSalvarDoc.Click

        'procurar e salvar no banco de dados DocContratos varbinary aray    
        Dim dialogo As New OpenFileDialog With {
            .Filter = "Arquivos de Texto (*.doc, *.docx)|*.doc;*.docx",
            .Title = "Selecione o arquivo de texto",
            .InitialDirectory = "C:\"
        }
        dialogo.ShowDialog()
        'DocContratosLinkLabel.Text = dialogo.FileName
        'salvar no banco de dados SQL SERVER Banco Empresas varbinary aray
        Try
            conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
            'tabela empresas e coluna DocContratos por razao social
            comando = New SqlCommand("UPDATE Empresas SET DocContratos = @DocContratos WHERE RazaoSocial = @RazaoSocial", conexao)
            comando.Parameters.Add("@DocContratos", SqlDbType.VarBinary).Value = File.ReadAllBytes(dialogo.FileName)
            comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
            conexao.Open()
            comando.ExecuteNonQuery()
            conexao.Close()
            MsgBox("Documento salvo com sucesso!")
            'coloca no listview apenas icone e nome
            Dim item As New ListViewItem With {
                .Text = dialogo.SafeFileName,
                .ImageIndex = 0
            }
            'adiciona no listview
            ListViewDocContratos.Items.Add(item)


        Catch ex As Exception
            MsgBox("Erro! " & vbCrLf & ex.Message)
        End Try

    End Sub

    Private Sub BtnAbrirDoc_Click(sender As Object, e As EventArgs) Handles BtnAbrirDoc.Click
        'save a file in .docx format, which was saved as VarBinary, in the database table companies and column DocContratos for corporate reasons
        Try
            conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
            comando = New SqlCommand("SELECT DocContratos FROM Empresas WHERE RazaoSocial = @RazaoSocial", conexao)
            comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
            conexao.Open()
            'SqlDataReader

            dr = comando.ExecuteReader
            If dr.Read Then

                Dim doc As Byte() = DirectCast(dr("DocContratos"), Byte())
                'opendialog  para salvar o arquivo FileStream do banco de dados
                'mudar local de salvamento do doc
                Dim saveFileDialog1 As New SaveFileDialog With {
                    .Filter = "Arquivos de Texto (*.doc, *.docx)|*.doc;*.docx",
                    .Title = "Salvar Arquivo de Texto"
                }
                saveFileDialog1.ShowDialog()
                Dim fs As New FileStream(saveFileDialog1.FileName, FileMode.Create)

                ' Dim fs As New FileStream("D:\teste.docx", FileMode.Create)
                'escreve o arquivo no banco de dados
                fs.Write(doc, 0, doc.Length)
                'fecha o arquivo
                fs.Close()
                'perguntas antes de abrir o arquivo
                Dim result As DialogResult = MessageBox.Show("Deseja abrir o arquivo?", "Abrir Arquivo", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Process.Start(saveFileDialog1.FileName)
                End If
            End If
            conexao.Close()
        Catch ex As Exception
            MsgBox("Erro! " & vbCrLf & ex.Message)
        End Try


    End Sub




    Private Sub BtnApagaAnexo_Click(sender As Object, e As EventArgs) Handles BtnApagaAnexo.Click
        'clear a file in .docx format, which was saved as VarBinary, in the database table companies and column DocContratos for corporate reasons
        'perguntar se deseja apagar
        Dim result As DialogResult = MessageBox.Show("Deseja apagar o arquivo?", "Apagar Arquivo", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Try
                conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
                comando = New SqlCommand("UPDATE Empresas SET DocContratos = @DocContratos WHERE RazaoSocial = @RazaoSocial", conexao)
                comando.Parameters.Add("@DocContratos", SqlDbType.VarBinary).Value = Nothing
                comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
                conexao.Open()
                comando.ExecuteNonQuery()
                conexao.Close()
                MsgBox("Documento apagado com sucesso!")
                BtnAbrirDoc.Enabled = False
                BtnSalvarDoc.Enabled = False
                PictureBox7.Image = My.Resources.off
                PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
            Catch ex As Exception
                MsgBox("Erro! " & vbCrLf & ex.Message)
            End Try
        End If

    End Sub

    Private Sub ListViewDocContratos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewDocContratos.SelectedIndexChanged
        'abrir arquivo anexado no  banco de dados DocContratos conforme a razaosocial
        Try
            conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
            comando = New SqlCommand("SELECT DocContratos FROM Empresas WHERE RazaoSocial = @RazaoSocial", conexao)
            comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
            conexao.Open()
            'SqlDataReader

            dr = comando.ExecuteReader
            If dr.Read Then

                Dim doc As Byte() = DirectCast(dr("DocContratos"), Byte())
                'opendialog  para salvar o arquivo FileStream do banco de dados
                'mudar local de salvamento do doc
                Dim saveFileDialog1 As New SaveFileDialog With {
                    .Filter = "Arquivos de Texto (*.doc, *.docx)|*.doc;*.docx",
                    .Title = "Salvar Arquivo de Texto"
                }
                saveFileDialog1.ShowDialog()
                Dim fs As New FileStream(saveFileDialog1.FileName, FileMode.Create)

                ' Dim fs As New FileStream("D:\teste.docx", FileMode.Create)
                'escreve o arquivo no banco de dados
                fs.Write(doc, 0, doc.Length)
                'fecha o arquivo
                fs.Close()
                'perguntas antes de abrir o arquivo
                Dim result As DialogResult = MessageBox.Show("Deseja abrir o arquivo?", "Abrir Arquivo", MessageBoxButtons.YesNo)
                If result = DialogResult.Yes Then
                    Process.Start(saveFileDialog1.FileName)
                End If
            End If
            conexao.Close()
        Catch ex As Exception
            MsgBox("Erro! " & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub TabControl1_Enter(sender As Object, e As EventArgs) Handles TabControl1.Enter
        'mostra na  listview o DocContratos de acordo com a a razão social
        Try
            conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
            comando = New SqlCommand("SELECT DocContratos FROM Empresas WHERE RazaoSocial = @RazaoSocial", conexao)
            comando.Parameters.Add("@RazaoSocial", SqlDbType.VarChar).Value = RazaoSocialTextBox.Text
            conexao.Open()
            'SqlDataReader

            dr = comando.ExecuteReader
            'colocar na listview o doccontratos




            conexao.Close()
        Catch ex As Exception
            MsgBox("Erro! " & vbCrLf & ex.Message)
        End Try


    End Sub
End Class
