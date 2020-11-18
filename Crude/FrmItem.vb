Public Class FrmItem
    Dim SQL As String
    Dim Process As New ClsConnection
    Dim tblItem As DataTable
    Sub Data_Record()
        tblItem = Process.ExecuteQuery("Select * From TblItem order by No_item asc")
        DGItem.DataSource = tblItem
        DGItem.Columns(1).Width = 100
    End Sub
    Sub Code_Otomatic()
        tblItem = Process.ExecuteQuery("Select * From TblItem order by No_item desc")
        If tblItem.Rows.Count = 0 Then
            NoItemTxt.Text = "000001"
        Else
            With tblItem.Rows(0)
                NoItemTxt.Text = .Item("No_item")
            End With

            NoItemTxt.Text = Val(NoItemTxt.Text) + 1

            Select Case Len(NoItemTxt.Text)
                Case 1
                    NoItemTxt.Text = "00000" & NoItemTxt.Text & ""
                Case 2
                    NoItemTxt.Text = "0000" & NoItemTxt.Text & ""
                Case 3
                    NoItemTxt.Text = "000" & NoItemTxt.Text & ""
                Case 4
                    NoItemTxt.Text = "00" & NoItemTxt.Text & ""
                Case 5
                    NoItemTxt.Text = "0" & NoItemTxt.Text & ""
                Case 6
                    NoItemTxt.Text = "" & NoItemTxt.Text & ""
            End Select
        End If
    End Sub

    Sub Arrange()
        NmItemTxt.Text = ""
        NmItemTxt.Focus()
        CategoryTxt.Text = ""
        UnitTxt.Text = ""
        StockTxt.Text = "0"
        Call Code_Otomatic()
        Call Data_Record()
        SaveBtn.Enabled = True
        EditBtn.Enabled = False
        DeleteBtn.Enabled = False
    End Sub


    Private Sub FrmItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Arrange()
    End Sub


    Private Sub SaveBtn_Click(sender As System.Object, e As System.EventArgs) Handles SaveBtn.Click
        If NmItemTxt.Text = "" Then NmItemTxt.Focus() : Exit Sub
        If CategoryTxt.Text = "" Then CategoryTxt.Focus() : Exit Sub
        If UnitTxt.Text = "" Then UnitTxt.Focus() : Exit Sub
        If StockTxt.Text = "" Then StockTxt.Focus() : Exit Sub

        SQL = "Insert Into TblItem Values ('" & NoItemTxt.Text & "','" & NmItemTxt.Text & "','" & CategoryTxt.Text & "','" & UnitTxt.Text & "','" & StockTxt.Text & "')"
        Process.ExecuteNonQuery(SQL)
        MessageBox.Show("New Data has been Saved..!!", "Saving success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Arrange()
    End Sub

    Private Sub EditBtn_Click(sender As System.Object, e As System.EventArgs) Handles EditBtn.Click
        If NmItemTxt.Text = "" Then NmItemTxt.Focus() : Exit Sub
        If CategoryTxt.Text = "" Then CategoryTxt.Focus() : Exit Sub
        If UnitTxt.Text = "" Then UnitTxt.Focus() : Exit Sub
        If StockTxt.Text = "" Then StockTxt.Focus() : Exit Sub

        SQL = "Update Into TblItem Set Name_item = '" & NmItemTxt.Text & "', Category = '" & CategoryTxt.Text & "',Unit = '" & UnitTxt.Text & "', Stock = '" & StockTxt.Text & "'where No_item = '" & NoItemTxt.Text & "'"
        Process.ExecuteNonQuery(SQL)
        MessageBox.Show("New Data has been changed..!!", "Changing Data Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Arrange()
    End Sub

    Private Sub DeleteBtn_Click(sender As System.Object, e As System.EventArgs) Handles DeleteBtn.Click
        SQL = "Delete From TblItem Where No_item = '" & NoItemTxt.Text & "'"
        Process.ExecuteNonQuery(SQL)
        MessageBox.Show("Data has been deleted..!!", "Deleting Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Arrange()
    End Sub

    Private Sub CancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles CancelBtn.Click
        Call Arrange()
    End Sub


    Private Sub DGItem_DoubleClick(ByVal sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGItem.CellDoubleClick
        NoItemTxt.Text = DGItem.SelectedCells(0).Value
        NmItemTxt.Text = DGItem.SelectedCells(1).Value
        CategoryTxt.Text = DGItem.SelectedCells(2).Value
        UnitTxt.Text = DGItem.SelectedCells(3).Value
        StockTxt.Text = DGItem.SelectedCells(4).Value

        SaveBtn.Enabled = False
        EditBtn.Enabled = True
        DeleteBtn.Enabled = True
        CancelBtn.Enabled = True
    End Sub

    Private Sub FindTxt_TextChanged(sender As System.Object, e As System.EventArgs) Handles FindTxt.TextChanged
        If NameRb.Checked = True Then
            tblItem = Process.ExecuteQuery("Select * From TblItem Where Name_item Like '%" & FindTxt.Text & "%'")
            If tblItem.Rows.Count = 0 Then
                DGItem.DataSource = tblItem
                FindTxt.Focus()
            Else
                DGItem.DataSource = tblItem
            End If
        ElseIf CategoryRb.Checked = True Then
            tblItem = Process.ExecuteQuery("Select * From TblItem Where Category Like '%" & FindTxt.Text & "%'")
            If tblItem.Rows.Count = 0 Then
                DGItem.DataSource = tblItem
                FindTxt.Focus()
            Else
                DGItem.DataSource = tblItem
            End If
        ElseIf UnitRb.Checked = True Then
            tblItem = Process.ExecuteQuery("Select * From TblItem Where Unit Like '%" & FindTxt.Text & "%'")
            If tblItem.Rows.Count = 0 Then
                DGItem.DataSource = tblItem
                FindTxt.Focus()
            Else
                DGItem.DataSource = tblItem
            End If
        End If
    End Sub
End Class