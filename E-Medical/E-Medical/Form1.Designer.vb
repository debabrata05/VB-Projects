<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEMedical
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEMedical))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.linklblSignUp = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 43.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(5, 9)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(1256, 68)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "WELCOME TO THE WORLD OF E-MEDICAL"
        '
        'linklblSignUp
        '
        Me.linklblSignUp.AutoSize = True
        Me.linklblSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linklblSignUp.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linklblSignUp.Location = New System.Drawing.Point(1152, 89)
        Me.linklblSignUp.Name = "linklblSignUp"
        Me.linklblSignUp.Size = New System.Drawing.Size(86, 26)
        Me.linklblSignUp.TabIndex = 2
        Me.linklblSignUp.TabStop = True
        Me.linklblSignUp.Text = "Sign up"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.Location = New System.Drawing.Point(647, 258)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(144, 20)
        Me.LinkLabel1.TabIndex = 27
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forgot Password"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(442, 207)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(349, 32)
        Me.TextBox2.TabIndex = 26
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(442, 163)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(349, 32)
        Me.TextBox1.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 207)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 26)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = " PASSWORD"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(317, 163)
        Me.Label8.Margin = New System.Windows.Forms.Padding(13, 0, 13, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 26)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "USER ID"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(442, 249)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 35)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Sign in"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'formEMedical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1262, 572)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.linklblSignUp)
        Me.Controls.Add(Me.lblHeading)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "formEMedical"
        Me.Text = "E-MEDICAL MANAGEMENT SYSTEM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblHeading As System.Windows.Forms.Label
    Friend WithEvents linklblSignUp As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
