Imports System.Data.SqlClient
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
        Dim comando As New SqlCommand("INSERT INTO Usuarios (Usuario, Senha, NomeCompleto, Tema) VALUES (@Usuario, @Senha, @NomeCompleto, @Tema)", conexao)
        comando.Parameters.AddWithValue("@Usuario", UsuarioTextBox.Text)
        comando.Parameters.AddWithValue("@Senha", SenhaTextBox.Text)
        comando.Parameters.AddWithValue("@NomeCompleto", NomeCompletoTextBox.Text)
        comando.Parameters.AddWithValue("@Tema", TemaComboBox.Text)
        conexao.Open()
        'verifica campos vazios
        If UsuarioTextBox.Text = "" Or SenhaTextBox.Text = "" Or NomeCompletoTextBox.Text = "" Or TemaComboBox.Text = "" Then
            MsgBox("Preencha todos os campos!")
        Else
            comando.ExecuteNonQuery()
            MsgBox("Usuário criado com sucesso!")
            conexao.Close()
        End If


    End Sub
End Class
