@Code
    ViewData("Title") = "Index2"
End Code

<h1>格子点に沿ってドラッグ</h1>
<img id="img1" src="~/images/sample.jpg" />

@section scripts
<script>
    $("#img1").draggable({ grid: [50, 50] });
</script>
End Section



