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

End Class