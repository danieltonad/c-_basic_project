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
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.panel4 = New System.Windows.Forms.Panel()
        Me.button2 = New System.Windows.Forms.Button()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Members1 = New Wages_Vb.members()
        Me.About2 = New Wages_Vb.about()
        Me.Wages2 = New Wages_Vb.wages()
        Me.about = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.slide = New System.Windows.Forms.Panel()
        Me.grp = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.num = New System.Windows.Forms.Label()
        Me.panel1.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.num)
        Me.panel1.Controls.Add(Me.Label1)
        Me.panel1.Controls.Add(Me.panel3)
        Me.panel1.Controls.Add(Me.panel2)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(780, 27)
        Me.panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Kristen ITC", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(5, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Wages Calculator"
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.panel4)
        Me.panel3.Controls.Add(Me.button2)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel3.Location = New System.Drawing.Point(720, 0)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(30, 27)
        Me.panel3.TabIndex = 1
        '
        'panel4
        '
        Me.panel4.BackColor = System.Drawing.Color.White
        Me.panel4.ForeColor = System.Drawing.Color.White
        Me.panel4.Location = New System.Drawing.Point(4, 14)
        Me.panel4.Name = "panel4"
        Me.panel4.Size = New System.Drawing.Size(18, 5)
        Me.panel4.TabIndex = 1
        '
        'button2
        '
        Me.button2.BackColor = System.Drawing.Color.Transparent
        Me.button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button2.FlatAppearance.BorderSize = 0
        Me.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold
        Me.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.White
        Me.button2.Location = New System.Drawing.Point(0, 0)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(30, 29)
        Me.button2.TabIndex = 2
        Me.button2.UseVisualStyleBackColor = False
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.button1)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.panel2.Location = New System.Drawing.Point(750, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(30, 27)
        Me.panel2.TabIndex = 0
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.Red
        Me.button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1.FlatAppearance.BorderSize = 0
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(0, 0)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(30, 29)
        Me.button1.TabIndex = 1
        Me.button1.Text = "X"
        Me.button1.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Members1)
        Me.Panel5.Controls.Add(Me.About2)
        Me.Panel5.Controls.Add(Me.Wages2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 27)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(780, 591)
        Me.Panel5.TabIndex = 2
        '
        'Members1
        '
        Me.Members1.BackColor = System.Drawing.Color.Goldenrod
        Me.Members1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Members1.Location = New System.Drawing.Point(0, 0)
        Me.Members1.Name = "Members1"
        Me.Members1.Size = New System.Drawing.Size(780, 591)
        Me.Members1.TabIndex = 2
        '
        'About2
        '
        Me.About2.BackColor = System.Drawing.Color.FloralWhite
        Me.About2.Location = New System.Drawing.Point(0, 1)
        Me.About2.Name = "About2"
        Me.About2.Size = New System.Drawing.Size(780, 598)
        Me.About2.TabIndex = 1
        '
        'Wages2
        '
        Me.Wages2.BackColor = System.Drawing.Color.Gold
        Me.Wages2.Location = New System.Drawing.Point(0, 1)
        Me.Wages2.Name = "Wages2"
        Me.Wages2.Size = New System.Drawing.Size(780, 591)
        Me.Wages2.TabIndex = 0
        '
        'about
        '
        Me.about.BackColor = System.Drawing.Color.Gold
        Me.about.Cursor = System.Windows.Forms.Cursors.Hand
        Me.about.FlatAppearance.BorderSize = 0
        Me.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.about.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.about.ForeColor = System.Drawing.Color.Magenta
        Me.about.Location = New System.Drawing.Point(0, 3)
        Me.about.Name = "about"
        Me.about.Size = New System.Drawing.Size(260, 44)
        Me.about.TabIndex = 3
        Me.about.Text = "About App"
        Me.about.UseVisualStyleBackColor = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.slide)
        Me.Panel6.Controls.Add(Me.grp)
        Me.Panel6.Controls.Add(Me.back)
        Me.Panel6.Controls.Add(Me.about)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 617)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(780, 54)
        Me.Panel6.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(780, 2)
        Me.Panel7.TabIndex = 1
        '
        'slide
        '
        Me.slide.BackColor = System.Drawing.Color.Lime
        Me.slide.Location = New System.Drawing.Point(0, 47)
        Me.slide.Name = "slide"
        Me.slide.Size = New System.Drawing.Size(260, 7)
        Me.slide.TabIndex = 0
        Me.slide.Visible = False
        '
        'grp
        '
        Me.grp.BackColor = System.Drawing.Color.Gold
        Me.grp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.grp.FlatAppearance.BorderSize = 0
        Me.grp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grp.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp.ForeColor = System.Drawing.Color.Magenta
        Me.grp.Location = New System.Drawing.Point(260, 3)
        Me.grp.Name = "grp"
        Me.grp.Size = New System.Drawing.Size(260, 44)
        Me.grp.TabIndex = 5
        Me.grp.Text = "App Info"
        Me.grp.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Gold
        Me.back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back.FlatAppearance.BorderSize = 0
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.Magenta
        Me.back.Location = New System.Drawing.Point(520, 3)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(260, 44)
        Me.back.TabIndex = 4
        Me.back.Text = "Back To Calculator"
        Me.back.UseVisualStyleBackColor = False
        Me.back.Visible = False
        '
        'num
        '
        Me.num.AutoSize = True
        Me.num.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num.Location = New System.Drawing.Point(176, 6)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(16, 17)
        Me.num.TabIndex = 3
        Me.num.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.ClientSize = New System.Drawing.Size(780, 671)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel3.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panel1 As Panel
    Private WithEvents panel3 As Panel
    Private WithEvents panel4 As Panel
    Private WithEvents button2 As Button
    Private WithEvents panel2 As Panel
    Private WithEvents button1 As Button
    Friend WithEvents Panel5 As Panel
    Private WithEvents about As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents slide As Panel
    Private WithEvents grp As Button
    Private WithEvents back As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents About2 As about
    Friend WithEvents Wages2 As wages
    Friend WithEvents Members1 As members
    Friend WithEvents num As Label
End Class
