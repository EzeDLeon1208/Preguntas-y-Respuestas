Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextUsu.Text = "Admin" And TextCont.Text = "1234" Then
            Form2.Show()

        Else
            MsgBox("Usuario o Contraseña Incorrectos")
            TextUsu.Text = ""
            TextCont.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Desea salir del programa?", vbQuestion + vbYesNo, "Salir") = vbYes Then

            End
        End If
    End Sub
End Class
