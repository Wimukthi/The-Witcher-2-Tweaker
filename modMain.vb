
Module modMain

    Public WitcherTwoUserFolder As String
    Public Function addTrailingSlash(StrPath As String) As String ' this function adds a trailing Slash if its not there

        Try

            If StrPath.EndsWith("\") = False Then
                StrPath = StrPath & "\"
            End If

        Catch ex As Exception
            MsgBox("Something went wrong : " & ex.Message, vbCritical)
        End Try

        Return StrPath
    End Function

    Public Function GetWitcherUserFolder()

        Dim witchertwodir As String
        witchertwodir = addTrailingSlash(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))

        If My.Computer.FileSystem.DirectoryExists(witchertwodir & "Witcher 2\Config") = True Then
            WitcherTwoUserFolder = witchertwodir & "Witcher 2"

        ElseIf My.Computer.FileSystem.DirectoryExists(witchertwodir & "Witcher 2\Config") = False Then

            If My.Computer.FileSystem.DirectoryExists(addTrailingSlash(My.Application.Info.DirectoryPath) & "Config") = True Then
                WitcherTwoUserFolder = addTrailingSlash(My.Application.Info.DirectoryPath)

            ElseIf My.Computer.FileSystem.DirectoryExists(addTrailingSlash(My.Application.Info.DirectoryPath) & "Config") = False Then

                Dim WitcherTwoSettings As New FolderBrowserDialog
                With WitcherTwoSettings
                    .RootFolder = Environment.SpecialFolder.Desktop
                    .Description = "Please Select the Witcher 2 User Settings Directory [\Witcher 2]"

                    If .ShowDialog = DialogResult.OK Then

                        If My.Computer.FileSystem.FileExists(addTrailingSlash(.SelectedPath) & "Config\User.ini") = True Then
                            WitcherTwoUserFolder = addTrailingSlash(.SelectedPath)

                        Else
                            MsgBox("Selected folder Doesnt Appear to be the Witcher 2 User Settings folder, Please select the correct folder!", vbCritical)
                            Return Nothing
                            Exit Function
                        End If

                    Else
                        Return Nothing
                        Exit Function
                    End If

                End With
            End If

        End If

        Return Nothing
    End Function

End Module
