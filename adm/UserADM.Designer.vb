﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class UserADM
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim NomeCompletoLabel As System.Windows.Forms.Label
        Dim TemaLabel As System.Windows.Forms.Label
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.SenhaNova = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SenhaNovaRepetida = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnNomeFinal = New System.Windows.Forms.Button()
        Me.NomeCompletoTextBox = New System.Windows.Forms.TextBox()
        Me.TemaComboBox = New System.Windows.Forms.ComboBox()
        NomeCompletoLabel = New System.Windows.Forms.Label()
        TemaLabel = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomeCompletoLabel
        '
        NomeCompletoLabel.AutoSize = True
        NomeCompletoLabel.Location = New System.Drawing.Point(537, 14)
        NomeCompletoLabel.Name = "NomeCompletoLabel"
        NomeCompletoLabel.Size = New System.Drawing.Size(85, 13)
        NomeCompletoLabel.TabIndex = 12
        NomeCompletoLabel.Text = "Nome Completo:"
        '
        'TemaLabel
        '
        TemaLabel.AutoSize = True
        TemaLabel.Location = New System.Drawing.Point(537, 57)
        TemaLabel.Name = "TemaLabel"
        TemaLabel.Size = New System.Drawing.Size(37, 13)
        TemaLabel.TabIndex = 14
        TemaLabel.Text = "Tema:"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.PrinceSistemas.My.Resources.Resources.Area_de_Membros
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(197, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(203, 9)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nome de Usuário"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Location = New System.Drawing.Point(203, 52)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Senha Atual"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(205, 29)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 20)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(205, 72)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 20)
        Me.PasswordTextBox.TabIndex = 2
        '
        'OK
        '
        Me.OK.Location = New System.Drawing.Point(229, 211)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(94, 23)
        Me.OK.TabIndex = 5
        Me.OK.Text = "&Alterar Senha"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(332, 211)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(94, 23)
        Me.Cancel.TabIndex = 6
        Me.Cancel.Text = "&Cancelar"
        '
        'SenhaNova
        '
        Me.SenhaNova.Location = New System.Drawing.Point(205, 125)
        Me.SenhaNova.Name = "SenhaNova"
        Me.SenhaNova.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaNova.Size = New System.Drawing.Size(220, 20)
        Me.SenhaNova.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(203, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "&Nova Senha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SenhaNovaRepetida
        '
        Me.SenhaNovaRepetida.Location = New System.Drawing.Point(206, 168)
        Me.SenhaNovaRepetida.Name = "SenhaNovaRepetida"
        Me.SenhaNovaRepetida.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SenhaNovaRepetida.Size = New System.Drawing.Size(220, 20)
        Me.SenhaNovaRepetida.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(204, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "&Repita Nova Senha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(643, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "&Cancelar"
        '
        'BtnNomeFinal
        '
        Me.BtnNomeFinal.Location = New System.Drawing.Point(540, 122)
        Me.BtnNomeFinal.Name = "BtnNomeFinal"
        Me.BtnNomeFinal.Size = New System.Drawing.Size(94, 23)
        Me.BtnNomeFinal.TabIndex = 16
        Me.BtnNomeFinal.Text = "&Alterar Dados"
        '
        'NomeCompletoTextBox
        '
        Me.NomeCompletoTextBox.Location = New System.Drawing.Point(540, 29)
        Me.NomeCompletoTextBox.Name = "NomeCompletoTextBox"
        Me.NomeCompletoTextBox.Size = New System.Drawing.Size(256, 20)
        Me.NomeCompletoTextBox.TabIndex = 18
        '
        'TemaComboBox
        '
        Me.TemaComboBox.FormattingEnabled = True
        Me.TemaComboBox.Items.AddRange(New Object() {"Noite"})
        Me.TemaComboBox.Location = New System.Drawing.Point(540, 73)
        Me.TemaComboBox.Name = "TemaComboBox"
        Me.TemaComboBox.Size = New System.Drawing.Size(169, 21)
        Me.TemaComboBox.TabIndex = 19
        '
        'UserADM
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(858, 254)
        Me.Controls.Add(Me.TemaComboBox)
        Me.Controls.Add(Me.NomeCompletoTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnNomeFinal)
        Me.Controls.Add(TemaLabel)
        Me.Controls.Add(NomeCompletoLabel)
        Me.Controls.Add(Me.SenhaNovaRepetida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SenhaNova)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserADM"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alterar Senha"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SenhaNova As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SenhaNovaRepetida As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnNomeFinal As Button
    Friend WithEvents NomeCompletoTextBox As TextBox
    Friend WithEvents TemaComboBox As ComboBox
End Class
