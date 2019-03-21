Public Class tableFormAlumnos
    Private tabla As New DataTable

    Private Sub btnExitForm_Click(sender As Object, e As EventArgs) Handles btnExitForm.Click
        Me.Close()
    End Sub

    Private Sub tableFormEmployees_Load(sender As Object, e As EventArgs) Handles Me.Load
        mostrar()
    End Sub

    Public Sub refreshData()
        mostrar()
    End Sub

    Private Sub mostrar()
        Me.AlumnosTableAdapter.Fill(Me.VinculacionAcademicaPT_TGU_DBDataSet1.Alumnos)
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
            btnDeleteEmployee.Enabled = False
            btnEditEmployee.Enabled = False
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

    Private Sub btnAddNewEmployee_Click(sender As Object, e As EventArgs) Handles btnAddNewEmployee.Click
        Dim detailsEmployee = New detailsFormAlumnos
        detailsEmployee.prepareForm(True, False, False)
        detailsEmployee.Show()
    End Sub

    Private Sub btnEditEmployee_Click(sender As Object, e As EventArgs) Handles btnEditEmployee.Click
        Dim detailsEmployee = New detailsFormAlumnos
        detailsEmployee.prepareForm(False, True, False)
        detailsEmployee.reciveData(sendData())
        detailsEmployee.Show()
    End Sub

    Private Sub btnDeleteEmployee_Click(sender As Object, e As EventArgs) Handles btnDeleteEmployee.Click
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
            Me.AlumnosTableAdapter.FillByCuenta(Me.VinculacionAcademicaPT_TGU_DBDataSet1.Alumnos, cuentaBuscar)
            btnClear.Visible = True
        Else
            MessageBox.Show("Debe ingresar un numero de cuenta antes de intentar buscar.", "Aviso")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        refreshData()
        btnClear.Visible = False
    End Sub
End Class