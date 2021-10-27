﻿Imports System.Windows.Forms

Public Class MDIPrincipal



    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
        Login.Close()
    End Sub



    Private Sub ControleLegalizaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleLegalizaçãoToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of Legalizacao)().Count() > 0 Then
            '  Dim Sair As String
            '  Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

            Legalizacao.Focus()
            ' Legalizacao.MdiParent = Me



        Else

            ' Legalizacao.MdiParent = Me
            Legalizacao.Show()


        End If

    End Sub

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chama validação da expiração
        Call ModData.FimData()
        Call ModData.Valida()
        'continua

        Me.WindowState = FormWindowState.Maximized

        'fundo padrao inicial
        Me.BackgroundImage = My.Resources.FundoNovo





        VbAvisoPrincipal.MdiParent = Me
        vbAvisoPrincipal.Show()





        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        'Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        'Me.BackgroundImage = My.Resources.FundoNovo

        'ToolStripComboBox1.Text = "Padrão"


        'Me.BackgroundImage = Global.myapp.My.Resources.Resources.Test_pp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch


        'Mudança do MENU COR
        ToolStrip.ForeColor = Color.Black
        ToolStrip.BackColor = Color.White


        MenuStrip.ForeColor = Color.Black
        MenuStrip.BackColor = Color.White



        'COR MENU PRINCIPAÇ
        MenuToolStripMenuItem.ForeColor = Color.Black
        EmpresasToolStripMenuItem.ForeColor = Color.Black
        AlvaráToolStripMenuItem.ForeColor = Color.Black
        TelefonesToolStripMenuItem.ForeColor = Color.Black
        ConsultaToolStripMenuItem.ForeColor = Color.Black
        RelatóriosToolStripMenuItem.ForeColor = Color.Black
        AgendaToolStripMenuItem.ForeColor = Color.Black
        HelpMenu.ForeColor = Color.Black


        MenuToolStripMenuItem.BackColor = Color.White
        EmpresasToolStripMenuItem.BackColor = Color.White
        AlvaráToolStripMenuItem.BackColor = Color.White
        TelefonesToolStripMenuItem.BackColor = Color.White
        ConsultaToolStripMenuItem.BackColor = Color.White
        RelatóriosToolStripMenuItem.BackColor = Color.White
        AgendaToolStripMenuItem.BackColor = Color.White
        HelpMenu.BackColor = Color.White

        'MENU  BARRA 2
        ToolStripButton1.ForeColor = Color.Black
        ToolStripButton2.ForeColor = Color.Black
        ToolStripButton3.ForeColor = Color.Black
        ToolStripButton4.ForeColor = Color.Black

        ToolStripButton1.BackColor = Color.White
        ToolStripButton2.BackColor = Color.White
        ToolStripButton3.BackColor = Color.White
        ToolStripButton4.BackColor = Color.White


        'MUDANÇA DE CORES

        'Menu
        SairToolStripMenuItem1.ForeColor = Color.Black

        'Empresas
        ControleLegalizaçãoToolStripMenuItem.ForeColor = Color.Black

        'Laudos
        LaudosGeralToolStripMenuItem.ForeColor = Color.Black
        OrToolStripMenuItem.ForeColor = Color.Black

        'Contatos
        ContatosToolStripMenuItem.ForeColor = Color.Black

        'Consulta
        ProtocoladosToolStripMenuItem.ForeColor = Color.Black
        'EmpresasPendênteToolStripMenuItem.ForeColor = Color.Black
        VencimentoAlvaráToolStripMenuItem.ForeColor = Color.Black
        'AlvarásPendenteToolStripMenuItem.ForeColor = Color.Black
        ControleLigaçãoLaudosToolStripMenuItem.ForeColor = Color.Black
        RegimeFederalToolStripMenuItem.ForeColor = Color.Black

        'Agenda
        TributáriaToolStripMenuItem.ForeColor = Color.Black

        'Relatórios
        EmpresasToolStripMenuItem.ForeColor = Color.Black
        AlvarásLaudosToolStripMenuItem.ForeColor = Color.Black


        'Ajuda
        ContadorToolStripMenuItem.ForeColor = Color.Black
        AboutToolStripMenuItem.ForeColor = Color.Black



        'OUTRA PARTE FUNDO COR

        'Menu
        SairToolStripMenuItem1.BackColor = Color.White

        'Empresas
        ControleLegalizaçãoToolStripMenuItem.BackColor = Color.White

        'Laudos
        LaudosGeralToolStripMenuItem.BackColor = Color.White
        OrToolStripMenuItem.BackColor = Color.White

        'Contatos
        ContatosToolStripMenuItem.BackColor = Color.White

        'Consulta
        ProtocoladosToolStripMenuItem.BackColor = Color.White
        ' EmpresasPendênteToolStripMenuItem.BackColor = Color.White
        VencimentoAlvaráToolStripMenuItem.BackColor = Color.White
        ' AlvarásPendenteToolStripMenuItem.BackColor = Color.White
        ControleLigaçãoLaudosToolStripMenuItem.BackColor = Color.White
        RegimeFederalToolStripMenuItem.BackColor = Color.White

        'Relatórios
        EmpresasToolStripMenuItem.BackColor = Color.White
        AlvarásLaudosToolStripMenuItem.BackColor = Color.White

        'Agenda
        TributáriaToolStripMenuItem.BackColor = Color.White


        'Ajuda
        ContadorToolStripMenuItem.BackColor = Color.White
        AboutToolStripMenuItem.BackColor = Color.White






    End Sub



    Private Sub ContadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContadorToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of Contador)().Count() > 0 Then

            Contador.Focus()
            Contador.MdiParent = Me


        Else

            Contador.MdiParent = Me
            Contador.Show()


        End If
    End Sub

    Private Sub MDIPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ' Me.Close()
        Login.Close()
    End Sub



    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click


        If Application.OpenForms.OfType(Of LembreteInicial)().Count() > 0 Then

            LembreteInicial.Focus()
            LembreteInicial.Close()
            LembreteInicial.MdiParent = Me
            LembreteInicial.Show()

        Else

            LembreteInicial.MdiParent = Me
            LembreteInicial.Show()


        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click

        If Application.OpenForms.OfType(Of vbAvisoPrincipal)().Count() > 0 Then

            vbAvisoPrincipal.Focus()
            vbAvisoPrincipal.Close()
            vbAvisoPrincipal.MdiParent = Me
            vbAvisoPrincipal.Show()

        Else

            vbAvisoPrincipal.MdiParent = Me
            vbAvisoPrincipal.Show()

        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of AboutBox)().Count() > 0 Then

            AboutBox.Focus()
            AboutBox.Close()
            AboutBox.MdiParent = Me
            AboutBox.Show()

        Else

            AboutBox.MdiParent = Me
            AboutBox.Show()

        End If
    End Sub



    Private Sub OrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of Telefones)().Count() > 0 Then

            Telefones.Focus()
            Telefones.Close()
            Telefones.MdiParent = Me
            Telefones.Show()

        Else

            Telefones.MdiParent = Me
            Telefones.Show()

        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click

        If Application.OpenForms.OfType(Of PrioridadeAviso)().Count() > 0 Then

            PrioridadeAviso.Focus()
            PrioridadeAviso.Close()
            PrioridadeAviso.MdiParent = Me
            PrioridadeAviso.Show()

        Else

            PrioridadeAviso.MdiParent = Me
            PrioridadeAviso.Show()

        End If
    End Sub

    Private Sub VencimentosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LaudosGeralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaudosGeralToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
            'fecha o formulario de consulta e depois abre o cadastro
            FrmAlvara.Close()

            If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
                '  Dim Sair As String
                '  Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

                FrmAlvara.Focus()
                ' FrmContatos.MdiParent = MDIMenu


            Else

                'FrmContatos.MdiParent = MDIMenu
                FrmAlvara.Show()


            End If
        Else
            'se nao tiver consulta aberto ele nao faz nd e verifica o cadastro e continua
            If Application.OpenForms.OfType(Of FrmAlvara)().Count() > 0 Then
                '  Dim Sair As String
                '  Sair = MsgBox("O formulário ja está aberto", MsgBoxStyle.Question, "Prince Sistemas Informa!")

                FrmAlvara.Focus()
                ' FrmContatos.MdiParent = MDIMenu


            Else

                'FrmContatos.MdiParent = MDIMenu
                FrmAlvara.Show()


            End If

        End If
    End Sub

    Private Sub ProtocoladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProtocoladosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmProtocolados)().Count() > 0 Then

            FrmProtocolados.Focus()
            FrmProtocolados.Close()
            FrmProtocolados.MdiParent = Me
            FrmProtocolados.Show()

        Else

            FrmProtocolados.MdiParent = Me
            FrmProtocolados.Show()

        End If
    End Sub

    Private Sub VencimentoAlvaráToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VencimentoAlvaráToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of VencimentoAlvara)().Count() > 0 Then

            VencimentoAlvara.Focus()
            VencimentoAlvara.Close()
            VencimentoAlvara.MdiParent = Me
            VencimentoAlvara.Show()

        Else

            VencimentoAlvara.MdiParent = Me
            VencimentoAlvara.Show()

        End If
    End Sub

    Private Sub EmpresasPendênteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Application.OpenForms.OfType(Of FrmEmpresaEmAndamento)().Count() > 0 Then

            FrmEmpresaEmAndamento.Focus()
            FrmEmpresaEmAndamento.Close()
            FrmEmpresaEmAndamento.MdiParent = Me
            FrmEmpresaEmAndamento.Show()

        Else

            FrmEmpresaEmAndamento.MdiParent = Me
            FrmEmpresaEmAndamento.Show()

        End If
    End Sub

    Private Sub AlvarásPendenteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Application.OpenForms.OfType(Of LaudosPendentes)().Count() > 0 Then

            LaudosPendentes.Focus()
            LaudosPendentes.Close()
            LaudosPendentes.MdiParent = Me
            LaudosPendentes.Show()

        Else

            LaudosPendentes.MdiParent = Me
            LaudosPendentes.Show()

        End If
    End Sub


    Private Sub TributáriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TributáriaToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of WebAgenda)().Count() > 0 Then

            WebAgenda.Focus()
            WebAgenda.Close()
            WebAgenda.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            WebAgenda.Show()


        Else

            WebAgenda.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            WebAgenda.Show()

        End If
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If Application.OpenForms.OfType(Of WebAgenda)().Count() > 0 Then

            WebAgenda.Focus()
            WebAgenda.Close()
            WebAgenda.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            WebAgenda.Show()


        Else

            WebAgenda.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            WebAgenda.Show()

        End If
    End Sub

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        'Me.Close()
        'Login.Close()
        Application.Exit()

    End Sub

    Private Sub ControleLigaçãoLaudosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleLigaçãoLaudosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmLigacaoAlvara)().Count() > 0 Then

            FrmLigacaoAlvara.Focus()
            FrmLigacaoAlvara.Close()
            FrmLigacaoAlvara.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmLigacaoAlvara.Show()


        Else

            FrmLigacaoAlvara.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            FrmLigacaoAlvara.Show()

        End If
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of BackupERestore)().Count() > 0 Then

            BackupERestore.Focus()
            BackupERestore.Close()
            BackupERestore.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            BackupERestore.Show()


        Else

            BackupERestore.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            BackupERestore.Show()

        End If
    End Sub

    Private Sub EmpresasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem1.Click
        If Application.OpenForms.OfType(Of RelatorioEmpresas)().Count() > 0 Then

            RelatorioEmpresas.Focus()
            RelatorioEmpresas.Close()
            RelatorioEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelatorioEmpresas.Show()


        Else

            RelatorioEmpresas.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelatorioEmpresas.Show()

        End If
    End Sub

    Private Sub AlvarásLaudosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlvarásLaudosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of RelatorioLaudos)().Count() > 0 Then

            RelatorioLaudos.Focus()
            RelatorioLaudos.Close()
            RelatorioLaudos.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelatorioEmpresas.Show()


        Else

            RelatorioLaudos.MdiParent = Me
            ' WebAgenda.WindowState = FormWindowState.Maximized
            RelatorioLaudos.Show()

        End If
    End Sub

    Private Sub RegimeFederalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegimeFederalToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmRelSimples)().Count() > 0 Then

            FrmRelSimples.Focus()
            FrmRelSimples.Close()
            FrmRelSimples.MdiParent = Me
            FrmRelSimples.Show()


        Else

            FrmRelSimples.MdiParent = Me
            FrmRelSimples.Show()

        End If
    End Sub

    Private Sub ContatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContatosToolStripMenuItem.Click
        If Application.OpenForms.OfType(Of FrmContatos)().Count() > 0 Then

            FrmContatos.Focus()
            FrmContatos.Close()
            FrmContatos.MdiParent = Me
            FrmContatos.Show()


        Else

            FrmContatos.MdiParent = Me
            FrmContatos.Show()

        End If
    End Sub

    Private Sub AlvarásProtocoladosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlvarásProtocoladosToolStripMenuItem.Click

        If Application.OpenForms.OfType(Of RelacaoAlvaraProtocolado)().Count() > 0 Then

            RelacaoAlvaraProtocolado.Focus()
            RelacaoAlvaraProtocolado.Close()
            RelacaoAlvaraProtocolado.MdiParent = Me
            RelacaoAlvaraProtocolado.Show()


        Else

            RelacaoAlvaraProtocolado.MdiParent = Me
            RelacaoAlvaraProtocolado.Show()

        End If
    End Sub


    Private Sub PadrãoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PadrãoToolStripMenuItem1.Click
        Me.BackgroundImage = My.Resources.FundoNovo
        Me.Refresh()
    End Sub

    Private Sub NoiteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NoiteToolStripMenuItem1.Click
        Me.BackgroundImage = My.Resources.noite
        Me.Refresh()
    End Sub

    Private Sub PrevFogoBombeiroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrevFogoBombeiroToolStripMenuItem.Click

        If Application.OpenForms.OfType(Of FrmBombeiro)().Count() > 0 Then

            FrmBombeiro.Focus()
            FrmBombeiro.Close()
            FrmBombeiro.MdiParent = Me
            FrmBombeiro.Show()

        Else

            FrmBombeiro.MdiParent = Me
            FrmBombeiro.Show()

        End If
    End Sub
End Class
