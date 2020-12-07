Public Class Form3

    Private Property tot As Integer
    Public Sub ref()
        tot = 0
        If CheckBox1.Checked Then
            If RadioButton1.Checked Then
                tot += 20
            End If
            If RadioButton2.Checked Then
                tot += 30
            End If
        End If
        TextBox1.Text = tot.ToString()
        TextBox1.Text += " SR"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Price1_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Price2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Label3.Visible = CheckBox1.Checked


        ref()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you wish to close the program?", "Close program?", MessageBoxButtons.YesNo)

        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = My.Resources.makeup___simple
        Label3.Text = "20 SR"
        ref()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = My.Resources.makeup___formal
        Label3.Text = "30 SR"
        ref()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.totprice += tot

        Dim form4 As New Form4
        form4.Show()
        Me.Hide()

    End Sub
End Class
