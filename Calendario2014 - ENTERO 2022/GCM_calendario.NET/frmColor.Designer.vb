<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmColor
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Picture1 As System.Windows.Forms.PictureBox
	Public WithEvents _HScroll1_0 As System.Windows.Forms.HScrollBar
	Public WithEvents _HScroll1_1 As System.Windows.Forms.HScrollBar
	Public WithEvents _HScroll1_2 As System.Windows.Forms.HScrollBar
	Public WithEvents cmdTransp As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents _Text1_2 As System.Windows.Forms.TextBox
	Public WithEvents _Text1_1 As System.Windows.Forms.TextBox
	Public WithEvents _Text1_0 As System.Windows.Forms.TextBox
	Public WithEvents _Label2_2 As System.Windows.Forms.Label
	Public WithEvents _Label2_1 As System.Windows.Forms.Label
	Public WithEvents _Label2_0 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents HScroll1 As Microsoft.VisualBasic.Compatibility.VB6.HScrollBarArray
	Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Text1 As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmColor))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Picture1 = New System.Windows.Forms.PictureBox
        Me._HScroll1_0 = New System.Windows.Forms.HScrollBar
        Me._HScroll1_1 = New System.Windows.Forms.HScrollBar
        Me._HScroll1_2 = New System.Windows.Forms.HScrollBar
        Me.cmdTransp = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me._Text1_2 = New System.Windows.Forms.TextBox
        Me._Text1_1 = New System.Windows.Forms.TextBox
        Me._Text1_0 = New System.Windows.Forms.TextBox
        Me._Label2_2 = New System.Windows.Forms.Label
        Me._Label2_1 = New System.Windows.Forms.Label
        Me._Label2_0 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.HScroll1 = New Microsoft.VisualBasic.Compatibility.VB6.HScrollBarArray(Me.components)
        Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(Me.components)
        Me.Text1 = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(Me.components)
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HScroll1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Text1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture1
        '
        Me.Picture1.BackColor = System.Drawing.SystemColors.Control
        Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Picture1.Location = New System.Drawing.Point(3, 87)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Picture1.Size = New System.Drawing.Size(307, 19)
        Me.Picture1.TabIndex = 12
        '
        '_HScroll1_0
        '
        Me._HScroll1_0.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScroll1.SetIndex(Me._HScroll1_0, CType(0, Short))
        Me._HScroll1_0.LargeChange = 16
        Me._HScroll1_0.Location = New System.Drawing.Point(40, 15)
        Me._HScroll1_0.Maximum = 270
        Me._HScroll1_0.Name = "_HScroll1_0"
        Me._HScroll1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._HScroll1_0.Size = New System.Drawing.Size(169, 10)
        Me._HScroll1_0.SmallChange = 6
        Me._HScroll1_0.TabIndex = 8
        Me._HScroll1_0.TabStop = True
        '
        '_HScroll1_1
        '
        Me._HScroll1_1.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScroll1.SetIndex(Me._HScroll1_1, CType(1, Short))
        Me._HScroll1_1.LargeChange = 16
        Me._HScroll1_1.Location = New System.Drawing.Point(40, 40)
        Me._HScroll1_1.Maximum = 270
        Me._HScroll1_1.Name = "_HScroll1_1"
        Me._HScroll1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._HScroll1_1.Size = New System.Drawing.Size(169, 10)
        Me._HScroll1_1.SmallChange = 6
        Me._HScroll1_1.TabIndex = 7
        Me._HScroll1_1.TabStop = True
        '
        '_HScroll1_2
        '
        Me._HScroll1_2.Cursor = System.Windows.Forms.Cursors.Default
        Me.HScroll1.SetIndex(Me._HScroll1_2, CType(2, Short))
        Me._HScroll1_2.LargeChange = 16
        Me._HScroll1_2.Location = New System.Drawing.Point(40, 66)
        Me._HScroll1_2.Maximum = 270
        Me._HScroll1_2.Name = "_HScroll1_2"
        Me._HScroll1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._HScroll1_2.Size = New System.Drawing.Size(169, 10)
        Me._HScroll1_2.SmallChange = 6
        Me._HScroll1_2.TabIndex = 6
        Me._HScroll1_2.TabStop = True
        '
        'cmdTransp
        '
        Me.cmdTransp.BackColor = System.Drawing.SystemColors.Control
        Me.cmdTransp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTransp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTransp.Location = New System.Drawing.Point(258, 9)
        Me.cmdTransp.Name = "cmdTransp"
        Me.cmdTransp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTransp.Size = New System.Drawing.Size(49, 22)
        Me.cmdTransp.TabIndex = 5
        Me.cmdTransp.Text = "Transp."
        Me.cmdTransp.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(258, 60)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(49, 22)
        Me.Command1.TabIndex = 3
        Me.Command1.Text = "Aceptar"
        Me.Command1.UseVisualStyleBackColor = False
        '
        '_Text1_2
        '
        Me._Text1_2.AcceptsReturn = True
        Me._Text1_2.BackColor = System.Drawing.SystemColors.Window
        Me._Text1_2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text1_2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.SetIndex(Me._Text1_2, CType(2, Short))
        Me._Text1_2.Location = New System.Drawing.Point(213, 57)
        Me._Text1_2.MaxLength = 0
        Me._Text1_2.Name = "_Text1_2"
        Me._Text1_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text1_2.Size = New System.Drawing.Size(31, 19)
        Me._Text1_2.TabIndex = 2
        Me._Text1_2.Text = "00"
        '
        '_Text1_1
        '
        Me._Text1_1.AcceptsReturn = True
        Me._Text1_1.BackColor = System.Drawing.SystemColors.Window
        Me._Text1_1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text1_1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.SetIndex(Me._Text1_1, CType(1, Short))
        Me._Text1_1.Location = New System.Drawing.Point(213, 33)
        Me._Text1_1.MaxLength = 0
        Me._Text1_1.Name = "_Text1_1"
        Me._Text1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text1_1.Size = New System.Drawing.Size(31, 19)
        Me._Text1_1.TabIndex = 1
        Me._Text1_1.Text = "00"
        '
        '_Text1_0
        '
        Me._Text1_0.AcceptsReturn = True
        Me._Text1_0.BackColor = System.Drawing.SystemColors.Window
        Me._Text1_0.Cursor = System.Windows.Forms.Cursors.IBeam
        Me._Text1_0.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Text1.SetIndex(Me._Text1_0, CType(0, Short))
        Me._Text1_0.Location = New System.Drawing.Point(213, 9)
        Me._Text1_0.MaxLength = 0
        Me._Text1_0.Name = "_Text1_0"
        Me._Text1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Text1_0.Size = New System.Drawing.Size(31, 19)
        Me._Text1_0.TabIndex = 0
        Me._Text1_0.Text = "00"
        '
        '_Label2_2
        '
        Me._Label2_2.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_2, CType(2, Short))
        Me._Label2_2.Location = New System.Drawing.Point(3, 63)
        Me._Label2_2.Name = "_Label2_2"
        Me._Label2_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_2.Size = New System.Drawing.Size(40, 16)
        Me._Label2_2.TabIndex = 11
        Me._Label2_2.Text = "AZUL"
        '
        '_Label2_1
        '
        Me._Label2_1.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_1, CType(1, Short))
        Me._Label2_1.Location = New System.Drawing.Point(3, 36)
        Me._Label2_1.Name = "_Label2_1"
        Me._Label2_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_1.Size = New System.Drawing.Size(40, 16)
        Me._Label2_1.TabIndex = 10
        Me._Label2_1.Text = "VERDE"
        '
        '_Label2_0
        '
        Me._Label2_0.BackColor = System.Drawing.SystemColors.Control
        Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.SetIndex(Me._Label2_0, CType(0, Short))
        Me._Label2_0.Location = New System.Drawing.Point(3, 12)
        Me._Label2_0.Name = "_Label2_0"
        Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label2_0.Size = New System.Drawing.Size(40, 16)
        Me._Label2_0.TabIndex = 9
        Me._Label2_0.Text = "ROJO"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(258, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "COLOR"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'HScroll1
        '
        '
        'frmColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(517, 295)
        Me.Controls.Add(Me.Picture1)
        Me.Controls.Add(Me._HScroll1_0)
        Me.Controls.Add(Me._HScroll1_1)
        Me.Controls.Add(Me._HScroll1_2)
        Me.Controls.Add(Me.cmdTransp)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me._Text1_2)
        Me.Controls.Add(Me._Text1_1)
        Me.Controls.Add(Me._Text1_0)
        Me.Controls.Add(Me._Label2_2)
        Me.Controls.Add(Me._Label2_1)
        Me.Controls.Add(Me._Label2_0)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmColor"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form2"
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HScroll1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Text1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class