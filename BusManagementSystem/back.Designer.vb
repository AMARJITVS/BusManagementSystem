<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class back
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(back))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.st = New System.Windows.Forms.Button()
        Me.fa = New System.Windows.Forms.Button()
        Me.all = New System.Windows.Forms.Button()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(269, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BACKUP ENTRIES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(251, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(319, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CLICK TO EXPORT DETAILS TO AN EXCEL FILE"
        '
        'st
        '
        Me.st.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.st.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.st.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.st.Location = New System.Drawing.Point(53, 206)
        Me.st.Name = "st"
        Me.st.Size = New System.Drawing.Size(190, 58)
        Me.st.TabIndex = 2
        Me.st.Text = "STUDENT DETAILS"
        Me.st.UseVisualStyleBackColor = False
        '
        'fa
        '
        Me.fa.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.fa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.fa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fa.Location = New System.Drawing.Point(313, 206)
        Me.fa.Name = "fa"
        Me.fa.Size = New System.Drawing.Size(190, 58)
        Me.fa.TabIndex = 3
        Me.fa.Text = "FACULTY DETAILS"
        Me.fa.UseVisualStyleBackColor = False
        '
        'all
        '
        Me.all.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.all.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.all.Location = New System.Drawing.Point(593, 206)
        Me.all.Name = "all"
        Me.all.Size = New System.Drawing.Size(190, 58)
        Me.all.TabIndex = 4
        Me.all.Text = "ALL"
        Me.all.UseVisualStyleBackColor = False
        '
        'txt
        '
        Me.txt.BackColor = System.Drawing.Color.Black
        Me.txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.ForeColor = System.Drawing.Color.Lime
        Me.txt.Location = New System.Drawing.Point(128, 385)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(550, 16)
        Me.txt.TabIndex = 5
        Me.txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(-3, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 45)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(692, 469)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 45)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt)
        Me.Controls.Add(Me.all)
        Me.Controls.Add(Me.fa)
        Me.Controls.Add(Me.st)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "back"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "back"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents st As Button
    Friend WithEvents fa As Button
    Friend WithEvents all As Button
    Friend WithEvents txt As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
