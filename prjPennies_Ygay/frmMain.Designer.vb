<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblDollar = New System.Windows.Forms.TextBox()
        Me.lblQuarters = New System.Windows.Forms.TextBox()
        Me.lblDimes = New System.Windows.Forms.TextBox()
        Me.lblNickles = New System.Windows.Forms.TextBox()
        Me.lblPennies = New System.Windows.Forms.TextBox()
        Me.Calculate = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Pennies"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dollars:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Quarters:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Dimes:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(76, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nickles:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(76, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pennies:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(142, 48)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(117, 20)
        Me.txtAmount.TabIndex = 6
        '
        'lblDollar
        '
        Me.lblDollar.Location = New System.Drawing.Point(142, 118)
        Me.lblDollar.Name = "lblDollar"
        Me.lblDollar.ReadOnly = True
        Me.lblDollar.Size = New System.Drawing.Size(117, 20)
        Me.lblDollar.TabIndex = 7
        '
        'lblQuarters
        '
        Me.lblQuarters.Location = New System.Drawing.Point(142, 165)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.ReadOnly = True
        Me.lblQuarters.Size = New System.Drawing.Size(117, 20)
        Me.lblQuarters.TabIndex = 8
        '
        'lblDimes
        '
        Me.lblDimes.Location = New System.Drawing.Point(142, 209)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.ReadOnly = True
        Me.lblDimes.Size = New System.Drawing.Size(117, 20)
        Me.lblDimes.TabIndex = 9
        '
        'lblNickles
        '
        Me.lblNickles.Location = New System.Drawing.Point(142, 253)
        Me.lblNickles.Name = "lblNickles"
        Me.lblNickles.ReadOnly = True
        Me.lblNickles.Size = New System.Drawing.Size(117, 20)
        Me.lblNickles.TabIndex = 10
        '
        'lblPennies
        '
        Me.lblPennies.Location = New System.Drawing.Point(142, 292)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.ReadOnly = True
        Me.lblPennies.Size = New System.Drawing.Size(117, 20)
        Me.lblPennies.TabIndex = 11
        '
        'Calculate
        '
        Me.Calculate.Location = New System.Drawing.Point(12, 333)
        Me.Calculate.Name = "Calculate"
        Me.Calculate.Size = New System.Drawing.Size(67, 31)
        Me.Calculate.TabIndex = 12
        Me.Calculate.Text = "Calculate"
        Me.Calculate.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(95, 333)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(67, 31)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(180, 333)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(67, 31)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 333)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(67, 31)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 387)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Calculate)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickles)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblDollar)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.Text = "                                 Money Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblDollar As TextBox
    Friend WithEvents lblQuarters As TextBox
    Friend WithEvents lblDimes As TextBox
    Friend WithEvents lblNickles As TextBox
    Friend WithEvents lblPennies As TextBox
    Friend WithEvents Calculate As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
