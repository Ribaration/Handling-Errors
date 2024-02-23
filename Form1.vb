Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As String = TextBox1.Text
        Dim inputNumber As Double


        Label1.Text = ""
        Label1.ForeColor = Color.Black ' Set label color to black


        If Double.TryParse(userInput, inputNumber) Then
            ' If successful, calculate the square of the number
            Dim result As Double = inputNumber * inputNumber
            Label1.Text = "Square of " & userInput & " is " & result
        Else
            ' If conversion fails, display an error message in red color
            Label1.Text = "Error: Please enter a valid numeric value."
            Label1.ForeColor = Color.Red ' Set label color to red
        End If
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setting label font
        Label1.Font = New Font("Arial", 12, FontStyle.Bold)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
