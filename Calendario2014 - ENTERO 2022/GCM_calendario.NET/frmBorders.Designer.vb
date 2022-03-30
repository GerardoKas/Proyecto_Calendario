<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmBorders
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
	Public WithEvents cmdRematar As System.Windows.Forms.Button
	Public WithEvents cmdAplicar As System.Windows.Forms.Button
	Public WithEvents scrollMargin As System.Windows.Forms.HScrollBar
	Public WithEvents scrollPadding As System.Windows.Forms.HScrollBar
	Public WithEvents cmdColor As System.Windows.Forms.Button
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents HScroll1 As System.Windows.Forms.HScrollBar
	Public WithEvents webX As System.Windows.Forms.WebBrowser
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBorders))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdRematar = New System.Windows.Forms.Button
		Me.cmdAplicar = New System.Windows.Forms.Button
		Me.scrollMargin = New System.Windows.Forms.HScrollBar
		Me.scrollPadding = New System.Windows.Forms.HScrollBar
		Me.cmdColor = New System.Windows.Forms.Button
		Me.Combo1 = New System.Windows.Forms.ComboBox
		Me.HScroll1 = New System.Windows.Forms.HScrollBar
		Me.webX = New System.Windows.Forms.WebBrowser
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.Text = "Form2"
		Me.ClientSize = New System.Drawing.Size(312, 213)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.Icon = CType(resources.GetObject("frmBorders.Icon"), System.Drawing.Icon)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmBorders"
		Me.cmdRematar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRematar.Text = "Aplicar"
		Me.cmdRematar.Size = New System.Drawing.Size(55, 22)
		Me.cmdRematar.Location = New System.Drawing.Point(237, 180)
		Me.cmdRematar.TabIndex = 12
		Me.cmdRematar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdRematar.CausesValidation = True
		Me.cmdRematar.Enabled = True
		Me.cmdRematar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdRematar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRematar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdRematar.TabStop = True
		Me.cmdRematar.Name = "cmdRematar"
		Me.cmdAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdAplicar.Text = "Probar"
		Me.AcceptButton = Me.cmdAplicar
		Me.cmdAplicar.Size = New System.Drawing.Size(64, 22)
		Me.cmdAplicar.Location = New System.Drawing.Point(162, 180)
		Me.cmdAplicar.TabIndex = 11
		Me.cmdAplicar.BackColor = System.Drawing.SystemColors.Control
		Me.cmdAplicar.CausesValidation = True
		Me.cmdAplicar.Enabled = True
		Me.cmdAplicar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdAplicar.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdAplicar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdAplicar.TabStop = True
		Me.cmdAplicar.Name = "cmdAplicar"
		Me.scrollMargin.Size = New System.Drawing.Size(80, 13)
		Me.scrollMargin.LargeChange = 5
		Me.scrollMargin.Location = New System.Drawing.Point(9, 192)
		Me.scrollMargin.Maximum = 64
		Me.scrollMargin.TabIndex = 9
		Me.scrollMargin.CausesValidation = True
		Me.scrollMargin.Enabled = True
		Me.scrollMargin.Minimum = 0
		Me.scrollMargin.Cursor = System.Windows.Forms.Cursors.Default
		Me.scrollMargin.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scrollMargin.SmallChange = 1
		Me.scrollMargin.TabStop = True
		Me.scrollMargin.Value = 0
		Me.scrollMargin.Visible = True
		Me.scrollMargin.Name = "scrollMargin"
		Me.scrollPadding.Size = New System.Drawing.Size(80, 13)
		Me.scrollPadding.LargeChange = 5
		Me.scrollPadding.Location = New System.Drawing.Point(9, 153)
		Me.scrollPadding.Maximum = 64
		Me.scrollPadding.TabIndex = 7
		Me.scrollPadding.CausesValidation = True
		Me.scrollPadding.Enabled = True
		Me.scrollPadding.Minimum = 0
		Me.scrollPadding.Cursor = System.Windows.Forms.Cursors.Default
		Me.scrollPadding.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.scrollPadding.SmallChange = 1
		Me.scrollPadding.TabStop = True
		Me.scrollPadding.Value = 0
		Me.scrollPadding.Visible = True
		Me.scrollPadding.Name = "scrollPadding"
		Me.cmdColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdColor.Text = "Color"
		Me.cmdColor.Size = New System.Drawing.Size(76, 19)
		Me.cmdColor.Location = New System.Drawing.Point(12, 108)
		Me.cmdColor.TabIndex = 5
		Me.cmdColor.BackColor = System.Drawing.SystemColors.Control
		Me.cmdColor.CausesValidation = True
		Me.cmdColor.Enabled = True
		Me.cmdColor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdColor.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdColor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdColor.TabStop = True
		Me.cmdColor.Name = "cmdColor"
		Me.Combo1.Size = New System.Drawing.Size(88, 21)
		Me.Combo1.Location = New System.Drawing.Point(9, 21)
		Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.Combo1.TabIndex = 2
		Me.Combo1.BackColor = System.Drawing.SystemColors.Window
		Me.Combo1.CausesValidation = True
		Me.Combo1.Enabled = True
		Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Combo1.IntegralHeight = True
		Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Combo1.Sorted = False
		Me.Combo1.TabStop = True
		Me.Combo1.Visible = True
		Me.Combo1.Name = "Combo1"
		Me.HScroll1.Size = New System.Drawing.Size(80, 13)
		Me.HScroll1.LargeChange = 5
		Me.HScroll1.Location = New System.Drawing.Point(9, 66)
		Me.HScroll1.Maximum = 64
		Me.HScroll1.TabIndex = 1
		Me.HScroll1.CausesValidation = True
		Me.HScroll1.Enabled = True
		Me.HScroll1.Minimum = 0
		Me.HScroll1.Cursor = System.Windows.Forms.Cursors.Default
		Me.HScroll1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HScroll1.SmallChange = 1
		Me.HScroll1.TabStop = True
		Me.HScroll1.Value = 0
		Me.HScroll1.Visible = True
		Me.HScroll1.Name = "HScroll1"
		Me.webX.Size = New System.Drawing.Size(160, 145)
		Me.webX.Location = New System.Drawing.Point(141, 21)
		Me.webX.TabIndex = 0
		Me.webX.AllowWebBrowserDrop = True
		Me.webX.Name = "webX"
		Me.Label5.Text = "Margen (Espacio Externo)"
		Me.Label5.Size = New System.Drawing.Size(122, 13)
		Me.Label5.Location = New System.Drawing.Point(3, 177)
		Me.Label5.TabIndex = 10
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = True
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "Padding (Espacio Interno)"
		Me.Label4.Size = New System.Drawing.Size(122, 13)
		Me.Label4.Location = New System.Drawing.Point(3, 138)
		Me.Label4.TabIndex = 8
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = True
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "Color del Borde"
		Me.Label3.Size = New System.Drawing.Size(73, 16)
		Me.Label3.Location = New System.Drawing.Point(3, 90)
		Me.Label3.TabIndex = 6
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Grosor del Borde"
		Me.Label2.Size = New System.Drawing.Size(79, 13)
		Me.Label2.Location = New System.Drawing.Point(6, 51)
		Me.Label2.TabIndex = 4
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = True
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Tipo de Borde"
		Me.Label1.Size = New System.Drawing.Size(67, 13)
		Me.Label1.Location = New System.Drawing.Point(3, 6)
		Me.Label1.TabIndex = 3
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(cmdRematar)
		Me.Controls.Add(cmdAplicar)
		Me.Controls.Add(scrollMargin)
		Me.Controls.Add(scrollPadding)
		Me.Controls.Add(cmdColor)
		Me.Controls.Add(Combo1)
		Me.Controls.Add(HScroll1)
		Me.Controls.Add(webX)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class