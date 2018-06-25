@Code
    ViewData("Title") = "Index2"
End Code

@ModelType web438.MyModel

<h2>モデルを厳密に参照する</h2>
<div>ID : @Model.ID </div>
<div>Title : @Model.Title </div>
<div>Price : @Model.Price </div>

