

using Microsoft.AspNetCore.Mvc;
using BasicMVC.Models;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {

            var customerList = new List<Customer>()
            {
                new Customer(1,"Ali","Yılmaz","aliyilmaz@mail.com"),
                new Customer(2,"Mehmet","Çelik","mehmetcelik@mail.com"),
                new Customer( 3,"Yusuf","Kaya","yusufkaya@mail.com")
            };

            var ordersList = new List<List<Orders>>
            {
                new List<Orders>
                {
                    new Orders(101,"Laptop",7500,1),
                    new Orders(102,"Mouse", 150, 2),
                    new Orders(103,"Klavye",300, 1)
                },
                new List<Orders>
                {
                    new Orders (201,  "Telefon", 6500, 1 ),
                    new Orders ( 202, "Kulaklık",  250,  1 ),
                    new Orders (203, "Şarj Aleti",  100, 3 )
                },
                 new List<Orders>
            {
                new Orders (301, "Televizyon",  5500,  1 ),
                new Orders ( 302,  "HDMI Kablo",  75,  3 ),
                new Orders (303,  "Duvar Askısı",  200,  1 )
            }

            };

            var customerOrderViewModels = new List<CustomerOrderViewModel>();

            for (int i = 0; i < customerList.Count; i++)
            {
                var viewModel = new CustomerOrderViewModel
                {
                    Customer = customerList[i],
                    Order = ordersList[i]  
                };

                customerOrderViewModels.Add(viewModel);
            }

            return View(customerOrderViewModels);
        }
    }
}
