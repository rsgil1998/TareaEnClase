@ModelType BEUVideo.Video
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
