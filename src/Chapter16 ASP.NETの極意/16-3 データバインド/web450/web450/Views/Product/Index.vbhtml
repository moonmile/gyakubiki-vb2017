@ModelType IEnumerable(Of web450.商品)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.商品名)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.単価)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.商品名)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.単価)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.商品ID }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.商品ID }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.商品ID })
        </td>
    </tr>
Next

</table>
