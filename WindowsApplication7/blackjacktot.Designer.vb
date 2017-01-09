<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class blackjacktot
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
        Me.btnHold = New System.Windows.Forms.Button()
        Me.btncard = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbltuthelp = New System.Windows.Forms.Label()
        Me.Lbltutnext = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnHold
        '
        Me.btnHold.BackColor = System.Drawing.SystemColors.Control
        Me.btnHold.Enabled = False
        Me.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold.Location = New System.Drawing.Point(598, 505)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(108, 96)
        Me.btnHold.TabIndex = 14
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseVisualStyleBackColor = False
        '
        'btncard
        '
        Me.btncard.BackColor = System.Drawing.SystemColors.Control
        Me.btncard.Enabled = False
        Me.btncard.FlatAppearance.BorderSize = 2
        Me.btncard.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btncard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncard.ForeColor = System.Drawing.Color.Black
        Me.btncard.Location = New System.Drawing.Point(428, 505)
        Me.btncard.Name = "btncard"
        Me.btncard.Size = New System.Drawing.Size(108, 96)
        Me.btncard.TabIndex = 15
        Me.btncard.Text = "Hit Me"
        Me.btncard.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.Enabled = False
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(12, 482)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(129, 49)
        Me.btnreset.TabIndex = 16
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(999, 519)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(138, 85)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "19"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGray
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!)
        Me.Button1.Location = New System.Drawing.Point(954, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 94)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "next Page"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lbltuthelp
        '
        Me.lbltuthelp.BackColor = System.Drawing.Color.Transparent
        Me.lbltuthelp.Font = New System.Drawing.Font("MV Boli", 22.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltuthelp.ForeColor = System.Drawing.SystemColors.Window
        Me.lbltuthelp.Location = New System.Drawing.Point(12, 9)
        Me.lbltuthelp.Name = "lbltuthelp"
        Me.lbltuthelp.Size = New System.Drawing.Size(774, 448)
        Me.lbltuthelp.TabIndex = 19
        '
        'Lbltutnext
        '
        Me.Lbltutnext.BackColor = System.Drawing.Color.DarkGreen
        Me.Lbltutnext.Font = New System.Drawing.Font("MV Boli", 18.25!, System.Drawing.FontStyle.Bold)
        Me.Lbltutnext.ForeColor = System.Drawing.Color.Cornsilk
        Me.Lbltutnext.Location = New System.Drawing.Point(807, 9)
        Me.Lbltutnext.Name = "Lbltutnext"
        Me.Lbltutnext.Size = New System.Drawing.Size(324, 62)
        Me.Lbltutnext.TabIndex = 20
        Me.Lbltutnext.Text = "press next to continue"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Red
        Me.lblScore.Location = New System.Drawing.Point(150, 525)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(226, 79)
        Me.lblScore.TabIndex = 21
        Me.lblScore.Text = "1000"
        '
        'btnexit
        '
        Me.btnexit.Enabled = False
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(12, 552)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(129, 49)
        Me.btnexit.TabIndex = 23
        Me.btnexit.Text = "Save and Exit Game"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'blackjacktot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication7.My.Resources.Resources.blackjack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1149, 613)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Lbltutnext)
        Me.Controls.Add(Me.lbltuthelp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btncard)
        Me.Controls.Add(Me.btnHold)
        Me.Name = "blackjacktot"
        Me.Text = "blackjacktot"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHold As System.Windows.Forms.Button
    Friend WithEvents btncard As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lbltuthelp As System.Windows.Forms.Label
    Friend WithEvents Lbltutnext As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
End Class
