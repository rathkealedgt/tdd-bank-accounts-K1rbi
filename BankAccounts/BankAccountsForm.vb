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

        Dim AccountHolder As String = TxtAccountHolder.Text
        Dim AccountNumber = TxtAccountNumber.Text
        Dim InterestRate As Double = CDbl(TxtAccountInterestRate.Text)
        Dim Balance As Double = CDbl(TxtAccountBalance.Text)
        Dim Country As String = TxtCountry.Text


        Dim NewAccount As New BankAccount(AccountHolder, AccountNumber, Balance, InterestRate, Country)
        Me.Accounts(Me.NumAccounts) = NewAccount
        Return Nothing
    End Function

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        End
    End Sub

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

End Class