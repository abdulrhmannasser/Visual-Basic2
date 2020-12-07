Public Class Form4


    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Price1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Price2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = Form1.clientname
        TextBox2.Text = Form1.mobilenumber
        TextBox3.Text = Form1.totprice.ToString()
        TextBox3.Text += " SR"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you wish to close the program?", "Close program?", MessageBoxButtons.YesNo)

        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
