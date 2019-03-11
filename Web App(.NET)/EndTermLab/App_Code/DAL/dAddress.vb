Imports System.Data
Namespace DAL
    Public Class dAddress

        Public Shared Function GetAllAddress(ByVal b As BAL.bAddress) As DataSet

            'when connecting with access
            '***************************
            Dim ds As New DataSet
            Dim daOledb As OleDb.OleDbDataAdapter
            Dim conOledb As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Adv VB\EndTerm.accdb")
            Dim sql As String = "SELECT * from Address"




            If conOledb.State = ConnectionState.Open Then
                conOledb.Close()
            End If

            Try
                conOledb.Open()

                daOledb = New OleDb.OleDbDataAdapter(sql, conOledb)
                daOledb.Fill(ds)  'pulls data here
                conOledb.Close()

            Catch ex As Exception
                'MsgBox("Can not open access connection ! ")
            End Try
            'End Access

            'when connecting with oracle
            '***************************
            'Dim dtsrc As String = "orcl" ' servername   
            'Dim dbid As String = "hr"  'usernm
            'Dim pwrd As String = "hr"

            'Dim connstringOra As String = "Data Source=" + dtsrc + ";Persist Security Info=True;User ID=" + dbid + ";Password=" + pwrd + ";Unicode=True"
            'Dim connOra As OracleConnection
            'Dim commOra As OracleCommand
            'Sql = "Select Employee_Id, First_Name, Last_Name, Email, Phone_Number from Employees"

            'connOra = New OracleConnection(connstringOra)

            'If connOra.State = ConnectionState.Open Then
            '    connOra.Close()
            'End If

            'Try
            '    connOra.Open()
            '    commOra = New OracleCommand(Sql, connOra)
            '    Dim daOra As OracleDataAdapter = New OracleDataAdapter(Sql, connOra)
            '    commOra.ExecuteNonQuery()
            '    daOra.Fill(ds)
            '    commOra.Dispose()
            '    connOra.Close()

            'Catch ex As Exception
            '    MsgBox("Can not open oracle connection ! ")
            'End Try
            'End Oracle

            Return ds

        End Function


        Public Shared Function AddAddress(ByVal b As BAL.bAddress) As String

            Dim ds As New DataSet
            Dim rtn As String = ""
            Dim sql As String = ""

            Dim myCommand As New OleDb.OleDbCommand
            Dim dt As New DataTable


            Dim myConnection As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\Adv VB\EndTerm.accdb")




            sql = "select max(AddressId) as maxAddressId from Address"
            myConnection.Open()
            myCommand = New OleDb.OleDbCommand(sql, myConnection)

            dt.Load(myCommand.ExecuteReader)
            Dim max As Integer = dt.Rows(0).Item(0)


            If String.IsNullOrEmpty(max) Then
                b.aId = 1
            Else
                b.aId = max + 1

            End If


            If myConnection.State = ConnectionState.Open Then
                myConnection.Close()
            End If


            'create sql string for insert
            sql = ""
            sql = "Insert into Address (AddressId, StoreId, Street, City, State, Zip, AddressType) Values ("
            sql = sql & b.aId & ","
            sql = sql & b.sId & ",'"
            sql = sql & b.St & "','"
            sql = sql & b.Cities & "','"
            sql = sql & b.States & "','"
            sql = sql & b.zips & "','"
            sql = sql & b.aType & "')"


            myConnection.Open()
            myCommand = New OleDb.OleDbCommand(sql, myConnection)

            Try
                myCommand.ExecuteNonQuery()  'rec is physically added here
                myConnection.Close()
                rtn = "Success"

            Catch ex As Exception
                rtn = "Error"

            End Try

            Return rtn

        End Function

    End Class
End Namespace