@Code
    ViewData("Title") = "Index2"
End Code

<h1>垂直方向にのみドラッグする</h1>
<img id="img1" src="~/images/sample.jpg" />

@section scripts
<script>
    $("#img1").draggable({ axis: 'y' });
</script>
End Section





