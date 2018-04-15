<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTilføjPrisliste
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTilføjPrisliste))
    Me.btnAnnuller = New System.Windows.Forms.Button
    Me.btnTilføj = New System.Windows.Forms.Button
    Me.DstPrislister = New WinPlanner.dstPrislister
    Me.TblPrislisterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
    Me.TblPrislisterTableAdapter = New WinPlanner.dstPrislisterTableAdapters.tblPrislisterTableAdapter
    Me.TblPrislisterDataGridView = New System.Windows.Forms.DataGridView
    Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
    Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
    CType(Me.DstPrislister, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblPrislisterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.TblPrislisterDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'btnAnnuller
    '
    Me.btnAnnuller.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnAnnuller.Location = New System.Drawing.Point(12, 164)
    Me.btnAnnuller.Name = "btnAnnuller"
    Me.btnAnnuller.Size = New System.Drawing.Size(67, 23)
    Me.btnAnnuller.TabIndex = 1
    Me.btnAnnuller.Text = "Annuller"
    '
    'btnTilføj
    '
    Me.btnTilføj.Location = New System.Drawing.Point(309, 164)
    Me.btnTilføj.Name = "btnTilføj"
    Me.btnTilføj.Size = New System.Drawing.Size(67, 23)
    Me.btnTilføj.TabIndex = 0
    Me.btnTilføj.Text = "Tilføj"
    '
    'DstPrislister
    '
    Me.DstPrislister.DataSetName = "dstPrislister"
    Me.DstPrislister.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
    '
    'TblPrislisterBindingSource
    '
    Me.TblPrislisterBindingSource.DataMember = "tblPrislister"
    Me.TblPrislisterBindingSource.DataSource = Me.DstPrislister
    '
    'TblPrislisterTableAdapter
    '
    Me.TblPrislisterTableAdapter.ClearBeforeFill = True
    '
    'TblPrislisterDataGridView
    '
    Me.TblPrislisterDataGridView.AllowUserToDeleteRows = False
    Me.TblPrislisterDataGridView.AutoGenerateColumns = False
    Me.TblPrislisterDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    Me.TblPrislisterDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
    Me.TblPrislisterDataGridView.DataSource = Me.TblPrislisterBindingSource
    Me.TblPrislisterDataGridView.Location = New System.Drawing.Point(13, 3)
    Me.TblPrislisterDataGridView.MultiSelect = False
    Me.TblPrislisterDataGridView.Name = "TblPrislisterDataGridView"
    Me.TblPrislisterDataGridView.Size = New System.Drawing.Size(364, 155)
    Me.TblPrislisterDataGridView.TabIndex = 2
    '
    'DataGridViewTextBoxColumn1
    '
    Me.DataGridViewTextBoxColumn1.DataPropertyName = "PrislisteID"
    Me.DataGridViewTextBoxColumn1.HeaderText = "PrislisteID"
    Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
    Me.DataGridViewTextBoxColumn1.ReadOnly = True
    Me.DataGridViewTextBoxColumn1.Visible = False
    '
    'DataGridViewTextBoxColumn2
    '
    Me.DataGridViewTextBoxColumn2.DataPropertyName = "PrislisteNavn"
    Me.DataGridViewTextBoxColumn2.HeaderText = "Prisliste"
    Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
    '
    'frmTilføjPrisliste
    '
    Me.AcceptButton = Me.btnTilføj
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnAnnuller
    Me.ClientSize = New System.Drawing.Size(389, 196)
    Me.Controls.Add(Me.TblPrislisterDataGridView)
    Me.Controls.Add(Me.btnAnnuller)
    Me.Controls.Add(Me.btnTilføj)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "frmTilføjPrisliste"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Tilføj Prisliste"
    CType(Me.DstPrislister, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblPrislisterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.TblPrislisterDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents btnAnnuller As System.Windows.Forms.Button
  Friend WithEvents btnTilføj As System.Windows.Forms.Button
  Friend WithEvents DstPrislister As WinPlanner.dstPrislister
  Friend WithEvents TblPrislisterBindingSource As System.Windows.Forms.BindingSource
  Friend WithEvents TblPrislisterTableAdapter As WinPlanner.dstPrislisterTableAdapters.tblPrislisterTableAdapter
  Friend WithEvents TblPrislisterDataGridView As System.Windows.Forms.DataGridView
  Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
  Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
