Public Class Launcher
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    '                                                    
    Private Sub Launcher_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top

    End Sub

    Private Sub Launcher_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Launcher_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub
    '                                                   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close() ' 
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '                                   CONFIG
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Shell("Explorer.exe fivem://connect/lininja.myddns.me") 'SERVER IP
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("Explorer.exe https://discord.gg/7P8rUufKzF") 'DISCORD SERVER
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Shell("Explorer.exe https://sites.google.com/view/bear-city-rp")
    End Sub


    Private Sub Creditos(sender As Object, e As EventArgs) Handles Button4.Click
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Shell("Explorer.exe fivem://connect/lininja.myddns.me") 'SERVER IP
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Shell("Explorer.exe fivem://connect/lininja.myddns.me") 'SERVER IP
        Me.Close()

    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Shell("Explorer.exe https://sites.google.com/view/bear-city-rp")
        Me.Close()
    End Sub
End Class
