<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmNewCustomer.aspx.cs" Inherits="ShoesEcommers.WebAdmin.Catalogs.FrmNewCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Nuevo Cliente</title>
    <link href="/Content/jquery-ui.css" rel="stylesheet" />
    <link href="/Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="http://netdna.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.css"/>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <header class="navbar navbar-default navbar-static-top" role="banner">
        <div class="container">
        <div class="navbar-header">
          <button class="navbar-toggle" type="button" data-toggle="collapse" data-target=".navbar-collapse">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
            <a href="/" class="navbar-brand"><img src="http://us-cdn.sd-assets.com/media/images/shared/SD_text_logo_200x38.png"/></a>
        </div>
        <nav class="collapse navbar-collapse" role="navigation">
          <ul class="nav navbar-nav">
            <li>
              <a href="#">Get Started</a>
            </li>
            <li>
              <a href="#">Edit</a>
            </li>
            <li>
              <a href="#">Visualize</a>
            </li>
            <li>
              <a href="#">Prototype</a>
            </li>
          </ul>
        </nav>
      </div>
    </header>

        <div class="container">
            <div class="row">
                <div class="col-md-3" id="leftCol">
                    <div class="well">
                        <ul class="nav nav-stacked" id="sidebar">
                            <li>Catálogos
                          <ul>
                              <li><a href="#">Clientes</a></li>
                              <li>Productos</li>
                          </ul>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class="col-md-9">
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
                        </div>
                    </div>

                    <div class="form-group row">
                        <label class="col-sm-3 control-label">Apellido Paterno:</label>
                        <div class="col-sm-5">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <asp:TextBox ID="TxtFirstName" runat="server" CssClass="form-control" placeholder="Apellido Paterno"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    
                    <div class="form-group row">
                        <label class="col-sm-3 control-label">Apellido Materno:</label>
                        <div class="col-sm-5">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <asp:TextBox ID="TxtLastName" runat="server" CssClass="form-control" placeholder="Apellido Materno"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    
                    
                    <div class="form-group row">
                        <label class="col-sm-3 control-label">Correo:</label>
                        <div class="col-sm-5">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-envelope"></i></span>
                                <asp:TextBox ID="TxtEmail" runat="server" CssClass="form-control" placeholder="Correo"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    
                     <div class="form-group row">
                        <label class="col-sm-3 control-label">Fecha Nacimiento:</label>
                        <div class="col-sm-5">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                <asp:DropDownList ID="DropDay" runat="server" placeholder="Día"></asp:DropDownList>-
                                 <asp:DropDownList ID="DropMonth" runat="server" placeholder="Mes"></asp:DropDownList>-
                                <asp:DropDownList ID="DropYear" runat="server" placeholder="Año"></asp:DropDownList>
                            </div>
                            <asp:CustomValidator ID="ValidDate" runat="server" ControlToValidate="DropDay" ErrorMessage="Fecha incorrecta" CssClass="label label-danger" ClientValidationFunction="validDate"></asp:CustomValidator>
                        </div>
                    </div>
                    
                     <div class="form-group row">
                        <label class="col-sm-3 control-label"></label>
                        <div class="col-sm-5">
                           <asp:Button ID="BtnSave" runat="server" Text="Guardar" CssClass="btn btn-success btn-sm" />
                        </div>
                    </div>

                </div>
            </div>
        </div>
    
    </div>
    </form>
    <script src="../Scripts/jquery.min.js"></script>
    <script src="../Scripts/jquery-ui.min.js"></script>
    
    
      <script  >
          function validDate(oSrc, args) {
              var idDropYear = "<% Response.Write(DropYear.ClientID);%>";
              var idDropMonth = "<% Response.Write(DropMonth.ClientID); %>";
              var idDropDay = "DropDay";
              var month = $("#" + idDropMonth).prop("selectedIndex");
              
              month++;
              month = ((month < 10) ? "0" : "") + month;
              var dateBirth = $("#" + idDropYear).val() + "-" + month + "-" + $("#" + idDropDay).val();
              var day = $("#" + idDropDay).val();
              var d = new Date(dateBirth);
              if (parseInt(d.getDate()) !== (parseInt(day)-1)) {
                  args.IsValid = false;
                  console.log("Fecha no valida");
                  return;
              }
          }
    </script>
</body>
</html>
