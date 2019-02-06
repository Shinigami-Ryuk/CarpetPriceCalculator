Option Strict On

Public Class Rectangle

    ' Variables for the class
    Private intLength As Integer
    Private intWidth As Integer
    Private intArea As Integer

    Private strColor As String
    Private strStyle As String
    Private dblPrice As Double

    ' set values to 0 before using class
    Public Sub New()
        intLength = 0
        intWidth = 0
        intArea = 0
    End Sub

    ' Length property
    Public Property Length() As Integer
        Get
            Return intLength
        End Get
        Set(ByVal value As Integer)
            intLength = value
        End Set
    End Property


    ' Width property
    Public Property Width() As Integer
        Get
            Return intWidth
        End Get
        Set(ByVal value As Integer)
            intWidth = value
        End Set
    End Property


    ' Area Property
    Public ReadOnly Property Area() As Integer
        Get
            Return intArea
        End Get
    End Property


    ' function to calculate area
    Public Sub CalcArea()
        ' calculate area
        intArea = intLength * intWidth

    End Sub

End Class
