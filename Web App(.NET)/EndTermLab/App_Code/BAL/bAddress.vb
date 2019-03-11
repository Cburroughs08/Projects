Imports System.Data
Namespace BAL
    Public Class bAddress
        Dim AddressId As Integer
        Dim StoreId As Integer
        Dim Street As String
        Dim City As String
        Dim State As String
        Dim Zip As String
        Dim AddressType As String

#Region "Properties"
        Public Property aId() As Integer
            Get
                Return AddressId
            End Get
            Set(value As Integer)
                AddressId = value

            End Set
        End Property

        Public Property sId() As Integer
            Get
                Return StoreId
            End Get
            Set(value As Integer)
                StoreId = value

            End Set
        End Property
        Public Property St() As String
            Get
                Return Street
            End Get
            Set(value As String)
                Street = value

            End Set
        End Property

        Public Property Cities() As String
            Get
                Return City
            End Get
            Set(value As String)
                City = value

            End Set
        End Property

        Public Property States() As String
            Get
                Return State
            End Get
            Set(value As String)
                State = value

            End Set
        End Property

        Public Property zips() As String
            Get
                Return Zip
            End Get
            Set(value As String)
                Zip = value

            End Set
        End Property

        Public Property aType() As String
            Get
                Return AddressType
            End Get
            Set(value As String)
                AddressType = value

            End Set
        End Property




#End Region

        Public Sub New()

        End Sub


        Public Function GetAllAdress() As DataSet
            Return DAL.dAddress.GetAllAddress(Me)
        End Function

        Public Function AddAddress() As String
            Return DAL.dAddress.AddAddress(Me)
        End Function

    End Class
End Namespace