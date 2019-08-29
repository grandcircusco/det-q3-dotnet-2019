using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using MakingAPIsMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakingAPIsMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public async Task<IActionResult> GetEmployees()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44389");

            var response = await client.GetAsync("api/company");
            var result = await response.Content.ReadAsAsync<List<Employee>>();
            return View(result);
        }

        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44389");

            var response = await client.GetAsync($"api/company/{id}");
            var result = await response.Content.ReadAsAsync<Employee>();
            return View(result);
        }

        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddEmployee(Employee employee)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44389");
            //HTTP POST
            var postEmployee = await client.PostAsJsonAsync<Employee>("api/company", employee);

            if (postEmployee.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Server error. Did not add to Db.");
            return View(employee);
        }

        public async Task<IActionResult> EditEmployee(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44389");

            var response = await client.GetAsync($"api/company/{id}");
            var result = await response.Content.ReadAsAsync<Employee>();
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee updatedEmployee)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44389");

            var putTask = await client.PutAsJsonAsync<Employee>($"api/company/{updatedEmployee.employeeId}", updatedEmployee);
            if (putTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("EditEmployee", updatedEmployee.employeeId);
        }


        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44389");

            var deleteTask = await client.DeleteAsync($"api/company/{id}");

            return RedirectToAction("Index");
        }

    }

}