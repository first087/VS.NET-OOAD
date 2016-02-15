Public Class Guitar
    Private serialNumber As String
    Private price As Double
    Private builder As String
    Private model As String
    Private type As String
    Private backWood As String
    Private topWood As String

    Public Sub New(serialNumber As String, price As Double, builder As String, model As String, type As String, backWood As String, topWood As String)
        Me.serialNumber = serialNumber
        Me.price = price
        Me.builder = builder
        Me.model = model
        Me.type = type
        Me.backWood = backWood
        Me.topWood = topWood
    End Sub

    Public Function getSerialNumber() As String
        Return Me.serialNumber
    End Function

    Public Function getPrice() As Double
        Return Me.price
    End Function

    Public Sub setPrice(price As Single)
        Me.price = price
    End Sub

    Public Function getBuilder() As String
        Return Me.builder
    End Function

    Public Function getModel() As String
        Return Me.model
    End Function

    Public Function getGuitarType() As String
        Return Me.type
    End Function

    Public Function getBackWood() As String
        Return Me.backWood
    End Function

    Public Function getTopWood() As String
        Return Me.topWood
    End Function
End Class
