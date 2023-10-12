Public Class Form1

    Dim num1 As Double
    Dim num2 As Double
    Dim operation As String
    Dim result As Double
    Dim LastResult As Double
    Dim IsNewOperation As Boolean
    Dim LastNum2Value As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tbResult.Text = "0"

    End Sub

    Private Sub btnentry_Click(sender As Object, e As EventArgs) Handles btn7.Click, btn4.Click, btn5.Click, btn6.Click, btn8.Click, btn9.Click, btn0.Click, btn1.Click, btn2.Click, btn3.Click, btdot.Click

        Dim input = CType(sender, Button)

        If tbResult.Text = "0" Then
            tbResult.Text = ""
            tbResult.Text &= input.Text
        ElseIf input.Text = "." Then
            If Not tbResult.Text.Contains(".") Then
                tbResult.Text = tbResult.Text + input.Text
            End If
        Else
            tbResult.Text = tbResult.Text + input.Text
        End If
        IsNewOperation = True
    End Sub

    Private Sub btSquared_Click(sender As Object, e As EventArgs) Handles btSquared.Click

        Dim num1 As Double = tbResult.Text
        tbResult.Text = num1 * num1

    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click

        Dim dbl1 As String
        Dim dbl2 As String

        dbl1 = num1
        dbl2 = num2

        tbResult.Text = "0"

    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click

        tbResult.Text = "0"

    End Sub

    Private Sub btnPosNeg_Click(sender As Object, e As EventArgs) Handles btnPosNeg.Click

        Dim posneg As Double

        posneg = Convert.ToDouble(-1 * tbResult.Text)
        tbResult.Text = Convert.ToDouble(-1 * tbResult.Text)

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click

        num1 = Convert.ToDouble(tbResult.Text)
        operation = "/"
        tbResult.Text = ""

    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click

        num1 = Convert.ToDouble(tbResult.Text)
        operation = "*"
        tbResult.Text = ""

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click

        num1 = Convert.ToDouble(tbResult.Text)
        operation = "-"
        tbResult.Text = ""

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        num1 = Convert.ToDouble(tbResult.Text)
        operation = "+"
        tbResult.Text = ""

    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click

        If IsNewOperation Then
            Dim num2 = Convert.ToDouble(tbResult.Text)
            LastNum2Value = num2
            If operation = "/" Then
                result = num1 / num2
            ElseIf operation = "*" Then
                result = num1 * num2
            ElseIf operation = "-" Then
                result = num1 - num2
            ElseIf operation = "+" Then
                result = num1 + num2
            End If
        Else
            Dim num1 = Convert.ToDouble(tbResult.Text)
            If operation = "/" Then
                result = num1 / LastNum2Value
            ElseIf operation = "*" Then
                result = num1 * LastNum2Value
            ElseIf operation = "-" Then
                result = num1 - LastNum2Value
            ElseIf operation = "+" Then
                result = num1 + LastNum2Value
            End If
        End If


        tbResult.Text = result.ToString()
        Dim LastResult = tbResult.Text
        IsNewOperation = False

    End Sub
End Class
