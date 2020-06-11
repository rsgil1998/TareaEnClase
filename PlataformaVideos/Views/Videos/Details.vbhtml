@ModelType BEUVideo.Video
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>Video</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.fecha_lanzamiento)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.fecha_lanzamiento)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.categoria)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.categoria)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.duracion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.duracion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
