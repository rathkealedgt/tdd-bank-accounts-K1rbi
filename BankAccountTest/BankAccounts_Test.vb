Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()

        ' round 2 because i forgot to save :(


        'arrange
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As Double = 1043.82
        Dim IntrestRate As Double = 4.3


        ' act
        Dim Account1 As New BankAccounts.BankAccount(AcountHolder, AcountNumber, Balance, IntrestRate, Country)
        Dim Account2 As New BankAccounts.BankAccount(AcountHolder, AcountNumber, Balance, IntrestRate)
        Dim Account3 As New BankAccounts.BankAccount(AcountHolder, AcountNumber, Balance)


        ' Assert
        Assert.IsNotNull(Account1)
        Assert.IsNotNull(Account2)
        Assert.IsNotNull(Account3)

    End Sub


    <TestMethod()> Public Sub TestAccountHolder()
        '

        'arrange
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As Double = 1043.82
        Dim IntrestRate As Double = 4.3

        Dim Account1 As New BankAccounts.BankAccount(AcountHolder, AcountNumber, Balance, IntrestRate, Country)

        'act
        Dim Name As String = Account1.GetAccountHolder()

        'assert
        Assert.AreEqual(Name, "Ms  I. N. Cognito")


    End Sub

    <TestMethod()> Public Sub TestsetAccountholder()
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
        '

        'act
        Account1.SetAccountHolder("Ms  I. N. Cognito")

        'assert
        Assert.AreEqual(Account1.GetAccountHolder, "Ms  I. N. Cognito")

    End Sub



    Private Function NewAccount() 
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As Double = 1043.82
        Dim IntrestRate As Double = 4.3

        Return New BankAccounts.BankAccount(AcountHolder, AcountNumber, Balance, IntrestRate, Country)
    End Function

    'getters new
    <TestMethod()> Public Sub TestgetInterestRate()
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
        '

        'act
        Dim Interestrate As Double = 4.3

        'assert
        Assert.AreEqual(Interestrate, Account1.GetInterestRate)

    End Sub



    <TestMethod()> Public Sub TestSetInterestRate()
        'arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'act
        Account1.SetInterestRate(5.1)



        'assert
        Assert.AreEqual(5.1, Account1.GetInterestRate)

    End Sub

    <TestMethod()> Public Sub TestgetAccountNumber()
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
        '

        'act
        Dim AcccountNumber As String = "ABCD 89011 11167890"

        'assert
        Assert.AreEqual(AcccountNumber, Account1.GetAccountNumber)

    End Sub



    <TestMethod()> Public Sub TestSetAccountNumber()
        'arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'act
        Account1.SetAccountNumber("ABCD 89011 11167890")



        'assert
        Assert.AreEqual("ABCD 89011 11167890", Account1.GetAccountNumber)

    End Sub

    ' country

    <TestMethod()> Public Sub Testgetcountry()
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
        '

        'act
        Dim country As String = "Isle of Man"

        'assert
        Assert.AreEqual(country, Account1.GetCountry)

    End Sub



    <TestMethod()> Public Sub TestSetcountry()
        'arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'act
        Account1.SetCountry("Isle of Man")



        'assert
        Assert.AreEqual("Isle of Man", Account1.GetCountry)

    End Sub


    ' balance
    <TestMethod()> Public Sub Testgetbalance()
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount
        '

        'act
        Dim balance As Double = 1043.82

        'assert
        Assert.AreEqual(balance, Account1.Getbalance)

    End Sub



    <TestMethod()> Public Sub TestSetbalance()
        'arrange
        Dim Account1 As BankAccounts.BankAccount = Me.NewAccount

        'act
        Account1.Setbalance(1500)
        Dim balance As Double = 1500


        'assert
        Assert.AreEqual(balance, Account1.Getbalance)

    End Sub

    <TestMethod()> Public Sub TestApplyInterestRate()
        'p x r x t = i => 37.07 + 10343.82 = 10380.89

        'arrange
        Dim account1 As BankAccounts.BankAccount = Me.NewAccount()

        'act
        account1.Setbalance(10343.82)
        account1.ApplyInterest()

        'assert
        Assert.AreEqual(account1.Getbalance(), 10380.89)


    End Sub


    <TestMethod()> Public Sub TestToStringMethod()
        'Must print like this : 
        'Isle of Man + vbcrlf
        'ABCD 890111 11167890 + vbcrlf
        'Ms I.N.Cognito + vbcrlf
        'Interrest: 4.3% + vbcrlf
        '10343.82 + vbcrlf

        'arrange
        Dim ExpectedValueString As New StringBuilder()

        ExpectedValueString.Append("Isle of Man" & vbCrLf)
        ExpectedValueString.Append("ABCD 89011 11167890" & vbCrLf)
        ExpectedValueString.Append("Ms  I. N. Cognito" & vbCrLf)
        ExpectedValueString.Append("Interrest: 4.3%" & vbCrLf)
        ExpectedValueString.Append(10343.82 & vbCrLf)
        Console.WriteLine(ExpectedValueString)
        Dim Account1 As BankAccounts.BankAccount = NewAccount2()

        'act
        Dim ActualString = Account1.ToString()
        Console.WriteLine(ActualString)
        'assert
        Assert.AreEqual(ExpectedValueString.ToString(), ActualString)


    End Sub

    Private Function NewAccount2() As BankAccounts.BankAccount
        Dim AcountHolder As String = "Ms  I. N. Cognito"
        Dim AcountNumber As String = "ABCD 89011 11167890"
        Dim Country As String = "Isle of Man"

        Dim Balance As Double = 10343.82
        Dim IntrestRate As Double = 4.3

        Return New BankAccounts.BankAccount(AcountHolder, AcountNumber, Balance, IntrestRate, Country)
    End Function

    <TestMethod()> Public Sub TestDeposit()
        'arrange
        Dim Account1 As BankAccounts.BankAccount = NewAccount2()
        Dim Exspected As Double = 10343.82 + 500


        'act
        Dim ActualValue As Double = Account1.Deposit(500)


        'assert
        Assert.AreEqual(Exspected, ActualValue)


    End Sub


    <TestMethod()> Public Sub TestWithdraw()
        'arrange
        Dim Account1 As BankAccounts.BankAccount = NewAccount2()
        Dim Exspected As Double = 10343.82 - 500


        'act
        Dim ActualValue As Double = Account1.Withdraw(500)


        'assert
        Assert.AreEqual(Exspected, ActualValue)


    End Sub
    <TestMethod()> Public Sub TestWithdrawLarge()
        'arrange
        Dim Account1 As BankAccounts.BankAccount = NewAccount2()
        Dim Exspected As Double = 10343.82


        'act

        Try
            Dim ActualValue As Double = Account1.Withdraw(100000)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        'assert
        Assert.AreEqual(Exspected, Account1.Getbalance)


    End Sub
End Class