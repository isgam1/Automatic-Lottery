<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAutoLottery
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAutoLottery))
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblLine1PowerNum = New System.Windows.Forms.Label()
        Me.lblLine1Num2 = New System.Windows.Forms.Label()
        Me.lblLine1Num3 = New System.Windows.Forms.Label()
        Me.lblLine1Num4 = New System.Windows.Forms.Label()
        Me.lblLine1Num5 = New System.Windows.Forms.Label()
        Me.lblLine1Num1 = New System.Windows.Forms.Label()
        Me.lblLine2Num1 = New System.Windows.Forms.Label()
        Me.lblLine2Num5 = New System.Windows.Forms.Label()
        Me.lblLine2Num4 = New System.Windows.Forms.Label()
        Me.lblLine2Num3 = New System.Windows.Forms.Label()
        Me.lblLine2Num2 = New System.Windows.Forms.Label()
        Me.lblLine2PowerNum = New System.Windows.Forms.Label()
        Me.lblLine3PowerNum = New System.Windows.Forms.Label()
        Me.lblLine3Num2 = New System.Windows.Forms.Label()
        Me.lblLine3Num3 = New System.Windows.Forms.Label()
        Me.lblLine3Num4 = New System.Windows.Forms.Label()
        Me.lblLine3Num5 = New System.Windows.Forms.Label()
        Me.lblLine3Num1 = New System.Windows.Forms.Label()
        Me.lblLine4PowerNum = New System.Windows.Forms.Label()
        Me.lblLine4Num2 = New System.Windows.Forms.Label()
        Me.lblLine4Num3 = New System.Windows.Forms.Label()
        Me.lblLine4Num4 = New System.Windows.Forms.Label()
        Me.lblLine4Num5 = New System.Windows.Forms.Label()
        Me.lblLine4Num1 = New System.Windows.Forms.Label()
        Me.lblLine5PowerNum = New System.Windows.Forms.Label()
        Me.lblLine5Num2 = New System.Windows.Forms.Label()
        Me.lblLine5Num3 = New System.Windows.Forms.Label()
        Me.lblLine5Num4 = New System.Windows.Forms.Label()
        Me.lblLine5Num5 = New System.Windows.Forms.Label()
        Me.lblLine5Num1 = New System.Windows.Forms.Label()
        Me.lblLine1 = New System.Windows.Forms.Label()
        Me.lblLine5 = New System.Windows.Forms.Label()
        Me.lblLine4 = New System.Windows.Forms.Label()
        Me.lblLine3 = New System.Windows.Forms.Label()
        Me.lblLine2 = New System.Windows.Forms.Label()
        Me.btnBet = New System.Windows.Forms.Button()
        Me.lblDollarsBet = New System.Windows.Forms.Label()
        Me.lblBet = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tmrGetLine1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGetLine2 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGetLine3 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGetLine4 = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGetLine5 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(437, 176)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(395, 81)
        Me.btnPlay.TabIndex = 5
        Me.btnPlay.Text = "PLAY"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblLine1PowerNum
        '
        Me.lblLine1PowerNum.BackColor = System.Drawing.Color.Crimson
        Me.lblLine1PowerNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1PowerNum.ForeColor = System.Drawing.Color.White
        Me.lblLine1PowerNum.Location = New System.Drawing.Point(812, 309)
        Me.lblLine1PowerNum.Name = "lblLine1PowerNum"
        Me.lblLine1PowerNum.Size = New System.Drawing.Size(50, 50)
        Me.lblLine1PowerNum.TabIndex = 13
        Me.lblLine1PowerNum.Text = "0"
        Me.lblLine1PowerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine1Num2
        '
        Me.lblLine1Num2.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine1Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1Num2.Location = New System.Drawing.Point(588, 309)
        Me.lblLine1Num2.Name = "lblLine1Num2"
        Me.lblLine1Num2.Size = New System.Drawing.Size(50, 50)
        Me.lblLine1Num2.TabIndex = 12
        Me.lblLine1Num2.Text = "0"
        Me.lblLine1Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine1Num3
        '
        Me.lblLine1Num3.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine1Num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1Num3.Location = New System.Drawing.Point(644, 309)
        Me.lblLine1Num3.Name = "lblLine1Num3"
        Me.lblLine1Num3.Size = New System.Drawing.Size(50, 50)
        Me.lblLine1Num3.TabIndex = 11
        Me.lblLine1Num3.Text = "0"
        Me.lblLine1Num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine1Num4
        '
        Me.lblLine1Num4.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine1Num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1Num4.Location = New System.Drawing.Point(700, 309)
        Me.lblLine1Num4.Name = "lblLine1Num4"
        Me.lblLine1Num4.Size = New System.Drawing.Size(50, 50)
        Me.lblLine1Num4.TabIndex = 10
        Me.lblLine1Num4.Text = "0"
        Me.lblLine1Num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine1Num5
        '
        Me.lblLine1Num5.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine1Num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1Num5.Location = New System.Drawing.Point(756, 309)
        Me.lblLine1Num5.Name = "lblLine1Num5"
        Me.lblLine1Num5.Size = New System.Drawing.Size(50, 50)
        Me.lblLine1Num5.TabIndex = 9
        Me.lblLine1Num5.Text = "0"
        Me.lblLine1Num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine1Num1
        '
        Me.lblLine1Num1.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine1Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1Num1.Location = New System.Drawing.Point(532, 309)
        Me.lblLine1Num1.Name = "lblLine1Num1"
        Me.lblLine1Num1.Size = New System.Drawing.Size(50, 50)
        Me.lblLine1Num1.TabIndex = 8
        Me.lblLine1Num1.Text = "0"
        Me.lblLine1Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine2Num1
        '
        Me.lblLine2Num1.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine2Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2Num1.Location = New System.Drawing.Point(532, 374)
        Me.lblLine2Num1.Name = "lblLine2Num1"
        Me.lblLine2Num1.Size = New System.Drawing.Size(50, 50)
        Me.lblLine2Num1.TabIndex = 14
        Me.lblLine2Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine2Num5
        '
        Me.lblLine2Num5.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine2Num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2Num5.Location = New System.Drawing.Point(756, 374)
        Me.lblLine2Num5.Name = "lblLine2Num5"
        Me.lblLine2Num5.Size = New System.Drawing.Size(50, 50)
        Me.lblLine2Num5.TabIndex = 15
        Me.lblLine2Num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine2Num4
        '
        Me.lblLine2Num4.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine2Num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2Num4.Location = New System.Drawing.Point(700, 374)
        Me.lblLine2Num4.Name = "lblLine2Num4"
        Me.lblLine2Num4.Size = New System.Drawing.Size(50, 50)
        Me.lblLine2Num4.TabIndex = 16
        Me.lblLine2Num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine2Num3
        '
        Me.lblLine2Num3.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine2Num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2Num3.Location = New System.Drawing.Point(644, 374)
        Me.lblLine2Num3.Name = "lblLine2Num3"
        Me.lblLine2Num3.Size = New System.Drawing.Size(50, 50)
        Me.lblLine2Num3.TabIndex = 17
        Me.lblLine2Num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine2Num2
        '
        Me.lblLine2Num2.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine2Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2Num2.Location = New System.Drawing.Point(588, 374)
        Me.lblLine2Num2.Name = "lblLine2Num2"
        Me.lblLine2Num2.Size = New System.Drawing.Size(50, 50)
        Me.lblLine2Num2.TabIndex = 18
        Me.lblLine2Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine2PowerNum
        '
        Me.lblLine2PowerNum.BackColor = System.Drawing.Color.Crimson
        Me.lblLine2PowerNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2PowerNum.ForeColor = System.Drawing.Color.White
        Me.lblLine2PowerNum.Location = New System.Drawing.Point(812, 374)
        Me.lblLine2PowerNum.Name = "lblLine2PowerNum"
        Me.lblLine2PowerNum.Size = New System.Drawing.Size(50, 50)
        Me.lblLine2PowerNum.TabIndex = 19
        Me.lblLine2PowerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine3PowerNum
        '
        Me.lblLine3PowerNum.BackColor = System.Drawing.Color.Crimson
        Me.lblLine3PowerNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3PowerNum.ForeColor = System.Drawing.Color.White
        Me.lblLine3PowerNum.Location = New System.Drawing.Point(812, 438)
        Me.lblLine3PowerNum.Name = "lblLine3PowerNum"
        Me.lblLine3PowerNum.Size = New System.Drawing.Size(50, 50)
        Me.lblLine3PowerNum.TabIndex = 25
        Me.lblLine3PowerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine3Num2
        '
        Me.lblLine3Num2.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine3Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3Num2.Location = New System.Drawing.Point(588, 438)
        Me.lblLine3Num2.Name = "lblLine3Num2"
        Me.lblLine3Num2.Size = New System.Drawing.Size(50, 50)
        Me.lblLine3Num2.TabIndex = 24
        Me.lblLine3Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine3Num3
        '
        Me.lblLine3Num3.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine3Num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3Num3.Location = New System.Drawing.Point(644, 438)
        Me.lblLine3Num3.Name = "lblLine3Num3"
        Me.lblLine3Num3.Size = New System.Drawing.Size(50, 50)
        Me.lblLine3Num3.TabIndex = 23
        Me.lblLine3Num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine3Num4
        '
        Me.lblLine3Num4.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine3Num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3Num4.Location = New System.Drawing.Point(700, 438)
        Me.lblLine3Num4.Name = "lblLine3Num4"
        Me.lblLine3Num4.Size = New System.Drawing.Size(50, 50)
        Me.lblLine3Num4.TabIndex = 22
        Me.lblLine3Num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine3Num5
        '
        Me.lblLine3Num5.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine3Num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3Num5.Location = New System.Drawing.Point(756, 438)
        Me.lblLine3Num5.Name = "lblLine3Num5"
        Me.lblLine3Num5.Size = New System.Drawing.Size(50, 50)
        Me.lblLine3Num5.TabIndex = 21
        Me.lblLine3Num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine3Num1
        '
        Me.lblLine3Num1.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine3Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3Num1.Location = New System.Drawing.Point(532, 438)
        Me.lblLine3Num1.Name = "lblLine3Num1"
        Me.lblLine3Num1.Size = New System.Drawing.Size(50, 50)
        Me.lblLine3Num1.TabIndex = 20
        Me.lblLine3Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine4PowerNum
        '
        Me.lblLine4PowerNum.BackColor = System.Drawing.Color.Crimson
        Me.lblLine4PowerNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine4PowerNum.ForeColor = System.Drawing.Color.White
        Me.lblLine4PowerNum.Location = New System.Drawing.Point(812, 502)
        Me.lblLine4PowerNum.Name = "lblLine4PowerNum"
        Me.lblLine4PowerNum.Size = New System.Drawing.Size(50, 50)
        Me.lblLine4PowerNum.TabIndex = 31
        Me.lblLine4PowerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine4Num2
        '
        Me.lblLine4Num2.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine4Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine4Num2.Location = New System.Drawing.Point(588, 502)
        Me.lblLine4Num2.Name = "lblLine4Num2"
        Me.lblLine4Num2.Size = New System.Drawing.Size(50, 50)
        Me.lblLine4Num2.TabIndex = 30
        Me.lblLine4Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine4Num3
        '
        Me.lblLine4Num3.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine4Num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine4Num3.Location = New System.Drawing.Point(644, 502)
        Me.lblLine4Num3.Name = "lblLine4Num3"
        Me.lblLine4Num3.Size = New System.Drawing.Size(50, 50)
        Me.lblLine4Num3.TabIndex = 29
        Me.lblLine4Num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine4Num4
        '
        Me.lblLine4Num4.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine4Num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine4Num4.Location = New System.Drawing.Point(700, 502)
        Me.lblLine4Num4.Name = "lblLine4Num4"
        Me.lblLine4Num4.Size = New System.Drawing.Size(50, 50)
        Me.lblLine4Num4.TabIndex = 28
        Me.lblLine4Num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine4Num5
        '
        Me.lblLine4Num5.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine4Num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine4Num5.Location = New System.Drawing.Point(756, 502)
        Me.lblLine4Num5.Name = "lblLine4Num5"
        Me.lblLine4Num5.Size = New System.Drawing.Size(50, 50)
        Me.lblLine4Num5.TabIndex = 27
        Me.lblLine4Num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine4Num1
        '
        Me.lblLine4Num1.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine4Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine4Num1.Location = New System.Drawing.Point(532, 502)
        Me.lblLine4Num1.Name = "lblLine4Num1"
        Me.lblLine4Num1.Size = New System.Drawing.Size(50, 50)
        Me.lblLine4Num1.TabIndex = 26
        Me.lblLine4Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine5PowerNum
        '
        Me.lblLine5PowerNum.BackColor = System.Drawing.Color.Crimson
        Me.lblLine5PowerNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine5PowerNum.ForeColor = System.Drawing.Color.White
        Me.lblLine5PowerNum.Location = New System.Drawing.Point(812, 566)
        Me.lblLine5PowerNum.Name = "lblLine5PowerNum"
        Me.lblLine5PowerNum.Size = New System.Drawing.Size(50, 50)
        Me.lblLine5PowerNum.TabIndex = 37
        Me.lblLine5PowerNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine5Num2
        '
        Me.lblLine5Num2.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine5Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine5Num2.Location = New System.Drawing.Point(588, 566)
        Me.lblLine5Num2.Name = "lblLine5Num2"
        Me.lblLine5Num2.Size = New System.Drawing.Size(50, 50)
        Me.lblLine5Num2.TabIndex = 36
        Me.lblLine5Num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine5Num3
        '
        Me.lblLine5Num3.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine5Num3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine5Num3.Location = New System.Drawing.Point(644, 566)
        Me.lblLine5Num3.Name = "lblLine5Num3"
        Me.lblLine5Num3.Size = New System.Drawing.Size(50, 50)
        Me.lblLine5Num3.TabIndex = 35
        Me.lblLine5Num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine5Num4
        '
        Me.lblLine5Num4.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine5Num4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine5Num4.Location = New System.Drawing.Point(700, 566)
        Me.lblLine5Num4.Name = "lblLine5Num4"
        Me.lblLine5Num4.Size = New System.Drawing.Size(50, 50)
        Me.lblLine5Num4.TabIndex = 34
        Me.lblLine5Num4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine5Num5
        '
        Me.lblLine5Num5.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine5Num5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine5Num5.Location = New System.Drawing.Point(756, 566)
        Me.lblLine5Num5.Name = "lblLine5Num5"
        Me.lblLine5Num5.Size = New System.Drawing.Size(50, 50)
        Me.lblLine5Num5.TabIndex = 33
        Me.lblLine5Num5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine5Num1
        '
        Me.lblLine5Num1.BackColor = System.Drawing.SystemColors.Window
        Me.lblLine5Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine5Num1.Location = New System.Drawing.Point(532, 566)
        Me.lblLine5Num1.Name = "lblLine5Num1"
        Me.lblLine5Num1.Size = New System.Drawing.Size(50, 50)
        Me.lblLine5Num1.TabIndex = 32
        Me.lblLine5Num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLine1
        '
        Me.lblLine1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine1.Location = New System.Drawing.Point(382, 311)
        Me.lblLine1.Name = "lblLine1"
        Me.lblLine1.Size = New System.Drawing.Size(128, 46)
        Me.lblLine1.TabIndex = 38
        Me.lblLine1.Text = "Line 1"
        '
        'lblLine5
        '
        Me.lblLine5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine5.Location = New System.Drawing.Point(382, 576)
        Me.lblLine5.Name = "lblLine5"
        Me.lblLine5.Size = New System.Drawing.Size(128, 46)
        Me.lblLine5.TabIndex = 40
        Me.lblLine5.Text = "Line 5"
        '
        'lblLine4
        '
        Me.lblLine4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine4.Location = New System.Drawing.Point(382, 504)
        Me.lblLine4.Name = "lblLine4"
        Me.lblLine4.Size = New System.Drawing.Size(128, 46)
        Me.lblLine4.TabIndex = 41
        Me.lblLine4.Text = "Line 4"
        '
        'lblLine3
        '
        Me.lblLine3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine3.Location = New System.Drawing.Point(382, 440)
        Me.lblLine3.Name = "lblLine3"
        Me.lblLine3.Size = New System.Drawing.Size(128, 46)
        Me.lblLine3.TabIndex = 42
        Me.lblLine3.Text = "Line 3"
        '
        'lblLine2
        '
        Me.lblLine2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine2.Location = New System.Drawing.Point(382, 376)
        Me.lblLine2.Name = "lblLine2"
        Me.lblLine2.Size = New System.Drawing.Size(128, 46)
        Me.lblLine2.TabIndex = 43
        Me.lblLine2.Text = "Line 2"
        '
        'btnBet
        '
        Me.btnBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBet.Location = New System.Drawing.Point(97, 176)
        Me.btnBet.Name = "btnBet"
        Me.btnBet.Size = New System.Drawing.Size(205, 81)
        Me.btnBet.TabIndex = 44
        Me.btnBet.Text = "BET!"
        Me.btnBet.UseVisualStyleBackColor = True
        '
        'lblDollarsBet
        '
        Me.lblDollarsBet.AutoSize = True
        Me.lblDollarsBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollarsBet.Location = New System.Drawing.Point(105, 266)
        Me.lblDollarsBet.Name = "lblDollarsBet"
        Me.lblDollarsBet.Size = New System.Drawing.Size(168, 36)
        Me.lblDollarsBet.TabIndex = 45
        Me.lblDollarsBet.Text = "Dollars Bet:"
        '
        'lblBet
        '
        Me.lblBet.AutoSize = True
        Me.lblBet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBet.ForeColor = System.Drawing.Color.Crimson
        Me.lblBet.Location = New System.Drawing.Point(270, 266)
        Me.lblBet.Name = "lblBet"
        Me.lblBet.Size = New System.Drawing.Size(32, 36)
        Me.lblBet.TabIndex = 46
        Me.lblBet.Text = "0"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(966, 176)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(205, 81)
        Me.btnExit.TabIndex = 47
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tmrGetLine1
        '
        '
        'tmrGetLine2
        '
        '
        'tmrGetLine3
        '
        '
        'tmrGetLine4
        '
        '
        'tmrGetLine5
        '
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 62)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1234, 69)
        Me.lblTitle.TabIndex = 48
        Me.lblTitle.Text = "Automatic Lottery Simulator"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(12, 9)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(64, 25)
        Me.lblAbout.TabIndex = 49
        Me.lblAbout.Text = "About"
        '
        'frmAutoLottery
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1258, 664)
        Me.Controls.Add(Me.lblAbout)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblBet)
        Me.Controls.Add(Me.lblDollarsBet)
        Me.Controls.Add(Me.btnBet)
        Me.Controls.Add(Me.lblLine2)
        Me.Controls.Add(Me.lblLine3)
        Me.Controls.Add(Me.lblLine4)
        Me.Controls.Add(Me.lblLine5)
        Me.Controls.Add(Me.lblLine1)
        Me.Controls.Add(Me.lblLine5PowerNum)
        Me.Controls.Add(Me.lblLine5Num2)
        Me.Controls.Add(Me.lblLine5Num3)
        Me.Controls.Add(Me.lblLine5Num4)
        Me.Controls.Add(Me.lblLine5Num5)
        Me.Controls.Add(Me.lblLine5Num1)
        Me.Controls.Add(Me.lblLine4PowerNum)
        Me.Controls.Add(Me.lblLine4Num2)
        Me.Controls.Add(Me.lblLine4Num3)
        Me.Controls.Add(Me.lblLine4Num4)
        Me.Controls.Add(Me.lblLine4Num5)
        Me.Controls.Add(Me.lblLine4Num1)
        Me.Controls.Add(Me.lblLine3PowerNum)
        Me.Controls.Add(Me.lblLine3Num2)
        Me.Controls.Add(Me.lblLine3Num3)
        Me.Controls.Add(Me.lblLine3Num4)
        Me.Controls.Add(Me.lblLine3Num5)
        Me.Controls.Add(Me.lblLine3Num1)
        Me.Controls.Add(Me.lblLine2PowerNum)
        Me.Controls.Add(Me.lblLine2Num2)
        Me.Controls.Add(Me.lblLine2Num3)
        Me.Controls.Add(Me.lblLine2Num4)
        Me.Controls.Add(Me.lblLine2Num5)
        Me.Controls.Add(Me.lblLine2Num1)
        Me.Controls.Add(Me.lblLine1PowerNum)
        Me.Controls.Add(Me.lblLine1Num2)
        Me.Controls.Add(Me.lblLine1Num3)
        Me.Controls.Add(Me.lblLine1Num4)
        Me.Controls.Add(Me.lblLine1Num5)
        Me.Controls.Add(Me.lblLine1Num1)
        Me.Controls.Add(Me.btnPlay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAutoLottery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automatic Lottery Simulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As Button
    Friend WithEvents lblLine1PowerNum As Label
    Friend WithEvents lblLine1Num2 As Label
    Friend WithEvents lblLine1Num3 As Label
    Friend WithEvents lblLine1Num4 As Label
    Friend WithEvents lblLine1Num5 As Label
    Friend WithEvents lblLine1Num1 As Label
    Friend WithEvents lblLine2Num1 As Label
    Friend WithEvents lblLine2Num5 As Label
    Friend WithEvents lblLine2Num4 As Label
    Friend WithEvents lblLine2Num3 As Label
    Friend WithEvents lblLine2Num2 As Label
    Friend WithEvents lblLine2PowerNum As Label
    Friend WithEvents lblLine3PowerNum As Label
    Friend WithEvents lblLine3Num2 As Label
    Friend WithEvents lblLine3Num3 As Label
    Friend WithEvents lblLine3Num4 As Label
    Friend WithEvents lblLine3Num5 As Label
    Friend WithEvents lblLine3Num1 As Label
    Friend WithEvents lblLine4PowerNum As Label
    Friend WithEvents lblLine4Num2 As Label
    Friend WithEvents lblLine4Num3 As Label
    Friend WithEvents lblLine4Num4 As Label
    Friend WithEvents lblLine4Num5 As Label
    Friend WithEvents lblLine4Num1 As Label
    Friend WithEvents lblLine5PowerNum As Label
    Friend WithEvents lblLine5Num2 As Label
    Friend WithEvents lblLine5Num3 As Label
    Friend WithEvents lblLine5Num4 As Label
    Friend WithEvents lblLine5Num5 As Label
    Friend WithEvents lblLine5Num1 As Label
    Friend WithEvents lblLine1 As Label
    Friend WithEvents lblLine5 As Label
    Friend WithEvents lblLine4 As Label
    Friend WithEvents lblLine3 As Label
    Friend WithEvents lblLine2 As Label
    Friend WithEvents btnBet As Button
    Friend WithEvents lblDollarsBet As Label
    Friend WithEvents lblBet As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents tmrGetLine1 As Timer
    Friend WithEvents tmrGetLine2 As Timer
    Friend WithEvents tmrGetLine3 As Timer
    Friend WithEvents tmrGetLine4 As Timer
    Friend WithEvents tmrGetLine5 As Timer
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAbout As Label
End Class
