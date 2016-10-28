<%@ Control Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="DateTimeText_Edit.ascx.cs" 
    Inherits="ShoeEcommers.WebAdminDynamic.DynamicData.FieldTemplates.DateTimeText_Edit" %>

<asp:DropDownList ID="DropDay" runat="server" placeholder="Día" ></asp:DropDownList>-
<asp:DropDownList ID="DropMonth" runat="server" placeholder="Mes" ></asp:DropDownList>-
<asp:DropDownList ID="DropYear" runat="server" placeholder="Año"></asp:DropDownList>
<asp:CustomValidator ID="ValidDate" runat="server" ControlToValidate="DropDay" ErrorMessage="Fecha incorrecta" CssClass="label label-danger" ClientValidationFunction="validDate" OnServerValidate="ValidDate_ServerValidate"></asp:CustomValidator>
<%#SetValue(FieldValueEditString) %>  
<script>
      function validDate(oSrc, args) {
          var idDropYear = "<% Response.Write(DropYear.ClientID);%>";
          var idDropMonth = "<% Response.Write(DropMonth.ClientID); %>";
          var idDropDay = "<% Response.Write(DropDay.ClientID); %>";
          var month = $("#" + idDropMonth).prop("selectedIndex");
          month++;
          month = ((month < 10) ? "0" : "") + month;
          var dateBirth = $("#" + idDropYear).val() + "-" + month + "-" + $("#" + idDropDay).val();
          var day = $("#" + idDropDay).val();
          var d = new Date(dateBirth + "T12:00:00");
          if (parseInt(d.getDate()) !== parseInt(day)) {
              args.IsValid = false;
              console.log("Fecha no valida");
              return;
          }
      }
  </script>