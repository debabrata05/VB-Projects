<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStopwatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formStopwatch))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblClock = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Lime
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(12, 152)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(0)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(120, 50)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "START"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Red
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(180, 152)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(120, 50)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "STOP"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Yellow
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(346, 152)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(120, 50)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblClock
        '
        Me.lblClock.AutoSize = True
        Me.lblClock.Font = New System.Drawing.Font("DS-Digital", 80.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClock.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblClock.Location = New System.Drawing.Point(153, 9)
        Me.lblClock.Name = "lblClock"
        Me.lblClock.Size = New System.Drawing.Size(172, 106)
        Me.lblClock.TabIndex = 3
        Me.lblClock.Text = "0.0"
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'formStopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(478, 235)
        Me.Controls.Add(Me.lblClock)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formStopwatch"
        Me.Text = "STOPWATCH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents lblClock As System.Windows.Forms.Label
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
