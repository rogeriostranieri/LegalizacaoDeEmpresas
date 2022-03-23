Imports System.Net.Mail

Public Class FrmMail
    Private Sub FrmMail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.eMailCaixaDeSaida'. Você pode movê-la ou removê-la conforme necessário.
        Me.EMailCaixaDeSaidaTableAdapter.Fill(Me.PrinceDBDataSet.eMailCaixaDeSaida)
        'TODO: esta linha de código carrega dados na tabela 'PrinceDBDataSet.eMail'. Você pode movê-la ou removê-la conforme necessário.
        Me.EMailTableAdapter.Fill(Me.PrinceDBDataSet.eMail)

    End Sub




    'tem que configurar no cliente POP/IMAP e habilitar e ter os dados"
    Private Sub ButtonEnviar_Click(sender As Object, e As EventArgs) Handles ButtonEnviar.Click

        TabControle.SelectedIndex = 2
        TabControle.SelectedIndex = 0


        Dim UserName As String = EMailTextBox.Text
        Dim UserSenha As String = SenhaEmailTextBox.Text
        Dim mail As MailMessage = New MailMessage

        mail.From = New MailAddress(UserName)
        mail.To.Add(New MailAddress(TextBoxPara.Text))
        mail.Subject = TextBoxAssunto.Text
        mail.Body = RichTextBoxMensagem.Text

        mail.IsBodyHtml = True

        Dim client As SmtpClient = New SmtpClient(SmtpClientTextBox.Text, SmtpPortTextBox.Text)
        client.EnableSsl = True
        client.UseDefaultCredentials = False
        client.Credentials = New System.Net.NetworkCredential(UserName, "betel8785")
        Try
            client.Send(mail)
            MessageBox.Show("E-mail enviado com sucesso")



        Catch ex As Exception
            MessageBox.Show("Erro ao enviar o e-mail ,tente novamente ou entre em contato com o administrador")
        End Try
    End Sub

    Private Sub EMailBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EMailBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMailBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PrinceDBDataSet)

    End Sub
End Class