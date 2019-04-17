@using $rootnamespace$
@model PageViewModel<ProductPage>

@{ Layout = "~/Views/Shared/Layouts/_TwoPlusOne.cshtml"; }

<h1 @Html.EditAttributes(x => x.CurrentPage.PageName)>@Model.CurrentPage.PageName</h1>
<p class="introduction" @Html.EditAttributes(x => x.CurrentPage.MetaDescription)>@Model.CurrentPage.MetaDescription</p>
<div class="row">
    <div class="span8 clearfix" @Html.EditAttributes(x => x.CurrentPage.MainBody)>
        @Html.DisplayFor(m => m.CurrentPage.MainBody)
    </div>
</div>
@Html.PropertyFor(x => x.CurrentPage.MainContentArea, new { CssClass = "row", Tag = Global.ContentAreaTags.TwoThirdsWidth })

@section RelatedContent
{
    <div @Html.EditAttributes(x => x.CurrentPage.PageImage)>
        <img src="@Url.ContentUrl(Model.CurrentPage.PageImage)"/>
    </div>

    <div class="block colorBox @string.Join(" ", @Model.CurrentPage.GetThemeCssClassNames())">
        <h2 @Html.EditAttributes(x => x.CurrentPage.PageName)>@Model.CurrentPage.PageName</h2>
        @Html.PropertyFor(x => x.CurrentPage.UniqueSellingPoints)
    </div>

    @Html.PropertyFor(x => x.CurrentPage.RelatedContentArea, new { CssClass = "row", Tag = Global.ContentAreaTags.OneThirdWidth })
}
