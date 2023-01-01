Public Class Form1
    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        lstOutput.Items.Add(New ListViewItem({txtName.Text, txtScore1.Text, txtScore2.Text, txtScore3.Text}))
    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lstOutput.Columns.Add("Name", 150, HorizontalAlignment.Left)
        lstOutput.Columns.Add("Score 1", 75, HorizontalAlignment.Center)
        lstOutput.Columns.Add("Score 2", 75, HorizontalAlignment.Center)
        lstOutput.Columns.Add("Score 3", 75, HorizontalAlignment.Center)
    End Sub

End Class
