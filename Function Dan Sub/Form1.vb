Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub sub1()
        lblLabel1.Text = "Hi"
    End Sub

    Private Sub sub2()
        Dim strText1 As String
        strText1 = txtBox1.Text
        lblLabel2.Text = strText1
    End Sub

    Private Function fun1()
        lblLabel3.Text = "Helo"
        Return lblLabel3
    End Function

    Private Function fun2()
        Dim strText2 As String
        strText2 = txtBox2.Text
        lblLabel4.Text = strText2
        Return lblLabel4
    End Function

    Private Sub BtnButton1_Click(sender As Object, e As EventArgs) Handles BtnButton1.Click
        sub1()
    End Sub

    Private Sub BtnButton2_Click(sender As Object, e As EventArgs) Handles BtnButton2.Click
        sub2()
    End Sub

    Private Sub BtnButton3_Click(sender As Object, e As EventArgs) Handles BtnButton3.Click
        fun1()
    End Sub

    Private Sub BtnButton4_Click(sender As Object, e As EventArgs) Handles BtnButton4.Click
        fun2()
    End Sub
End Class
