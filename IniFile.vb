
Public Class IniFile

    ' API functions
    Private Declare Ansi Function GetPrivateProfileString _
                         Lib "kernel32.dll" _
                         Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, _
                                                           ByVal lpKeyName As String, _
                                                           ByVal lpDefault As String, _
                                                           ByVal lpReturnedString As System.Text.StringBuilder, _
                                                           ByVal nSize As Integer, _
                                                           ByVal lpFileName As String) As Integer

    Private Declare Ansi Function WritePrivateProfileString _
                         Lib "kernel32.dll" _
                         Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As String, _
                                                             ByVal lpKeyName As String, _
                                                             ByVal lpString As String, _
                                                             ByVal lpFileName As String) As Integer

    Private Declare Ansi Function GetPrivateProfileInt _
                         Lib "kernel32.dll" _
                         Alias "GetPrivateProfileIntA" (ByVal lpApplicationName As String, _
                                                        ByVal lpKeyName As String, _
                                                        ByVal nDefault As Integer, _
                                                        ByVal lpFileName As String) As Integer

    Private Declare Ansi Function FlushPrivateProfileString _
                         Lib "kernel32.dll" _
                         Alias "WritePrivateProfileStringA" (ByVal lpApplicationName As Integer, _
                                                             ByVal lpKeyName As Integer, _
                                                             ByVal lpString As Integer, _
                                                             ByVal lpFileName As String) As Integer

    Dim strFilename As String

    ' Constructor, accepting a filename
    Public Sub New(ByVal Filename As String)
        strFilename = Filename
    End Sub

    ' Read-only filename property
    ReadOnly Property FileName() As String
        Get
            Return strFilename
        End Get
    End Property

    Public Function GetString(ByVal Section As String, _
                              ByVal Key As String, _
                              ByVal [Default] As String) As String

        ' Returns a string from your INI file
        Dim intCharCount As Integer
        Dim objResult As New System.Text.StringBuilder(256)
        intCharCount = GetPrivateProfileString(Section, Key, [Default], objResult, objResult.Capacity, strFilename)

        If intCharCount > 0 Then GetString = Left(objResult.ToString, intCharCount)
    End Function

    Public Function GetInteger(ByVal Section As String, _
                               ByVal Key As String, _
                               ByVal [Default] As Integer) As Integer
        ' Returns an integer from your INI file
        Return GetPrivateProfileInt(Section, Key, [Default], strFilename)
    End Function

    Public Function GetBoolean(ByVal Section As String, _
                               ByVal Key As String, _
                               ByVal [Default] As Boolean) As Boolean
        ' Returns a boolean from your INI file
        Return (GetPrivateProfileInt(Section, Key, CInt([Default]), strFilename) = 1)
    End Function

    Public Sub WriteString(ByVal Section As String, _
                           ByVal Key As String, _
                           ByVal Value As String)
        ' Writes a string to your INI file
        WritePrivateProfileString(Section, Key, Value, strFilename)
        Flush()
    End Sub

    Public Sub WriteInteger(ByVal Section As String, _
                            ByVal Key As String, _
                            ByVal Value As Integer)
        ' Writes an integer to your INI file
        WriteString(Section, Key, CStr(Value))
        Flush()
    End Sub

    Public Sub WriteBoolean(ByVal Section As String, _
                            ByVal Key As String, _
                            ByVal Value As Boolean)
        ' Writes a boolean to your INI file
        WriteString(Section, Key, CStr(CInt(Value)))
        Flush()
    End Sub

    Private Sub Flush()
        ' Stores all the cached changes to your INI file
        FlushPrivateProfileString(0, 0, 0, strFilename)
    End Sub

End Class
