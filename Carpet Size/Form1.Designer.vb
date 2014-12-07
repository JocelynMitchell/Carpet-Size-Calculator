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
        Me.btnCalcCarpetArea = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCarpetArea = New System.Windows.Forms.Label()
        Me.txtCarpetWidth = New System.Windows.Forms.TextBox()
        Me.txtCarpetLength = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCalcCarpetArea
        '
        Me.btnCalcCarpetArea.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCalcCarpetArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcCarpetArea.Location = New System.Drawing.Point(12, 184)
        Me.btnCalcCarpetArea.Name = "btnCalcCarpetArea"
        Me.btnCalcCarpetArea.Size = New System.Drawing.Size(75, 41)
        Me.btnCalcCarpetArea.TabIndex = 0
        Me.btnCalcCarpetArea.Text = "Calculate Area"
        Me.btnCalcCarpetArea.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Black
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(204, 184)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 41)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Carpet Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Carpet Length"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Carpet Area"
        '
        'lblCarpetArea
        '
        Me.lblCarpetArea.AutoSize = True
        Me.lblCarpetArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarpetArea.Location = New System.Drawing.Point(189, 139)
        Me.lblCarpetArea.Name = "lblCarpetArea"
        Me.lblCarpetArea.Size = New System.Drawing.Size(0, 20)
        Me.lblCarpetArea.TabIndex = 5
        '
        'txtCarpetWidth
        '
        Me.txtCarpetWidth.Location = New System.Drawing.Point(174, 41)
        Me.txtCarpetWidth.Name = "txtCarpetWidth"
        Me.txtCarpetWidth.Size = New System.Drawing.Size(100, 20)
        Me.txtCarpetWidth.TabIndex = 6
        '
        'txtCarpetLength
        '
        Me.txtCarpetLength.Location = New System.Drawing.Point(174, 90)
        Me.txtCarpetLength.Name = "txtCarpetLength"
        Me.txtCarpetLength.Size = New System.Drawing.Size(100, 20)
        Me.txtCarpetLength.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(104, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(291, 236)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCarpetLength)
        Me.Controls.Add(Me.txtCarpetWidth)
        Me.Controls.Add(Me.lblCarpetArea)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalcCarpetArea)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.Name = "Form1"
        Me.Text = "Carpet Size"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcCarpetArea As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCarpetArea As System.Windows.Forms.Label
    Friend WithEvents txtCarpetWidth As System.Windows.Forms.TextBox
    Friend WithEvents txtCarpetLength As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
