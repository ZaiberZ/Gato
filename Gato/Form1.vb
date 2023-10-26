Public Class frmCat
    Dim t = 1
    Dim p = 1
    Dim a As Date
    Dim b As Double

    Public Sub maq()

        
        vicu()

        While (t = 2)
            'b = TimeOfDay.Millisecond / 10
            b = Date.Now.Millisecond / 10
            'b = TimeOfDay.Second
            'b = Math.Sin(b) * 100

            If ((Button2.Text = "O" And Button3.Text = "O") Or (Button4.Text = "O" And Button7.Text = "O") Or
                (Button5.Text = "O" And Button9.Text = "O")) And Button1.Enabled Then
                Button1.Text = "O"
                t = 1
                Button1.Enabled = False
                vicm()
            ElseIf ((Button1.Text = "O" And Button3.Text = "O") Or (Button5.Text = "O" And Button8.Text = "O")) And Button2.Enabled Then
                Button2.Text = "O"
                t = 1
                Button2.Enabled = False
                vicm()
            ElseIf ((Button2.Text = "O" And Button1.Text = "O") Or (Button5.Text = "O" And Button7.Text = "O") Or
                (Button6.Text = "O" And Button9.Text = "O")) And Button3.Enabled Then
                Button3.Text = "O"
                t = 1
                Button3.Enabled = False
                vicm()
            ElseIf ((Button1.Text = "O" And Button7.Text = "O") Or (Button5.Text = "O" And Button6.Text = "O")) And Button4.Enabled Then
                Button4.Text = "O"
                t = 1
                Button4.Enabled = False
                vicm()
            ElseIf ((Button9.Text = "O" And Button1.Text = "O") Or (Button3.Text = "O" And Button7.Text = "O") Or
                (Button2.Text = "O" And Button8.Text = "O") Or (Button4.Text = "O" And Button6.Text = "O")) And Button5.Enabled Then
                Button5.Text = "O"
                t = 1
                Button5.Enabled = False
                vicm()
            ElseIf ((Button3.Text = "O" And Button9.Text = "O") Or (Button5.Text = "O" And Button4.Text = "O")) And Button6.Enabled Then
                Button6.Text = "O"
                t = 1
                Button6.Enabled = False
            ElseIf ((Button1.Text = "O" And Button4.Text = "O") Or (Button5.Text = "O" And Button3.Text = "O") Or
            (Button8.Text = "O" And Button9.Text = "O")) And Button7.Enabled Then
                Button7.Text = "O"
                t = 1
                Button7.Enabled = False
                vicm()
            ElseIf ((Button7.Text = "O" And Button9.Text = "O") Or (Button5.Text = "O" And Button2.Text = "O")) And Button8.Enabled Then
                Button8.Text = "O"
                t = 1
                Button8.Enabled = False
                vicm()
            ElseIf ((Button1.Text = "O" And Button5.Text = "O") Or (Button6.Text = "O" And Button3.Text = "O") Or
                (Button8.Text = "O" And Button7.Text = "O")) And Button9.Enabled Then
                Button9.Text = "O"
                t = 1
                Button9.Enabled = False
                vicm()
            ElseIf ((Button2.Text = "X" And Button3.Text = "X") Or (Button4.Text = "X" And Button7.Text = "X") Or
                (Button5.Text = "X" And Button9.Text = "X")) And Button1.Enabled Then
                Button1.Text = "O"
                t = 1
                Button1.Enabled = False
                vicm()
            ElseIf ((Button1.Text = "X" And Button3.Text = "X") Or (Button5.Text = "X" And Button8.Text = "X")) And Button2.Enabled Then
                Button2.Text = "O"
                t = 1
                Button2.Enabled = False
                vicm()
            ElseIf ((Button2.Text = "X" And Button1.Text = "X") Or (Button5.Text = "X" And Button7.Text = "X") Or
                (Button6.Text = "X" And Button9.Text = "X")) And Button3.Enabled Then
                Button3.Text = "O"
                t = 1
                Button3.Enabled = False
                vicm()
            ElseIf ((Button1.Text = "X" And Button7.Text = "X") Or (Button5.Text = "X" And Button6.Text = "X")) And Button4.Enabled Then
                Button4.Text = "O"
                t = 1
                Button4.Enabled = False
                vicm()
            ElseIf ((Button9.Text = "X" And Button1.Text = "X") Or (Button3.Text = "X" And Button7.Text = "X") Or
                (Button2.Text = "X" And Button8.Text = "X") Or (Button4.Text = "X" And Button6.Text = "X")) And Button5.Enabled Then
                Button5.Text = "O"
                t = 1
                Button5.Enabled = False
                vicm()
            ElseIf ((Button3.Text = "X" And Button9.Text = "X") Or (Button5.Text = "X" And Button4.Text = "X")) And Button6.Enabled Then
                Button6.Text = "O"
                t = 1
                Button6.Enabled = False
                vicm()
            ElseIf ((Button1.Text = "X" And Button4.Text = "X") Or (Button5.Text = "X" And Button3.Text = "X") Or
            (Button8.Text = "X" And Button9.Text = "X")) And Button7.Enabled Then
                Button7.Text = "O"
                t = 1
                Button7.Enabled = False
                vicm()
            ElseIf ((Button7.Text = "X" And Button9.Text = "X") Or (Button5.Text = "X" And Button2.Text = "X")) And Button8.Enabled Then
                Button8.Text = "O"
                t = 1
                Button8.Enabled = False
                vicm()
            ElseIf ((Button1.Text = "X" And Button5.Text = "X") Or (Button6.Text = "X" And Button3.Text = "X") Or
                (Button8.Text = "X" And Button7.Text = "X")) And Button9.Enabled Then
                Button9.Text = "O"
                t = 1
                Button9.Enabled = False
                vicm()
            Else
                If (b > 0 And b < 11.11) And Button1.Enabled Then
                    Button1.Text = "O"
                    t = 1
                    Button1.Enabled = False
                End If
                If (b > 11.12 And b < 22.22) And Button2.Enabled Then
                    Button2.Text = "O"
                    t = 1
                    Button2.Enabled = False
                End If
                If (b > 22.23 And b < 33.33) And Button3.Enabled Then
                    Button3.Text = "O"
                    t = 1
                    Button3.Enabled = False
                End If
                If (b > 33.34 And b < 44.44) And Button4.Enabled Then
                    Button4.Text = "O"
                    t = 1
                    Button4.Enabled = False
                End If
                If (b > 44.45 And b < 55.55) And Button5.Enabled Then
                    Button5.Text = "O"
                    t = 1
                    Button5.Enabled = False
                End If
                If (b > 55.56 And b < 66.66) And Button6.Enabled Then
                    Button6.Text = "O"
                    t = 1
                    Button6.Enabled = False
                End If
                If (b > 66.67 And b < 77.77) And Button7.Enabled Then
                    Button7.Text = "O"
                    t = 1
                    Button7.Enabled = False
                End If
                If (b > 77.78 And b < 88.88) And Button8.Enabled Then
                    Button8.Text = "O"
                    t = 1
                    Button8.Enabled = False
                End If
                If (b > 88.89 And b < 100) And Button9.Enabled Then
                    Button9.Text = "O"
                    t = 1
                    Button9.Enabled = False
                End If

                vicm()


                If (Button1.Enabled = False) And (Button2.Enabled = False) And (Button3.Enabled = False) And
                    (Button4.Enabled = False) And (Button5.Enabled = False) And (Button6.Enabled = False) And
                    (Button7.Enabled = False) And (Button8.Enabled = False) And (Button9.Enabled = False) Then
                    rei.Visible = True
                    t = 1
                End If
            End If
        End While
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Button1.Text = "X"
        t = 2
        Button1.Enabled = False
        maq()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Text = "X"
        t = 2
        Button2.Enabled = False
        maq()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button3.Text = "X"
        t = 2
        Button3.Enabled = False
        maq()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Text = "X"
        t = 2
        Button4.Enabled = False
        maq()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Button5.Text = "X"
        t = 2
        Button5.Enabled = False
        maq()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Button6.Text = "X"
        t = 2
        Button6.Enabled = False
        maq()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Button7.Text = "X"
        t = 2
        Button7.Enabled = False
        maq()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Button8.Text = "X"
        t = 2
        Button8.Enabled = False
        maq()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Button9.Text = "X"
        t = 2
        Button9.Enabled = False
        maq()
    End Sub

    Public Sub vicu()
        If (Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X") Or
            (Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X") Or
            (Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X") Or
            (Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X") Or
            (Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X") Or
            (Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X") Or
            (Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X") Or
            (Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X") Then
            MsgBox("Ganaste")
            t = 1
            fin()
            rei.Visible = True
        End If
    End Sub

    Public Sub vicm()
        If (Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O") Or
                (Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O") Or
                (Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O") Or
                (Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O") Or
                (Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O") Or
                (Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O") Or
                (Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O") Or
                (Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O") Then
            MsgBox("Perdiste")
            t = 1
            fin()
            rei.Visible = True
        End If
    End Sub

    Public Sub fin()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rei.Click
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""
        rei.Visible = False
        If p = 1 Then
            p = 2
            t = 2
            maq()
        ElseIf p = 2 Then
            p = 1
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
