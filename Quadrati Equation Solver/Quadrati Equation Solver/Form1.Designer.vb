<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEquSolver
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEquSolver))
        Me.txtValueOfa = New System.Windows.Forms.TextBox()
        Me.lblEnterValues = New System.Windows.Forms.Label()
        Me.lblEqun = New System.Windows.Forms.Label()
        Me.txtValueOfb = New System.Windows.Forms.TextBox()
        Me.txtValueOfc = New System.Windows.Forms.TextBox()
        Me.lblRoot2 = New System.Windows.Forms.Label()
        Me.lblValueOfa = New System.Windows.Forms.Label()
        Me.lbValueOfc = New System.Windows.Forms.Label()
        Me.lblRoot1 = New System.Windows.Forms.Label()
        Me.lblValueOfb = New System.Windows.Forms.Label()
        Me.txtRoot1 = New System.Windows.Forms.TextBox()
        Me.txtRoot2 = New System.Windows.Forms.TextBox()
        Me.btnSolution = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtValueOfa
        '
        Me.txtValueOfa.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValueOfa.Location = New System.Drawing.Point(78, 155)
        Me.txtValueOfa.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtValueOfa.Name = "txtValueOfa"
        Me.txtValueOfa.Size = New System.Drawing.Size(145, 38)
        Me.txtValueOfa.TabIndex = 2
        '
        'lblEnterValues
        '
        Me.lblEnterValues.AutoSize = True
        Me.lblEnterValues.Location = New System.Drawing.Point(12, 98)
        Me.lblEnterValues.Name = "lblEnterValues"
        Me.lblEnterValues.Size = New System.Drawing.Size(328, 26)
        Me.lblEnterValues.TabIndex = 3
        Me.lblEnterValues.Text = "Enter the Values of a, b and c"
        '
        'lblEqun
        '
        Me.lblEqun.AutoSize = True
        Me.lblEqun.Location = New System.Drawing.Point(12, 35)
        Me.lblEqun.Name = "lblEqun"
        Me.lblEqun.Size = New System.Drawing.Size(493, 26)
        Me.lblEqun.TabIndex = 4
        Me.lblEqun.Text = "Equation is of the form   :   a X^2 + b X + c=0"
        '
        'txtValueOfb
        '
        Me.txtValueOfb.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValueOfb.Location = New System.Drawing.Point(302, 155)
        Me.txtValueOfb.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtValueOfb.Name = "txtValueOfb"
        Me.txtValueOfb.Size = New System.Drawing.Size(147, 38)
        Me.txtValueOfb.TabIndex = 5
        '
        'txtValueOfc
        '
        Me.txtValueOfc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValueOfc.Location = New System.Drawing.Point(527, 155)
        Me.txtValueOfc.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtValueOfc.Name = "txtValueOfc"
        Me.txtValueOfc.Size = New System.Drawing.Size(152, 38)
        Me.txtValueOfc.TabIndex = 6
        '
        'lblRoot2
        '
        Me.lblRoot2.AutoSize = True
        Me.lblRoot2.Location = New System.Drawing.Point(22, 384)
        Me.lblRoot2.Name = "lblRoot2"
        Me.lblRoot2.Size = New System.Drawing.Size(96, 26)
        Me.lblRoot2.TabIndex = 7
        Me.lblRoot2.Text = "Root2 ="
        '
        'lblValueOfa
        '
        Me.lblValueOfa.AutoSize = True
        Me.lblValueOfa.Location = New System.Drawing.Point(22, 155)
        Me.lblValueOfa.Name = "lblValueOfa"
        Me.lblValueOfa.Size = New System.Drawing.Size(46, 26)
        Me.lblValueOfa.TabIndex = 8
        Me.lblValueOfa.Text = "a ="
        '
        'lbValueOfc
        '
        Me.lbValueOfc.AutoSize = True
        Me.lbValueOfc.Location = New System.Drawing.Point(472, 155)
        Me.lbValueOfc.Name = "lbValueOfc"
        Me.lbValueOfc.Size = New System.Drawing.Size(45, 26)
        Me.lbValueOfc.TabIndex = 9
        Me.lbValueOfc.Text = "c ="
        '
        'lblRoot1
        '
        Me.lblRoot1.AutoSize = True
        Me.lblRoot1.Location = New System.Drawing.Point(22, 303)
        Me.lblRoot1.Name = "lblRoot1"
        Me.lblRoot1.Size = New System.Drawing.Size(96, 26)
        Me.lblRoot1.TabIndex = 10
        Me.lblRoot1.Text = "Root1 ="
        '
        'lblValueOfb
        '
        Me.lblValueOfb.AutoSize = True
        Me.lblValueOfb.Location = New System.Drawing.Point(246, 155)
        Me.lblValueOfb.Name = "lblValueOfb"
        Me.lblValueOfb.Size = New System.Drawing.Size(46, 26)
        Me.lblValueOfb.TabIndex = 11
        Me.lblValueOfb.Text = "b ="
        '
        'txtRoot1
        '
        Me.txtRoot1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoot1.Location = New System.Drawing.Point(128, 300)
        Me.txtRoot1.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRoot1.Name = "txtRoot1"
        Me.txtRoot1.ReadOnly = True
        Me.txtRoot1.Size = New System.Drawing.Size(389, 38)
        Me.txtRoot1.TabIndex = 12
        '
        'txtRoot2
        '
        Me.txtRoot2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoot2.Location = New System.Drawing.Point(128, 381)
        Me.txtRoot2.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.txtRoot2.Name = "txtRoot2"
        Me.txtRoot2.ReadOnly = True
        Me.txtRoot2.Size = New System.Drawing.Size(389, 38)
        Me.txtRoot2.TabIndex = 13
        '
        'btnSolution
        '
        Me.btnSolution.Location = New System.Drawing.Point(270, 213)
        Me.btnSolution.Name = "btnSolution"
        Me.btnSolution.Size = New System.Drawing.Size(193, 61)
        Me.btnSolution.TabIndex = 14
        Me.btnSolution.Text = "SOLUTION"
        Me.btnSolution.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(270, 453)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(193, 61)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'formEquSolver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(695, 526)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSolution)
        Me.Controls.Add(Me.txtRoot2)
        Me.Controls.Add(Me.txtRoot1)
        Me.Controls.Add(Me.lblValueOfb)
        Me.Controls.Add(Me.lblRoot1)
        Me.Controls.Add(Me.lbValueOfc)
        Me.Controls.Add(Me.lblValueOfa)
        Me.Controls.Add(Me.lblRoot2)
        Me.Controls.Add(Me.txtValueOfc)
        Me.Controls.Add(Me.txtValueOfb)
        Me.Controls.Add(Me.lblEqun)
        Me.Controls.Add(Me.lblEnterValues)
        Me.Controls.Add(Me.txtValueOfa)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "formEquSolver"
        Me.Text = "QUADRATIC EQUATION SOLVER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtValueOfa As System.Windows.Forms.TextBox
    Friend WithEvents lblEnterValues As System.Windows.Forms.Label
    Friend WithEvents lblEqun As System.Windows.Forms.Label
    Friend WithEvents txtValueOfb As System.Windows.Forms.TextBox
    Friend WithEvents txtValueOfc As System.Windows.Forms.TextBox
    Friend WithEvents lblRoot2 As System.Windows.Forms.Label
    Friend WithEvents lblValueOfa As System.Windows.Forms.Label
    Friend WithEvents lbValueOfc As System.Windows.Forms.Label
    Friend WithEvents lblRoot1 As System.Windows.Forms.Label
    Friend WithEvents lblValueOfb As System.Windows.Forms.Label
    Friend WithEvents txtRoot1 As System.Windows.Forms.TextBox
    Friend WithEvents txtRoot2 As System.Windows.Forms.TextBox
    Friend WithEvents btnSolution As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
