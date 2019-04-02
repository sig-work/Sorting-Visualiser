<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Btn_Rand = New System.Windows.Forms.Button()
        Me.LstBx = New System.Windows.Forms.ListBox()
        Me.ChkBx_Delay = New System.Windows.Forms.CheckBox()
        Me.Btn_BubbleSort = New System.Windows.Forms.Button()
        Me.Btn_SelectSort = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Btn_Rand
        '
        Me.Btn_Rand.Location = New System.Drawing.Point(185, 67)
        Me.Btn_Rand.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_Rand.Name = "Btn_Rand"
        Me.Btn_Rand.Size = New System.Drawing.Size(85, 44)
        Me.Btn_Rand.TabIndex = 1
        Me.Btn_Rand.Text = "Randomise Order"
        Me.Btn_Rand.UseVisualStyleBackColor = True
        '
        'LstBx
        '
        Me.LstBx.FormattingEnabled = True
        Me.LstBx.Location = New System.Drawing.Point(527, 10)
        Me.LstBx.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LstBx.Name = "LstBx"
        Me.LstBx.Size = New System.Drawing.Size(446, 563)
        Me.LstBx.TabIndex = 2
        '
        'ChkBx_Delay
        '
        Me.ChkBx_Delay.AutoSize = True
        Me.ChkBx_Delay.Enabled = False
        Me.ChkBx_Delay.Location = New System.Drawing.Point(129, 150)
        Me.ChkBx_Delay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ChkBx_Delay.Name = "ChkBx_Delay"
        Me.ChkBx_Delay.Size = New System.Drawing.Size(224, 17)
        Me.ChkBx_Delay.TabIndex = 4
        Me.ChkBx_Delay.Text = "Show Each Compaison with a 0.25s delay"
        Me.ChkBx_Delay.UseVisualStyleBackColor = True
        '
        'Btn_BubbleSort
        '
        Me.Btn_BubbleSort.Location = New System.Drawing.Point(72, 224)
        Me.Btn_BubbleSort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_BubbleSort.Name = "Btn_BubbleSort"
        Me.Btn_BubbleSort.Size = New System.Drawing.Size(85, 44)
        Me.Btn_BubbleSort.TabIndex = 5
        Me.Btn_BubbleSort.Text = "Bubble Sort"
        Me.Btn_BubbleSort.UseVisualStyleBackColor = True
        '
        'Btn_SelectSort
        '
        Me.Btn_SelectSort.Location = New System.Drawing.Point(303, 224)
        Me.Btn_SelectSort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Btn_SelectSort.Name = "Btn_SelectSort"
        Me.Btn_SelectSort.Size = New System.Drawing.Size(85, 44)
        Me.Btn_SelectSort.TabIndex = 6
        Me.Btn_SelectSort.Text = "Selection Sort"
        Me.Btn_SelectSort.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 584)
        Me.Controls.Add(Me.Btn_SelectSort)
        Me.Controls.Add(Me.Btn_BubbleSort)
        Me.Controls.Add(Me.ChkBx_Delay)
        Me.Controls.Add(Me.LstBx)
        Me.Controls.Add(Me.Btn_Rand)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_Rand As Button
    Friend WithEvents LstBx As ListBox
    Friend WithEvents ChkBx_Delay As CheckBox
    Friend WithEvents Btn_BubbleSort As Button
    Friend WithEvents Btn_SelectSort As Button
    Friend WithEvents Timer As Timer
End Class
