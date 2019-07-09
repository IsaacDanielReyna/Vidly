### Cheat Sheet - ASP.NET MVC Fundmentals

**Action Results**

Type | Helper Method
---- | -------------
ViewResult | View()
PartialViewResult | PartialView()
ContentResult | Content()
RedirectResult | Redirect()
RedirectToRouteResult | RedirectToAction()
JsonResult | Json()
FileResult | File()
HttpNotFoundResult | HttpNotFound()
EmptyResult | 

---
**Action Parameters**

Sources
* Embedded in the URL: /movies/edit/1
* In the query string: /movies/edit?id=1
* In the form data

---
**Convention-based Routes**

```c#
routes.MapRoute(
  "MoviesByReleaseDate",
  "movies/released/{year}/{month}",
  new {
    controller = "Movies",
    action = "MoviesReleaseByDate"
  },
  new {
    year = @"\d{4}",
    month = @"\d{2}"
  }
);
```
---
**Attribute Routes**
```c#
[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
public ActionResult ByReleaseDate(int year, int month)
{
  return Content(year + "/" + month);
}
```
---
**Passing Data to Views**

Avoid using ViewData and ViewBag because they are fragile.
Plus, you have to do extra casting, which makes your code ugly. Pass a model (or a view model) direcly to a view:
```c#
public ActionResult Details(int id)
{
  var movie = GetMovies().SingleOrDefault(m => m.Id == id);
  if (movie == null)
    return HttpNotFound();
  return View(movie);
}
```
```c#
@model Vidly.Models.Movie
@{
  ViewBag.Title = "Details";
  Layout = "~/Views/Shared/_Layout.cshtml";
}

<h2>@Model.Name</h2>
```
---
**Razor Views**
```c#
@if(...)
{
  //C# code or HTML
}
```

```c#
@foreach(var customer in Model.Customer)
{
  <li>@customer.Name</li>
}
```

Render a class (or any attributes) conditionally:
```c#
@{
  var className = Model.Customers.Count > 5 ? "popular" : null;
}
<h2 class="@className">...</h2>
```
---
**Partial Views**

To render:
```c#
@Html.Partial("_Navbar")
```
