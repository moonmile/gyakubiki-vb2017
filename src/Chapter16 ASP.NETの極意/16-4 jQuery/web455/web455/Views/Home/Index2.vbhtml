@Code
    ViewData("Title") = "Index2"
End Code

<h1>ここの色を変える</h1>
<p>文章を入れる</p>
<h1>ここの色も変える</h1>
<p>文章を入れる</p>
@section scripts
<script>
        $(function () {
            $("h1").css("color", "red");
        });
</script>
End Section
