﻿Imports System.Text
Public Class BankAccount
    ''' <summary>
    '''        Bank account
    ''' </summary>
    ''' <author> Tom K </author>
    ''' <date>17/05/2020</date>



    Private AcountHolder As String
    Private AcountNumber As String
    Private Country As String
    Private Balance As Double
    Private Intrestrate As Double

    Public Sub New(AcountHolder As String, AcountNumber As String, Balance As Double, IntrestRate As Double, Country As String)
        Me.AcountHolder = AcountHolder
        Me.AcountNumber = AcountNumber
        Me.Balance = Balance
        Me.Intrestrate = IntrestRate
        Me.Country = Country
    End Sub

    Public Sub New(AcountHolder As String, AcountNumber As String, Balance As Double, IntrestRate As Double)
        Me.AcountHolder = AcountHolder
        Me.AcountNumber = AcountNumber
        Me.Balance = Balance
        Me.Intrestrate = IntrestRate
    End Sub

    Public Sub New(AcountHolder As String, AcountNumber As String, Balance As Double)
        Me.AcountHolder = AcountHolder
        Me.AcountNumber = AcountNumber
        Me.Balance = Balance
    End Sub

    Public Function GetAccountHolder()

        Return Me.AcountHolder
    End Function
    Public Function SetAccountHolder(AccountHolder As String)
        Me.AcountHolder = AccountHolder

        Return Nothing
    End Function



    Public Function GetInterestRate()

        Return Me.Intrestrate
    End Function

    Public Function SetInterestRate(rate As Double)
        Me.Intrestrate = rate

        Return Nothing
    End Function



    Public Function GetAccountNumber()

        Return Me.AcountNumber
    End Function

    Public Function SetAccountNumber(Number As String)
        Me.AcountNumber = Number

        Return Nothing
    End Function

    'Country
    Public Function GetCountry()

        Return Me.Country
    End Function

    Public Function SetCountry(country As String)
        Me.Country = country

        Return Nothing
    End Function

    'balance


    Public Function Getbalance()

        Return Me.Balance
    End Function

    Public Function Setbalance(balance As String)
        Me.Balance = balance

        Return Nothing
    End Function

    Public Function ApplyInterest()
        Dim NewBalance As Double
        NewBalance = Me.Balance + (Me.Balance * 0.043 * (1 / 12))

        ' 2dp
        Me.Balance = Math.Round(NewBalance, 2)

        Return Nothing
    End Function

    Public Overrides Function ToString() As String
        Dim OutPut As New StringBuilder

        OutPut.Append("Account holder: " & Me.AcountHolder & vbCrLf)
        OutPut.Append("Country: " & Me.Country & vbCrLf)
        OutPut.Append("Account Number: " & Me.AcountNumber & vbCrLf)
        OutPut.Append("Interest rate: " & Me.Intrestrate & "%" & vbCrLf)
        OutPut.Append("$" & Me.Balance & vbCrLf)


        Return OutPut.ToString
    End Function

    Public Function Deposit(InFlow As Double)

        Me.Balance = Me.Balance + InFlow

        Return Me.Balance
    End Function

    Public Function Withdraw(OutFlow As Double)
        Dim OverDraft As String
        OverDraft = "You do not have enough balance to with drawthis amount in the current acount"


        If OutFlow > Me.Balance Then
            Throw New Exception(OverDraft)
        End If

        Me.Balance = Me.Balance - OutFlow

        Return Me.Balance
    End Function

End Class
