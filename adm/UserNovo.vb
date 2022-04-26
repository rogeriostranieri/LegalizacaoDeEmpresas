﻿Imports System.Data.SqlClient
Public Class UserNovo
    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        'limpar os campos do form UserNovo
        UsuarioTextBox.Text = ""
        SenhaTextBox.Text = ""
        NomeCompletoTextBox.Text = ""
        TemaComboBox.Text = ""

    End Sub

    Private Sub BtnCriar_Click(sender As Object, e As EventArgs) Handles BtnCriar.Click
        'Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755
        'criar novo usuario no banco de dados
        Dim conexao As New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")
        Dim comando As New SqlCommand("INSERT INTO Login (Usuario, Senha, NomeCompleto, Tema) VALUES (@Usuario, @Senha, @NomeCompleto, @Tema)", conexao)
        comando.Parameters.AddWithValue("@Usuario", UsuarioTextBox.Text)
        comando.Parameters.AddWithValue("@Senha", SenhaTextBox.Text)
        comando.Parameters.AddWithValue("@NomeCompleto", NomeCompletoTextBox.Text)
        comando.Parameters.AddWithValue("@Tema", TemaComboBox.Text)
        conexao.Open()

        'verifica campos vazios e se não existe usuario com mesmo nome no banco de dados
        If UsuarioTextBox.Text = "" Or SenhaTextBox.Text = "" Or NomeCompletoTextBox.Text = "" Or TemaComboBox.Text = "" Then
            MsgBox("Preencha todos os campos!")
        Else
            'verifica se o usuario nao existe no banco de dados
            Dim comando2 As New SqlCommand("SELECT * FROM Login WHERE Usuario = @Usuario", conexao)
            comando2.Parameters.AddWithValue("@Usuario", UsuarioTextBox.Text)
            Dim leitor As SqlDataReader
            leitor = comando2.ExecuteReader()
            If leitor.HasRows Then
                MsgBox("Usuario ja existe!")
            Else
                leitor.Close()
                comando.ExecuteNonQuery()
                MsgBox("Usuario criado com sucesso!")
            End If

        End If

    End Sub

    Private Sub UserNovo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TemaComboBox.Items.Add("Novo")
        TemaComboBox.Items.Add("Padrão")
        TemaComboBox.Items.Add("Noite")
    End Sub
End Class
