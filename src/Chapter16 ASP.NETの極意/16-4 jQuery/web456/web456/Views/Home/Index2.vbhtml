@Code
    ViewData("Title") = "Index2"
End Code

<h1 id="id1">ここの色を変える</h1>
<p>文章を入れる</p>
<h1 id="id2">ここの色は変わらない</h1>
<p>文章を入れる</p>
@section scripts
<script>
    $(function () {
        $("#id1").css("background", "yellow");
    });
</script>
End Section

