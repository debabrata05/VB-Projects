<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAnalogAndDigitalClock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAnalogAndDigitalClock))
        Me.lblDigital = New System.Windows.Forms.Label()
        Me.rdbtnAnalog = New System.Windows.Forms.RadioButton()
        Me.rdbtnDigital = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Analog = New System.Windows.Forms.WebBrowser()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDigital
        '
        Me.lblDigital.AutoSize = True
        Me.lblDigital.Font = New System.Drawing.Font("DS-Digital", 70.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDigital.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDigital.Location = New System.Drawing.Point(70, 238)
        Me.lblDigital.Name = "lblDigital"
        Me.lblDigital.Size = New System.Drawing.Size(232, 93)
        Me.lblDigital.TabIndex = 0
        Me.lblDigital.Text = "rasd"
        '
        'rdbtnAnalog
        '
        Me.rdbtnAnalog.AutoSize = True
        Me.rdbtnAnalog.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.rdbtnAnalog.ForeColor = System.Drawing.Color.Lime
        Me.rdbtnAnalog.Location = New System.Drawing.Point(320, 36)
        Me.rdbtnAnalog.Name = "rdbtnAnalog"
        Me.rdbtnAnalog.Size = New System.Drawing.Size(249, 43)
        Me.rdbtnAnalog.TabIndex = 2
        Me.rdbtnAnalog.TabStop = True
        Me.rdbtnAnalog.Text = "Analog Clock"
        Me.rdbtnAnalog.UseVisualStyleBackColor = True
        '
        'rdbtnDigital
        '
        Me.rdbtnDigital.AutoSize = True
        Me.rdbtnDigital.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.rdbtnDigital.ForeColor = System.Drawing.Color.Lime
        Me.rdbtnDigital.Location = New System.Drawing.Point(16, 36)
        Me.rdbtnDigital.Name = "rdbtnDigital"
        Me.rdbtnDigital.Size = New System.Drawing.Size(239, 43)
        Me.rdbtnDigital.TabIndex = 3
        Me.rdbtnDigital.TabStop = True
        Me.rdbtnDigital.Text = "Digital Clock"
        Me.rdbtnDigital.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.rdbtnDigital)
        Me.Panel1.Controls.Add(Me.rdbtnAnalog)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(582, 127)
        Me.Panel1.TabIndex = 4
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Analog
        '
        Me.Analog.Location = New System.Drawing.Point(0, 123)
        Me.Analog.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Analog.Name = "Analog"
        Me.Analog.Size = New System.Drawing.Size(582, 333)
        Me.Analog.TabIndex = 5
        Me.Analog.Url = New System.Uri("http://www.gheos.net/js/clock/clock.swf", System.UriKind.Absolute)
        '
        'formAnalogAndDigitalClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(582, 456)
        Me.Controls.Add(Me.Analog)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblDigital)
        Me.Font = New System.Drawing.Font("DengXian", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "formAnalogAndDigitalClock"
        Me.Text = "ANALOG AND DIGITAL CLOCK"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDigital As System.Windows.Forms.Label
    Friend WithEvents rdbtnAnalog As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnDigital As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Analog As System.Windows.Forms.WebBrowser

End Class
