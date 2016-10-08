<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ShoesEcommers.WebAdmin.Index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/jquery-ui.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link rel="stylesheet" href="//netdna.bootstrapcdn.com/font-awesome/4.5.0/css/font-awesome.css"/>
</head>
<body>
    <form id="form1" runat="server">
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
                    <div class="row well well-sm text-center">
                        <h4><strong>Catálogo de Clientes</strong> </h4>
                    </div>
                    <div class="row">
                        <div class="form-group">
                            <label class="col-sm-2 control-label">Nombre</label>
        <div class="col-sm-8">
            <div class="input-group">
                <span class="input-group-addon"><i class="fa fa-user"></i></span>
                <input placeholder="Nombre"
                       type="text"
                       max="50" ng-model="name" name="name" class="form-control" required/>
            </div>
            <span class="label label-danger" 
                ng-show="frmContact.name.$error.required">¡Obligatorio!</span>
        </div>
    </div>
                        
                    </div>
                </div>
            

            </div>
        </div>
    </form>
    
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/jquery-ui.css" rel="stylesheet" />
</body>
</html>
