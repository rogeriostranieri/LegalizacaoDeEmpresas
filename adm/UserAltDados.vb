Imports System.Data.SqlClient
Imports System.Globalization

Public Class UserAltDados
    Private Sub BtnNomeFinal_Click(sender As Object, e As EventArgs) Handles BtnNomeFinal.Click
        Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        Dim sql As String = "select count(*) from Login where Usuario=@Usuario and Senha=@Senha"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
                cmd.Parameters.AddWithValue("@Senha", PasswordTextBox.Text)
                Dim value = cmd.ExecuteScalar()
                If value = 1 Then
                    'UPDATE Login SET Tema=@TemaComboBox WHERE NomeCompleto=@NomeCompletoTextBox
                    'Selecionar Usuario e mudar nome completo e tema
                    Dim strSQL As String = "UPDATE Login SET NomeCompleto=@NomeCompleto, Tema=@TemaComboBox WHERE Usuario=@Usuario" 'WHERE ID = @ID
                    Using cmd4 As New SqlCommand(strSQL, Conn)
                        cmd4.Parameters.AddWithValue("@NomeCompleto", NomeCompletoTextBox.Text)
                        cmd4.Parameters.AddWithValue("@TemaComboBox", TemaComboBox.Text)
                        cmd4.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
                        cmd4.ExecuteNonQuery()
                    End Using
                    MsgBox("Dados alterados com sucesso")

                Else
                    MsgBox("Usuário ou senha incorretos")
                End If
            End Using
        End Using

    End Sub

    Private Sub UserAltDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'adicionar no TemaComboBox, todas imagens com nome iniciando "planodefundo" da pasta "...\Imagens\Plano de Fundo"
        'For Each img As String In IO.Directory.GetFiles(Application.StartupPath & "\Imagens\Plano de Fundo")
        Try
            For Each img As String In IO.Directory.GetFiles(Application.StartupPath & "\Imagens\Plano de Fundo")
                Dim imgName As String = IO.Path.GetFileName(img)
                If imgName.StartsWith("planodefundo") Then
                    TemaComboBox.Items.Add(imgName)
                End If

            Next
        Catch ex As Exception
            MsgBox("Erro ao carregar imagens")
        End Try

    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        'limpar campos
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
        NomeCompletoTextBox.Text = ""
        TemaComboBox.Text = ""

    End Sub

    Private Sub BtnMostrarDados_Click(sender As Object, e As EventArgs) Handles BtnMostrarDados.Click
        'mostrar dados e tema do usuario
        Dim str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        Dim sql As String = "select * from Login where Usuario=@Usuario and Senha=@Senha"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
                cmd.Parameters.AddWithValue("@Senha", PasswordTextBox.Text)
                Dim value = cmd.ExecuteScalar()
                If value = 1 Then
                    'Selecionar Usuario e mudar nome completo e tema
                    Dim strSQL As String = "SELECT * FROM Login WHERE Usuario=@Usuario" 'WHERE ID = @ID
                    Using cmd4 As New SqlCommand(strSQL, Conn)
                        cmd4.Parameters.AddWithValue("@Usuario", UsernameTextBox.Text)
                        Dim dr As SqlDataReader = cmd4.ExecuteReader()
                        If dr.Read() Then
                            NomeCompletoTextBox.Text = dr("NomeCompleto")
                            TemaComboBox.Text = dr("Tema")
                        End If
                    End Using

                    'MDIPrincipal.Refresh()
                End If
            End Using
        End Using


    End Sub
End Class
