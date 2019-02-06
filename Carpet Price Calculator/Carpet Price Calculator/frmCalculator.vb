' ************************************************************
' Ryan Turner
' 1/28/2019
'
' This is a program to calculate the price of a carpet
' based on the dimensions and price per sqare foot
' using classes and objects
'
' ************************************************************
Option Strict On
Public Class frmCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Create new object from Rectangle class
        Dim objRectangle = New Rectangle

        ' Create new object from Carpet class
        Dim objCarpet = New Carpet

        ' Validate user input
        If Validation() = True Then

            ' If all inputs are valid, insert data into class
            objCarpet.Color = txtColor.Text          ' Color
            objCarpet.Style = txtStyle.Text          ' Style
            objCarpet.Price = CDbl(txtPrice.Text)    ' Price
            objRectangle.Length = CInt(txtLength.Text)  ' Length
            objRectangle.Width = CInt(txtWidth.Text)    ' Width

            ' Display output
            Display(objRectangle, objCarpet)

        End If


    End Sub

    Private Function Validation() As Boolean
        ' Set back colors to white if it was yellow
        txtColor.BackColor = Color.White
        txtStyle.BackColor = Color.White
        txtPrice.BackColor = Color.White
        txtLength.BackColor = Color.White
        txtWidth.BackColor = Color.White

        ' Validate Color input
        If txtColor.Text = String.Empty Then
            MessageBox.Show("Please enter a color. ")
            ' Set the back color to yellow and set focus 
            txtColor.BackColor = Color.Yellow
            txtColor.Focus()
            Return False

        End If

        ' Validate Style input
        If txtStyle.Text = String.Empty Then
            MessageBox.Show("Please enter a style. ")
            ' Set the back color to yellow and set focus 
            txtStyle.BackColor = Color.Yellow
            txtStyle.Focus()
            Return False

        End If

        ' Validate price input
        If IsNumeric(txtPrice.Text) = False Then
            MessageBox.Show("Please enter a price.")
            ' Set the back color to yellow and set focus 
            txtPrice.BackColor = Color.Yellow
            txtPrice.Focus()
            Return False

        End If

        ' Validate length input
        If IsNumeric(txtLength.Text) = False Then
            MessageBox.Show("Please enter a Length.")
            ' Set the back color to yellow and set focus 
            txtLength.BackColor = Color.Yellow
            txtLength.Focus()
            Return False

        End If

        ' Validate width input
        If IsNumeric(txtWidth.Text) = False Then
            MessageBox.Show("Please enter a Width.")
            ' Set the back color to yellow and set focus 
            txtWidth.BackColor = Color.Yellow
            txtWidth.Focus()
            Return False

        End If

        ' If Everything is correct, return true
        Return True

    End Function

    Private Sub Display(ByVal objRectangle As Rectangle, ByVal objCarpet As Carpet)
        ' Get the total area
        objRectangle.CalcArea()

        ' Display total area
        lblArea.Text = objRectangle.Area.ToString() + " sqFt."

        ' Calculate and display total price for the carpet
        lblPrice.Text = FormatCurrency(objRectangle.Area * objCarpet.Price)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clear labels
        lblArea.ResetText()
        lblPrice.ResetText()

        ' Clear text boxes
        txtColor.Clear()
        txtStyle.Clear()
        txtPrice.Clear()
        txtLength.Clear()
        txtWidth.Clear()

        ' Set focus to first text box
        txtColor.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Exit the application
        Close()

    End Sub
End Class