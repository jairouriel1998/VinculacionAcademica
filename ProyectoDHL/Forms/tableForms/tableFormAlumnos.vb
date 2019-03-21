﻿Public Class tableFormAlumnos
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
        Try
            Dim funciones As New dEmployees
            tabla = funciones.mostrar
            If tabla.Rows.Count <> 0 Then
                datalistAlumnos.DataSource = tabla
                datalistAlumnos.ColumnHeadersVisible = True
                datalistAlumnos.Columns("id_persona").Visible = False
            Else
                datalistAlumnos.DataSource = Nothing
                datalistAlumnos.ColumnHeadersVisible = False
            End If
        Catch evento As Exception
            MsgBox(evento.Message)
        End Try
        If tabla.Rows.Count = 0 Then
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
        Dim detailsEmpleado = New detailsFormAlumnos
        detailsEmpleado.prepareForm(False, False, True)
        detailsEmpleado.reciveData(sendData())
        detailsEmpleado.Show()
    End Sub

    Function sendData() As eEmployees
        Dim employeeData As New eEmployees
        employeeData.Id_persona1 = datalistAlumnos.SelectedCells.Item(0).Value
        employeeData.Id_empleado1 = datalistAlumnos.SelectedCells.Item(1).Value
        employeeData.Nombre1 = datalistAlumnos.SelectedCells.Item(2).Value
        employeeData.Apellido1 = datalistAlumnos.SelectedCells.Item(3).Value
        employeeData.Identidad1 = datalistAlumnos.SelectedCells.Item(4).Value
        employeeData.Telefono1 = datalistAlumnos.SelectedCells.Item(5).Value
        employeeData.Email1 = datalistAlumnos.SelectedCells.Item(6).Value
        employeeData.Cargo1 = datalistAlumnos.SelectedCells.Item(7).Value
        Return employeeData
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
            Dim setData As New dEmployees
            setData.eliminar(datalistAlumnos.SelectedCells.Item(1).Value)
        End If
        refreshData()
    End Sub
End Class