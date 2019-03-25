Imports System.Runtime.InteropServices

Public Class detailsFormAlumnos
    Dim newAlumno, editAlumno, viewAlumno As Boolean
    Dim registroActual As New eAlumnos

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Public Sub prepareForm(newData As Boolean, editData As Boolean, viewData As Boolean)
        newAlumno = newData
        editAlumno = editData
        viewAlumno = viewData
        prepareButtons()
        prepareTextBox()
    End Sub

    Private Sub prepareButtons()
        If newAlumno Or editAlumno Then
            btnSave.Visible = True
            btnClear.Visible = True
            btnCancel.Visible = True
            btnClose.Visible = False
        ElseIf viewAlumno Then
            btnSave.Visible = False
            btnClear.Visible = False
            btnCancel.Visible = False
            btnClose.Visible = True
        End If
    End Sub

    Private Sub prepareTextBox()
        If newAlumno Or editAlumno Then
            txtCuenta.ReadOnly = False
            txtNombre.ReadOnly = False
            txtProyecto.ReadOnly = False
            txtBeneficiado.ReadOnly = False
            txtEvaluador.ReadOnly = False
            txtHoras.ReadOnly = False
            txtEvaluacion.ReadOnly = False
            txtPeriodo.ReadOnly = False
            txtValor.ReadOnly = False
            txtAsignatura.ReadOnly = False
            txtCarrera.ReadOnly = False
            txtObservaciones.ReadOnly = False
        ElseIf viewAlumno Then
            txtCuenta.ReadOnly = True
            txtNombre.ReadOnly = True
            txtProyecto.ReadOnly = True
            txtBeneficiado.ReadOnly = True
            txtEvaluador.ReadOnly = True
            txtHoras.ReadOnly = True
            txtEvaluacion.ReadOnly = True
            txtPeriodo.ReadOnly = True
            txtValor.ReadOnly = True
            txtAsignatura.ReadOnly = True
            txtCarrera.ReadOnly = True
            txtObservaciones.ReadOnly = True
        End If
    End Sub


    Public Sub reciveData(alumnoData As eAlumnos)
        If alumnoData.Id1 <> 0 Then
            txtCuenta.Text = alumnoData.Cuenta1
            txtNombre.Text = alumnoData.NombreCompleto1
            txtProyecto.Text = alumnoData.NombreProyecto1
            txtBeneficiado.Text = alumnoData.OrganizacionBeneficiada1
            txtEvaluador.Text = alumnoData.Catedratico1
            txtHoras.Text = alumnoData.HorasInvertidas1
            txtEvaluacion.Text = alumnoData.Evaluacion1
            txtPeriodo.Text = alumnoData.Periodo1
            txtValor.Text = alumnoData.ValorEconomico1
            txtAsignatura.Text = alumnoData.Asignatura1
            txtCarrera.Text = alumnoData.Carrera1
            txtObservaciones.Text = alumnoData.Observaciones1
            registroActual = alumnoData
        Else
            txtCuenta.Text = ""
            txtNombre.Text = ""
            txtProyecto.Text = ""
            txtBeneficiado.Text = ""
            txtEvaluador.Text = ""
            txtHoras.Text = ""
            txtEvaluacion.Text = ""
            txtPeriodo.Text = ""
            txtValor.Text = ""
            txtAsignatura.Text = ""
            txtCarrera.Text = ""
            txtObservaciones.Text = ""
            registroActual = alumnoData
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim errores As Boolean = False

        If txtCuenta.Text <> "" And txtNombre.Text <> "" And txtProyecto.Text <> "" And txtHoras.Text <> "" Then

            registroActual.Cuenta1 = txtCuenta.Text
            registroActual.NombreCompleto1 = txtNombre.Text
            registroActual.NombreProyecto1 = txtProyecto.Text
            registroActual.OrganizacionBeneficiada1 = txtBeneficiado.Text
            registroActual.Catedratico1 = txtEvaluador.Text

            If txtHoras.Text = "" Then
                registroActual.HorasInvertidas1 = 0
            Else
                Try
                    registroActual.HorasInvertidas1 = Integer.Parse(txtHoras.Text)
                Catch ex As Exception
                    registroActual.HorasInvertidas1 = 0
                    errores = True
                End Try
            End If

            If txtEvaluacion.Text = "" Then
                registroActual.Evaluacion1 = 0
            Else
                Try
                    registroActual.Evaluacion1 = Integer.Parse(txtEvaluacion.Text)
                Catch ex As Exception
                    registroActual.Evaluacion1 = 0
                    errores = True
                End Try
            End If

            registroActual.Periodo1 = txtPeriodo.Text

            If txtValor.Text = "" Then
                registroActual.ValorEconomico1 = 0
            Else
                Try
                    registroActual.ValorEconomico1 = Integer.Parse(txtValor.Text)
                Catch ex As Exception
                    registroActual.ValorEconomico1 = 0
                    errores = True
                End Try
            End If


            registroActual.Asignatura1 = txtAsignatura.Text
            registroActual.Carrera1 = txtCarrera.Text
            registroActual.Observaciones1 = txtObservaciones.Text

            If errores = False Then
                If newAlumno Then
                    Dim deletePeticion As Integer = MessageBox.Show("¿Desea guardar el nuevo registro?", "", MessageBoxButtons.YesNo)
                    If deletePeticion = DialogResult.Yes Then
                        tableFormAlumnos.nuevosDatos(registroActual)
                        MainForm.formTablaRegistros.refreshData()
                        Me.Close()
                    End If

                ElseIf editAlumno Then
                    Dim deletePeticion As Integer = MessageBox.Show("¿Desea guardar los cambios realizados?", "", MessageBoxButtons.YesNo)
                    If deletePeticion = DialogResult.Yes Then
                        tableFormAlumnos.edicionDatos(registroActual)
                        MainForm.formTablaRegistros.refreshData()
                        Me.Close()
                    End If
                End If
            Else
                Dim alerta As frmAlerta = New frmAlerta
                alerta.setText("ERROR!" + vbLf + "Se ha ingresado texto en campos numéricos." + vbLf + vbLf + " No se han guardado los cambios.")
                alerta.Show()
            End If
        Else
            Dim alerta As frmAlerta = New frmAlerta
            alerta.setText("Se necesitan los campos: número de cuenta, el nombre del estudiante, el nombre del proyecto y las horas vinculadas para poder guardar el nuevo registro.")
            alerta.Show()
        End If
    End Sub

    Private Sub Label1_MouseMove(sender As Object, e As MouseEventArgs) Handles Label1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCuenta.Text = ""
        txtNombre.Text = ""
        txtProyecto.Text = ""
        txtBeneficiado.Text = ""
        txtEvaluador.Text = ""
        txtHoras.Text = ""
        txtEvaluacion.Text = ""
        txtPeriodo.Text = ""
        txtValor.Text = ""
        txtAsignatura.Text = ""
        txtCarrera.Text = ""
        txtObservaciones.Text = ""
    End Sub

End Class