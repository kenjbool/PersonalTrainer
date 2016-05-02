using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonalTrainer.Models
{
    public class DbColumnAttribute : Attribute
    {
        string Name { get; set; }
        public DbColumnAttribute(string name)
        {
            this.Name = name;
        }
        
        static void WriteColumnMappings(Parq parq)
        {
            // Just grabbing this to get hold of the type name:
            var type = parq.GetType();

            // Get the PropertyInfo object:
            var properties = parq.GetType().GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(false);
                var columnMapping = attributes
                    .FirstOrDefault(a => a.GetType() == typeof(DbColumnAttribute));
                if (columnMapping != null)
                {
                    var mapsto = columnMapping as DbColumnAttribute;
                    Console.WriteLine(property.Name, mapsto.Name);
                }
            }
        }
    }

}