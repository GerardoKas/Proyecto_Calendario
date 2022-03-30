Option Strict Off
Option Explicit On
Friend Class frmBorders
	Inherits System.Windows.Forms.Form
	Private myDoc As mshtml.HTMLDocument
	Private myStyleCss As mshtml.IHTMLStyleSheet
	Private myTipoCssRule As mshtml.HTMLStyleSheetRule
	Public objCssRule2 As mshtml.HTMLStyleSheetRule 'dat cagsad
	
	Private Sub cargaObjeto(ByRef obj As mshtml.HTMLStyleSheetRule)
		objCssRule2 = obj
		'MsgBox obj, vbCritical, "FAIL"
		With objCssRule2.Style
			myTipoCssRule.Style.BorderColor = .BorderColor
			myTipoCssRule.Style.BorderWidth = .BorderWidth
			myTipoCssRule.Style.BorderStyle = .BorderStyle
			myTipoCssRule.Style.padding = .padding
			myTipoCssRule.Style.margin = .margin
		End With
	End Sub
	Private Sub cmdAplicar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAplicar.Click
		objCssRule2.Style.BorderColor = myTipoCssRule.Style.BorderColor
		objCssRule2.Style.BorderStyle = myTipoCssRule.Style.BorderStyle
		objCssRule2.Style.BorderWidth = myTipoCssRule.Style.BorderWidth
		objCssRule2.Style.padding = myTipoCssRule.Style.padding
		objCssRule2.Style.margin = myTipoCssRule.Style.margin
	End Sub
	
	Private Sub cmdRematar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRematar.Click
		cmdAplicar_Click(cmdAplicar, New System.EventArgs())
		Me.Close()
	End Sub
	
	Private Sub frmBorders_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Object
		'Dim webX As HTMLDocument
		With Combo1
			.Items.Add("solid")
			.Items.Add("dotted")
			.Items.Add("dashed")
			.Items.Add("inset")
			.Items.Add("outset")
			.Items.Add("ridge")
			.Items.Add("groove")
		End With
		
		'set webx.Document = "tyng"
		'UPGRADE_WARNING: Navigate2 se actualizó a Navigate y tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		webX.Navigate(New System.URI(("about:blank")))
		Do While webX.ReadyState <> System.Windows.Forms.WebBrowserReadyState.Complete
			System.Windows.Forms.Application.DoEvents()
		Loop 
		myDoc = webX.Document.DomDocument
		'sgBox web1.LocationNam
		On Error Resume Next
		For i = 0 To 1000
			System.Windows.Forms.Application.DoEvents()
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Me.Text = i & " - Calendario"
		Next 
		'hojaestilosfile = "cascadeCalendario.css"
		'On Error Resume Next
		myStyleCss = myDoc.createStyleSheet(".\calendario.css")
		myDoc.body.innerHTML = "<table border=1><td>A</td><td>B</td><tr><td>C</td><td>D</td></tr></table>"
		myStyleCss.addRule("TD", "background-color:white")
		For i = 0 To 100
			System.Windows.Forms.Application.DoEvents()
		Next 
		'MsgBox myStyleCss.rules.length
		myTipoCssRule = myStyleCss.rules.item(0)
		cargaObjeto(objCssRule2)
		cargaControles(myTipoCssRule)
	End Sub
	
	'UPGRADE_NOTE: HScroll1.Change pasó de ser un evento a un procedimiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: HScrollBar evento HScroll1.Change tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub HScroll1_Change(ByVal newScrollValue As Integer)
		On Error Resume Next
		myTipoCssRule.Style.BorderWidth = CStr(newScrollValue)
	End Sub
	
	'UPGRADE_NOTE: scrollMargin.Change pasó de ser un evento a un procedimiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: HScrollBar evento scrollMargin.Change tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub scrollMargin_Change(ByVal newScrollValue As Integer)
		myTipoCssRule.Style.margin = CStr(newScrollValue)
	End Sub
	
	'UPGRADE_NOTE: scrollPadding.Change pasó de ser un evento a un procedimiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="4E2DC008-5EDA-4547-8317-C9316952674F"'
	'UPGRADE_WARNING: HScrollBar evento scrollPadding.Change tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub scrollPadding_Change(ByVal newScrollValue As Integer)
		myTipoCssRule.Style.padding = CStr(newScrollValue)
	End Sub
	
	Private Sub cmdColor_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdColor.Click
		VB6.ShowForm(frmColor, 1, Me)
		myTipoCssRule.Style.BorderColor = frmColor.hexColor
	End Sub
	
	'UPGRADE_WARNING: El evento Combo1.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo1.SelectedIndexChanged
		On Error Resume Next
		
		myTipoCssRule.Style.BorderStyle = Combo1.Text
	End Sub
	
	Sub cargaControles(ByRef obj As mshtml.HTMLStyleSheetRule)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto findIndex(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Combo1.SelectedIndex = findIndex(Combo1, obj.Style.BorderStyle)
		HScroll1.Value = Val(obj.Style.BorderWidth)
		scrollMargin.Value = Val(obj.Style.margin)
		scrollPadding.Value = Val(obj.Style.margin)
	End Sub
	
	
	Function findIndex(ByRef combo As System.Windows.Forms.ComboBox, ByRef texto As String) As Object
		Dim i As Object
		For i = 0 To combo.Items.Count - 1
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If texto = VB6.GetItemString(combo, i) Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto i. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto findIndex. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				findIndex = i
				Exit Function
			End If
		Next i
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto findIndex. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		findIndex = -1
		
	End Function
	Private Sub HScroll1_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles HScroll1.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				HScroll1_Change(eventArgs.newValue)
		End Select
	End Sub
	Private Sub scrollMargin_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles scrollMargin.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				scrollMargin_Change(eventArgs.newValue)
		End Select
	End Sub
	Private Sub scrollPadding_Scroll(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.ScrollEventArgs) Handles scrollPadding.Scroll
		Select Case eventArgs.type
			Case System.Windows.Forms.ScrollEventType.EndScroll
				scrollPadding_Change(eventArgs.newValue)
		End Select
	End Sub
End Class