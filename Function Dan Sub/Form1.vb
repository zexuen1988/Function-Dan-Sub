Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub sub1()
        lblLabel1.Text = "Hi"
    End Sub

    Private Sub sub2(strText1 As String)
        strText1 = txtBox1.Text
        lblLabel2.Text = strText1
    End Sub

    Private Function fun1()
        lblLabel3.Text = "Helo"
        Return lblLabel3
    End Function

    Private Function fun2(strText2 As String)
        strText2 = txtBox2.Text
        lblLabel4.Text = strText2
        Return lblLabel4
    End Function


End Class
