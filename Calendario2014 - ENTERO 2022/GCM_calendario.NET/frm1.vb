Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmCalHTML
    Inherits System.Windows.Forms.Form
    Dim cmdl As Object
	Dim myHtml As String
	Dim myYear As Short
    Dim myColor As System.Drawing.Color
	Dim myFile As String
	Dim myFolder As String
	Dim myTempFile As String
	'Dim myTempFolder As String
	Dim myImages As New Collection
	Dim numImages As Short
	
	Dim objStyleSheet As mshtml.IHTMLStyleSheet
	Dim objCssRule As mshtml.HTMLStyleSheetRule
	
	Const juntarTrimestres As Short = 3
	'Dim WithEvents butones As CommandButton
	Const doDebug As Boolean = False
	
	Private Sub Cal_Html()
		Dim i As Object
		Dim mymonthName As Object
		Dim xday As Object
		Dim xweek As Object
		Dim xmonth As Object
		Dim xdate As Object
		Dim numDias As Integer
		If myYear = 0 Then myYear = DatePart(Microsoft.VisualBasic.DateInterval.Year, Now)
		
		
		Dim myDay As Short 'recorre los 365 dias
		numDias = 365
		If DatePart(Microsoft.VisualBasic.DateInterval.Month, DateSerial(myYear, 2, 29)) = 2 Then
			numDias = 366
		End If
		'addH myYear, "y"
		For myDay = 1 To numDias
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdate. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			xdate = DateSerial(myYear, 1, myDay)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdate. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xmonth. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			xmonth = DatePart(Microsoft.VisualBasic.DateInterval.Month, xdate, FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdate. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xweek. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			xweek = DatePart(Microsoft.VisualBasic.DateInterval.WeekDay, xdate, FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xdate. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xday. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			xday = DatePart(Microsoft.VisualBasic.DateInterval.Day, xdate, FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xweek. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If xweek = 1 Then
				'dia lunes... nueva semana
				addH("", "w")
			End If
			'nuevo mes
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xday. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If xday = 1 Then
				'si es uno se etiqueta un nuevo mes
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xmonth. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mymonthName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				mymonthName = MonthName(xmonth)
				addH(mymonthName, "m")
				addH("", "w")
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xweek. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If xweek <> 1 Then 'si empieza el mes en dia no lunes
					'movemos el cursor hacia ese dia
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xweek. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For i = 1 To xweek - 1
						addH("", "d")
					Next i
				End If
			End If
			' dia normal o festivo
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto xweek. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If xweek = 7 Then
				addH(xday, "df")
			Else
				addH(xday, "d")
			End If
			'mywday = WeekdayName(xweek)
			'MsgBox mywday
		Next myDay
		addH("", "e")
		Do While web1.IsBusy = True
			System.Windows.Forms.Application.DoEvents()
		Loop 
		
		'web1.Document.write myHtml
	End Sub
	
	
	Sub addH(ByRef cadena As Object, ByRef tipo As Object)
		Dim s As Object
		Static beganM As Boolean
		Static beganW As Boolean
		Static numTrim As Short
		Select Case tipo
			Case "y"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadena. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				s = "<table><td id=Anno align=center>" & cadena & "</td></table>"
			Case "d"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadena. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				s = "<td class=Dia align=right>" & cadena & "</td>"
			Case "df"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadena. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				s = "<td class=Festivo align=right>" & cadena & "</td>"
			Case "m"
				If beganM = True Then 'solo ocurre la segunda vez
					'desde la segunda vez hay qye cerrar las anteriores
					If beganW = True Then
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						s = s & "</tr>" 'cerramos la semana anterior
						beganW = False
					End If
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					s = s & "</table>" & vbCrLf 'cerramos el mes anterior
				End If
				If numTrim Mod juntarTrimestres = 0 Then
					'fin tabla trimestres
					If numTrim > 0 Then
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						s = s & "</table>" & vbCrLf
					End If
					'tabla para los trimestres
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					s = s & vbCrLf & "<table style='background-color:transparent' class=Trim><tr><td>"
				End If
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				s = s & vbCrLf & "<table align=left class=Mes>"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadena. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				s = s & "<tr><td colspan=7 align=center class=MesCabecera>" & UCase(cadena) & "</td></tr>"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto diasSemana(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				s = s & vbCrLf & "<tr>" & diasSemana() & "</tr>" 'los nombres de los dias
				beganM = True
				numTrim = numTrim + 1
			Case "w"
				If beganW = True Then
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					s = "</tr>"
				End If
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				s = s & "<tr class=Semana>"
				beganW = True
			Case "e"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				s = "</tr></table></table>"
		End Select
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		myHtml = myHtml & s & vbCrLf
	End Sub
	
	Function diasSemana() As Object
		Dim i As Object
		Dim s As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		s = ""
		For i = 1 To 7
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			s = s & "<td class=DiaCabecera>" & UCase(VB.Left(WeekDayName(i, True), 2)) & "</td>"
		Next 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto s. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto diasSemana. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		diasSemana = s
	End Function
	
	'UPGRADE_WARNING: El evento cmbStyles.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbStyles_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbStyles.SelectedIndexChanged
		Dim t As Object
		'DESCRIPCIONES DE AYUDA
		Select Case cmbStyles.Text
			Case "Body"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto t. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				t = "Se aplica a toda la pagina. Detras de todos los objetos"
			Case "#Anno"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto t. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				t = "La cabecera con el año"
			Case ".Mes"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto t. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				t = "Se aplica al recuadro del mes. Por detras de los dias. No aplica color de fondo"
			Case ".MesCabecera"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto t. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				t = "Nombre del Mes. Se puede poner color de fondo y fuente"
			Case ".Dia"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto t. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				t = "Recuadro de Dias del mes, salvo los festivos. Se pueden cambiar todas las propiedades"
			Case ".Festivo"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto t. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				t = "Los domingos, se puede tratar igual que los dias"
			Case ".DiaCabecera"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto t. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				t = "Los nombres de los dias. Se pueden cambiar todas las propiedades"
			Case ".Semana"
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto t. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				t = "Las Semanas. No aplica color de fondo ni fuentes, es el contenedor de los dias"
		End Select
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto t. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lblCombo.Text = t
		If objStyleSheet.rules.length > cmbStyles.SelectedIndex Then
			objCssRule = objStyleSheet.rules.item(cmbStyles.SelectedIndex)
		End If
	End Sub
	
	
	Private Sub cmdBack_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdBack.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		lblButtons.Text = "Color de Fondo del Objeto. No se aplica a mes, semana. Se puede aplicar en todos los demas"
	End Sub
	
	Private Sub cmdBordes_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdBordes.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		lblButtons.Text = "Aplica Tipo,Color,Grosor de Borde y espaciado del objeto. Se puede aplicar a cualquier objeto"
	End Sub
	
	Private Sub cmdColor_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdColor.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		lblButtons.Text = "Color del texto. No se aplica a los contenedores (mes,semana...). Solo en Dia,Festivo,DiaCabecera y MesCabecera"
	End Sub
	
	Private Sub cmdFuente_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdFuente.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		lblButtons.Text = "El tipo de fuente, tamaño y grosor"
	End Sub
	
	Private Sub cmdImagen_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdImagen.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		lblButtons.Text = "Imagen para poner en cualquier objeto. Pero mejor en uno de fondo (body,mes,semana...).Es preferible una imagen muy clarita o muy oscura y poner el texto con color adecuado"
	End Sub
	
	Private Sub frmCalHTML_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Object
		'UPGRADE_NOTE: my se actualizó a my_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim my_Renamed As Object
		
		'myTempFolder = "c:\windows\temp\"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto my. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If my_Renamed = "" Then
			myYear = Year(Now)
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto my. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			myYear = my_Renamed
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto my. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		my_Renamed = InputBox("De que año quieres realizar el Calendario?", "Elegir año para el Calendario", CStr(Year(Now) + 1))
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto my. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		myYear = my_Renamed
		
        myTempFile = getDocsFolder() & "\calendario.html"
		myHtml = "<html><!DOCTYPE HTML PUBLIC '-//W3C//DTD HTML 4.01 Transitional//EN'>"
		myHtml = myHtml & vbCrLf & "<head><title>Calendario de " & myYear & "</title></head>"
		myHtml = myHtml & "<body>" & vbCrLf & "<TABLE id=Toda align=center width=100%><caption id=Anno>" & myYear & "</caption><td align=center valign=center>" & vbCrLf
		Cal_Html()
		myHtml = myHtml & vbCrLf & "</td></table>" & vbCrLf & "</body></html>"
		savefile(myHtml, myTempFile)
		
		'myFile = savefile(myHtml, myFile)
		web1.Navigate(New System.URI(myTempFile))
		Do While Not web1.ReadyState = System.Windows.Forms.WebBrowserReadyState.Complete
			System.Windows.Forms.Application.DoEvents()
		Loop 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto web1.Document.createStyleSheet. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		objStyleSheet = web1.Document.DomDocument.createStyleSheet("calendario.css")
		
		With cmbStyles
			.Items.Insert(0, "Body")
			.Items.Insert(1, "#Anno")
			.Items.Insert(2, ".Mes")
			.Items.Insert(3, ".MesCabecera")
			.Items.Insert(4, ".Semana")
			.Items.Insert(5, ".Dia")
			.Items.Insert(6, ".DiaCabecera")
			.Items.Insert(7, ".Festivo")
		End With
		For i = 0 To cmbStyles.Items.Count - 1
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cmbStyles.SelectedIndex = i
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			objStyleSheet.addRule(VB6.GetItemString(cmbStyles, i), "color:black")
			setStyle_Renamed("background-Color", "transparent")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			myImages.Add("", VB6.GetItemString(cmbStyles, i))
		Next 
		cmbStyles.SelectedIndex = 0
		'frmBorders.Visible = True
	End Sub
	
	'UPGRADE_WARNING: El evento frmCalHTML.Resize se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub frmCalHTML_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
		On Error Resume Next
		web1.SetBounds(0, 0, Me.ClientRectangle.Width, VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.ClientRectangle.Height) - VB6.PixelsToTwipsY(Frame1.Height)))
		Frame1.SetBounds(0, web1.Height, Me.ClientRectangle.Width, 0, Windows.Forms.BoundsSpecified.X Or Windows.Forms.BoundsSpecified.Y Or Windows.Forms.BoundsSpecified.Width)
	End Sub
	
	Private Sub cmdBordes_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBordes.Click
		frmBorders.objCssRule2 = objStyleSheet.rules.item(cmbStyles.SelectedIndex)
		VB6.ShowForm(frmBorders, 1, Me)
	End Sub
	
	'--------------------------------------------------
	Private Sub txtCss_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCss.DoubleClick
		objStyleSheet.cssText = txtCss.Text
	End Sub
	
	Private Sub txtCss_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCss.Enter
		txtCss.BringToFront()
		txtCss.Text = objStyleSheet.cssText
	End Sub
	
	Private Sub txtCss_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCss.Leave
		txtCss.SendToBack()
	End Sub
	'--------------------------------------------------------
	
	Private Sub cmdFuente_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFuente.Click
        'UPGRADE_ISSUE: MSComDlg.CommonDialog propiedad cmdl.Flags no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'cmdl.Flags = &H3
		cmdlFont.ShowDialog()
		'aqui da errores de automatzaion
		objCssRule.Style.fontWeight = IIf(cmdlFont.Font.Bold, "900", "100")
		objCssRule.Style.fontFamily = cmdlFont.Font.Name
		objCssRule.Style.FontSize = cmdlFont.Font.Size
		objCssRule.Style.fontStyle = IIf(cmdlFont.Font.Italic, "", "normal")
	End Sub
	
	Private Sub cmdColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdColor.Click
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objStyleSheet.rules().Style.Color. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '  MsgBox(objStyleSheet.rules.item(cmbStyles.SelectedIndex).style.color)



        myColor = objStyleSheet.rules.item(cmbStyles.SelectedIndex).style.color

		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cargaColor(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        myColor = cargaColor(myColor)
		objCssRule.Style.Color = myColor
	End Sub
	
    'Private Sub mdBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBack.Click
    '    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objStyleSheet.rules().Style.backgroundColor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '    myColor = objStyleSheet.rules.item(cmbStyles.SelectedIndex).style.backgroundColor
    '    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cargaColor(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '    myColor = cargaColor()
    '    objCssRule.style.backgroundColor = "#" & myColor
    'End Sub

    'Private Function cargaColor() As Object
    '    frmColor.setColorHTML(myColor)
    '    'frmColor.loadObj (objStyleSheet.rules(cmbStyles.ListIndex).Style.backgroundColor)
    '    VB6.ShowForm(frmColor, 1, Me)
    '    'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cargaColor. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '    cargaColor = frmColor.hexColor
    'End Function
	
	
	Private Sub cmdImagen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImagen.Click
		Dim myimage As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cargarImagen(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto myimage. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		myimage = cargarImagen()
		'myfimage = copiarImagen(myimage, myTempFolder)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto myimage. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If myimage = "" Then Exit Sub
		myImages.Remove((cmbStyles.Text))
		myImages.Add(myimage, cmbStyles.Text)
		'aqui da eror de auromtaicacion
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto myimage. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		objCssRule.Style.backgroundImage = "url(" & myimage & ")"
	End Sub
	
	Private Sub cmdImagen_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdImagen.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		If Button = 2 Then
			'quitar imagen
			On Error Resume Next
			myImages.Remove((cmbStyles.Text))
			objCssRule.Style.backgroundImage = ""
			
		End If
	End Sub
	
	Private Sub cmdUpdate_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdUpdate.Click
		objStyleSheet.cssText = objStyleSheet.cssText
		web1.Refresh()
	End Sub
	
	Private Sub cmdSave_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.Click
		'como esta en codigo en el aire antes hay que guardarlo al disco duro
		''''
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto getSaveFileName(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		myFile = getSaveFileName()
		If myFile = "" Then
			MsgBox("No se ha guardado el calendario")
			Exit Sub
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto createHTMLFolder(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		myFolder = createHTMLFolder(myFile)
		saveImages(myImages, myFolder) 'modifica el css de url image
		saveAllPage(myFile)
		web1.Navigate(New System.URI(myFile))
		MsgBox("Se ha guardado el calendario en " & vbCrLf & myFile, MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "Gracias Por Usar Este Programa")
		
	End Sub
	
	Sub saveAllPage(ByRef fichero As String)
		Dim filetext As Object
		Dim css As Object
		Dim html As Object
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto web1.Document.body. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto html. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		html = web1.Document.DomDocument.body.innerHTML
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto css. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		css = objStyleSheet.cssText
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto html. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto css. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto filetext. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		filetext = "<style>" & vbCrLf & css & vbCrLf & "</style>" & vbCrLf & html
		savefile(filetext, fichero)
	End Sub
	
	Function getSaveFileName() As Object
		On Error GoTo ErrName
		cmdlOpen.DefaultExt = "*.html"
		cmdlSave.DefaultExt = "*.html"
		cmdlOpen.Title = "Guardar Calendario"
		cmdlSave.Title = "Guardar Calendario"
		cmdlOpen.CheckPathExists = True
		cmdlSave.CheckPathExists = True
		'UPGRADE_ISSUE: No se actualizó la constante cdlOFNExplorer. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="55B59875-9A95-4B71-9D6A-7C294BF7139D"'
		'UPGRADE_ISSUE: MSComDlg.CommonDialog propiedad cmdl.Flags no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'cmdl.Flags = MSComDlg.FileOpenConstants.cdlOFNExplorer
		'UPGRADE_WARNING: Filter tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		cmdlOpen.Filter = "Pagina Web Con Imagenes|*.html"
		cmdlSave.Filter = "Pagina Web Con Imagenes|*.html"
		cmdlOpen.FileName = "Calendario " & myYear
		cmdlSave.FileName = "Calendario " & myYear
		'UPGRADE_WARNING: La propiedad CancelError de CommonDialog no se admite en Visual Basic .NET. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="8B377936-3DF7-4745-AA26-DD00FA5B9BE1"'
		cmdl.CancelError = True
		cmdlSave.ShowDialog()
		cmdlOpen.FileName = cmdlSave.FileName
		'If cmdl.Flags And cdlOFNExtensionDifferent Then
		'    cmdl.FileName = cmdl.FileName & ".html"
		'End If
		If cmdlOpen.FileName = "" Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto getSaveFileName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			getSaveFileName = ""
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto getSaveFileName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			getSaveFileName = cmdlOpen.FileName
		End If
		Exit Function
ErrName: 
		If Err.Number = 32755 Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto getSaveFileName. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			getSaveFileName = ""
		Else
			MsgBox(Err.Number & vbCrLf & "Error Al Seleccionar archivo:" & vbCrLf & Err.Description)
		End If
	End Function
	
	Function savefile(ByRef texto As Object, ByRef fichero As Object) As Object
		Dim f As Short
		Dim fname As String
		f = FreeFile
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fichero. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If fichero <> "" Then
            'UPGRADE_WARichero, OpenMode.Output)
            FileOpen(f, fichero, OpenMode.Output)
            PrintLine(f, texto)   'warNING: No se puede resolver la propiedad predeterminada del objeto fichero. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

			FileClose(f)
		Else
			MsgBox("No se ha guardado el archivo")
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fichero. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto savefile. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		savefile = fichero
	End Function
	
	Function saveImages(ByRef colImages As Object, ByRef Directorio As Object) As Object
        Dim imname As String
        Dim file As String
        Dim i As Integer
        Dim dirBase As String
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto baseName(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto dirBase. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dirBase = baseName(Directorio)
		For i = 0 To cmbStyles.Items.Count - 1
			'cmbStyles.ListIndex = i
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto colImages.Item. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto file. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			file = colImages.Item(VB6.GetItemString(cmbStyles, i))
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto file. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If file <> "" Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto baseName(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto imname. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				imname = baseName(file)
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto imname. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Directorio. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto file. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				FileCopy(file, Directorio & "\" & imname)
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto imname. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto dirBase. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				setStyle_Renamed("background-image", "url(" & dirBase & "\" & imname & ")")
			End If
		Next 
	End Function
	
	Function baseName(ByRef file As Object) As Object
		Dim pos As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto file. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto pos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		pos = InStrRev(file, "\")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto pos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto file. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		baseName = VB.Right(file, Len(file) - pos)
	End Function
	
	Function copiarImagen(ByRef imagen As Object, ByRef Directorio As Object) As Object
		Dim pos As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto imagen. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto pos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		pos = InStrRev(imagen, "\")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto pos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto imagen. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		copiarImagen = VB.Right(imagen, Len(imagen) - pos)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto copiarImagen. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Directorio. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto imagen. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileCopy(imagen, Directorio & copiarImagen)
	End Function
	
	Function createHTMLFolder(ByRef file As Object) As Object
		Dim base As Object
		Dim pospunto As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto file. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto pospunto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		pospunto = InStrRev(file, ".")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto pospunto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto file. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto base. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		base = VB.Left(file, pospunto - 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto base. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto createHTMLFolder. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		createHTMLFolder = base & "_archivos"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto createHTMLFolder. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Dir tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(createHTMLFolder, FileAttribute.Directory) = "" Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto createHTMLFolder. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MkDir(createHTMLFolder)
		End If
	End Function
	
	'UPGRADE_NOTE: Text se actualizó a Text_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Private Sub web1_DocumentTitleChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles web1.DocumentTitleChanged
		Dim Text_Renamed As String = CType(eventSender, WebBrowser).DocumentTitle
		Me.Text = Text_Renamed
	End Sub
	
	'UPGRADE_NOTE: setStyle se actualizó a setStyle_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
	Function setStyle_Renamed(ByRef atributo As Object, ByRef value As Object) As Object
		Dim vbOKCance As Object
		Dim objindex As Object
		Dim obj As Object
		On Error GoTo UnError
		If cmbStyles.Text = "" Then
			MsgBox("Debes seleccionar una categoria en el recuadro")
			Exit Function
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto obj. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			obj = cmbStyles.Text
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objindex. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			objindex = cmbStyles.SelectedIndex
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto atributo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objindex. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		objStyleSheet.rules.item(objindex).Style.setAttribute(atributo, value)
		objStyleSheet.cssText = objStyleSheet.cssText
		txtCss.Text = objStyleSheet.cssText
		If doDebug = True Then
			txtDebug.Visible = True
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto value. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto atributo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtDebug.Text = txtDebug.Text & vbCrLf & atributo & ": " & value
		End If
		Exit Function
UnError: 
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto vbOKCance. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MsgBox("Ha ocurrido un error no controlado : " & vbCrLf & Err.Description, vbOKCance + MsgBoxStyle.Critical)
	End Function
	Function removeImage() As Object
		Dim objindex As Object
		Dim obj As Object
		
		If cmbStyles.Text = "" Then
			MsgBox("Debes seleccionar una categoria en el recuadro")
			Exit Function
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto obj. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			obj = cmbStyles.Text
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objindex. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			objindex = cmbStyles.SelectedIndex
		End If
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto objindex. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		objStyleSheet.rules.item(objindex).Style.backgroundImage = ""
		objStyleSheet.cssText = objStyleSheet.cssText
		txtCss.Text = objStyleSheet.cssText
	End Function
	
	Function cargarImagen() As Object
		'UPGRADE_WARNING: Filter tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		cmdlOpen.Filter = "Imagenes jpg gif bmp png|*.jpg;*.bmp;*.gif;*.png"
		cmdlSave.Filter = "Imagenes jpg gif bmp png|*.jpg;*.bmp;*.gif;*.png"
		cmdlOpen.Title = "Cargar Imagen de Fondo"
		cmdlSave.Title = "Cargar Imagen de Fondo"
		cmdlOpen.ShowDialog()
		cmdlSave.FileName = cmdlOpen.FileName
		If cmdlOpen.FileName <> "" Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cargarImagen. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cargarImagen = cmdlOpen.FileName
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cargarImagen. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cargarImagen = ""
		End If
	End Function

    Public Function getDocsFolder() As String
        Return My.Computer.FileSystem.SpecialDirectories.MyDocuments
    End Function

    Private Sub cmdBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBack.Click
        cargaColor(Color.AliceBlue)

    End Sub
    Public Function cargaColor(ByVal color As System.Drawing.Color) As System.Drawing.Color

        ColorDialog1.Color = color
        ColorDialog1.ShowDialog()
    End Function
End Class