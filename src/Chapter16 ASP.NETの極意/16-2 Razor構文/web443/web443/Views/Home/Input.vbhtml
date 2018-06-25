@ModelType web443.MyModel

@Code
    ViewData("Title") = "Input"
End Code

<h2>フォーム入力</h2>
@Using Html.BeginForm("Post", "Home")
    @<table border="0">
        <tr>
            <td>ID</td>
            <td>@Html.TextBoxFor(Function(x) x.ID)</td>
        </tr>
        <tr>
            <td>タイトル</td>
            <td>@Html.TextBoxFor(Function(x) x.Title)</td>
        </tr>
        <tr>
            <td>価格</td>
            <td>@Html.TextBoxFor(Function(x) x.Price)</td>
        </tr>
    </table>
    @<input type="submit" value="登録" />
End Using

