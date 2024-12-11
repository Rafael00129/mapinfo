<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(390, 392)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(209, 30)
        Me.txtemail.TabIndex = 0
        '
        'txtpwd
        '
        Me.txtpwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.Location = New System.Drawing.Point(390, 443)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(209, 30)
        Me.txtpwd.TabIndex = 3
        Me.txtpwd.Tag = ""
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(366, 497)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(108, 39)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "LOG IN"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(515, 497)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 39)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "SIGN IN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(828, 584)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 39)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "BACK"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.mapinfo.My.Resources.Resources._462644700_944192797627900_330797476859318558_n
        Me.ClientSize = New System.Drawing.Size(948, 635)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.txtemail)
        Me.Name = "admin"
        Me.Text = "admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtpwd As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
