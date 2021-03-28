using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using COMP212_LAB4.Models;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace COMP212_LAB4.ViewModels
{
    class FoodViewModel 
    {
        private ObservableCollection<Food> AppetizerList;
        private ObservableCollection<Food> MainCourseList;
        private ObservableCollection<Food> BeverageList;
        private ObservableCollection<Food> DessertList;
        private ObservableCollection<Food> AllList = new ObservableCollection<Food>();
        public FoodViewModel() 
        {
            AppetizerList = new ObservableCollection<Food> {
                new Food{Item="Buffalo Wings",Price=5.95,Quantity=1},
                new Food{Item="Buffalo Fingers",Price=6.95,Quantity=1},
                new Food{Item="Potato Skins",Price=8.95,Quantity=1},
                new Food{Item="Nachos",Price=8.95,Quantity=1},
                new Food{Item="Mushroom Caps",Price=10.95,Quantity=1},
                new Food{Item="Shrimp Cocktail",Price=12.95,Quantity=1},
                new Food{Item="Chips and Salsa",Price=6.95,Quantity=1},
            };
            MainCourseList = new ObservableCollection<Food> {
                new Food{Item="Seafood Alfredo",Price=15.95,Quantity=1 },
                new Food{Item="Chicken Alfredo",Price=13.95,Quantity=1 },
                new Food{Item="Chicken Picatta",Price=13.95,Quantity=1 },
                new Food{Item="Turkey Club",Price=11.95,Quantity=1 },
                new Food{Item="Lobster Pie",Price=19.95,Quantity=1 },
                new Food{Item="Prime Rib",Price=20.95,Quantity=1 },
                new Food{Item="Shrimp Scampi",Price=18.95,Quantity=1 },
                new Food{Item="Turkey Dinner",Price=13.95,Quantity=1 },
                new Food{Item="Stuffed Chicken",Price=14.95,Quantity=1 }
            };
            BeverageList = new ObservableCollection<Food> {
                new Food{Item="Soda",Price=1.95,Quantity=1 },
                new Food{Item="Tea",Price=1.50,Quantity=1 },
                new Food{Item="Coffee",Price=1.25,Quantity=1 },
                new Food{Item="Mineral Water",Price=2.95,Quantity=1 },
                new Food{Item="Juice",Price=2.50,Quantity=1 },
                new Food{Item="Milk",Price=1.50,Quantity=1 }
            };
            DessertList = new ObservableCollection<Food> {
                new Food{Item="Apple Pie",Price=5.95,Quantity=1 },
                new Food{Item="Sundae",Price=3.95,Quantity=1 },
                new Food{Item="Carrot Cake",Price=5.95,Quantity=1 },
                new Food{Item="Mud Pie",Price=4.95,Quantity=1 },
                new Food{Item="Apple Crisp",Price=5.95,Quantity=1 }
            };
        }
        public ObservableCollection<Food> DataMenu
        {
            get { return AllList; }
            set { AllList = value;}
        }
        public ObservableCollection<Food> Appetizers
        {
            get { return AppetizerList; }
            set { AppetizerList = value; }
        }
        public ObservableCollection<Food> MainCourses 
        {
            get { return MainCourseList; }
            set { MainCourseList = value; }
        }
        public ObservableCollection<Food> Beverages
        {
            get { return BeverageList; }
            set { BeverageList = value; }
        }
        public ObservableCollection<Food> Desserts
        {
            get { return DessertList; }
            set { DessertList = value; }
        }

    }
}
