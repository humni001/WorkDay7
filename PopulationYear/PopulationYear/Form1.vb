Option Strict On

Public Class Form1

    Dim population As Double = 7000000000
    Dim year As Integer = 2014

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Do While population >= 6000000
            population = population / 2
            year = year - 50
        Loop

        MessageBox.Show("The year was: " & year)

    End Sub
End Class
