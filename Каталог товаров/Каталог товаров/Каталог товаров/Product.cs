using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Каталог_товаров
{
    public class Product
    {
        public string Name { set; get; }
        public string Country_of_made { set; get; }
        public string Price { set; get; }

        public override string ToString()
        {
            return "Назва: " + Name + "\\  Країна виробника: " + Country_of_made + "\\   Ціна: " + Price;
        }

        public void XML(string str, string name_of_file = ".xml")
        {

            if (File.Exists(str + name_of_file))     //перевірка чи елемент файл існує 
            {
                XmlDocument doc = new XmlDocument();

                doc.Load(str + name_of_file);        //загружаємо все дерево
                XmlNode root = doc.DocumentElement;  //кореневий елемент

                XmlNode xProduct = doc.CreateElement(string.Empty, "Product", string.Empty);  //створення person
                root.AppendChild(xProduct);           

                XmlNode xName = doc.CreateElement(string.Empty, "Name", string.Empty);
                XmlNode x_t_Name = doc.CreateTextNode(this.Name);
                xName.AppendChild(x_t_Name);
                xProduct.AppendChild(xName);

                XmlNode xCountry = doc.CreateElement(string.Empty, "Country", string.Empty);
                XmlNode x_t_Country = doc.CreateTextNode(this.Country_of_made);
                xCountry.AppendChild(x_t_Country);
                xProduct.AppendChild(xCountry);            

                XmlNode xPrice = doc.CreateElement(string.Empty, "Price", string.Empty);
                XmlNode x_t_Product = doc.CreateTextNode(this.Price);
                xPrice.AppendChild(x_t_Product);
                xProduct.AppendChild(xPrice);

                doc.Save(str + name_of_file);
            }

            else
            {
                //(1) xml declaration
                XmlDocument doc = new XmlDocument();
                XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(xmlDeclaration, root);         //Метод Node.insertBefore() добавляет элемент в  список дочерних элементов родителя перед указанным элементом.

                //(2) string.Empty makes cleaner code
                XmlElement xProducts = doc.CreateElement(string.Empty, "Products", string.Empty);
                doc.AppendChild(xProducts);

                XmlElement xProduct = doc.CreateElement(string.Empty, "Product", string.Empty);
                xProducts.AppendChild(xProduct);

                XmlElement xName = doc.CreateElement(string.Empty, "Name", string.Empty);
                XmlText x_t_Name = doc.CreateTextNode(this.Name);
                xName.AppendChild(x_t_Name);  //текстовий ел. є доч. XmlElement
                xProduct.AppendChild(xName);        //XmlElement є доч. Persony

                XmlElement xCountry = doc.CreateElement(string.Empty, "Country", string.Empty);
                XmlText x_t_Country = doc.CreateTextNode(this.Country_of_made);
                xCountry.AppendChild(x_t_Country);
                xProduct.AppendChild(xCountry);

                XmlElement xPrice = doc.CreateElement(string.Empty, "Price", string.Empty);
                XmlText x_t_Price = doc.CreateTextNode(this.Price);
                xPrice.AppendChild(x_t_Price);
                xProduct.AppendChild(xPrice);

               
                doc.Save(str + name_of_file);
            }
        }

    }
}
