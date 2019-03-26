﻿'Creator: Harris Ransom
'Date: December 3rd, 2018

Public Class FactorCalc
    'Declares variables 
    Dim numToFactor As Double 'The number being factored
    Dim factor As Double 'The factor being used in the calculation
    Dim isFactor As Boolean 'True/False value determining if number is a factor or not

    'Calculates the factor 
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        numToFactor = txtNumberToFactor.Text
        factor = txtFactor.Text
        lblResult.Visible = True

        'Determines if number is factor, then displays result
        If (numToFactor Mod factor = 0) Then
            lblResult.Text = CStr(factor) + " is a factor of " + CStr(numToFactor)
        Else
            lblResult.Text = CStr(factor) + " is not a factor of " + CStr(numToFactor)
        End If

    End Sub
    'Clears the program from the menu strip
    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs)
        lblResult.Text = ""
        lblResult.Visible = False
        txtFactor.Text = ""
        txtNumberToFactor.Text = ""

    End Sub

    'Exits the program
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'Takes user back to hub
    Private Sub btnHub_Click(sender As Object, e As EventArgs) Handles btnHub.Click
        Me.Hide()
        ApplicationHub.Show()
    End Sub
End Class
