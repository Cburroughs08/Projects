
Imports System.Data
Namespace BAL
    Public Class bStore

        Dim StoreId As Integer
        Dim StoreName As String
        Dim StoreType As String
        Dim OwnerName As String
        Dim Phone As String
        Dim Score As String
        Dim Status As String


#Region "Properties"
        Public Property Id() As Integer
            Get
                Return StoreId
            End Get
            Set(value As Integer)
                StoreId = value

            End Set
        End Property
        Public Property Name() As String
            Get
                Return StoreName
            End Get
            Set(value As String)
                StoreName = value

            End Set
        End Property

        Public Property Type() As String
            Get
                Return StoreType
            End Get
            Set(value As String)
                StoreType = value

            End Set
        End Property

        Public Property Own() As String
            Get
                Return OwnerName
            End Get
            Set(value As String)
                OwnerName = value

            End Set
        End Property

        Public Property pnum() As String
            Get
                Return Phone
            End Get
            Set(value As String)
                Phone = value

            End Set
        End Property

        Public Property scores() As Integer
            Get
                Return Score
            End Get
            Set(value As Integer)
                Score = value

            End Set
        End Property

        Public Property Stat() As String
            Get
                Return Status
            End Get
            Set(value As String)
                Status = value

            End Set
        End Property


#End Region

        Public Sub New()

        End Sub


        Public Function GetAllStores() As DataSet
            Return DAL.dStore.GetAllStores(Me)
        End Function

        Public Function AddStore() As String
            Return DAL.dStore.AddStore(Me)
        End Function


    End Class
End Namespace