<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.cmbLMakanan = New System.Windows.Forms.ComboBox()
        Me.cbxID = New System.Windows.Forms.CheckBox()
        Me.cmbLMinuman = New System.Windows.Forms.ComboBox()
        Me.labelMakanan = New System.Windows.Forms.Label()
        Me.labelMinuman = New System.Windows.Forms.Label()
        Me.lblJmlhMakanan = New System.Windows.Forms.Label()
        Me.lblJmlhMinuman = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPMkn = New System.Windows.Forms.Label()
        Me.lblPMnm = New System.Windows.Forms.Label()
        Me.txtTotalMkn = New System.Windows.Forms.TextBox()
        Me.txtTotalMnm = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbLMakanan
        '
        Me.cmbLMakanan.FormattingEnabled = True
        Me.cmbLMakanan.Items.AddRange(New Object() {"Nasi Uduk", "Bakso", "Mie Ayam"})
        Me.cmbLMakanan.Location = New System.Drawing.Point(139, 51)
        Me.cmbLMakanan.Name = "cmbLMakanan"
        Me.cmbLMakanan.Size = New System.Drawing.Size(156, 21)
        Me.cmbLMakanan.TabIndex = 0
        '
        'cbxID
        '
        Me.cbxID.AutoSize = True
        Me.cbxID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxID.Location = New System.Drawing.Point(139, 88)
        Me.cbxID.Name = "cbxID"
        Me.cbxID.Size = New System.Drawing.Size(109, 21)
        Me.cbxID.TabIndex = 1
        Me.cbxID.Text = "Include Drink"
        Me.cbxID.UseVisualStyleBackColor = True
        '
        'cmbLMinuman
        '
        Me.cmbLMinuman.FormattingEnabled = True
        Me.cmbLMinuman.Items.AddRange(New Object() {"Es Jeruk", "Jus Alpukat", "Es Teh Manis"})
        Me.cmbLMinuman.Location = New System.Drawing.Point(139, 122)
        Me.cmbLMinuman.Name = "cmbLMinuman"
        Me.cmbLMinuman.Size = New System.Drawing.Size(156, 21)
        Me.cmbLMinuman.TabIndex = 2
        Me.cmbLMinuman.Visible = False
        '
        'labelMakanan
        '
        Me.labelMakanan.AutoSize = True
        Me.labelMakanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMakanan.Location = New System.Drawing.Point(342, 57)
        Me.labelMakanan.Name = "labelMakanan"
        Me.labelMakanan.Size = New System.Drawing.Size(47, 17)
        Me.labelMakanan.TabIndex = 3
        Me.labelMakanan.Text = "Harga"
        '
        'labelMinuman
        '
        Me.labelMinuman.AutoSize = True
        Me.labelMinuman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMinuman.Location = New System.Drawing.Point(342, 126)
        Me.labelMinuman.Name = "labelMinuman"
        Me.labelMinuman.Size = New System.Drawing.Size(47, 17)
        Me.labelMinuman.TabIndex = 4
        Me.labelMinuman.Text = "Harga"
        Me.labelMinuman.Visible = False
        '
        'lblJmlhMakanan
        '
        Me.lblJmlhMakanan.AutoSize = True
        Me.lblJmlhMakanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlhMakanan.Location = New System.Drawing.Point(438, 57)
        Me.lblJmlhMakanan.Name = "lblJmlhMakanan"
        Me.lblJmlhMakanan.Size = New System.Drawing.Size(34, 17)
        Me.lblJmlhMakanan.TabIndex = 5
        Me.lblJmlhMakanan.Text = "Rp0"
        '
        'lblJmlhMinuman
        '
        Me.lblJmlhMinuman.AutoSize = True
        Me.lblJmlhMinuman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJmlhMinuman.Location = New System.Drawing.Point(438, 126)
        Me.lblJmlhMinuman.Name = "lblJmlhMinuman"
        Me.lblJmlhMinuman.Size = New System.Drawing.Size(34, 17)
        Me.lblJmlhMinuman.TabIndex = 6
        Me.lblJmlhMinuman.Text = "Rp0"
        Me.lblJmlhMinuman.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.btnHitung)
        Me.GroupBox1.Controls.Add(Me.txtTotalMnm)
        Me.GroupBox1.Controls.Add(Me.txtTotalMkn)
        Me.GroupBox1.Controls.Add(Me.lblPMnm)
        Me.GroupBox1.Controls.Add(Me.lblPMkn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(583, 323)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Pesanan"
        '
        'lblPMkn
        '
        Me.lblPMkn.AutoSize = True
        Me.lblPMkn.Location = New System.Drawing.Point(145, 93)
        Me.lblPMkn.Name = "lblPMkn"
        Me.lblPMkn.Size = New System.Drawing.Size(152, 17)
        Me.lblPMkn.TabIndex = 0
        Me.lblPMkn.Text = "Berapa Porsi Makanan"
        '
        'lblPMnm
        '
        Me.lblPMnm.AutoSize = True
        Me.lblPMnm.Location = New System.Drawing.Point(146, 147)
        Me.lblPMnm.Name = "lblPMnm"
        Me.lblPMnm.Size = New System.Drawing.Size(151, 17)
        Me.lblPMnm.TabIndex = 1
        Me.lblPMnm.Text = "Berapa Porsi Minuman"
        Me.lblPMnm.Visible = False
        '
        'txtTotalMkn
        '
        Me.txtTotalMkn.Location = New System.Drawing.Point(329, 90)
        Me.txtTotalMkn.Name = "txtTotalMkn"
        Me.txtTotalMkn.Size = New System.Drawing.Size(109, 23)
        Me.txtTotalMkn.TabIndex = 2
        '
        'txtTotalMnm
        '
        Me.txtTotalMnm.Location = New System.Drawing.Point(329, 144)
        Me.txtTotalMnm.Name = "txtTotalMnm"
        Me.txtTotalMnm.Size = New System.Drawing.Size(109, 23)
        Me.txtTotalMnm.TabIndex = 3
        Me.txtTotalMnm.Visible = False
        '
        'btnHitung
        '
        Me.btnHitung.BackColor = System.Drawing.Color.Goldenrod
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(172, 230)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(85, 34)
        Me.btnHitung.TabIndex = 4
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(330, 239)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(34, 17)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Rp0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 538)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblJmlhMinuman)
        Me.Controls.Add(Me.lblJmlhMakanan)
        Me.Controls.Add(Me.labelMinuman)
        Me.Controls.Add(Me.labelMakanan)
        Me.Controls.Add(Me.cmbLMinuman)
        Me.Controls.Add(Me.cbxID)
        Me.Controls.Add(Me.cmbLMakanan)
        Me.Name = "Form1"
        Me.Text = "Order Makanan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbLMakanan As ComboBox
    Friend WithEvents cbxID As CheckBox
    Friend WithEvents cmbLMinuman As ComboBox
    Friend WithEvents labelMakanan As Label
    Friend WithEvents labelMinuman As Label
    Friend WithEvents lblJmlhMakanan As Label
    Friend WithEvents lblJmlhMinuman As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents txtTotalMnm As TextBox
    Friend WithEvents txtTotalMkn As TextBox
    Friend WithEvents lblPMnm As Label
    Friend WithEvents lblPMkn As Label
End Class
