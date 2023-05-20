@ModelType IEnumerable(Of CarInsurance.Insuree)

@Code
    ViewData("Title") = "Admin"
End Code

<h2>Admin</h2>

<table class="table">
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Email Address</th>
        <th>Quote</th>
    </tr>

    @For Each insuree In Model
        @<tr>
            <td>@insuree.FirstName</td>
            <td>@insuree.LastName</td>
            <td>@insuree.EmailAddress</td>
            <td>@insuree.Quote</td>
        </tr>
    Next
</table>

<div>
    @Html.ActionLink("Back to List", "Index")
</div>
