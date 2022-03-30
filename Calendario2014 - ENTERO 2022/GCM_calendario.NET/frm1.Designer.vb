<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCalHTML
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
	Public WithEvents txtDebug As System.Windows.Forms.TextBox
	Public WithEvents cmbStyles As System.Windows.Forms.ComboBox
	Public WithEvents cmdFuente As System.Windows.Forms.Button
	Public WithEvents cmdColor As System.Windows.Forms.Button
	Public WithEvents cmdBack As System.Windows.Forms.Button
	Public WithEvents cmdImagen As System.Windows.Forms.Button
	Public WithEvents cmdSave As System.Windows.Forms.Button
	Public WithEvents cmdBordes As System.Windows.Forms.Button
	Public WithEvents lblCombo As System.Windows.Forms.Label
	Public WithEvents lblButtons As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdUpdate As System.Windows.Forms.Button
	Public cmdlOpen As System.Windows.Forms.OpenFileDialog
	Public cmdlSave As System.Windows.Forms.SaveFileDialog
	Public cmdlFont As System.Windows.Forms.FontDialog
	Public WithEvents web1 As System.Windows.Forms.WebBrowser
	Public WithEvents txtCss As System.Windows.Forms.TextBox
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCalHTML))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtDebug = New System.Windows.Forms.TextBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.cmbStyles = New System.Windows.Forms.ComboBox
        Me.cmdFuente = New System.Windows.Forms.Button
        Me.cmdColor = New System.Windows.Forms.Button
        Me.cmdBack = New System.Windows.Forms.Button
        Me.cmdImagen = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdBordes = New System.Windows.Forms.Button
        Me.lblCombo = New System.Windows.Forms.Label
        Me.lblButtons = New System.Windows.Forms.Label
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.cmdlOpen = New System.Windows.Forms.OpenFileDialog
        Me.cmdlSave = New System.Windows.Forms.SaveFileDialog
        Me.cmdlFont = New System.Windows.Forms.FontDialog
        Me.web1 = New System.Windows.Forms.WebBrowser
        Me.txtCss = New System.Windows.Forms.TextBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDebug
        '
        Me.txtDebug.AcceptsReturn = True
        Me.txtDebug.BackColor = System.Drawing.SystemColors.Window
        Me.txtDebug.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDebug.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDebug.Location = New System.Drawing.Point(6, 21)
        Me.txtDebug.MaxLength = 0
        Me.txtDebug.Multiline = True
        Me.txtDebug.Name = "txtDebug"
        Me.txtDebug.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDebug.Size = New System.Drawing.Size(220, 151)
        Me.txtDebug.TabIndex = 13
        Me.txtDebug.Text = "Debug"
        Me.txtDebug.Visible = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.cmbStyles)
        Me.Frame1.Controls.Add(Me.cmdFuente)
        Me.Frame1.Controls.Add(Me.cmdColor)
        Me.Frame1.Controls.Add(Me.cmdBack)
        Me.Frame1.Controls.Add(Me.cmdImagen)
        Me.Frame1.Controls.Add(Me.cmdSave)
        Me.Frame1.Controls.Add(Me.cmdBordes)
        Me.Frame1.Controls.Add(Me.lblCombo)
        Me.Frame1.Controls.Add(Me.lblButtons)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(0, 306)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(568, 94)
        Me.Frame1.TabIndex = 3
        Me.Frame1.TabStop = False
        '
        'cmbStyles
        '
        Me.cmbStyles.BackColor = System.Drawing.SystemColors.Window
        Me.cmbStyles.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbStyles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStyles.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbStyles.Location = New System.Drawing.Point(6, 12)
        Me.cmbStyles.Name = "cmbStyles"
        Me.cmbStyles.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbStyles.Size = New System.Drawing.Size(109, 21)
        Me.cmbStyles.TabIndex = 10
        '
        'cmdFuente
        '
        Me.cmdFuente.BackColor = System.Drawing.SystemColors.Control
        Me.cmdFuente.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFuente.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFuente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFuente.Location = New System.Drawing.Point(120, 12)
        Me.cmdFuente.Name = "cmdFuente"
        Me.cmdFuente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFuente.Size = New System.Drawing.Size(52, 19)
        Me.cmdFuente.TabIndex = 9
        Me.cmdFuente.Text = "Fuente"
        Me.cmdFuente.UseVisualStyleBackColor = False
        '
        'cmdColor
        '
        Me.cmdColor.BackColor = System.Drawing.SystemColors.Control
        Me.cmdColor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdColor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdColor.Location = New System.Drawing.Point(174, 12)
        Me.cmdColor.Name = "cmdColor"
        Me.cmdColor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdColor.Size = New System.Drawing.Size(73, 19)
        Me.cmdColor.TabIndex = 8
        Me.cmdColor.Text = "Color Texto"
        Me.cmdColor.UseVisualStyleBackColor = False
        '
        'cmdBack
        '
        Me.cmdBack.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBack.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBack.Location = New System.Drawing.Point(249, 12)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBack.Size = New System.Drawing.Size(73, 19)
        Me.cmdBack.TabIndex = 7
        Me.cmdBack.Text = "Color Fondo"
        Me.cmdBack.UseVisualStyleBackColor = False
        '
        'cmdImagen
        '
        Me.cmdImagen.BackColor = System.Drawing.SystemColors.Control
        Me.cmdImagen.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImagen.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdImagen.Location = New System.Drawing.Point(324, 12)
        Me.cmdImagen.Name = "cmdImagen"
        Me.cmdImagen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdImagen.Size = New System.Drawing.Size(97, 19)
        Me.cmdImagen.TabIndex = 6
        Me.cmdImagen.Text = "Imagen de Fondo"
        Me.cmdImagen.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Location = New System.Drawing.Point(414, 45)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(142, 34)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "Guardar Calendario"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdBordes
        '
        Me.cmdBordes.BackColor = System.Drawing.SystemColors.Control
        Me.cmdBordes.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdBordes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdBordes.Location = New System.Drawing.Point(423, 12)
        Me.cmdBordes.Name = "cmdBordes"
        Me.cmdBordes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdBordes.Size = New System.Drawing.Size(109, 19)
        Me.cmdBordes.TabIndex = 4
        Me.cmdBordes.Text = "Bordes y Espaciado"
        Me.cmdBordes.UseVisualStyleBackColor = False
        '
        'lblCombo
        '
        Me.lblCombo.BackColor = System.Drawing.SystemColors.Menu
        Me.lblCombo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCombo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCombo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblCombo.Location = New System.Drawing.Point(6, 36)
        Me.lblCombo.Name = "lblCombo"
        Me.lblCombo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCombo.Size = New System.Drawing.Size(137, 55)
        Me.lblCombo.TabIndex = 12
        Me.lblCombo.Text = "Label1"
        '
        'lblButtons
        '
        Me.lblButtons.BackColor = System.Drawing.SystemColors.Menu
        Me.lblButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblButtons.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblButtons.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblButtons.Location = New System.Drawing.Point(147, 36)
        Me.lblButtons.Name = "lblButtons"
        Me.lblButtons.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblButtons.Size = New System.Drawing.Size(256, 55)
        Me.lblButtons.TabIndex = 11
        Me.lblButtons.Text = "Descripcion del boton"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUpdate.Location = New System.Drawing.Point(3, 0)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUpdate.Size = New System.Drawing.Size(55, 19)
        Me.cmdUpdate.TabIndex = 2
        Me.cmdUpdate.Text = "Actualizar"
        Me.cmdUpdate.UseVisualStyleBackColor = False
        Me.cmdUpdate.Visible = False
        '
        'web1
        '
        Me.web1.Location = New System.Drawing.Point(0, 0)
        Me.web1.Name = "web1"
        Me.web1.Size = New System.Drawing.Size(565, 304)
        Me.web1.TabIndex = 0
        '
        'txtCss
        '
        Me.txtCss.AcceptsReturn = True
        Me.txtCss.BackColor = System.Drawing.SystemColors.Window
        Me.txtCss.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCss.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCss.Location = New System.Drawing.Point(222, 3)
        Me.txtCss.MaxLength = 0
        Me.txtCss.Multiline = True
        Me.txtCss.Name = "txtCss"
        Me.txtCss.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCss.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCss.Size = New System.Drawing.Size(310, 304)
        Me.txtCss.TabIndex = 1
        '
        'ColorDialog1
        '
        Me.ColorDialog1.Color = System.Drawing.Color.Maroon
        '
        'frmCalHTML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(571, 400)
        Me.Controls.Add(Me.txtDebug)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.cmdUpdate)
        Me.Controls.Add(Me.web1)
        Me.Controls.Add(Me.txtCss)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "frmCalHTML"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Form1"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
#End Region 
End Class