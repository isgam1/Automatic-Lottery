Public Class frmLoad
    Private Sub frmLoad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timeLoad.Start()
    End Sub

    Private Sub timeLoad_Tick(sender As Object, e As EventArgs) Handles timeLoad.Tick

        pbarLoad.Increment(5)

        If pbarLoad.Value = 100 Then
            timeLoad.Stop()
        End If

    End Sub
End Class