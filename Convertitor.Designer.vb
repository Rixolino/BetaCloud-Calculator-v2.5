<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Convertitor
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Convertitor))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitOfMeasureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(469, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.ScientificToolStripMenuItem, Me.UnitOfMeasureToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.NormalToolStripMenuItem.Text = "Normal"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'UnitOfMeasureToolStripMenuItem
        '
        Me.UnitOfMeasureToolStripMenuItem.Name = "UnitOfMeasureToolStripMenuItem"
        Me.UnitOfMeasureToolStripMenuItem.Size = New System.Drawing.Size(189, 26)
        Me.UnitOfMeasureToolStripMenuItem.Text = "Binary (Actual)"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 71)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(394, 80)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(12, 167)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(400, 80)
        Me.TextBox2.TabIndex = 2
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button17.Location = New System.Drawing.Point(154, 508)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(96, 53)
        Me.Button17.TabIndex = 83
        Me.Button17.Text = "0"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button16.Location = New System.Drawing.Point(270, 438)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(96, 53)
        Me.Button16.TabIndex = 82
        Me.Button16.Text = "9"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button9.Location = New System.Drawing.Point(270, 353)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 53)
        Me.Button9.TabIndex = 81
        Me.Button9.Text = "6"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button10.Location = New System.Drawing.Point(153, 353)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(96, 53)
        Me.Button10.TabIndex = 80
        Me.Button10.Text = "5"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button6.Location = New System.Drawing.Point(34, 353)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 53)
        Me.Button6.TabIndex = 79
        Me.Button6.Text = "4"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button7.Location = New System.Drawing.Point(270, 269)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 53)
        Me.Button7.TabIndex = 78
        Me.Button7.Text = "3"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button3.Location = New System.Drawing.Point(154, 269)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 53)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "2"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(34, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 53)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "1"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button12.Location = New System.Drawing.Point(154, 438)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(96, 53)
        Me.Button12.TabIndex = 86
        Me.Button12.Text = "8"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button13.Location = New System.Drawing.Point(34, 438)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(96, 53)
        Me.Button13.TabIndex = 85
        Me.Button13.Text = "7"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button14.Location = New System.Drawing.Point(34, 580)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(332, 57)
        Me.Button14.TabIndex = 87
        Me.Button14.Text = "="
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(568, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 32)
        Me.Label2.TabIndex = 89
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(435, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 32)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "="
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(12, 33)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(174, 29)
        Me.RadioButton1.TabIndex = 91
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Binary to Integer"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button21
        '
        Me.Button21.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(281, 521)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(85, 40)
        Me.Button21.TabIndex = 116
        Me.Button21.Text = "C"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(193, -4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 120
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Convertitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 723)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button21)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Convertitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BetaCloud Calculator (Converter)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitOfMeasureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button17 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button21 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
