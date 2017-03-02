Option Strict On



Public Class frmXboxGamingGrp
    Dim intSingleSub As Integer = 7 'Class Level Interger Variables for the Price of the Membershipts 
    Dim intFamilySub As Integer = 12
    Dim intXBoxDevSub As Integer = 3





    Private Sub frmXboxGamingGrp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstSubscriptionType.SetSelected(0, True) 'When the form loads set the Subsription Type List Box to the first Index 
        lstNumberOfMonBox.Value = 1 'When the form loads set the Number Of Months List Box to 1


    End Sub



    Private Sub btnSelectMembership_Click(sender As Object, e As EventArgs) Handles btnSelectMembership.Click
        Dim strSubscriptionType As String = lstSubscriptionType.SelectedIndex.ToString("G")
        Dim intSubscriptionTypeIndex As Integer = (lstSubscriptionType.SelectedIndex)
        'lblHeading.Text = strSubscriptionType
        Dim intNumberOfMon As Integer = Convert.ToInt32(lstNumberOfMonBox.Value)
        Dim intSubcriptionCost As Integer

        If intSubscriptionTypeIndex = 0 Then

            lblSubscriptionType.Text = "$7 a month for a Single Subcription"
            intSubcriptionCost = intNumberOfMon * intSingleSub
            lblDisplayTotal.Text = intSubcriptionCost.ToString("C") & " for " & intNumberOfMon & " Months"
        ElseIf intSubscriptionTypeIndex = 1 Then
            lblSubscriptionType.Text = "$12 a  month for the Family Subscription "
            intSubcriptionCost = intNumberOfMon * intFamilySub
            lblDisplayTotal.Text = intSubcriptionCost.ToString("C") & " for " & intNumberOfMon & " Months"
        ElseIf intSubscriptionTypeIndex = 2 Then
            lblSubscriptionType.Text = "$3 a month for the XBox Developer Subcription"
            intSubcriptionCost = intNumberOfMon * intXBoxDevSub
            lblDisplayTotal.Text = intSubcriptionCost.ToString("C") & " for " & intNumberOfMon & " Months"
        End If

        Dim intLstNumberOfMonValue As Integer = Convert.ToInt32(lstNumberOfMonBox.Value)

        If intLstNumberOfMonValue < 1 Or intLstNumberOfMonValue > 12 Then
            Dim strMsg As String = "Please enter in a number between 1 and 12"
            Dim strMsgTitle As String = "Invalid Entry"
            MessageBox.Show(strMsg, strMsgTitle)
            lstNumberOfMonBox.Value = 1

        End If



    End Sub

    Private Sub lstSubscriptionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSubscriptionType.SelectedIndexChanged
        If lstSubscriptionType.SelectedIndex = 0 Then
            lblCostPerMonth.Text = "$7 a Month for Selected Subscription"
        End If
        If lstSubscriptionType.SelectedIndex = 1 Then
            lblCostPerMonth.Text = "$12 a Month for Selected Subscription"
        End If
        If lstSubscriptionType.SelectedIndex = 2 Then
            lblCostPerMonth.Text = "$3 a Month for Selected Susbcrtipion"
        End If

    End Sub

    Private Sub btnClearSelection_Click(sender As Object, e As EventArgs) Handles btnClearSelection.Click
        txt1stName.Text = ""
        txtLastName.Text = ""
        txtMiddInitial.Text = ""
        lstNumberOfMonBox.Value = 1
        lstSubscriptionType.SetSelected(0, True)



    End Sub
End Class
