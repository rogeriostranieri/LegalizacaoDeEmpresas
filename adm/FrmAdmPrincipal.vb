﻿Public Class FrmAdmPrincipal

    Private Sub BtnAlterarSenha_Click(sender As Object, e As EventArgs) Handles BtnAlterarSenha.Click

        Label1.Text = "Alterar Senha"
        'abrir UserAltSenha formulario dentro do FlowLayoutPanel1
        FlowLayoutPanel1.Controls.Clear()
        Dim userAltSenha As New UserAltSenha
        FlowLayoutPanel1.Controls.Add(userAltSenha)


    End Sub

    Private Sub BtnAltDados_Click(sender As Object, e As EventArgs) Handles BtnAltDados.Click
        Label1.Text = "Alterar Dados Pessoais"

        'abrir UserAltDados formulario dentro do FlowLayoutPanel1
        FlowLayoutPanel1.Controls.Clear()
        Dim userAltDados As New UserAltDados
        FlowLayoutPanel1.Controls.Add(userAltDados)
    End Sub

    Private Sub BtnNovoUsuario_Click(sender As Object, e As EventArgs) Handles BtnNovoUsuario.Click
        Label1.Text = "Criar Novo Usuário para o Sistema"
        'abrir UserNovo formulario dentro do FlowLayoutPanel1
        FlowLayoutPanel1.Controls.Clear()
        Dim userNovo As New UserNovo
        FlowLayoutPanel1.Controls.Add(userNovo)
    End Sub

    Private Sub FrmAdmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Escolha o Menu lateral"
        'muda picturebox para recursos System.Drawing.Bitmap
        PictureBox1.Image = My.Resources.Pessoais


    End Sub


End Class