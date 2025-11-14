using BaiThucHanh1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BaiThucHanh1.Controllers
{
    [Route("Admin/Student")]
    public class StudentController : Controller
    {
        private List<Student> listStudents = new List<Student>();
        public StudentController() {
            //Tao danh sach sinh vien voi 4 du lieu mau 
            listStudents = new List<Student>()
            {
                new Student() {Id = 1, Name = "Thanh Hoang", Branch = Branch.IT,
                    Gender = Gender.Male, IsRegular = true,
                    Address = "Nam Dinh", Email = "hoang@g.com" },
                new Student() {Id = 2, Name = "Thanh Tra", Branch=Branch.BE,
                    Gender = Gender.Female, IsRegular=true,
                    Address = "Ha Noi", Email = "tra@g.com" },
                new Student() {Id = 3, Name = "Duc Anh", Branch=Branch.CE,
                    Gender = Gender.Male, IsRegular = false,
                    Address = "Hai Phong", Email = "ducanh@g.com" },
                new Student(){Id = 4,Name = "Ngoc Sang", Branch = Branch.EE,
                    Gender= Gender.Male, IsRegular=false,
                    Address = "Nam Dinh", Email = "sang@g.com" }
            };
        }
        [HttpGet("List")]
        public IActionResult Index()
        {
            return View(listStudents);
        }
        [HttpGet("Add")]
        public IActionResult Create() {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            {
                new SelectListItem{ Text = "IT", Value = "1"},
                new SelectListItem{Text = "BE", Value="2"},
                new SelectListItem{ Text = "CE", Value="3"},
                new SelectListItem{ Text = "EE", Value="4"}
            };

            return View();
        }
        [HttpPost("Add")]
        public IActionResult Create(Student s, IFormFile AvatarFile) {
            if (AvatarFile != null && AvatarFile.Length > 0)
            {
                var fileName = Path.GetFileName(AvatarFile.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    AvatarFile.CopyTo(stream);
                }
                s.Avatar = "/images/" + fileName;
            }
            s.Id = listStudents.Last<Student>().Id+1;
            listStudents.Add(s);
            return View("Index",listStudents);
        }

    }
}
