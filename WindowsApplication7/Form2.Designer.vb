<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmplayerdetails
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.filesListBox = New System.Windows.Forms.ListBox()
        Me.txtplayerdetails = New System.Windows.Forms.TextBox()
        Me.txtplayername = New System.Windows.Forms.TextBox()
        Me.btnsaveuser = New System.Windows.Forms.Button()
        Me.Txtplayerage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.browseButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnread = New System.Windows.Forms.Button()
        Me.Btntutorial = New System.Windows.Forms.Button()
        Me.Btnentergame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'filesListBox
        '
        Me.filesListBox.FormattingEnabled = True
        Me.filesListBox.Location = New System.Drawing.Point(22, 48)
        Me.filesListBox.Name = "filesListBox"
        Me.filesListBox.Size = New System.Drawing.Size(152, 82)
        Me.filesListBox.TabIndex = 7
        '
        'txtplayerdetails
        '
        Me.txtplayerdetails.Location = New System.Drawing.Point(314, 48)
        Me.txtplayerdetails.Multiline = True
        Me.txtplayerdetails.Name = "txtplayerdetails"
        Me.txtplayerdetails.Size = New System.Drawing.Size(116, 82)
        Me.txtplayerdetails.TabIndex = 8
        '
        'txtplayername
        '
        Me.txtplayername.Location = New System.Drawing.Point(237, 371)
        Me.txtplayername.Name = "txtplayername"
        Me.txtplayername.Size = New System.Drawing.Size(118, 20)
        Me.txtplayername.TabIndex = 10
        '
        'btnsaveuser
        '
        Me.btnsaveuser.Location = New System.Drawing.Point(22, 480)
        Me.btnsaveuser.Name = "btnsaveuser"
        Me.btnsaveuser.Size = New System.Drawing.Size(116, 55)
        Me.btnsaveuser.TabIndex = 11
        Me.btnsaveuser.Text = "Create New Game"
        Me.btnsaveuser.UseVisualStyleBackColor = True
        '
        'Txtplayerage
        '
        Me.Txtplayerage.Location = New System.Drawing.Point(237, 432)
        Me.Txtplayerage.Name = "Txtplayerage"
        Me.Txtplayerage.Size = New System.Drawing.Size(118, 20)
        Me.Txtplayerage.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 22)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Please enter your Age"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 22)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Please enter your name"
        '
        'browseButton
        '
        Me.browseButton.Location = New System.Drawing.Point(22, 187)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(152, 55)
        Me.browseButton.TabIndex = 19
        Me.browseButton.Text = "search for save"
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 13.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(18, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(397, 22)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "For a new game please fill in details below"
        '
        'btnread
        '
        Me.btnread.Location = New System.Drawing.Point(314, 187)
        Me.btnread.Name = "btnread"
        Me.btnread.Size = New System.Drawing.Size(116, 55)
        Me.btnread.TabIndex = 21
        Me.btnread.Text = "load profile"
        Me.btnread.UseVisualStyleBackColor = True
        '
        'Btntutorial
        '
        Me.Btntutorial.Location = New System.Drawing.Point(735, 480)
        Me.Btntutorial.Name = "Btntutorial"
        Me.Btntutorial.Size = New System.Drawing.Size(206, 55)
        Me.Btntutorial.TabIndex = 22
        Me.Btntutorial.Text = "Check tutoral"
        Me.Btntutorial.UseVisualStyleBackColor = True
        '
        'Btnentergame
        '
        Me.Btnentergame.Location = New System.Drawing.Point(947, 480)
        Me.Btnentergame.Name = "Btnentergame"
        Me.Btnentergame.Size = New System.Drawing.Size(206, 55)
        Me.Btnentergame.TabIndex = 23
        Me.Btnentergame.Text = "continue to game"
        Me.Btnentergame.UseVisualStyleBackColor = True
        '
        'frmplayerdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication7.My.Resources.Resources.rog5_550___Copy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1165, 547)
        Me.Controls.Add(Me.Btnentergame)
        Me.Controls.Add(Me.Btntutorial)
        Me.Controls.Add(Me.btnread)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.browseButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtplayerage)
        Me.Controls.Add(Me.btnsaveuser)
        Me.Controls.Add(Me.txtplayername)
        Me.Controls.Add(Me.txtplayerdetails)
        Me.Controls.Add(Me.filesListBox)
        Me.Name = "frmplayerdetails"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents filesListBox As System.Windows.Forms.ListBox
    Friend WithEvents txtplayerdetails As System.Windows.Forms.TextBox
    Friend WithEvents txtplayername As System.Windows.Forms.TextBox
    Friend WithEvents btnsaveuser As System.Windows.Forms.Button
    Friend WithEvents Txtplayerage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents browseButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnread As System.Windows.Forms.Button
    Friend WithEvents Btntutorial As System.Windows.Forms.Button
    Friend WithEvents Btnentergame As System.Windows.Forms.Button
End Class
