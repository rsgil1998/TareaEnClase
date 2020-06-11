@ModelType IEnumerable(Of BEUVideo.Video)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.fecha_lanzamiento)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.categoria)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.duracion)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.fecha_lanzamiento)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.categoria)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.duracion)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
