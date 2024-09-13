# BasicMVC

![image](https://github.com/user-attachments/assets/808ad8ec-0233-43c5-85aa-d0396f044da1)

## Task: Display Customer and Order Information
We are developing an application using ASP.NET MVC to display customer and order information by following the steps below.

### Step 1: Creating the Model

#### Customer Model:

##### Create a Customer class with the following properties:

- Id (Unique customer ID, type: int)
- FirstName (Customer's first name, type: string)
- LastName (Customer's last name, type: string)
- Email (Customer's email address, type: string)

#### Order Model:

##### Create an Order class with the following properties:

- Id (Unique order ID, type: int)
- ProductName (Name of the product, type: string)
- Price (Price of the product, type: decimal)
- Quantity (Quantity of the ordered product, type: int)

### Step 2: Creating the ViewModel

#### CustomerOrderViewModel Class:
- Create a CustomerOrderViewModel class.
- Customer (A Customer object)
- Orders (A list of Order objects)
- The ViewModel will hold the model data along with any additional information necessary for the view.

### Step 3: Creating the Controller

#### CustomerOrdersController:

- Create a CustomerOrdersController class.
- Inside this controller, create an action method named Index.

#### In the Index method:
- Create a sample Customer object and a few Order objects.
- Use these objects to create a CustomerOrderViewModel object.
- Pass the CustomerOrderViewModel object to the view.

### Step 4: Creating the View

#### Index View:
- Create a view named Index.cshtml inside the Views/CustomerOrders folder.
- This view will display customer information and orders using the CustomerOrderViewModel.

#### In the View:
- Display customer details (ID, first name, last name, email).
- Create a table to list the orders, showing the order ID, product name, price, and quantity.

 --- 

## Görev: Müşteri ve Sipariş Bilgilerini Görüntüleme
Aşağıdaki adımları izleyerek, ASP.NET MVC kullanarak bir müşteri ve sipariş bilgilerini görüntülemek için bir uygulama geliştiriyoruz.

### Aşama 1: Model Oluşturma

#### Customer Modeli:

##### Bir Customer sınıfı oluşturun.
- Id (Müşterinin benzersiz kimliği, int türünde)
- FirstName (Müşterinin adı, string türünde)
- LastName (Müşterinin soyadı, string türünde)
- Email (Müşterinin e-posta adresi, string türünde)

#### Order Modeli:

##### Bir Order sınıfı oluşturun.
- Id (Siparişin benzersiz kimliği, int türünde)
- ProductName (Ürünün adı, string türünde)
- Price (Ürünün fiyatı, decimal türünde)
- Quantity (Sipariş edilen ürün miktarı, int türünde)

### Aşama 2: ViewModel Oluşturma

#### CustomerOrderViewModel Sınıfı:

- Bir CustomerOrderViewModel sınıfı oluşturun.
- Customer (Bir Customer nesnesi)
- Orders (Bir Order nesneleri listesi)
- ViewModel, model verilerini ve view'da göstermek için gerekli ek bilgileri bir arada tutacaktır.

### Aşama 3: Controller Oluşturma

#### CustomerOrdersController:

- Bir CustomerOrdersController sınıfı oluşturun.
- Bu controller içinde, Index adında bir aksiyon metodu oluşturun.

#### Index metodunda:

- Örnek bir Customer nesnesi ve birkaç Order nesnesi oluşturun.
- Bu nesneleri kullanarak bir CustomerOrderViewModel nesnesi oluşturun.
- CustomerOrderViewModel nesnesini view'a iletin.

### Aşama 4: View Oluşturma

#### Index View:

- Views/CustomerOrders klasörü altında bir Index.cshtml adlı view oluşturun.
- Bu view, CustomerOrderViewModel kullanarak müşteri bilgilerini ve siparişleri gösterecek.

#### View’da:

- Müşteri bilgilerini (ID, adı, soyadı, e-posta) görüntüleyin.
- Siparişlerin bir tablosunu oluşturun ve sipariş ID'si, ürün adı, fiyat ve miktar bilgilerini listeleyin.
