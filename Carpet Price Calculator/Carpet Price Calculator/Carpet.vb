﻿Option Strict On

Public Class Carpet
    ' Class variables
    Private strColor As String
    Private strStyle As String
    Private dblPrice As Double

    ' Initialize class variables before use
    Public Sub New()
        strColor = String.Empty
        strStyle = String.Empty
        dblPrice = 0
    End Sub

    ' Color property
    Public Property Color() As String
        Get
            Return strColor
        End Get
        Set(ByVal value As String)
            strColor = value
        End Set
    End Property


    ' Style property
    Public Property Style() As String
        Get
            Return strStyle
        End Get
        Set(ByVal value As String)
            strStyle = value
        End Set
    End Property


    ' price property
    Public Property Price() As Double
        Get
            Return dblPrice
        End Get
        Set(ByVal value As Double)
            dblPrice = value
        End Set
    End Property

End Class
