using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExampleApp.Models
{
    public class ProductDbInitializer:DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext db)
        {
            //как сделать через инициализаторы?(из-за абстрактного класса непонятно)
            db.Products.Add(new Book { Name = "Спартак", Description = "Историческое повествование VII века", Price = 1300u });
            /*db.Products.Add(new Book(
                "Спартак", "Историческое повествование VII века", 1300, "Рафаэло Джованьоли", 542));
            db.Products.Add(new Book(
                "Почти как \"Бьюик\"", "История о загадочном автомобиле", 900, "Стивен Кинг", 448));
            db.Products.Add(new Book(
                "Игра Престолов", "Первая часть из саги \"Песнь льда и пламени\"", 1500, "Джордж Мартин", 766));*/

            base.Seed(db);
        }
    }
}