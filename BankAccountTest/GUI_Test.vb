﻿Imports System.Text
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
        BF.CreateAccount()
        Dim TempAccount() As BankAccount = BF.GetAccounts()
        'assert
        Assert.AreEqual(AcountHolder, TempAccount(0).GetAccountHolder())
        Assert.AreEqual(AcountNumber, TempAccount(0).GetAccountNumber())
        Assert.AreEqual(Country, TempAccount(0).GetCountry())
        Assert.AreEqual(1043.82, TempAccount(0).Getbalance())
        Assert.AreEqual(4.3, TempAccount(0).GetInterestRate())
    End Sub

End Class