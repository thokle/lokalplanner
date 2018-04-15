<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckTekst
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
    Me.txtTekst = New System.Windows.Forms.TextBox()
    Me.btnLuk = New System.Windows.Forms.Button()
    Me.pgbFile = New System.Windows.Forms.ProgressBar()
    Me.SuspendLayout()
    '
    'txtTekst
    '
    Me.txtTekst.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.txtTekst.Cursor = System.Windows.Forms.Cursors.Default
    Me.txtTekst.ImeMode = System.Windows.Forms.ImeMode.NoControl
    Me.txtTekst.Location = New System.Drawing.Point(8, 8)
    Me.txtTekst.Multiline = True
    Me.txtTekst.Name = "txtTekst"
    Me.txtTekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
    Me.txtTekst.Size = New System.Drawing.Size(840, 512)
    Me.txtTekst.TabIndex = 0
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
    Me.btnLuk.Enabled = False
    Me.btnLuk.Location = New System.Drawing.Point(392, 584)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.Size = New System.Drawing.Size(75, 23)
    Me.btnLuk.TabIndex = 1
    Me.btnLuk.Text = "Luk"
    '
    'pgbFile
    '
    Me.pgbFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.pgbFile.Location = New System.Drawing.Point(8, 552)
    Me.pgbFile.Name = "pgbFile"
    Me.pgbFile.Size = New System.Drawing.Size(840, 16)
    Me.pgbFile.TabIndex = 2
    '
    'frmCheckTekst
    '
    Me.AcceptButton = Me.btnLuk
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(856, 613)
    Me.ControlBox = False
    Me.Controls.Add(Me.pgbFile)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.txtTekst)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Name = "frmCheckTekst"
    Me.ShowInTaskbar = False
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Check tekst"
    Me.TopMost = True
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Friend WithEvents txtTekst As System.Windows.Forms.TextBox
  Friend WithEvents btnLuk As System.Windows.Forms.Button
  Friend WithEvents pgbFile As System.Windows.Forms.ProgressBar
End Class
