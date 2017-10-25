<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StageReading
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StageReading))
        Me.back = New System.Windows.Forms.Button()
        Me.exitsr = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.yearsr = New System.Windows.Forms.ComboBox()
        Me.deptsr = New System.Windows.Forms.ComboBox()
        Me.secsr = New System.Windows.Forms.ComboBox()
        Me.gensr = New System.Windows.Forms.ComboBox()
        Me.busr = New System.Windows.Forms.ComboBox()
        Me.stopsr = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.deptsrf = New System.Windows.Forms.ComboBox()
        Me.gensrf = New System.Windows.Forms.ComboBox()
        Me.bussrf = New System.Windows.Forms.ComboBox()
        Me.stopsrf = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.countsr = New System.Windows.Forms.Button()
        Me.countsrf = New System.Windows.Forms.Button()
        Me.txtsr = New System.Windows.Forms.TextBox()
        Me.txtsrf = New System.Windows.Forms.TextBox()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.totals = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.Silver
        Me.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back.Location = New System.Drawing.Point(0, 456)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(143, 55)
        Me.back.TabIndex = 1
        Me.back.Text = "BACK"
        Me.back.UseVisualStyleBackColor = False
        '
        'exitsr
        '
        Me.exitsr.BackColor = System.Drawing.Color.Red
        Me.exitsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitsr.Location = New System.Drawing.Point(691, 456)
        Me.exitsr.Name = "exitsr"
        Me.exitsr.Size = New System.Drawing.Size(143, 55)
        Me.exitsr.TabIndex = 2
        Me.exitsr.Text = "EXIT"
        Me.exitsr.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 100)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(214, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "STAGE READINGS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "YEAR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DEPARTMENT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SECTION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(40, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "GENDER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(38, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "BUSNO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(38, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "STOP NAME"
        '
        'yearsr
        '
        Me.yearsr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearsr.FormattingEnabled = True
        Me.yearsr.Items.AddRange(New Object() {"", "1", "2", "3", "4"})
        Me.yearsr.Location = New System.Drawing.Point(162, 166)
        Me.yearsr.Name = "yearsr"
        Me.yearsr.Size = New System.Drawing.Size(182, 21)
        Me.yearsr.TabIndex = 10
        '
        'deptsr
        '
        Me.deptsr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deptsr.FormattingEnabled = True
        Me.deptsr.Items.AddRange(New Object() {"", "IT", "EEE", "ECE", "MECH", "BME", "CSE", "EIE", "MBA", "ME", "MATHS", "PHYSICS", "CHEMISTRY"})
        Me.deptsr.Location = New System.Drawing.Point(162, 197)
        Me.deptsr.Name = "deptsr"
        Me.deptsr.Size = New System.Drawing.Size(182, 21)
        Me.deptsr.TabIndex = 11
        '
        'secsr
        '
        Me.secsr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.secsr.FormattingEnabled = True
        Me.secsr.Items.AddRange(New Object() {"", "A", "B", "C", "D"})
        Me.secsr.Location = New System.Drawing.Point(162, 230)
        Me.secsr.Name = "secsr"
        Me.secsr.Size = New System.Drawing.Size(182, 21)
        Me.secsr.TabIndex = 12
        '
        'gensr
        '
        Me.gensr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gensr.FormattingEnabled = True
        Me.gensr.Items.AddRange(New Object() {"", "MALE", "FEMALE"})
        Me.gensr.Location = New System.Drawing.Point(162, 262)
        Me.gensr.Name = "gensr"
        Me.gensr.Size = New System.Drawing.Size(182, 21)
        Me.gensr.TabIndex = 13
        '
        'busr
        '
        Me.busr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.busr.FormattingEnabled = True
        Me.busr.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.busr.Location = New System.Drawing.Point(162, 295)
        Me.busr.Name = "busr"
        Me.busr.Size = New System.Drawing.Size(182, 21)
        Me.busr.TabIndex = 14
        '
        'stopsr
        '
        Me.stopsr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stopsr.FormattingEnabled = True
        Me.stopsr.Items.AddRange(New Object() {"NONE"})
        Me.stopsr.Location = New System.Drawing.Point(162, 330)
        Me.stopsr.Name = "stopsr"
        Me.stopsr.Size = New System.Drawing.Size(182, 21)
        Me.stopsr.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label8.Location = New System.Drawing.Point(108, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "STUDENTS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label9.Location = New System.Drawing.Point(631, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "FACULTY"
        '
        'deptsrf
        '
        Me.deptsrf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deptsrf.FormattingEnabled = True
        Me.deptsrf.Items.AddRange(New Object() {"", "IT", "EEE", "ECE", "MECH", "BME", "CSE", "EIE", "MBA", "ME", "MATHS", "PHYSICS", "CHEMISTRY"})
        Me.deptsrf.Location = New System.Drawing.Point(621, 166)
        Me.deptsrf.Name = "deptsrf"
        Me.deptsrf.Size = New System.Drawing.Size(182, 21)
        Me.deptsrf.TabIndex = 18
        '
        'gensrf
        '
        Me.gensrf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.gensrf.FormattingEnabled = True
        Me.gensrf.Items.AddRange(New Object() {"", "MALE", "FEMALE"})
        Me.gensrf.Location = New System.Drawing.Point(621, 213)
        Me.gensrf.Name = "gensrf"
        Me.gensrf.Size = New System.Drawing.Size(182, 21)
        Me.gensrf.TabIndex = 19
        '
        'bussrf
        '
        Me.bussrf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bussrf.FormattingEnabled = True
        Me.bussrf.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.bussrf.Location = New System.Drawing.Point(621, 256)
        Me.bussrf.Name = "bussrf"
        Me.bussrf.Size = New System.Drawing.Size(182, 21)
        Me.bussrf.TabIndex = 20
        '
        'stopsrf
        '
        Me.stopsrf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stopsrf.FormattingEnabled = True
        Me.stopsrf.Location = New System.Drawing.Point(621, 303)
        Me.stopsrf.Name = "stopsrf"
        Me.stopsrf.Size = New System.Drawing.Size(182, 21)
        Me.stopsrf.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(511, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "BUSNO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(511, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "STOP NAME"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(510, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "DEPARTMENT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(510, 216)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "GENDER"
        '
        'countsr
        '
        Me.countsr.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.countsr.FlatAppearance.BorderSize = 0
        Me.countsr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.countsr.ForeColor = System.Drawing.Color.Black
        Me.countsr.Location = New System.Drawing.Point(71, 384)
        Me.countsr.Name = "countsr"
        Me.countsr.Size = New System.Drawing.Size(143, 23)
        Me.countsr.TabIndex = 26
        Me.countsr.Text = "COUNT"
        Me.countsr.UseVisualStyleBackColor = False
        '
        'countsrf
        '
        Me.countsrf.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.countsrf.FlatAppearance.BorderSize = 0
        Me.countsrf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.countsrf.ForeColor = System.Drawing.Color.Black
        Me.countsrf.Location = New System.Drawing.Point(549, 384)
        Me.countsrf.Name = "countsrf"
        Me.countsrf.Size = New System.Drawing.Size(143, 23)
        Me.countsrf.TabIndex = 27
        Me.countsrf.Text = "COUNT"
        Me.countsrf.UseVisualStyleBackColor = False
        '
        'txtsr
        '
        Me.txtsr.BackColor = System.Drawing.Color.Black
        Me.txtsr.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsr.ForeColor = System.Drawing.Color.White
        Me.txtsr.Location = New System.Drawing.Point(259, 389)
        Me.txtsr.Name = "txtsr"
        Me.txtsr.ReadOnly = True
        Me.txtsr.Size = New System.Drawing.Size(100, 16)
        Me.txtsr.TabIndex = 28
        Me.txtsr.Text = "0"
        '
        'txtsrf
        '
        Me.txtsrf.BackColor = System.Drawing.Color.Black
        Me.txtsrf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsrf.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsrf.ForeColor = System.Drawing.Color.White
        Me.txtsrf.Location = New System.Drawing.Point(722, 387)
        Me.txtsrf.Name = "txtsrf"
        Me.txtsrf.ReadOnly = True
        Me.txtsrf.Size = New System.Drawing.Size(100, 16)
        Me.txtsrf.TabIndex = 29
        Me.txtsrf.Text = "0"
        '
        'total
        '
        Me.total.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.Color.White
        Me.total.Location = New System.Drawing.Point(443, 445)
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Size = New System.Drawing.Size(138, 17)
        Me.total.TabIndex = 30
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label14.Location = New System.Drawing.Point(368, 445)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 20)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "TOTAL :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label15.Location = New System.Drawing.Point(278, 481)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(157, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "TOTAL STUDENTS :"
        '
        'totals
        '
        Me.totals.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.totals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.totals.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totals.ForeColor = System.Drawing.Color.White
        Me.totals.Location = New System.Drawing.Point(443, 482)
        Me.totals.Name = "totals"
        Me.totals.ReadOnly = True
        Me.totals.Size = New System.Drawing.Size(138, 17)
        Me.totals.TabIndex = 33
        '
        'StageReading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.Controls.Add(Me.totals)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.txtsrf)
        Me.Controls.Add(Me.txtsr)
        Me.Controls.Add(Me.countsrf)
        Me.Controls.Add(Me.countsr)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.stopsrf)
        Me.Controls.Add(Me.bussrf)
        Me.Controls.Add(Me.gensrf)
        Me.Controls.Add(Me.deptsrf)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.stopsr)
        Me.Controls.Add(Me.busr)
        Me.Controls.Add(Me.gensr)
        Me.Controls.Add(Me.secsr)
        Me.Controls.Add(Me.deptsr)
        Me.Controls.Add(Me.yearsr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.exitsr)
        Me.Controls.Add(Me.back)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StageReading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StageReading"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents exitsr As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents yearsr As ComboBox
    Friend WithEvents deptsr As ComboBox
    Friend WithEvents secsr As ComboBox
    Friend WithEvents gensr As ComboBox
    Friend WithEvents busr As ComboBox
    Friend WithEvents stopsr As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents deptsrf As ComboBox
    Friend WithEvents gensrf As ComboBox
    Friend WithEvents bussrf As ComboBox
    Friend WithEvents stopsrf As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents countsr As Button
    Friend WithEvents countsrf As Button
    Friend WithEvents txtsr As TextBox
    Friend WithEvents txtsrf As TextBox
    Friend WithEvents total As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents totals As TextBox
End Class
