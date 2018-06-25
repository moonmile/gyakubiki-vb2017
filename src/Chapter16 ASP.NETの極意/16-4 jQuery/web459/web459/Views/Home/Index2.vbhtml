﻿@Code
    ViewData("Title") = "Index2"
End Code

<h1>画像を移動させる</h1>
<img id="img1" src="~/images/sample.jpg" />

@section scripts
<script>
    $(function () {
        $("#img1").click(
            function () {
                $("#img1").animate({ 'marginLeft': '300px' });
            });
    });
</script>
End Section


