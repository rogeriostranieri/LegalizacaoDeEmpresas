<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAnotacoes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAnotacoes))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonInicial = New System.Windows.Forms.Button()
        Me.ButtonLegalizacao = New System.Windows.Forms.Button()
        Me.ButtonFederal = New System.Windows.Forms.Button()
        Me.ButtonEstadual = New System.Windows.Forms.Button()
        Me.ButtonPrefeitura = New System.Windows.Forms.Button()
        Me.ButtonDemais = New System.Windows.Forms.Button()
        Me.AnotacoesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.AnotacoesTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.AnotacoesTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        Me.GroupBoxEditor = New System.Windows.Forms.GroupBox()
        Me.BtnNegrito = New System.Windows.Forms.Button()
        Me.cbotamanho = New System.Windows.Forms.ComboBox()
        Me.cbofonte = New System.Windows.Forms.ComboBox()
        Me.MudarCorBotao = New System.Windows.Forms.Button()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMudaTexto = New System.Windows.Forms.Label()
        Me.ButtonSalvar = New System.Windows.Forms.Button()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        Me.ButtonFechar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RichTextBoxAnotacao = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BtnItalico = New System.Windows.Forms.Button()
        Me.BtnSublinhado = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.AnotacoesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxEditor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonInicial, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonLegalizacao, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonFederal, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonEstadual, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonPrefeitura, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.ButtonDemais, 0, 5)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 152)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(124, 213)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'ButtonInicial
        '
        Me.ButtonInicial.AutoSize = True
        Me.ButtonInicial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonInicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonInicial.Location = New System.Drawing.Point(3, 3)
        Me.ButtonInicial.Name = "ButtonInicial"
        Me.ButtonInicial.Size = New System.Drawing.Size(120, 29)
        Me.ButtonInicial.TabIndex = 53
        Me.ButtonInicial.Text = "Inicial"
        Me.ButtonInicial.UseVisualStyleBackColor = True
        '
        'ButtonLegalizacao
        '
        Me.ButtonLegalizacao.AutoSize = True
        Me.ButtonLegalizacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonLegalizacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonLegalizacao.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLegalizacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonLegalizacao.Location = New System.Drawing.Point(3, 38)
        Me.ButtonLegalizacao.Name = "ButtonLegalizacao"
        Me.ButtonLegalizacao.Size = New System.Drawing.Size(120, 29)
        Me.ButtonLegalizacao.TabIndex = 52
        Me.ButtonLegalizacao.Text = "Legalizacao"
        Me.ButtonLegalizacao.UseVisualStyleBackColor = True
        '
        'ButtonFederal
        '
        Me.ButtonFederal.AutoSize = True
        Me.ButtonFederal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonFederal.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonFederal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFederal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonFederal.Location = New System.Drawing.Point(3, 73)
        Me.ButtonFederal.Name = "ButtonFederal"
        Me.ButtonFederal.Size = New System.Drawing.Size(120, 29)
        Me.ButtonFederal.TabIndex = 54
        Me.ButtonFederal.Text = "Receita Federal"
        Me.ButtonFederal.UseVisualStyleBackColor = True
        '
        'ButtonEstadual
        '
        Me.ButtonEstadual.AutoSize = True
        Me.ButtonEstadual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonEstadual.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEstadual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEstadual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonEstadual.Location = New System.Drawing.Point(3, 108)
        Me.ButtonEstadual.Name = "ButtonEstadual"
        Me.ButtonEstadual.Size = New System.Drawing.Size(120, 29)
        Me.ButtonEstadual.TabIndex = 55
        Me.ButtonEstadual.Text = "Receita Estadual"
        Me.ButtonEstadual.UseVisualStyleBackColor = True
        '
        'ButtonPrefeitura
        '
        Me.ButtonPrefeitura.AutoSize = True
        Me.ButtonPrefeitura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrefeitura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPrefeitura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPrefeitura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonPrefeitura.Location = New System.Drawing.Point(3, 143)
        Me.ButtonPrefeitura.Name = "ButtonPrefeitura"
        Me.ButtonPrefeitura.Size = New System.Drawing.Size(120, 29)
        Me.ButtonPrefeitura.TabIndex = 56
        Me.ButtonPrefeitura.Text = "Prefeitura"
        Me.ButtonPrefeitura.UseVisualStyleBackColor = True
        '
        'ButtonDemais
        '
        Me.ButtonDemais.AutoSize = True
        Me.ButtonDemais.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonDemais.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDemais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDemais.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ButtonDemais.Location = New System.Drawing.Point(3, 178)
        Me.ButtonDemais.Name = "ButtonDemais"
        Me.ButtonDemais.Size = New System.Drawing.Size(120, 32)
        Me.ButtonDemais.TabIndex = 57
        Me.ButtonDemais.Text = "Demais"
        Me.ButtonDemais.UseVisualStyleBackColor = True
        '
        'AnotacoesBindingSource
        '
        Me.AnotacoesBindingSource.DataMember = "Anotacoes"
        Me.AnotacoesBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnotacoesTableAdapter
        '
        Me.AnotacoesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnotacoesTableAdapter = Me.AnotacoesTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADSituacaoAlvaraTableAdapter = Nothing
        Me.TableAdapterManager.CADstatusTableAdapter = Nothing
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.eMailCaixaDeSaidaTableAdapter = Nothing
        Me.TableAdapterManager.eMailTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBoxEditor
        '
        Me.GroupBoxEditor.Controls.Add(Me.ToolStrip1)
        Me.GroupBoxEditor.Controls.Add(Me.BtnSublinhado)
        Me.GroupBoxEditor.Controls.Add(Me.BtnItalico)
        Me.GroupBoxEditor.Controls.Add(Me.BtnNegrito)
        Me.GroupBoxEditor.Controls.Add(Me.cbotamanho)
        Me.GroupBoxEditor.Controls.Add(Me.cbofonte)
        Me.GroupBoxEditor.Controls.Add(Me.MudarCorBotao)
        Me.GroupBoxEditor.Location = New System.Drawing.Point(138, 53)
        Me.GroupBoxEditor.Name = "GroupBoxEditor"
        Me.GroupBoxEditor.Size = New System.Drawing.Size(651, 93)
        Me.GroupBoxEditor.TabIndex = 53
        Me.GroupBoxEditor.TabStop = False
        Me.GroupBoxEditor.Text = "Editor"
        '
        'BtnNegrito
        '
        Me.BtnNegrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNegrito.Location = New System.Drawing.Point(361, 59)
        Me.BtnNegrito.Name = "BtnNegrito"
        Me.BtnNegrito.Size = New System.Drawing.Size(30, 28)
        Me.BtnNegrito.TabIndex = 8
        Me.BtnNegrito.Text = "B"
        Me.BtnNegrito.UseVisualStyleBackColor = True
        '
        'cbotamanho
        '
        Me.cbotamanho.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotamanho.FormattingEnabled = True
        Me.cbotamanho.Location = New System.Drawing.Point(245, 61)
        Me.cbotamanho.Name = "cbotamanho"
        Me.cbotamanho.Size = New System.Drawing.Size(61, 26)
        Me.cbotamanho.TabIndex = 6
        '
        'cbofonte
        '
        Me.cbofonte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbofonte.FormattingEnabled = True
        Me.cbofonte.Location = New System.Drawing.Point(6, 61)
        Me.cbofonte.Name = "cbofonte"
        Me.cbofonte.Size = New System.Drawing.Size(233, 26)
        Me.cbofonte.TabIndex = 5
        '
        'MudarCorBotao
        '
        Me.MudarCorBotao.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MudarCorBotao.Location = New System.Drawing.Point(312, 59)
        Me.MudarCorBotao.Name = "MudarCorBotao"
        Me.MudarCorBotao.Size = New System.Drawing.Size(43, 28)
        Me.MudarCorBotao.TabIndex = 4
        Me.MudarCorBotao.Text = "Cor"
        Me.MudarCorBotao.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 50)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "ANOTAÇÕES : "
        '
        'lblMudaTexto
        '
        Me.lblMudaTexto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMudaTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMudaTexto.ForeColor = System.Drawing.Color.Blue
        Me.lblMudaTexto.Location = New System.Drawing.Point(229, 6)
        Me.lblMudaTexto.Name = "lblMudaTexto"
        Me.lblMudaTexto.Size = New System.Drawing.Size(416, 35)
        Me.lblMudaTexto.TabIndex = 55
        '
        'ButtonSalvar
        '
        Me.ButtonSalvar.BackgroundImage = CType(resources.GetObject("ButtonSalvar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonSalvar.Location = New System.Drawing.Point(6, 19)
        Me.ButtonSalvar.Name = "ButtonSalvar"
        Me.ButtonSalvar.Size = New System.Drawing.Size(69, 23)
        Me.ButtonSalvar.TabIndex = 51
        Me.ButtonSalvar.Text = "Salvar"
        Me.ButtonSalvar.UseVisualStyleBackColor = True
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.BackgroundImage = CType(resources.GetObject("ButtonLimpar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonLimpar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonLimpar.Location = New System.Drawing.Point(6, 48)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(69, 23)
        Me.ButtonLimpar.TabIndex = 53
        Me.ButtonLimpar.Text = "Limpar"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'ButtonFechar
        '
        Me.ButtonFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFechar.BackgroundImage = CType(resources.GetObject("ButtonFechar.BackgroundImage"), System.Drawing.Image)
        Me.ButtonFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButtonFechar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonFechar.Location = New System.Drawing.Point(804, 3)
        Me.ButtonFechar.Name = "ButtonFechar"
        Me.ButtonFechar.Size = New System.Drawing.Size(69, 23)
        Me.ButtonFechar.TabIndex = 52
        Me.ButtonFechar.Text = "Fechar"
        Me.ButtonFechar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonLimpar)
        Me.GroupBox1.Controls.Add(Me.ButtonSalvar)
        Me.GroupBox1.Location = New System.Drawing.Point(795, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(78, 104)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'RichTextBoxAnotacao
        '
        Me.RichTextBoxAnotacao.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxAnotacao.Location = New System.Drawing.Point(138, 152)
        Me.RichTextBoxAnotacao.Name = "RichTextBoxAnotacao"
        Me.RichTextBoxAnotacao.Size = New System.Drawing.Size(651, 407)
        Me.RichTextBoxAnotacao.TabIndex = 54
        Me.RichTextBoxAnotacao.Text = ""
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 3
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.52511!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.11416!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.474886!))
        Me.TableLayoutPanel5.Controls.Add(Me.ButtonFechar, 2, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.RichTextBoxAnotacao, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBoxEditor, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox1, 2, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.33594!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.66406!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(876, 562)
        Me.TableLayoutPanel5.TabIndex = 55
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblMudaTexto)
        Me.GroupBox2.Location = New System.Drawing.Point(138, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(651, 44)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'BtnItalico
        '
        Me.BtnItalico.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItalico.Location = New System.Drawing.Point(397, 59)
        Me.BtnItalico.Name = "BtnItalico"
        Me.BtnItalico.Size = New System.Drawing.Size(30, 28)
        Me.BtnItalico.TabIndex = 9
        Me.BtnItalico.Text = "I"
        Me.BtnItalico.UseVisualStyleBackColor = True
        '
        'BtnSublinhado
        '
        Me.BtnSublinhado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSublinhado.Location = New System.Drawing.Point(433, 59)
        Me.BtnSublinhado.Name = "BtnSublinhado"
        Me.BtnSublinhado.Size = New System.Drawing.Size(30, 28)
        Me.BtnSublinhado.TabIndex = 10
        Me.BtnSublinhado.Text = "S"
        Me.BtnSublinhado.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1, Me.ToolStripSeparator1, Me.ToolStripComboBox2, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(645, 28)
        Me.ToolStrip1.TabIndex = 11
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(121, 28)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(50, 25)
        Me.ToolStripButton1.Text = "Cores"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripButton2.Text = "B"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripButton3.Text = "I"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 25)
        Me.ToolStripButton4.Text = "S"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 28)
        '
        'FrmAnotacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 562)
        Me.Controls.Add(Me.TableLayoutPanel5)
        Me.KeyPreview = True
        Me.Name = "FrmAnotacoes"
        Me.ShowIcon = False
        Me.Text = "Anotações Gerais"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.AnotacoesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxEditor.ResumeLayout(False)
        Me.GroupBoxEditor.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents AnotacoesBindingSource As BindingSource
    Friend WithEvents AnotacoesTableAdapter As PrinceDBDataSetTableAdapters.AnotacoesTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents ButtonInicial As Button
    Friend WithEvents ButtonLegalizacao As Button
    Friend WithEvents ButtonFederal As Button
    Friend WithEvents ButtonEstadual As Button
    Friend WithEvents ButtonPrefeitura As Button
    Friend WithEvents ButtonDemais As Button
    Friend WithEvents GroupBoxEditor As GroupBox
    Friend WithEvents MudarCorBotao As Button
    Friend WithEvents cbotamanho As ComboBox
    Friend WithEvents cbofonte As ComboBox
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents minhasCores As ColorDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonLimpar As Button
    Friend WithEvents ButtonSalvar As Button
    Friend WithEvents lblMudaTexto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonFechar As Button
    Friend WithEvents RichTextBoxAnotacao As RichTextBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnNegrito As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BtnItalico As Button
    Friend WithEvents BtnSublinhado As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripComboBox2 As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
