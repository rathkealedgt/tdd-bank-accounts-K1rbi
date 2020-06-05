Imports System.Text
Imports BankAccounts
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class GUI_Test

    <TestMethod()> Public Sub TestCreateAccount()

        'arrange
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As String = 1043.82
        Dim IntrestRate As String = 4.3

        Dim BF As New BankAccountsForm()

        BF.SetTestForTesting(AcountHolder, AcountNumber, Balance, IntrestRate, Country)

        ' act
        BF.CreatAccount()
        Dim TempAccount() As BankAccount = BF.GetAccounts()
        'assert
        Assert.AreEqual(AcountHolder, TempAccount(0).GetAccountHolder())
        Assert.AreEqual(AcountNumber, TempAccount(0).GetAccountNumber())
        Assert.AreEqual(Country, TempAccount(0).GetCountry())
        Assert.AreEqual(1043.82, TempAccount(0).Getbalance())
        Assert.AreEqual(4.3, TempAccount(0).GetInterestRate())
    End Sub

    <TestMethod()> Public Sub TestEmptyAccountHolder()

        'arrange
        Dim AcountHolder As String = ""
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As String = 1043.82
        Dim IntrestRate As String = 4.3

        Dim BF As New BankAccountsForm()

        BF.SetTestForTesting(AcountHolder, AcountNumber, Balance, IntrestRate, Country)

        ' act
        Try
            BF.CreatAccount()
            Assert.Fail() ' 
        Catch EX As Exception
            'assert
            Assert.AreEqual("AccountholderRequired", Ex.Message)
        End Try


    End Sub
    <TestMethod()> Public Sub TestEmptyAccountNumber()

        'arrange
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = ""
        Dim Country As String = "Isle of Man"

        Dim Balance As String = 1043.82
        Dim IntrestRate As String = 4.3

        Dim BF As New BankAccountsForm()

        BF.SetTestForTesting(AcountHolder, AcountNumber, Balance, IntrestRate, Country)

        ' act
        Try
            BF.CreatAccount()
            Assert.Fail() ' 
        Catch EX As Exception
            'assert
            Assert.AreEqual("AccountNumberRequired", Ex.Message)
        End Try


    End Sub
    <TestMethod()> Public Sub TestEmptyInterestRate()

        'arrange
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As String = 1043.82
        Dim IntrestRate As String = Nothing

        Dim BF As New BankAccountsForm()

        BF.SetTestForTesting(AcountHolder, AcountNumber, Balance, IntrestRate, Country)

        ' act
        Try
            BF.CreatAccount()
            Assert.Fail() ' 
        Catch EX As Exception
            'assert
            Assert.AreEqual("AccountInterestRateRequired", Ex.Message)
        End Try


    End Sub

    <TestMethod()> Public Sub TestEmptyBalance()

        'arrange
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As String = Nothing
        Dim IntrestRate As String = 4.3

        Dim BF As New BankAccountsForm()

        BF.SetTestForTesting(AcountHolder, AcountNumber, Balance, IntrestRate, Country)

        ' act
        Try
            BF.CreatAccount()
            Assert.Fail() ' 
        Catch EX As Exception
            'assert
            Assert.AreEqual("AccountBalanceRequired", Ex.Message)
        End Try


    End Sub

    <TestMethod()> Public Sub TestEmptyCrountry()

        'arrange
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = ""

        Dim Balance As String = 1043.82
        Dim IntrestRate As String = 4.3

        Dim BF As New BankAccountsForm()

        BF.SetTestForTesting(AcountHolder, AcountNumber, Balance, IntrestRate, Country)

        ' act
        Try
            BF.CreatAccount()
            Assert.Fail() ' 
        Catch EX As Exception
            'assert
            Assert.AreEqual("AccoubtCountryRequired", Ex.Message)
        End Try


    End Sub

    <TestMethod()> Public Sub TestAddFiveAccounts()


        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As String = 1043.82
        Dim IntrestRate As String = 4.3

        Dim BF As New BankAccountsForm()

        BF.SetTestForTesting(AcountHolder, AcountNumber, Balance, IntrestRate, Country)

        'arrange

        ' act

        Try

            For Counter As Integer = 0 To 4
                BF.SetTestForTesting(Counter & "_" & AcountHolder, AcountNumber, Balance, IntrestRate, Country)
                BF.CreatAccount()
            Next Counter

        Catch ex As Exception

            Assert.Fail()

        End Try


        Dim TempAccounts() As BankAccount = Bf.GetAccounts

        For Each Ba In TempAccounts
            If Ba Is Nothing Then Assert.Fail()
        Next

    End Sub

    <TestMethod()> Public Sub TestCanNOtAddSixAccounts()

        'arrange
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As String = 1043.82
        Dim IntrestRate As String = 4.3

        Dim BF As New BankAccountsForm()


        ' act

        Try

            For Counter As Integer = 0 To 5
                BF.SetTestForTesting(Counter & "_" & AcountHolder, AcountNumber, Balance, IntrestRate, Country)
                BF.CreatAccount()
            Next Counter

            'assert
            Assert.Fail()


        Catch ex As Exception

            Assert.AreEqual("MaxumumACcountsReachedException", ex.Message())

        End Try
    End Sub

End Class