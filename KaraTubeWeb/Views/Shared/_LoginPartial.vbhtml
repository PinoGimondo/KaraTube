@Imports Microsoft.AspNet.Identity

@If Request.IsAuthenticated Then
    Dim u As User = ViewBag.user

    @Using Html.BeginForm("LogOff", "Account", FormMethod.Post, New With {.id = "logoutForm", .class = "navbar-right"})
        @Html.AntiForgeryToken()
        @<ul class="nav navbar-nav navbar-right mr-auto">
        <li class="nav-item"> @Html.ActionLink("Salve " + User.Identity.GetUserName() + "!", "Index", "Manage", routeValues:=Nothing, htmlAttributes:=New With {.title = "Manage", .class = "nav-link"}) </li>
        <li class="nav-item"><a class="nav-link" href="javascript:document.getElementById('logoutForm').submit()">Disconnetti</a></li>

        @If u.isAdmin Then
            @<li>@Html.ActionLink("Admin", "Index", "Admin", routeValues:=Nothing, htmlAttributes:=New With {.title = "Admin", .class = "nav-link"})</li>
        End If

</ul>    
    End Using
Else
@<ul class="nav navbar-nav navbar-right mr-auto">
    <li class="nav-item">@Html.ActionLink("Registrazione", "Register", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "registerLink", .class = "nav-link"})</li>
    <li class="nav-item">@Html.ActionLink("Accedi", "Login", "Account", routeValues:=Nothing, htmlAttributes:=New With {.id = "loginLink", .class = "nav-link"})</li>
</ul>
End If

