@ModelType web454.商品
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>商品</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.商品名)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.商品名)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.単価)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.単価)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.商品ID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
