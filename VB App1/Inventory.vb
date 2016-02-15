Public Class Inventory
    Private guitars As List(Of Guitar)

    Public Sub New()
        Me.guitars = New List(Of Guitar)()
    End Sub

    Public Sub addGuitar(serialNumber As String, price As Double, builder As String, model As String, type As String, backWood As String, topWood As String)
        Dim guitar As Guitar = New Guitar(serialNumber, price, builder, model, type, backWood, topWood)
        Me.guitars.Add(guitar)
    End Sub

    Public Function getGuitar(serialNumber As String) As Guitar
        For i As Integer = 0 To Me.guitars.Count - 1
            Dim guitar As Guitar = Me.guitars(i)

            If guitar.getSerialNumber().Equals(serialNumber) Then
                Return guitar
            End If
        Next

        Return Nothing
    End Function

    Public Function search(searchGuitar As Guitar) As Guitar
        For i As Integer = 0 To Me.guitars.Count - 1
            Dim guitar As Guitar = Me.guitars(i)

            Dim builder As String = searchGuitar.getBuilder()
            If builder <> Nothing AndAlso Not builder.Equals("") AndAlso Not builder.Equals(guitar.getBuilder()) Then
                Continue For
            End If

            ' TODO : compare each property of the guitar

            Return guitar
        Next

        Return Nothing
    End Function
End Class
