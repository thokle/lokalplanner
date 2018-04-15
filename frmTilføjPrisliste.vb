Imports System.Windows.Forms

Public Class frmTilføjPrisliste

  Public ReadOnly Property ValgtPrisliste() As Integer
    Get
      Return TblPrislisterDataGridView.CurrentRow.Cells(0).Value
    End Get
  End Property

  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTilføj.Click
    Me.TblPrislisterBindingSource.EndEdit()
    Me.TblPrislisterTableAdapter.Update(Me.DstPrislister.tblPrislister)
    Me.DialogResult = System.Windows.Forms.DialogResult.OK
  End Sub

  Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuller.Click
    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
  End Sub

  Private Sub frmTilføjPrisliste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Me.TblPrislisterTableAdapter.Fill(Me.DstPrislister.tblPrislister)
  End Sub

End Class
