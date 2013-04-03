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
        Me.components = New System.ComponentModel.Container()
        Me.Fire = New System.Windows.Forms.Button()
        Me.UDPHandler = New System.ComponentModel.BackgroundWorker()
        Me.SendTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OpenPayloadFile = New System.Windows.Forms.OpenFileDialog()
        Me.PayloadFileBox = New System.Windows.Forms.RichTextBox()
        Me.SendRateBar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenPayload = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TargetName = New System.Windows.Forms.TextBox()
        Me.TargetPort = New System.Windows.Forms.TextBox()
        Me.LockButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CounterBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SendRateBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fire
        '
        Me.Fire.BackColor = System.Drawing.Color.Red
        Me.Fire.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fire.ForeColor = System.Drawing.Color.White
        Me.Fire.Location = New System.Drawing.Point(160, 120)
        Me.Fire.Name = "Fire"
        Me.Fire.Size = New System.Drawing.Size(170, 74)
        Me.Fire.TabIndex = 0
        Me.Fire.Text = "FIRE"
        Me.Fire.UseVisualStyleBackColor = False
        '
        'UDPHandler
        '
        Me.UDPHandler.WorkerSupportsCancellation = True
        '
        'SendTimer
        '
        '
        'OpenPayloadFile
        '
        Me.OpenPayloadFile.FileName = "OpenFileDialog1"
        Me.OpenPayloadFile.Title = "Select a file to use as the payload."
        '
        'PayloadFileBox
        '
        Me.PayloadFileBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayloadFileBox.Location = New System.Drawing.Point(12, 419)
        Me.PayloadFileBox.Name = "PayloadFileBox"
        Me.PayloadFileBox.ReadOnly = True
        Me.PayloadFileBox.Size = New System.Drawing.Size(467, 35)
        Me.PayloadFileBox.TabIndex = 2
        Me.PayloadFileBox.Text = ""
        '
        'SendRateBar
        '
        Me.SendRateBar.Location = New System.Drawing.Point(120, 200)
        Me.SendRateBar.Maximum = 100
        Me.SendRateBar.Minimum = 1
        Me.SendRateBar.Name = "SendRateBar"
        Me.SendRateBar.Size = New System.Drawing.Size(246, 45)
        Me.SendRateBar.TabIndex = 3
        Me.SendRateBar.Value = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 392)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Payload File"
        '
        'OpenPayload
        '
        Me.OpenPayload.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenPayload.Location = New System.Drawing.Point(143, 378)
        Me.OpenPayload.Name = "OpenPayload"
        Me.OpenPayload.Size = New System.Drawing.Size(91, 35)
        Me.OpenPayload.TabIndex = 5
        Me.OpenPayload.Text = "SELECT"
        Me.OpenPayload.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 329)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(12, 352)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TargetName
        '
        Me.TargetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetName.Location = New System.Drawing.Point(108, 85)
        Me.TargetName.Name = "TargetName"
        Me.TargetName.Size = New System.Drawing.Size(317, 29)
        Me.TargetName.TabIndex = 8
        Me.TargetName.Text = "127.0.0.1"
        '
        'TargetPort
        '
        Me.TargetPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TargetPort.Location = New System.Drawing.Point(328, 38)
        Me.TargetPort.Name = "TargetPort"
        Me.TargetPort.Size = New System.Drawing.Size(135, 29)
        Me.TargetPort.TabIndex = 9
        Me.TargetPort.Text = "11000"
        '
        'LockButton
        '
        Me.LockButton.Location = New System.Drawing.Point(183, 32)
        Me.LockButton.Name = "LockButton"
        Me.LockButton.Size = New System.Drawing.Size(124, 47)
        Me.LockButton.TabIndex = 10
        Me.LockButton.Text = "LOCK"
        Me.LockButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 24)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Target IP"
        '
        'CounterBox
        '
        Me.CounterBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CounterBox.Location = New System.Drawing.Point(361, 145)
        Me.CounterBox.Name = "CounterBox"
        Me.CounterBox.Size = New System.Drawing.Size(96, 35)
        Me.CounterBox.TabIndex = 12
        Me.CounterBox.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 24)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "1 Hz"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(324, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "50 Hz"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 465)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CounterBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LockButton)
        Me.Controls.Add(Me.TargetPort)
        Me.Controls.Add(Me.TargetName)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.OpenPayload)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SendRateBar)
        Me.Controls.Add(Me.PayloadFileBox)
        Me.Controls.Add(Me.Fire)
        Me.Name = "Form1"
        Me.Text = "UDP Hammer"
        CType(Me.SendRateBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fire As System.Windows.Forms.Button
    Friend WithEvents UDPHandler As System.ComponentModel.BackgroundWorker
    Friend WithEvents SendTimer As System.Windows.Forms.Timer
    Friend WithEvents OpenPayloadFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PayloadFileBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SendRateBar As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenPayload As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TargetName As System.Windows.Forms.TextBox
    Friend WithEvents TargetPort As System.Windows.Forms.TextBox
    Friend WithEvents LockButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CounterBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
