Public Class Form2
    Private Property tot As Integer

    Public Sub ref()
        tot = 0
        If CheckBox1.Checked Then
            If RadioButton1.Checked Then
                tot += 55
            End If
            If RadioButton2.Checked Then
                tot += 30
            End If
        End If
        If CheckBox2.Checked Then
            If RadioButton3.Checked Then
                tot += 40
            End If
            If RadioButton4.Checked Then
                tot += 45
            End If
        End If

        TextBox3.Text = tot.ToString()
        TextBox3.Text += " SR"


    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Price1_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Price2_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ref()
        Label3.Visible = CheckBox1.Checked

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ref()
        Label4.Visible = CheckBox2.Checked

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = My.Resources.hair_cut___short_hair

        Label3.Text = "55 SR"

        ref()

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = My.Resources.hair_cut___long_hair


        Label3.Text = "30 SR"

        ref()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.Image = My.Resources.body_care__hand_nail


        Label4.Text = "40 SR"

        ref()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox1.Image = My.Resources.body_care___leg_care


        Label4.Text = "45 SR"

        ref()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.totprice += tot


        Dim form3 As New Form3
        form3.Show()
        Me.Hide()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you wish to close the program?", "Close program?", MessageBoxButtons.YesNo)

        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class
