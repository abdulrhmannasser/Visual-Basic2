Public Class Form1
    Private Property tot As Integer
    Public Property clientname As String
    Public Property mobilenumber As String

    Public Property totprice As Integer



    Public Sub ref()
        tot = 0
        If CheckBox1.Checked Then
            If RadioButton1.Checked Then
                tot += 60
            End If
            If RadioButton2.Checked Then
                tot += 40
            End If
        End If
        If CheckBox2.Checked Then
            If RadioButton3.Checked Then
                tot += 39
            End If
            If RadioButton4.Checked Then
                tot += 55
            End If
        End If

        TextBox3.Text = tot.ToString()
        TextBox3.Text += " SR"


    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Price1_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Price2_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Label3.Visible = CheckBox1.Checked

        ref()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        Label4.Visible = CheckBox2.Checked

        ref()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox1.Image = My.Resources.skin_care___simple_care

        Label3.Text = "60 SR"

        ref()


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Image = My.Resources.skin_care___deep_clean

        Label3.Text = "40 SR"

        ref()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox1.Image = My.Resources.hair_mask___argan_oil
        Label4.Text = "39 SR"

        ref()

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        PictureBox1.Image = My.Resources.hair_mask__oil_natural

        Label4.Text = "55 SR"

        ref()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you wish to close the program?", "Close program?", MessageBoxButtons.YesNo)

        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Equals("") Then
            MessageBox.Show("Please fill your name")

        ElseIf TextBox2.TextLength < 10 Or Not (TextBox2.Text.StartsWith("05")) Then
            MessageBox.Show("Please fill mobile number starting by 05")

        Else
            clientname = TextBox1.Text
            mobilenumber = TextBox2.Text
            totprice += tot


            Dim form2 As New Form2
            form2.Show()
            Me.Hide()
        End If




    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
