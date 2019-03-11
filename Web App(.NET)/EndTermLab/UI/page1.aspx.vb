Public Class page1
    Inherits System.Web.UI.Page

    Dim ds As New DataSet
    Dim rowcnt As Integer = 0
    Dim Storeid As Integer = 0
    Dim Gstore As BAL.bStore = New BAL.bStore


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadGridview()
    End Sub

    Public Sub LoadGridview()

        Dim bStore As New BAL.bStore

        ds = bStore.GetAllStores

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

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim rtn As Boolean = ValidateInput()

        If (rtn = True) Then

            'Gstore.Id = txtStoreId.Text
            Gstore.Name = txtStorename.Text
            Gstore.Type = txtStoreType.Text
            Gstore.Own = txtOwnerName.Text
            Gstore.pnum = txtPhone.Text
            Gstore.scores = txtScore.Text
            Gstore.Stat = txtStatus.Text


            Dim rt As String = Gstore.AddStore

            If (rt = "Success") Then
                lblmsg.Text = "Rec added successfully"

            Else
                lblMsg.Text = "Rec not added"
            End If
        Else
            lblMsg.Text = "Invalid Input Data"
        End If

    End Sub

    Public Function ValidateInput()

        Dim rtn As Boolean = True

        If String.IsNullOrEmpty(txtStorename.Text) Or
                String.IsNullOrEmpty(txtStoreType.Text) Or
                String.IsNullOrEmpty(txtOwnerName.Text) Or
                String.IsNullOrEmpty(txtPhone.Text) Or
                String.IsNullOrEmpty(txtScore.Text) Or
                String.IsNullOrEmpty(txtStatus.Text) Then
                rtn = False

            End If

            Return rtn

    End Function

    Protected Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Session("StoreId") = txtStoreId.Text
        Session("StoreName") = txtStorename.Text
        Session("StoreType") = txtStoreType.Text
        Session("OwnerName") = txtOwnerName.Text
        Session("Phone") = txtPhone.Text
        Session("Score") = txtScore.Text
        Session("Status") = txtStatus.Text

        Response.Redirect("page2.aspx")

    End Sub

    Protected Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Response.Redirect(HttpContext.Current.Request.Url.ToString(), True)
    End Sub
End Class