Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setSize(400, 200)
    End Sub

    Private Sub AddControl(item As (valor As Integer, ancho As Integer, alto As Integer, x As Integer, y As Integer))
        Dim myCrtl As New Label
        With myCrtl
            .Size = New Size(item.ancho, item.alto)
            .Location = New Size(item.x, item.y)
            .Text = IIf(item.valor = 0, "ERROR", item.valor)
            .TextAlign = ContentAlignment.MiddleCenter
            .BorderStyle = BorderStyle.FixedSingle
            .Font = lblValores.Font
            .ForeColor = Color.Blue

        End With
        Dim myToolTip As New ToolTip
        myToolTip.SetToolTip(myCrtl, $"{item.ancho * item.alto}" + vbCrLf +
                                     $"{item.ancho}*{item.alto}" + vbCrLf +
                                     $"({item.x},{item.y})")

        Me.pnlPresentacion.Controls.Add(myCrtl)
    End Sub

    Sub setSize(ancho As Int16, alto As Int16)
        pnlPresentacion.Width = ancho
        pnlPresentacion.Height = alto
        txtLista.Width = Math.Max(ancho, 250)
        btnGenerar.Left = txtLista.Left + txtLista.Width - btnGenerar.Width
        Me.Width = txtLista.Width + (2 * txtLista.Left) + 20
        Me.Height = pnlPresentacion.Top + pnlPresentacion.Height + 110
        txtAlto.Text = pnlPresentacion.Height
        txtAncho.Text = pnlPresentacion.Width
    End Sub

    Private Sub btnWMinus_Click(sender As Object, e As EventArgs) Handles btnWMinus.Click
        setSize(pnlPresentacion.Width - 10, pnlPresentacion.Height)
    End Sub

    Private Sub btnHMinus_Click(sender As Object, e As EventArgs) Handles btnHMinus.Click
        setSize(pnlPresentacion.Width, pnlPresentacion.Height - 10)
    End Sub

    Private Sub btnHPlus_Click(sender As Object, e As EventArgs) Handles btnHPlus.Click
        setSize(pnlPresentacion.Width, pnlPresentacion.Height + 10)
    End Sub

    Private Sub btnWPlus_Click(sender As Object, e As EventArgs) Handles btnWplus.Click
        setSize(pnlPresentacion.Width + 10, pnlPresentacion.Height)
    End Sub

    Private Sub txtAlto_TextChanged(sender As Object, e As EventArgs) Handles txtAlto.TextChanged
        setSize(pnlPresentacion.Width, CInt(txtAlto.Text))
    End Sub

    Private Sub txtAncho_TextChanged(sender As Object, e As EventArgs) Handles txtAncho.TextChanged
        setSize(CInt(txtAncho.Text), pnlPresentacion.Height)
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        '1 convertir la entrada de txt a valores numericos
        Dim strValues = txtLista.Text.Replace("  ", " ").Trim.Split(" ")
        Dim values As New List(Of Integer)
        Try
            For Each str As String In strValues
                values.Add(CInt(str))
            Next
        Catch ex As Exception
            MsgBox("Dame mejores números")
            txtLista.Text = "10 20 5 5 40"
            Return
        End Try


        '2 Ordenar la lista (si queremos)
        values.Sort()
        values.Reverse()

        '3 Corvertir la lista a 2 dimensiones
        '3.1 Preparamos la lista de resultado como un tupla!!!!! con nombre
        ' https://docs.microsoft.com/es-es/dotnet/visual-basic/programming-guide/language-features/data-types/tuples
        Dim resultado = New List(Of (valor As Integer, ancho As Integer, alto As Integer, x As Integer, y As Integer))
        For Each val As Integer In values
            resultado.Add((valor:=val, 0, 0, 0, 0))
        Next
        '3.2 Invocamos la magia
        Dim ancho As Integer = CInt(txtAncho.Text)
        Dim alto As Integer = CInt(txtAlto.Text)

        Dim area = (ancho:=ancho, alto:=alto, x:=0, y:=0)
        ConsoleLogList(resultado)
        ListaDeEnterosA2Dimensiones(resultado, area)

        '4 confirmar que las areas son iguales
        Console.WriteLine($"Área {ancho * alto} = {ancho}*{alto}")
        Dim sAreas As Integer = 0
        For Each item In resultado
            sAreas += (item.ancho * item.alto)
        Next
        Console.WriteLine($"Área {sAreas} de la lista")

        '5 La presentamos
        pnlPresentacion.Controls.Clear()

        If ancho * alto <> sAreas Then
            AddControl((valor:=0, ancho:=area.ancho, alto:=area.alto, x:=area.x, y:=area.y))
        Else
            For Each item In resultado
                AddControl(item)
            Next
        End If

    End Sub


    Private Sub ListaDeEnterosA2Dimensiones(ByRef list As List(Of (valor As Integer, ancho As Integer, alto As Integer, x As Integer, y As Integer)), area As (ancho As Integer, alto As Integer, x As Integer, y As Integer))
        '1.- primer control de la recursividad
        If list.Count = 1 Then
            list(0) = (valor:=list(0).valor,
                        ancho:=area.ancho,
                        alto:=area.alto,
                        x:=area.x,
                        y:=area.y)
            Return
        End If

        '2.- ya que hay más de un elemento, separamos la lista en 2 lista
        ' las vamos a separar 'equilibradas' es decir que más o menos hay la misma suma 
        ' en cada lista
        Dim l0 = New List(Of (valor As Integer, ancho As Integer, alto As Integer, x As Integer, y As Integer))
        Dim l1 = New List(Of (valor As Integer, ancho As Integer, alto As Integer, x As Integer, y As Integer))
        Dim s0 As Integer = 0
        Dim s1 As Integer = 0

        For Each item In list
            If s0 < s1 Then
                l0.Add(item)
                s0 += item.valor
            Else
                l1.Add(item)
                s1 += item.valor
            End If
        Next
        ConsoleLogList(l0)
        ConsoleLogList(l1)

        '3.- ahora tenemos Dos listas l0 y l1, y su suma s0 y s1
        ' Repartimos el área entre estos valores ' Regla de 3
        Dim ap0 = (area.ancho * area.alto) * s0 / (s0 + s1) ' x area proporcional de l0
        Dim ap1 = (area.ancho * area.alto) * s1 / (s0 + s1) ' y area proporcional de l1

        '4.-  Ajuste del Area mayor al Lado menor
        ' Para que tenga aspecto más cuadrado
        Dim a0 = (ancho:=0, alto:=0, x:=0, y:=0)
        Dim a1 = (ancho:=0, alto:=0, x:=0, y:=0)

        If (ap0 > ap1) Then
            'vertical u horizontal
            If (area.alto < area.ancho) Then
                'HORIZONTAL
                a0 = (ancho:=ap0 \ area.alto, alto:=area.alto, x:=area.x, y:=area.y)
                a1 = (ancho:=area.ancho - a0.ancho, alto:=area.alto, x:=area.x + a0.ancho, y:=area.y)
            Else
                'VERTICAL
                a0 = (ancho:=area.ancho, alto:=ap0 \ area.ancho, x:=area.x, y:=area.y)
                a1 = (ancho:=area.ancho, alto:=area.alto - a0.alto, x:=area.x, y:=area.y + a0.alto)
            End If
        Else
            If (area.alto < area.ancho) Then
                a1 = (ancho:=ap1 \ area.alto, alto:=area.alto, x:=area.x, y:=area.y)
                a0 = (ancho:=area.ancho - a1.ancho, alto:=area.alto, x:=area.x + a1.ancho, y:=area.y)
            Else
                a1 = (ancho:=area.ancho, alto:=ap1 \ area.ancho, x:=area.x, y:=area.y)
                a0 = (ancho:=area.ancho, alto:=area.alto - a1.alto, x:=area.x, y:=area.y + a1.alto)
            End If
        End If

        '5.- Ahora invocamos la recursividad
        ListaDeEnterosA2Dimensiones(l0, a0)
        ListaDeEnterosA2Dimensiones(l1, a1)

        list.Clear()
        list.AddRange(l0)
        list.AddRange(l1)
    End Sub

    Sub ConsoleLogList(list As List(Of (valor As Integer, ancho As Integer, alto As Integer, x As Integer, y As Integer)))
        Static i As Integer = 0
        i += 1
        Console.Write($"#{i}({list.Count})[ ")
        For Each item In list
            Console.Write($"{item.valor} ")
        Next
        Console.WriteLine("]")
    End Sub
End Class
