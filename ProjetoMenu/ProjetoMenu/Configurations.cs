using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjetoMenu
{
    public class Configurations
    {
        private readonly string _path;

        public Configurations()
        {
            _path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            _path += @"\Projeto_Menu\";

            if (!Directory.Exists(_path))
            {
                Directory.CreateDirectory(_path);
            }
        }

        public void Add(Product product)
        {
            var id = 0;

            while (File.Exists(_path + id + ".txt")) id++;          

            if (File.Exists(_path + id + ".txt")) return;

            using (var file = new StreamWriter(_path + id + ".txt"))
            {
                file.WriteLine(product.Id = id);
                file.WriteLine(product.Code);
                file.WriteLine(product.Brand);
                file.WriteLine(product.Model);
                file.WriteLine(product.Description);
                file.WriteLine(product.Date);
                file.WriteLine(product.Amount);
                file.WriteLine(product.Price);
                file.WriteLine(product.Total);
            }
        }

        public List<string> Show(int count)
        {     
            return File.ReadAllLines(_path + count + ".txt").ToList();
        }
    }
}