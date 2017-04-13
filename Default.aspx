<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calendar</title>
    <h1>Scheduled Events</h1>
    <link href="StyleSheet.css" rel="stylesheet" />
    <link href="StyleSheet.css" rel="stylesheet" />
    <link href="StyleSheet.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>

        <asp:Label ID="Label1" runat="server" Text="" CssClass "results"></asp:Label>

    </div>
    </form>
</body>
</html>
