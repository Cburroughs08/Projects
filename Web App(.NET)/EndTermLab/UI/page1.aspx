<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="page1.aspx.vb" Inherits="EndTermLab.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="page1" runat="server">
    <div>
    <table>

        <tr>
                     <td> <asp:Label ID="lblStoreId" runat="server" Text="StoreId"></asp:Label></td>
                    <td><asp:TextBox ID="txtStoreId" runat="server" Enabled="False"></asp:TextBox></td>
        </tr>

        <tr>
                     <td> <asp:Label ID="lblStoreName" runat="server" Text="StoreName"></asp:Label></td>
                    <td><asp:TextBox ID="txtStorename" runat="server"></asp:TextBox></td>
                     <td> <asp:Label ID="lblStoreType" runat="server" Text="StoreType"></asp:Label></td>
                    <td><asp:TextBox ID="txtStoreType" runat="server"></asp:TextBox></td>
            <td> <asp:Label ID="lblcp" runat="server" Text="(C/P) Corp or Private"></asp:Label></td>
        </tr>

        <tr>
                  <td> <asp:Label ID="lblOwnerName" runat="server" Text="OwnerName"></asp:Label></td>
                    <td><asp:TextBox ID="txtOwnerName" runat="server"></asp:TextBox></td>
                     <td> <asp:Label ID="lblPhone" runat="server" Text="Phone#"></asp:Label></td>
                    <td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
                 <td> <asp:Label ID="lblScore" runat="server" Text="Score"></asp:Label></td>
                    <td><asp:TextBox ID="txtScore" runat="server"></asp:TextBox></td>
                     <td> <asp:Label ID="lblStatus" runat="server" Text="Status"></asp:Label></td>
                    <td><asp:TextBox ID="txtStatus" runat="server"></asp:TextBox></td>
            <td> <asp:Label ID="lblaip" runat="server" Text="(A/I/P) Active, Inactive, Pending"></asp:Label></td>
        </tr>

        <tr>
            <td>            
                <asp:Button ID="btnAdd" runat="server" Text="Add" />
            </td>
             <td>            
                <asp:Button ID="btnUpdate" runat="server" Text="Update" />
            </td>
             <td>            
                <asp:Button ID="btnRefresh" runat="server" Text="Refresh" />
            </td>
             <td>            
                <asp:Button ID="btnNext" runat="server" Text="Next" />
             
            </td>
             <td> <asp:Label ID="lblmsg" runat="server" Text="Running"></asp:Label></td>
        </tr>

    </table>

        <table>

                <tr><td colspan="1">

                    <asp:GridView ID="grdvu" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="5" OnRowDataBound="grdvu_OnRowDataBound"
                        OnSelectedIndexChanged="grdvu_OnSelectedIndexChanged">
                        <Columns>
                            <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="20" />
                               <asp:BoundField DataField="StoreId" HeaderText="StoreId">
                                  </asp:BoundField >
                             <asp:BoundField DataField="StoreName" HeaderText="StoreName">
                                  </asp:BoundField >
                              <asp:BoundField DataField="StoreType" HeaderText="StoreType">
                                  </asp:BoundField >
                              <asp:BoundField DataField="OwnerName" HeaderText="OwnerName">
                                  </asp:BoundField >
                               <asp:BoundField DataField="Phone" HeaderText="Phone">
                                  </asp:BoundField >
                                <asp:BoundField DataField="Score" HeaderText="Score">
                                  </asp:BoundField >
                                <asp:BoundField DataField="Status" HeaderText="Status">
                                  </asp:BoundField >
                        </Columns>

                    </asp:GridView>

               </td> </tr>
        </table>





    </div>
    </form>
</body>
</html>
