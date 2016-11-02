<%@ Page Language="C#" 
    AutoEventWireup="false"  
    CodeBehind="FrmCustomers.aspx.cs" 
    Inherits="ShoesEcommers.WebAdmin.Catalogs.FrmCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Clientes</title>
    
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
                          <ul >
                              <li> <a href="#">Clientes</a></li>
                              <li>Productos</li>
                          </ul>
                      </li>
              	    </ul>
  				    </div>
      		    </div>  
                <div class="col-md-9">
                    <div class="form-group row">
                        <label class="col-sm-2 control-label">Buscar por nombre:</label>
                        <div class="col-sm-3">
                            <div class="input-group">
                                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-sm-2">
                            <asp:Button ID="Button1" runat="server" Text="Buscar" CssClass="btn btn-success" OnClick="Button1_Click" />
                        </div>
                    </div>
                    
                    <div class="row">
                        <asp:GridView ID="GridCustomer" runat="server" CssClass="table" GridLines="None" AutoGenerateColumns="False" DataSourceID="ObjectCustomer">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                                <asp:BoundField DataField="DateBirth" HeaderText="DateBirth" SortExpression="DateBirth" />
                                <asp:BoundField DataField="DateCreated" HeaderText="DateCreated" SortExpression="DateCreated" />
                                <asp:BoundField DataField="DateUpdate" HeaderText="DateUpdate" SortExpression="DateUpdate" />
                            </Columns>
                        </asp:GridView>
                        
                        <asp:ObjectDataSource ID="ObjectCustomer" runat="server" SelectMethod="GetCustomers" TypeName="ShoeEcommers.LogicLayer.Repositories.CustomerRepository">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="TxtName" Name="name" PropertyName="Text" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                        
                    </div>


                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
