Imports System.Text

Public Class BankAccountsForm

    Private Accounts(4) As BankAccount
    Private NumAccounts As Integer


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.NumAccounts = 0

    End Sub

    Public Function CreatAccount()


        If TxtAccountHolder.Text = "" Then Throw New Exception("AccountholderRequired")
        If TxtAccountNumber.Text = "" Then Throw New Exception("AccountNumberRequired")
        If TxtAccountInterestRate.Text = "" Then Throw New Exception("AccountInterestRateRequired")
        If TxtAccountBalance.Text = "" Then Throw New Exception("AccountBalanceRequired")
        If TxtCountry.Text = "" Then Throw New Exception("AccoubtCountryRequired")
        If Me.NumAccounts > 4 Then Throw New Exception("MaxumumACcountsReachedException")

        Dim AccountHolder As String = TxtAccountHolder.Text
        Dim AccountNumber = TxtAccountNumber.Text
        Dim InterestRate As Double = CDbl(TxtAccountInterestRate.Text)
        Dim Balance As Double = CDbl(TxtAccountBalance.Text)
        Dim Country As String = TxtCountry.Text


        Dim NewAccount As New BankAccount(AccountHolder, AccountNumber, Balance, InterestRate, Country)
        Me.Accounts(Me.NumAccounts) = NewAccount
        Me.NumAccounts += 1



        Return Nothing
    End Function


    Public Function SetTestForTesting(AccountHolder As String, AccountNumber As String, Balance As String, InterestRate As String, Country As String)

        TxtAccountHolder.Text = AccountHolder
        TxtAccountNumber.Text = AccountNumber
        TxtAccountBalance.Text = Balance
        TxtAccountInterestRate.Text = InterestRate
        TxtCountry.Text = Country

        Return Nothing
    End Function


    Public Function GetAccounts() As BankAccount()
        Return Me.Accounts
    End Function

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub


    Private Sub BtnCreateAccount_Click(sender As Object, e As EventArgs) Handles BtnCreateAccount.Click

        Dim FeeBack As String = "Account added."
        Dim Title As String = "Success"

        Try
            Me.CreatAccount()

        Catch EX As Exception
            Title = EX.Message()

            If EX.Message = "AccountHolderRequiredExpection" Then
                FeeBack = "please enter an account holder required"
                TxtAccountHolder.Focus()

            ElseIf EX.Message = "AccountNumberRequired" Then
                FeeBack = "please enter an account number required"
                TxtAccountNumber.Focus()
            ElseIf EX.Message = "AccoubtCountryRequired" Then
                FeeBack = "please enter an account Country required"
                TxtCountry.Focus()

            ElseIf EX.Message = "AccountInterestRateRequired" Then
                FeeBack = "please enter an account interest Rate required"
                TxtAccountInterestRate.Focus()

            ElseIf EX.Message = "AccountBalanceRequired" Then
                FeeBack = "please enter an account balance required"
                TxtAccountBalance.Focus()

            ElseIf EX.Message = "MaxumumACcountsReachedException" Then
                FeeBack = "you have reached the max amount of accounts"
                TxtCountry.Focus()
            Else
                Title = "An error occurred"
                FeeBack = EX.Message
            End If
        End Try

        MsgBox(FeeBack, vbOKOnly, Title)

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        Dim AllAccounts As New StringBuilder()

        For Each Ba As BankAccount In Me.Accounts
            If Ba Is Nothing Then Exit For

            AllAccounts.Append(Ba.ToString())
            AllAccounts.Append(vbCrLf)

        Next
        TxtAccountList.Text = AllAccounts.ToString()


    End Sub
End Class