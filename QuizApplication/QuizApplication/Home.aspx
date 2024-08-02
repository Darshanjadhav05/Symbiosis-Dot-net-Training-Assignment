<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="QuizApplication.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <style>
        #Button1{
            background-color: #43c043;
    border: none;
    border-radius: 3px;
    padding: 11px;
    margin-left: 20px;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome To Quiz App</h1>

        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate Quiz" />
    </form>
</body>
</html>
