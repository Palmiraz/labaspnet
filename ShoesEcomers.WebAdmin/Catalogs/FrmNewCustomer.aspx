

<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="FrmNewCustomer.aspx.cs" 
    Inherits="ShoesEcommers.WebAdmin.Catalogs.FrmNewCustomer" 
    MasterPageFile="~/Masters/MasterGlobal.Master" %>

<%@ Register Src="~/Controls/CtlDate.ascx" TagPrefix="uc1" TagName="CtlDate" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                
                    <div class="well text-center">
                        <strong>Nuevo Cliente</strong>
                    </div>
                    
                    <div class="form-group row">
                        <label class="col-sm-3 control-label">Nombre:</label>
                        <div class="col-sm-5">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control" placeholder="Nombre"></asp:TextBox>
                            </div>
                            <asp:RequiredFieldValidator 
                                ID="ValidName" 
                                runat="server" 
                                ErrorMessage="(requerido)"
                                ControlToValidate="TxtName"
                                CssClass="label label-danger"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="form-group row">
                        <label class="col-sm-3 control-label">Apellido Paterno:</label>
                        <div class="col-sm-5">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <asp:TextBox ID="TxtFirstName" runat="server" CssClass="form-control" placeholder="Apellido Paterno"></asp:TextBox>
                            </div>
                             <asp:RequiredFieldValidator 
                                ID="ValidFirstName" 
                                runat="server" 
                                ErrorMessage="(requerido)"
                                ControlToValidate="TxtFirstName"
                                CssClass="label label-danger"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    
                    <div class="form-group row">
                        <label class="col-sm-3 control-label">Apellido Materno:</label>
                        <div class="col-sm-5">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <asp:TextBox ID="TxtLastName" runat="server" CssClass="form-control" placeholder="Apellido Materno"></asp:TextBox>
                            </div>
                            <asp:RequiredFieldValidator 
                                ID="ValidLastName" 
                                runat="server" 
                                ErrorMessage="(requerido)"
                                ControlToValidate="TxtLastName"
                                CssClass="label label-danger"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    
                    
                    <div class="form-group row">
                        <label class="col-sm-3 control-label">Correo:</label>
                        <div class="col-sm-5">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-envelope"></i></span>
                                <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" placeholder="Correo"></asp:TextBox>
                            </div>
                              <asp:RequiredFieldValidator 
                                ID="ValidEmail" 
                                runat="server" 
                                ErrorMessage="(requerido)"
                                ControlToValidate="TxtEmail"
                                CssClass="label label-danger"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator 
                                ID="ValidFormatEmail" 
                                runat="server" 
                                ErrorMessage="(formato incorrecto)"
                                ControlToValidate="TxtEmail"
                                CssClass="label label-danger" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>


                        </div>
                    </div>
                    
                     <div class="form-group row">
                        <label class="col-sm-3 control-label">Fecha Nacimiento:</label>
                        <div class="col-sm-5">
                            <div class="input-group">
                                <uc1:CtlDate runat="server" ID="CtlDate" />
                            </div>
                            
                        </div>
                    </div>
                    
                     <div class="form-group row">
                        <label class="col-sm-3 control-label"></label>
                        <div class="col-sm-5">
                            <asp:Button ID="BtnCancel" 
                                runat="server" 
                                Text="Cancelar" 
                                CausesValidation="false"
                                CssClass="btn btn-warning btn-sm"  
                                PostBackUrl="~/Catalogs/FrmCustomers.aspx" />
                           <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success btn-sm" OnClick="BtnSave_Click" />
                        </div>
                    </div>
    
                    <div class="form-group row">
                        <label class="col-sm-3 control-label"></label>
                        <div class="col-sm-8" id="ContentMessage" runat="server">
                            <asp:Label ID="LblMessage" runat="server" Text="" ClientIDMode="Predictable"></asp:Label>
                        </div>
                    </div>
                    <asp:HiddenField ID="HiddId" runat="server" />
</asp:Content>