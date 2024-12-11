<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit
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
        Me.balik = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNAME = New System.Windows.Forms.TextBox()
        Me.txtINFO = New System.Windows.Forms.TextBox()
        Me.DATAGRIDVIEW = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        CType(Me.DATAGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'balik
        '
        Me.balik.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balik.Location = New System.Drawing.Point(868, 531)
        Me.balik.Name = "balik"
        Me.balik.Size = New System.Drawing.Size(118, 57)
        Me.balik.TabIndex = 0
        Me.balik.Text = "BACK"
        Me.balik.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(347, 124)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(164, 26)
        Me.txtID.TabIndex = 1
        '
        'txtNAME
        '
        Me.txtNAME.Location = New System.Drawing.Point(347, 215)
        Me.txtNAME.Name = "txtNAME"
        Me.txtNAME.Size = New System.Drawing.Size(164, 26)
        Me.txtNAME.TabIndex = 2
        '
        'txtINFO
        '
        Me.txtINFO.Location = New System.Drawing.Point(347, 307)
        Me.txtINFO.Name = "txtINFO"
        Me.txtINFO.Size = New System.Drawing.Size(164, 26)
        Me.txtINFO.TabIndex = 3
        '
        'DATAGRIDVIEW
        '
        Me.DATAGRIDVIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAGRIDVIEW.Location = New System.Drawing.Point(619, 124)
        Me.DATAGRIDVIEW.Name = "DATAGRIDVIEW"
        Me.DATAGRIDVIEW.RowHeadersWidth = 62
        Me.DATAGRIDVIEW.RowTemplate.Height = 28
        Me.DATAGRIDVIEW.Size = New System.Drawing.Size(367, 320)
        Me.DATAGRIDVIEW.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(166, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Room ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(166, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Room Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Room Info:"
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.Location = New System.Drawing.Point(170, 443)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(127, 56)
        Me.btnsearch.TabIndex = 8
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(384, 443)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(127, 56)
        Me.btnupdate.TabIndex = 9
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 625)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DATAGRIDVIEW)
        Me.Controls.Add(Me.txtINFO)
        Me.Controls.Add(Me.txtNAME)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.balik)
        Me.Name = "edit"
        Me.Text = "edit"
        CType(Me.DATAGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents balik As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNAME As TextBox
    Friend WithEvents txtINFO As TextBox
    Friend WithEvents DATAGRIDVIEW As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnupdate As Button
End Class
