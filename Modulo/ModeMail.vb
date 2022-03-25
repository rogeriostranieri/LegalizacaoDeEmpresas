﻿Imports System.Data
Imports System.Data.SqlClient


Module ModeMail
    Sub EmailCaixaDeSaida()
        Dim Str As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
        Dim Sql As String = "select count(*) from eMail where eMail=@EMailPrincipal"

        Try

            Using Conn As New SqlConnection(Str)
                Using cmd As New SqlCommand(Sql, Conn)
                    Conn.Open()
                    cmd.Parameters.AddWithValue("@EMailPrincipal", FrmEmailCaixaDeSaida.ComboBoxBusca.Text)

                    Dim value = cmd.ExecuteScalar()

                    If value > 0 Then


                    Else

                        ' abrir aba dados para pegar informações
                        FrmMail.TabControle.SelectTab(1) 'dados

                        'tabcontrole dos aba dados
                        FrmMail.TabControle.SelectTab(0)


                        'Abrir FORM
                        FrmEmailCaixaDeSaida.MdiParent = MDIPrincipal
                        FrmEmailCaixaDeSaida.Show()
                        FrmEmailCaixaDeSaida.Visible = False
                        'Valida e Abre um novo registro
                        FrmEmailCaixaDeSaida.Validate()
                        FrmEmailCaixaDeSaida.EMailCaixaDeSaidaBindingSource.AddNew()
                        '  LFrmEmailCaixaDeSaida.RazaoSocialTextBox.Text = RazaoSocialTextBox.Text


                        'codigo de copiar entre os form

                        'COPIA OS DADOS
                        FrmEmailCaixaDeSaida.EMailPrincipalTextBox.Text = FrmMail.ComboBoxEmailSelecionar.Text
                        FrmEmailCaixaDeSaida.EMailDestinoTextBox.Text = FrmMail.TextBoxPara.Text
                        FrmEmailCaixaDeSaida.AssuntoTextBox.Text = FrmMail.TextBoxAssunto.Text
                        FrmEmailCaixaDeSaida.CaixaDeSaidaTextoRichTextBox.Text = FrmMail.RichTextBoxMensagem.Text



                        'data de criação e aviso
                        '  FrmEmailCaixaDeSaida.DataCriadoMaskedTextBox.Text = System.DateTime.Now
                        '  FrmEmailCaixaDeSaida.AvisarDiaMaskedTextBox.Text = System.DateTime.Today

                        'termina as copia e foca
                        'Focus
                        FrmEmailCaixaDeSaida.EMailPrincipalTextBox.Focus()

                        'adicionar data

                        FrmEmailCaixaDeSaida.DataEnviadoMaskedTextBox.Text = DateTime.Now.AddMinutes(55).ToString("dd'/'MM'/'yyyy HH:mm:ss", System.Globalization.CultureInfo.GetCultureInfo("pt-BR"))


                        'MessageBox.Show("Importação realizada com sucesso","Prince Sistemas Informa")
                        FrmEmailCaixaDeSaida.Validate()
                        FrmEmailCaixaDeSaida.EMailCaixaDeSaidaBindingSource.EndEdit()
                        FrmEmailCaixaDeSaida.EMailCaixaDeSaidaTableAdapter.Update(FrmEmailCaixaDeSaida.PrinceDBDataSet.eMailCaixaDeSaida)
                        FrmEmailCaixaDeSaida.Close()


                    End If

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Erro na conexão!" & vbCrLf & ex.Message)

        Finally
            'Whether there is error or not. Close the connection.

        End Try
    End Sub

    Sub Enviaremaillegalizao()
        Legalizacao.TabControle.SelectTab(0)

        'abrir histórico
        FrmMail.TabControle.SelectTab(0)

        FrmMail.TextBoxAssunto.Text = ""
        FrmMail.RichTextBoxMensagem.Text = ""

        'igual esta no comando no formulario legalizacao
        Legalizacao.SistemaExternoComboBox.SelectedIndex = 0

        Try
            Dim A = Legalizacao.RazaoSocialTextBox.Text.ToString()
            Dim B = Legalizacao.CNPJMaskedTextBox.Text.ToString()
            Dim C = Legalizacao.ProcessoComboBox.Text.ToString()
            Dim D = Legalizacao.MotivoRichTextBox.Text.ToString()
            Dim E = Legalizacao.SistemaExternoComboBox.Text.ToString()

            'assunto
            FrmMail.TextBoxAssunto.Text = A

            'corpo do email
            FrmMail.RichTextBoxMensagem.SelectedText &=
"A Empresa: " & A & ", com CNPJ: " & B & ", 
Com o processo de:" & C & ", 
Teve como objetivo de: " & D &",
E no sistema ja foi atualizado:" & E & ".

            
//-----------------//-----------------//-----------------//-----------------//
"

        Catch ex As System.InvalidCastException
            MessageBox.Show("ERRO" & vbCrLf & ex.Message, "Prince Avisa")

        End Try


    End Sub
End Module
