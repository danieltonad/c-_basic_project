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
        Me.components = New System.ComponentModel.Container()
        Me.eng = New System.Windows.Forms.CheckBox()
        Me.math = New System.Windows.Forms.CheckBox()
        Me.phy = New System.Windows.Forms.CheckBox()
        Me.bio = New System.Windows.Forms.CheckBox()
        Me.chem = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.generate = New System.Windows.Forms.Button()
        Me.head = New System.Windows.Forms.Panel()
        Me.mini = New System.Windows.Forms.Label()
        Me.close = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnPanel = New System.Windows.Forms.Panel()
        Me.subPanel = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.subject = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.geo = New System.Windows.Forms.CheckBox()
        Me.agric = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.info = New System.Windows.Forms.ToolTip(Me.components)
        Me.head.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.BtnPanel.SuspendLayout()
        Me.subPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'eng
        '
        Me.eng.AutoSize = True
        Me.eng.Checked = True
        Me.eng.CheckState = System.Windows.Forms.CheckState.Checked
        Me.eng.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eng.Location = New System.Drawing.Point(44, 51)
        Me.eng.Name = "eng"
        Me.eng.Size = New System.Drawing.Size(106, 26)
        Me.eng.TabIndex = 0
        Me.eng.Text = "ENGLISH"
        Me.eng.UseVisualStyleBackColor = True
        '
        'math
        '
        Me.math.AutoSize = True
        Me.math.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.math.Location = New System.Drawing.Point(377, 51)
        Me.math.Name = "math"
        Me.math.Size = New System.Drawing.Size(161, 26)
        Me.math.TabIndex = 1
        Me.math.Text = "MATHEMATICS"
        Me.math.UseVisualStyleBackColor = True
        '
        'phy
        '
        Me.phy.AutoSize = True
        Me.phy.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phy.Location = New System.Drawing.Point(44, 102)
        Me.phy.Name = "phy"
        Me.phy.Size = New System.Drawing.Size(102, 26)
        Me.phy.TabIndex = 2
        Me.phy.Text = "PHYSICS"
        Me.phy.UseVisualStyleBackColor = True
        '
        'bio
        '
        Me.bio.AutoSize = True
        Me.bio.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bio.Location = New System.Drawing.Point(377, 102)
        Me.bio.Name = "bio"
        Me.bio.Size = New System.Drawing.Size(116, 26)
        Me.bio.TabIndex = 3
        Me.bio.Text = "BIOLOGY"
        Me.bio.UseVisualStyleBackColor = True
        '
        'chem
        '
        Me.chem.AutoSize = True
        Me.chem.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chem.Location = New System.Drawing.Point(610, 51)
        Me.chem.Name = "chem"
        Me.chem.Size = New System.Drawing.Size(129, 26)
        Me.chem.TabIndex = 4
        Me.chem.Text = "CHEMISTRY"
        Me.chem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("HelvLight", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "JAMB SUBJECT COMBINATION" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'generate
        '
        Me.generate.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.generate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.generate.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.generate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generate.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generate.ForeColor = System.Drawing.Color.White
        Me.generate.Location = New System.Drawing.Point(649, 6)
        Me.generate.Name = "generate"
        Me.generate.Size = New System.Drawing.Size(239, 66)
        Me.generate.TabIndex = 7
        Me.generate.Text = "Generate"
        Me.info.SetToolTip(Me.generate, "Generate courses")
        Me.generate.UseVisualStyleBackColor = False
        '
        'head
        '
        Me.head.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.head.Controls.Add(Me.mini)
        Me.head.Controls.Add(Me.close)
        Me.head.Controls.Add(Me.Label1)
        Me.head.Dock = System.Windows.Forms.DockStyle.Top
        Me.head.Location = New System.Drawing.Point(0, 0)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(901, 41)
        Me.head.TabIndex = 45
        '
        'mini
        '
        Me.mini.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mini.Dock = System.Windows.Forms.DockStyle.Right
        Me.mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mini.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mini.ForeColor = System.Drawing.Color.White
        Me.mini.Location = New System.Drawing.Point(817, 0)
        Me.mini.Name = "mini"
        Me.mini.Size = New System.Drawing.Size(42, 41)
        Me.mini.TabIndex = 1
        Me.mini.Text = "_"
        Me.mini.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.info.SetToolTip(Me.mini, "minimize")
        '
        'close
        '
        Me.close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close.Dock = System.Windows.Forms.DockStyle.Right
        Me.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.close.ForeColor = System.Drawing.Color.White
        Me.close.Location = New System.Drawing.Point(859, 0)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(42, 41)
        Me.close.TabIndex = 0
        Me.close.Text = "X"
        Me.close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.info.SetToolTip(Me.close, "close")
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnPanel)
        Me.Panel1.Controls.Add(Me.subPanel)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 771)
        Me.Panel1.TabIndex = 46
        '
        'BtnPanel
        '
        Me.BtnPanel.Controls.Add(Me.generate)
        Me.BtnPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnPanel.Location = New System.Drawing.Point(0, 744)
        Me.BtnPanel.Name = "BtnPanel"
        Me.BtnPanel.Size = New System.Drawing.Size(899, 78)
        Me.BtnPanel.TabIndex = 9
        '
        'subPanel
        '
        Me.subPanel.Controls.Add(Me.Label2)
        Me.subPanel.Controls.Add(Me.subject)
        Me.subPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.subPanel.Location = New System.Drawing.Point(0, 248)
        Me.subPanel.Name = "subPanel"
        Me.subPanel.Size = New System.Drawing.Size(899, 496)
        Me.subPanel.TabIndex = 8
        Me.subPanel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("HelvLight", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(300, 23)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "SUGGESTED COURSES ARE :"
        '
        'subject
        '
        Me.subject.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject.Location = New System.Drawing.Point(72, 41)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(392, 380)
        Me.subject.TabIndex = 19
        Me.subject.Text = "Label2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.geo)
        Me.GroupBox1.Controls.Add(Me.agric)
        Me.GroupBox1.Controls.Add(Me.phy)
        Me.GroupBox1.Controls.Add(Me.eng)
        Me.GroupBox1.Controls.Add(Me.chem)
        Me.GroupBox1.Controls.Add(Me.math)
        Me.GroupBox1.Controls.Add(Me.bio)
        Me.GroupBox1.Font = New System.Drawing.Font("HelvLight", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(819, 155)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "   SELECT ANY FOUR SUBJECT   "
        '
        'geo
        '
        Me.geo.AutoSize = True
        Me.geo.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.geo.Location = New System.Drawing.Point(190, 51)
        Me.geo.Name = "geo"
        Me.geo.Size = New System.Drawing.Size(152, 26)
        Me.geo.TabIndex = 6
        Me.geo.Text = "GEOGRAPHY"
        Me.geo.UseVisualStyleBackColor = True
        '
        'agric
        '
        Me.agric.AutoSize = True
        Me.agric.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agric.Location = New System.Drawing.Point(190, 102)
        Me.agric.Name = "agric"
        Me.agric.Size = New System.Drawing.Size(93, 26)
        Me.agric.TabIndex = 5
        Me.agric.Text = "AGIRC"
        Me.agric.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(899, 248)
        Me.Panel2.TabIndex = 5
        '
        'info
        '
        Me.info.AutomaticDelay = 6000
        Me.info.AutoPopDelay = 60000
        Me.info.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.info.ForeColor = System.Drawing.Color.FromArgb(CType(CType(8, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.info.InitialDelay = 350
        Me.info.ReshowDelay = 220
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(901, 771)
        Me.Controls.Add(Me.head)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.head.ResumeLayout(False)
        Me.head.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.BtnPanel.ResumeLayout(False)
        Me.subPanel.ResumeLayout(False)
        Me.subPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents eng As CheckBox
    Friend WithEvents math As CheckBox
    Friend WithEvents phy As CheckBox
    Friend WithEvents bio As CheckBox
    Friend WithEvents chem As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents generate As Button
    Friend WithEvents head As Panel
    Friend WithEvents mini As Label
    Friend WithEvents close As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnPanel As Panel
    Friend WithEvents subPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents subject As Label
    Friend WithEvents info As ToolTip
    Friend WithEvents geo As CheckBox
    Friend WithEvents agric As CheckBox
    Friend WithEvents Label2 As Label
End Class
