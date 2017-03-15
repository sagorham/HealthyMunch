<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.lblAddInfo = New System.Windows.Forms.Label()
        Me.lblStartInfo = New System.Windows.Forms.Label()
        Me.lblGrains = New System.Windows.Forms.Label()
        Me.lblVeggies = New System.Windows.Forms.Label()
        Me.lblFruits = New System.Windows.Forms.Label()
        Me.lblDairy = New System.Windows.Forms.Label()
        Me.lblMeats = New System.Windows.Forms.Label()
        Me.lblFats = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblFatPoints = New System.Windows.Forms.Label()
        Me.lblMeatPoints = New System.Windows.Forms.Label()
        Me.lblDairyPoints = New System.Windows.Forms.Label()
        Me.lblVegetablePoints = New System.Windows.Forms.Label()
        Me.lblFruitPoints = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAddInfo
        '
        Me.lblAddInfo.AutoSize = True
        Me.lblAddInfo.Font = New System.Drawing.Font("Comic Sans MS", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddInfo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAddInfo.Location = New System.Drawing.Point(351, 6)
        Me.lblAddInfo.Name = "lblAddInfo"
        Me.lblAddInfo.Size = New System.Drawing.Size(499, 60)
        Me.lblAddInfo.TabIndex = 0
        Me.lblAddInfo.Text = "Additional Information"
        '
        'lblStartInfo
        '
        Me.lblStartInfo.AutoSize = True
        Me.lblStartInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblStartInfo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblStartInfo.Location = New System.Drawing.Point(1, 82)
        Me.lblStartInfo.Name = "lblStartInfo"
        Me.lblStartInfo.Size = New System.Drawing.Size(360, 45)
        Me.lblStartInfo.TabIndex = 1
        Me.lblStartInfo.Text = resources.GetString("lblStartInfo.Text")
        '
        'lblGrains
        '
        Me.lblGrains.AutoSize = True
        Me.lblGrains.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrains.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblGrains.Location = New System.Drawing.Point(1, 474)
        Me.lblGrains.Name = "lblGrains"
        Me.lblGrains.Size = New System.Drawing.Size(267, 45)
        Me.lblGrains.TabIndex = 2
        Me.lblGrains.Text = "Grains: Grains provide carbohydrates (sugars), " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " which are an important source o" &
    "f energy." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Serving Sizes: 6-11 servings" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblVeggies
        '
        Me.lblVeggies.AutoSize = True
        Me.lblVeggies.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeggies.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblVeggies.Location = New System.Drawing.Point(1, 359)
        Me.lblVeggies.Name = "lblVeggies"
        Me.lblVeggies.Size = New System.Drawing.Size(321, 45)
        Me.lblVeggies.TabIndex = 3
        Me.lblVeggies.Text = "Vegetables: Vegetables provide vitamins and minerals that" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " our bodies cannot pro" &
    "duce on their own." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Serving Sizes: 3-4 servings"
        '
        'lblFruits
        '
        Me.lblFruits.AutoSize = True
        Me.lblFruits.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFruits.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblFruits.Location = New System.Drawing.Point(1, 424)
        Me.lblFruits.Name = "lblFruits"
        Me.lblFruits.Size = New System.Drawing.Size(319, 30)
        Me.lblFruits.TabIndex = 4
        Me.lblFruits.Text = "Fruits: Fruits provide natural sugars, fiber, and vitamins. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Serving Sizes: 2-4" &
    " servings"
        '
        'lblDairy
        '
        Me.lblDairy.AutoSize = True
        Me.lblDairy.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDairy.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDairy.Location = New System.Drawing.Point(1, 218)
        Me.lblDairy.Name = "lblDairy"
        Me.lblDairy.Size = New System.Drawing.Size(346, 45)
        Me.lblDairy.TabIndex = 5
        Me.lblDairy.Text = "Milk/Dairy: Dairy provides our body with calcium, protein, and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Vitamins A and D" &
    ", which help our bodies grow big and strong." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Serving Sizes: 2-3 servings"
        '
        'lblMeats
        '
        Me.lblMeats.AutoSize = True
        Me.lblMeats.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeats.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblMeats.Location = New System.Drawing.Point(1, 278)
        Me.lblMeats.Name = "lblMeats"
        Me.lblMeats.Size = New System.Drawing.Size(318, 60)
        Me.lblMeats.TabIndex = 6
        Me.lblMeats.Text = "Meat and Beans/Nuts: Meat and beans/nuts gives the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " body protein, complex carbs," &
    " iron, zinc, and Vitamin B12," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " which help build and protect our muscles." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Serv" &
    "ing Sizes: 2-3 servings"
        '
        'lblFats
        '
        Me.lblFats.AutoSize = True
        Me.lblFats.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFats.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblFats.Location = New System.Drawing.Point(1, 144)
        Me.lblFats.Name = "lblFats"
        Me.lblFats.Size = New System.Drawing.Size(313, 60)
        Me.lblFats.TabIndex = 7
        Me.lblFats.Text = "Fats/Oils and Sweets: Fats are in the smallest category" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " of the food pyramid bec" &
    "ause they provide calorie and are " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " not very nutritious." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Serving Sizes: consu" &
    "me responsibly"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPoints.Location = New System.Drawing.Point(573, 474)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(229, 45)
        Me.lblPoints.TabIndex = 8
        Me.lblPoints.Text = "The different serving sizes of each food" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " groups will represent the points that " &
    "can" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " be earned when obtained in the game."
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(170, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 32)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(387, 82)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(822, 545)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'lblFatPoints
        '
        Me.lblFatPoints.AutoSize = True
        Me.lblFatPoints.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFatPoints.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblFatPoints.Location = New System.Drawing.Point(407, 129)
        Me.lblFatPoints.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFatPoints.Name = "lblFatPoints"
        Me.lblFatPoints.Size = New System.Drawing.Size(100, 17)
        Me.lblFatPoints.TabIndex = 17
        Me.lblFatPoints.Text = "Fats = +1 point"
        Me.lblFatPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMeatPoints
        '
        Me.lblMeatPoints.AutoSize = True
        Me.lblMeatPoints.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeatPoints.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblMeatPoints.Location = New System.Drawing.Point(406, 182)
        Me.lblMeatPoints.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMeatPoints.Name = "lblMeatPoints"
        Me.lblMeatPoints.Size = New System.Drawing.Size(111, 17)
        Me.lblMeatPoints.TabIndex = 18
        Me.lblMeatPoints.Text = "Meat = +2 points"
        Me.lblMeatPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDairyPoints
        '
        Me.lblDairyPoints.AutoSize = True
        Me.lblDairyPoints.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDairyPoints.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDairyPoints.Location = New System.Drawing.Point(406, 156)
        Me.lblDairyPoints.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDairyPoints.Name = "lblDairyPoints"
        Me.lblDairyPoints.Size = New System.Drawing.Size(114, 17)
        Me.lblDairyPoints.TabIndex = 19
        Me.lblDairyPoints.Text = "Dairy = +2 points"
        Me.lblDairyPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblVegetablePoints
        '
        Me.lblVegetablePoints.AutoSize = True
        Me.lblVegetablePoints.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVegetablePoints.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblVegetablePoints.Location = New System.Drawing.Point(406, 237)
        Me.lblVegetablePoints.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVegetablePoints.Name = "lblVegetablePoints"
        Me.lblVegetablePoints.Size = New System.Drawing.Size(146, 17)
        Me.lblVegetablePoints.TabIndex = 20
        Me.lblVegetablePoints.Text = "Vegetables = +4 points"
        Me.lblVegetablePoints.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblFruitPoints
        '
        Me.lblFruitPoints.AutoSize = True
        Me.lblFruitPoints.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFruitPoints.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblFruitPoints.Location = New System.Drawing.Point(407, 209)
        Me.lblFruitPoints.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFruitPoints.Name = "lblFruitPoints"
        Me.lblFruitPoints.Size = New System.Drawing.Size(117, 17)
        Me.lblFruitPoints.TabIndex = 21
        Me.lblFruitPoints.Text = "Fruits = +3 points"
        Me.lblFruitPoints.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(406, 265)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Grains = +5 points"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(735, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 31)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Food Pyramid!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(161, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(908, 482)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFruitPoints)
        Me.Controls.Add(Me.lblVegetablePoints)
        Me.Controls.Add(Me.lblDairyPoints)
        Me.Controls.Add(Me.lblMeatPoints)
        Me.Controls.Add(Me.lblFatPoints)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblFats)
        Me.Controls.Add(Me.lblMeats)
        Me.Controls.Add(Me.lblDairy)
        Me.Controls.Add(Me.lblFruits)
        Me.Controls.Add(Me.lblVeggies)
        Me.Controls.Add(Me.lblGrains)
        Me.Controls.Add(Me.lblStartInfo)
        Me.Controls.Add(Me.lblAddInfo)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAddInfo As Label
    Friend WithEvents lblStartInfo As Label
    Friend WithEvents lblGrains As Label
    Friend WithEvents lblVeggies As Label
    Friend WithEvents lblFruits As Label
    Friend WithEvents lblDairy As Label
    Friend WithEvents lblMeats As Label
    Friend WithEvents lblFats As Label
    Friend WithEvents lblPoints As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblFatPoints As Label
    Friend WithEvents lblMeatPoints As Label
    Friend WithEvents lblDairyPoints As Label
    Friend WithEvents lblVegetablePoints As Label
    Friend WithEvents lblFruitPoints As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
