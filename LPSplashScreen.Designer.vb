<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LPSplashScreen
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LPSplashScreen))
    Me.TextBoxDescription = New System.Windows.Forms.TextBox()
    Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
    Me.LabelProductName = New System.Windows.Forms.Label()
    Me.LabelVersion = New System.Windows.Forms.Label()
    Me.LabelCopyright = New System.Windows.Forms.Label()
    Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.TableLayoutPanel.SuspendLayout()
    Me.SuspendLayout()
    '
    'TextBoxDescription
    '
    Me.TextBoxDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TextBoxDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.TextBoxDescription.Location = New System.Drawing.Point(173, 161)
    Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
    Me.TextBoxDescription.Multiline = True
    Me.TextBoxDescription.Name = "TextBoxDescription"
    Me.TextBoxDescription.ReadOnly = True
    Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBoxDescription.Size = New System.Drawing.Size(331, 119)
    Me.TextBoxDescription.TabIndex = 0
    Me.TextBoxDescription.TabStop = False
    Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
    '
    'LogoPictureBox
    '
    Me.LogoPictureBox.BackColor = System.Drawing.SystemColors.Control
    Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
    Me.TableLayoutPanel.SetColumnSpan(Me.LogoPictureBox, 2)
    Me.LogoPictureBox.Image = Global.WinPlanner.My.Resources.Resources.logo
    Me.LogoPictureBox.InitialImage = Global.WinPlanner.My.Resources.Resources.ny_stor
    Me.LogoPictureBox.Location = New System.Drawing.Point(3, 3)
    Me.LogoPictureBox.Name = "LogoPictureBox"
    Me.LogoPictureBox.Size = New System.Drawing.Size(500, 79)
    Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
    Me.LogoPictureBox.TabIndex = 0
    Me.LogoPictureBox.TabStop = False
    '
    'LabelProductName
    '
    Me.LabelProductName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.TableLayoutPanel.SetColumnSpan(Me.LabelProductName, 2)
    Me.LabelProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelProductName.Location = New System.Drawing.Point(6, 85)
    Me.LabelProductName.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelProductName.Name = "LabelProductName"
    Me.LabelProductName.Size = New System.Drawing.Size(498, 23)
    Me.LabelProductName.TabIndex = 0
    Me.LabelProductName.Text = "Product Name"
    Me.LabelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelVersion
    '
    Me.LabelVersion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelVersion.Location = New System.Drawing.Point(173, 108)
    Me.LabelVersion.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelVersion.Name = "LabelVersion"
    Me.LabelVersion.Size = New System.Drawing.Size(331, 25)
    Me.LabelVersion.TabIndex = 0
    Me.LabelVersion.Text = "Version {0:00}.{1:00}.{2:00}.{3:0000}"
    Me.LabelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'LabelCopyright
    '
    Me.LabelCopyright.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.LabelCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.LabelCopyright.Location = New System.Drawing.Point(6, 158)
    Me.LabelCopyright.Margin = New System.Windows.Forms.Padding(6, 0, 3, 0)
    Me.LabelCopyright.Name = "LabelCopyright"
    Me.LabelCopyright.Size = New System.Drawing.Size(158, 125)
    Me.LabelCopyright.TabIndex = 0
    Me.LabelCopyright.Text = "Copyright"
    '
    'TableLayoutPanel
    '
    Me.TableLayoutPanel.AutoSize = True
    Me.TableLayoutPanel.ColumnCount = 2
    Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.00395!))
    Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.99605!))
    Me.TableLayoutPanel.Controls.Add(Me.TextBoxDescription, 1, 4)
    Me.TableLayoutPanel.Controls.Add(Me.LogoPictureBox, 0, 0)
    Me.TableLayoutPanel.Controls.Add(Me.LabelProductName, 0, 1)
    Me.TableLayoutPanel.Controls.Add(Me.LabelVersion, 1, 2)
    Me.TableLayoutPanel.Controls.Add(Me.LabelCopyright, 0, 4)
    Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
    Me.TableLayoutPanel.Location = New System.Drawing.Point(0, 0)
    Me.TableLayoutPanel.Name = "TableLayoutPanel"
    Me.TableLayoutPanel.RowCount = 5
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle())
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.37113!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.37113!))
    Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.34021!))
    Me.TableLayoutPanel.Size = New System.Drawing.Size(507, 283)
    Me.TableLayoutPanel.TabIndex = 1
    '
    'LPSplashScreen
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
    Me.ClientSize = New System.Drawing.Size(507, 283)
    Me.ControlBox = False
    Me.Controls.Add(Me.TableLayoutPanel)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.MaximizeBox = False
    Me.MinimizeBox = False
    Me.Name = "LPSplashScreen"
    Me.ShowInTaskbar = False
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
    Me.Text = "Starter Lokalplanner.Net"
    CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
    Me.TableLayoutPanel.ResumeLayout(False)
    Me.TableLayoutPanel.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
  Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
  Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
  Friend WithEvents LabelProductName As System.Windows.Forms.Label
  Friend WithEvents LabelVersion As System.Windows.Forms.Label
  Friend WithEvents LabelCopyright As System.Windows.Forms.Label

End Class
