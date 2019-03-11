Public Class page2
    Inherits System.Web.UI.Page

    Dim ds As New DataSet
    Dim rowcnt As Integer = 0
    Dim Addressid As Integer = 0
    Dim Gaddress As BAL.bAddress = New BAL.bAddress

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadStoreInfo()
        LoadAdressInfo()
    End Sub

    Public Sub LoadStoreInfo()

        Dim id As Integer = CType(Session.Item("StoreId"), Integer)
        lblId.Text = id
        Dim n As String = CType(Session.Item("StoreName"), String)
        lblName.Text = n
        Dim t As String = CType(Session.Item("StoreType"), String)
        lblty.Text = t
        Dim o As String = CType(Session.Item("OwnerName"), String)
        lblOwner.Text = o
        Dim p As String = CType(Session.Item("Phone"), String)
        lblp.Text = p
        Dim sc As Integer = CType(Session.Item("Score"), Integer)
        lblscr.Text = sc
        Dim sts As String = CType(Session.Item("Status"), String)
        lblsts.Text = sts



    End Sub

    Public Sub LoadAdressInfo()

        Dim bAdress As New BAL.bAddress

        ds = bAdress.GetAllAdress

        Dim row As Integer = ds.Tables(0).Rows.Count
        If row > 0 Then
            grdvu.DataSource = ds
            grdvu.DataBind()
        End If

    End Sub

    Protected Sub grdvu_OnSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Protected Sub grdvu_OnRowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grdvu.RowDataBound

    End Sub



    Protected Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Response.Redirect("page1.aspx")
    End Sub

    Protected Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        Dim rtn As Boolean = ValidateInput()

        If (rtn = True) Then

            'Gaddress.aId = txtAddressId.Text
            Gaddress.sId = lblId.Text
            Gaddress.St = txtStreet.Text
            Gaddress.Cities = txtCity.Text
            Gaddress.States = txtState.Text
            Gaddress.zips = txtZip.Text
            Gaddress.aType = txtAddressType.Text


            Dim rt As String = Gaddress.AddAddress

            If (rt = "Success") Then
                lblm.Text = "Rec added successfully"

            Else
                lblm.Text = "Rec not added"
            End If
        Else
            lblm.Text = "Invalid Input Data"
        End If
    End Sub

    Public Function ValidateInput()

        Dim rtn As Boolean = True

        If String.IsNullOrEmpty(txtStreet.Text) Or
                String.IsNullOrEmpty(txtCity.Text) Or
                String.IsNullOrEmpty(txtState.Text) Or
                String.IsNullOrEmpty(txtZip.Text) Or
                String.IsNullOrEmpty(txtAddressType.Text) Then
            rtn = False

        End If

        Return rtn

    End Function




End Class