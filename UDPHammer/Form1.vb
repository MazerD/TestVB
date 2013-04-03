Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class Form1

    Dim payloadFN As String
    Dim payload As [Byte]()
    Dim sendRate As Double
    Const MAX_FREQ As Integer = 50
    Dim client As New UdpClient()
    Dim headerBytes As [Byte]()
    Dim msg As String
    Dim target As New IPEndPoint(IPAddress.Loopback, 11000)
    Dim counter As Long
    Dim payloadFile As FileStream

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        counter = 0
        sendRate = 1
        payloadFN = ""
        'payload = ""
        msg = "This is a test."
        headerBytes = Encoding.ASCII.GetBytes(counter.ToString() + msg)

    End Sub

    Private Sub Fire_Click(sender As System.Object, e As System.EventArgs) Handles Fire.Click

        If (SendTimer.Enabled) Then
            UDPHandler.CancelAsync()
            SendTimer.Stop()
            Fire.BackColor = Color.Red
        Else
            SendTimer.Start()
            Fire.BackColor = Color.Green
        End If

    End Sub

    Private Sub OpenPayloadFile_FileOk(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles OpenPayloadFile.FileOk

        payloadFN = OpenPayloadFile.FileName
        PayloadFileBox.Text = OpenPayloadFile.FileName
        payloadFile = New FileStream(payloadFN, FileMode.Open, FileAccess.Read)


    End Sub

    Private Sub SendRateBar_Scroll(sender As System.Object, e As System.EventArgs) Handles SendRateBar.Scroll

        sendRate = SendRateBar.Value
        SendTimer.Interval = 1000 / ((sendRate / 100) * MAX_FREQ)

    End Sub

    Private Sub OpenPayload_Click(sender As System.Object, e As System.EventArgs) Handles OpenPayload.Click

        OpenPayloadFile.ShowDialog()

    End Sub

    Private Sub UDPHandler_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles UDPHandler.DoWork

        headerBytes = Encoding.ASCII.GetBytes(counter.ToString() + "::" + msg)

        Dim payloadBytes As [Byte]() = Encoding.ASCII.GetBytes("otherstuff!")

        Dim sendBytes(headerBytes.Length + payloadBytes.Length) As Byte

        headerBytes.CopyTo(sendBytes, 0)
        payloadBytes.CopyTo(sendBytes, headerBytes.Length - 1)

        'CounterBox.Text = counter.ToString()
        CounterUpdate()

        client.Send(sendBytes, sendBytes.Length, target)
        counter = counter + 1

    End Sub

    Private Delegate Sub CounterDelegate()
    Private Sub CounterUpdate()

        If (Me.InvokeRequired) Then
            Invoke(New CounterDelegate(AddressOf CounterUpdate))
        Else

            CounterBox.Text = counter.ToString()

        End If

    End Sub

    Private Sub SendTimer_Tick(sender As System.Object, e As System.EventArgs) Handles SendTimer.Tick

        UDPHandler.RunWorkerAsync()

    End Sub

    Private Sub LockButton_Click(sender As System.Object, e As System.EventArgs) Handles LockButton.Click

        target = New IPEndPoint(IPAddress.Parse(TargetName.Text.Trim()), 11000)

    End Sub

    Private Sub TargetName_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TargetName.KeyPress

        If (e.KeyChar.Equals(Keys.Enter)) Then
            LockButton_Click(sender, e)
        End If

    End Sub
End Class
