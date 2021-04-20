<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnButton1 = New System.Windows.Forms.Button()
        Me.lblLabel1 = New System.Windows.Forms.Label()
        Me.lblLabel2 = New System.Windows.Forms.Label()
        Me.BtnButton2 = New System.Windows.Forms.Button()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.BtnButton3 = New System.Windows.Forms.Button()
        Me.lblLabel3 = New System.Windows.Forms.Label()
        Me.BtnButton4 = New System.Windows.Forms.Button()
        Me.lblLabel4 = New System.Windows.Forms.Label()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnButton1
        '
        Me.BtnButton1.Location = New System.Drawing.Point(229, 109)
        Me.BtnButton1.Name = "BtnButton1"
        Me.BtnButton1.Size = New System.Drawing.Size(75, 23)
        Me.BtnButton1.TabIndex = 0
        Me.BtnButton1.Text = "Button1"
        Me.BtnButton1.UseVisualStyleBackColor = True
        '
        'lblLabel1
        '
        Me.lblLabel1.AutoSize = True
        Me.lblLabel1.Location = New System.Drawing.Point(343, 114)
        Me.lblLabel1.Name = "lblLabel1"
        Me.lblLabel1.Size = New System.Drawing.Size(51, 17)
        Me.lblLabel1.TabIndex = 1
        Me.lblLabel1.Text = "Label1"
        '
        'lblLabel2
        '
        Me.lblLabel2.AutoSize = True
        Me.lblLabel2.Location = New System.Drawing.Point(346, 157)
        Me.lblLabel2.Name = "lblLabel2"
        Me.lblLabel2.Size = New System.Drawing.Size(51, 17)
        Me.lblLabel2.TabIndex = 2
        Me.lblLabel2.Text = "Label2"
        '
        'BtnButton2
        '
        Me.BtnButton2.Location = New System.Drawing.Point(229, 151)
        Me.BtnButton2.Name = "BtnButton2"
        Me.BtnButton2.Size = New System.Drawing.Size(75, 23)
        Me.BtnButton2.TabIndex = 3
        Me.BtnButton2.Text = "Button2"
        Me.BtnButton2.UseVisualStyleBackColor = True
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(102, 151)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(100, 22)
        Me.txtBox1.TabIndex = 4
        '
        'BtnButton3
        '
        Me.BtnButton3.Location = New System.Drawing.Point(229, 199)
        Me.BtnButton3.Name = "BtnButton3"
        Me.BtnButton3.Size = New System.Drawing.Size(75, 23)
        Me.BtnButton3.TabIndex = 5
        Me.BtnButton3.Text = "Button3"
        Me.BtnButton3.UseVisualStyleBackColor = True
        '
        'lblLabel3
        '
        Me.lblLabel3.AutoSize = True
        Me.lblLabel3.Location = New System.Drawing.Point(346, 204)
        Me.lblLabel3.Name = "lblLabel3"
        Me.lblLabel3.Size = New System.Drawing.Size(51, 17)
        Me.lblLabel3.TabIndex = 6
        Me.lblLabel3.Text = "Label3"
        '
        'BtnButton4
        '
        Me.BtnButton4.Location = New System.Drawing.Point(229, 248)
        Me.BtnButton4.Name = "BtnButton4"
        Me.BtnButton4.Size = New System.Drawing.Size(75, 23)
        Me.BtnButton4.TabIndex = 7
        Me.BtnButton4.Text = "Button4"
        Me.BtnButton4.UseVisualStyleBackColor = True
        '
        'lblLabel4
        '
        Me.lblLabel4.AutoSize = True
        Me.lblLabel4.Location = New System.Drawing.Point(346, 253)
        Me.lblLabel4.Name = "lblLabel4"
        Me.lblLabel4.Size = New System.Drawing.Size(51, 17)
        Me.lblLabel4.TabIndex = 8
        Me.lblLabel4.Text = "Label4"
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(102, 248)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(100, 22)
        Me.txtBox2.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.lblLabel4)
        Me.Controls.Add(Me.BtnButton4)
        Me.Controls.Add(Me.lblLabel3)
        Me.Controls.Add(Me.BtnButton3)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.BtnButton2)
        Me.Controls.Add(Me.lblLabel2)
        Me.Controls.Add(Me.lblLabel1)
        Me.Controls.Add(Me.BtnButton1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnButton1 As Button
    Friend WithEvents lblLabel1 As Label
    Friend WithEvents lblLabel2 As Label
    Friend WithEvents BtnButton2 As Button
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents BtnButton3 As Button
    Friend WithEvents lblLabel3 As Label
    Friend WithEvents BtnButton4 As Button
    Friend WithEvents lblLabel4 As Label
    Friend WithEvents txtBox2 As TextBox
End Class
