<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="UrunGuncelle.aspx.cs" Inherits="ASP_Project.Urun.UrunGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form runat="server" class="form-group">
        <div>
            <asp:Label ID="Label1" runat="server" Text="ÜRÜN AD" Font-Bold="true"></asp:Label>

            <asp:TextBox ID="TxtUrunAd" runat="server" placeholder="Ürün Adını Girin" CssClass="form-control"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:Label ID="Label2" runat="server" Text="MARKA" Font-Bold="true"></asp:Label>

            <asp:TextBox ID="TxtMarka" runat="server" placeholder="Marka Adını Girin" CssClass="form-control"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:Label ID="Label3" runat="server" Text="KATEGORİ" Font-Bold="true"></asp:Label>

            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>

        <br />

        <div>
            <asp:Label ID="Label4" runat="server" Text="FİYAT" Font-Bold="true"></asp:Label>

            <asp:TextBox ID="TxtFiyat" runat="server" placeholder="Fiyat Girin" CssClass="form-control"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:Label ID="Label5" runat="server" Text="STOK" Font-Bold="true"></asp:Label>

            <asp:TextBox ID="TxtStok" runat="server" placeholder="Stok Girin" CssClass="form-control"></asp:TextBox>
        </div>

        <br />

        <div>
            <asp:Button ID="Button1" runat="server" Text="Ürün Güncelle" CssClass="btn btn-primary" OnClick="Button1_Click" />
        </div>
    </form>

</asp:Content>
