@Code
    ViewData("Title") = "Index2"
    Dim msg = String.Format(
        "コントローラーで {0} 設定", ViewBag.Flag)
End Code

<h2>View 内でコードを記述する</h2>
<div>@msg</div>
