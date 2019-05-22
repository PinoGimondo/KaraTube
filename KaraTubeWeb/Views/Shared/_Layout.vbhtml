<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - Applicazione ASP.NET</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <nav class="navbar navbar-expand-sm navbar-dark fixed-top bg-dark">
        <div class="container">
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            @Html.ActionLink("KaraTube", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            <div class="navbar-collapse collapse" id="navbarSupportedContent">

                <ul class="nav navbar-nav mr-auto">
                    <li>@Html.ActionLink("Home", "Index", "Home", New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Informazioni", "About", "Home", New With {.class = "nav-link"})</li>
                    <li>@Html.ActionLink("Contatti", "Contact", "Home", New With {.class = "nav-link"})</li>
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </nav>

    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - KaraTube - a GIMUS.COM Application</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
