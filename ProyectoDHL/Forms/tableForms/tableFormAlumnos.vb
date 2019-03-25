Public Class tableFormAlumnos
    Private tabla As New DataTable

    Private Sub btnExitForm_Click(sender As Object, e As EventArgs) Handles btnExitForm.Click
        MainForm.reintegrateForm()
        Me.Close()
    End Sub

    Private Sub tableFormEmployees_Load(sender As Object, e As EventArgs) Handles Me.Load
        refreshData()
    End Sub

    Public Sub refreshData()
        loadDataToDataTable()
        mostrar()
    End Sub

    Public Sub loadDataToDataTable()
        tabla = Me.AlumnosTableAdapter.GetData(True)
    End Sub

    Private Sub mostrar()
        datalistAlumnos.DataSource = tabla
        datalistAlumnos.ColumnHeadersVisible = True
        datalistAlumnos.Columns(0).Visible = False
        datalistAlumnos.Columns(12).Visible = False
        datalistAlumnos.Columns(13).Visible = False
        If datalistAlumnos.Rows.Count = 0 Then
            Dim emptyDataTable As New DataTable
            emptyDataTable.Columns.Add("dataEmpty")
            Dim emptyRow As DataRow = emptyDataTable.NewRow()
            emptyRow("dataEmpty") = "No hay datos"
            emptyDataTable.Rows.Add(emptyRow)
            datalistAlumnos.DataSource = emptyDataTable
            btnDeleteAlumno.Enabled = False
            btnEditAlumno.Enabled = False
            btnViewDetailsEmployee.Enabled = False
        End If
    End Sub

    Private Sub btnViewDetailsEmployee_Click(sender As Object, e As EventArgs) Handles btnViewDetailsEmployee.Click
        Dim detailsAlumno = New detailsFormAlumnos
        detailsAlumno.prepareForm(False, False, True)
        Dim datos As eAlumnos = New eAlumnos
        datos = sendData()
        If datos.Id1 <> 0 Then
            detailsAlumno.reciveData(datos)
            detailsAlumno.Show()
        Else
            Dim alerta As frmAlerta = New frmAlerta
            alerta.setText("No hay nada que mostrar")
            alerta.Show()
        End If
    End Sub

    Function sendData() As eAlumnos
        Dim alumnoData As New eAlumnos
        Try
            alumnoData.Id1 = datalistAlumnos.SelectedCells.Item(0).Value
            alumnoData.Cuenta1 = datalistAlumnos.SelectedCells.Item(1).Value & ""
            alumnoData.NombreCompleto1 = datalistAlumnos.SelectedCells.Item(2).Value & ""
            alumnoData.NombreProyecto1 = datalistAlumnos.SelectedCells.Item(3).Value & ""
            alumnoData.OrganizacionBeneficiada1 = datalistAlumnos.SelectedCells.Item(4).Value & ""
            alumnoData.Catedratico1 = datalistAlumnos.SelectedCells.Item(5).Value & ""
            alumnoData.HorasInvertidas1 = datalistAlumnos.SelectedCells.Item(6).Value + 0
            alumnoData.Evaluacion1 = datalistAlumnos.SelectedCells.Item(7).Value + 0
            alumnoData.Periodo1 = datalistAlumnos.SelectedCells.Item(8).Value & ""
            alumnoData.ValorEconomico1 = datalistAlumnos.SelectedCells.Item(9).Value + 0
            alumnoData.Asignatura1 = datalistAlumnos.SelectedCells.Item(10).Value & ""
            alumnoData.Carrera1 = datalistAlumnos.SelectedCells.Item(11).Value & ""
            alumnoData.Observaciones1 = datalistAlumnos.SelectedCells.Item(12).Value & ""
            alumnoData.Activo1 = datalistAlumnos.SelectedCells.Item(13).Value
        Catch exepcion As Exception
            alumnoData.Id1 = 0
            alumnoData.Cuenta1 = ""
            alumnoData.NombreCompleto1 = ""
            alumnoData.NombreProyecto1 = ""
            alumnoData.OrganizacionBeneficiada1 = ""
            alumnoData.Catedratico1 = ""
            alumnoData.HorasInvertidas1 = 0
            alumnoData.Evaluacion1 = 0
            alumnoData.Periodo1 = ""
            alumnoData.ValorEconomico1 = 0
            alumnoData.Asignatura1 = ""
            alumnoData.Carrera1 = ""
            alumnoData.Observaciones1 = ""
            alumnoData.Activo1 = False
        End Try
        Return alumnoData
    End Function

    Private Sub btnAddNewAlumno_Click(sender As Object, e As EventArgs) Handles btnAddNewAlumno.Click
        Dim detailsEmployee = New detailsFormAlumnos
        detailsEmployee.prepareForm(True, False, False)
        detailsEmployee.Show()
    End Sub

    Private Sub btnEditAlumno_Click(sender As Object, e As EventArgs) Handles btnEditAlumno.Click
        Dim detailsEmployee = New detailsFormAlumnos
        detailsEmployee.prepareForm(False, True, False)
        detailsEmployee.reciveData(sendData())
        detailsEmployee.Show()
    End Sub

    Private Sub btnDeleteAlumno_Click(sender As Object, e As EventArgs) Handles btnDeleteAlumno.Click
        Dim deletePeticion As Integer = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "", MessageBoxButtons.YesNoCancel)
        If deletePeticion = DialogResult.Yes Then
            Me.AlumnosTableAdapter.ActivoRegistro(False, datalistAlumnos.SelectedCells.Item(0).Value)
        End If
        refreshData()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cuentaBuscar As String
        cuentaBuscar = txtBusqueda.Text
        If cuentaBuscar <> "" Then
            Dim datosBuscados As DataTable
            datosBuscados = Me.AlumnosTableAdapter.GetDataByCuenta(cuentaBuscar)
            datalistAlumnos.DataSource = datosBuscados
            btnClear.Visible = True
            If datosBuscados.Rows.Count = 0 Then
                Dim alerta As frmAlerta = New frmAlerta
                alerta.setText("No se encontraron resultados")
                alerta.Show()
            End If
            If datosBuscados.Rows.Count > 0 Then
                Dim horasVinculadas As Integer = 0
                For elementos As Integer = 0 To datosBuscados.Rows.Count - 1
                    Dim row As DataRow
                    row = datosBuscados.Rows(elementos)
                    horasVinculadas += row.Item(6)
                Next
                labVinculadas.Visible = True
                txtVinculadas.Visible = True
                txtVinculadas.ReadOnly = True
                txtVinculadas.Text = horasVinculadas
            End If
        Else
            Dim alerta As frmAlerta = New frmAlerta
            alerta.setText("Debe ingresar un número de cuenta para poder buscar.")
            alerta.Show()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        btnClear.Visible = False
        txtBusqueda.Text = ""
        txtVinculadas.Text = ""
        txtVinculadas.Visible = False
        labVinculadas.Visible = False
        refreshData()
    End Sub

    Private Sub datalistAlumnos_SelectionChanged(sender As Object, e As EventArgs) Handles datalistAlumnos.SelectionChanged
        If datalistAlumnos.Rows.Count = 0 Then
            txtBusqueda.Text = ""
        Else
            Try
                txtBusqueda.Text = datalistAlumnos.SelectedCells.Item(1).Value
            Catch ex As Exception

            End Try
        End If
    End Sub

    Public Sub edicionDatos(ByRef datos As eAlumnos)
        Me.AlumnosTableAdapter.EditarRegistro(datos.Cuenta1, datos.NombreCompleto1, datos.NombreProyecto1, datos.OrganizacionBeneficiada1, datos.Catedratico1, datos.HorasInvertidas1, datos.Evaluacion1, datos.Periodo1, datos.ValorEconomico1, datos.Asignatura1, datos.Carrera1, datos.Observaciones1, datos.Id1)
        refreshData()
        Dim alerta As frmAlerta = New frmAlerta
        alerta.setText("Datos guardados exitosamente.")
        alerta.Show()
    End Sub

    Public Sub nuevosDatos(ByRef datos As eAlumnos)
        Me.AlumnosTableAdapter.InsertarRegistro(datos.Cuenta1, datos.NombreCompleto1, datos.NombreProyecto1, datos.OrganizacionBeneficiada1, datos.Catedratico1, datos.HorasInvertidas1, datos.Evaluacion1, datos.Periodo1, datos.ValorEconomico1, datos.Asignatura1, datos.Carrera1, datos.Observaciones1, True)
        Dim alerta As frmAlerta = New frmAlerta
        alerta.setText("Datos guardados exitosamente.")
        alerta.Show()
        refreshData()
    End Sub

    'Metodos para impacto en la base de datos lamados desde otros formularios
    'Hice estos metodos aquí porque no construí un controlador para eso xD que debería estar en la carpeta Data

    Public Function extraerEliminados() As DataTable
        tabla = Me.AlumnosTableAdapter.GetData(False)
        Return tabla
    End Function

    Public Sub restaurarRegistro(ByRef id_Registro As Integer)
        Me.AlumnosTableAdapter.ActivoRegistro(True, id_Registro)
    End Sub

    Public Sub eliminarRegistro(ByRef id_Registro As Integer)
        Me.AlumnosTableAdapter.EliminarRegistro(id_Registro)
    End Sub

    Public Sub vaciarPapelera()
        Me.AlumnosTableAdapter.eliminacionSeccionada(False)
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim exportacionForm As New formExport
        exportacionForm.obtenerGrid(datalistAlumnos)
        exportacionForm.Show()
    End Sub
End Class