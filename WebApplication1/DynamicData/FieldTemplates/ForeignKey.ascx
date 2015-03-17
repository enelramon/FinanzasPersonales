<%@ Control Language="VB" CodeBehind="ForeignKey.ascx.vb" Inherits="WebApplication1.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

