using RoadMapBasedProjects.Models;

namespace RoadMapBasedProjects.DataBase
{
  public class Producttbl
  {
    public List<ProductModel> Products = new()
      {
      new ProductModel
      {
          Id = 1,
          Name = "Apple",
          Price = 120.00m,
          Description = "Fresh red apples.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/1/15/Red_Apple.jpg"
      },

      new ProductModel
      {
          Id = 2,
          Name = "Banana",
          Price = 60.00m,
          Description = "Fresh ripe bananas.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/8/8a/Banana-Single.jpg"
      },

      new ProductModel
      {
          Id = 3,
          Name = "Orange",
          Price = 90.00m,
          Description = "Juicy fresh oranges.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/c/c4/Orange-Fruit-Pieces.jpg"
      },

      new ProductModel
      {
          Id = 4,
          Name = "Mango",
          Price = 150.00m,
          Description = "Sweet and juicy ripe mangoes.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/9/90/Hapus_Mango.jpg"
      },

      new ProductModel
      {
          Id = 5,
          Name = "Strawberry",
          Price = 180.00m,
          Description = "Fresh red strawberries.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/2/29/PerfectStrawberry.jpg"
      },

      new ProductModel
      {
          Id = 6,
          Name = "Pineapple",
          Price = 100.00m,
          Description = "Fresh tropical pineapple.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/c/cb/Pineapple_and_cross_section.jpg"
      },

      new ProductModel
      {
          Id = 7,
          Name = "Watermelon",
          Price = 80.00m,
          Description = "Sweet and refreshing watermelon.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/4/4c/Watermelon.jpg"
      },

      new ProductModel
      {
          Id = 8,
          Name = "Grapes",
          Price = 110.00m,
          Description = "Fresh green seedless grapes.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/b/bb/Table_grapes_on_white.jpg"
      },

      new ProductModel
      {
          Id = 9,
          Name = "Papaya",
          Price = 70.00m,
          Description = "Ripe and naturally sweet papaya.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/6/6b/Papaya_cross_section_BNC.jpg"
      },

      new ProductModel
      {
          Id = 10,
          Name = "Kiwi",
          Price = 200.00m,
          Description = "Fresh green kiwi fruit.",
          Type = "Fruit",
          selected = false,
          Link = "https://upload.wikimedia.org/wikipedia/commons/d/d3/Kiwi_aka.jpg"
      }
      };




    //public List<ProductModel> Products = new()
    //{
    //  new ProductModel { Id = 1, Name = "Wireless Mouse", Price = 799.00m, Description = "Ergonomic wireless mouse with adjustable DPI.", Type = "Electronics", selected = false, link = "" },
    //  new ProductModel { Id = 2, Name = "Mechanical Keyboard", Price = 2499.00m, Description = "RGB mechanical keyboard with blue switches.", Type = "Electronics", selected = false },
    //  new ProductModel { Id = 3, Name = "USB-C Hub", Price = 1299.00m, Description = "Multi-port USB-C hub with HDMI and USB 3.0.", Type = "Accessories", selected = false },
    //  new ProductModel { Id = 4, Name = "Laptop Stand", Price = 1499.00m, Description = "Adjustable aluminium laptop stand.", Type = "Accessories", selected = false },
    //  new ProductModel { Id = 5, Name = "Bluetooth Speaker", Price = 1999.00m, Description = "Portable Bluetooth speaker with stereo sound.", Type = "Audio", selected = false },
    //  new ProductModel { Id = 6, Name = "USB-C Earphones", Price = 999.00m, Description = "Wired USB-C earphones with in-line microphone.", Type = "Audio", selected = false },
    //  new ProductModel { Id = 7, Name = "Power Bank", Price = 1799.00m, Description = "10000mAh power bank with fast charging support.", Type = "Electronics", selected = false },
    //  new ProductModel { Id = 8, Name = "Webcam", Price = 2299.00m, Description = "1080p USB webcam with built-in microphone.", Type = "Electronics", selected = false },
    //  new ProductModel { Id = 9, Name = "Desk Lamp", Price = 899.00m, Description = "LED desk lamp with adjustable brightness.", Type = "Home", selected = false },
    //  new ProductModel { Id = 10, Name = "Notebook", Price = 299.00m, Description = "Hardcover ruled notebook with 200 pages.", Type = "Stationery", selected = false }

    //  //new ProductModel { Id = 11, Name = "Gaming Mouse", Price = 1599.00m, Description = "High precision gaming mouse with RGB lighting.", Type = "Gaming", selected = false },
    //  //new ProductModel { Id = 12, Name = "Gaming Keyboard", Price = 3299.00m, Description = "Mechanical gaming keyboard with RGB backlight.", Type = "Gaming", selected = false },
    //  //new ProductModel { Id = 13, Name = "Gaming Headset", Price = 2799.00m, Description = "Over-ear gaming headset with noise isolation.", Type = "Gaming", selected = false },
    //  //new ProductModel { Id = 14, Name = "Monitor Stand", Price = 1899.00m, Description = "Height-adjustable monitor stand for desks.", Type = "Accessories", selected = false },
    //  //new ProductModel { Id = 15, Name = "HDMI Cable", Price = 499.00m, Description = "High-speed HDMI cable supporting 4K video.", Type = "Accessories", selected = false },
    //  //new ProductModel { Id = 16, Name = "DisplayPort Cable", Price = 699.00m, Description = "DisplayPort cable for high-resolution monitors.", Type = "Accessories", selected = false },
    //  //new ProductModel { Id = 17, Name = "Wireless Charger", Price = 1199.00m, Description = "Fast wireless charging pad for compatible phones.", Type = "Electronics", selected = false },
    //  //new ProductModel { Id = 18, Name = "Smart LED Bulb", Price = 649.00m, Description = "Wi-Fi enabled smart LED bulb with adjustable brightness.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 19, Name = "Smart Plug", Price = 899.00m, Description = "Wi-Fi smart plug with mobile app control.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 20, Name = "Bluetooth Adapter", Price = 549.00m, Description = "Compact Bluetooth adapter for desktop computers.", Type = "Electronics", selected = false },

    //  //new ProductModel { Id = 21, Name = "Running Shoes", Price = 2499.00m, Description = "Lightweight running shoes with cushioned soles.", Type = "Footwear", selected = false },
    //  //new ProductModel { Id = 22, Name = "Casual Sneakers", Price = 1999.00m, Description = "Comfortable everyday sneakers for casual wear.", Type = "Footwear", selected = false },
    //  //new ProductModel { Id = 23, Name = "Formal Shoes", Price = 2999.00m, Description = "Classic formal shoes suitable for office wear.", Type = "Footwear", selected = false },
    //  //new ProductModel { Id = 24, Name = "Sports Sandals", Price = 1299.00m, Description = "Lightweight sandals designed for outdoor activities.", Type = "Footwear", selected = false },
    //  //new ProductModel { Id = 25, Name = "Cotton T-Shirt", Price = 599.00m, Description = "Soft cotton round-neck T-shirt.", Type = "Clothing", selected = false },
    //  //new ProductModel { Id = 26, Name = "Denim Jeans", Price = 1799.00m, Description = "Classic regular-fit denim jeans.", Type = "Clothing", selected = false },
    //  //new ProductModel { Id = 27, Name = "Hooded Sweatshirt", Price = 1499.00m, Description = "Warm cotton-blend hooded sweatshirt.", Type = "Clothing", selected = false },
    //  //new ProductModel { Id = 28, Name = "Formal Shirt", Price = 1199.00m, Description = "Slim-fit formal shirt for office wear.", Type = "Clothing", selected = false },
    //  //new ProductModel { Id = 29, Name = "Winter Jacket", Price = 3499.00m, Description = "Insulated winter jacket with multiple pockets.", Type = "Clothing", selected = false },
    //  //new ProductModel { Id = 30, Name = "Cotton Socks", Price = 299.00m, Description = "Pack of comfortable cotton ankle socks.", Type = "Clothing", selected = false },

    //  //new ProductModel { Id = 31, Name = "Travel Backpack", Price = 1899.00m, Description = "Water-resistant backpack with laptop compartment.", Type = "Bags", selected = false },
    //  //new ProductModel { Id = 32, Name = "Laptop Backpack", Price = 2299.00m, Description = "Padded laptop backpack with multiple compartments.", Type = "Bags", selected = false },
    //  //new ProductModel { Id = 33, Name = "Sling Bag", Price = 899.00m, Description = "Compact sling bag for daily essentials.", Type = "Bags", selected = false },
    //  //new ProductModel { Id = 34, Name = "Duffel Bag", Price = 1599.00m, Description = "Spacious duffel bag suitable for travel and gym use.", Type = "Bags", selected = false },
    //  //new ProductModel { Id = 35, Name = "Wallet", Price = 699.00m, Description = "Compact wallet with multiple card slots.", Type = "Accessories", selected = false },
    //  //new ProductModel { Id = 36, Name = "Leather Belt", Price = 899.00m, Description = "Classic belt made from durable leather.", Type = "Accessories", selected = false },
    //  //new ProductModel { Id = 37, Name = "Analog Watch", Price = 2499.00m, Description = "Classic analog watch with stainless steel case.", Type = "Accessories", selected = false },
    //  //new ProductModel { Id = 38, Name = "Digital Watch", Price = 1599.00m, Description = "Digital watch with alarm and stopwatch functions.", Type = "Accessories", selected = false },
    //  //new ProductModel { Id = 39, Name = "Sunglasses", Price = 999.00m, Description = "UV-protected sunglasses with lightweight frame.", Type = "Accessories", selected = false },
    //  //new ProductModel { Id = 40, Name = "Cap", Price = 499.00m, Description = "Adjustable cotton baseball cap.", Type = "Clothing", selected = false },

    //  //new ProductModel { Id = 41, Name = "Coffee Mug", Price = 399.00m, Description = "Ceramic coffee mug with 350ml capacity.", Type = "Kitchen", selected = false },
    //  //new ProductModel { Id = 42, Name = "Water Bottle", Price = 699.00m, Description = "Stainless steel insulated water bottle.", Type = "Kitchen", selected = false },
    //  //new ProductModel { Id = 43, Name = "Lunch Box", Price = 799.00m, Description = "Leak-resistant lunch box with multiple compartments.", Type = "Kitchen", selected = false },
    //  //new ProductModel { Id = 44, Name = "Electric Kettle", Price = 1499.00m, Description = "Fast-boiling electric kettle with auto shut-off.", Type = "Kitchen", selected = false },
    //  //new ProductModel { Id = 45, Name = "Toaster", Price = 1799.00m, Description = "Two-slice toaster with adjustable browning levels.", Type = "Kitchen", selected = false },
    //  //new ProductModel { Id = 46, Name = "Hand Blender", Price = 1299.00m, Description = "Compact hand blender for everyday cooking.", Type = "Kitchen", selected = false },
    //  //new ProductModel { Id = 47, Name = "Non-Stick Pan", Price = 999.00m, Description = "Non-stick frying pan with heat-resistant handle.", Type = "Kitchen", selected = false },
    //  //new ProductModel { Id = 48, Name = "Knife Set", Price = 1199.00m, Description = "Stainless steel kitchen knife set.", Type = "Kitchen", selected = false },
    //  //new ProductModel { Id = 49, Name = "Cutting Board", Price = 499.00m, Description = "Durable chopping board for kitchen use.", Type = "Kitchen", selected = false },
    //  //new ProductModel { Id = 50, Name = "Storage Containers", Price = 899.00m, Description = "Set of airtight food storage containers.", Type = "Kitchen", selected = false },

    //  //new ProductModel { Id = 51, Name = "Ballpoint Pen Set", Price = 199.00m, Description = "Set of smooth-writing blue ballpoint pens.", Type = "Stationery", selected = false },
    //  //new ProductModel { Id = 52, Name = "Gel Pen Set", Price = 249.00m, Description = "Set of colorful gel pens for writing and drawing.", Type = "Stationery", selected = false },
    //  //new ProductModel { Id = 53, Name = "Pencil Set", Price = 149.00m, Description = "Set of graphite pencils with different hardness levels.", Type = "Stationery", selected = false },
    //  //new ProductModel { Id = 54, Name = "Highlighter Set", Price = 299.00m, Description = "Set of fluorescent highlighters.", Type = "Stationery", selected = false },
    //  //new ProductModel { Id = 55, Name = "A4 Notebook", Price = 349.00m, Description = "A4 ruled notebook with durable binding.", Type = "Stationery", selected = false },
    //  //new ProductModel { Id = 56, Name = "Spiral Notebook", Price = 249.00m, Description = "Spiral-bound notebook with 160 ruled pages.", Type = "Stationery", selected = false },
    //  //new ProductModel { Id = 57, Name = "Desk Organizer", Price = 399.00m, Description = "Multi-compartment organizer for office supplies.", Type = "Stationery", selected = false },
    //  //new ProductModel { Id = 58, Name = "Sticky Notes", Price = 149.00m, Description = "Colorful sticky notes for reminders and planning.", Type = "Stationery", selected = false },
    //  //new ProductModel { Id = 59, Name = "File Folder", Price = 99.00m, Description = "Durable plastic folder for document storage.", Type = "Stationery", selected = false },
    //  //new ProductModel { Id = 60, Name = "Calculator", Price = 499.00m, Description = "Basic calculator with large display.", Type = "Stationery", selected = false },

    //  //new ProductModel { Id = 61, Name = "Table Clock", Price = 599.00m, Description = "Digital table clock with alarm function.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 62, Name = "Wall Clock", Price = 899.00m, Description = "Modern wall clock with silent movement.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 63, Name = "Cushion", Price = 499.00m, Description = "Soft decorative cushion for home interiors.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 64, Name = "Bedsheet", Price = 1299.00m, Description = "Soft cotton bedsheet with printed design.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 65, Name = "Pillow", Price = 699.00m, Description = "Comfortable microfiber-filled pillow.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 66, Name = "Curtains", Price = 1499.00m, Description = "Light-blocking curtains for bedrooms and living rooms.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 67, Name = "Floor Mat", Price = 599.00m, Description = "Anti-slip floor mat for indoor use.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 68, Name = "Table Fan", Price = 1899.00m, Description = "Compact table fan with three speed settings.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 69, Name = "Air Purifier", Price = 6999.00m, Description = "Compact air purifier with multi-stage filtration.", Type = "Home", selected = false },
    //  //new ProductModel { Id = 70, Name = "Humidifier", Price = 1999.00m, Description = "Compact humidifier for maintaining indoor humidity.", Type = "Home", selected = false },

    //  //new ProductModel { Id = 71, Name = "Football", Price = 899.00m, Description = "Durable training football for outdoor games.", Type = "Sports", selected = false },
    //  //new ProductModel { Id = 72, Name = "Cricket Bat", Price = 2499.00m, Description = "English willow cricket bat for training.", Type = "Sports", selected = false },
    //  //new ProductModel { Id = 73, Name = "Cricket Ball", Price = 399.00m, Description = "Durable leather cricket ball.", Type = "Sports", selected = false },
    //  //new ProductModel { Id = 74, Name = "Badminton Racket", Price = 1299.00m, Description = "Lightweight badminton racket with strong frame.", Type = "Sports", selected = false },
    //  //new ProductModel { Id = 75, Name = "Tennis Racket", Price = 1999.00m, Description = "Lightweight tennis racket for recreational play.", Type = "Sports", selected = false },
    //  //new ProductModel { Id = 76, Name = "Yoga Mat", Price = 799.00m, Description = "Non-slip yoga mat with cushioned surface.", Type = "Sports", selected = false },
    //  //new ProductModel { Id = 77, Name = "Skipping Rope", Price = 299.00m, Description = "Adjustable skipping rope for cardio workouts.", Type = "Sports", selected = false },
    //  //new ProductModel { Id = 78, Name = "Dumbbell Set", Price = 2499.00m, Description = "Adjustable dumbbell set for home workouts.", Type = "Sports", selected = false },
    //  //new ProductModel { Id = 79, Name = "Resistance Bands", Price = 699.00m, Description = "Set of resistance bands for strength training.", Type = "Sports", selected = false },
    //  //new ProductModel { Id = 80, Name = "Gym Gloves", Price = 599.00m, Description = "Breathable workout gloves with padded palms.", Type = "Sports", selected = false },

    //  //new ProductModel { Id = 81, Name = "Face Wash", Price = 399.00m, Description = "Gentle face wash suitable for daily cleansing.", Type = "Personal Care", selected = false },
    //  //new ProductModel { Id = 82, Name = "Shampoo", Price = 499.00m, Description = "Daily-use shampoo for clean and healthy hair.", Type = "Personal Care", selected = false },
    //  //new ProductModel { Id = 83, Name = "Body Lotion", Price = 349.00m, Description = "Moisturizing body lotion for everyday use.", Type = "Personal Care", selected = false },
    //  //new ProductModel { Id = 84, Name = "Hand Wash", Price = 199.00m, Description = "Liquid hand wash with refreshing fragrance.", Type = "Personal Care", selected = false },
    //  //new ProductModel { Id = 85, Name = "Toothbrush", Price = 149.00m, Description = "Soft-bristle toothbrush for everyday dental care.", Type = "Personal Care", selected = false },
    //  //new ProductModel { Id = 86, Name = "Bath Towel", Price = 699.00m, Description = "Absorbent cotton bath towel.", Type = "Personal Care", selected = false },
    //  //new ProductModel { Id = 87, Name = "Hair Dryer", Price = 1299.00m, Description = "Compact hair dryer with multiple heat settings.", Type = "Personal Care", selected = false },
    //  //new ProductModel { Id = 88, Name = "Electric Trimmer", Price = 1799.00m, Description = "Rechargeable trimmer with adjustable length settings.", Type = "Personal Care", selected = false },
    //  //new ProductModel { Id = 89, Name = "Comb Set", Price = 199.00m, Description = "Set of durable combs for everyday grooming.", Type = "Personal Care", selected = false },
    //  //new ProductModel { Id = 90, Name = "Travel Toiletry Kit", Price = 599.00m, Description = "Compact toiletry kit with multiple storage compartments.", Type = "Personal Care", selected = false },

    //  //new ProductModel { Id = 91, Name = "Portable SSD", Price = 4999.00m, Description = "Fast portable SSD with USB-C connectivity.", Type = "Storage", selected = false },
    //  //new ProductModel { Id = 92, Name = "USB Flash Drive", Price = 699.00m, Description = "Compact 64GB USB flash drive.", Type = "Storage", selected = false },
    //  //new ProductModel { Id = 93, Name = "External Hard Drive", Price = 5499.00m, Description = "1TB external hard drive for backup and storage.", Type = "Storage", selected = false },
    //  //new ProductModel { Id = 94, Name = "MicroSD Card", Price = 799.00m, Description = "128GB microSD card for compatible devices.", Type = "Storage", selected = false },
    //  //new ProductModel { Id = 95, Name = "Memory Card Reader", Price = 399.00m, Description = "USB card reader supporting multiple memory card formats.", Type = "Storage", selected = false },
    //  //new ProductModel { Id = 96, Name = "Smartphone Tripod", Price = 899.00m, Description = "Adjustable tripod for smartphones and small cameras.", Type = "Photography", selected = false },
    //  //new ProductModel { Id = 97, Name = "Ring Light", Price = 1499.00m, Description = "LED ring light with adjustable brightness levels.", Type = "Photography", selected = false },
    //  //new ProductModel { Id = 98, Name = "Camera Bag", Price = 1999.00m, Description = "Padded camera bag with adjustable compartments.", Type = "Photography", selected = false },
    //  //new ProductModel { Id = 99, Name = "Phone Lens Kit", Price = 799.00m, Description = "Clip-on lens kit for smartphone photography.", Type = "Photography", selected = false },
    //  //new ProductModel { Id = 100, Name = "Mini Photo Printer", Price = 5999.00m, Description = "Compact wireless printer for instant photo printing.", Type = "Photography", selected = false }
    //};
  }
}
