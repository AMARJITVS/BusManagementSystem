<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.add1 = New System.Windows.Forms.Button()
        Me.del = New System.Windows.Forms.Button()
        Me.stage = New System.Windows.Forms.Button()
        Me.BusSuggestion = New System.Windows.Forms.Button()
        Me.Exit1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Indication = New System.Windows.Forms.TextBox()
        Me.feesmain = New System.Windows.Forms.Button()
        Me.backmain = New System.Windows.Forms.Button()
        Me.help = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'add1
        '
        Me.add1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.add1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add1.ForeColor = System.Drawing.Color.Black
        Me.add1.Location = New System.Drawing.Point(24, 81)
        Me.add1.Name = "add1"
        Me.add1.Size = New System.Drawing.Size(250, 180)
        Me.add1.TabIndex = 0
        Me.add1.Text = "ADDING MEMBERS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( Adding Entries of Students and Faculty )"
        Me.add1.UseVisualStyleBackColor = False
        '
        'del
        '
        Me.del.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.del.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del.Location = New System.Drawing.Point(290, 81)
        Me.del.Name = "del"
        Me.del.Size = New System.Drawing.Size(250, 180)
        Me.del.TabIndex = 1
        Me.del.Text = "DELETING MEMBERS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deleting Entries of Students and Faculty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( Includes exportin" &
    "g to Excel files )"
        Me.del.UseVisualStyleBackColor = False
        '
        'stage
        '
        Me.stage.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.stage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stage.Location = New System.Drawing.Point(24, 268)
        Me.stage.Name = "stage"
        Me.stage.Size = New System.Drawing.Size(250, 180)
        Me.stage.TabIndex = 2
        Me.stage.Text = "STAGE-WISE READINGS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( Includes Stage-wise readings of passengers )"
        Me.stage.UseVisualStyleBackColor = False
        '
        'BusSuggestion
        '
        Me.BusSuggestion.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BusSuggestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BusSuggestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusSuggestion.Location = New System.Drawing.Point(290, 267)
        Me.BusSuggestion.Name = "BusSuggestion"
        Me.BusSuggestion.Size = New System.Drawing.Size(250, 180)
        Me.BusSuggestion.TabIndex = 3
        Me.BusSuggestion.Text = "BUS SUGGESTIONS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "( Suggests Alternate buses )"
        Me.BusSuggestion.UseVisualStyleBackColor = False
        '
        'Exit1
        '
        Me.Exit1.BackColor = System.Drawing.Color.Red
        Me.Exit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Exit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exit1.Location = New System.Drawing.Point(693, 461)
        Me.Exit1.Name = "Exit1"
        Me.Exit1.Size = New System.Drawing.Size(143, 55)
        Me.Exit1.TabIndex = 4
        Me.Exit1.Text = "EXIT"
        Me.Exit1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(122, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(597, 46)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BUS MANAGEMENT SYSTEM"
        '
        'Indication
        '
        Me.Indication.BackColor = System.Drawing.Color.Black
        Me.Indication.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Indication.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Indication.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Indication.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Indication.Location = New System.Drawing.Point(12, 480)
        Me.Indication.Name = "Indication"
        Me.Indication.Size = New System.Drawing.Size(262, 16)
        Me.Indication.TabIndex = 7
        '
        'feesmain
        '
        Me.feesmain.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.feesmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.feesmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feesmain.ForeColor = System.Drawing.Color.Black
        Me.feesmain.Location = New System.Drawing.Point(556, 81)
        Me.feesmain.Name = "feesmain"
        Me.feesmain.Size = New System.Drawing.Size(250, 180)
        Me.feesmain.TabIndex = 8
        Me.feesmain.Text = "SEARCH" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Search using Ref. ID or Register number)"
        Me.feesmain.UseVisualStyleBackColor = False
        '
        'backmain
        '
        Me.backmain.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.backmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backmain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backmain.ForeColor = System.Drawing.Color.Black
        Me.backmain.Location = New System.Drawing.Point(556, 268)
        Me.backmain.Name = "backmain"
        Me.backmain.Size = New System.Drawing.Size(250, 180)
        Me.backmain.TabIndex = 9
        Me.backmain.Text = "BACKUP" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EXPORTING TO EXCEL FILE"
        Me.backmain.UseVisualStyleBackColor = False
        '
        'help
        '
        Me.help.BackgroundImage = CType(resources.GetObject("help.BackgroundImage"), System.Drawing.Image)
        Me.help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.help.Location = New System.Drawing.Point(790, 12)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(32, 34)
        Me.help.TabIndex = 10
        Me.help.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.Controls.Add(Me.help)
        Me.Controls.Add(Me.backmain)
        Me.Controls.Add(Me.feesmain)
        Me.Controls.Add(Me.Indication)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Exit1)
        Me.Controls.Add(Me.BusSuggestion)
        Me.Controls.Add(Me.stage)
        Me.Controls.Add(Me.del)
        Me.Controls.Add(Me.add1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents add1 As Button
    Friend WithEvents del As Button
    Friend WithEvents stage As Button
    Friend WithEvents BusSuggestion As Button
    Friend WithEvents Exit1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Indication As TextBox
    Friend WithEvents feesmain As Button
    Friend WithEvents backmain As Button
    Friend WithEvents help As Button
End Class
