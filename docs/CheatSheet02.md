### Entity Framework

**Code-first Migration**

First enable migrations by navigating the menu to Tools, NuGet Package Manager, Package Manager Console.

```
enable-migrations
```
```
add-migration <name>
add-migration <name> -force (to overwrite the last migration)
update-database
```
---

**Seeding the Database**

Create a new empty migration and use the SQL method:
```
Sql("INSERT INTO ...")
```
---

**Overriding Conventions**

```
[Required]
[StringLength(255)]
public string Name { get; set; }
```
---

**Querying Objects**

```c#
public class MoviesController
{
  private ApplicationDbContext _context;
  
  public MoviesController()
  {
    _context = new ApplicationDbContext();
  }
  
  protected override Dispose()
  {
    _context.Dispose();
  }
  
  public ActionResult Index()
  {
    var movies = _context.Movies.ToList();
    ...
  }
}
```
---

**LINQ Extension Methods**
```c#
_context.Movies.Where(m => m.GenreId == 1);
_context.Movies.Single(m => m.Id == 1);
_context.Movies.SingleOrDefault(m => m.Id == 1);
_context.Movies.ToList();
```
---

**Eager Loading**
```c#
_context.Movies.Include(m => m.Genre);
```
