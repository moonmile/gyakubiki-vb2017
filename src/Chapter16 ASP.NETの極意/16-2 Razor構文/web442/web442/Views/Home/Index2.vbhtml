@Code
    ViewData("Title") = "Index2"
End Code

@ModelType List(Of web442.MyModel)
<h2>If 文で条件分岐する</h2>

@If Model.Count = 0 Then
    @<div>書籍データがありません。</div>
Else
    @<table border="1">
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
End If

