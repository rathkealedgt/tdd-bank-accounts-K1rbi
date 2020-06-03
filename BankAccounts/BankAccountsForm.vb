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
        Dim AccountHolder As String = TxtAccountHolder.Text
        Dim AccountNumber = TxtAccountNumber.Text
        Dim InterestRate As Double = CDbl(TxtAccountInterestRate.Text)
        Dim Balance As Double = CDbl(TxtAccountBalance.Text)
        Dim Country As String = TxtCountry.Text

        If AccountHolder = "" Then Throw New Exception("AccountholderRequired")
        If AccountNumber = "" Then Throw New Exception("AccountNumberRequired")
        If InterestRate = "" Then Throw New Exception("AccountInterestRateRequired")
        If Balance = "" Then Throw New Exception("AccountBalanceRequired")
        If Country = "" Then Throw New Exception("AccoubtCountryRequired")

        Dim NewAccoint As New BankAccount(AccountHolder, AccountNumber, InterestRate, Balance, Country)
        Me.Accounts(Me.NumAccounts) = NewAccoint
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