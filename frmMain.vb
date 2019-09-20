Imports The_Witcher_2_Tweaker.IniFile

Public Class frmMain

    Private Sub TextureDownscale_SelectedIndexChanged(sender As System.Object, _
                                                      e As System.EventArgs) _
            Handles TextureDownscale.SelectedIndexChanged
    End Sub

    Private Sub frmMain_Load(sender As System.Object, _
                             e As System.EventArgs) _
            Handles MyBase.Load

        Try
            GetWitcherUserFolder()

            doReadingStuff()

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Public Sub doReadingStuff()

        Try

            If WitcherTwoUserFolder <> "" Then
                Me.Text = "The Witcher 2 Tweaker v" & My.Application.Info.Version.ToString & "   [" & WitcherTwoUserFolder & "]"

                If My.Computer.FileSystem.DirectoryExists(addTrailingSlash(WitcherTwoUserFolder) & "Config") = True Then

                    If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\user.ini") = True Then

                        Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\user.ini")
                        TextureDownscale.Text = userIni.GetString("Rendering", "TextureDownscale", "")
                        AtlasTextureDownscale.Text = userIni.GetString("Rendering", "AtlasTextureDownscale", "")
                        DetailTextureDownscale.Text = userIni.GetString("Rendering", "DetailTextureDownscale", "")
                        MaxTextureSize.Text = userIni.GetString("Rendering", "MaxTextureSize", "")
                        MaxAtlasTextureSize.Text = userIni.GetString("Rendering", "MaxAtlasTextureSize", "")
                        TextureMemoryBudget.Text = userIni.GetString("Rendering", "TextureMemoryBudget", "")
                        TextureTimeBudget.Text = userIni.GetString("Rendering", "TextureTimeBudget", "")
                        MaxCubeShadowSize.Text = userIni.GetString("Rendering", "MaxCubeShadowSize", "")
                        MaxCubeShadowCount.Text = userIni.GetString("Rendering", "MaxCubeShadowCount", "")
                        MaxSpotShadowSize.Text = userIni.GetString("Rendering", "MaxSpotShadowSize", "")
                        MaxSpotShadowCount.Text = userIni.GetString("Rendering", "MaxSpotShadowCount", "")
                        FoliageDistanceScale.Text = userIni.GetString("Rendering", "FoliageDistanceScale", "")
                        MeshDistanceScale.Text = userIni.GetString("Rendering", "MeshDistanceScale", "")
                        CharacterLodGameplayDownscale.Text = userIni.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                        AllowBloom.Text = userIni.GetString("Rendering", "AllowBloom", "")
                        AllowShafts.Text = userIni.GetString("Rendering", "AllowShafts", "")
                        AllowAntialias.Text = userIni.GetString("Rendering", "AllowAntialias", "")
                        AllowBlur.Text = userIni.GetString("Rendering", "AllowBlur", "")
                        AllowDOF.Text = userIni.GetString("Rendering", "AllowDOF", "")
                        AllowDecals.Text = userIni.GetString("Rendering", "AllowDecals", "")
                        AllowVignette.Text = userIni.GetString("Rendering", "AllowVignette", "")
                        AllowSharpen.Text = userIni.GetString("Rendering", "AllowSharpen", "")
                        AllowRain.Text = userIni.GetString("Rendering", "AllowRain", "")
                        AllowSSAO.Text = userIni.GetString("Rendering", "AllowSSAO", "")
                        AllowMotionBlur.Text = userIni.GetString("Rendering", "AllowMotionBlur", "")
                        AllowScatterDOF.Text = userIni.GetString("Rendering", "AllowScatterDOF", "")
                        AllowCutsceneDOF.Text = userIni.GetString("Rendering", "AllowCutsceneDOF", "")
                        DanglesLimiter.Text = userIni.GetString("Rendering", "DanglesLimiter", "")
                        ShadowQuality.Text = userIni.GetString("Rendering", "ShadowQuality", "")
                        ShadowedLights.Text = userIni.GetString("Rendering", "ShadowedLights", "")
                        UberSampling.Text = userIni.GetString("Rendering", "uberSampling", "")
                        Fullscreen.Text = userIni.GetString("Rendering", "Fullscreen", "")
                        VSync.Text = userIni.GetString("Rendering", "Vsync", "")
                        viewport.Text = userIni.GetString("Viewport", "Width", "") & " x " & userIni.GetString("Viewport", "Height", "")
                        btnacceptChanges.Enabled = True

                    Else
                        MsgBox("Could not Locate the user.ini file !", vbCritical)
                        btnacceptChanges.Enabled = False
                    End If

                    If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCUber.ini") = True Then

                        Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCUber.ini")
                        UberTextureDownscale.Text = userIni.GetString("Rendering", "TextureDownscale", "")
                        uberAtlasTextureDownscale.Text = userIni.GetString("Rendering", "AtlasTextureDownscale", "")
                        uberDetailTextureDownscale.Text = userIni.GetString("Rendering", "DetailTextureDownscale", "")
                        uberMaxTextureSize.Text = userIni.GetString("Rendering", "MaxTextureSize", "")
                        uberMaxAtlasTextureSize.Text = userIni.GetString("Rendering", "MaxAtlasTextureSize", "")
                        uberTextureMemoryBudget.Text = userIni.GetString("Rendering", "TextureMemoryBudget", "")
                        uberTextureTimeBudget.Text = userIni.GetString("Rendering", "TextureTimeBudget", "")
                        uberMaxCubeShadowSize.Text = userIni.GetString("Rendering", "MaxCubeShadowSize", "")
                        uberMaxCubeShadowCount.Text = userIni.GetString("Rendering", "MaxCubeShadowCount", "")
                        uberMaxSpotShadowSize.Text = userIni.GetString("Rendering", "MaxSpotShadowSize", "")
                        uberMaxSpotShadowCount.Text = userIni.GetString("Rendering", "MaxSpotShadowCount", "")
                        uberFoliageDistanceScale.Text = userIni.GetString("Rendering", "FoliageDistanceScale", "")
                        uberMeshDistanceScale.Text = userIni.GetString("Rendering", "MeshDistanceScale", "")
                        uberCharacterLodGameplayDownscale.Text = userIni.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                        uberAllowBloom.Text = userIni.GetString("Rendering", "AllowBloom", "")
                        uberAllowShafts.Text = userIni.GetString("Rendering", "AllowShafts", "")
                        uberAllowAntialias.Text = userIni.GetString("Rendering", "AllowAntialias", "")
                        uberAllowBlur.Text = userIni.GetString("Rendering", "AllowBlur", "")
                        uberAllowDOF.Text = userIni.GetString("Rendering", "AllowDOF", "")
                        uberAllowDecals.Text = userIni.GetString("Rendering", "AllowDecals", "")
                        uberAllowVignette.Text = userIni.GetString("Rendering", "AllowVignette", "")
                        uberAllowSharpen.Text = userIni.GetString("Rendering", "AllowSharpen", "")
                        uberAllowRain.Text = userIni.GetString("Rendering", "AllowRain", "")
                        uberAllowSSAO.Text = userIni.GetString("Rendering", "AllowSSAO", "")
                        uberAllowMotionBlur.Text = userIni.GetString("Rendering", "AllowMotionBlur", "")
                        uberAllowScatterDOF.Text = userIni.GetString("Rendering", "AllowScatterDOF", "")
                        uberAllowCutsceneDOF.Text = userIni.GetString("Rendering", "AllowCutsceneDOF", "")
                        uberDanglesLimiter.Text = userIni.GetString("Rendering", "DanglesLimiter", "")
                        uberShadowQuality.Text = userIni.GetString("Rendering", "ShadowQuality", "")
                        uberShadowedLights.Text = userIni.GetString("Rendering", "ShadowedLights", "")
                        uberUberSampling.Text = userIni.GetString("Rendering", "uberSampling", "")
                        uberFullscreen.Text = userIni.GetString("Rendering", "Fullscreen", "")
                        uberVsync.Text = userIni.GetString("Rendering", "Vsync", "")
                        btnSetUber.Enabled = True

                    Else
                        MsgBox("Could not Locate the PCUber.ini file !", vbCritical)
                        btnSetUber.Enabled = False
                    End If

                    If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCHigh.ini") = True Then

                        Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCHigh.ini")
                        highTextureDownscale.Text = userIni.GetString("Rendering", "TextureDownscale", "")
                        highAtlasTextureDownscale.Text = userIni.GetString("Rendering", "AtlasTextureDownscale", "")
                        highDetailTextureDownscale.Text = userIni.GetString("Rendering", "DetailTextureDownscale", "")
                        highMaxTextureSize.Text = userIni.GetString("Rendering", "MaxTextureSize", "")
                        highMaxAtlasTextureSize.Text = userIni.GetString("Rendering", "MaxAtlasTextureSize", "")
                        highTextureMemoryBudget.Text = userIni.GetString("Rendering", "TextureMemoryBudget", "")
                        highTextureTimeBudget.Text = userIni.GetString("Rendering", "TextureTimeBudget", "")
                        highMaxCubeShadowSize.Text = userIni.GetString("Rendering", "MaxCubeShadowSize", "")
                        highMaxCubeShadowCount.Text = userIni.GetString("Rendering", "MaxCubeShadowCount", "")
                        highMaxSpotShadowSize.Text = userIni.GetString("Rendering", "MaxSpotShadowSize", "")
                        highMaxSpotShadowCount.Text = userIni.GetString("Rendering", "MaxSpotShadowCount", "")
                        highFoliageDistanceScale.Text = userIni.GetString("Rendering", "FoliageDistanceScale", "")
                        highMeshDistanceScale.Text = userIni.GetString("Rendering", "MeshDistanceScale", "")
                        highCharacterLodGameplayDownscale.Text = userIni.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                        highAllowBloom.Text = userIni.GetString("Rendering", "AllowBloom", "")
                        highAllowShafts.Text = userIni.GetString("Rendering", "AllowShafts", "")
                        highAllowAntialias.Text = userIni.GetString("Rendering", "AllowAntialias", "")
                        highAllowBlur.Text = userIni.GetString("Rendering", "AllowBlur", "")
                        highAllowDOF.Text = userIni.GetString("Rendering", "AllowDOF", "")
                        highAllowDecals.Text = userIni.GetString("Rendering", "AllowDecals", "")
                        highAllowVignette.Text = userIni.GetString("Rendering", "AllowVignette", "")
                        highAllowSharpen.Text = userIni.GetString("Rendering", "AllowSharpen", "")
                        highAllowRain.Text = userIni.GetString("Rendering", "AllowRain", "")
                        highAllowSSAO.Text = userIni.GetString("Rendering", "AllowSSAO", "")
                        highAllowMotionBlur.Text = userIni.GetString("Rendering", "AllowMotionBlur", "")
                        highAllowScatterDOF.Text = userIni.GetString("Rendering", "AllowScatterDOF", "")
                        highAllowCutsceneDOF.Text = userIni.GetString("Rendering", "AllowCutsceneDOF", "")
                        highDanglesLimiter.Text = userIni.GetString("Rendering", "DanglesLimiter", "")
                        highShadowQuality.Text = userIni.GetString("Rendering", "ShadowQuality", "")
                        highShadowedLights.Text = userIni.GetString("Rendering", "ShadowedLights", "")
                        highuberSampling.Text = userIni.GetString("Rendering", "uberSampling", "")
                        highFullscreen.Text = userIni.GetString("Rendering", "Fullscreen", "")
                        highVsync.Text = userIni.GetString("Rendering", "Vsync", "")
                        btnSetHigh.Enabled = True

                    Else
                        MsgBox("Could not Locate the PCHigh.ini file !", vbCritical)
                        btnSetHigh.Enabled = False
                    End If

                    If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCMedium.ini") = True Then

                        Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCMedium.ini")
                        mediumTextureDownscale.Text = userIni.GetString("Rendering", "TextureDownscale", "")
                        mediumAtlasTextureDownscale.Text = userIni.GetString("Rendering", "AtlasTextureDownscale", "")
                        mediumDetailTextureDownscale.Text = userIni.GetString("Rendering", "DetailTextureDownscale", "")
                        mediumMaxTextureSize.Text = userIni.GetString("Rendering", "MaxTextureSize", "")
                        mediumMaxAtlasTextureSize.Text = userIni.GetString("Rendering", "MaxAtlasTextureSize", "")
                        mediumTextureMemoryBudget.Text = userIni.GetString("Rendering", "TextureMemoryBudget", "")
                        mediumTextureTimeBudget.Text = userIni.GetString("Rendering", "TextureTimeBudget", "")
                        mediumMaxCubeShadowSize.Text = userIni.GetString("Rendering", "MaxCubeShadowSize", "")
                        mediumMaxCubeShadowCount.Text = userIni.GetString("Rendering", "MaxCubeShadowCount", "")
                        mediumMaxSpotShadowSize.Text = userIni.GetString("Rendering", "MaxSpotShadowSize", "")
                        mediumMaxSpotShadowCount.Text = userIni.GetString("Rendering", "MaxSpotShadowCount", "")
                        mediumFoliageDistanceScale.Text = userIni.GetString("Rendering", "FoliageDistanceScale", "")
                        mediumMeshDistanceScale.Text = userIni.GetString("Rendering", "MeshDistanceScale", "")
                        mediumCharacterLodGameplayDownscale.Text = userIni.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                        mediumAllowBloom.Text = userIni.GetString("Rendering", "AllowBloom", "")
                        mediumAllowShafts.Text = userIni.GetString("Rendering", "AllowShafts", "")
                        mediumAllowAntialias.Text = userIni.GetString("Rendering", "AllowAntialias", "")
                        mediumAllowBlur.Text = userIni.GetString("Rendering", "AllowBlur", "")
                        mediumAllowDOF.Text = userIni.GetString("Rendering", "AllowDOF", "")
                        mediumAllowDecals.Text = userIni.GetString("Rendering", "AllowDecals", "")
                        mediumAllowVignette.Text = userIni.GetString("Rendering", "AllowVignette", "")
                        mediumAllowSharpen.Text = userIni.GetString("Rendering", "AllowSharpen", "")
                        mediumAllowRain.Text = userIni.GetString("Rendering", "AllowRain", "")
                        mediumAllowSSAO.Text = userIni.GetString("Rendering", "AllowSSAO", "")
                        mediumAllowMotionBlur.Text = userIni.GetString("Rendering", "AllowMotionBlur", "")
                        mediumAllowScatterDOF.Text = userIni.GetString("Rendering", "AllowScatterDOF", "")
                        mediumAllowCutsceneDOF.Text = userIni.GetString("Rendering", "AllowCutsceneDOF", "")
                        mediumDanglesLimiter.Text = userIni.GetString("Rendering", "DanglesLimiter", "")
                        mediumShadowQuality.Text = userIni.GetString("Rendering", "ShadowQuality", "")
                        mediumShadowedLights.Text = userIni.GetString("Rendering", "ShadowedLights", "")
                        mediumuberSampling.Text = userIni.GetString("Rendering", "uberSampling", "")
                        mediumFullscreen.Text = userIni.GetString("Rendering", "Fullscreen", "")
                        mediumVsync.Text = userIni.GetString("Rendering", "Vsync", "")
                        btnSetMedium.Enabled = True

                    Else
                        MsgBox("Could not Locate the PCMedium.ini file !", vbCritical)
                        btnSetMedium.Enabled = False
                    End If

                    If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCLow.ini") = True Then

                        Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCLow.ini")
                        lowTextureDownscale.Text = userIni.GetString("Rendering", "TextureDownscale", "")
                        lowAtlasTextureDownscale.Text = userIni.GetString("Rendering", "AtlasTextureDownscale", "")
                        lowDetailTextureDownscale.Text = userIni.GetString("Rendering", "DetailTextureDownscale", "")
                        lowMaxTextureSize.Text = userIni.GetString("Rendering", "MaxTextureSize", "")
                        lowMaxAtlasTextureSize.Text = userIni.GetString("Rendering", "MaxAtlasTextureSize", "")
                        lowTextureMemoryBudget.Text = userIni.GetString("Rendering", "TextureMemoryBudget", "")
                        lowTextureTimeBudget.Text = userIni.GetString("Rendering", "TextureTimeBudget", "")
                        lowMaxCubeShadowSize.Text = userIni.GetString("Rendering", "MaxCubeShadowSize", "")
                        lowMaxCubeShadowCount.Text = userIni.GetString("Rendering", "MaxCubeShadowCount", "")
                        lowMaxSpotShadowSize.Text = userIni.GetString("Rendering", "MaxSpotShadowSize", "")
                        lowMaxSpotShadowCount.Text = userIni.GetString("Rendering", "MaxSpotShadowCount", "")
                        lowFoliageDistanceScale.Text = userIni.GetString("Rendering", "FoliageDistanceScale", "")
                        lowMeshDistanceScale.Text = userIni.GetString("Rendering", "MeshDistanceScale", "")
                        lowCharacterLodGameplayDownscale.Text = userIni.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                        lowAllowBloom.Text = userIni.GetString("Rendering", "AllowBloom", "")
                        lowAllowShafts.Text = userIni.GetString("Rendering", "AllowShafts", "")
                        lowAllowAntialias.Text = userIni.GetString("Rendering", "AllowAntialias", "")
                        lowAllowBlur.Text = userIni.GetString("Rendering", "AllowBlur", "")
                        lowAllowDOF.Text = userIni.GetString("Rendering", "AllowDOF", "")
                        lowAllowDecals.Text = userIni.GetString("Rendering", "AllowDecals", "")
                        lowAllowVignette.Text = userIni.GetString("Rendering", "AllowVignette", "")
                        lowAllowSharpen.Text = userIni.GetString("Rendering", "AllowSharpen", "")
                        lowAllowRain.Text = userIni.GetString("Rendering", "AllowRain", "")
                        lowAllowSSAO.Text = userIni.GetString("Rendering", "AllowSSAO", "")
                        lowAllowMotionBlur.Text = userIni.GetString("Rendering", "AllowMotionBlur", "")
                        lowAllowScatterDOF.Text = userIni.GetString("Rendering", "AllowScatterDOF", "")
                        lowAllowCutsceneDOF.Text = userIni.GetString("Rendering", "AllowCutsceneDOF", "")
                        lowDanglesLimiter.Text = userIni.GetString("Rendering", "DanglesLimiter", "")
                        lowShadowQuality.Text = userIni.GetString("Rendering", "ShadowQuality", "")
                        lowShadowedLights.Text = userIni.GetString("Rendering", "ShadowedLights", "")
                        lowuberSampling.Text = userIni.GetString("Rendering", "uberSampling", "")
                        lowFullscreen.Text = userIni.GetString("Rendering", "Fullscreen", "")
                        lowVsync.Text = userIni.GetString("Rendering", "Vsync", "")
                        btnSetLow.Enabled = True

                    Else
                        MsgBox("Could not Locate the PCLow.ini file !", vbCritical)
                        btnSetLow.Enabled = False
                    End If

                Else
                    Exit Sub
                End If

            Else
                MsgBox("Could not locate The Witcher 2 User Configuration Directory, Program will not load any settings!", vbCritical)
                Me.Text = Me.Text & " v" & My.Application.Info.Version.ToString & "   [Could Not Locate the Witcher 2 User Settings Directory!]"
                btnSetLow.Enabled = False
                btnSetMedium.Enabled = False
                btnSetHigh.Enabled = False
                btnSetUber.Enabled = False
                btnacceptChanges.Enabled = False
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnacceptChanges_Click(sender As System.Object, _
                                       e As System.EventArgs) _
            Handles btnacceptChanges.Click

        Try

            If WitcherTwoUserFolder <> "" Then

                Dim button As New DialogResult
                button = MessageBox.Show("Are you sure you want to Commit all the Changes?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                If button = Windows.Forms.DialogResult.Yes Then

                    If My.Computer.FileSystem.DirectoryExists(addTrailingSlash(WitcherTwoUserFolder) & "Config") = True Then

                        If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\user.ini") = True Then

                            Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\user.ini")
                            userIni.WriteString("Rendering", "TextureDownscale", TextureDownscale.Text)
                            userIni.WriteString("Rendering", "AtlasTextureDownscale", AtlasTextureDownscale.Text)
                            userIni.WriteString("Rendering", "DetailTextureDownscale", DetailTextureDownscale.Text)
                            userIni.WriteString("Rendering", "MaxTextureSize", MaxTextureSize.Text)
                            userIni.WriteString("Rendering", "MaxAtlasTextureSize", MaxAtlasTextureSize.Text)
                            userIni.WriteString("Rendering", "TextureMemoryBudget", TextureMemoryBudget.Text)
                            userIni.WriteString("Rendering", "TextureTimeBudget", TextureTimeBudget.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowSize", MaxCubeShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowCount", MaxCubeShadowCount.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowSize", MaxSpotShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowCount", MaxSpotShadowCount.Text)
                            userIni.WriteString("Rendering", "FoliageDistanceScale", FoliageDistanceScale.Text)
                            userIni.WriteString("Rendering", "MeshDistanceScale", MeshDistanceScale.Text)
                            userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", CharacterLodGameplayDownscale.Text)
                            userIni.WriteString("Rendering", "AllowBloom", AllowBloom.Text)
                            userIni.WriteString("Rendering", "AllowShafts", AllowShafts.Text)
                            userIni.WriteString("Rendering", "AllowAntialias", AllowAntialias.Text)
                            userIni.WriteString("Rendering", "AllowBlur", AllowBlur.Text)
                            userIni.WriteString("Rendering", "AllowDOF", AllowDOF.Text)
                            userIni.WriteString("Rendering", "AllowDecals", AllowDecals.Text)
                            userIni.WriteString("Rendering", "AllowVignette", AllowVignette.Text)
                            userIni.WriteString("Rendering", "AllowSharpen", AllowSharpen.Text)
                            userIni.WriteString("Rendering", "AllowRain", AllowRain.Text)
                            userIni.WriteString("Rendering", "AllowSSAO", AllowSSAO.Text)
                            userIni.WriteString("Rendering", "AllowMotionBlur", AllowMotionBlur.Text)
                            userIni.WriteString("Rendering", "AllowScatterDOF", AllowScatterDOF.Text)
                            userIni.WriteString("Rendering", "AllowCutsceneDOF", AllowCutsceneDOF.Text)
                            userIni.WriteString("Rendering", "DanglesLimiter", DanglesLimiter.Text)
                            userIni.WriteString("Rendering", "ShadowQuality", ShadowQuality.Text)
                            userIni.WriteString("Rendering", "ShadowedLights", ShadowedLights.Text)
                            userIni.WriteString("Rendering", "uberSampling", UberSampling.Text)
                            userIni.WriteString("Rendering", "Fullscreen", Fullscreen.Text)
                            userIni.WriteString("Rendering", "Vsync", VSync.Text)
                            userIni.WriteString("Viewport", "Height", Strings.Right(viewport.Text, viewport.Text.IndexOf(" ")))
                            userIni.WriteString("Viewport", "Width", Strings.Left(viewport.Text, viewport.Text.IndexOf(" ")))

                        Else
                            MsgBox("Could not Locate the user.ini file !", vbCritical)
                        End If

                        If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCUber.ini") = True Then

                            Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCUber.ini")
                            userIni.WriteString("Rendering", "TextureDownscale", UberTextureDownscale.Text)
                            userIni.WriteString("Rendering", "AtlasTextureDownscale", uberAtlasTextureDownscale.Text)
                            userIni.WriteString("Rendering", "DetailTextureDownscale", uberDetailTextureDownscale.Text)
                            userIni.WriteString("Rendering", "MaxTextureSize", uberMaxTextureSize.Text)
                            userIni.WriteString("Rendering", "MaxAtlasTextureSize", uberMaxAtlasTextureSize.Text)
                            userIni.WriteString("Rendering", "TextureMemoryBudget", uberTextureMemoryBudget.Text)
                            userIni.WriteString("Rendering", "TextureTimeBudget", uberTextureTimeBudget.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowSize", uberMaxCubeShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowCount", uberMaxCubeShadowCount.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowSize", uberMaxSpotShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowCount", uberMaxSpotShadowCount.Text)
                            userIni.WriteString("Rendering", "FoliageDistanceScale", uberFoliageDistanceScale.Text)
                            userIni.WriteString("Rendering", "MeshDistanceScale", uberMeshDistanceScale.Text)
                            userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", uberCharacterLodGameplayDownscale.Text)
                            userIni.WriteString("Rendering", "AllowBloom", uberAllowBloom.Text)
                            userIni.WriteString("Rendering", "AllowShafts", uberAllowShafts.Text)
                            userIni.WriteString("Rendering", "AllowAntialias", uberAllowAntialias.Text)
                            userIni.WriteString("Rendering", "AllowBlur", uberAllowBlur.Text)
                            userIni.WriteString("Rendering", "AllowDOF", uberAllowDOF.Text)
                            userIni.WriteString("Rendering", "AllowDecals", uberAllowDecals.Text)
                            userIni.WriteString("Rendering", "AllowVignette", uberAllowVignette.Text)
                            userIni.WriteString("Rendering", "AllowSharpen", uberAllowSharpen.Text)
                            userIni.WriteString("Rendering", "AllowRain", uberAllowRain.Text)
                            userIni.WriteString("Rendering", "AllowSSAO", uberAllowSSAO.Text)
                            userIni.WriteString("Rendering", "AllowMotionBlur", uberAllowMotionBlur.Text)
                            userIni.WriteString("Rendering", "AllowScatterDOF", uberAllowScatterDOF.Text)
                            userIni.WriteString("Rendering", "AllowCutsceneDOF", uberAllowCutsceneDOF.Text)
                            userIni.WriteString("Rendering", "DanglesLimiter", uberDanglesLimiter.Text)
                            userIni.WriteString("Rendering", "ShadowQuality", uberShadowQuality.Text)
                            userIni.WriteString("Rendering", "ShadowedLights", uberShadowedLights.Text)
                            userIni.WriteString("Rendering", "uberSampling", uberUberSampling.Text)
                            userIni.WriteString("Rendering", "Fullscreen", uberFullscreen.Text)
                            userIni.WriteString("Rendering", "Vsync", uberVsync.Text)

                        Else
                            MsgBox("Could not Locate the PCUber.ini file !", vbCritical)
                        End If

                        If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCHigh.ini") = True Then

                            Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCHigh.ini")
                            userIni.WriteString("Rendering", "TextureDownscale", highTextureDownscale.Text)
                            userIni.WriteString("Rendering", "AtlasTextureDownscale", highAtlasTextureDownscale.Text)
                            userIni.WriteString("Rendering", "DetailTextureDownscale", highDetailTextureDownscale.Text)
                            userIni.WriteString("Rendering", "MaxTextureSize", highMaxTextureSize.Text)
                            userIni.WriteString("Rendering", "MaxAtlasTextureSize", highMaxAtlasTextureSize.Text)
                            userIni.WriteString("Rendering", "TextureMemoryBudget", highTextureMemoryBudget.Text)
                            userIni.WriteString("Rendering", "TextureTimeBudget", highTextureTimeBudget.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowSize", highMaxCubeShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowCount", highMaxCubeShadowCount.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowSize", highMaxSpotShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowCount", highMaxSpotShadowCount.Text)
                            userIni.WriteString("Rendering", "FoliageDistanceScale", highFoliageDistanceScale.Text)
                            userIni.WriteString("Rendering", "MeshDistanceScale", highMeshDistanceScale.Text)
                            userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", highCharacterLodGameplayDownscale.Text)
                            userIni.WriteString("Rendering", "AllowBloom", highAllowBloom.Text)
                            userIni.WriteString("Rendering", "AllowShafts", highAllowShafts.Text)
                            userIni.WriteString("Rendering", "AllowAntialias", highAllowAntialias.Text)
                            userIni.WriteString("Rendering", "AllowBlur", highAllowBlur.Text)
                            userIni.WriteString("Rendering", "AllowDOF", highAllowDOF.Text)
                            userIni.WriteString("Rendering", "AllowDecals", highAllowDecals.Text)
                            userIni.WriteString("Rendering", "AllowVignette", highAllowVignette.Text)
                            userIni.WriteString("Rendering", "AllowSharpen", highAllowSharpen.Text)
                            userIni.WriteString("Rendering", "AllowRain", highAllowRain.Text)
                            userIni.WriteString("Rendering", "AllowSSAO", highAllowSSAO.Text)
                            userIni.WriteString("Rendering", "AllowMotionBlur", highAllowMotionBlur.Text)
                            userIni.WriteString("Rendering", "AllowScatterDOF", highAllowScatterDOF.Text)
                            userIni.WriteString("Rendering", "AllowCutsceneDOF", highAllowCutsceneDOF.Text)
                            userIni.WriteString("Rendering", "DanglesLimiter", highDanglesLimiter.Text)
                            userIni.WriteString("Rendering", "ShadowQuality", highShadowQuality.Text)
                            userIni.WriteString("Rendering", "ShadowedLights", highShadowedLights.Text)
                            userIni.WriteString("Rendering", "uberSampling", highuberSampling.Text)
                            userIni.WriteString("Rendering", "Fullscreen", highFullscreen.Text)
                            userIni.WriteString("Rendering", "Vsync", highVsync.Text)

                        Else
                            MsgBox("Could not Locate the PCHigh.ini file !", vbCritical)
                        End If

                        If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCMedium.ini") = True Then

                            Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCMedium.ini")
                            userIni.WriteString("Rendering", "TextureDownscale", mediumTextureDownscale.Text)
                            userIni.WriteString("Rendering", "AtlasTextureDownscale", mediumAtlasTextureDownscale.Text)
                            userIni.WriteString("Rendering", "DetailTextureDownscale", mediumDetailTextureDownscale.Text)
                            userIni.WriteString("Rendering", "MaxTextureSize", mediumMaxTextureSize.Text)
                            userIni.WriteString("Rendering", "MaxAtlasTextureSize", mediumMaxAtlasTextureSize.Text)
                            userIni.WriteString("Rendering", "TextureMemoryBudget", mediumTextureMemoryBudget.Text)
                            userIni.WriteString("Rendering", "TextureTimeBudget", mediumTextureTimeBudget.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowSize", mediumMaxCubeShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowCount", mediumMaxCubeShadowCount.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowSize", mediumMaxSpotShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowCount", mediumMaxSpotShadowCount.Text)
                            userIni.WriteString("Rendering", "FoliageDistanceScale", mediumFoliageDistanceScale.Text)
                            userIni.WriteString("Rendering", "MeshDistanceScale", mediumMeshDistanceScale.Text)
                            userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", mediumCharacterLodGameplayDownscale.Text)
                            userIni.WriteString("Rendering", "AllowBloom", mediumAllowBloom.Text)
                            userIni.WriteString("Rendering", "AllowShafts", mediumAllowShafts.Text)
                            userIni.WriteString("Rendering", "AllowAntialias", mediumAllowAntialias.Text)
                            userIni.WriteString("Rendering", "AllowBlur", mediumAllowBlur.Text)
                            userIni.WriteString("Rendering", "AllowDOF", mediumAllowDOF.Text)
                            userIni.WriteString("Rendering", "AllowDecals", mediumAllowDecals.Text)
                            userIni.WriteString("Rendering", "AllowVignette", mediumAllowVignette.Text)
                            userIni.WriteString("Rendering", "AllowSharpen", mediumAllowSharpen.Text)
                            userIni.WriteString("Rendering", "AllowRain", mediumAllowRain.Text)
                            userIni.WriteString("Rendering", "AllowSSAO", mediumAllowSSAO.Text)
                            userIni.WriteString("Rendering", "AllowMotionBlur", mediumAllowMotionBlur.Text)
                            userIni.WriteString("Rendering", "AllowScatterDOF", mediumAllowScatterDOF.Text)
                            userIni.WriteString("Rendering", "AllowCutsceneDOF", mediumAllowCutsceneDOF.Text)
                            userIni.WriteString("Rendering", "DanglesLimiter", mediumDanglesLimiter.Text)
                            userIni.WriteString("Rendering", "ShadowQuality", mediumShadowQuality.Text)
                            userIni.WriteString("Rendering", "ShadowedLights", mediumShadowedLights.Text)
                            userIni.WriteString("Rendering", "uberSampling", mediumuberSampling.Text)
                            userIni.WriteString("Rendering", "Fullscreen", mediumFullscreen.Text)
                            userIni.WriteString("Rendering", "Vsync", mediumVsync.Text)

                        Else
                            MsgBox("Could not Locate the PCMedium.ini file !", vbCritical)
                        End If

                        If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCLow.ini") = True Then

                            Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\profiles\PCLow.ini")
                            userIni.WriteString("Rendering", "TextureDownscale", lowTextureDownscale.Text)
                            userIni.WriteString("Rendering", "AtlasTextureDownscale", lowAtlasTextureDownscale.Text)
                            userIni.WriteString("Rendering", "DetailTextureDownscale", lowDetailTextureDownscale.Text)
                            userIni.WriteString("Rendering", "MaxTextureSize", lowMaxTextureSize.Text)
                            userIni.WriteString("Rendering", "MaxAtlasTextureSize", lowMaxAtlasTextureSize.Text)
                            userIni.WriteString("Rendering", "TextureMemoryBudget", lowTextureMemoryBudget.Text)
                            userIni.WriteString("Rendering", "TextureTimeBudget", lowTextureTimeBudget.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowSize", lowMaxCubeShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxCubeShadowCount", lowMaxCubeShadowCount.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowSize", lowMaxSpotShadowSize.Text)
                            userIni.WriteString("Rendering", "MaxSpotShadowCount", lowMaxSpotShadowCount.Text)
                            userIni.WriteString("Rendering", "FoliageDistanceScale", lowFoliageDistanceScale.Text)
                            userIni.WriteString("Rendering", "MeshDistanceScale", lowMeshDistanceScale.Text)
                            userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", lowCharacterLodGameplayDownscale.Text)
                            userIni.WriteString("Rendering", "AllowBloom", lowAllowBloom.Text)
                            userIni.WriteString("Rendering", "AllowShafts", lowAllowShafts.Text)
                            userIni.WriteString("Rendering", "AllowAntialias", lowAllowAntialias.Text)
                            userIni.WriteString("Rendering", "AllowBlur", lowAllowBlur.Text)
                            userIni.WriteString("Rendering", "AllowDOF", lowAllowDOF.Text)
                            userIni.WriteString("Rendering", "AllowDecals", lowAllowDecals.Text)
                            userIni.WriteString("Rendering", "AllowVignette", lowAllowVignette.Text)
                            userIni.WriteString("Rendering", "AllowSharpen", lowAllowSharpen.Text)
                            userIni.WriteString("Rendering", "AllowRain", lowAllowRain.Text)
                            userIni.WriteString("Rendering", "AllowSSAO", lowAllowSSAO.Text)
                            userIni.WriteString("Rendering", "AllowMotionBlur", lowAllowMotionBlur.Text)
                            userIni.WriteString("Rendering", "AllowScatterDOF", lowAllowScatterDOF.Text)
                            userIni.WriteString("Rendering", "AllowCutsceneDOF", lowAllowCutsceneDOF.Text)
                            userIni.WriteString("Rendering", "DanglesLimiter", lowDanglesLimiter.Text)
                            userIni.WriteString("Rendering", "ShadowQuality", lowShadowQuality.Text)
                            userIni.WriteString("Rendering", "ShadowedLights", lowShadowedLights.Text)
                            userIni.WriteString("Rendering", "uberSampling", lowuberSampling.Text)
                            userIni.WriteString("Rendering", "Fullscreen", lowFullscreen.Text)
                            userIni.WriteString("Rendering", "Vsync", lowVsync.Text)

                        Else
                            MsgBox("Could not Locate the PCLow.ini file !", vbCritical)
                        End If

                    Else
                        Exit Sub
                    End If

                Else
                    Exit Sub
                End If

            Else
                MsgBox("Could not locate The Witcher 2 User Configuration Directory, Program will not Write any settings!", vbCritical)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As System.Object, _
                               e As System.EventArgs) _
            Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnLoadUser_Click(sender As System.Object, _
                                  e As System.EventArgs) _
            Handles btnLoadUser.Click

        Try

            Dim importinifile As System.Windows.Forms.OpenFileDialog
            importinifile = New System.Windows.Forms.OpenFileDialog()
            importinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            importinifile.Title = "Import Witcher 2 Configuration ini file"

            If importinifile.ShowDialog() = DialogResult.OK Then

                If My.Computer.FileSystem.FileExists(importinifile.FileName) = True Then

                    Dim userIni As New IniFile(importinifile.FileName)
                    TextureDownscale.Text = userIni.GetString("Rendering", "TextureDownscale", "")
                    AtlasTextureDownscale.Text = userIni.GetString("Rendering", "AtlasTextureDownscale", "")
                    DetailTextureDownscale.Text = userIni.GetString("Rendering", "DetailTextureDownscale", "")
                    MaxTextureSize.Text = userIni.GetString("Rendering", "MaxTextureSize", "")
                    MaxAtlasTextureSize.Text = userIni.GetString("Rendering", "MaxAtlasTextureSize", "")
                    TextureMemoryBudget.Text = userIni.GetString("Rendering", "TextureMemoryBudget", "")
                    TextureTimeBudget.Text = userIni.GetString("Rendering", "TextureTimeBudget", "")
                    MaxCubeShadowSize.Text = userIni.GetString("Rendering", "MaxCubeShadowSize", "")
                    MaxCubeShadowCount.Text = userIni.GetString("Rendering", "MaxCubeShadowCount", "")
                    MaxSpotShadowSize.Text = userIni.GetString("Rendering", "MaxSpotShadowSize", "")
                    MaxSpotShadowCount.Text = userIni.GetString("Rendering", "MaxSpotShadowCount", "")
                    FoliageDistanceScale.Text = userIni.GetString("Rendering", "FoliageDistanceScale", "")
                    MeshDistanceScale.Text = userIni.GetString("Rendering", "MeshDistanceScale", "")
                    CharacterLodGameplayDownscale.Text = userIni.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                    AllowBloom.Text = userIni.GetString("Rendering", "AllowBloom", "")
                    AllowShafts.Text = userIni.GetString("Rendering", "AllowShafts", "")
                    AllowAntialias.Text = userIni.GetString("Rendering", "AllowAntialias", "")
                    AllowBlur.Text = userIni.GetString("Rendering", "AllowBlur", "")
                    AllowDOF.Text = userIni.GetString("Rendering", "AllowDOF", "")
                    AllowDecals.Text = userIni.GetString("Rendering", "AllowDecals", "")
                    AllowVignette.Text = userIni.GetString("Rendering", "AllowVignette", "")
                    AllowSharpen.Text = userIni.GetString("Rendering", "AllowSharpen", "")
                    AllowRain.Text = userIni.GetString("Rendering", "AllowRain", "")
                    AllowSSAO.Text = userIni.GetString("Rendering", "AllowSSAO", "")
                    AllowMotionBlur.Text = userIni.GetString("Rendering", "AllowMotionBlur", "")
                    AllowScatterDOF.Text = userIni.GetString("Rendering", "AllowScatterDOF", "")
                    AllowCutsceneDOF.Text = userIni.GetString("Rendering", "AllowCutsceneDOF", "")
                    DanglesLimiter.Text = userIni.GetString("Rendering", "DanglesLimiter", "")
                    ShadowQuality.Text = userIni.GetString("Rendering", "ShadowQuality", "")
                    ShadowedLights.Text = userIni.GetString("Rendering", "ShadowedLights", "")
                    UberSampling.Text = userIni.GetString("Rendering", "uberSampling", "")
                    Fullscreen.Text = userIni.GetString("Rendering", "Fullscreen", "")
                    VSync.Text = userIni.GetString("Rendering", "Vsync", "")

                    If WitcherTwoUserFolder <> "" Then
                        btnacceptChanges.Enabled = True
                    End If

                Else
                    MsgBox("Could not Locate the ini file !", vbCritical)
                End If

            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnLoadUber_Click(sender As System.Object, _
                                  e As System.EventArgs) _
            Handles btnLoadUber.Click

        Try

            Dim importinifile As System.Windows.Forms.OpenFileDialog
            importinifile = New System.Windows.Forms.OpenFileDialog()
            importinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            importinifile.Title = "Import Witcher 2 Configuration ini file"

            If importinifile.ShowDialog() = DialogResult.OK Then

                If My.Computer.FileSystem.FileExists(importinifile.FileName) = True Then

                    Dim uberini As New IniFile(importinifile.FileName)
                    UberTextureDownscale.Text = uberini.GetString("Rendering", "TextureDownscale", "")
                    uberAtlasTextureDownscale.Text = uberini.GetString("Rendering", "AtlasTextureDownscale", "")
                    uberDetailTextureDownscale.Text = uberini.GetString("Rendering", "DetailTextureDownscale", "")
                    uberMaxTextureSize.Text = uberini.GetString("Rendering", "MaxTextureSize", "")
                    uberMaxAtlasTextureSize.Text = uberini.GetString("Rendering", "MaxAtlasTextureSize", "")
                    uberTextureMemoryBudget.Text = uberini.GetString("Rendering", "TextureMemoryBudget", "")
                    uberTextureTimeBudget.Text = uberini.GetString("Rendering", "TextureTimeBudget", "")
                    uberMaxCubeShadowSize.Text = uberini.GetString("Rendering", "MaxCubeShadowSize", "")
                    uberMaxCubeShadowCount.Text = uberini.GetString("Rendering", "MaxCubeShadowCount", "")
                    uberMaxSpotShadowSize.Text = uberini.GetString("Rendering", "MaxSpotShadowSize", "")
                    uberMaxSpotShadowCount.Text = uberini.GetString("Rendering", "MaxSpotShadowCount", "")
                    uberFoliageDistanceScale.Text = uberini.GetString("Rendering", "FoliageDistanceScale", "")
                    uberMeshDistanceScale.Text = uberini.GetString("Rendering", "MeshDistanceScale", "")
                    uberCharacterLodGameplayDownscale.Text = uberini.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                    uberAllowBloom.Text = uberini.GetString("Rendering", "AllowBloom", "")
                    uberAllowShafts.Text = uberini.GetString("Rendering", "AllowShafts", "")
                    uberAllowAntialias.Text = uberini.GetString("Rendering", "AllowAntialias", "")
                    uberAllowBlur.Text = uberini.GetString("Rendering", "AllowBlur", "")
                    uberAllowDOF.Text = uberini.GetString("Rendering", "AllowDOF", "")
                    uberAllowDecals.Text = uberini.GetString("Rendering", "AllowDecals", "")
                    uberAllowVignette.Text = uberini.GetString("Rendering", "AllowVignette", "")
                    uberAllowSharpen.Text = uberini.GetString("Rendering", "AllowSharpen", "")
                    uberAllowRain.Text = uberini.GetString("Rendering", "AllowRain", "")
                    uberAllowSSAO.Text = uberini.GetString("Rendering", "AllowSSAO", "")
                    uberAllowMotionBlur.Text = uberini.GetString("Rendering", "AllowMotionBlur", "")
                    uberAllowScatterDOF.Text = uberini.GetString("Rendering", "AllowScatterDOF", "")
                    uberAllowCutsceneDOF.Text = uberini.GetString("Rendering", "AllowCutsceneDOF", "")
                    uberDanglesLimiter.Text = uberini.GetString("Rendering", "DanglesLimiter", "")
                    uberShadowQuality.Text = uberini.GetString("Rendering", "ShadowQuality", "")
                    uberShadowedLights.Text = uberini.GetString("Rendering", "ShadowedLights", "")
                    uberUberSampling.Text = uberini.GetString("Rendering", "uberSampling", "")
                    uberFullscreen.Text = uberini.GetString("Rendering", "Fullscreen", "")
                    uberVsync.Text = uberini.GetString("Rendering", "Vsync", "")

                    If WitcherTwoUserFolder <> "" Then
                        btnSetUber.Enabled = True
                    End If

                Else
                    MsgBox("Could not Locate the ini file !", vbCritical)
                End If

            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnLoadHigh_Click(sender As System.Object, _
                                  e As System.EventArgs) _
            Handles btnLoadHigh.Click

        Try

            Dim importinifile As System.Windows.Forms.OpenFileDialog
            importinifile = New System.Windows.Forms.OpenFileDialog()
            importinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            importinifile.Title = "Import Witcher 2 Configuration ini file"

            If importinifile.ShowDialog() = DialogResult.OK Then

                If My.Computer.FileSystem.FileExists(importinifile.FileName) = True Then

                    Dim highini As New IniFile(importinifile.FileName)
                    highTextureDownscale.Text = highini.GetString("Rendering", "TextureDownscale", "")
                    highAtlasTextureDownscale.Text = highini.GetString("Rendering", "AtlasTextureDownscale", "")
                    highDetailTextureDownscale.Text = highini.GetString("Rendering", "DetailTextureDownscale", "")
                    highMaxTextureSize.Text = highini.GetString("Rendering", "MaxTextureSize", "")
                    highMaxAtlasTextureSize.Text = highini.GetString("Rendering", "MaxAtlasTextureSize", "")
                    highTextureMemoryBudget.Text = highini.GetString("Rendering", "TextureMemoryBudget", "")
                    highTextureTimeBudget.Text = highini.GetString("Rendering", "TextureTimeBudget", "")
                    highMaxCubeShadowSize.Text = highini.GetString("Rendering", "MaxCubeShadowSize", "")
                    highMaxCubeShadowCount.Text = highini.GetString("Rendering", "MaxCubeShadowCount", "")
                    highMaxSpotShadowSize.Text = highini.GetString("Rendering", "MaxSpotShadowSize", "")
                    highMaxSpotShadowCount.Text = highini.GetString("Rendering", "MaxSpotShadowCount", "")
                    highFoliageDistanceScale.Text = highini.GetString("Rendering", "FoliageDistanceScale", "")
                    highMeshDistanceScale.Text = highini.GetString("Rendering", "MeshDistanceScale", "")
                    highCharacterLodGameplayDownscale.Text = highini.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                    highAllowBloom.Text = highini.GetString("Rendering", "AllowBloom", "")
                    highAllowShafts.Text = highini.GetString("Rendering", "AllowShafts", "")
                    highAllowAntialias.Text = highini.GetString("Rendering", "AllowAntialias", "")
                    highAllowBlur.Text = highini.GetString("Rendering", "AllowBlur", "")
                    highAllowDOF.Text = highini.GetString("Rendering", "AllowDOF", "")
                    highAllowDecals.Text = highini.GetString("Rendering", "AllowDecals", "")
                    highAllowVignette.Text = highini.GetString("Rendering", "AllowVignette", "")
                    highAllowSharpen.Text = highini.GetString("Rendering", "AllowSharpen", "")
                    highAllowRain.Text = highini.GetString("Rendering", "AllowRain", "")
                    highAllowSSAO.Text = highini.GetString("Rendering", "AllowSSAO", "")
                    highAllowMotionBlur.Text = highini.GetString("Rendering", "AllowMotionBlur", "")
                    highAllowScatterDOF.Text = highini.GetString("Rendering", "AllowScatterDOF", "")
                    highAllowCutsceneDOF.Text = highini.GetString("Rendering", "AllowCutsceneDOF", "")
                    highDanglesLimiter.Text = highini.GetString("Rendering", "DanglesLimiter", "")
                    highShadowQuality.Text = highini.GetString("Rendering", "ShadowQuality", "")
                    highShadowedLights.Text = highini.GetString("Rendering", "ShadowedLights", "")
                    highuberSampling.Text = highini.GetString("Rendering", "uberSampling", "")
                    highFullscreen.Text = highini.GetString("Rendering", "Fullscreen", "")
                    highVsync.Text = highini.GetString("Rendering", "Vsync", "")

                    If WitcherTwoUserFolder <> "" Then
                        btnSetHigh.Enabled = True
                    End If

                Else
                    MsgBox("Could not Locate the ini file !", vbCritical)
                End If

            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnLoadmedium_Click(sender As System.Object, _
                                    e As System.EventArgs) _
            Handles btnLoadMedium.Click, btnLoadHigh.Click

        Try

            Dim importinifile As System.Windows.Forms.OpenFileDialog
            importinifile = New System.Windows.Forms.OpenFileDialog()
            importinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            importinifile.Title = "Import Witcher 2 Configuration ini file"

            If importinifile.ShowDialog() = DialogResult.OK Then

                If My.Computer.FileSystem.FileExists(importinifile.FileName) = True Then

                    Dim mediumini As New IniFile(importinifile.FileName)
                    mediumTextureDownscale.Text = mediumini.GetString("Rendering", "TextureDownscale", "")
                    mediumAtlasTextureDownscale.Text = mediumini.GetString("Rendering", "AtlasTextureDownscale", "")
                    mediumDetailTextureDownscale.Text = mediumini.GetString("Rendering", "DetailTextureDownscale", "")
                    mediumMaxTextureSize.Text = mediumini.GetString("Rendering", "MaxTextureSize", "")
                    mediumMaxAtlasTextureSize.Text = mediumini.GetString("Rendering", "MaxAtlasTextureSize", "")
                    mediumTextureMemoryBudget.Text = mediumini.GetString("Rendering", "TextureMemoryBudget", "")
                    mediumTextureTimeBudget.Text = mediumini.GetString("Rendering", "TextureTimeBudget", "")
                    mediumMaxCubeShadowSize.Text = mediumini.GetString("Rendering", "MaxCubeShadowSize", "")
                    mediumMaxCubeShadowCount.Text = mediumini.GetString("Rendering", "MaxCubeShadowCount", "")
                    mediumMaxSpotShadowSize.Text = mediumini.GetString("Rendering", "MaxSpotShadowSize", "")
                    mediumMaxSpotShadowCount.Text = mediumini.GetString("Rendering", "MaxSpotShadowCount", "")
                    mediumFoliageDistanceScale.Text = mediumini.GetString("Rendering", "FoliageDistanceScale", "")
                    mediumMeshDistanceScale.Text = mediumini.GetString("Rendering", "MeshDistanceScale", "")
                    mediumCharacterLodGameplayDownscale.Text = mediumini.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                    mediumAllowBloom.Text = mediumini.GetString("Rendering", "AllowBloom", "")
                    mediumAllowShafts.Text = mediumini.GetString("Rendering", "AllowShafts", "")
                    mediumAllowAntialias.Text = mediumini.GetString("Rendering", "AllowAntialias", "")
                    mediumAllowBlur.Text = mediumini.GetString("Rendering", "AllowBlur", "")
                    mediumAllowDOF.Text = mediumini.GetString("Rendering", "AllowDOF", "")
                    mediumAllowDecals.Text = mediumini.GetString("Rendering", "AllowDecals", "")
                    mediumAllowVignette.Text = mediumini.GetString("Rendering", "AllowVignette", "")
                    mediumAllowSharpen.Text = mediumini.GetString("Rendering", "AllowSharpen", "")
                    mediumAllowRain.Text = mediumini.GetString("Rendering", "AllowRain", "")
                    mediumAllowSSAO.Text = mediumini.GetString("Rendering", "AllowSSAO", "")
                    mediumAllowMotionBlur.Text = mediumini.GetString("Rendering", "AllowMotionBlur", "")
                    mediumAllowScatterDOF.Text = mediumini.GetString("Rendering", "AllowScatterDOF", "")
                    mediumAllowCutsceneDOF.Text = mediumini.GetString("Rendering", "AllowCutsceneDOF", "")
                    mediumDanglesLimiter.Text = mediumini.GetString("Rendering", "DanglesLimiter", "")
                    mediumShadowQuality.Text = mediumini.GetString("Rendering", "ShadowQuality", "")
                    mediumShadowedLights.Text = mediumini.GetString("Rendering", "ShadowedLights", "")
                    mediumuberSampling.Text = mediumini.GetString("Rendering", "uberSampling", "")
                    mediumFullscreen.Text = mediumini.GetString("Rendering", "Fullscreen", "")
                    mediumVsync.Text = mediumini.GetString("Rendering", "Vsync", "")

                    If WitcherTwoUserFolder <> "" Then
                        btnSetMedium.Enabled = True
                    End If

                Else
                    MsgBox("Could not Locate the ini file !", vbCritical)
                End If

            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnLoadlow_Click(sender As System.Object, _
                                 e As System.EventArgs) _
            Handles btnLoadlow.Click

        Try

            Dim importinifile As System.Windows.Forms.OpenFileDialog
            importinifile = New System.Windows.Forms.OpenFileDialog()
            importinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            importinifile.Title = "Import Witcher 2 Configuration ini file"

            If importinifile.ShowDialog() = DialogResult.OK Then

                If My.Computer.FileSystem.FileExists(importinifile.FileName) = True Then

                    Dim lowini As New IniFile(importinifile.FileName)
                    lowTextureDownscale.Text = lowini.GetString("Rendering", "TextureDownscale", "")
                    lowAtlasTextureDownscale.Text = lowini.GetString("Rendering", "AtlasTextureDownscale", "")
                    lowDetailTextureDownscale.Text = lowini.GetString("Rendering", "DetailTextureDownscale", "")
                    lowMaxTextureSize.Text = lowini.GetString("Rendering", "MaxTextureSize", "")
                    lowMaxAtlasTextureSize.Text = lowini.GetString("Rendering", "MaxAtlasTextureSize", "")
                    lowTextureMemoryBudget.Text = lowini.GetString("Rendering", "TextureMemoryBudget", "")
                    lowTextureTimeBudget.Text = lowini.GetString("Rendering", "TextureTimeBudget", "")
                    lowMaxCubeShadowSize.Text = lowini.GetString("Rendering", "MaxCubeShadowSize", "")
                    lowMaxCubeShadowCount.Text = lowini.GetString("Rendering", "MaxCubeShadowCount", "")
                    lowMaxSpotShadowSize.Text = lowini.GetString("Rendering", "MaxSpotShadowSize", "")
                    lowMaxSpotShadowCount.Text = lowini.GetString("Rendering", "MaxSpotShadowCount", "")
                    lowFoliageDistanceScale.Text = lowini.GetString("Rendering", "FoliageDistanceScale", "")
                    lowMeshDistanceScale.Text = lowini.GetString("Rendering", "MeshDistanceScale", "")
                    lowCharacterLodGameplayDownscale.Text = lowini.GetString("Rendering", "CharacterLodGameplayDownscale", "")
                    lowAllowBloom.Text = lowini.GetString("Rendering", "AllowBloom", "")
                    lowAllowShafts.Text = lowini.GetString("Rendering", "AllowShafts", "")
                    lowAllowAntialias.Text = lowini.GetString("Rendering", "AllowAntialias", "")
                    lowAllowBlur.Text = lowini.GetString("Rendering", "AllowBlur", "")
                    lowAllowDOF.Text = lowini.GetString("Rendering", "AllowDOF", "")
                    lowAllowDecals.Text = lowini.GetString("Rendering", "AllowDecals", "")
                    lowAllowVignette.Text = lowini.GetString("Rendering", "AllowVignette", "")
                    lowAllowSharpen.Text = lowini.GetString("Rendering", "AllowSharpen", "")
                    lowAllowRain.Text = lowini.GetString("Rendering", "AllowRain", "")
                    lowAllowSSAO.Text = lowini.GetString("Rendering", "AllowSSAO", "")
                    lowAllowMotionBlur.Text = lowini.GetString("Rendering", "AllowMotionBlur", "")
                    lowAllowScatterDOF.Text = lowini.GetString("Rendering", "AllowScatterDOF", "")
                    lowAllowCutsceneDOF.Text = lowini.GetString("Rendering", "AllowCutsceneDOF", "")
                    lowDanglesLimiter.Text = lowini.GetString("Rendering", "DanglesLimiter", "")
                    lowShadowQuality.Text = lowini.GetString("Rendering", "ShadowQuality", "")
                    lowShadowedLights.Text = lowini.GetString("Rendering", "ShadowedLights", "")
                    lowuberSampling.Text = lowini.GetString("Rendering", "uberSampling", "")
                    lowFullscreen.Text = lowini.GetString("Rendering", "Fullscreen", "")
                    lowVsync.Text = lowini.GetString("Rendering", "Vsync", "")

                    If WitcherTwoUserFolder <> "" Then
                        btnSetLow.Enabled = True
                    End If

                Else
                    MsgBox("Could not Locate the ini file !", vbCritical)
                End If

            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnExportUser_Click(sender As System.Object, _
                                    e As System.EventArgs) _
            Handles btnExportUser.Click

        Try

            Dim exportinifile As System.Windows.Forms.SaveFileDialog
            exportinifile = New System.Windows.Forms.SaveFileDialog()
            exportinifile.CreatePrompt = False
            exportinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            exportinifile.Title = "Export Witcher 2 Tweaker Configuration ini file"

            If exportinifile.ShowDialog() = DialogResult.OK Then

                Dim userIni As New IniFile(exportinifile.FileName)
                userIni.WriteString("Rendering", "TextureDownscale", TextureDownscale.Text)
                userIni.WriteString("Rendering", "AtlasTextureDownscale", AtlasTextureDownscale.Text)
                userIni.WriteString("Rendering", "DetailTextureDownscale", DetailTextureDownscale.Text)
                userIni.WriteString("Rendering", "MaxTextureSize", MaxTextureSize.Text)
                userIni.WriteString("Rendering", "MaxAtlasTextureSize", MaxAtlasTextureSize.Text)
                userIni.WriteString("Rendering", "TextureMemoryBudget", TextureMemoryBudget.Text)
                userIni.WriteString("Rendering", "TextureTimeBudget", TextureTimeBudget.Text)
                userIni.WriteString("Rendering", "MaxCubeShadowSize", MaxCubeShadowSize.Text)
                userIni.WriteString("Rendering", "MaxCubeShadowCount", MaxCubeShadowCount.Text)
                userIni.WriteString("Rendering", "MaxSpotShadowSize", MaxSpotShadowSize.Text)
                userIni.WriteString("Rendering", "MaxSpotShadowCount", MaxSpotShadowCount.Text)
                userIni.WriteString("Rendering", "FoliageDistanceScale", FoliageDistanceScale.Text)
                userIni.WriteString("Rendering", "MeshDistanceScale", MeshDistanceScale.Text)
                userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", CharacterLodGameplayDownscale.Text)
                userIni.WriteString("Rendering", "AllowBloom", AllowBloom.Text)
                userIni.WriteString("Rendering", "AllowShafts", AllowShafts.Text)
                userIni.WriteString("Rendering", "AllowAntialias", AllowAntialias.Text)
                userIni.WriteString("Rendering", "AllowBlur", AllowBlur.Text)
                userIni.WriteString("Rendering", "AllowDOF", AllowDOF.Text)
                userIni.WriteString("Rendering", "AllowDecals", AllowDecals.Text)
                userIni.WriteString("Rendering", "AllowVignette", AllowVignette.Text)
                userIni.WriteString("Rendering", "AllowSharpen", AllowSharpen.Text)
                userIni.WriteString("Rendering", "AllowRain", AllowRain.Text)
                userIni.WriteString("Rendering", "AllowSSAO", AllowSSAO.Text)
                userIni.WriteString("Rendering", "AllowMotionBlur", AllowMotionBlur.Text)
                userIni.WriteString("Rendering", "AllowScatterDOF", AllowScatterDOF.Text)
                userIni.WriteString("Rendering", "AllowCutsceneDOF", AllowCutsceneDOF.Text)
                userIni.WriteString("Rendering", "DanglesLimiter", DanglesLimiter.Text)
                userIni.WriteString("Rendering", "ShadowQuality", ShadowQuality.Text)
                userIni.WriteString("Rendering", "ShadowedLights", ShadowedLights.Text)
                userIni.WriteString("Rendering", "uberSampling", UberSampling.Text)
                userIni.WriteString("Rendering", "Fullscreen", Fullscreen.Text)
                userIni.WriteString("Rendering", "Vsync", VSync.Text)
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnExportUber_Click(sender As System.Object, _
                                    e As System.EventArgs) _
            Handles btnExportUber.Click

        Try

            Dim exportinifile As System.Windows.Forms.SaveFileDialog
            exportinifile = New System.Windows.Forms.SaveFileDialog()
            exportinifile.CreatePrompt = False
            exportinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            exportinifile.Title = "Export Witcher 2 Tweaker Configuration ini file"

            If exportinifile.ShowDialog() = DialogResult.OK Then

                Dim uberini As New IniFile(exportinifile.FileName)
                uberini.WriteString("Rendering", "TextureDownscale", UberTextureDownscale.Text)
                uberini.WriteString("Rendering", "AtlasTextureDownscale", uberAtlasTextureDownscale.Text)
                uberini.WriteString("Rendering", "DetailTextureDownscale", uberDetailTextureDownscale.Text)
                uberini.WriteString("Rendering", "MaxTextureSize", uberMaxTextureSize.Text)
                uberini.WriteString("Rendering", "MaxAtlasTextureSize", uberMaxAtlasTextureSize.Text)
                uberini.WriteString("Rendering", "TextureMemoryBudget", uberTextureMemoryBudget.Text)
                uberini.WriteString("Rendering", "TextureTimeBudget", uberTextureTimeBudget.Text)
                uberini.WriteString("Rendering", "MaxCubeShadowSize", uberMaxCubeShadowSize.Text)
                uberini.WriteString("Rendering", "MaxCubeShadowCount", uberMaxCubeShadowCount.Text)
                uberini.WriteString("Rendering", "MaxSpotShadowSize", uberMaxSpotShadowSize.Text)
                uberini.WriteString("Rendering", "MaxSpotShadowCount", uberMaxSpotShadowCount.Text)
                uberini.WriteString("Rendering", "FoliageDistanceScale", uberFoliageDistanceScale.Text)
                uberini.WriteString("Rendering", "MeshDistanceScale", uberMeshDistanceScale.Text)
                uberini.WriteString("Rendering", "CharacterLodGameplayDownscale", uberCharacterLodGameplayDownscale.Text)
                uberini.WriteString("Rendering", "AllowBloom", uberAllowBloom.Text)
                uberini.WriteString("Rendering", "AllowShafts", uberAllowShafts.Text)
                uberini.WriteString("Rendering", "AllowAntialias", uberAllowAntialias.Text)
                uberini.WriteString("Rendering", "AllowBlur", uberAllowBlur.Text)
                uberini.WriteString("Rendering", "AllowDOF", uberAllowDOF.Text)
                uberini.WriteString("Rendering", "AllowDecals", uberAllowDecals.Text)
                uberini.WriteString("Rendering", "AllowVignette", uberAllowVignette.Text)
                uberini.WriteString("Rendering", "AllowSharpen", uberAllowSharpen.Text)
                uberini.WriteString("Rendering", "AllowRain", uberAllowRain.Text)
                uberini.WriteString("Rendering", "AllowSSAO", uberAllowSSAO.Text)
                uberini.WriteString("Rendering", "AllowMotionBlur", uberAllowMotionBlur.Text)
                uberini.WriteString("Rendering", "AllowScatterDOF", uberAllowScatterDOF.Text)
                uberini.WriteString("Rendering", "AllowCutsceneDOF", uberAllowCutsceneDOF.Text)
                uberini.WriteString("Rendering", "DanglesLimiter", uberDanglesLimiter.Text)
                uberini.WriteString("Rendering", "ShadowQuality", uberShadowQuality.Text)
                uberini.WriteString("Rendering", "ShadowedLights", uberShadowedLights.Text)
                uberini.WriteString("Rendering", "uberSampling", uberUberSampling.Text)
                uberini.WriteString("Rendering", "Fullscreen", uberFullscreen.Text)
                uberini.WriteString("Rendering", "Vsync", uberVsync.Text)
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnExportHigh_Click(sender As System.Object, _
                                    e As System.EventArgs) _
            Handles btnExportHigh.Click

        Try

            Dim exportinifile As System.Windows.Forms.SaveFileDialog
            exportinifile = New System.Windows.Forms.SaveFileDialog()
            exportinifile.CreatePrompt = False
            exportinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            exportinifile.Title = "Export Witcher 2 Tweaker Configuration ini file"

            If exportinifile.ShowDialog() = DialogResult.OK Then

                Dim highini As New IniFile(exportinifile.FileName)
                highini.WriteString("Rendering", "TextureDownscale", highTextureDownscale.Text)
                highini.WriteString("Rendering", "AtlasTextureDownscale", highAtlasTextureDownscale.Text)
                highini.WriteString("Rendering", "DetailTextureDownscale", highDetailTextureDownscale.Text)
                highini.WriteString("Rendering", "MaxTextureSize", highMaxTextureSize.Text)
                highini.WriteString("Rendering", "MaxAtlasTextureSize", highMaxAtlasTextureSize.Text)
                highini.WriteString("Rendering", "TextureMemoryBudget", highTextureMemoryBudget.Text)
                highini.WriteString("Rendering", "TextureTimeBudget", highTextureTimeBudget.Text)
                highini.WriteString("Rendering", "MaxCubeShadowSize", highMaxCubeShadowSize.Text)
                highini.WriteString("Rendering", "MaxCubeShadowCount", highMaxCubeShadowCount.Text)
                highini.WriteString("Rendering", "MaxSpotShadowSize", highMaxSpotShadowSize.Text)
                highini.WriteString("Rendering", "MaxSpotShadowCount", highMaxSpotShadowCount.Text)
                highini.WriteString("Rendering", "FoliageDistanceScale", highFoliageDistanceScale.Text)
                highini.WriteString("Rendering", "MeshDistanceScale", highMeshDistanceScale.Text)
                highini.WriteString("Rendering", "CharacterLodGameplayDownscale", highCharacterLodGameplayDownscale.Text)
                highini.WriteString("Rendering", "AllowBloom", highAllowBloom.Text)
                highini.WriteString("Rendering", "AllowShafts", highAllowShafts.Text)
                highini.WriteString("Rendering", "AllowAntialias", highAllowAntialias.Text)
                highini.WriteString("Rendering", "AllowBlur", highAllowBlur.Text)
                highini.WriteString("Rendering", "AllowDOF", highAllowDOF.Text)
                highini.WriteString("Rendering", "AllowDecals", highAllowDecals.Text)
                highini.WriteString("Rendering", "AllowVignette", highAllowVignette.Text)
                highini.WriteString("Rendering", "AllowSharpen", highAllowSharpen.Text)
                highini.WriteString("Rendering", "AllowRain", highAllowRain.Text)
                highini.WriteString("Rendering", "AllowSSAO", highAllowSSAO.Text)
                highini.WriteString("Rendering", "AllowMotionBlur", highAllowMotionBlur.Text)
                highini.WriteString("Rendering", "AllowScatterDOF", highAllowScatterDOF.Text)
                highini.WriteString("Rendering", "AllowCutsceneDOF", highAllowCutsceneDOF.Text)
                highini.WriteString("Rendering", "DanglesLimiter", highDanglesLimiter.Text)
                highini.WriteString("Rendering", "ShadowQuality", highShadowQuality.Text)
                highini.WriteString("Rendering", "ShadowedLights", highShadowedLights.Text)
                highini.WriteString("Rendering", "uberSampling", highuberSampling.Text)
                highini.WriteString("Rendering", "Fullscreen", highFullscreen.Text)
                highini.WriteString("Rendering", "Vsync", highVsync.Text)
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnExportMedium_Click(sender As System.Object, _
                                      e As System.EventArgs) _
            Handles btnExportMedium.Click

        Try

            Dim exportinifile As System.Windows.Forms.SaveFileDialog
            exportinifile = New System.Windows.Forms.SaveFileDialog()
            exportinifile.CreatePrompt = False
            exportinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            exportinifile.Title = "Export Witcher 2 Tweaker Configuration ini file"

            If exportinifile.ShowDialog() = DialogResult.OK Then

                Dim mediumini As New IniFile(exportinifile.FileName)
                mediumini.WriteString("Rendering", "TextureDownscale", mediumTextureDownscale.Text)
                mediumini.WriteString("Rendering", "AtlasTextureDownscale", mediumAtlasTextureDownscale.Text)
                mediumini.WriteString("Rendering", "DetailTextureDownscale", mediumDetailTextureDownscale.Text)
                mediumini.WriteString("Rendering", "MaxTextureSize", mediumMaxTextureSize.Text)
                mediumini.WriteString("Rendering", "MaxAtlasTextureSize", mediumMaxAtlasTextureSize.Text)
                mediumini.WriteString("Rendering", "TextureMemoryBudget", mediumTextureMemoryBudget.Text)
                mediumini.WriteString("Rendering", "TextureTimeBudget", mediumTextureTimeBudget.Text)
                mediumini.WriteString("Rendering", "MaxCubeShadowSize", mediumMaxCubeShadowSize.Text)
                mediumini.WriteString("Rendering", "MaxCubeShadowCount", mediumMaxCubeShadowCount.Text)
                mediumini.WriteString("Rendering", "MaxSpotShadowSize", mediumMaxSpotShadowSize.Text)
                mediumini.WriteString("Rendering", "MaxSpotShadowCount", mediumMaxSpotShadowCount.Text)
                mediumini.WriteString("Rendering", "FoliageDistanceScale", mediumFoliageDistanceScale.Text)
                mediumini.WriteString("Rendering", "MeshDistanceScale", mediumMeshDistanceScale.Text)
                mediumini.WriteString("Rendering", "CharacterLodGameplayDownscale", mediumCharacterLodGameplayDownscale.Text)
                mediumini.WriteString("Rendering", "AllowBloom", mediumAllowBloom.Text)
                mediumini.WriteString("Rendering", "AllowShafts", mediumAllowShafts.Text)
                mediumini.WriteString("Rendering", "AllowAntialias", mediumAllowAntialias.Text)
                mediumini.WriteString("Rendering", "AllowBlur", mediumAllowBlur.Text)
                mediumini.WriteString("Rendering", "AllowDOF", mediumAllowDOF.Text)
                mediumini.WriteString("Rendering", "AllowDecals", mediumAllowDecals.Text)
                mediumini.WriteString("Rendering", "AllowVignette", mediumAllowVignette.Text)
                mediumini.WriteString("Rendering", "AllowSharpen", mediumAllowSharpen.Text)
                mediumini.WriteString("Rendering", "AllowRain", mediumAllowRain.Text)
                mediumini.WriteString("Rendering", "AllowSSAO", mediumAllowSSAO.Text)
                mediumini.WriteString("Rendering", "AllowMotionBlur", mediumAllowMotionBlur.Text)
                mediumini.WriteString("Rendering", "AllowScatterDOF", mediumAllowScatterDOF.Text)
                mediumini.WriteString("Rendering", "AllowCutsceneDOF", mediumAllowCutsceneDOF.Text)
                mediumini.WriteString("Rendering", "DanglesLimiter", mediumDanglesLimiter.Text)
                mediumini.WriteString("Rendering", "ShadowQuality", mediumShadowQuality.Text)
                mediumini.WriteString("Rendering", "ShadowedLights", mediumShadowedLights.Text)
                mediumini.WriteString("Rendering", "uberSampling", mediumuberSampling.Text)
                mediumini.WriteString("Rendering", "Fullscreen", mediumFullscreen.Text)
                mediumini.WriteString("Rendering", "Vsync", mediumVsync.Text)
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnExportlow_Click(sender As System.Object, _
                                   e As System.EventArgs) _
            Handles btnExportlow.Click

        Try

            Dim exportinifile As System.Windows.Forms.SaveFileDialog
            exportinifile = New System.Windows.Forms.SaveFileDialog()
            exportinifile.CreatePrompt = False
            exportinifile.Filter = "Witcher 2 Configuration ini file(*.ini) |*.ini"
            exportinifile.Title = "Export Witcher 2 Tweaker Configuration ini file"

            If exportinifile.ShowDialog() = DialogResult.OK Then

                Dim lowini As New IniFile(exportinifile.FileName)
                lowini.WriteString("Rendering", "TextureDownscale", lowTextureDownscale.Text)
                lowini.WriteString("Rendering", "AtlasTextureDownscale", lowAtlasTextureDownscale.Text)
                lowini.WriteString("Rendering", "DetailTextureDownscale", lowDetailTextureDownscale.Text)
                lowini.WriteString("Rendering", "MaxTextureSize", lowMaxTextureSize.Text)
                lowini.WriteString("Rendering", "MaxAtlasTextureSize", lowMaxAtlasTextureSize.Text)
                lowini.WriteString("Rendering", "TextureMemoryBudget", lowTextureMemoryBudget.Text)
                lowini.WriteString("Rendering", "TextureTimeBudget", lowTextureTimeBudget.Text)
                lowini.WriteString("Rendering", "MaxCubeShadowSize", lowMaxCubeShadowSize.Text)
                lowini.WriteString("Rendering", "MaxCubeShadowCount", lowMaxCubeShadowCount.Text)
                lowini.WriteString("Rendering", "MaxSpotShadowSize", lowMaxSpotShadowSize.Text)
                lowini.WriteString("Rendering", "MaxSpotShadowCount", lowMaxSpotShadowCount.Text)
                lowini.WriteString("Rendering", "FoliageDistanceScale", lowFoliageDistanceScale.Text)
                lowini.WriteString("Rendering", "MeshDistanceScale", lowMeshDistanceScale.Text)
                lowini.WriteString("Rendering", "CharacterLodGameplayDownscale", lowCharacterLodGameplayDownscale.Text)
                lowini.WriteString("Rendering", "AllowBloom", lowAllowBloom.Text)
                lowini.WriteString("Rendering", "AllowShafts", lowAllowShafts.Text)
                lowini.WriteString("Rendering", "AllowAntialias", lowAllowAntialias.Text)
                lowini.WriteString("Rendering", "AllowBlur", lowAllowBlur.Text)
                lowini.WriteString("Rendering", "AllowDOF", lowAllowDOF.Text)
                lowini.WriteString("Rendering", "AllowDecals", lowAllowDecals.Text)
                lowini.WriteString("Rendering", "AllowVignette", lowAllowVignette.Text)
                lowini.WriteString("Rendering", "AllowSharpen", lowAllowSharpen.Text)
                lowini.WriteString("Rendering", "AllowRain", lowAllowRain.Text)
                lowini.WriteString("Rendering", "AllowSSAO", lowAllowSSAO.Text)
                lowini.WriteString("Rendering", "AllowMotionBlur", lowAllowMotionBlur.Text)
                lowini.WriteString("Rendering", "AllowScatterDOF", lowAllowScatterDOF.Text)
                lowini.WriteString("Rendering", "AllowCutsceneDOF", lowAllowCutsceneDOF.Text)
                lowini.WriteString("Rendering", "DanglesLimiter", lowDanglesLimiter.Text)
                lowini.WriteString("Rendering", "ShadowQuality", lowShadowQuality.Text)
                lowini.WriteString("Rendering", "ShadowedLights", lowShadowedLights.Text)
                lowini.WriteString("Rendering", "uberSampling", lowuberSampling.Text)
                lowini.WriteString("Rendering", "Fullscreen", lowFullscreen.Text)
                lowini.WriteString("Rendering", "Vsync", lowVsync.Text)
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnSetLow_Click(sender As System.Object, _
                                e As System.EventArgs) _
            Handles btnSetLow.Click

        Try

            If WitcherTwoUserFolder <> "" Then

                Dim button As New DialogResult
                button = MessageBox.Show("Pressing Yes will Transfer the settings on PCLow.ini to user.ini, effectively making the low Profile Active, Continue ?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                If button = Windows.Forms.DialogResult.Yes Then

                    If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\User.ini") = True Then

                        Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\User.ini")
                        userIni.WriteString("Rendering", "TextureDownscale", lowTextureDownscale.Text)
                        userIni.WriteString("Rendering", "AtlasTextureDownscale", lowAtlasTextureDownscale.Text)
                        userIni.WriteString("Rendering", "DetailTextureDownscale", lowDetailTextureDownscale.Text)
                        userIni.WriteString("Rendering", "MaxTextureSize", lowMaxTextureSize.Text)
                        userIni.WriteString("Rendering", "MaxAtlasTextureSize", lowMaxAtlasTextureSize.Text)
                        userIni.WriteString("Rendering", "TextureMemoryBudget", lowTextureMemoryBudget.Text)
                        userIni.WriteString("Rendering", "TextureTimeBudget", lowTextureTimeBudget.Text)
                        userIni.WriteString("Rendering", "MaxCubeShadowSize", lowMaxCubeShadowSize.Text)
                        userIni.WriteString("Rendering", "MaxCubeShadowCount", lowMaxCubeShadowCount.Text)
                        userIni.WriteString("Rendering", "MaxSpotShadowSize", lowMaxSpotShadowSize.Text)
                        userIni.WriteString("Rendering", "MaxSpotShadowCount", lowMaxSpotShadowCount.Text)
                        userIni.WriteString("Rendering", "FoliageDistanceScale", lowFoliageDistanceScale.Text)
                        userIni.WriteString("Rendering", "MeshDistanceScale", lowMeshDistanceScale.Text)
                        userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", lowCharacterLodGameplayDownscale.Text)
                        userIni.WriteString("Rendering", "AllowBloom", lowAllowBloom.Text)
                        userIni.WriteString("Rendering", "AllowShafts", lowAllowShafts.Text)
                        userIni.WriteString("Rendering", "AllowAntialias", lowAllowAntialias.Text)
                        userIni.WriteString("Rendering", "AllowBlur", lowAllowBlur.Text)
                        userIni.WriteString("Rendering", "AllowDOF", lowAllowDOF.Text)
                        userIni.WriteString("Rendering", "AllowDecals", lowAllowDecals.Text)
                        userIni.WriteString("Rendering", "AllowVignette", lowAllowVignette.Text)
                        userIni.WriteString("Rendering", "AllowSharpen", lowAllowSharpen.Text)
                        userIni.WriteString("Rendering", "AllowRain", lowAllowRain.Text)
                        userIni.WriteString("Rendering", "AllowSSAO", lowAllowSSAO.Text)
                        userIni.WriteString("Rendering", "AllowMotionBlur", lowAllowMotionBlur.Text)
                        userIni.WriteString("Rendering", "AllowScatterDOF", lowAllowScatterDOF.Text)
                        userIni.WriteString("Rendering", "AllowCutsceneDOF", lowAllowCutsceneDOF.Text)
                        userIni.WriteString("Rendering", "DanglesLimiter", lowDanglesLimiter.Text)
                        userIni.WriteString("Rendering", "ShadowQuality", lowShadowQuality.Text)
                        userIni.WriteString("Rendering", "ShadowedLights", lowShadowedLights.Text)
                        userIni.WriteString("Rendering", "uberSampling", lowuberSampling.Text)
                        userIni.WriteString("Rendering", "Fullscreen", lowFullscreen.Text)
                        userIni.WriteString("Rendering", "Vsync", lowVsync.Text)

                        doReadingStuff()

                    Else
                        MsgBox("Could not Locate the user.ini file !", vbCritical)
                    End If

                End If

            Else
                MsgBox("Could not locate The Witcher 2 User Configuration Directory, Program will not Write any settings!", vbCritical)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnSetMedium_Click(sender As System.Object, _
                                   e As System.EventArgs) _
            Handles btnSetMedium.Click

        Try

            If WitcherTwoUserFolder <> "" Then

                Dim button As New DialogResult
                button = MessageBox.Show("Pressing Yes will Transfer the settings on PCMedium.ini to user.ini, effectively making the Medium Profile Active, Continue ?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                If button = Windows.Forms.DialogResult.Yes Then

                    If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\User.ini") = True Then

                        Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\User.ini")
                        userIni.WriteString("Rendering", "TextureDownscale", mediumTextureDownscale.Text)
                        userIni.WriteString("Rendering", "AtlasTextureDownscale", mediumAtlasTextureDownscale.Text)
                        userIni.WriteString("Rendering", "DetailTextureDownscale", mediumDetailTextureDownscale.Text)
                        userIni.WriteString("Rendering", "MaxTextureSize", mediumMaxTextureSize.Text)
                        userIni.WriteString("Rendering", "MaxAtlasTextureSize", mediumMaxAtlasTextureSize.Text)
                        userIni.WriteString("Rendering", "TextureMemoryBudget", mediumTextureMemoryBudget.Text)
                        userIni.WriteString("Rendering", "TextureTimeBudget", mediumTextureTimeBudget.Text)
                        userIni.WriteString("Rendering", "MaxCubeShadowSize", mediumMaxCubeShadowSize.Text)
                        userIni.WriteString("Rendering", "MaxCubeShadowCount", mediumMaxCubeShadowCount.Text)
                        userIni.WriteString("Rendering", "MaxSpotShadowSize", mediumMaxSpotShadowSize.Text)
                        userIni.WriteString("Rendering", "MaxSpotShadowCount", mediumMaxSpotShadowCount.Text)
                        userIni.WriteString("Rendering", "FoliageDistanceScale", mediumFoliageDistanceScale.Text)
                        userIni.WriteString("Rendering", "MeshDistanceScale", mediumMeshDistanceScale.Text)
                        userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", mediumCharacterLodGameplayDownscale.Text)
                        userIni.WriteString("Rendering", "AllowBloom", mediumAllowBloom.Text)
                        userIni.WriteString("Rendering", "AllowShafts", mediumAllowShafts.Text)
                        userIni.WriteString("Rendering", "AllowAntialias", mediumAllowAntialias.Text)
                        userIni.WriteString("Rendering", "AllowBlur", mediumAllowBlur.Text)
                        userIni.WriteString("Rendering", "AllowDOF", mediumAllowDOF.Text)
                        userIni.WriteString("Rendering", "AllowDecals", mediumAllowDecals.Text)
                        userIni.WriteString("Rendering", "AllowVignette", mediumAllowVignette.Text)
                        userIni.WriteString("Rendering", "AllowSharpen", mediumAllowSharpen.Text)
                        userIni.WriteString("Rendering", "AllowRain", mediumAllowRain.Text)
                        userIni.WriteString("Rendering", "AllowSSAO", mediumAllowSSAO.Text)
                        userIni.WriteString("Rendering", "AllowMotionBlur", mediumAllowMotionBlur.Text)
                        userIni.WriteString("Rendering", "AllowScatterDOF", mediumAllowScatterDOF.Text)
                        userIni.WriteString("Rendering", "AllowCutsceneDOF", mediumAllowCutsceneDOF.Text)
                        userIni.WriteString("Rendering", "DanglesLimiter", mediumDanglesLimiter.Text)
                        userIni.WriteString("Rendering", "ShadowQuality", mediumShadowQuality.Text)
                        userIni.WriteString("Rendering", "ShadowedLights", mediumShadowedLights.Text)
                        userIni.WriteString("Rendering", "uberSampling", mediumuberSampling.Text)
                        userIni.WriteString("Rendering", "Fullscreen", mediumFullscreen.Text)
                        userIni.WriteString("Rendering", "Vsync", mediumVsync.Text)

                        doReadingStuff()

                    Else
                        MsgBox("Could not Locate the user.ini file !", vbCritical)
                    End If

                End If

            Else
                MsgBox("Could not locate The Witcher 2 User Configuration Directory, Program will not Write any settings!", vbCritical)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnSetHigh_Click(sender As System.Object, _
                                 e As System.EventArgs) _
            Handles btnSetHigh.Click

        Try

            If WitcherTwoUserFolder <> "" Then

                Dim button As New DialogResult
                button = MessageBox.Show("Pressing Yes will Transfer the settings on PCHigh.ini to user.ini, effectively making the High Profile Active, Continue ?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                If button = Windows.Forms.DialogResult.Yes Then

                    If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\User.ini") = True Then

                        Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\User.ini")
                        userIni.WriteString("Rendering", "TextureDownscale", highTextureDownscale.Text)
                        userIni.WriteString("Rendering", "AtlasTextureDownscale", highAtlasTextureDownscale.Text)
                        userIni.WriteString("Rendering", "DetailTextureDownscale", highDetailTextureDownscale.Text)
                        userIni.WriteString("Rendering", "MaxTextureSize", highMaxTextureSize.Text)
                        userIni.WriteString("Rendering", "MaxAtlasTextureSize", highMaxAtlasTextureSize.Text)
                        userIni.WriteString("Rendering", "TextureMemoryBudget", highTextureMemoryBudget.Text)
                        userIni.WriteString("Rendering", "TextureTimeBudget", highTextureTimeBudget.Text)
                        userIni.WriteString("Rendering", "MaxCubeShadowSize", highMaxCubeShadowSize.Text)
                        userIni.WriteString("Rendering", "MaxCubeShadowCount", highMaxCubeShadowCount.Text)
                        userIni.WriteString("Rendering", "MaxSpotShadowSize", highMaxSpotShadowSize.Text)
                        userIni.WriteString("Rendering", "MaxSpotShadowCount", highMaxSpotShadowCount.Text)
                        userIni.WriteString("Rendering", "FoliageDistanceScale", highFoliageDistanceScale.Text)
                        userIni.WriteString("Rendering", "MeshDistanceScale", highMeshDistanceScale.Text)
                        userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", highCharacterLodGameplayDownscale.Text)
                        userIni.WriteString("Rendering", "AllowBloom", highAllowBloom.Text)
                        userIni.WriteString("Rendering", "AllowShafts", highAllowShafts.Text)
                        userIni.WriteString("Rendering", "AllowAntialias", highAllowAntialias.Text)
                        userIni.WriteString("Rendering", "AllowBlur", highAllowBlur.Text)
                        userIni.WriteString("Rendering", "AllowDOF", highAllowDOF.Text)
                        userIni.WriteString("Rendering", "AllowDecals", highAllowDecals.Text)
                        userIni.WriteString("Rendering", "AllowVignette", highAllowVignette.Text)
                        userIni.WriteString("Rendering", "AllowSharpen", highAllowSharpen.Text)
                        userIni.WriteString("Rendering", "AllowRain", highAllowRain.Text)
                        userIni.WriteString("Rendering", "AllowSSAO", highAllowSSAO.Text)
                        userIni.WriteString("Rendering", "AllowMotionBlur", highAllowMotionBlur.Text)
                        userIni.WriteString("Rendering", "AllowScatterDOF", highAllowScatterDOF.Text)
                        userIni.WriteString("Rendering", "AllowCutsceneDOF", highAllowCutsceneDOF.Text)
                        userIni.WriteString("Rendering", "DanglesLimiter", highDanglesLimiter.Text)
                        userIni.WriteString("Rendering", "ShadowQuality", highShadowQuality.Text)
                        userIni.WriteString("Rendering", "ShadowedLights", highShadowedLights.Text)
                        userIni.WriteString("Rendering", "uberSampling", highuberSampling.Text)
                        userIni.WriteString("Rendering", "Fullscreen", highFullscreen.Text)
                        userIni.WriteString("Rendering", "Vsync", highVsync.Text)

                        doReadingStuff()

                    Else
                        MsgBox("Could not Locate the user.ini file !", vbCritical)
                    End If

                End If

            Else
                MsgBox("Could not locate The Witcher 2 User Configuration Directory, Program will not Write any settings!", vbCritical)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnSetUber_Click(sender As System.Object, _
                                 e As System.EventArgs) _
            Handles btnSetUber.Click

        Try

            If WitcherTwoUserFolder <> "" Then

                Dim button As New DialogResult
                button = MessageBox.Show("Pressing Yes will Transfer the settings on PCUber.ini to user.ini, effectively making the Ultra Profile Active, Continue ?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                If button = Windows.Forms.DialogResult.Yes Then

                    If My.Computer.FileSystem.FileExists(addTrailingSlash(WitcherTwoUserFolder) & "Config\User.ini") = True Then

                        Dim userIni As New IniFile(addTrailingSlash(WitcherTwoUserFolder) & "Config\User.ini")
                        userIni.WriteString("Rendering", "TextureDownscale", UberTextureDownscale.Text)
                        userIni.WriteString("Rendering", "AtlasTextureDownscale", uberAtlasTextureDownscale.Text)
                        userIni.WriteString("Rendering", "DetailTextureDownscale", uberDetailTextureDownscale.Text)
                        userIni.WriteString("Rendering", "MaxTextureSize", uberMaxTextureSize.Text)
                        userIni.WriteString("Rendering", "MaxAtlasTextureSize", uberMaxAtlasTextureSize.Text)
                        userIni.WriteString("Rendering", "TextureMemoryBudget", uberTextureMemoryBudget.Text)
                        userIni.WriteString("Rendering", "TextureTimeBudget", uberTextureTimeBudget.Text)
                        userIni.WriteString("Rendering", "MaxCubeShadowSize", uberMaxCubeShadowSize.Text)
                        userIni.WriteString("Rendering", "MaxCubeShadowCount", uberMaxCubeShadowCount.Text)
                        userIni.WriteString("Rendering", "MaxSpotShadowSize", uberMaxSpotShadowSize.Text)
                        userIni.WriteString("Rendering", "MaxSpotShadowCount", uberMaxSpotShadowCount.Text)
                        userIni.WriteString("Rendering", "FoliageDistanceScale", uberFoliageDistanceScale.Text)
                        userIni.WriteString("Rendering", "MeshDistanceScale", uberMeshDistanceScale.Text)
                        userIni.WriteString("Rendering", "CharacterLodGameplayDownscale", uberCharacterLodGameplayDownscale.Text)
                        userIni.WriteString("Rendering", "AllowBloom", uberAllowBloom.Text)
                        userIni.WriteString("Rendering", "AllowShafts", uberAllowShafts.Text)
                        userIni.WriteString("Rendering", "AllowAntialias", uberAllowAntialias.Text)
                        userIni.WriteString("Rendering", "AllowBlur", uberAllowBlur.Text)
                        userIni.WriteString("Rendering", "AllowDOF", uberAllowDOF.Text)
                        userIni.WriteString("Rendering", "AllowDecals", uberAllowDecals.Text)
                        userIni.WriteString("Rendering", "AllowVignette", uberAllowVignette.Text)
                        userIni.WriteString("Rendering", "AllowSharpen", uberAllowSharpen.Text)
                        userIni.WriteString("Rendering", "AllowRain", uberAllowRain.Text)
                        userIni.WriteString("Rendering", "AllowSSAO", uberAllowSSAO.Text)
                        userIni.WriteString("Rendering", "AllowMotionBlur", uberAllowMotionBlur.Text)
                        userIni.WriteString("Rendering", "AllowScatterDOF", uberAllowScatterDOF.Text)
                        userIni.WriteString("Rendering", "AllowCutsceneDOF", uberAllowCutsceneDOF.Text)
                        userIni.WriteString("Rendering", "DanglesLimiter", uberDanglesLimiter.Text)
                        userIni.WriteString("Rendering", "ShadowQuality", uberShadowQuality.Text)
                        userIni.WriteString("Rendering", "ShadowedLights", uberShadowedLights.Text)
                        userIni.WriteString("Rendering", "uberSampling", uberUberSampling.Text)
                        userIni.WriteString("Rendering", "Fullscreen", uberFullscreen.Text)
                        userIni.WriteString("Rendering", "Vsync", uberVsync.Text)

                        doReadingStuff()

                    Else
                        MsgBox("Could not Locate the user.ini file !", vbCritical)
                    End If

                End If

            Else
                MsgBox("Could not locate The Witcher 2 User Configuration Directory, Program will not Write any settings!", vbCritical)
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub btnReload_Click(sender As System.Object, _
                                e As System.EventArgs) _
            Handles btnReload.Click

        If WitcherTwoUserFolder <> "" Then

            Dim button As New DialogResult
            button = MessageBox.Show("Pressing Yes will Reload all the settings, You will loose any unsaved Changes! Continue ?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If button = Windows.Forms.DialogResult.Yes Then

                doReadingStuff()
            End If

        Else
            GetWitcherUserFolder()
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try

            If My.Settings.validated = False Then
                Dim WitcherTwoSettings As New FolderBrowserDialog
                With WitcherTwoSettings


                    .RootFolder = Environment.SpecialFolder.Desktop
                    .Description = "Please Select the Witcher 2 Installation Directory, This is only a one time process, The Witcher II Tweaker Will Remember This Setting"

                    If .ShowDialog = DialogResult.OK Then



                        If My.Computer.FileSystem.FileExists(addTrailingSlash(.SelectedPath) & "bin\witcher2.exe") = True Then
                            My.Settings.validated = True
                            My.Settings.programFolder = addTrailingSlash(.SelectedPath)
                            System.Diagnostics.Process.Start(My.Settings.programFolder & "bin\witcher2.exe")
                        Else
                            MsgBox(Prompt:="Selected folder Doesn't Appear to be the Witcher 2 Installation Directory, Please select the correct Location!", Buttons:=vbInformation)
                            My.Settings.validated = False
                            Exit Sub
                        End If
                    End If
                End With
            Else
                System.Diagnostics.Process.Start(My.Settings.programFolder & "bin\witcher2.exe")
            End If
        Catch ex As Exception
            MsgBox("Something Went Wrong : " & ex.Message, vbCritical)
        End Try
    End Sub
End Class
