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
        Me.TxtAccountHolder.Location = New System.Drawing.Point(436, 165)
        Me.TxtAccountHolder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtAccountHolder.Name = "TxtAccountHolder"
        Me.TxtAccountHolder.Size = New System.Drawing.Size(283, 22)
        Me.TxtAccountHolder.TabIndex = 1
        '
        'LbAccountName
        '
        Me.LbAccountName.AutoSize = True
        Me.LbAccountName.Location = New System.Drawing.Point(433, 145)
        Me.LbAccountName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAccountName.Name = "LbAccountName"
        Me.LbAccountName.Size = New System.Drawing.Size(146, 17)
        Me.LbAccountName.TabIndex = 2
        Me.LbAccountName.Text = "Account Holder Name"
        '
        'LbAccountNumber
        '
        Me.LbAccountNumber.AutoSize = True
        Me.LbAccountNumber.Location = New System.Drawing.Point(433, 190)
        Me.LbAccountNumber.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAccountNumber.Name = "LbAccountNumber"
        Me.LbAccountNumber.Size = New System.Drawing.Size(113, 17)
        Me.LbAccountNumber.TabIndex = 3
        Me.LbAccountNumber.Text = "Account Number"
        '
        'TxtAccountNumber
        '
        Me.TxtAccountNumber.Location = New System.Drawing.Point(436, 209)
        Me.TxtAccountNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtAccountNumber.Name = "TxtAccountNumber"
        Me.TxtAccountNumber.Size = New System.Drawing.Size(283, 22)
        Me.TxtAccountNumber.TabIndex = 4
        '
        'TxtCountry
        '
        Me.TxtCountry.Location = New System.Drawing.Point(437, 257)
        Me.TxtCountry.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(283, 22)
        Me.TxtCountry.TabIndex = 6
        '
        'LbAccount_Country
        '
        Me.LbAccount_Country.AutoSize = True
        Me.LbAccount_Country.Location = New System.Drawing.Point(433, 238)
        Me.LbAccount_Country.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAccount_Country.Name = "LbAccount_Country"
        Me.LbAccount_Country.Size = New System.Drawing.Size(112, 17)
        Me.LbAccount_Country.TabIndex = 5
        Me.LbAccount_Country.Text = "Account Country"
        '
        'TxtAccountInterestRate
        '
        Me.TxtAccountInterestRate.Location = New System.Drawing.Point(439, 305)
        Me.TxtAccountInterestRate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtAccountInterestRate.Name = "TxtAccountInterestRate"
        Me.TxtAccountInterestRate.Size = New System.Drawing.Size(283, 22)
        Me.TxtAccountInterestRate.TabIndex = 8
        '
        'LbAccountInterestRate
        '
        Me.LbAccountInterestRate.AutoSize = True
        Me.LbAccountInterestRate.Location = New System.Drawing.Point(435, 286)
        Me.LbAccountInterestRate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAccountInterestRate.Name = "LbAccountInterestRate"
        Me.LbAccountInterestRate.Size = New System.Drawing.Size(144, 17)
        Me.LbAccountInterestRate.TabIndex = 7
        Me.LbAccountInterestRate.Text = "Account Interest Rate"
        '
        'TxtAccountBalance
        '
        Me.TxtAccountBalance.Location = New System.Drawing.Point(439, 353)
        Me.TxtAccountBalance.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtAccountBalance.Name = "TxtAccountBalance"
        Me.TxtAccountBalance.Size = New System.Drawing.Size(283, 22)
        Me.TxtAccountBalance.TabIndex = 10
        '
        'LbAccountBalance
        '
        Me.LbAccountBalance.AutoSize = True
        Me.LbAccountBalance.Location = New System.Drawing.Point(435, 334)
        Me.LbAccountBalance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAccountBalance.Name = "LbAccountBalance"
        Me.LbAccountBalance.Size = New System.Drawing.Size(114, 17)
        Me.LbAccountBalance.TabIndex = 9
        Me.LbAccountBalance.Text = "Account Balance"
        '
        'LbAccountDetails
        '
        Me.LbAccountDetails.AutoSize = True
        Me.LbAccountDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LbAccountDetails.Location = New System.Drawing.Point(436, 90)
        Me.LbAccountDetails.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAccountDetails.Name = "LbAccountDetails"
        Me.LbAccountDetails.Size = New System.Drawing.Size(197, 29)
        Me.LbAccountDetails.TabIndex = 11
        Me.LbAccountDetails.Text = "Account Details "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 45)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Accounts"
        '
        'BtnPrint
        '
        Me.BtnPrint.Location = New System.Drawing.Point(24, 444)
        Me.BtnPrint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(97, 73)
        Me.BtnPrint.TabIndex = 13
        Me.BtnPrint.Text = "Print Accounts "
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'BntAddInterest
        '
        Me.BntAddInterest.Location = New System.Drawing.Point(283, 444)
        Me.BntAddInterest.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BntAddInterest.Name = "BntAddInterest"
        Me.BntAddInterest.Size = New System.Drawing.Size(97, 73)
        Me.BntAddInterest.TabIndex = 14
        Me.BntAddInterest.Text = "Add Interest"
        Me.BntAddInterest.UseVisualStyleBackColor = True
        '
        'BtnCreateAccount
        '
        Me.BtnCreateAccount.Location = New System.Drawing.Point(151, 444)
        Me.BtnCreateAccount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCreateAccount.Name = "BtnCreateAccount"
        Me.BtnCreateAccount.Size = New System.Drawing.Size(97, 73)
        Me.BtnCreateAccount.TabIndex = 15
        Me.BtnCreateAccount.Text = "Create Account"
        Me.BtnCreateAccount.UseVisualStyleBackColor = True
        '
        'LbAccountList
        '
        Me.LbAccountList.AutoSize = True
        Me.LbAccountList.Location = New System.Drawing.Point(20, 90)
        Me.LbAccountList.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LbAccountList.Name = "LbAccountList"
        Me.LbAccountList.Size = New System.Drawing.Size(80, 17)
        Me.LbAccountList.TabIndex = 17
        Me.LbAccountList.Text = "Account list"
        '
        'TxtAccountList
        '
        Me.TxtAccountList.Location = New System.Drawing.Point(23, 110)
        Me.TxtAccountList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtAccountList.Multiline = True
        Me.TxtAccountList.Name = "TxtAccountList"
        Me.TxtAccountList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtAccountList.Size = New System.Drawing.Size(283, 267)
        Me.TxtAccountList.TabIndex = 16
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(624, 444)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(97, 73)
        Me.BtnExit.TabIndex = 18
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BankAccountsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 554)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
