Public Class tableFormPapelera
    Private tabla As New DataTable

    Private Sub btnExitForm_Click(sender As Object, e As EventArgs) Handles btnExitForm.Click
        MainForm.reintegrateForm()
        Me.Close()
    End Sub

    Private Sub tableFormConsumers_Load(sender As Object, e As EventArgs) Handles Me.Load
        refreshData()
    End Sub

    Public Sub refreshData()
        loadErasedDataToDataTable()
        mostrar()
    End Sub

    Public Sub loadErasedDataToDataTable()
        tabla = tableFormAlumnos.extraerEliminados()
    End Sub


    Private Sub mostrar()
        datalistEliminados.DataSource = tabla
        datalistEliminados.ColumnHeadersVisible = True
        datalistEliminados.Columns(0).Visible = False
        datalistEliminados.Columns(12).Visible = False
        datalistEliminados.Columns(13).Visible = False
        If tabla.Rows.Count = 0 Then
            Dim emptyDataTable As New DataTable
            emptyDataTable.Columns.Add("Vacio")
            Dim emptyRow As DataRow = emptyDataTable.NewRow()
            emptyRow("Vacio") = "No hay datos"
            emptyDataTable.Rows.Add(emptyRow)
            datalistEliminados.DataSource = emptyDataTable
            btnVaciarPapelera.Visible = False
            btnEliminarDelTodo.Visible = False
            btnVerDetalles.Visible = False
            btnRestaurarRegistro.Visible = False
        Else
            btnVaciarPapelera.Visible = True
            btnEliminarDelTodo.Visible = True
            btnVerDetalles.Visible = True
            btnRestaurarRegistro.Visible = True
        End If
    End Sub

    Private Sub btnViewDetailsConsumer_Click(sender As Object, e As EventArgs) Handles btnVerDetalles.Click
        Dim detailsRegistro = New detailsFormAlumnos
        detailsRegistro.prepareForm(False, False, True)
        detailsRegistro.reciveData(sendData())
        detailsRegistro.Show()
    End Sub

    Function sendData() As eAlumnos
        Dim alumnoData As New eAlumnos
        Try
            alumnoData.Id1 = datalistEliminados.SelectedCells.Item(0).Value
            alumnoData.Cuenta1 = datalistEliminados.SelectedCells.Item(1).Value & ""
            alumnoData.NombreCompleto1 = datalistEliminados.SelectedCells.Item(2).Value & ""
            alumnoData.NombreProyecto1 = datalistEliminados.SelectedCells.Item(3).Value & ""
            alumnoData.OrganizacionBeneficiada1 = datalistEliminados.SelectedCells.Item(4).Value & ""
            alumnoData.Catedratico1 = datalistEliminados.SelectedCells.Item(5).Value & ""
            alumnoData.HorasInvertidas1 = datalistEliminados.SelectedCells.Item(6).Value + 0
            alumnoData.Evaluacion1 = datalistEliminados.SelectedCells.Item(7).Value + 0
            alumnoData.Periodo1 = datalistEliminados.SelectedCells.Item(8).Value & ""
            alumnoData.ValorEconomico1 = datalistEliminados.SelectedCells.Item(9).Value + 0
            alumnoData.Asignatura1 = datalistEliminados.SelectedCells.Item(10).Value & ""
            alumnoData.Carrera1 = datalistEliminados.SelectedCells.Item(11).Value & ""
            alumnoData.Observaciones1 = datalistEliminados.SelectedCells.Item(12).Value & ""
            alumnoData.Activo1 = datalistEliminados.SelectedCells.Item(13).Value
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

    Private Sub btnRestaurarRegistro_Click(sender As Object, e As EventArgs) Handles btnRestaurarRegistro.Click
        Dim restorePeticion As Integer = MessageBox.Show("¿Desea restaurar el registro seleccionado?", "", MessageBoxButtons.YesNo)
        If restorePeticion = DialogResult.Yes Then
            tableFormAlumnos.restaurarRegistro(datalistEliminados.SelectedCells.Item(0).Value)
            refreshData()
        End If
    End Sub

    Private Sub btnEliminarDelTodo_Click(sender As Object, e As EventArgs) Handles btnEliminarDelTodo.Click
        Dim deletePeticion As Integer = MessageBox.Show("¿Desea eliminar el registro seleccionado?" + vbLf + "No se puede deshacer esta operación.", "", MessageBoxButtons.YesNo)
        If deletePeticion = DialogResult.Yes Then
            tableFormAlumnos.eliminarRegistro(datalistEliminados.SelectedCells.Item(0).Value)
            refreshData()
        End If
    End Sub

    Private Sub btnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnVaciarPapelera.Click
        Dim deletePeticion As Integer = MessageBox.Show("¿Desea vaciar la papelera?" + vbLf + "No se puede deshacer esta operación.", "", MessageBoxButtons.YesNo)
        If deletePeticion = DialogResult.Yes Then
            tableFormAlumnos.vaciarPapelera()
            refreshData()
        End If
    End Sub
End Class