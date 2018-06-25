﻿@Code
    ViewData("Title") = "Index2"
End Code

<style>
    <!--
    #sort1 {
        list-style-type: none;
    }

        #sort1 li {
            margin: 3px;
            padding: 3px;
            width: 200px;
            background: lightgray;
        }
    -->
</style>

<h1>並べ替えができるリスト</h1>
<ul id="sort1">
    <li>項目A</li>
    <li>項目B</li>
    <li>項目C</li>
    <li>項目D</li>
    <li>項目E</li>
</ul>
@section scripts
<script>
    $('#sort1').sortable({
        cursor: 'move',
        opacity: 0.5,
    });
    $('#sort1').disableSelection();
</script>
End Section

