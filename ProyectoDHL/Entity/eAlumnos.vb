Public Class eAlumnos
    Dim id As Integer
    Dim cuenta, nombreCompleto, nombreProyecto, organizacionBeneficiada, catedratico As String
    Dim horasInvertidas, evaluacion As Integer
    Dim periodo As String
    Dim valorEconomico As Double
    Dim asignatura, carrera, observaciones As String
    Dim activo As Boolean


    Public Sub New(id As Integer, cuenta As String, nombreCompleto As String, nombreProyecto As String, organizacionBeneficiada As String, catedratico As String, horasInvertidas As Integer, evaluacion As Integer, periodo As String, valorEconomico As Double, asignatura As String, carrera As String, observaciones As String, activo As Boolean)
        Me.Id1 = id
        Me.Cuenta1 = cuenta
        Me.NombreCompleto1 = nombreCompleto
        Me.NombreProyecto1 = nombreProyecto
        Me.OrganizacionBeneficiada1 = organizacionBeneficiada
        Me.Catedratico1 = catedratico
        Me.HorasInvertidas1 = horasInvertidas
        Me.Evaluacion1 = evaluacion
        Me.Periodo1 = periodo
        Me.ValorEconomico1 = valorEconomico
        Me.Asignatura1 = asignatura
        Me.Carrera1 = carrera
        Me.Observaciones1 = observaciones
        Me.Activo1 = activo
    End Sub


    Public Sub New()
    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Cuenta1 As String
        Get
            Return cuenta
        End Get
        Set(value As String)
            cuenta = value
        End Set
    End Property

    Public Property NombreCompleto1 As String
        Get
            Return nombreCompleto
        End Get
        Set(value As String)
            nombreCompleto = value
        End Set
    End Property

    Public Property NombreProyecto1 As String
        Get
            Return nombreProyecto
        End Get
        Set(value As String)
            nombreProyecto = value
        End Set
    End Property

    Public Property OrganizacionBeneficiada1 As String
        Get
            Return organizacionBeneficiada
        End Get
        Set(value As String)
            organizacionBeneficiada = value
        End Set
    End Property

    Public Property Catedratico1 As String
        Get
            Return catedratico
        End Get
        Set(value As String)
            catedratico = value
        End Set
    End Property

    Public Property HorasInvertidas1 As Integer
        Get
            Return horasInvertidas
        End Get
        Set(value As Integer)
            horasInvertidas = value
        End Set
    End Property

    Public Property Evaluacion1 As Integer
        Get
            Return evaluacion
        End Get
        Set(value As Integer)
            evaluacion = value
        End Set
    End Property

    Public Property Periodo1 As String
        Get
            Return periodo
        End Get
        Set(value As String)
            periodo = value
        End Set
    End Property

    Public Property ValorEconomico1 As Double
        Get
            Return valorEconomico
        End Get
        Set(value As Double)
            valorEconomico = value
        End Set
    End Property

    Public Property Asignatura1 As String
        Get
            Return asignatura
        End Get
        Set(value As String)
            asignatura = value
        End Set
    End Property

    Public Property Carrera1 As String
        Get
            Return carrera
        End Get
        Set(value As String)
            carrera = value
        End Set
    End Property

    Public Property Observaciones1 As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property

    Public Property Activo1 As Boolean
        Get
            Return activo
        End Get
        Set(value As Boolean)
            activo = value
        End Set
    End Property

End Class
