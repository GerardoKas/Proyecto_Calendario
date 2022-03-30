Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmColor
	Inherits System.Windows.Forms.Form
	Public hexColor As String
	Public Red As String
	Public Green As String
	Public Blue As String
	Public Event Seleccionado(ByRef hexColor As Object)
	Private colors As Object
	Public ObjetoStylo As mshtml.HTMLStyleSheetRule
	Public ReglaStylo As Object
	
	Public Sub loadObj(ByRef obj As Object)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto obj. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ReglaStylo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ReglaStylo = obj
	End Sub
	
	Private Sub frmColor_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		showColors(Picture1)
	End Sub
	
	Private Sub cmdTransp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTransp.Click
		hexColor = "transparent"
		Me.Close()
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Red = Text1(0).Text
		Green = Text1(1).Text
		Blue = Text1(2).Text
		hexColor = Red & Green & Blue
		addColorHex(hexColor)
		Me.Close()
	End Sub
	
	Public Function setColorHTML(ByRef HexValue As String) As Object
		Dim azul As String
		Dim verde As String
		Dim rojo As String
		If HexValue = "transparent" Then
			Exit Function
		End If
		If VB.Left(HexValue, 1) = "#" Then
			HexValue = VB.Right(HexValue, Len(HexValue) - 1)
		End If
		rojo = Mid(HexValue, 1, 2)
		verde = Mid(HexValue, 3, 2)
		azul = Mid(HexValue, 5, 2)
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto toDec(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HScroll1(0).Value = toDec(rojo)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto toDec(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HScroll1(1).Value = toDec(verde)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto toDec(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		HScroll1(2).Value = toDec(azul)
	End Function
	
	Public Function setColorDec(ByRef r As Object, ByRef g As Object, ByRef b As Object) As Object
		HScroll1(0).Value = (r)
		HScroll1(1).Value = (g)
		HScroll1(2).Value = (b)
	End Function
	
	'UPGRADE_NOTE: HScroll1.Change pasó de ser un evento a un procedimiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: HScrollBar evento HScroll1.Change tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub HScroll1_Change(ByRef Index As Short, ByVal newScrollValue As Integer)
		'UPGRADE_WARNING: No se puede resolver el nombre del control HScroll1( Index ). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="42E71AA3-6BB8-4B87-8DF8-4566652145AA"'
		Text1(Index).Text = Hex(HScroll1(Index).Value)
		If Len(Text1(Index).Text) = 1 Then Text1(Index).Text = "0" & Text1(Index).Text
		'UPGRADE_WARNING: No se puede resolver el nombre del control HScroll1( 2 ). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="42E71AA3-6BB8-4B87-8DF8-4566652145AA"'
		'UPGRADE_WARNING: No se puede resolver el nombre del control HScroll1( 1 ). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="42E71AA3-6BB8-4B87-8DF8-4566652145AA"'
		'UPGRADE_WARNING: No se puede resolver el nombre del control HScroll1( 0 ). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="42E71AA3-6BB8-4B87-8DF8-4566652145AA"'
		Label1.BackColor = System.Drawing.ColorTranslator.FromOle(RGB(HScroll1(0).Value, HScroll1(1).Value, HScroll1(2).Value))
		Label1.Text = Text1(0).Text & Text1(1).Text & Text1(2).Text
		Select Case Index
			Case 0
				'UPGRADE_WARNING: No se puede resolver el nombre del control HScroll1( 0 ). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="42E71AA3-6BB8-4B87-8DF8-4566652145AA"'
				Label2(0).BackColor = System.Drawing.ColorTranslator.FromOle(RGB(HScroll1(0).Value, 0, 0))
			Case 1
				'UPGRADE_WARNING: No se puede resolver el nombre del control HScroll1( 1 ). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="42E71AA3-6BB8-4B87-8DF8-4566652145AA"'
				Label2(1).BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, HScroll1(1).Value, 0))
			Case 2
				'UPGRADE_WARNING: No se puede resolver el nombre del control HScroll1( 2 ). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="42E71AA3-6BB8-4B87-8DF8-4566652145AA"'
				Label2(2).BackColor = System.Drawing.ColorTranslator.FromOle(RGB(0, 0, HScroll1(2).Value))
		End Select
	End Sub
	
	
	Private Sub Picture1_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Picture1.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = VB6.PixelsToTwipsX(eventArgs.X)
		Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
		Dim Col As Object
		Dim este As Object
		Dim pos As Integer
		'total = (UBound(colors) + 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto este. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		este = Int(X / 16)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto este. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If este > UBound(modColors.colors) Then Exit Sub
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto modColors.colors(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Col. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Col = modColors.colors(este)
		setColorDec(r(Col), g(Col), b(Col))
	End Sub
	Private Sub HScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll1.Scroll
		Dim Index As Short = HScroll1.GetIndex(eventSender)
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				HScroll1_Change(Index, eventArgs.newValue)
		End Select
    End Sub
    Private Function getDocsFolder() As String
        Return My.Computer.FileSystem.SpecialDirectories.MyDocuments
    End Function
End Class