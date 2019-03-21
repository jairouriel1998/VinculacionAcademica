Public Class tableFormAlumnos
    Private tabla As New DataTable

    Private Sub btnExitForm_Click(sender As Object, e As EventArgs) Handles btnExitForm.Click
        Me.Close()
    End Sub

    Private Sub tableFormEmployees_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDataToDataTable()
        mostrar()
    End Sub

    Public Sub refreshData()
        mostrar()
    End Sub

    Public Sub loadDataToDataTable()
        tabla = Me.AlumnosTableAdapter.GetData()
    End Sub

    Private Sub mostrar()
        datalistAlumnos.DataSource = tabla
        datalistAlumnos.ColumnHeadersVisible = True
        datalistAlumnos.Columns(0).Visible = False
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
        detailsAlumno.reciveData(sendData())
        detailsAlumno.Show()
    End Sub

    Function sendData() As eAlumnos
        Dim alumnoData As New eAlumnos
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
        Return alumnoData
    End Function

    Private Sub btnAddNewEmployee_Click(sender As Object, e As EventArgs) Handles btnAddNewAlumno.Click
        Dim detailsEmployee = New detailsFormAlumnos
        detailsEmployee.prepareForm(True, False, False)
        detailsEmployee.Show()
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditAlumno.Click
        Dim detailsEmployee = New detailsFormAlumnos
        detailsEmployee.prepareForm(False, True, False)
        detailsEmployee.reciveData(sendData())
        detailsEmployee.Show()
    End Sub

    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteAlumno.Click
        Dim deletePeticion As Integer = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "caption", MessageBoxButtons.YesNoCancel)
        If deletePeticion = DialogResult.Cancel Then
            MessageBox.Show("Eliminacion cancelada")
        ElseIf deletePeticion = DialogResult.Yes Then
            ' Dim setData As New dEmployees
            'setData.eliminar(datalistAlumnos.SelectedCells.Item(1).Value)
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
                txtVinculadas.Text = horasVinculadas
            End If
        Else
            MessageBox.Show("Debe ingresar un numero de cuenta antes de intentar buscar.", "Aviso")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        refreshData()
        btnClear.Visible = False
        txtBusqueda.Text = ""
        txtVinculadas.Text = ""
        txtVinculadas.Visible = False
        labVinculadas.Visible = False
    End Sub


End Class