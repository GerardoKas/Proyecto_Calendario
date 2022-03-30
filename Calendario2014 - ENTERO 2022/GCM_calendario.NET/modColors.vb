Option Strict Off
Option Explicit On
Module modColors
	Public colors As Object
	Public total As Short
	
	Public Function getColors() As Object
		If total = 0 Then
			'UPGRADE_WARNING: Array tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto colors. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			colors = New Object(){"FFFFFF", "FFFF00", "FF0000", "00FF00", "00FFFF", "FF00FF", "0000FF", "000000"}
			total = UBound(colors)
		End If
		
	End Function
	
	Public Function addColorHex(ByRef value As String) As Object
		Dim i As Object
		For i = 0 To UBound(colors)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto colors(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If UCase(colors(i)) = UCase(value) Then Exit Function
		Next 
		total = total + 1
		ReDim Preserve colors(total)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto colors(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		colors(total) = value
	End Function
	
	Public Sub showColors(ByRef pic As System.Windows.Forms.PictureBox)
		Dim n As Object
		Dim c As Object
		Dim i As Object
		getColors()
		'UPGRADE_ISSUE: No se actualizó la constante vbPixels. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: PictureBox propiedad pic.ScaleMode no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        '	pic.ScaleMode = vbPixels
		'UPGRADE_ISSUE: PictureBox propiedad pic.DrawWidth no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.DrawWidth = 16
		'UPGRADE_ISSUE: PictureBox propiedad pic.FillStyle no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'pic.FillStyle = 0
		For i = 0 To UBound(colors)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto colors(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto c. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			c = colors(i)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto c. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If c <> -1 Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto b(c). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto g(c). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto r(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'pic.ForeColor = System.Drawing.ColorTranslator.FromOle(RGB(r(c), g(c), b(c)))
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				n = i * 16 + 8
				'UPGRADE_ISSUE: PictureBox método pic.Line no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
                'pic.Line (n, 0) - (n, VB6.PixelsToTwipsY(pic.ClientRectangle.Height))
			End If
		Next 
	End Sub
	
	
	
	Public Function toDec(ByRef value As Object) As Object
		Dim vdec2 As Object
		Dim vdec1 As Object
		Dim i As Object
		Dim v2 As Object
		Dim v1 As Object
		Dim valores As Object
		On Error GoTo ErrValue
		
		'UPGRADE_WARNING: Array tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto valores. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		valores = New Object(){0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "A", "B", "C", "D", "E", "F"}
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If value = "" Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto toDec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			toDec = 0 : Exit Function
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		v1 = Left(value, 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		v2 = Right(value, 1)
		
		For i = 0 To 16
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto valores(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If UCase(v1) = CStr(valores(i)) Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto vdec1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				vdec1 = i
				Exit For
			End If
		Next 
		
		For i = 0 To 16
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto valores(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If UCase(v2) = CStr(valores(i)) Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto vdec2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				vdec2 = i
				Exit For
			End If
		Next 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto vdec2. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto vdec1. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto toDec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		toDec = vdec1 * 15 + vdec2
		Exit Function
ErrValue: 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MsgBox("Ha ocurrido un error al traducir el siguiente valor 'hexadecimal' :" & value & vbCrLf & "No se pueden leer nombres de color")
	End Function
	
	Public Function r(ByRef v As Object) As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		r = Mid(v, 1, 2)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto toDec(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		r = toDec(r)
	End Function
	
	
	Public Function g(ByRef v As Object) As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		g = Mid(v, 3, 2)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto toDec(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		g = toDec(g)
	End Function
	
	
	Public Function b(ByRef v As Object) As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto v. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		b = Mid(v, 5, 2)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto toDec(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		b = toDec(b)
	End Function
End Module