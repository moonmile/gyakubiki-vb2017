@Imports web439

@Code
    ViewData("Title") = "Index2"

    Dim model As New MyModel() With
    {
        .ID = 100,
        .Title = "逆引き大全VB2017サンプル",
        .Price = 2000
    }
End Code

<h2>View 内でモデルを生成する</h2>
<div>ID : @model.ID </div>
<div>Title : @model.Title </div>
<div>Price : @model.Price </div>
