<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngameScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngameScreen))
        Me.imglstCard = New System.Windows.Forms.ImageList(Me.components)
        Me.picCard = New System.Windows.Forms.PictureBox()
        Me.btncard = New System.Windows.Forms.Button()
        Me.lblvalue = New System.Windows.Forms.Label()
        Me.picCard2 = New System.Windows.Forms.PictureBox()
        Me.lblvalue2 = New System.Windows.Forms.Label()
        Me.LblValue3 = New System.Windows.Forms.Label()
        Me.LblValue4 = New System.Windows.Forms.Label()
        Me.Lblvalue5 = New System.Windows.Forms.Label()
        Me.picCard3 = New System.Windows.Forms.PictureBox()
        Me.picCard4 = New System.Windows.Forms.PictureBox()
        Me.picCard5 = New System.Windows.Forms.PictureBox()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.lbldealertest = New System.Windows.Forms.Label()
        Me.lblResultlose = New System.Windows.Forms.Label()
        Me.lblresultwin = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnstart = New System.Windows.Forms.Button()
        Me.lblnameage = New System.Windows.Forms.Label()
        Me.lblsaveinfo = New System.Windows.Forms.Label()
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imglstCard
        '
        Me.imglstCard.ImageStream = CType(resources.GetObject("imglstCard.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglstCard.TransparentColor = System.Drawing.Color.Transparent
        Me.imglstCard.Images.SetKeyName(0, "blue back of cards.png")
        Me.imglstCard.Images.SetKeyName(1, "2c.png")
        Me.imglstCard.Images.SetKeyName(2, "2d.png")
        Me.imglstCard.Images.SetKeyName(3, "2h.png")
        Me.imglstCard.Images.SetKeyName(4, "2s.png")
        Me.imglstCard.Images.SetKeyName(5, "3c.png")
        Me.imglstCard.Images.SetKeyName(6, "3d.png")
        Me.imglstCard.Images.SetKeyName(7, "3h.png")
        Me.imglstCard.Images.SetKeyName(8, "3s.png")
        Me.imglstCard.Images.SetKeyName(9, "4c.png")
        Me.imglstCard.Images.SetKeyName(10, "4d.png")
        Me.imglstCard.Images.SetKeyName(11, "4h.png")
        Me.imglstCard.Images.SetKeyName(12, "4s.png")
        Me.imglstCard.Images.SetKeyName(13, "5c.png")
        Me.imglstCard.Images.SetKeyName(14, "5d.png")
        Me.imglstCard.Images.SetKeyName(15, "5h.png")
        Me.imglstCard.Images.SetKeyName(16, "5s.png")
        Me.imglstCard.Images.SetKeyName(17, "6c.png")
        Me.imglstCard.Images.SetKeyName(18, "6d.png")
        Me.imglstCard.Images.SetKeyName(19, "6h.png")
        Me.imglstCard.Images.SetKeyName(20, "6s.png")
        Me.imglstCard.Images.SetKeyName(21, "7c.png")
        Me.imglstCard.Images.SetKeyName(22, "7d.png")
        Me.imglstCard.Images.SetKeyName(23, "7h.png")
        Me.imglstCard.Images.SetKeyName(24, "7s.png")
        Me.imglstCard.Images.SetKeyName(25, "8c.png")
        Me.imglstCard.Images.SetKeyName(26, "8d.png")
        Me.imglstCard.Images.SetKeyName(27, "8h.png")
        Me.imglstCard.Images.SetKeyName(28, "8s.png")
        Me.imglstCard.Images.SetKeyName(29, "9c.png")
        Me.imglstCard.Images.SetKeyName(30, "9d.png")
        Me.imglstCard.Images.SetKeyName(31, "9h.png")
        Me.imglstCard.Images.SetKeyName(32, "9s.png")
        Me.imglstCard.Images.SetKeyName(33, "10c.png")
        Me.imglstCard.Images.SetKeyName(34, "10d.png")
        Me.imglstCard.Images.SetKeyName(35, "10h.png")
        Me.imglstCard.Images.SetKeyName(36, "10s.png")
        Me.imglstCard.Images.SetKeyName(37, "jc.png")
        Me.imglstCard.Images.SetKeyName(38, "jd.png")
        Me.imglstCard.Images.SetKeyName(39, "jh.png")
        Me.imglstCard.Images.SetKeyName(40, "js.png")
        Me.imglstCard.Images.SetKeyName(41, "qc.png")
        Me.imglstCard.Images.SetKeyName(42, "qd.png")
        Me.imglstCard.Images.SetKeyName(43, "qh.png")
        Me.imglstCard.Images.SetKeyName(44, "qs.png")
        Me.imglstCard.Images.SetKeyName(45, "kc.png")
        Me.imglstCard.Images.SetKeyName(46, "ks.png")
        Me.imglstCard.Images.SetKeyName(47, "kh.png")
        Me.imglstCard.Images.SetKeyName(48, "kd.png")
        Me.imglstCard.Images.SetKeyName(49, "ad.png")
        Me.imglstCard.Images.SetKeyName(50, "ac.png")
        Me.imglstCard.Images.SetKeyName(51, "ah.png")
        Me.imglstCard.Images.SetKeyName(52, "as.png")
        '
        'picCard
        '
        Me.picCard.BackColor = System.Drawing.Color.Transparent
        Me.picCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picCard.Enabled = False
        Me.picCard.Location = New System.Drawing.Point(85, 272)
        Me.picCard.Name = "picCard"
        Me.picCard.Size = New System.Drawing.Size(86, 125)
        Me.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard.TabIndex = 0
        Me.picCard.TabStop = False
        '
        'btncard
        '
        Me.btncard.BackColor = System.Drawing.SystemColors.Control
        Me.btncard.FlatAppearance.BorderSize = 2
        Me.btncard.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btncard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncard.ForeColor = System.Drawing.Color.Black
        Me.btncard.Location = New System.Drawing.Point(515, 726)
        Me.btncard.Name = "btncard"
        Me.btncard.Size = New System.Drawing.Size(125, 135)
        Me.btncard.TabIndex = 1
        Me.btncard.Text = "Hit Me"
        Me.btncard.UseVisualStyleBackColor = False
        Me.btncard.Visible = False
        '
        'lblvalue
        '
        Me.lblvalue.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblvalue.Location = New System.Drawing.Point(84, 248)
        Me.lblvalue.Name = "lblvalue"
        Me.lblvalue.Size = New System.Drawing.Size(28, 21)
        Me.lblvalue.TabIndex = 2
        Me.lblvalue.Visible = False
        '
        'picCard2
        '
        Me.picCard2.BackColor = System.Drawing.Color.Transparent
        Me.picCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCard2.Enabled = False
        Me.picCard2.Location = New System.Drawing.Point(324, 430)
        Me.picCard2.Name = "picCard2"
        Me.picCard2.Size = New System.Drawing.Size(86, 125)
        Me.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard2.TabIndex = 3
        Me.picCard2.TabStop = False
        '
        'lblvalue2
        '
        Me.lblvalue2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblvalue2.Location = New System.Drawing.Point(321, 406)
        Me.lblvalue2.Name = "lblvalue2"
        Me.lblvalue2.Size = New System.Drawing.Size(28, 21)
        Me.lblvalue2.TabIndex = 4
        Me.lblvalue2.UseMnemonic = False
        Me.lblvalue2.Visible = False
        '
        'LblValue3
        '
        Me.LblValue3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblValue3.Location = New System.Drawing.Point(618, 469)
        Me.LblValue3.Name = "LblValue3"
        Me.LblValue3.Size = New System.Drawing.Size(23, 24)
        Me.LblValue3.TabIndex = 5
        Me.LblValue3.Visible = False
        '
        'LblValue4
        '
        Me.LblValue4.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblValue4.Location = New System.Drawing.Point(898, 403)
        Me.LblValue4.Name = "LblValue4"
        Me.LblValue4.Size = New System.Drawing.Size(23, 24)
        Me.LblValue4.TabIndex = 6
        Me.LblValue4.Visible = False
        '
        'Lblvalue5
        '
        Me.Lblvalue5.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Lblvalue5.Location = New System.Drawing.Point(1137, 227)
        Me.Lblvalue5.Name = "Lblvalue5"
        Me.Lblvalue5.Size = New System.Drawing.Size(23, 32)
        Me.Lblvalue5.TabIndex = 7
        Me.Lblvalue5.Visible = False
        '
        'picCard3
        '
        Me.picCard3.BackColor = System.Drawing.Color.Transparent
        Me.picCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picCard3.Enabled = False
        Me.picCard3.Location = New System.Drawing.Point(621, 496)
        Me.picCard3.Name = "picCard3"
        Me.picCard3.Size = New System.Drawing.Size(86, 125)
        Me.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard3.TabIndex = 8
        Me.picCard3.TabStop = False
        '
        'picCard4
        '
        Me.picCard4.BackColor = System.Drawing.Color.Transparent
        Me.picCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCard4.Enabled = False
        Me.picCard4.Location = New System.Drawing.Point(901, 430)
        Me.picCard4.Name = "picCard4"
        Me.picCard4.Size = New System.Drawing.Size(86, 125)
        Me.picCard4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard4.TabIndex = 9
        Me.picCard4.TabStop = False
        '
        'picCard5
        '
        Me.picCard5.BackColor = System.Drawing.Color.Transparent
        Me.picCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picCard5.Enabled = False
        Me.picCard5.Location = New System.Drawing.Point(1140, 272)
        Me.picCard5.Name = "picCard5"
        Me.picCard5.Size = New System.Drawing.Size(86, 125)
        Me.picCard5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCard5.TabIndex = 10
        Me.picCard5.TabStop = False
        '
        'btnreset
        '
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnreset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.Location = New System.Drawing.Point(12, 750)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(129, 49)
        Me.btnreset.TabIndex = 11
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        Me.btnreset.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(1161, 782)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(138, 79)
        Me.lblTotal.TabIndex = 12
        '
        'btnHold
        '
        Me.btnHold.BackColor = System.Drawing.SystemColors.Control
        Me.btnHold.Enabled = False
        Me.btnHold.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold.Location = New System.Drawing.Point(683, 726)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(125, 135)
        Me.btnHold.TabIndex = 13
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseVisualStyleBackColor = False
        Me.btnHold.Visible = False
        '
        'lbldealertest
        '
        Me.lbldealertest.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lbldealertest.Location = New System.Drawing.Point(512, 9)
        Me.lbldealertest.Name = "lbldealertest"
        Me.lbldealertest.Size = New System.Drawing.Size(36, 24)
        Me.lbldealertest.TabIndex = 14
        Me.lbldealertest.Visible = False
        '
        'lblResultlose
        '
        Me.lblResultlose.BackColor = System.Drawing.Color.Transparent
        Me.lblResultlose.Font = New System.Drawing.Font("MV Boli", 60.25!, System.Drawing.FontStyle.Bold)
        Me.lblResultlose.ForeColor = System.Drawing.Color.Red
        Me.lblResultlose.Location = New System.Drawing.Point(99, 78)
        Me.lblResultlose.Name = "lblResultlose"
        Me.lblResultlose.Size = New System.Drawing.Size(1032, 494)
        Me.lblResultlose.TabIndex = 15
        Me.lblResultlose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblResultlose.Visible = False
        '
        'lblresultwin
        '
        Me.lblresultwin.BackColor = System.Drawing.Color.Transparent
        Me.lblresultwin.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.0!, System.Drawing.FontStyle.Bold)
        Me.lblresultwin.ForeColor = System.Drawing.Color.Gold
        Me.lblresultwin.Location = New System.Drawing.Point(127, 83)
        Me.lblresultwin.Name = "lblresultwin"
        Me.lblresultwin.Size = New System.Drawing.Size(1064, 538)
        Me.lblresultwin.TabIndex = 16
        Me.lblresultwin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblresultwin.Visible = False
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.Color.Transparent
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 55.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.Color.Red
        Me.lblScore.Location = New System.Drawing.Point(184, 772)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(226, 79)
        Me.lblScore.TabIndex = 17
        '
        'btnexit
        '
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(12, 821)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(129, 49)
        Me.btnexit.TabIndex = 19
        Me.btnexit.Text = "Save and Exit Game"
        Me.btnexit.UseVisualStyleBackColor = True
        Me.btnexit.Visible = False
        '
        'btnstart
        '
        Me.btnstart.BackColor = System.Drawing.SystemColors.Control
        Me.btnstart.FlatAppearance.BorderSize = 2
        Me.btnstart.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnstart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstart.ForeColor = System.Drawing.Color.Black
        Me.btnstart.Location = New System.Drawing.Point(467, 726)
        Me.btnstart.Name = "btnstart"
        Me.btnstart.Size = New System.Drawing.Size(397, 135)
        Me.btnstart.TabIndex = 21
        Me.btnstart.Text = "Start Game"
        Me.btnstart.UseVisualStyleBackColor = False
        '
        'lblnameage
        '
        Me.lblnameage.BackColor = System.Drawing.Color.Transparent
        Me.lblnameage.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnameage.ForeColor = System.Drawing.Color.Red
        Me.lblnameage.Location = New System.Drawing.Point(6, 9)
        Me.lblnameage.Name = "lblnameage"
        Me.lblnameage.Size = New System.Drawing.Size(106, 79)
        Me.lblnameage.TabIndex = 22
        Me.lblnameage.Text = "Name:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Age:"
        '
        'lblsaveinfo
        '
        Me.lblsaveinfo.BackColor = System.Drawing.Color.Transparent
        Me.lblsaveinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsaveinfo.ForeColor = System.Drawing.Color.Red
        Me.lblsaveinfo.Location = New System.Drawing.Point(118, 9)
        Me.lblsaveinfo.Name = "lblsaveinfo"
        Me.lblsaveinfo.Size = New System.Drawing.Size(415, 79)
        Me.lblsaveinfo.TabIndex = 23
        '
        'frmIngameScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication7.My.Resources.Resources.blackjack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1311, 873)
        Me.Controls.Add(Me.lblsaveinfo)
        Me.Controls.Add(Me.lblnameage)
        Me.Controls.Add(Me.btnstart)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblresultwin)
        Me.Controls.Add(Me.lblResultlose)
        Me.Controls.Add(Me.lbldealertest)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.picCard5)
        Me.Controls.Add(Me.picCard4)
        Me.Controls.Add(Me.picCard3)
        Me.Controls.Add(Me.Lblvalue5)
        Me.Controls.Add(Me.LblValue4)
        Me.Controls.Add(Me.LblValue3)
        Me.Controls.Add(Me.lblvalue2)
        Me.Controls.Add(Me.picCard2)
        Me.Controls.Add(Me.lblvalue)
        Me.Controls.Add(Me.btncard)
        Me.Controls.Add(Me.picCard)
        Me.Name = "frmIngameScreen"
        Me.Text = "BlackJack"
        CType(Me.picCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCard5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imglstCard As System.Windows.Forms.ImageList
    Friend WithEvents picCard As System.Windows.Forms.PictureBox
    Friend WithEvents btncard As System.Windows.Forms.Button
    Friend WithEvents lblvalue As System.Windows.Forms.Label
    Friend WithEvents picCard2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblvalue2 As System.Windows.Forms.Label
    Friend WithEvents LblValue3 As System.Windows.Forms.Label
    Friend WithEvents LblValue4 As System.Windows.Forms.Label
    Friend WithEvents Lblvalue5 As System.Windows.Forms.Label
    Friend WithEvents picCard3 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard4 As System.Windows.Forms.PictureBox
    Friend WithEvents picCard5 As System.Windows.Forms.PictureBox
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnHold As System.Windows.Forms.Button
    Friend WithEvents lbldealertest As System.Windows.Forms.Label
    Friend WithEvents lblResultlose As System.Windows.Forms.Label
    Friend WithEvents lblresultwin As System.Windows.Forms.Label
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnstart As System.Windows.Forms.Button
    Friend WithEvents lblnameage As System.Windows.Forms.Label
    Friend WithEvents lblsaveinfo As System.Windows.Forms.Label

End Class
