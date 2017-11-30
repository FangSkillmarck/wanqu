<%--<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>

</body>
</html>--%>
 <%@ Page Language="C#" AutoEventWireup="true" %>
<% try { Roles.CreateRole("Administrators"); } 
    catch (Exception) { } 
    try { var user = Membership.CreateUser("episerver", "episerver", "episerver@episerver.com"); user.IsApproved = true; } 
    catch (Exception) { } 
    try { }
    catch (Exception) 
    { Roles.AddUserToRole("episerver", "Administrators"); } %> 