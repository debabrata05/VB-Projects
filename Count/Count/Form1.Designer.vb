<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCount
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.listParagraph = New System.Windows.Forms.ListBox()
        Me.txtAddressBar = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnCharacters = New System.Windows.Forms.Button()
        Me.btnSrntences = New System.Windows.Forms.Button()
        Me.btnWords = New System.Windows.Forms.Button()
        Me.btnConsonants = New System.Windows.Forms.Button()
        Me.btnVowels = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtHelp = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(762, 12)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(188, 32)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "BROSWE"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'listParagraph
        '
        Me.listParagraph.FormattingEnabled = True
        Me.listParagraph.ItemHeight = 25
        Me.listParagraph.Location = New System.Drawing.Point(12, 110)
        Me.listParagraph.Name = "listParagraph"
        Me.listParagraph.Size = New System.Drawing.Size(713, 429)
        Me.listParagraph.TabIndex = 1
        '
        'txtAddressBar
        '
        Me.txtAddressBar.Location = New System.Drawing.Point(12, 12)
        Me.txtAddressBar.Name = "txtAddressBar"
        Me.txtAddressBar.Size = New System.Drawing.Size(713, 32)
        Me.txtAddressBar.TabIndex = 2
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(244, 61)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(188, 32)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnCharacters
        '
        Me.btnCharacters.Location = New System.Drawing.Point(762, 175)
        Me.btnCharacters.Name = "btnCharacters"
        Me.btnCharacters.Size = New System.Drawing.Size(188, 32)
        Me.btnCharacters.TabIndex = 4
        Me.btnCharacters.Text = "CHARACTERS"
        Me.btnCharacters.UseVisualStyleBackColor = True
        '
        'btnSrntences
        '
        Me.btnSrntences.Location = New System.Drawing.Point(762, 366)
        Me.btnSrntences.Name = "btnSrntences"
        Me.btnSrntences.Size = New System.Drawing.Size(188, 32)
        Me.btnSrntences.TabIndex = 5
        Me.btnSrntences.Text = "SENTENCES"
        Me.btnSrntences.UseVisualStyleBackColor = True
        '
        'btnWords
        '
        Me.btnWords.Location = New System.Drawing.Point(762, 317)
        Me.btnWords.Name = "btnWords"
        Me.btnWords.Size = New System.Drawing.Size(188, 32)
        Me.btnWords.TabIndex = 6
        Me.btnWords.Text = "WORDS"
        Me.btnWords.UseVisualStyleBackColor = True
        '
        'btnConsonants
        '
        Me.btnConsonants.Location = New System.Drawing.Point(762, 268)
        Me.btnConsonants.Name = "btnConsonants"
        Me.btnConsonants.Size = New System.Drawing.Size(188, 32)
        Me.btnConsonants.TabIndex = 7
        Me.btnConsonants.Text = "CONSONANTS"
        Me.btnConsonants.UseVisualStyleBackColor = True
        '
        'btnVowels
        '
        Me.btnVowels.Location = New System.Drawing.Point(762, 222)
        Me.btnVowels.Name = "btnVowels"
        Me.btnVowels.Size = New System.Drawing.Size(188, 32)
        Me.btnVowels.TabIndex = 8
        Me.btnVowels.Text = "VOWELS"
        Me.btnVowels.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Text Files|*.txt"
        '
        'txtHelp
        '
        Me.txtHelp.AllowDrop = True
        Me.txtHelp.Location = New System.Drawing.Point(736, 486)
        Me.txtHelp.Name = "txtHelp"
        Me.txtHelp.Size = New System.Drawing.Size(214, 32)
        Me.txtHelp.TabIndex = 9
        '
        'formCount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 552)
        Me.Controls.Add(Me.txtHelp)
        Me.Controls.Add(Me.btnVowels)
        Me.Controls.Add(Me.btnConsonants)
        Me.Controls.Add(Me.btnWords)
        Me.Controls.Add(Me.btnSrntences)
        Me.Controls.Add(Me.btnCharacters)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtAddressBar)
        Me.Controls.Add(Me.listParagraph)
        Me.Controls.Add(Me.btnBrowse)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "formCount"
        Me.Text = "COUNT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents listParagraph As System.Windows.Forms.ListBox
    Friend WithEvents txtAddressBar As System.Windows.Forms.TextBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnCharacters As System.Windows.Forms.Button
    Friend WithEvents btnSrntences As System.Windows.Forms.Button
    Friend WithEvents btnWords As System.Windows.Forms.Button
    Friend WithEvents btnConsonants As System.Windows.Forms.Button
    Friend WithEvents btnVowels As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtHelp As System.Windows.Forms.TextBox

End Class
