<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmXboxGamingGrp
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
        Me.txt1stName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtMiddInitial = New System.Windows.Forms.TextBox()
        Me.lblMiddInitial = New System.Windows.Forms.Label()
        Me.lstNumberOfMonBox = New System.Windows.Forms.NumericUpDown()
        Me.lstSubscriptionType = New System.Windows.Forms.ListBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnSelectMembership = New System.Windows.Forms.Button()
        Me.btnClearSelection = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblCostPerMonth = New System.Windows.Forms.Label()
        Me.lblNumOfMonths = New System.Windows.Forms.Label()
        Me.lblSubscriptionType = New System.Windows.Forms.Label()
        Me.lblSubScriptionTotal = New System.Windows.Forms.Label()
        Me.lblDisplayTotal = New System.Windows.Forms.Label()
        CType(Me.lstNumberOfMonBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt1stName
        '
        Me.txt1stName.Location = New System.Drawing.Point(474, 127)
        Me.txt1stName.Name = "txt1stName"
        Me.txt1stName.Size = New System.Drawing.Size(109, 20)
        Me.txt1stName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(474, 221)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(109, 20)
        Me.txtLastName.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(474, 107)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(474, 201)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name"
        '
        'txtMiddInitial
        '
        Me.txtMiddInitial.Location = New System.Drawing.Point(474, 174)
        Me.txtMiddInitial.Name = "txtMiddInitial"
        Me.txtMiddInitial.Size = New System.Drawing.Size(22, 20)
        Me.txtMiddInitial.TabIndex = 2
        '
        'lblMiddInitial
        '
        Me.lblMiddInitial.AutoSize = True
        Me.lblMiddInitial.Location = New System.Drawing.Point(474, 154)
        Me.lblMiddInitial.Name = "lblMiddInitial"
        Me.lblMiddInitial.Size = New System.Drawing.Size(25, 13)
        Me.lblMiddInitial.TabIndex = 3
        Me.lblMiddInitial.Text = "M.I."
        '
        'lstNumberOfMonBox
        '
        Me.lstNumberOfMonBox.Location = New System.Drawing.Point(474, 268)
        Me.lstNumberOfMonBox.Name = "lstNumberOfMonBox"
        Me.lstNumberOfMonBox.Size = New System.Drawing.Size(36, 20)
        Me.lstNumberOfMonBox.TabIndex = 4
        Me.lstNumberOfMonBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lstSubscriptionType
        '
        Me.lstSubscriptionType.FormattingEnabled = True
        Me.lstSubscriptionType.Items.AddRange(New Object() {"Single Subscription", "Family Subscription(4 member max)", "Xbox Developer Subscripition"})
        Me.lstSubscriptionType.Location = New System.Drawing.Point(474, 315)
        Me.lstSubscriptionType.Name = "lstSubscriptionType"
        Me.lstSubscriptionType.Size = New System.Drawing.Size(167, 43)
        Me.lstSubscriptionType.TabIndex = 5
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(63, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(367, 25)
        Me.lblHeading.TabIndex = 6
        Me.lblHeading.Text = "XBox Membership Selection Form"
        '
        'btnSelectMembership
        '
        Me.btnSelectMembership.ForeColor = System.Drawing.Color.Black
        Me.btnSelectMembership.Location = New System.Drawing.Point(68, 335)
        Me.btnSelectMembership.Name = "btnSelectMembership"
        Me.btnSelectMembership.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectMembership.TabIndex = 7
        Me.btnSelectMembership.Text = "Confirm"
        Me.btnSelectMembership.UseVisualStyleBackColor = True
        '
        'btnClearSelection
        '
        Me.btnClearSelection.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClearSelection.ForeColor = System.Drawing.Color.Black
        Me.btnClearSelection.Location = New System.Drawing.Point(209, 335)
        Me.btnClearSelection.Name = "btnClearSelection"
        Me.btnClearSelection.Size = New System.Drawing.Size(75, 23)
        Me.btnClearSelection.TabIndex = 7
        Me.btnClearSelection.Text = "Clear"
        Me.btnClearSelection.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(330, 335)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblCostPerMonth
        '
        Me.lblCostPerMonth.AutoSize = True
        Me.lblCostPerMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerMonth.ForeColor = System.Drawing.Color.DarkRed
        Me.lblCostPerMonth.Location = New System.Drawing.Point(65, 59)
        Me.lblCostPerMonth.Name = "lblCostPerMonth"
        Me.lblCostPerMonth.Size = New System.Drawing.Size(222, 13)
        Me.lblCostPerMonth.TabIndex = 8
        Me.lblCostPerMonth.Text = "$XX a month for selected subscription"
        '
        'lblNumOfMonths
        '
        Me.lblNumOfMonths.AutoSize = True
        Me.lblNumOfMonths.Location = New System.Drawing.Point(474, 248)
        Me.lblNumOfMonths.Name = "lblNumOfMonths"
        Me.lblNumOfMonths.Size = New System.Drawing.Size(96, 13)
        Me.lblNumOfMonths.TabIndex = 9
        Me.lblNumOfMonths.Text = "Number Of Months"
        '
        'lblSubscriptionType
        '
        Me.lblSubscriptionType.AutoSize = True
        Me.lblSubscriptionType.Location = New System.Drawing.Point(474, 295)
        Me.lblSubscriptionType.Name = "lblSubscriptionType"
        Me.lblSubscriptionType.Size = New System.Drawing.Size(92, 13)
        Me.lblSubscriptionType.TabIndex = 10
        Me.lblSubscriptionType.Text = "Subscription Type"
        '
        'lblSubScriptionTotal
        '
        Me.lblSubScriptionTotal.AutoSize = True
        Me.lblSubScriptionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubScriptionTotal.ForeColor = System.Drawing.Color.LimeGreen
        Me.lblSubScriptionTotal.Location = New System.Drawing.Point(65, 107)
        Me.lblSubScriptionTotal.Name = "lblSubScriptionTotal"
        Me.lblSubScriptionTotal.Size = New System.Drawing.Size(110, 13)
        Me.lblSubScriptionTotal.TabIndex = 11
        Me.lblSubScriptionTotal.Text = "Subscription Total"
        '
        'lblDisplayTotal
        '
        Me.lblDisplayTotal.AutoSize = True
        Me.lblDisplayTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplayTotal.Location = New System.Drawing.Point(65, 134)
        Me.lblDisplayTotal.Name = "lblDisplayTotal"
        Me.lblDisplayTotal.Size = New System.Drawing.Size(90, 31)
        Me.lblDisplayTotal.TabIndex = 12
        Me.lblDisplayTotal.Text = "$XXX "
        '
        'frmXboxGamingGrp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CancelButton = Me.btnClearSelection
        Me.ClientSize = New System.Drawing.Size(646, 423)
        Me.Controls.Add(Me.lblDisplayTotal)
        Me.Controls.Add(Me.lblSubScriptionTotal)
        Me.Controls.Add(Me.lblSubscriptionType)
        Me.Controls.Add(Me.lblNumOfMonths)
        Me.Controls.Add(Me.lblCostPerMonth)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClearSelection)
        Me.Controls.Add(Me.btnSelectMembership)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.lstSubscriptionType)
        Me.Controls.Add(Me.lstNumberOfMonBox)
        Me.Controls.Add(Me.lblMiddInitial)
        Me.Controls.Add(Me.txtMiddInitial)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txt1stName)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmXboxGamingGrp"
        Me.Text = "Form1"
        CType(Me.lstNumberOfMonBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1stName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtMiddInitial As TextBox
    Friend WithEvents lblMiddInitial As Label
    Friend WithEvents lstNumberOfMonBox As NumericUpDown
    Friend WithEvents lstSubscriptionType As ListBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnSelectMembership As Button
    Friend WithEvents btnClearSelection As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCostPerMonth As Label
    Friend WithEvents lblNumOfMonths As Label
    Friend WithEvents lblSubscriptionType As Label
    Friend WithEvents lblSubScriptionTotal As Label
    Friend WithEvents lblDisplayTotal As Label
End Class
