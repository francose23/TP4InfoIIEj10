Public Class Form1
    Dim Matriz(7, 7), Vector(7), Matriz2(3, 4), NroAzar, May As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For c = 1 To 7
            dgSalida.Columns.Add("", "")
            dgSalida.Columns(c - 1).Width = 40
        Next
        dgSalida.Rows.Add(7)
        For c = 1 To 4
            dgSalida2.Columns.Add("", "")
            dgSalida2.Columns(c - 1).Width = 40
        Next
        dgSalida2.Rows.Add(3)
        dgVector.Columns.Add("", "")
        dgVector.Columns(0).Width = 40
        dgVector.Rows.Add(7)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For f = 1 To 7
            For c = 1 To 7
                NroAzar = Int(Rnd() * 100)
                Matriz(f, c) = NroAzar
            Next
        Next
        For f = 1 To 7
            For c = 1 To 7
                dgSalida.Item(c - 1, f - 1).Value = Matriz(f, c)
            Next
        Next
        For f = 1 To 4
            Vector(f) = Matriz(f, f + 3)
        Next
        For f = 5 To 7
            Vector(f) = Matriz(f, f - 4)
        Next
        For f = 1 To 7
            dgVector.Item(0, f - 1).Value = Vector(f)
        Next
        For f = 1 To 3
            For c = 1 To 4
                Matriz2(f, c) = Matriz(f + 2, c + f)
            Next
        Next
        For f = 1 To 3
            For c = 1 To 4
                dgSalida2.Item(c - 1, f - 1).Value = Matriz2(f, c)
            Next
        Next
        May = Matriz(7, 1)
        For c = 1 To 7
            If Matriz(8 - c, c) > May Then
                May = Matriz(8 - c, c)
            End If
        Next
        txtSalida.Text = "c) El Mayor de la contradiagonal principal es: " & May & "."

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
