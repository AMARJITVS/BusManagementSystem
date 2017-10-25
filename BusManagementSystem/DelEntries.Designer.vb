<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DelEntries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DelEntries))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.del = New System.Windows.Forms.Button()
        Me.delall = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.delpan = New System.Windows.Forms.Panel()
        Me.delallpan = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.delsf = New System.Windows.Forms.Button()
        Me.delf = New System.Windows.Forms.Button()
        Me.dels = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.warning = New System.Windows.Forms.TextBox()
        Me.indi = New System.Windows.Forms.TextBox()
        Me.delbutton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.delrol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.delpan.SuspendLayout()
        Me.delallpan.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(0, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(204, 55)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(0, 456)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(204, 55)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 74)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(285, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "DELETE MEMBERS"
        '
        'del
        '
        Me.del.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del.Location = New System.Drawing.Point(0, 0)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(204, 207)
        Me.del.TabIndex = 4
        Me.del.Text = "DELETE AN ENTRY"
        Me.del.UseVisualStyleBackColor = False
        '
        'delall
        '
        Me.delall.BackColor = System.Drawing.Color.Silver
        Me.delall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delall.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delall.ForeColor = System.Drawing.Color.Red
        Me.delall.Location = New System.Drawing.Point(0, 203)
        Me.delall.Name = "delall"
        Me.delall.Size = New System.Drawing.Size(204, 133)
        Me.delall.TabIndex = 5
        Me.delall.Text = "DELETE ALL ENTRIES" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(WARNING:All entries will be deleted)"
        Me.delall.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.del)
        Me.Panel2.Controls.Add(Me.delall)
        Me.Panel2.Location = New System.Drawing.Point(0, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(204, 336)
        Me.Panel2.TabIndex = 6
        '
        'delpan
        '
        Me.delpan.Controls.Add(Me.delallpan)
        Me.delpan.Controls.Add(Me.indi)
        Me.delpan.Controls.Add(Me.delbutton)
        Me.delpan.Controls.Add(Me.Label3)
        Me.delpan.Controls.Add(Me.delrol)
        Me.delpan.Controls.Add(Me.Label2)
        Me.delpan.Location = New System.Drawing.Point(201, 73)
        Me.delpan.Name = "delpan"
        Me.delpan.Size = New System.Drawing.Size(631, 438)
        Me.delpan.TabIndex = 7
        '
        'delallpan
        '
        Me.delallpan.Controls.Add(Me.Label7)
        Me.delallpan.Controls.Add(Me.delsf)
        Me.delallpan.Controls.Add(Me.delf)
        Me.delallpan.Controls.Add(Me.dels)
        Me.delallpan.Controls.Add(Me.Label6)
        Me.delallpan.Controls.Add(Me.Label5)
        Me.delallpan.Controls.Add(Me.label4)
        Me.delallpan.Controls.Add(Me.warning)
        Me.delallpan.Location = New System.Drawing.Point(0, 0)
        Me.delallpan.Name = "delallpan"
        Me.delallpan.Size = New System.Drawing.Size(634, 438)
        Me.delallpan.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(123, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(351, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "FEATURE : Exporting the whole entries to EXCEL file has been included."
        '
        'delsf
        '
        Me.delsf.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.delsf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delsf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delsf.ForeColor = System.Drawing.Color.Red
        Me.delsf.Location = New System.Drawing.Point(393, 297)
        Me.delsf.Name = "delsf"
        Me.delsf.Size = New System.Drawing.Size(101, 44)
        Me.delsf.TabIndex = 6
        Me.delsf.Text = "DELETE"
        Me.delsf.UseVisualStyleBackColor = False
        '
        'delf
        '
        Me.delf.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.delf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delf.ForeColor = System.Drawing.Color.Red
        Me.delf.Location = New System.Drawing.Point(393, 192)
        Me.delf.Name = "delf"
        Me.delf.Size = New System.Drawing.Size(101, 44)
        Me.delf.TabIndex = 5
        Me.delf.Text = "DELETE"
        Me.delf.UseVisualStyleBackColor = False
        '
        'dels
        '
        Me.dels.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.dels.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dels.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dels.ForeColor = System.Drawing.Color.Red
        Me.dels.Location = New System.Drawing.Point(393, 93)
        Me.dels.Name = "dels"
        Me.dels.Size = New System.Drawing.Size(101, 44)
        Me.dels.TabIndex = 4
        Me.dels.Text = "DELETE"
        Me.dels.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(75, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DELETE ALL ENTRIES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(75, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "TO DELETE FACULTY DETAILS"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.ForeColor = System.Drawing.Color.White
        Me.label4.Location = New System.Drawing.Point(75, 109)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(170, 13)
        Me.label4.TabIndex = 1
        Me.label4.Text = "TO DELETE STUDENT DETAILS"
        '
        'warning
        '
        Me.warning.BackColor = System.Drawing.Color.Black
        Me.warning.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.warning.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warning.ForeColor = System.Drawing.Color.Red
        Me.warning.Location = New System.Drawing.Point(78, 25)
        Me.warning.Name = "warning"
        Me.warning.Size = New System.Drawing.Size(477, 23)
        Me.warning.TabIndex = 0
        Me.warning.Text = "WARNING: ALL ENTRIES WILL BE DELETED!!!"
        '
        'indi
        '
        Me.indi.BackColor = System.Drawing.Color.Black
        Me.indi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.indi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.indi.Location = New System.Drawing.Point(468, 152)
        Me.indi.Name = "indi"
        Me.indi.Size = New System.Drawing.Size(153, 13)
        Me.indi.TabIndex = 16
        '
        'delbutton
        '
        Me.delbutton.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.delbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delbutton.Location = New System.Drawing.Point(229, 227)
        Me.delbutton.Name = "delbutton"
        Me.delbutton.Size = New System.Drawing.Size(137, 40)
        Me.delbutton.TabIndex = 15
        Me.delbutton.Text = "DELETE"
        Me.delbutton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(254, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "REG NO"
        '
        'delrol
        '
        Me.delrol.Location = New System.Drawing.Point(148, 149)
        Me.delrol.Name = "delrol"
        Me.delrol.Size = New System.Drawing.Size(300, 20)
        Me.delrol.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(145, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 26)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Note: Both STUDENTS and FACULTY entries can be deleted " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please enter the REGISTE" &
    "R NO."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DelEntries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.Controls.Add(Me.delpan)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "DelEntries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DELETION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.delpan.ResumeLayout(False)
        Me.delpan.PerformLayout()
        Me.delallpan.ResumeLayout(False)
        Me.delallpan.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents del As Button
    Friend WithEvents delall As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents delpan As Panel
    Friend WithEvents indi As TextBox
    Friend WithEvents delbutton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents delrol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents delallpan As Panel
    Friend WithEvents delsf As Button
    Friend WithEvents delf As Button
    Friend WithEvents dels As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents label4 As Label
    Friend WithEvents warning As TextBox
    Friend WithEvents Label7 As Label
End Class
