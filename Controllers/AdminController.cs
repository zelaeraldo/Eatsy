using Eatsy1.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Authorize(Roles = "Admin")] // Siguro që vetëm adminët kanë qasje
public class AdminController : Controller
{
    private readonly ApplicationDbContext _context;

    public AdminController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Paneli kryesor i administratorit
    public IActionResult Dashboard()
    {
        // Opsionale: Merr statistika për faqen
        ViewBag.TotalUsers = _context.Users.Count();
        ViewBag.TotalOrders = _context.Order.Count();
        ViewBag.TotalRestaurants = _context.Restaurant.Count();

        return View();
    }

    // Menaxho përdoruesit
    public IActionResult ManageUsers()
    {
        var users = _context.Users.ToList();
        return View(users);
    }

    // Menaxho restorantet
    public IActionResult ManageRestaurants()
    {
        var restaurants = _context.Restaurant.ToList();
        return View(restaurants);
    }

    // Menaxho porositë
    public IActionResult ManageOrders()
    {
        var orders = _context.Order.Include(o => o.Id).Include(o => o.OrderDetails).ToList();
        return View(orders);
    }
}