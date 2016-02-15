Imports VB_App1

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnFindGuitar.Click
        Dim inventory As Inventory = New Inventory()

        initialInventory(inventory)

        Dim myGuitarLikes As Guitar = New Guitar(Nothing, 0.0, "gibson", Nothing, Nothing, Nothing, Nothing)

        Dim guitar As Guitar = inventory.search(myGuitarLikes)

        If (guitar IsNot Nothing) Then
            displayGuitarInfo(guitar)
        Else
            displaySorryMessage(myGuitarLikes)
        End If
    End Sub

    Private Sub initialInventory(inventory As Inventory)
        inventory.addGuitar("1", 1999.95, "Finder", "F1000", "Acoustic", "Indian Rosewood", "Indian Rosewood")
        inventory.addGuitar("2", 1499.95, "Gibson", "GA101", "Electric", "Maple", "Alder")
        inventory.addGuitar("3", 1799.0, "Ryan", "R1A01", "Acoustic", "Alder", "Indian Rosewood")
    End Sub

    Private Sub displayGuitarInfo(guitar As Guitar)
        Dim infoMsg As String = String.Format("Found guitar.{0}{0}SerialNo. {1}{0}Price {2}", vbCrLf, guitar.getSerialNumber(), guitar.getPrice())
        MessageBox.Show(infoMsg)
    End Sub

    Private Sub displaySorryMessage(guitar As Guitar)
        Dim sorryMsg As String = String.Format("Not found guitar build from {0}.", guitar.getBuilder())
        MessageBox.Show(sorryMsg)
    End Sub
End Class
