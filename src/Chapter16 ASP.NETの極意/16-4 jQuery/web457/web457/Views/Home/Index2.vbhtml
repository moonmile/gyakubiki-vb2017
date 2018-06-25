@Code
    ViewData("Title") = "Index2"
End Code

<h1>見出し</h1>
<p class="cls1">文章を入れる</p>
<h1>見出し</h1>
<p class="cls1">文章を入れる</p>
@section scripts
<script>
    $(function () {
        $(".cls1").css("font-size", "small");
    });
</script>
End Section







