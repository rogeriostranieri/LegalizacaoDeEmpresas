Imports System.Data
Imports System.Data.SqlClient
Public Class Login

    ' TODO: Inserir c�digo para realizar autentica��o personalizada utilizando o nome de usu�rio e senha fornecidos 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de seguran�a personalizada pode ser anexada � entidade de seguran�a da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal � a implementa��o de IPrincipal usada para realizar a autentica��o. 
    ' Subsequentemente, My.User ir� retornar informa��es de identifica��o encapsuladas num objeto CustomPrincipal
    ' como nome de usu�rio, nome de exibi��o etc.

    Private Sub ConnectToSQL()


        If txtUsername.Text.Length <= 0 Then
                MessageBox.Show("Digite o nome de Usu�rio!")
            ElseIf txtPassword.Text.Length <= 0 Then
                MessageBox.Show("Digite sua Senha")
            End If
            Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
            Dim sql As String = "select count(*) from Login where Usuario=@Usuario and Senha=@Senha"
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@Usuario", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@Senha", txtPassword.Text)
                    Dim value = cmd.ExecuteScalar()
                    If value > 0 Then

                        'MessageBox.Show("Seja Bem Vindo!")
                        FimData1()

                        MDIPrincipal.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Usu�rio ou Senha incorreta!")
                    End If
                End Using

            End Using


    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ConnectToSQL()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'chama valida��o da expira��o
        Call ModData.FimData()
        'continua



    End Sub
End Class
