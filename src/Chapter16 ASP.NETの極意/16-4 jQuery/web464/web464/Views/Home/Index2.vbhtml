@Code
    ViewData("Title") = "Index2"
End Code

<h1>カレンダーで選択</h1>
<input type="text" id="cal1" />

@section scripts
<script>
    $(function () {
        $("#cal1").datepicker();
        $("#cal1").datepicker("option", "showOn", 'both');
    });
</script>
End Section


