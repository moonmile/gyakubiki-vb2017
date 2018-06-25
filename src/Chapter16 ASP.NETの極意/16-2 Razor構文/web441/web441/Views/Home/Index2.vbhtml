@Code
    ViewData("Title") = "Index2"
End Code

@ModelType List(Of web441.MyModel)
<h2>For Eachでループ表示</h2>
<table border="1">
    <tr>
        <th>ID</th>
        <th>タイトル</th>
        <th>価格</th>
    </tr>
    @For Each item In Model
        @<tr>
            <td>@item.ID</td>
            <td>@item.Title</td>
            <td>@item.Price 円</td>
        </tr>
    Next
</table>

