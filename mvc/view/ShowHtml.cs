@model ExamWebApp.Models.Employee

@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>ShowHtml</title>
</head>
<body>
    <h1>Employee Details</h1>
    <hr />
    <div>
        <p>ID: @Model.EmpID</p>
        <p>Name: @Model.EmpName</p>
        <p>Address: @Model.EmpAddress</p>
        <p>Salary: @Model.EmpSalary</p>
    </div>
</body>
</html>