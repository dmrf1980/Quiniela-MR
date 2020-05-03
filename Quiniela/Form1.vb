Public Class Form1

    'Cerrar aplicacion--------------------------------OK

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Application.Exit()

    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()

    End Sub


    '-------------------------------------AGREGAR-------------------------------------OK

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim numAgregado As String
        numAgregado = nudNumeros.Value

        If Not lbxApostados.Items.Contains(numAgregado.ToString) Then
            lbxApostados.Items.Add(numAgregado.ToString)
            btnSortear.Enabled = True
        Else
            MsgBox("Numero repetido", 48, "ERROR")

        End If


    End Sub


    ' QUITAR numero seleccionado---------------------------------------------------------OK

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        lbxApostados.Items.Remove(lbxApostados.SelectedItem)

    End Sub


    '--------------------------------SORTEAR----------------------------------------------OK

    Private Sub btnSortear_Click(sender As Object, e As EventArgs) Handles btnSortear.Click

        Dim numero As New Random
        Dim numeracion As Integer
        Dim numeroSorteado, aciertos As String
        Dim ciclo As Integer
        ciclo = 0
        aciertos = ""

        lbxSorteados.Items.Clear()
        lblCiclo.Text = ""
        lblAciertos.Visible = True

        If lbxApostados.Items.Count = 0 Then
            MsgBox("Primero debe realizar apuesta")
            btnSortear.Enabled = False

        Else

            Do While lbxSorteados.Items.Count() < 20
                numeroSorteado = Math.Truncate(numero.NextDouble * 999)
                '  _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ 
                '|ACA puede activar el siguient MSGBOX para ver cuando         |
                '|sale un n° repetido y no lo guarda en el LISTBOX de sorteados|             
                ' ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯
                'MsgBox("REPETIDO" + numeroSorteado.ToString)

                If Not lbxSorteados.Items.Contains(numeroSorteado.ToString) Then
                    lbxSorteados.Items.Add((numeracion + 1).ToString + "° - " + numeroSorteado.ToString)
                    numeracion += 1

                    If lbxApostados.Items.Contains(numeroSorteado.ToString) Then
                        MsgBox(numeracion.ToString + "° - " + numeroSorteado.ToString, 0, "ACERTASTE")
                        aciertos = aciertos + numeracion.ToString + "°: " + numeroSorteado + "  - "
                        rtxBoxAciertos.Text = aciertos
                        ciclo += 1
                        lblCiclo.Text = ciclo.ToString

                    End If
                End If
            Loop
        End If

        If aciertos = "" Then
            lblCiclo.Text = " No hay aciertos"
            lblAciertos.Visible = False
            rtxBoxAciertos.Text = ""

        End If

        If lbxSorteados.Items.Count <> 0 Then
            btnSortear.Text = "Nuevo Sorteo"

        End If
    End Sub


    ' VACIAR apostados---------------------------------------

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        If MsgBox("Estas seguro?", MsgBoxStyle.YesNo, "Eliminar Apuesta") = MsgBoxResult.Yes Then
            lbxApostados.Items.Clear()

        End If
    End Sub


    ' VACIAR sorteados-----------------------------------------

    Private Sub btnVaciarSorteados_Click(sender As Object, e As EventArgs) Handles btnVaciarSorteados.Click
        If MsgBox("Estas seguro?", MsgBoxStyle.YesNo, "Eliminar Sorteo") = MsgBoxResult.Yes Then
            lbxSorteados.Items.Clear()
            btnSortear.Text = "Sortear"

        End If
    End Sub


End Class
