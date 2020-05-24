<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BankAccountsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtAccountHolder = New System.Windows.Forms.TextBox()
        Me.LbAccountName = New System.Windows.Forms.Label()
        Me.LbAccountNumber = New System.Windows.Forms.Label()
        Me.TxtAccountNumber = New System.Windows.Forms.TextBox()
        Me.TxtCountry = New System.Windows.Forms.TextBox()
        Me.LbAccount_Country = New System.Windows.Forms.Label()
        Me.TxtAccountInterestRate = New System.Windows.Forms.TextBox()
        Me.LbAccountInterestRate = New System.Windows.Forms.Label()
        Me.TxtAccountBalance = New System.Windows.Forms.TextBox()
        Me.LbAccountBalance = New System.Windows.Forms.Label()
        Me.LbAccountDetails = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BntAddInterest = New System.Windows.Forms.Button()
        Me.BtnCreateAccount = New System.Windows.Forms.Button()
        Me.LbAccountList = New System.Windows.Forms.Label()
        Me.TxtAccountList = New System.Windows.Forms.TextBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtAccountHolder
        '
        Me.TxtAccountHolder.Location = New System.Drawing.Point(327, 134)
        Me.TxtAccountHolder.Name = "TxtAccountHolder"
        Me.TxtAccountHolder.Size = New System.Drawing.Size(213, 20)
        Me.TxtAccountHolder.TabIndex = 1
        '
        'LbAccountName
        '
        Me.LbAccountName.AutoSize = True
        Me.LbAccountName.Location = New System.Drawing.Point(325, 118)
        Me.LbAccountName.Name = "LbAccountName"
        Me.LbAccountName.Size = New System.Drawing.Size(112, 13)
        Me.LbAccountName.TabIndex = 2
        Me.LbAccountName.Text = "Account Holder Name"
        '
        'LbAccountNumber
        '
        Me.LbAccountNumber.AutoSize = True
        Me.LbAccountNumber.Location = New System.Drawing.Point(325, 154)
        Me.LbAccountNumber.Name = "LbAccountNumber"
        Me.LbAccountNumber.Size = New System.Drawing.Size(87, 13)
        Me.LbAccountNumber.TabIndex = 3
        Me.LbAccountNumber.Text = "Account Number"
        '
        'TxtAccountNumber
        '
        Me.TxtAccountNumber.Location = New System.Drawing.Point(327, 170)
        Me.TxtAccountNumber.Name = "TxtAccountNumber"
        Me.TxtAccountNumber.Size = New System.Drawing.Size(213, 20)
        Me.TxtAccountNumber.TabIndex = 4
        '
        'TxtCountry
        '
        Me.TxtCountry.Location = New System.Drawing.Point(328, 209)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(213, 20)
        Me.TxtCountry.TabIndex = 6
        '
        'LbAccount_Country
        '
        Me.LbAccount_Country.AutoSize = True
        Me.LbAccount_Country.Location = New System.Drawing.Point(325, 193)
        Me.LbAccount_Country.Name = "LbAccount_Country"
        Me.LbAccount_Country.Size = New System.Drawing.Size(86, 13)
        Me.LbAccount_Country.TabIndex = 5
        Me.LbAccount_Country.Text = "Account Country"
        '
        'TxtAccountInterestRate
        '
        Me.TxtAccountInterestRate.Location = New System.Drawing.Point(329, 248)
        Me.TxtAccountInterestRate.Name = "TxtAccountInterestRate"
        Me.TxtAccountInterestRate.Size = New System.Drawing.Size(213, 20)
        Me.TxtAccountInterestRate.TabIndex = 8
        '
        'LbAccountInterestRate
        '
        Me.LbAccountInterestRate.AutoSize = True
        Me.LbAccountInterestRate.Location = New System.Drawing.Point(326, 232)
        Me.LbAccountInterestRate.Name = "LbAccountInterestRate"
        Me.LbAccountInterestRate.Size = New System.Drawing.Size(111, 13)
        Me.LbAccountInterestRate.TabIndex = 7
        Me.LbAccountInterestRate.Text = "Account Interest Rate"
        '
        'TxtAccountBalance
        '
        Me.TxtAccountBalance.Location = New System.Drawing.Point(329, 287)
        Me.TxtAccountBalance.Name = "TxtAccountBalance"
        Me.TxtAccountBalance.Size = New System.Drawing.Size(213, 20)
        Me.TxtAccountBalance.TabIndex = 10
        '
        'LbAccountBalance
        '
        Me.LbAccountBalance.AutoSize = True
        Me.LbAccountBalance.Location = New System.Drawing.Point(326, 271)
        Me.LbAccountBalance.Name = "LbAccountBalance"
        Me.LbAccountBalance.Size = New System.Drawing.Size(89, 13)
        Me.LbAccountBalance.TabIndex = 9
        Me.LbAccountBalance.Text = "Account Balance"
        '
        'LbAccountDetails
        '
        Me.LbAccountDetails.AutoSize = True
        Me.LbAccountDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LbAccountDetails.Location = New System.Drawing.Point(327, 73)
        Me.LbAccountDetails.Name = "LbAccountDetails"
        Me.LbAccountDetails.Size = New System.Drawing.Size(153, 25)
        Me.LbAccountDetails.TabIndex = 11
        Me.LbAccountDetails.Text = "Account Details "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 36)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Accounts"
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(18, 361)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(73, 59)
        Me.BtnPrint.TabIndex = 13
        Me.BtnPrint.Text = "Print Accounts "
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BntAddInterest
        '
        Me.BntAddInterest.Location = New System.Drawing.Point(212, 361)
        Me.BntAddInterest.Name = "BntAddInterest"
        Me.BntAddInterest.Size = New System.Drawing.Size(73, 59)
        Me.BntAddInterest.TabIndex = 14
        Me.BntAddInterest.Text = "Add Interest"
        Me.BntAddInterest.UseVisualStyleBackColor = True
        '
        'BtnCreateAccount
        '
        Me.BtnCreateAccount.Location = New System.Drawing.Point(113, 361)
        Me.BtnCreateAccount.Name = "BtnCreateAccount"
        Me.BtnCreateAccount.Size = New System.Drawing.Size(73, 59)
        Me.BtnCreateAccount.TabIndex = 15
        Me.BtnCreateAccount.Text = "Create Account"
        Me.BtnCreateAccount.UseVisualStyleBackColor = True
        '
        'LbAccountList
        '
        Me.LbAccountList.AutoSize = True
        Me.LbAccountList.Location = New System.Drawing.Point(15, 73)
        Me.LbAccountList.Name = "LbAccountList"
        Me.LbAccountList.Size = New System.Drawing.Size(62, 13)
        Me.LbAccountList.TabIndex = 17
        Me.LbAccountList.Text = "Account list"
        '
        'TxtAccountList
        '
        Me.TxtAccountList.Location = New System.Drawing.Point(17, 89)
        Me.TxtAccountList.Multiline = True
        Me.TxtAccountList.Name = "TxtAccountList"
        Me.TxtAccountList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAccountList.Size = New System.Drawing.Size(213, 218)
        Me.TxtAccountList.TabIndex = 16
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(468, 361)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(73, 59)
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BankAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LbAccountList)
        Me.Controls.Add(Me.TxtAccountList)
        Me.Controls.Add(Me.BtnCreateAccount)
        Me.Controls.Add(Me.BntAddInterest)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbAccountDetails)
        Me.Controls.Add(Me.TxtAccountBalance)
        Me.Controls.Add(Me.LbAccountBalance)
        Me.Controls.Add(Me.TxtAccountInterestRate)
        Me.Controls.Add(Me.LbAccountInterestRate)
        Me.Controls.Add(Me.TxtCountry)
        Me.Controls.Add(Me.LbAccount_Country)
        Me.Controls.Add(Me.TxtAccountNumber)
        Me.Controls.Add(Me.LbAccountNumber)
        Me.Controls.Add(Me.LbAccountName)
        Me.Controls.Add(Me.TxtAccountHolder)
        Me.Name = "BankAccountsForm"
        Me.Text = "BankAccountsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtAccountHolder As Windows.Forms.TextBox
    Friend WithEvents LbAccountName As Windows.Forms.Label
    Friend WithEvents LbAccountNumber As Windows.Forms.Label
    Friend WithEvents TxtAccountNumber As Windows.Forms.TextBox
    Friend WithEvents TxtCountry As Windows.Forms.TextBox
    Friend WithEvents LbAccount_Country As Windows.Forms.Label
    Friend WithEvents TxtAccountInterestRate As Windows.Forms.TextBox
    Friend WithEvents LbAccountInterestRate As Windows.Forms.Label
    Friend WithEvents TxtAccountBalance As Windows.Forms.TextBox
    Friend WithEvents LbAccountBalance As Windows.Forms.Label
    Friend WithEvents LbAccountDetails As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents BtnPrint As Windows.Forms.Button
    Friend WithEvents BntAddInterest As Windows.Forms.Button
    Friend WithEvents BtnCreateAccount As Windows.Forms.Button
    Friend WithEvents LbAccountList As Windows.Forms.Label
    Friend WithEvents TxtAccountList As Windows.Forms.TextBox
    Friend WithEvents BtnExit As Windows.Forms.Button
End Class
