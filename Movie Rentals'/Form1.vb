' Project : Homework 1
'Author: William Orr
'Description: Uses Variables and computations to calculate discounts and number of videos rented

Public Class form1
    Const DiscountPercentage As Decimal = 0.2
    Dim TotalVideosRented As Integer
    Dim CustomerCount As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Dim Quanity As Integer
        Dim Price As Decimal
        Dim ExtendedPrice, DiscountPrice, FinalPrice As Decimal

        Try
            Quanity = Integer.Parse(VideosRentedTB.Text)

            Try
                Price = Decimal.Parse(PriceTextBox.Text)

                ExtendedPrice = Quanity * Price
                ExtendedPriceTextBox.Text = ExtendedPrice.ToString("c")

                ''Discount Calculation
                DiscountPrice = ExtendedPrice * DiscountPercentage
                DiscountTextBox.Text = DiscountPrice.ToString("c")

                ''Calculate Final Price
                FinalPrice = ExtendedPrice - DiscountPrice
                DiscountedPriceTextBox.Text = FinalPrice.ToString("c")

                TotalVideosRented += Quanity
                CustomerCount = CustomerCount + 1

                TotalVideosRentedTB.Text = TotalVideosRented.ToString
                TotalCustomersTB.Text = CustomerCount.ToString


            Catch ex As FormatException
                MessageBox.Show("Can not be empty",
                           "Data Entry Error",
                           MessageBoxButtons.OK,
                           MessageBoxIcon.Asterisk)
                MemberNumberTB.Focus()
                MemberNumberTB.SelectAll()

            End Try

        Catch ex As FormatException
            MessageBox.Show("Can not be empty",
                            "Data Entry Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk)
            VideosRentedTB.Focus()
            VideosRentedTB.SelectAll()

        End Try




    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub TotalDiscountTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        VideosRentedTB.Text = String.Empty
        MemberNumberTB.Text = String.Empty

        VideosRentedTB.Focus()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
