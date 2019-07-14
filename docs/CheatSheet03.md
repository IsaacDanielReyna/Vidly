### Building Forms

**View**
```razor
@using (Html.BeginForm("action", "controller"))
{
  <div class="form-group">
    @Html.LabelFor( m => m.Name )
    @Html.TextBoxFor( m => m.Name, new { @class = "form-control" } )
  </div>
  <button type="submit" class="btn btn-primary">Save</button>
}
```
---
**Markup for Checkbox Fields**
```razor
@Html.DropDownListFor( m => m.TypeId, new SelectList(Model.Types, "Id", "Name"), "", new { @class = "form-control })
```
---
**Drop-down Lists**
```razor
@Html.DropDownListFor( m => m.TypeId, new SelectList(Model.Types, "Id", "Name"), "", new { @class = "form-control" })
```
---
**Overriding Labels**
```c#
[Display(Name = "Date of Birth")]
public DateTime? Birthdate { get; set; }
```
---
**Saving Data**
```c#
[HttpPost]
public ActionResult Save(Customer customer)
{
  if (customer.Id == 0)
    _context.Customer.Add(customer);
  else
  {
    var customerInDb = _context.Customers.Single(c.Id == customer.Id);
    // update properties
  }
  
  _context.SaveChanges();
  
  return RedirectToAction("Index", "Customers"
}
```
---
**Hidden Fields**
```razor
@Html.HiddenFor( m => m.Customer.Id)
```
