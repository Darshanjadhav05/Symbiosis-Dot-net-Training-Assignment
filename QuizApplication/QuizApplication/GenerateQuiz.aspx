<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GenerateQuiz.aspx.cs" Inherits="QuizApplication.GenerateQuiz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
        .wrong-answer {
            color: red;
        }
        .correct-answer{
            color:green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <asp:Repeater ID="QuizRepeater" runat="server" OnItemDataBound="QuizRepeater_ItemDataBound">
            <ItemTemplate>
                <h3><%# Eval("Text") %></h3>
                <asp:HiddenField ID="QuestionId" runat="server" Value='<%# Eval("Id") %>' />
                <asp:RadioButtonList ID="Options" runat="server">
                </asp:RadioButtonList>
                <asp:Label ID="FeedbackLabel" runat="server" Text="" />
            </ItemTemplate>
        </asp:Repeater>
        <asp:Button ID="SubmitQuiz" runat="server" Text="Submit Quiz" OnClick="SubmitQuiz_Click" />
        <asp:Label ID="ResultLabel" runat="server" Text="" />
    </form>
</body>
</html>
