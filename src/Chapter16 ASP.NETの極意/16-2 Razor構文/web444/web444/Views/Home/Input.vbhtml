@ModelType web444.MyModel

@Code
    ViewData("Title") = "Input"
End Code

<style>
    .inp {
        font-size: 20px;
        background-color: blue;
        color: white;
    }
</style>
<h2>フォーム入力</h2>

<div>@ViewData("Message")</div>

@Using Html.BeginForm("Post", "Home")
    @<table border="0">
        <tr>
            <td>ID</td>
            <td>@Html.TextBoxFor(
                          Function(x) x.ID,
                          New With {.class = "inp"})</td>
        </tr>
        <tr>
            <td>タイトル</td>
            <td>@Html.TextBoxFor(
                          Function(x) x.Title,
                          New With {.class = "inp"})</td>
        </tr>
        <tr>
            <td>価格</td>
            <td>@Html.TextBoxFor(
                          Function(x) x.Price,
                          New With {.class = "inp"})</td>
        </tr>
    </table>
    @<input type="submit" value="登録" />
End Using
