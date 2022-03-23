<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMail
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMail))
        Dim EMailLabel As System.Windows.Forms.Label
        Dim SenhaEmailLabel As System.Windows.Forms.Label
        Dim SmtpClientLabel As System.Windows.Forms.Label
        Dim SmtpPortLabel As System.Windows.Forms.Label
        Dim ClientSslLabel As System.Windows.Forms.Label
        Dim EMailLabel1 As System.Windows.Forms.Label
        Me.LabelDe = New System.Windows.Forms.Label()
        Me.LabelPara = New System.Windows.Forms.Label()
        Me.TextBoxPara = New System.Windows.Forms.TextBox()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.RichTextBoxMensagem = New System.Windows.Forms.RichTextBox()
        Me.TextBoxAssunto = New System.Windows.Forms.TextBox()
        Me.TabControle = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.EMailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EMailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EMailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.EMailTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.eMailTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.EMailCaixaDeSaidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMailCaixaDeSaidaTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.eMailCaixaDeSaidaTableAdapter()
        Me.EMailTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaEmailTextBox = New System.Windows.Forms.TextBox()
        Me.SmtpClientTextBox = New System.Windows.Forms.TextBox()
        Me.SmtpPortTextBox = New System.Windows.Forms.TextBox()
        Me.ClientSslComboBox = New System.Windows.Forms.ComboBox()
        Me.EMailCaixaDeSaidaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EMailCaixaDeSaidaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMailLabel2 = New System.Windows.Forms.Label()
        Me.ComboBoxEmailSelecionar = New System.Windows.Forms.ComboBox()
        EMailLabel = New System.Windows.Forms.Label()
        SenhaEmailLabel = New System.Windows.Forms.Label()
        SmtpClientLabel = New System.Windows.Forms.Label()
        SmtpPortLabel = New System.Windows.Forms.Label()
        ClientSslLabel = New System.Windows.Forms.Label()
        EMailLabel1 = New System.Windows.Forms.Label()
        Me.TabControle.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.EMailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EMailBindingNavigator.SuspendLayout()
        CType(Me.EMailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMailCaixaDeSaidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMailCaixaDeSaidaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EMailCaixaDeSaidaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDe
        '
        Me.LabelDe.AutoSize = True
        Me.LabelDe.Location = New System.Drawing.Point(36, 36)
        Me.LabelDe.Name = "LabelDe"
        Me.LabelDe.Size = New System.Drawing.Size(108, 13)
        Me.LabelDe.TabIndex = 1
        Me.LabelDe.Text = "E-mail que vai enviar:"
        '
        'LabelPara
        '
        Me.LabelPara.AutoSize = True
        Me.LabelPara.Location = New System.Drawing.Point(112, 65)
        Me.LabelPara.Name = "LabelPara"
        Me.LabelPara.Size = New System.Drawing.Size(32, 13)
        Me.LabelPara.TabIndex = 3
        Me.LabelPara.Text = "Para:"
        '
        'TextBoxPara
        '
        Me.TextBoxPara.Location = New System.Drawing.Point(150, 62)
        Me.TextBoxPara.Name = "TextBoxPara"
        Me.TextBoxPara.Size = New System.Drawing.Size(193, 20)
        Me.TextBoxPara.TabIndex = 2
        Me.TextBoxPara.Text = "legalizacaobetel@gmail.com"
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Location = New System.Drawing.Point(290, 232)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEnviar.TabIndex = 4
        Me.ButtonEnviar.Text = "Enviar"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'RichTextBoxMensagem
        '
        Me.RichTextBoxMensagem.Location = New System.Drawing.Point(48, 151)
        Me.RichTextBoxMensagem.Name = "RichTextBoxMensagem"
        Me.RichTextBoxMensagem.Size = New System.Drawing.Size(317, 75)
        Me.RichTextBoxMensagem.TabIndex = 5
        Me.RichTextBoxMensagem.Text = ""
        '
        'TextBoxAssunto
        '
        Me.TextBoxAssunto.Location = New System.Drawing.Point(48, 125)
        Me.TextBoxAssunto.Name = "TextBoxAssunto"
        Me.TextBoxAssunto.Size = New System.Drawing.Size(249, 20)
        Me.TextBoxAssunto.TabIndex = 6
        Me.TextBoxAssunto.Text = "Digite aqui o assunto..."
        '
        'TabControle
        '
        Me.TabControle.Controls.Add(Me.TabPage1)
        Me.TabControle.Controls.Add(Me.TabPage2)
        Me.TabControle.Controls.Add(Me.TabPage3)
        Me.TabControle.Location = New System.Drawing.Point(26, 66)
        Me.TabControle.Name = "TabControle"
        Me.TabControle.SelectedIndex = 0
        Me.TabControle.Size = New System.Drawing.Size(462, 311)
        Me.TabControle.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ComboBoxEmailSelecionar)
        Me.TabPage1.Controls.Add(Me.RichTextBoxMensagem)
        Me.TabPage1.Controls.Add(Me.TextBoxAssunto)
        Me.TabPage1.Controls.Add(Me.LabelDe)
        Me.TabPage1.Controls.Add(Me.ButtonEnviar)
        Me.TabPage1.Controls.Add(Me.TextBoxPara)
        Me.TabPage1.Controls.Add(Me.LabelPara)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(454, 285)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Enviar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.EMailCaixaDeSaidaDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(454, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Caixa de Saída"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(ClientSslLabel)
        Me.TabPage3.Controls.Add(Me.ClientSslComboBox)
        Me.TabPage3.Controls.Add(SmtpPortLabel)
        Me.TabPage3.Controls.Add(Me.SmtpPortTextBox)
        Me.TabPage3.Controls.Add(SmtpClientLabel)
        Me.TabPage3.Controls.Add(Me.SmtpClientTextBox)
        Me.TabPage3.Controls.Add(SenhaEmailLabel)
        Me.TabPage3.Controls.Add(Me.SenhaEmailTextBox)
        Me.TabPage3.Controls.Add(EMailLabel)
        Me.TabPage3.Controls.Add(Me.EMailTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(454, 285)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Dados"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'EMailBindingNavigator
        '
        Me.EMailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EMailBindingNavigator.BindingSource = Me.EMailBindingSource
        Me.EMailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EMailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EMailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EMailBindingNavigatorSaveItem})
        Me.EMailBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EMailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EMailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EMailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EMailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EMailBindingNavigator.Name = "EMailBindingNavigator"
        Me.EMailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EMailBindingNavigator.Size = New System.Drawing.Size(549, 25)
        Me.EMailBindingNavigator.TabIndex = 8
        Me.EMailBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'EMailBindingNavigatorSaveItem
        '
        Me.EMailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EMailBindingNavigatorSaveItem.Image = CType(resources.GetObject("EMailBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EMailBindingNavigatorSaveItem.Name = "EMailBindingNavigatorSaveItem"
        Me.EMailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EMailBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'EMailBindingSource
        '
        Me.EMailBindingSource.DataMember = "eMail"
        Me.EMailBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EMailTableAdapter
        '
        Me.EMailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Me.EMailTableAdapter
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EMailCaixaDeSaidaBindingSource
        '
        Me.EMailCaixaDeSaidaBindingSource.DataMember = "eMailCaixaDeSaida"
        Me.EMailCaixaDeSaidaBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'EMailCaixaDeSaidaTableAdapter
        '
        Me.EMailCaixaDeSaidaTableAdapter.ClearBeforeFill = True
        '
        'EMailLabel
        '
        EMailLabel.AutoSize = True
        EMailLabel.Location = New System.Drawing.Point(32, 33)
        EMailLabel.Name = "EMailLabel"
        EMailLabel.Size = New System.Drawing.Size(38, 13)
        EMailLabel.TabIndex = 0
        EMailLabel.Text = "e Mail:"
        '
        'EMailTextBox
        '
        Me.EMailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "eMail", True))
        Me.EMailTextBox.Location = New System.Drawing.Point(76, 30)
        Me.EMailTextBox.Name = "EMailTextBox"
        Me.EMailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EMailTextBox.TabIndex = 1
        Me.EMailTextBox.Text = "contato@escritoriobetel.com.br"
        '
        'SenhaEmailLabel
        '
        SenhaEmailLabel.AutoSize = True
        SenhaEmailLabel.Location = New System.Drawing.Point(34, 75)
        SenhaEmailLabel.Name = "SenhaEmailLabel"
        SenhaEmailLabel.Size = New System.Drawing.Size(69, 13)
        SenhaEmailLabel.TabIndex = 2
        SenhaEmailLabel.Text = "Senha Email:"
        '
        'SenhaEmailTextBox
        '
        Me.SenhaEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "SenhaEmail", True))
        Me.SenhaEmailTextBox.Location = New System.Drawing.Point(109, 72)
        Me.SenhaEmailTextBox.Name = "SenhaEmailTextBox"
        Me.SenhaEmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SenhaEmailTextBox.TabIndex = 3
        Me.SenhaEmailTextBox.Text = "betel8785"
        '
        'SmtpClientLabel
        '
        SmtpClientLabel.AutoSize = True
        SmtpClientLabel.Location = New System.Drawing.Point(76, 107)
        SmtpClientLabel.Name = "SmtpClientLabel"
        SmtpClientLabel.Size = New System.Drawing.Size(63, 13)
        SmtpClientLabel.TabIndex = 4
        SmtpClientLabel.Text = "Smtp Client:"
        '
        'SmtpClientTextBox
        '
        Me.SmtpClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "SmtpClient", True))
        Me.SmtpClientTextBox.Location = New System.Drawing.Point(145, 104)
        Me.SmtpClientTextBox.Name = "SmtpClientTextBox"
        Me.SmtpClientTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SmtpClientTextBox.TabIndex = 5
        Me.SmtpClientTextBox.Text = "mail.escritoriobetel.com.br"
        '
        'SmtpPortLabel
        '
        SmtpPortLabel.AutoSize = True
        SmtpPortLabel.Location = New System.Drawing.Point(33, 141)
        SmtpPortLabel.Name = "SmtpPortLabel"
        SmtpPortLabel.Size = New System.Drawing.Size(56, 13)
        SmtpPortLabel.TabIndex = 6
        SmtpPortLabel.Text = "Smtp Port:"
        '
        'SmtpPortTextBox
        '
        Me.SmtpPortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "SmtpPort", True))
        Me.SmtpPortTextBox.Location = New System.Drawing.Point(95, 138)
        Me.SmtpPortTextBox.Name = "SmtpPortTextBox"
        Me.SmtpPortTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SmtpPortTextBox.TabIndex = 7
        Me.SmtpPortTextBox.Text = "587"
        '
        'ClientSslLabel
        '
        ClientSslLabel.AutoSize = True
        ClientSslLabel.Location = New System.Drawing.Point(71, 172)
        ClientSslLabel.Name = "ClientSslLabel"
        ClientSslLabel.Size = New System.Drawing.Size(52, 13)
        ClientSslLabel.TabIndex = 8
        ClientSslLabel.Text = "client Ssl:"
        '
        'ClientSslComboBox
        '
        Me.ClientSslComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "clientSsl", True))
        Me.ClientSslComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClientSslComboBox.FormattingEnabled = True
        Me.ClientSslComboBox.Items.AddRange(New Object() {"", "False", "True"})
        Me.ClientSslComboBox.Location = New System.Drawing.Point(129, 169)
        Me.ClientSslComboBox.Name = "ClientSslComboBox"
        Me.ClientSslComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ClientSslComboBox.Sorted = True
        Me.ClientSslComboBox.TabIndex = 9
        '
        'EMailCaixaDeSaidaBindingSource1
        '
        Me.EMailCaixaDeSaidaBindingSource1.DataMember = "eMail_eMailCaixaDeSaida"
        Me.EMailCaixaDeSaidaBindingSource1.DataSource = Me.EMailBindingSource
        '
        'EMailCaixaDeSaidaDataGridView
        '
        Me.EMailCaixaDeSaidaDataGridView.AutoGenerateColumns = False
        Me.EMailCaixaDeSaidaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EMailCaixaDeSaidaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.EMailCaixaDeSaidaDataGridView.DataSource = Me.EMailCaixaDeSaidaBindingSource1
        Me.EMailCaixaDeSaidaDataGridView.Location = New System.Drawing.Point(12, 25)
        Me.EMailCaixaDeSaidaDataGridView.Name = "EMailCaixaDeSaidaDataGridView"
        Me.EMailCaixaDeSaidaDataGridView.Size = New System.Drawing.Size(425, 220)
        Me.EMailCaixaDeSaidaDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID_eMailCaixaDeSaida"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID_eMailCaixaDeSaida"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDeMailPrincipal"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDeMailPrincipal"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "eMailPrincipal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "eMailPrincipal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "eMailDestino"
        Me.DataGridViewTextBoxColumn4.HeaderText = "eMailDestino"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Assunto"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Assunto"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CaixaDeSaidaTexto"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CaixaDeSaidaTexto"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DataEnviado"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DataEnviado"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'EMailLabel1
        '
        EMailLabel1.AutoSize = True
        EMailLabel1.Location = New System.Drawing.Point(39, 32)
        EMailLabel1.Name = "EMailLabel1"
        EMailLabel1.Size = New System.Drawing.Size(38, 13)
        EMailLabel1.TabIndex = 8
        EMailLabel1.Text = "e Mail:"
        '
        'EMailLabel2
        '
        Me.EMailLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EMailBindingSource, "eMail", True))
        Me.EMailLabel2.Location = New System.Drawing.Point(83, 32)
        Me.EMailLabel2.Name = "EMailLabel2"
        Me.EMailLabel2.Size = New System.Drawing.Size(100, 23)
        Me.EMailLabel2.TabIndex = 9
        Me.EMailLabel2.Text = "Label1"
        '
        'ComboBoxEmailSelecionar
        '
        Me.ComboBoxEmailSelecionar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxEmailSelecionar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxEmailSelecionar.DataSource = Me.EMailBindingSource
        Me.ComboBoxEmailSelecionar.DisplayMember = "eMail"
        Me.ComboBoxEmailSelecionar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxEmailSelecionar.FormattingEnabled = True
        Me.ComboBoxEmailSelecionar.Location = New System.Drawing.Point(148, 31)
        Me.ComboBoxEmailSelecionar.Name = "ComboBoxEmailSelecionar"
        Me.ComboBoxEmailSelecionar.Size = New System.Drawing.Size(195, 21)
        Me.ComboBoxEmailSelecionar.TabIndex = 7
        Me.ComboBoxEmailSelecionar.ValueMember = "eMail"
        '
        'FrmMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 389)
        Me.Controls.Add(EMailLabel1)
        Me.Controls.Add(Me.EMailLabel2)
        Me.Controls.Add(Me.EMailBindingNavigator)
        Me.Controls.Add(Me.TabControle)
        Me.Name = "FrmMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMail"
        Me.TabControle.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.EMailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EMailBindingNavigator.ResumeLayout(False)
        Me.EMailBindingNavigator.PerformLayout()
        CType(Me.EMailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMailCaixaDeSaidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMailCaixaDeSaidaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EMailCaixaDeSaidaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDe As Label
    Friend WithEvents LabelPara As Label
    Friend WithEvents TextBoxPara As TextBox
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents RichTextBoxMensagem As RichTextBox
    Friend WithEvents TextBoxAssunto As TextBox
    Friend WithEvents TabControle As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents EMailBindingSource As BindingSource
    Friend WithEvents EMailTableAdapter As PrinceDBDataSetTableAdapters.eMailTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EMailBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EMailBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EMailCaixaDeSaidaBindingSource As BindingSource
    Friend WithEvents EMailCaixaDeSaidaTableAdapter As PrinceDBDataSetTableAdapters.eMailCaixaDeSaidaTableAdapter
    Friend WithEvents EMailCaixaDeSaidaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents EMailCaixaDeSaidaBindingSource1 As BindingSource
    Friend WithEvents ClientSslComboBox As ComboBox
    Friend WithEvents SmtpPortTextBox As TextBox
    Friend WithEvents SmtpClientTextBox As TextBox
    Friend WithEvents SenhaEmailTextBox As TextBox
    Friend WithEvents EMailTextBox As TextBox
    Friend WithEvents EMailLabel2 As Label
    Friend WithEvents ComboBoxEmailSelecionar As ComboBox
End Class
