<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wages
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.earn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.period = New System.Windows.Forms.ComboBox()
        Me.week_hours = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.solution = New System.Windows.Forms.Panel()
        Me.hour = New System.Windows.Forms.Label()
        Me.day = New System.Windows.Forms.Label()
        Me.month = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.solution.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Earnings"
        '
        'earn
        '
        Me.earn.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.earn.Location = New System.Drawing.Point(261, 110)
        Me.earn.Name = "earn"
        Me.earn.Size = New System.Drawing.Size(215, 33)
        Me.earn.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(482, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 44)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "per"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 18.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(306, 44)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Weekly Working Hours"
        '
        'period
        '
        Me.period.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.period.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.period.FormattingEnabled = True
        Me.period.Items.AddRange(New Object() {"Month", "Year"})
        Me.period.Location = New System.Drawing.Point(539, 113)
        Me.period.Name = "period"
        Me.period.Size = New System.Drawing.Size(125, 32)
        Me.period.TabIndex = 4
        '
        'week_hours
        '
        Me.week_hours.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.week_hours.Location = New System.Drawing.Point(456, 188)
        Me.week_hours.Name = "week_hours"
        Me.week_hours.Size = New System.Drawing.Size(208, 33)
        Me.week_hours.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe Script", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(304, 488)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 52)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'solution
        '
        Me.solution.Controls.Add(Me.hour)
        Me.solution.Controls.Add(Me.day)
        Me.solution.Controls.Add(Me.month)
        Me.solution.Controls.Add(Me.year)
        Me.solution.Controls.Add(Me.Label7)
        Me.solution.Controls.Add(Me.Label6)
        Me.solution.Controls.Add(Me.Label5)
        Me.solution.Controls.Add(Me.Label4)
        Me.solution.Location = New System.Drawing.Point(139, 266)
        Me.solution.Name = "solution"
        Me.solution.Size = New System.Drawing.Size(525, 176)
        Me.solution.TabIndex = 7
        Me.solution.Visible = False
        '
        'hour
        '
        Me.hour.AutoSize = True
        Me.hour.BackColor = System.Drawing.Color.Gold
        Me.hour.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hour.ForeColor = System.Drawing.Color.Blue
        Me.hour.Location = New System.Drawing.Point(186, 134)
        Me.hour.Name = "hour"
        Me.hour.Size = New System.Drawing.Size(142, 28)
        Me.hour.TabIndex = 8
        Me.hour.Text = "0123456789"
        '
        'day
        '
        Me.day.AutoSize = True
        Me.day.BackColor = System.Drawing.Color.Gold
        Me.day.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.day.ForeColor = System.Drawing.Color.Blue
        Me.day.Location = New System.Drawing.Point(170, 95)
        Me.day.Name = "day"
        Me.day.Size = New System.Drawing.Size(142, 28)
        Me.day.TabIndex = 7
        Me.day.Text = "0123456789"
        '
        'month
        '
        Me.month.AutoSize = True
        Me.month.BackColor = System.Drawing.Color.Gold
        Me.month.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.month.ForeColor = System.Drawing.Color.Blue
        Me.month.Location = New System.Drawing.Point(201, 55)
        Me.month.Name = "month"
        Me.month.Size = New System.Drawing.Size(142, 28)
        Me.month.TabIndex = 6
        Me.month.Text = "0123456789"
        '
        'year
        '
        Me.year.AutoSize = True
        Me.year.BackColor = System.Drawing.Color.Gold
        Me.year.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.ForeColor = System.Drawing.Color.Blue
        Me.year.Location = New System.Drawing.Point(184, 15)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(142, 28)
        Me.year.TabIndex = 5
        Me.year.Text = "0123456789"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(183, 37)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Hourly Salary ="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 37)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Daily Salary ="
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 37)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Monthly Salary ="
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 37)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Yearly Salary ="
        '
        'wages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.Controls.Add(Me.solution)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.week_hours)
        Me.Controls.Add(Me.period)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.earn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "wages"
        Me.Size = New System.Drawing.Size(780, 591)
        Me.solution.ResumeLayout(False)
        Me.solution.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents earn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents period As ComboBox
    Friend WithEvents week_hours As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents solution As Panel
    Friend WithEvents hour As Label
    Friend WithEvents day As Label
    Friend WithEvents month As Label
    Friend WithEvents year As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
