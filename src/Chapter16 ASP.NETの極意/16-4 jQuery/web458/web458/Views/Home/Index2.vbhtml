﻿@Code
    ViewData("Title") = "Index2"
End Code

<h1>画像のクリックで切り替える</h1>
<img id="img1" src="/images/sample.jpg" />

@section scripts
<script>
    $(function () {
        $("#img1").click(
            function () {
                $("#img1").attr("src", "/images/sample2.jpg");
            });
    });
</script>
End Section
