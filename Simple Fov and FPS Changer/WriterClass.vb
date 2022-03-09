Imports System.Runtime.InteropServices
Imports System.Text
Public Class WriterClass

    Dim ProcList As Process()

#Region "Basic Stuff"
    <DllImport("kernel32.dll")> _
    Private Shared Function ReadProcessMemory(hProcess As IntPtr, lpBaseAddress As IntPtr, <[In](), Out()> buffer As Byte(), size As UInt32, ByRef lpNumberOfBytesWritten As IntPtr) As Int32
    End Function
    <DllImport("kernel32.dll")> _
    Private Shared Function WriteProcessMemory(hProcess As IntPtr, lpBaseAddress As IntPtr, <[In](), Out()> buffer As Byte(), size As UInt32, ByRef lpNumberOfBytesWritten As IntPtr) As Int32
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> _
    Public Shared Function GetKeyState(ByVal virtualKeyCode As Keys) As Short
    End Function
    Private pHandel As IntPtr
    Private ProcessModule As ProcessModule
    Public BaseAddress As Integer
    Public Function Process_Handle(ProcessName As String) As Boolean
        Try
            ProcList = Process.GetProcessesByName(ProcessName)
            If ProcList.Length = 0 Then
                Return False
            Else
                pHandel = ProcList(0).Handle
                ProcessModule = ProcList(0).MainModule
                BaseAddress = ProcessModule.BaseAddress
                Return True
            End If
        Catch ex As Exception
            Console.WriteLine("Process_Handle - " + ex.Message)
            Return False
        End Try
    End Function
    Private Function Read(Address As Integer, Length As Integer) As Byte()
        Dim Buffer As Byte() = New Byte(Length - 1) {}
        Dim Zero As IntPtr = IntPtr.Zero
        ReadProcessMemory(pHandel, New IntPtr(Address), Buffer, UInt32.Parse(Buffer.Length), Zero)
        Return Buffer
    End Function
    Private Sub Write(Address As Integer, Value As Integer)
        Dim Buffer As Byte() = BitConverter.GetBytes(Value)
        Dim Zero As IntPtr = IntPtr.Zero
        WriteProcessMemory(pHandel, New IntPtr(Address), Buffer, UInt32.Parse(Buffer.Length), Zero)
    End Sub
#End Region

    'This is the part you want to edit
#Region "Write Functions (Integer & String)"
    Public Sub WriteInteger(Address As Integer, Value As Integer)
        Write(Address, Value)
    End Sub
    Public Sub WriteString(Address As Integer, Text As String)
        Dim Buffer As Byte() = New ASCIIEncoding().GetBytes(Text)
        Dim Zero As IntPtr = IntPtr.Zero
        WriteProcessMemory(pHandel, New IntPtr(Address), Buffer, UInt32.Parse(Buffer.Length), Text.Length)
    End Sub
    Public Sub WriteFloat(Address As Integer, Float As Single)
        Dim Buffer As Byte() = BitConverter.GetBytes(Float)
        Dim Zero As IntPtr = IntPtr.Zero
        WriteProcessMemory(pHandel, New IntPtr(Address), Buffer, 4, Zero)
    End Sub
    Public Sub WriteBytes(Address As Integer, Bytes As Byte())
        Dim Zero As IntPtr = IntPtr.Zero
        WriteProcessMemory(pHandel, New IntPtr(Address), Bytes, CUInt(Bytes.Length), Zero)
    End Sub
    Public Sub WriteNOP(Address As Integer)
        Dim Buffer As Byte() = New Byte() {&H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90, &H90}
        Dim Zero As IntPtr = IntPtr.Zero
        WriteProcessMemory(pHandel, New IntPtr(Address), Buffer, UInt32.Parse(Buffer.Length), Zero)
    End Sub


#End Region
#Region "Read Functions (Integer & String)"
    Public Function ReadInteger(Address As Integer, Optional Length As Integer = 4) As Integer
        Return BitConverter.ToInt32(Read(Address, Length), 0)
    End Function
    Public Function ReadFloat(Address As Integer, Optional Length As Integer = 4) As Double
        Return BitConverter.ToSingle(Read(Address, Length), 0)
    End Function
    Public Function ReadString(Address As Integer, Optional Length As Integer = 4) As String
        Return New ASCIIEncoding().GetString(Read(Address, Length))
    End Function
    Public Function ReadBytes(Address As Integer, Length As Integer) As Byte()
        Return Read(Address, Length)
    End Function
#End Region
#Region "Extra"
    Public Function HotKey(Key As Keys) As Boolean
        Return Convert.ToBoolean(GetKeyState(Key))
    End Function
    Private Check_res As Boolean = True
    Public Function Check_Value(Value As String) As Integer
        For Each a As Char In Value
            If Char.IsNumber(a, 0) Then
                Check_res = True
            Else
                Check_res = False
                Return 0
                Exit For
            End If
        Next
        Return Convert.ToInt32(Value)
    End Function
#End Region


End Class
