<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicForm.aspx.cs" Inherits="EvidencijaNezaposlenih.Interfejs.DynamicForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dynamic Form</title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            // Function to add a new row
            $("#btnAddRow").click(function () {
                // Clone the first row
                var newRow = $("#rowTemplate").clone();
                // Increment the IDs
                newRow.find("select").attr("id", function (_, id) {
                    return id.replace(/(\d+)/, function (match, p1) {
                        return parseInt(p1) + 1;
                    });
                });
                newRow.find("input[type='text']").attr("id", function (_, id) {
                    return id.replace(/(\d+)/, function (match, p1) {
                        return parseInt(p1) + 1;
                    });
                });
                // Append the new row
                newRow.appendTo("#formTable");
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="formTable">
                <tr id="rowTemplate">
                    <td>
                        <select id="combo1">
                            <!-- Populate this with your combo box options -->
                            <option value="1">Option 1</option>
                            <option value="2">Option 2</option>
                            <!-- Add more options as needed -->
                        </select>
                    </td>
                    <td>
                        <input type="text" id="date1" class="datepicker" />
                    </td>
                    <td>
                        <input type="text" id="date2" class="datepicker" />
                    </td>
                </tr>
            </table>
            <input type="button" id="btnAddRow" value="+" />
        </div>
    </form>
    <script>
        $(document).ready(function () {
            // Initialize datepickers
            $(".datepicker").datepicker();
        });
    </script>
</body>
</html>
