using Microsoft.EntityFrameworkCore;
using ProjeYonetim.Entities;
using ProjeYonetim.Entities.Constant;
using System;
using System.Linq;

namespace ProjeYonetim.Data.Concrete.EFCore
{
    public static class SeedDatabase
    {


        private static readonly Employee[] Employees =
        {
            new Employee() {IsActive=true, FullName = "Mücahit Kızılarslan", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 1, 1), Department = Department.Yönetim, Salary = 12000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Eyüp Orhun Fındık", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 2, 2), Department = Department.Yönetim, Salary = 10000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Nergiz Gilim", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 3, 3), Department = Department.Muhasebe, Salary = 3000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Kubra Göçmen", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 4, 4), Department = Department.Muhasebe, Salary = 4000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Berhudan Garip", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 5, 5), Department = Department.Muhasebe, Salary = 2000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Nihan Gazitepe", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 6, 6), Department = Department.Satış, Salary = 7000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Menekşe Geben", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 7, 7), Department = Department.Satış, Salary = 3000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Şeniz Geboloğlu", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 8, 8), Department = Department.Satış, Salary = 3000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Zeynep Senahan Geçioğlu", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 9, 9), Department = Department.Satış, Salary = 6000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Hayri Anıl Geçkin", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 1, 10), Department = Department.Satış, Salary = 5000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Muazzez Ece Gemalmaz", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 2, 11), Department = Department.Satış, Salary = 4000, LastUpdateDate = DateTime.Now.Date},
            new Employee() {IsActive=true, FullName = "Kerem Cahit Gençoğlu", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 3, 12), Department = Department.Yazılım, Salary = 3000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Sadık Can Gezmiş", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 4, 13), Department = Department.Yazılım, Salary = 6000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Resmiye Elif Gırgın", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 5, 14), Department = Department.Yazılım, Salary = 5000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "İrfan Anıl Fındıkçı", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 6, 15), Department = Department.Yazılım, Salary = 4000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Mehmet Gökalp Ginoviç", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 7, 16), Department = Department.Yazılım, Salary = 5000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Mehmetali Girgin", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 8, 17), Department = Department.Yazılım, Salary = 5000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Abdullah Halit Golba", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 9, 18), Department = Department.Yazılım, Salary = 6000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Tilbe Göç", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 1, 19), Department = Department.Yazılım, Salary = 4000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Ertuğ Furuncuoğlu", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 2, 21), Department = Department.Yazılım, Salary = 5000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Kubilay Gödek", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 3, 22), Department = Department.Yazılım, Salary = 4000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Busem Gökçeaslan", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 4, 23), Department = Department.Yazılım, Salary = 4000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Banuhan Gökçek", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 5, 24), Department = Department.Yazılım, Salary = 6000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Örgün Gökhan", Gender = Gender.Erkek, DateOfBirth = new DateTime(2020, 6, 25), Department = Department.Yazılım, Salary = 5000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Melike Göksoy", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 7, 26), Department = Department.Satış, Salary = 3000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Yeşim Gölmes", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 8, 27), Department = Department.Satış, Salary = 7000, LastUpdateDate = DateTime.Now.Date },
            new Employee() {IsActive=true, FullName = "Nilüfer Gönay", Gender = Gender.Kadın, DateOfBirth = new DateTime(2020, 9, 28), Department = Department.Satış, Salary = 7000, LastUpdateDate = DateTime.Now.Date }
        };

        private static readonly Sales[] Sales =
        {
            new Sales() { CustomerName = "A Firması",SalesName = "Satış A",EmployeeId = 1,SalesDate = new DateTime(2020, 7, 7),Price = 21000},
            new Sales() { CustomerName = "B Firması",SalesName = "Satış B",EmployeeId = 2,SalesDate = new DateTime(2020, 7, 7),Price = 32000},
            new Sales() { CustomerName = "C Firması",SalesName = "Satış C",EmployeeId = 3,SalesDate = new DateTime(2020, 7, 7),Price = 63000},
            new Sales() { CustomerName = "D Firması",SalesName = "Satış D",EmployeeId = 4,SalesDate = new DateTime(2020, 7, 7),Price = 44000},
            new Sales() { CustomerName = "E Firması",SalesName = "Satış E",EmployeeId = 5,SalesDate = new DateTime(2020, 7, 7),Price = 25000},
            new Sales() { CustomerName = "F Firması",SalesName = "Satış F",EmployeeId = 6,SalesDate = new DateTime(2020, 7, 7),Price = 56000},
            new Sales() { CustomerName = "G Firması",SalesName = "Satış G",EmployeeId = 7,SalesDate = new DateTime(2020, 7, 7),Price = 87000},
            new Sales() { CustomerName = "H Firması",SalesName = "Satış H",EmployeeId = 8,SalesDate = new DateTime(2020, 7, 7),Price = 18000},
            new Sales() { CustomerName = "I Firması",SalesName = "Satış I",EmployeeId = 9,SalesDate = new DateTime(2020, 7, 7),Price = 62000},
            new Sales() { CustomerName = "J Firması",SalesName = "Satış J",EmployeeId = 10,SalesDate = new DateTime(2020, 7, 7),Price = 42000},
            new Sales() { CustomerName = "K Firması",SalesName = "Satış K",EmployeeId = 11,SalesDate = new DateTime(2020, 7, 7),Price = 63000},
            new Sales() { CustomerName = "L Firması",SalesName = "Satış L",EmployeeId = 12,SalesDate = new DateTime(2020, 7, 7),Price = 24000},
            new Sales() { CustomerName = "M Firması",SalesName = "Satış M",EmployeeId = 13,SalesDate = new DateTime(2020, 7, 7),Price = 15000},
            new Sales() { CustomerName = "N Firması",SalesName = "Satış N",EmployeeId = 14,SalesDate = new DateTime(2020, 7, 7),Price = 56000},
            new Sales() { CustomerName = "O Firması",SalesName = "Satış O",EmployeeId = 15,SalesDate = new DateTime(2020, 7, 7),Price = 32000},
            new Sales() { CustomerName = "P Firması",SalesName = "Satış P",EmployeeId = 16,SalesDate = new DateTime(2020, 7, 7),Price = 31000},
            new Sales() { CustomerName = "R Firması",SalesName = "Satış R",EmployeeId = 17,SalesDate = new DateTime(2020, 7, 7),Price = 45000},
            new Sales() { CustomerName = "S Firması",SalesName = "Satış S",EmployeeId = 18,SalesDate = new DateTime(2020, 7, 7),Price = 26000},
            new Sales() { CustomerName = "T Firması",SalesName = "Satış T",EmployeeId = 19,SalesDate = new DateTime(2020, 7, 7),Price = 22000},
            new Sales() { CustomerName = "U Firması",SalesName = "Satış U",EmployeeId = 20,SalesDate = new DateTime(2020, 7, 7),Price = 32000},
        };

        private static readonly Project[] Projects =
        {
            new Project() { SalesId = 1,ProjectName = "Proje A",ProjectDetail = "Detaylar 1",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 2, 4)},
            new Project() { SalesId = 2,ProjectName = "Proje B",ProjectDetail = "Detaylar 2",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 2, 5)},
            new Project() { SalesId = 3,ProjectName = "Proje C",ProjectDetail = "Detaylar 3",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 2, 6)},
            new Project() { SalesId = 4,ProjectName = "Proje D",ProjectDetail = "Detaylar 4",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 3, 7)},
            new Project() { SalesId = 5,ProjectName = "Proje E",ProjectDetail = "Detaylar 5",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 2, 8)},
            new Project() { SalesId = 6,ProjectName = "Proje F",ProjectDetail = "Detaylar 6",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 2, 9)},
            new Project() { SalesId = 7,ProjectName = "Proje G",ProjectDetail = "Detaylar 7",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 3, 10)},
            new Project() { SalesId = 8,ProjectName = "Proje H",ProjectDetail = "Detaylar 8",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 2, 11)},
            new Project() { SalesId = 9,ProjectName = "Proje I",ProjectDetail = "Detaylar 9",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 3, 12)},
            new Project() { SalesId = 10,ProjectName = "Proje J",ProjectDetail = "Detaylar 10",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 2, 13)},
            new Project() { SalesId = 11,ProjectName = "Proje K",ProjectDetail = "Detaylar 11",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 1, 14)},
            new Project() { SalesId = 12,ProjectName = "Proje L",ProjectDetail = "Detaylar 12",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 3, 15)},
            new Project() { SalesId = 13,ProjectName = "Proje M",ProjectDetail = "Detaylar 13",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 4, 16)},
            new Project() { SalesId = 14,ProjectName = "Proje N",ProjectDetail = "Detaylar 14",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 1, 17)},
            new Project() { SalesId = 15,ProjectName = "Proje O",ProjectDetail = "Detaylar 15",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 5, 18)},
            new Project() { SalesId = 16,ProjectName = "Proje P",ProjectDetail = "Detaylar 16",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 4, 19)},
            new Project() { SalesId = 17,ProjectName = "Proje R",ProjectDetail = "Detaylar 17",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 2, 20)},
            new Project() { SalesId = 18,ProjectName = "Proje S",ProjectDetail = "Detaylar 18",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 3, 21)},
            new Project() { SalesId = 19,ProjectName = "Proje T",ProjectDetail = "Detaylar 19",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 1, 22)},
            new Project() { SalesId = 20,ProjectName = "Proje U",ProjectDetail = "Detaylar 10",StartDate = new DateTime(2020, 1, 1), EndDate = new DateTime(2020, 3, 23)},
        };

        private static readonly ToDoList[] ToDoLists =
        {
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Düşük,EmployeeId = 12,ProjectId = 1},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Orta,EmployeeId = 13,ProjectId = 2},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Yüksek,EmployeeId = 14,ProjectId = 3},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Düşük,EmployeeId = 15,ProjectId = 4},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Orta,EmployeeId = 16,ProjectId = 5},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Düşük,EmployeeId = 17,ProjectId = 6},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Orta,EmployeeId = 18,ProjectId = 7},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Yüksek,EmployeeId = 19,ProjectId = 8},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Orta,EmployeeId = 20,ProjectId = 9},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Yüksek,EmployeeId = 21,ProjectId = 10},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Düşük,EmployeeId = 22,ProjectId = 11},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Orta,EmployeeId = 23,ProjectId = 12},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Yüksek,EmployeeId = 24,ProjectId = 13},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Düşük,EmployeeId = 15,ProjectId = 14},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Düşük,EmployeeId = 16,ProjectId = 15},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Orta,EmployeeId = 17,ProjectId = 16},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Yüksek,EmployeeId = 18,ProjectId = 17},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Düşük,EmployeeId = 19,ProjectId = 18},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Yüksek,EmployeeId = 20,ProjectId = 19},
            new ToDoList() { ToDoName = "Yapılacak 1",ToDoContent = "Yapılacak İçerik 1",Priority = Priority.Orta,EmployeeId = 21,ProjectId = 20},

            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Düşük,EmployeeId = 22,ProjectId = 1},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Yüksek,EmployeeId = 23,ProjectId = 2},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Orta,EmployeeId = 24,ProjectId = 3},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Düşük,EmployeeId = 12,ProjectId = 4},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Orta,EmployeeId = 13,ProjectId = 5},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Yüksek,EmployeeId = 14,ProjectId = 6},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Düşük,EmployeeId = 15,ProjectId = 7},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Düşük,EmployeeId = 16,ProjectId = 8},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Orta,EmployeeId = 17,ProjectId = 9},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Düşük,EmployeeId = 18,ProjectId = 10},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Orta,EmployeeId = 19,ProjectId = 11},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Yüksek,EmployeeId = 12,ProjectId = 12},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Düşük,EmployeeId = 13,ProjectId = 13},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Düşük,EmployeeId = 14,ProjectId = 14},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Orta,EmployeeId = 15,ProjectId = 15},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Yüksek,EmployeeId = 16,ProjectId = 16},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Düşük,EmployeeId = 17,ProjectId = 17},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Yüksek,EmployeeId = 18,ProjectId = 18},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Orta,EmployeeId = 19,ProjectId = 19},
            new ToDoList() { ToDoName = "Yapılacak 2",ToDoContent = "Yapılacak İçerik 2",Priority = Priority.Düşük,EmployeeId = 20,ProjectId = 20},

            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Yüksek,EmployeeId = 21,ProjectId = 1},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Düşük,EmployeeId = 22,ProjectId = 2},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Orta,EmployeeId = 23,ProjectId = 3},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Yüksek,EmployeeId = 24,ProjectId = 4},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Düşük,EmployeeId = 15,ProjectId = 5},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Düşük,EmployeeId = 16,ProjectId = 6},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Orta,EmployeeId = 17,ProjectId = 7},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Yüksek,EmployeeId = 18,ProjectId = 8},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Düşük,EmployeeId = 19,ProjectId = 9},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Düşük,EmployeeId = 20,ProjectId = 10},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Orta,EmployeeId = 21,ProjectId = 11},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Yüksek,EmployeeId = 22,ProjectId = 12},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Orta,EmployeeId = 23,ProjectId = 13},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Düşük,EmployeeId = 24,ProjectId = 14},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Orta,EmployeeId = 12,ProjectId = 15},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Düşük,EmployeeId = 13,ProjectId = 16},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Yüksek,EmployeeId = 14,ProjectId = 17},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Düşük,EmployeeId = 15,ProjectId = 18},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Orta,EmployeeId = 16,ProjectId = 19},
            new ToDoList() { ToDoName = "Yapılacak 3",ToDoContent = "Yapılacak İçerik 3",Priority = Priority.Yüksek,EmployeeId = 17,ProjectId = 20},
        };

        private static readonly Expense[] Expenses =
        {
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 1000,ProjectId = 1},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 2000,ProjectId = 2},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 1000,ProjectId = 3},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 2000,ProjectId = 4},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 1000,ProjectId = 5},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 2000,ProjectId = 6},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 3000,ProjectId = 7},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 2000,ProjectId = 8},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 1000,ProjectId = 9},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 500,ProjectId = 10},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 600,ProjectId = 11},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 800,ProjectId = 12},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 200,ProjectId = 13},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 600,ProjectId = 14},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 1000,ProjectId = 15},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 1000,ProjectId = 16},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 1500,ProjectId = 17},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 2000,ProjectId = 18},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 1500,ProjectId = 19},
            new Expense() { ExpenseName = "Gider A",ExpenseAmount = 2500,ProjectId = 20},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 2000,ProjectId = 1},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 1000,ProjectId = 2},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 1000,ProjectId = 3},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 1050,ProjectId = 4},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 1000,ProjectId = 5},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 1500,ProjectId = 6},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 1000,ProjectId = 7},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 1000,ProjectId = 8},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 1050,ProjectId = 9},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 200,ProjectId = 10},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 2000,ProjectId = 11},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 2000,ProjectId = 12},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 1050,ProjectId = 13},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 2000,ProjectId = 14},
            new Expense() { ExpenseName = "Gider B",ExpenseAmount = 3000,ProjectId = 15},
        };

        private static readonly EmployeeProject[] EmployeeProjects =
        {
            new EmployeeProject() { EmployeeId = 12,ProjectId = 1},
            new EmployeeProject() { EmployeeId = 13,ProjectId = 2},
            new EmployeeProject() { EmployeeId = 14,ProjectId = 3},
            new EmployeeProject() { EmployeeId = 15,ProjectId = 4},
            new EmployeeProject() { EmployeeId = 16,ProjectId = 5},
            new EmployeeProject() { EmployeeId = 17,ProjectId = 6},
            new EmployeeProject() { EmployeeId = 18,ProjectId = 7},
            new EmployeeProject() { EmployeeId = 19,ProjectId = 8},
            new EmployeeProject() { EmployeeId = 20,ProjectId = 9},
            new EmployeeProject() { EmployeeId = 21,ProjectId = 10},
            new EmployeeProject() { EmployeeId = 22,ProjectId = 11},
            new EmployeeProject() { EmployeeId = 23,ProjectId = 12},
            new EmployeeProject() { EmployeeId = 24,ProjectId = 13},
            new EmployeeProject() { EmployeeId = 15,ProjectId = 14},
            new EmployeeProject() { EmployeeId = 16,ProjectId = 15},
            new EmployeeProject() { EmployeeId = 17,ProjectId = 16},
            new EmployeeProject() { EmployeeId = 18,ProjectId = 17},
            new EmployeeProject() { EmployeeId = 19,ProjectId = 18},
            new EmployeeProject() { EmployeeId = 20,ProjectId = 19},
            new EmployeeProject() { EmployeeId = 21,ProjectId = 20},

            new EmployeeProject() { EmployeeId = 22,ProjectId = 1},
            new EmployeeProject() { EmployeeId = 23,ProjectId = 2},
            new EmployeeProject() { EmployeeId = 24,ProjectId = 3},
            new EmployeeProject() { EmployeeId = 12,ProjectId = 4},
            new EmployeeProject() { EmployeeId = 13,ProjectId = 5},
            new EmployeeProject() { EmployeeId = 14,ProjectId = 6},
            new EmployeeProject() { EmployeeId = 15,ProjectId = 7},
            new EmployeeProject() { EmployeeId = 16,ProjectId = 8},
            new EmployeeProject() { EmployeeId = 17,ProjectId = 9},
            new EmployeeProject() { EmployeeId = 18,ProjectId = 10},
            new EmployeeProject() { EmployeeId = 19,ProjectId = 11},
            new EmployeeProject() { EmployeeId = 12,ProjectId = 12},
            new EmployeeProject() { EmployeeId = 13,ProjectId = 13},
            new EmployeeProject() { EmployeeId = 14,ProjectId = 14},
            new EmployeeProject() { EmployeeId = 15,ProjectId = 15},
            new EmployeeProject() { EmployeeId = 16,ProjectId = 16},
            new EmployeeProject() { EmployeeId = 17,ProjectId = 17},
            new EmployeeProject() { EmployeeId = 18,ProjectId = 18},
            new EmployeeProject() { EmployeeId = 19,ProjectId = 19},
            new EmployeeProject() { EmployeeId = 20,ProjectId = 20},

            new EmployeeProject() { EmployeeId = 21,ProjectId = 1},
            new EmployeeProject() { EmployeeId = 22,ProjectId = 2},
            new EmployeeProject() { EmployeeId = 23,ProjectId = 3},
            new EmployeeProject() { EmployeeId = 24,ProjectId = 4},
            new EmployeeProject() { EmployeeId = 15,ProjectId = 5},
            new EmployeeProject() { EmployeeId = 16,ProjectId = 6},
            new EmployeeProject() { EmployeeId = 17,ProjectId = 7},
            new EmployeeProject() { EmployeeId = 18,ProjectId = 8},
            new EmployeeProject() { EmployeeId = 19,ProjectId = 9},
            new EmployeeProject() { EmployeeId = 20,ProjectId = 10},
            new EmployeeProject() { EmployeeId = 21,ProjectId = 11},
            new EmployeeProject() { EmployeeId = 22,ProjectId = 12},
            new EmployeeProject() { EmployeeId = 23,ProjectId = 13},
            new EmployeeProject() { EmployeeId = 24,ProjectId = 14},
            new EmployeeProject() { EmployeeId = 12,ProjectId = 15},
            new EmployeeProject() { EmployeeId = 13,ProjectId = 16},
            new EmployeeProject() { EmployeeId = 14,ProjectId = 17},
            new EmployeeProject() { EmployeeId = 15,ProjectId = 18},
            new EmployeeProject() { EmployeeId = 16,ProjectId = 19},
            new EmployeeProject() { EmployeeId = 17,ProjectId = 20}
        };

        public static void Seed()
        {
            var context = new ProjeYonetimDbContext();

            if (!context.Database.EnsureCreated())
            {
                if (!context.Employees.Any() && !context.Sales.Any() && !context.Projects.Any() && !context.ToDoLists.Any() && !context.Expenses.Any() && !context.EmployeeProjects.Any())
                {
                    context.Employees.AddRange(Employees);
                    context.SaveChanges();
                    context.Sales.AddRange(Sales);
                    context.SaveChanges();
                    context.Projects.AddRange(Projects);
                    context.SaveChanges();
                    context.EmployeeProjects.AddRange(EmployeeProjects);
                    context.SaveChanges();
                    context.ToDoLists.AddRange(ToDoLists);
                    context.SaveChanges();
                    context.Expenses.AddRangeAsync(Expenses);
                    context.SaveChanges();
                }
            }
        }
    }
}