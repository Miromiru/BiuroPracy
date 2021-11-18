<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="BiuroPracy.AddEmployee" %>
<%@ Register TagPRefix="employee" TagName="AddEmployeeControl" Src="Controls/AddemployeeControl.ascx" %>
<%@ Register TagPRefix="employee" TagName="PlaceOfResidenceControl" Src="Controls/PlaceOfResidenceControl.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <h4>Dodawanie pracowników</h4>
    <div class="bodyForm">
        <employee:AddEmployeeControl ID="crtlAddEMployee" runat="server" />
        <employee:PlaceOFResidenceControl ID="crtlPlaceOfResidenceControl" runat="server" />
        <div class="form-group">

                <asp:Button ID="btnSave" CssClass="btn-primary" runat="server" Text="Zapisz" />
        </div>
        <div class="form-group">

                <asp:Button ID="btnTestNHibernate" OnCLick="btnTestNHibernate_Click" runat="server" Text="TestNHibernate" />
        </div>
    </div>
</asp:Content>