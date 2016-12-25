<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbItems = New System.Windows.Forms.ListBox()
        Me.btnAddItems = New System.Windows.Forms.Button()
        Me.btnSaveItems = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.txtItems = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbItems
        '
        Me.lbItems.FormattingEnabled = True
        Me.lbItems.ItemHeight = 20
        Me.lbItems.Location = New System.Drawing.Point(12, 12)
        Me.lbItems.Name = "lbItems"
        Me.lbItems.Size = New System.Drawing.Size(449, 244)
        Me.lbItems.TabIndex = 0
        '
        'btnAddItems
        '
        Me.btnAddItems.Location = New System.Drawing.Point(12, 354)
        Me.btnAddItems.Name = "btnAddItems"
        Me.btnAddItems.Size = New System.Drawing.Size(172, 36)
        Me.btnAddItems.TabIndex = 1
        Me.btnAddItems.Text = "Add Items"
        Me.btnAddItems.UseVisualStyleBackColor = True
        '
        'btnSaveItems
        '
        Me.btnSaveItems.Location = New System.Drawing.Point(290, 354)
        Me.btnSaveItems.Name = "btnSaveItems"
        Me.btnSaveItems.Size = New System.Drawing.Size(171, 36)
        Me.btnSaveItems.TabIndex = 2
        Me.btnSaveItems.Text = "Save Items"
        Me.btnSaveItems.UseVisualStyleBackColor = True
        '
        'txtFileName
        '
        Me.txtFileName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileName.Location = New System.Drawing.Point(12, 271)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(449, 32)
        Me.txtFileName.TabIndex = 3
        '
        'txtItems
        '
        Me.txtItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItems.Location = New System.Drawing.Point(12, 309)
        Me.txtItems.Name = "txtItems"
        Me.txtItems.Size = New System.Drawing.Size(449, 32)
        Me.txtItems.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(473, 402)
        Me.Controls.Add(Me.txtItems)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnSaveItems)
        Me.Controls.Add(Me.btnAddItems)
        Me.Controls.Add(Me.lbItems)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbItems As System.Windows.Forms.ListBox
    Friend WithEvents btnAddItems As System.Windows.Forms.Button
    Friend WithEvents btnSaveItems As System.Windows.Forms.Button
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents txtItems As System.Windows.Forms.TextBox

End Class
