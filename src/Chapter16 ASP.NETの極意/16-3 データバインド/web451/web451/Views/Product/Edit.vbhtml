@ModelType web451.商品
@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>商品</h4>
        <hr />
        @Html.ValidationSummary(True, "",
                                             New With {.class = "text-danger"})
        @Html.HiddenFor(Function(model) model.商品ID)

        <div class="form-group">
            @Html.LabelFor(
                         Function(model) model.商品名,
                         htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(
                         Function(model) model.商品名,
                         New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(
                         Function(model) model.商品名, "",
                         New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.単価, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.単価, New With { .htmlAttributes = New With { .class = "form-control" } })
                @Html.ValidationMessageFor(Function(model) model.単価, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Save" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
End Section
