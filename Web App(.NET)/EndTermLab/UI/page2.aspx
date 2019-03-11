<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="page2.aspx.vb" Inherits="EndTermLab.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="page2" runat="server">
    <div>
    
        <table>

            <tr>
                 <td> <asp:Label ID="lblsId" runat="server" Text="StoreId: "></asp:Label></td>
                  <td> <asp:Label ID="lblId" runat="server" Text="_"></asp:Label></td>
            </tr>

            <tr>               
                   <td> <asp:Label ID="lblsName" runat="server" Text="StoreName: "></asp:Label></td>
                 <td> <asp:Label ID="lblName" runat="server" Text="_"></asp:Label></td>
                 <td> <asp:Label ID="lbltype" runat="server" Text="StoreType: "></asp:Label></td>
                  <td> <asp:Label ID="lblty" runat="server" Text="_"></asp:Label></td>
                 <td> <asp:Label ID="lbloName" runat="server" Text="OwnerName: "></asp:Label></td>
                 <td> <asp:Label ID="lblOwner" runat="server" Text="_"></asp:Label></td>
            </tr>

             <tr>
                 <td> <asp:Label ID="lblpnum" runat="server" Text="Phone: "></asp:Label></td>
                  <td> <asp:Label ID="lblp" runat="server" Text="_"></asp:Label></td>
                   <td> <asp:Label ID="lblsc" runat="server" Text="Score: "></asp:Label></td>
                 <td> <asp:Label ID="lblscr" runat="server" Text="_"></asp:Label></td>
                 <td> <asp:Label ID="lblstat" runat="server" Text="Status: "></asp:Label></td>
                 <td> <asp:Label ID="lblsts" runat="server" Text="_"></asp:Label></td>
                 
            </tr>
           
             <tr>
                  <td> <asp:Label ID="lblAddressId" runat="server" Text="AddressId"></asp:Label></td>
                    <td><asp:TextBox ID="txtAddressId" runat="server"></asp:TextBox></td>
                 
                     <td> <asp:Label ID="lblStreet" runat="server" Text="Street"></asp:Label></td>
                    <td><asp:TextBox ID="txtStreet" runat="server"></asp:TextBox></td>
        </tr>

             <tr>
                  <td> <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label></td>
                    <td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td>
                     <td> <asp:Label ID="lblState" runat="server" Text="State"></asp:Label></td>
                    <td><asp:TextBox ID="txtState" runat="server"></asp:TextBox></td>
        </tr>

             <tr>
                  <td> <asp:Label ID="lblZip" runat="server" Text="Zip"></asp:Label></td>
                    <td><asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td>
                     <td> <asp:Label ID="lblAddressType" runat="server" Text="AddressType"></asp:Label></td>
                    <td><asp:TextBox ID="txtAddressType" runat="server"></asp:TextBox></td>
                  <td> <asp:Label ID="lblmp" runat="server" Text="(M/P) Mailing or Physical"></asp:Label></td>
        </tr>

             <tr>
            <td>            
                <asp:Button ID="btnAdd2" runat="server" Text="Add" />
            </td>
             <td>            
                <asp:Button ID="btnPrevious" runat="server" Text="Prev" />
            </td>
            
             <td> <asp:Label ID="lblm" runat="server" Text="Running"></asp:Label></td>
        </tr>

        </table>

         <table>

                <tr><td>

                    <asp:GridView ID="grdvu" runat="server" AutoGenerateColumns="false" AllowPaging="true" PageSize="5" OnRowDataBound="grdvu_OnRowDataBound"
                        OnSelectedIndexChanged="grdvu_OnSelectedIndexChanged">
                        <Columns>
                            <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="20" />
                               <asp:BoundField DataField="AddressId" HeaderText="AddressId">
                                  </asp:BoundField >
                             <asp:BoundField DataField="StoreId" HeaderText="StoreId">
                                  </asp:BoundField >
                             <asp:BoundField DataField="Street" HeaderText="Street">
                                  </asp:BoundField >
                              <asp:BoundField DataField="City" HeaderText="City">
                                  </asp:BoundField >
                              <asp:BoundField DataField="State" HeaderText="State">
                                  </asp:BoundField >
                               <asp:BoundField DataField="Zip" HeaderText="Zip">
                                  </asp:BoundField >
                                <asp:BoundField DataField="AddressType" HeaderText="AddressType">
                                  </asp:BoundField >
                                
                        </Columns>

                    </asp:GridView>

               </td> </tr>
        </table>







    </div>
    </form>
</body>
</html>
