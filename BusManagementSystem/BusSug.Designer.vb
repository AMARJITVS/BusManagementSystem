<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusSug
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusSug))
        Me.backbs = New System.Windows.Forms.Button()
        Me.exitbs = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.busnobs = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.okbs = New System.Windows.Forms.Button()
        Me.selectedbs = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.resultbs = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'backbs
        '
        Me.backbs.BackColor = System.Drawing.Color.Silver
        Me.backbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backbs.Location = New System.Drawing.Point(-1, 470)
        Me.backbs.Margin = New System.Windows.Forms.Padding(4)
        Me.backbs.Name = "backbs"
        Me.backbs.Size = New System.Drawing.Size(143, 37)
        Me.backbs.TabIndex = 1
        Me.backbs.Text = "BACK"
        Me.backbs.UseVisualStyleBackColor = False
        '
        'exitbs
        '
        Me.exitbs.BackColor = System.Drawing.Color.Red
        Me.exitbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exitbs.Location = New System.Drawing.Point(677, 470)
        Me.exitbs.Margin = New System.Windows.Forms.Padding(4)
        Me.exitbs.Name = "exitbs"
        Me.exitbs.Size = New System.Drawing.Size(154, 37)
        Me.exitbs.TabIndex = 2
        Me.exitbs.Text = "EXIT"
        Me.exitbs.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1113, 103)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(254, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "BUS SUGGESTIONS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(37, 167)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "BUS NO :"
        '
        'busnobs
        '
        Me.busnobs.AllowDrop = True
        Me.busnobs.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.busnobs.CheckOnClick = True
        Me.busnobs.FormattingEnabled = True
        Me.busnobs.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30"})
        Me.busnobs.Location = New System.Drawing.Point(152, 148)
        Me.busnobs.Margin = New System.Windows.Forms.Padding(4)
        Me.busnobs.Name = "busnobs"
        Me.busnobs.Size = New System.Drawing.Size(175, 76)
        Me.busnobs.TabIndex = 19
        Me.busnobs.ThreeDCheckBoxes = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(232, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(412, 20)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "NOTE : Enter the BUS NO which are not assigned."
        '
        'okbs
        '
        Me.okbs.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.okbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.okbs.Location = New System.Drawing.Point(170, 280)
        Me.okbs.Margin = New System.Windows.Forms.Padding(4)
        Me.okbs.Name = "okbs"
        Me.okbs.Size = New System.Drawing.Size(157, 28)
        Me.okbs.TabIndex = 22
        Me.okbs.Text = "OK"
        Me.okbs.UseVisualStyleBackColor = False
        '
        'selectedbs
        '
        Me.selectedbs.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.selectedbs.Location = New System.Drawing.Point(15, 248)
        Me.selectedbs.Margin = New System.Windows.Forms.Padding(4)
        Me.selectedbs.Name = "selectedbs"
        Me.selectedbs.ReadOnly = True
        Me.selectedbs.Size = New System.Drawing.Size(116, 186)
        Me.selectedbs.TabIndex = 23
        Me.selectedbs.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 215)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Selected Items :"
        '
        'resultbs
        '
        Me.resultbs.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.resultbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultbs.Location = New System.Drawing.Point(335, 148)
        Me.resultbs.Margin = New System.Windows.Forms.Padding(4)
        Me.resultbs.Name = "resultbs"
        Me.resultbs.ReadOnly = True
        Me.resultbs.Size = New System.Drawing.Size(482, 314)
        Me.resultbs.TabIndex = 25
        Me.resultbs.Text = ""
        '
        'BusSug
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(830, 507)
        Me.Controls.Add(Me.resultbs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.selectedbs)
        Me.Controls.Add(Me.okbs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.busnobs)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.exitbs)
        Me.Controls.Add(Me.backbs)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "BusSug"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BusSug"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backbs As Button
    Friend WithEvents exitbs As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents busnobs As CheckedListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents okbs As Button
    Friend WithEvents selectedbs As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents resultbs As RichTextBox
End Class
