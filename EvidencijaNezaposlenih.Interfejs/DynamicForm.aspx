<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicForm.aspx.cs" Inherits="EvidencijaNezaposlenih.Interfejs.DynamicForm" Async="true" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Submit Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Content of your page -->
            <h1>Submit Page</h1>
            <!-- Add your form fields here if needed -->
            
            <!-- Submit Button -->
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
