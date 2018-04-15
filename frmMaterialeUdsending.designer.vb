<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaterialeUdsending
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaterialeUdsending))
    Me.lblBureauOrdreNr = New System.Windows.Forms.Label
    Me.lblFilnavn = New System.Windows.Forms.Label
    Me.lblSendAlle = New System.Windows.Forms.Label
    Me.lblErSendt = New System.Windows.Forms.Label
    Me.lblOrdreInfo = New System.Windows.Forms.Label
    Me.lblAviser = New System.Windows.Forms.Label
    Me.lblAvisnavn1 = New System.Windows.Forms.Label
    Me.txtBureauordrenr1 = New System.Windows.Forms.TextBox
    Me.txtFilnavn1 = New System.Windows.Forms.TextBox
    Me.chkSend1 = New System.Windows.Forms.CheckBox
    Me.listBox1 = New System.Windows.Forms.ListBox
    Me.btnSkiftDirectory = New System.Windows.Forms.Button
    Me.chkErSendt1 = New System.Windows.Forms.CheckBox
    Me.openFile = New System.Windows.Forms.OpenFileDialog
    Me.sqlConn = New System.Data.SqlClient.SqlConnection
    Me.sqlComm = New System.Data.SqlClient.SqlCommand
    Me.chkSendAlle = New System.Windows.Forms.CheckBox
    Me.chkSammeFil = New System.Windows.Forms.CheckBox
    Me.chkSammeNr = New System.Windows.Forms.CheckBox
    Me.btnSendMateriale = New System.Windows.Forms.Button
    Me.sqlDelMateriale = New System.Data.SqlClient.SqlCommand
    Me.sqlInsertMateriale = New System.Data.SqlClient.SqlCommand
    Me.btnLuk = New System.Windows.Forms.Button
    Me.pnlControls = New System.Windows.Forms.Panel
    Me.pbTransfer = New System.Windows.Forms.ProgressBar
    Me.timer = New System.Windows.Forms.Timer(Me.components)
    Me.pnlControls.SuspendLayout()
    Me.SuspendLayout()
    '
    'lblBureauOrdreNr
    '
    Me.lblBureauOrdreNr.AutoSize = True
    Me.lblBureauOrdreNr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblBureauOrdreNr.Location = New System.Drawing.Point(516, 48)
    Me.lblBureauOrdreNr.Name = "lblBureauOrdreNr"
    Me.lblBureauOrdreNr.Size = New System.Drawing.Size(101, 17)
    Me.lblBureauOrdreNr.TabIndex = 2
    Me.lblBureauOrdreNr.Text = "Bureauordrenr"
    '
    'lblFilnavn
    '
    Me.lblFilnavn.AutoSize = True
    Me.lblFilnavn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblFilnavn.Location = New System.Drawing.Point(237, 48)
    Me.lblFilnavn.Name = "lblFilnavn"
    Me.lblFilnavn.Size = New System.Drawing.Size(53, 17)
    Me.lblFilnavn.TabIndex = 3
    Me.lblFilnavn.Text = "Filnavn"
    '
    'lblSendAlle
    '
    Me.lblSendAlle.AutoSize = True
    Me.lblSendAlle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblSendAlle.Location = New System.Drawing.Point(408, 48)
    Me.lblSendAlle.Name = "lblSendAlle"
    Me.lblSendAlle.Size = New System.Drawing.Size(68, 17)
    Me.lblSendAlle.TabIndex = 16
    Me.lblSendAlle.Text = "Send Alle"
    '
    'lblErSendt
    '
    Me.lblErSendt.AutoSize = True
    Me.lblErSendt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblErSendt.Location = New System.Drawing.Point(452, 69)
    Me.lblErSendt.Name = "lblErSendt"
    Me.lblErSendt.Size = New System.Drawing.Size(61, 17)
    Me.lblErSendt.TabIndex = 25
    Me.lblErSendt.Text = "Er sendt"
    '
    'lblOrdreInfo
    '
    Me.lblOrdreInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblOrdreInfo.Location = New System.Drawing.Point(8, 8)
    Me.lblOrdreInfo.Name = "lblOrdreInfo"
    Me.lblOrdreInfo.Size = New System.Drawing.Size(928, 23)
    Me.lblOrdreInfo.TabIndex = 0
    Me.lblOrdreInfo.Text = "Materialeudsendelse for Ordre Nr. ##### kunde : XXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
    '
    'lblAviser
    '
    Me.lblAviser.AutoSize = True
    Me.lblAviser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblAviser.Location = New System.Drawing.Point(8, 48)
    Me.lblAviser.Name = "lblAviser"
    Me.lblAviser.Size = New System.Drawing.Size(47, 17)
    Me.lblAviser.TabIndex = 1
    Me.lblAviser.Text = "Aviser"
    '
    'lblAvisnavn1
    '
    Me.lblAvisnavn1.BackColor = System.Drawing.SystemColors.Highlight
    Me.lblAvisnavn1.ForeColor = System.Drawing.SystemColors.HighlightText
    Me.lblAvisnavn1.Location = New System.Drawing.Point(8, 1)
    Me.lblAvisnavn1.Name = "lblAvisnavn1"
    Me.lblAvisnavn1.Size = New System.Drawing.Size(224, 20)
    Me.lblAvisnavn1.TabIndex = 4
    Me.lblAvisnavn1.Tag = "1"
    Me.lblAvisnavn1.Text = "Avis Navn"
    '
    'txtBureauordrenr1
    '
    Me.txtBureauordrenr1.Location = New System.Drawing.Point(508, 1)
    Me.txtBureauordrenr1.MaxLength = 20
    Me.txtBureauordrenr1.Name = "txtBureauordrenr1"
    Me.txtBureauordrenr1.ReadOnly = True
    Me.txtBureauordrenr1.Size = New System.Drawing.Size(120, 20)
    Me.txtBureauordrenr1.TabIndex = 0
    Me.txtBureauordrenr1.Tag = "1"
    '
    'txtFilnavn1
    '
    Me.txtFilnavn1.AllowDrop = True
    Me.txtFilnavn1.Location = New System.Drawing.Point(237, 1)
    Me.txtFilnavn1.MaxLength = 250
    Me.txtFilnavn1.Name = "txtFilnavn1"
    Me.txtFilnavn1.ReadOnly = True
    Me.txtFilnavn1.Size = New System.Drawing.Size(192, 20)
    Me.txtFilnavn1.TabIndex = 12
    Me.txtFilnavn1.TabStop = False
    Me.txtFilnavn1.Tag = "1"
    '
    'chkSend1
    '
    Me.chkSend1.Location = New System.Drawing.Point(437, 1)
    Me.chkSend1.Name = "chkSend1"
    Me.chkSend1.Size = New System.Drawing.Size(16, 20)
    Me.chkSend1.TabIndex = 17
    Me.chkSend1.TabStop = False
    Me.chkSend1.Tag = "1"
    '
    'listBox1
    '
    Me.listBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.listBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.listBox1.HorizontalScrollbar = True
    Me.listBox1.ItemHeight = 16
    Me.listBox1.Location = New System.Drawing.Point(676, 88)
    Me.listBox1.Name = "listBox1"
    Me.listBox1.Size = New System.Drawing.Size(260, 532)
    Me.listBox1.Sorted = True
    Me.listBox1.TabIndex = 21
    Me.listBox1.TabStop = False
    '
    'btnSkiftDirectory
    '
    Me.btnSkiftDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnSkiftDirectory.Location = New System.Drawing.Point(676, 626)
    Me.btnSkiftDirectory.Name = "btnSkiftDirectory"
    Me.btnSkiftDirectory.Size = New System.Drawing.Size(260, 23)
    Me.btnSkiftDirectory.TabIndex = 23
    Me.btnSkiftDirectory.TabStop = False
    Me.btnSkiftDirectory.Text = "Skift folder"
    '
    'chkErSendt1
    '
    Me.chkErSendt1.Location = New System.Drawing.Point(477, 1)
    Me.chkErSendt1.Name = "chkErSendt1"
    Me.chkErSendt1.Size = New System.Drawing.Size(16, 20)
    Me.chkErSendt1.TabIndex = 24
    Me.chkErSendt1.TabStop = False
    Me.chkErSendt1.Tag = "1"
    '
    'sqlConn
    '
    Me.sqlConn.ConnectionString = "Data Source=dddimp;Initial Catalog=DiMPdotNet;Persist Security Info=True;User ID=" & _
        "sa;Password=hydeliFyt12;Connect Timeout=30"
    Me.sqlConn.FireInfoMessageEventOnUserErrors = False
    '
    'sqlComm
    '
    Me.sqlComm.CommandText = resources.GetString("sqlComm.CommandText")
    Me.sqlComm.Connection = Me.sqlConn
    Me.sqlComm.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MedieplanNr", System.Data.SqlDbType.Int, 4, "MedieplanNr"), New System.Data.SqlClient.SqlParameter("@Version", System.Data.SqlDbType.SmallInt, 2, "Version")})
    '
    'chkSendAlle
    '
    Me.chkSendAlle.Location = New System.Drawing.Point(437, 64)
    Me.chkSendAlle.Name = "chkSendAlle"
    Me.chkSendAlle.Size = New System.Drawing.Size(16, 20)
    Me.chkSendAlle.TabIndex = 27
    Me.chkSendAlle.TabStop = False
    '
    'chkSammeFil
    '
    Me.chkSammeFil.Enabled = False
    Me.chkSammeFil.Location = New System.Drawing.Point(240, 64)
    Me.chkSammeFil.Name = "chkSammeFil"
    Me.chkSammeFil.Size = New System.Drawing.Size(112, 20)
    Me.chkSammeFil.TabIndex = 28
    Me.chkSammeFil.TabStop = False
    Me.chkSammeFil.Text = "Samme fil til alle"
    '
    'chkSammeNr
    '
    Me.chkSammeNr.Enabled = False
    Me.chkSammeNr.Location = New System.Drawing.Point(519, 64)
    Me.chkSammeNr.Name = "chkSammeNr"
    Me.chkSammeNr.Size = New System.Drawing.Size(112, 20)
    Me.chkSammeNr.TabIndex = 29
    Me.chkSammeNr.TabStop = False
    Me.chkSammeNr.Text = "Samme nr til alle"
    '
    'btnSendMateriale
    '
    Me.btnSendMateriale.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnSendMateriale.Enabled = False
    Me.btnSendMateriale.Location = New System.Drawing.Point(260, 640)
    Me.btnSendMateriale.Name = "btnSendMateriale"
    Me.btnSendMateriale.Size = New System.Drawing.Size(136, 24)
    Me.btnSendMateriale.TabIndex = 30
    Me.btnSendMateriale.Text = "Send Materiale"
    '
    'sqlDelMateriale
    '
    Me.sqlDelMateriale.CommandText = "DELETE FROM tblMateriale" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "WHERE     (MedieplanNr = @MedieplanNr)"
    Me.sqlDelMateriale.Connection = Me.sqlConn
    Me.sqlDelMateriale.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MedieplanNr", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MedieplanNr", System.Data.DataRowVersion.Original, Nothing)})
    '
    'sqlInsertMateriale
    '
    Me.sqlInsertMateriale.CommandText = "INSERT INTO tblMateriale" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                      (MedieplanNr, UgeavisID, FilNavn," & _
        " ErSendt, FilSti, SkalSendes)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VALUES     (@MedieplanNr,@BladID,@Filnavn,@ErSend" & _
        "t,@filSti,@skalSendes)"
    Me.sqlInsertMateriale.Connection = Me.sqlConn
    Me.sqlInsertMateriale.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MedieplanNr", System.Data.SqlDbType.Int, 4, "MedieplanNr"), New System.Data.SqlClient.SqlParameter("@BladID", System.Data.SqlDbType.Int, 4, "UgeavisID"), New System.Data.SqlClient.SqlParameter("@Filnavn", System.Data.SqlDbType.NVarChar, 100, "FilNavn"), New System.Data.SqlClient.SqlParameter("@ErSendt", System.Data.SqlDbType.Bit, 1, "ErSendt"), New System.Data.SqlClient.SqlParameter("@filSti", System.Data.SqlDbType.NVarChar, 250, "FilSti"), New System.Data.SqlClient.SqlParameter("@skalSendes", System.Data.SqlDbType.Bit, 1, "SkalSendes")})
    '
    'btnLuk
    '
    Me.btnLuk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.btnLuk.DialogResult = System.Windows.Forms.DialogResult.Cancel
    Me.btnLuk.Location = New System.Drawing.Point(832, 673)
    Me.btnLuk.Name = "btnLuk"
    Me.btnLuk.Size = New System.Drawing.Size(104, 23)
    Me.btnLuk.TabIndex = 31
    Me.btnLuk.Text = "Luk"
    '
    'pnlControls
    '
    Me.pnlControls.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.pnlControls.AutoScroll = True
    Me.pnlControls.Controls.Add(Me.lblAvisnavn1)
    Me.pnlControls.Controls.Add(Me.txtBureauordrenr1)
    Me.pnlControls.Controls.Add(Me.txtFilnavn1)
    Me.pnlControls.Controls.Add(Me.chkSend1)
    Me.pnlControls.Controls.Add(Me.chkErSendt1)
    Me.pnlControls.Location = New System.Drawing.Point(0, 88)
    Me.pnlControls.Name = "pnlControls"
    Me.pnlControls.Size = New System.Drawing.Size(631, 536)
    Me.pnlControls.TabIndex = 32
    '
    'pbTransfer
    '
    Me.pbTransfer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.pbTransfer.Location = New System.Drawing.Point(8, 680)
    Me.pbTransfer.Name = "pbTransfer"
    Me.pbTransfer.Size = New System.Drawing.Size(623, 16)
    Me.pbTransfer.TabIndex = 38
    Me.pbTransfer.Visible = False
    '
    'timer
    '
    Me.timer.Interval = 1000
    '
    'frmMaterialeUdsending
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.CancelButton = Me.btnLuk
    Me.ClientSize = New System.Drawing.Size(950, 725)
    Me.Controls.Add(Me.pbTransfer)
    Me.Controls.Add(Me.pnlControls)
    Me.Controls.Add(Me.btnLuk)
    Me.Controls.Add(Me.btnSendMateriale)
    Me.Controls.Add(Me.chkSammeNr)
    Me.Controls.Add(Me.chkSammeFil)
    Me.Controls.Add(Me.chkSendAlle)
    Me.Controls.Add(Me.lblErSendt)
    Me.Controls.Add(Me.btnSkiftDirectory)
    Me.Controls.Add(Me.listBox1)
    Me.Controls.Add(Me.lblSendAlle)
    Me.Controls.Add(Me.lblFilnavn)
    Me.Controls.Add(Me.lblBureauOrdreNr)
    Me.Controls.Add(Me.lblAviser)
    Me.Controls.Add(Me.lblOrdreInfo)
    Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmMaterialeUdsending"
    Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
    Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
    Me.Text = "Materialeudsendelse for Ordre Nr. #####"
    Me.TopMost = True
    Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    Me.pnlControls.ResumeLayout(False)
    Me.pnlControls.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub

  Private WithEvents listBox1 As System.Windows.Forms.ListBox
  Private WithEvents txtFilnavn1 As System.Windows.Forms.TextBox
  Private WithEvents chkSend1 As System.Windows.Forms.CheckBox
  Private WithEvents lblAvisnavn1 As System.Windows.Forms.Label
  Private WithEvents txtBureauordrenr1 As System.Windows.Forms.TextBox
  Private WithEvents chkErSendt1 As System.Windows.Forms.CheckBox
  Private WithEvents openFile As System.Windows.Forms.OpenFileDialog
  Private lblOrdreInfo As System.Windows.Forms.Label
  Private sqlConn As System.Data.SqlClient.SqlConnection
  Private sqlComm As System.Data.SqlClient.SqlCommand
  Private WithEvents chkSendAlle As System.Windows.Forms.CheckBox
  Private WithEvents btnSkiftDirectory As System.Windows.Forms.Button
  Private WithEvents chkSammeFil As System.Windows.Forms.CheckBox
  Private WithEvents chkSammeNr As System.Windows.Forms.CheckBox
  Private WithEvents btnSendMateriale As System.Windows.Forms.Button
  Private sqlDelMateriale As System.Data.SqlClient.SqlCommand
  Private sqlInsertMateriale As System.Data.SqlClient.SqlCommand
  Private WithEvents btnLuk As System.Windows.Forms.Button
  Private pnlControls As System.Windows.Forms.Panel
  Private lblAviser As System.Windows.Forms.Label
  Private WithEvents pbTransfer As System.Windows.Forms.ProgressBar
  Private WithEvents timer As System.Windows.Forms.Timer
  Friend WithEvents lblFilnavn As System.Windows.Forms.Label
  Friend WithEvents lblSendAlle As System.Windows.Forms.Label
  Friend WithEvents lblErSendt As System.Windows.Forms.Label
  Friend WithEvents lblBureauOrdreNr As System.Windows.Forms.Label
End Class
