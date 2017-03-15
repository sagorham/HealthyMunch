<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblControls = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(249, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Healthy Munch"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblInstructions.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblInstructions.Location = New System.Drawing.Point(19, 188)
        Me.lblInstructions.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(696, 152)
        Me.lblInstructions.TabIndex = 1
        Me.lblInstructions.Text = resources.GetString("lblInstructions.Text")
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblName.Location = New System.Drawing.Point(605, 437)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(90, 19)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Enter Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(541, 493)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(272, 26)
        Me.txtName.TabIndex = 3
        '
        'btnStart
        '
        Me.btnStart.ForeColor = System.Drawing.Color.CadetBlue
        Me.btnStart.Location = New System.Drawing.Point(541, 546)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(134, 46)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnClear.Location = New System.Drawing.Point(681, 546)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(134, 46)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblControls
        '
        Me.lblControls.AutoSize = True
        Me.lblControls.ForeColor = System.Drawing.Color.Teal
        Me.lblControls.Location = New System.Drawing.Point(19, 437)
        Me.lblControls.Name = "lblControls"
        Me.lblControls.Size = New System.Drawing.Size(204, 95)
        Me.lblControls.TabIndex = 6
        Me.lblControls.Text = "Controls: Use the arrow keys" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•" & Global.Microsoft.VisualBasic.ChrW(9) & "Left Arrow: move left" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•" & Global.Microsoft.VisualBasic.ChrW(9) & "Right Arrow: move right" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•" & Global.Microsoft.VisualBasic.ChrW(9) & "Down Arrow: move down" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "•" & Global.Microsoft.VisualBasic.ChrW(9) & "Up Arrow: move up"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(335, 493)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 132)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1356, 664)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblControls)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.LimeGreen
        Me.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblControls As Label
    Friend WithEvents Button1 As Button
End Class
