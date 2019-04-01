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
        Me.Btn_Rand = New System.Windows.Forms.Button()
        Me.LstBx = New System.Windows.Forms.ListBox()
        Me.ChkBx_Delay = New System.Windows.Forms.CheckBox()
        Me.Btn_BubbleSort = New System.Windows.Forms.Button()
        Me.Btn_SelectSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Rand
        '
        Me.Btn_Rand.Location = New System.Drawing.Point(247, 82)
        Me.Btn_Rand.Name = "Btn_Rand"
        Me.Btn_Rand.Size = New System.Drawing.Size(113, 54)
        Me.Btn_Rand.TabIndex = 1
        Me.Btn_Rand.Text = "Randomise Order"
        Me.Btn_Rand.UseVisualStyleBackColor = True
        '
        'LstBx
        '
        Me.LstBx.FormattingEnabled = True
        Me.LstBx.ItemHeight = 16
        Me.LstBx.Location = New System.Drawing.Point(703, 12)
        Me.LstBx.Name = "LstBx"
        Me.LstBx.Size = New System.Drawing.Size(594, 692)
        Me.LstBx.TabIndex = 2
        '
        'ChkBx_Delay
        '
        Me.ChkBx_Delay.AutoSize = True
        Me.ChkBx_Delay.Enabled = False
        Me.ChkBx_Delay.Location = New System.Drawing.Point(172, 184)
        Me.ChkBx_Delay.Name = "ChkBx_Delay"
        Me.ChkBx_Delay.Size = New System.Drawing.Size(291, 21)
        Me.ChkBx_Delay.TabIndex = 4
        Me.ChkBx_Delay.Text = "Show Each Compaison with a 0.25s delay"
        Me.ChkBx_Delay.UseVisualStyleBackColor = True
        '
        'Btn_BubbleSort
        '
        Me.Btn_BubbleSort.Location = New System.Drawing.Point(96, 276)
        Me.Btn_BubbleSort.Name = "Btn_BubbleSort"
        Me.Btn_BubbleSort.Size = New System.Drawing.Size(113, 54)
        Me.Btn_BubbleSort.TabIndex = 5
        Me.Btn_BubbleSort.Text = "Bubble Sort"
        Me.Btn_BubbleSort.UseVisualStyleBackColor = True
        '
        'Btn_SelectSort
        '
        Me.Btn_SelectSort.Location = New System.Drawing.Point(404, 276)
        Me.Btn_SelectSort.Name = "Btn_SelectSort"
        Me.Btn_SelectSort.Size = New System.Drawing.Size(113, 54)
        Me.Btn_SelectSort.TabIndex = 6
        Me.Btn_SelectSort.Text = "Selection Sort"
        Me.Btn_SelectSort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 719)
        Me.Controls.Add(Me.Btn_SelectSort)
        Me.Controls.Add(Me.Btn_BubbleSort)
        Me.Controls.Add(Me.ChkBx_Delay)
        Me.Controls.Add(Me.LstBx)
        Me.Controls.Add(Me.Btn_Rand)
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
End Class
