Option Strict On



Public Class frmXboxGamingGrp
    Dim intSingleSub As Integer = 7 'Class Level Interger Variables for the Price of the Membershipts 
    Dim intFamilySub As Integer = 12
    Dim intXBoxDevSub As Integer = 3




    'This event happens when the form is loaded
    Private Sub frmXboxGamingGrp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSubscriptionType.SetSelected(0, True) 'When the form loads set the Subsription Type List Box to the first Index 
        lstNumberOfMonBox.Value = 1 'When the form loads set the Number Of Months List Box to 1
        lblDisplayTotal.Text = " "


    End Sub


    'This event happens when the user clicks on the confirm button
    Private Sub btnSelectMembership_Click(sender As Object, e As EventArgs) Handles btnSelectMembership.Click

        Dim strSubscriptionType As String = lstSubscriptionType.SelectedIndex.ToString("G")
        Dim intSubscriptionTypeIndex As Integer = (lstSubscriptionType.SelectedIndex)
        'lblHeading.Text = strSubscriptionType
        Dim intNumberOfMon As Integer = Convert.ToInt32(lstNumberOfMonBox.Value)
        Dim intSubcriptionCost As Integer

        If intSubscriptionTypeIndex = 0 Then
            lblSubscriptionType.Text = "$7 per month for a Single Subcription"
            intSubcriptionCost = intNumberOfMon * intSingleSub
            lblDisplayTotal.Text = intSubcriptionCost.ToString("C") & " for " & intNumberOfMon & " Months"
        ElseIf intSubscriptionTypeIndex = 1 Then
            lblSubscriptionType.Text = "$12 per month for the Family Subscription "
            intSubcriptionCost = intNumberOfMon * intFamilySub
            lblDisplayTotal.Text = intSubcriptionCost.ToString("C") & " for " & intNumberOfMon & " Months"
        ElseIf intSubscriptionTypeIndex = 2 Then
            lblSubscriptionType.Text = "$3 per month for the XBox Developer Subcription"
            intSubcriptionCost = intNumberOfMon * intXBoxDevSub
            lblDisplayTotal.Text = intSubcriptionCost.ToString("C") & " for " & intNumberOfMon & " Months"
        End If

        'Gets value from the List Number Of Months box  Converts to Int and sets it equal to int Variable intLstNumberOfMonValue
        Dim intLstNumberOfMonValue As Integer = CInt(lstNumberOfMonBox.Value)

        'If the Integer Value enter is less than one or greather than 12_
        ' Then a message box will appear to alert of the error and reset the Number of Mon LstBox to 1
        If intLstNumberOfMonValue < 1 Or intLstNumberOfMonValue > 12 Then
            Dim strMsg As String = "Please enter in a number between 1 and 12"
            Dim strMsgTitle As String = "Invalid Entry"
            MsgBox(strMsg, , strMsgTitle) 'Can use MsgBox I forgot to add a second ( , ) between the two arguements
            lstNumberOfMonBox.Value = 1

        End If

        'If the user does not enter a first or last name then the user will be prompted to correct the error
        If txt1stName.Text = "" Or txtLastName.Text = "" Then
            Dim strNameMsg As String = "You did not enter the name fields correctly, use N/A where necessary"
            Dim strNameMsgTitle As String = "Incomplete Entry"
            MessageBox.Show(strNameMsg, strNameMsgTitle) 'Can also use MsgBox but it wanted to give me issues with this string for whatever reason
            txt1stName.Text = ""
            txtLastName.Text = ""
            txtMiddInitial.Text = ""
            lblDisplayTotal.Text = ""
        End If

    End Sub


    'This event happens as the user selects the different memberships to see their prices
    Private Sub lstSubscriptionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubscriptionType.SelectedIndexChanged
        If lstSubscriptionType.SelectedIndex = 0 Then
            lblCostPerMonth.Text = "$7 per Month for Selected Subscription"
        End If
        If lstSubscriptionType.SelectedIndex = 1 Then
            lblCostPerMonth.Text = "$12 per Month for Selected Subscription"
        End If
        If lstSubscriptionType.SelectedIndex = 2 Then
            lblCostPerMonth.Text = "$3 per Month for Selected Susbcrtipion"
        End If

    End Sub

    'This event happens when the Clear Button is Selected and clears the Form
    Private Sub btnClearSelection_Click(sender As Object, e As EventArgs) Handles btnClearSelection.Click
        txt1stName.Text = ""
        txtLastName.Text = ""
        txtMiddInitial.Text = ""
        lblDisplayTotal.Text = ""
        lstNumberOfMonBox.Value = 1
        lstSubscriptionType.SetSelected(0, True)



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
