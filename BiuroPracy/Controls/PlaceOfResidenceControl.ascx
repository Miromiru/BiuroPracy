<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PlaceOfResidenceControl.ascx.cs" Inherits="BiuroPracy.Controls.PlaceOfResidenceControl" %>
<div class="form-group">
    <label class="control-label col-sm-2">Ulica:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtUlica" class="form-control" runat="server"></asp:TextBox>
    <!--    <asp:RequiredFieldValidator ID="tfvEmail" ControlToValidate="txtUlica" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator> -->
    </div>
</div>
<div class="form-group">
    <label class="control-label col-sm-2">Kod pocztowy:</label>
    <div class="col-sm-10">
        <asp:TextBox ID="txtKodPocztowy" class="form-control" runat="server"></asp:TextBox>
    <!--    <asp:RequiredFieldValidator ID="tfvKodPocztowy" ControlToValidate="txtKodPOcztowy" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator> -->
    </div>
</div>
<div class="form-group">
    <label class="control-label col-sm-2">Miasto:</label>
    <div class="col-sm-10">
        <asp:DropDownList ID="ddlMiasto" runat="server"></asp:DropDownList>
       <!-- <asp:RequiredFieldValidator ID="tfvMiasto" ControlToValidate="ddlMiasto" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator> -->
    </div>
</div>
<div class="form-group">
    <label class="control-label col-sm-2">Kraj:</label>
    <div class="col-sm-10">
        <asp:DropDownList ID="ddlKraj" runat="server"></asp:DropDownList>
      <!-- <asp:RequiredFieldValidator ID="tvfKraj" ControlToValidate="ddlKraj" runat="server" ErrorMessage="Wymagane pole"></asp:RequiredFieldValidator> -->
    </div>
</div>