<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPrintRapport
  Inherits System.Windows.Forms.Form

  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing AndAlso components IsNot Nothing Then
      components.Dispose()
    End If
    MyBase.Dispose(disposing)
  End Sub

  Private components As System.ComponentModel.IContainer

  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.components = New System.ComponentModel.Container()
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintRapport))
    Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
    Me.startTimer = New System.Windows.Forms.Timer(Me.components)
    Me.slutTimer = New System.Windows.Forms.Timer(Me.components)
    Me.bilagTimer = New System.Windows.Forms.Timer(Me.components)
    Me.SuspendLayout()
    '
    'crViewer
    '
    Me.crViewer.ActiveViewIndex = -1
    Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
    Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
    Me.crViewer.Location = New System.Drawing.Point(0, 0)
    Me.crViewer.Name = "crViewer"
    Me.crViewer.SelectionFormula = ""
    Me.crViewer.ShowExportButton = False
    Me.crViewer.ShowGotoPageButton = False
    Me.crViewer.ShowGroupTreeButton = False
    Me.crViewer.ShowPageNavigateButtons = False
    Me.crViewer.ShowTextSearchButton = False
    Me.crViewer.ShowZoomButton = False
    Me.crViewer.Size = New System.Drawing.Size(993, 566)
    Me.crViewer.TabIndex = 0
    Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
    Me.crViewer.ViewTimeSelectionFormula = ""
    '
    'startTimer
    '
    Me.startTimer.Interval = 1000
    '
    'slutTimer
    '
    Me.slutTimer.Interval = 1000
    '
    'bilagTimer
    '
    Me.bilagTimer.Interval = 10000
    '
    'frmPrintRapport
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(993, 566)
    Me.Controls.Add(Me.crViewer)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmPrintRapport"
    Me.Text = "Faktureringsbilag"
    Me.ResumeLayout(False)

  End Sub
  Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
  Friend WithEvents startTimer As System.Windows.Forms.Timer
  Friend WithEvents slutTimer As System.Windows.Forms.Timer
  Friend WithEvents bilagTimer As System.Windows.Forms.Timer

End Class
