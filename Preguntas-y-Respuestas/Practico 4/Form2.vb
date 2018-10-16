Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Cont, Cont2 As Integer

        Cont = 0
        Cont2 = 0

        If Preg1.Text = "Español" Then
            Label2.Visible = True
            Cont = Cont + 1

        Else
            Preg1.BackColor = Color.Red
            Cont2 = Cont2 + 1

        End If

        If Preg2.Text = "Paris" Then
            Label3.Visible = True
            Cont = Cont + 1

        Else
            Preg2.BackColor = Color.Red
            Cont2 = Cont2 + 1

        End If

        If Preg3.Text = "25 de Mayo" Then
            Label4.Visible = True
            Cont = Cont + 1

        Else
            Preg3.BackColor = Color.Red
            Cont2 = Cont2 + 1

        End If

        If Preg4.Text = "Navidad" Then
            Label5.Visible = True
            Cont = Cont + 1

        Else
            Preg4.BackColor = Color.Red
            Cont2 = Cont2 + 1

        End If

        If Preg5.Text = "Jorge" Then
            Label6.Visible = True
            Cont = Cont + 1

        Else
            Preg5.BackColor = Color.Red
            Cont2 = Cont2 + 1

        End If

        If Preg6.Text = "15" Then
            Label8.Visible = True
            Cont = Cont + 1

        Else
            Preg6.BackColor = Color.Red
            Cont2 = Cont2 + 1

        End If


        If Preg7.Text = "Roberto Sanchez" Then
            Label9.Visible = True
            Cont = Cont + 1

        Else
            Preg7.BackColor = Color.Red
            Cont2 = Cont2 + 1

        End If

        If Preg8.Text = "Alemania" Then
            Label10.Visible = True
            Cont = Cont + 1

        Else
            Preg8.BackColor = Color.Red
            Cont2 = Cont2 + 1

        End If


        If Preg9.Text = "Pablo" Then
            Label7.Visible = True
            Cont = Cont + 1

        Else
            Preg9.BackColor = Color.Red
            Cont2 = Cont2 + 1
        End If

        If Preg10.Text = "Astrónomo" Then
            Label11.Visible = True
            Cont = Cont + 1

        Else
            Preg10.BackColor = Color.Red
            Cont2 = Cont2 + 1

        End If
        TextBox1.Text = CStr(Cont)
        TextBox2.Text = CStr(Cont2)
        TextBox3.Text = CStr(Cont * 100) / 10

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Preg1.Text = ""
        Preg1.BackColor = Color.White
        Preg2.Text = ""
        Preg2.BackColor = Color.White
        Preg3.Text = ""
        Preg3.BackColor = Color.White
        Preg4.Text = ""
        Preg4.BackColor = Color.White
        Preg5.Text = ""
        Preg5.BackColor = Color.White
        Preg6.Text = ""
        Preg6.BackColor = Color.White
        Preg7.Text = ""
        Preg7.BackColor = Color.White
        Preg8.Text = ""
        Preg8.BackColor = Color.White
        Preg9.Text = ""
        Preg9.BackColor = Color.White
        Preg10.Text = ""
        Preg10.BackColor = Color.White
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class