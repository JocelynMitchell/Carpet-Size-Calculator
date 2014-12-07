Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close form.
        Me.Close()
    End Sub

    Private Sub btnCalcCarpetArea_Click(sender As Object, e As EventArgs) Handles btnCalcCarpetArea.Click
        ' Declare and initialize variables.
        Dim carpetWidth As Double
        Dim carpetLength As Double

        ' Make sure user input is a positive number.
        If Not IsNumeric(txtCarpetWidth.Text) Or Val(txtCarpetWidth.Text) <= 0 Then
            MessageBox.Show("Enter a positive number greater than zero. ")
            txtCarpetLength.Clear()
            txtCarpetWidth.Clear()
            txtCarpetWidth.Focus()
        Else
            carpetWidth = Double.Parse(txtCarpetWidth.Text)
            If Not IsNumeric(txtCarpetLength.Text) Or Val(txtCarpetLength.Text) <= 0 Then
                MessageBox.Show("Enter a positive number greater than zero. ")
                txtCarpetLength.Clear()
                txtCarpetWidth.Clear()
                txtCarpetWidth.Focus()
            Else
                carpetLength = Double.Parse(txtCarpetLength.Text)
            End If
        End If

        ' Multiply carpetWidth by carpetLength and display result.
        Dim carpetArea As Double
        carpetArea = carpetLength * carpetWidth
        lblCarpetArea.Text = Double.Parse(carpetArea)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Clear textboxes and reset focus.
        txtCarpetLength.Clear()
        txtCarpetWidth.Clear()
        lblCarpetArea.Text = " "
        txtCarpetWidth.Focus()
    End Sub
End Class
