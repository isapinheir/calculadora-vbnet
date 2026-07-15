Public Class Calculadora
    Dim Num1, Num2 As String
    Dim Op, Soma, Subtracao, Multiplicacao, Divisao As Boolean
    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles Btn.Click
        TxtResult.Text += Btn.Text
        If Op = False Then
            Num1 = Num1 + Btn.Text
        Else
            Num2 = Num2 + Btn.Text
        End If
    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TxtResult.Text += Btn1.Text
        If Op = False Then
            Num1 = Num1 + Btn1.Text
        Else
            Num2 = Num2 + Btn1.Text
        End If
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        TxtResult.Text += Btn2.Text
        If Op = False Then
            Num1 = Num1 + Btn2.Text
        Else
            Num2 = Num2 + Btn2.Text
        End If
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        TxtResult.Text += Btn3.Text
        If Op = False Then
            Num1 = Num1 + Btn3.Text
        Else
            Num2 = Num2 + Btn3.Text
        End If
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        TxtResult.Text += Btn4.Text
        If Op = False Then
            Num1 = Num1 + Btn4.Text
        Else
            Num2 = Num2 + Btn4.Text
        End If
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        TxtResult.Text += Btn5.Text
        If Op = False Then
            Num1 = Num1 + Btn5.Text
        Else
            Num2 = Num2 + Btn5.Text
        End If
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        TxtResult.Text += Btn6.Text
        If Op = False Then
            Num1 = Num1 + Btn6.Text
        Else
            Num2 = Num2 + Btn6.Text
        End If
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        TxtResult.Text += Btn7.Text
        If Op = False Then
            Num1 = Num1 + Btn7.Text
        Else
            Num2 = Num2 + Btn7.Text
        End If
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        TxtResult.Text += Btn8.Text
        If Op = False Then
            Num1 = Num1 + Btn8.Text
        Else
            Num2 = Num2 + Btn8.Text
        End If
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        TxtResult.Text += Btn9.Text
        If Op = False Then
            Num1 = Num1 + Btn9.Text
        Else
            Num2 = Num2 + Btn9.Text
        End If
    End Sub

    Private Sub BtnSo_Click(sender As Object, e As EventArgs) Handles BtnSo.Click
        Op = True
        Soma = True
        TxtResult.Text += " + "
    End Sub

    Private Sub BtnSu_Click(sender As Object, e As EventArgs) Handles BtnSu.Click
        Op = True
        Subtracao = True
        TxtResult.Text += " - "
    End Sub

    Private Sub BtnMult_Click(sender As Object, e As EventArgs) Handles BtnMult.Click
        Op = True
        Multiplicacao = True
        TxtResult.Text += " X "
    End Sub

    Private Sub BtnDiv_Click(sender As Object, e As EventArgs) Handles BtnDiv.Click
        Op = True
        Divisao = True
        TxtResult.Text += " ÷ "
    End Sub

    Private Sub BtnIgual_Click(sender As Object, e As EventArgs) Handles BtnIgual.Click
        If Soma = True Then
            TxtResult.Text = Val(Num1) + Val(Num2)
        End If
        If Subtracao = True Then
            TxtResult.Text = Val(Num1) - Val(Num2)
        End If
        If Multiplicacao = True Then
            TxtResult.Text = Val(Num1) * Val(Num2)
        End If
        If Divisao = True Then
            TxtResult.Text = Val(Num1) / Val(Num2)
        End If
        Soma = False
        Subtracao = False
        Multiplicacao = False
        Divisao = False
        Op = False
    End Sub
    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        TxtResult.Text = ""
        Num1 = ""
        Num2 = ""
    End Sub
End Class