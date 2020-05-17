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
        Me.AcountHolder = AcountNumber
        Me.Balance = Balance
        Me.Intrestrate = IntrestRate
        Me.Country = Country
    End Sub

    Public Sub New(AcountHolder As String, AcountNumber As String, Balance As Double, IntrestRate As Double)
        Me.AcountHolder = AcountHolder
        Me.AcountHolder = AcountNumber
        Me.Balance = Balance
        Me.Intrestrate = IntrestRate
    End Sub

    Public Sub New(AcountHolder As String, AcountNumber As String, Balance As Double,)
        Me.AcountHolder = AcountHolder
        Me.AcountHolder = AcountNumber
        Me.Balance = Balance
    End Sub

    Public Function GetAccountHolder()

        Return AcountHolder
    End Function


End Class
