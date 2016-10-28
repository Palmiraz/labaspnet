<%@ Page Title="" Language="C#" MasterPageFile="~/Masters/MasterGlobal.Master" AutoEventWireup="true" CodeBehind="LoadCategories.aspx.cs" Inherits="ShoesEcommers.WebAdmin.UploadData.LoadCategories" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Subir Categorias:<asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="BtnUpload" CssClass="btn btn-success" runat="server" OnClick="BtnUpload_Click" Text="Subir Información" />
&nbsp;</p>
</asp:Content>
