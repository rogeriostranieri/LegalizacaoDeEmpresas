<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpresaAltStatus
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
        Dim DescricaoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpresaAltStatus))
        Me.BtnFechar = New System.Windows.Forms.Button()
        Me.BtnSalvar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.CADstatusBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CADstatusBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DescricaoTextBox = New System.Windows.Forms.TextBox()
        Me.CADstatusDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CADstatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrinceDBDataSet = New PrinceSistemas.PrinceDBDataSet()
        Me.CADstatusTableAdapter = New PrinceSistemas.PrinceDBDataSetTableAdapters.CADstatusTableAdapter()
        Me.TableAdapterManager = New PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager()
        DescricaoLabel = New System.Windows.Forms.Label()
        CType(Me.CADstatusBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CADstatusBindingNavigator.SuspendLayout()
        CType(Me.CADstatusDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CADstatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescricaoLabel
        '
        DescricaoLabel.AutoSize = True
        DescricaoLabel.Location = New System.Drawing.Point(9, 87)
        DescricaoLabel.Name = "DescricaoLabel"
        DescricaoLabel.Size = New System.Drawing.Size(58, 13)
        DescricaoLabel.TabIndex = 30
        DescricaoLabel.Text = "Descricao:"
        '
        'BtnFechar
        '
        Me.BtnFechar.BackgroundImage = CType(resources.GetObject("BtnFechar.BackgroundImage"), System.Drawing.Image)
        Me.BtnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFechar.Location = New System.Drawing.Point(456, 113)
        Me.BtnFechar.Name = "BtnFechar"
        Me.BtnFechar.Size = New System.Drawing.Size(69, 23)
        Me.BtnFechar.TabIndex = 29
        Me.BtnFechar.Text = "Fechar"
        Me.BtnFechar.UseVisualStyleBackColor = True
        '
        'BtnSalvar
        '
        Me.BtnSalvar.BackgroundImage = CType(resources.GetObject("BtnSalvar.BackgroundImage"), System.Drawing.Image)
        Me.BtnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSalvar.Location = New System.Drawing.Point(456, 55)
        Me.BtnSalvar.Name = "BtnSalvar"
        Me.BtnSalvar.Size = New System.Drawing.Size(69, 23)
        Me.BtnSalvar.TabIndex = 28
        Me.BtnSalvar.Text = "Salvar"
        Me.BtnSalvar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.BackgroundImage = CType(resources.GetObject("BtnNovo.BackgroundImage"), System.Drawing.Image)
        Me.BtnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNovo.ForeColor = System.Drawing.Color.Green
        Me.BtnNovo.Location = New System.Drawing.Point(456, 27)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(69, 22)
        Me.BtnNovo.TabIndex = 26
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.BackgroundImage = CType(resources.GetObject("BtnExcluir.BackgroundImage"), System.Drawing.Image)
        Me.BtnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnExcluir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExcluir.Location = New System.Drawing.Point(456, 84)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(69, 23)
        Me.BtnExcluir.TabIndex = 27
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'CADstatusBindingNavigator
        '
        Me.CADstatusBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CADstatusBindingNavigator.BindingSource = Me.CADstatusBindingSource
        Me.CADstatusBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CADstatusBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CADstatusBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CADstatusBindingNavigatorSaveItem})
        Me.CADstatusBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CADstatusBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CADstatusBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CADstatusBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CADstatusBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CADstatusBindingNavigator.Name = "CADstatusBindingNavigator"
        Me.CADstatusBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CADstatusBindingNavigator.Size = New System.Drawing.Size(586, 25)
        Me.CADstatusBindingNavigator.TabIndex = 30
        Me.CADstatusBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CADstatusBindingNavigatorSaveItem
        '
        Me.CADstatusBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CADstatusBindingNavigatorSaveItem.Image = CType(resources.GetObject("CADstatusBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CADstatusBindingNavigatorSaveItem.Name = "CADstatusBindingNavigatorSaveItem"
        Me.CADstatusBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CADstatusBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'DescricaoTextBox
        '
        Me.DescricaoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CADstatusBindingSource, "Descricao", True))
        Me.DescricaoTextBox.Location = New System.Drawing.Point(73, 84)
        Me.DescricaoTextBox.Name = "DescricaoTextBox"
        Me.DescricaoTextBox.Size = New System.Drawing.Size(352, 20)
        Me.DescricaoTextBox.TabIndex = 31
        '
        'CADstatusDataGridView
        '
        Me.CADstatusDataGridView.AllowUserToAddRows = False
        Me.CADstatusDataGridView.AllowUserToDeleteRows = False
        Me.CADstatusDataGridView.AutoGenerateColumns = False
        Me.CADstatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CADstatusDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.CADstatusDataGridView.DataSource = Me.CADstatusBindingSource
        Me.CADstatusDataGridView.Location = New System.Drawing.Point(15, 216)
        Me.CADstatusDataGridView.Name = "CADstatusDataGridView"
        Me.CADstatusDataGridView.ReadOnly = True
        Me.CADstatusDataGridView.Size = New System.Drawing.Size(461, 209)
        Me.CADstatusDataGridView.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(482, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 32)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Atualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Descricao"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descricao"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 400
        '
        'CADstatusBindingSource
        '
        Me.CADstatusBindingSource.DataMember = "CADstatus"
        Me.CADstatusBindingSource.DataSource = Me.PrinceDBDataSet
        '
        'PrinceDBDataSet
        '
        Me.PrinceDBDataSet.DataSetName = "PrinceDBDataSet"
        Me.PrinceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CADstatusTableAdapter
        '
        Me.CADstatusTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CADstatusTableAdapter = Me.CADstatusTableAdapter
        Me.TableAdapterManager.CNAETableAdapter = Nothing
        Me.TableAdapterManager.ContadorTableAdapter = Nothing
        Me.TableAdapterManager.ContatosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresasTableAdapter = Nothing
        Me.TableAdapterManager.LaudosTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.MunicipioTableAdapter = Nothing
        Me.TableAdapterManager.NaturezajuridicaTableAdapter = Nothing
        Me.TableAdapterManager.TelefonesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrinceSistemas.PrinceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmEmpresaAltStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 445)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CADstatusDataGridView)
        Me.Controls.Add(DescricaoLabel)
        Me.Controls.Add(Me.DescricaoTextBox)
        Me.Controls.Add(Me.CADstatusBindingNavigator)
        Me.Controls.Add(Me.BtnFechar)
        Me.Controls.Add(Me.BtnSalvar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.BtnExcluir)
        Me.Name = "FrmEmpresaAltStatus"
        Me.ShowIcon = False
        Me.Text = "Controle dos Status em Empresas"
        CType(Me.CADstatusBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CADstatusBindingNavigator.ResumeLayout(False)
        Me.CADstatusBindingNavigator.PerformLayout()
        CType(Me.CADstatusDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CADstatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrinceDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnFechar As Button
    Friend WithEvents BtnSalvar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents PrinceDBDataSet As PrinceDBDataSet
    Friend WithEvents CADstatusBindingSource As BindingSource
    Friend WithEvents CADstatusTableAdapter As PrinceDBDataSetTableAdapters.CADstatusTableAdapter
    Friend WithEvents TableAdapterManager As PrinceDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CADstatusBindingNavigator As BindingNavigator
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
    Friend WithEvents CADstatusBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DescricaoTextBox As TextBox
    Friend WithEvents CADstatusDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
