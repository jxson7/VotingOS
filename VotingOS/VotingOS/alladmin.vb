Public Class alladmin
    Private Sub AuthorisedmembersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AuthorisedmembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub alladmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.authorisedmembers' table. You can move, or remove it, as needed.
        Me.AuthorisedmembersTableAdapter.Fill(Me.DatabaseDataSet.authorisedmembers)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim mRow As Integer = 0
        Dim newpage As Boolean = True
        With AuthorisedmembersDataGridView
            Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
            fmt.LineAlignment = StringAlignment.Center
            fmt.Trimming = StringTrimming.EllipsisCharacter
            Dim y As Single = e.MarginBounds.Top
            Do While mRow < .RowCount
                Dim row As DataGridViewRow = .Rows(mRow)
                Dim x As Single = e.MarginBounds.Left
                Dim h As Single = 0
                For Each cell As DataGridViewCell In row.Cells
                    Dim rc As RectangleF = New RectangleF(x, y, cell.Size.Width, cell.Size.Height)
                    e.Graphics.DrawRectangle(Pens.Black, rc.Left, rc.Top, rc.Width, rc.Height)
                    If (newpage) Then
                        e.Graphics.DrawString(AuthorisedmembersDataGridView.Columns(cell.ColumnIndex).HeaderText, .Font, Brushes.Black, rc, fmt)
                    Else
                        e.Graphics.DrawString(AuthorisedmembersDataGridView.Rows(cell.RowIndex).Cells(cell.ColumnIndex).FormattedValue.ToString(), .Font, Brushes.Black, rc, fmt)
                    End If
                    x += rc.Width
                    h = Math.Max(h, rc.Height)
                Next
                newpage = False
                y += h
                mRow += 1
                If y + h > e.MarginBounds.Bottom Then
                    e.HasMorePages = True
                    mRow -= 1
                    newpage = True
                    Exit Sub
                End If
            Loop
            mRow = 0
        End With
    End Sub
    End Sub
End Class