Imports System.Data.SqlClient

Public Class UserADM

    ' TODO: Inserir c�digo para realizar autentica��o personalizada utilizando o nome de usu�rio e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de seguran�a personalizada pode ser anexada � entidade de seguran�a da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal � a implementa��o de IPrincipal usada para realizar a autentica��o. 
    ' Subsequentemente, My.User ir� retornar informa��es de identifica��o encapsuladas num objeto CustomPrincipal
    ' como nome de usu�rio, nome de exibi��o etc.

    Private Sub ConnectToSQL()

        Try
            If UsernameTextBox.Text.Length <= 0 Then
                MessageBox.Show("Digite o nome de Usu�rio!")
            ElseIf PasswordTextBox.Text.Length <= 0 Then
                MessageBox.Show("Digite sua Senha")
            End If
            Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
            Dim sql As String = "select count(*) from Login where Usuario=@Usuario and Senha=@Senha"
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@Senha", PasswordTextBox.Text)
                    Dim value = cmd.ExecuteScalar()
                    If value > 0 Then
                        'SenhaNova
                        'SenhaNovaRepetida
                        If SenhaNova.Text = SenhaNovaRepetida.Text Then
                            teste()
                        Else
                            MessageBox.Show("As novas senhas est�o diferentes!")

                        End If
                    Else
                        MessageBox.Show("Usu�rio ou Senha inicial est� incorreta!")
                    End If
                End Using

            End Using
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)

        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ConnectToSQL()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UserADM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub



    ' comando atualizar senha

    Private conexao As SqlConnection
    Private comando As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader
    Private Sub teste()
        Try
            conexao = New SqlConnection("Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755")

            'Comando para inserir novo registro
            Dim strSQL As String = "UPDATE Login SET Senha = @Senha WHERE Usuario = @Usuario" 'WHERE ID = @ID

            comando = New SqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@Senha", SenhaNova.Text.Trim)
            comando.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
            ' comando.Parameters.AddWithValue("@NUMERO", txtNumero.Text)

            conexao.Open()
            comando.ExecuteNonQuery()

            MessageBox.Show("Senha alterada com Sucesso!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            comando.Clone()
            comando = Nothing
            conexao = Nothing
        End Try
    End Sub
End Class
