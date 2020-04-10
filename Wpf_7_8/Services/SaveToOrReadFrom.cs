using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_7_8.Models;

namespace Wpf_7_8.Services
{
    class SaveToOrReadFrom
    {
        private readonly string Path;
        public SaveToOrReadFrom( string path)
        {
            Path = path;
        }
        public BindingList<ToDoMod> ReadFrom()
            {
            var fileExist = File.Exists(Path);
            if(!fileExist)
            {
                File.CreateText(Path).Dispose();
                return new BindingList<ToDoMod>();
            }
           using(var reader = File.OpenText(Path))
            {
                var fileText = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<ToDoMod>>(fileText);
            }
            }

        public  void Save(object toDoData)
        {
            using (StreamWriter  writer = File.CreateText(Path))
            {
                string output = JsonConvert.SerializeObject(toDoData);
                writer.Write(output);
            }
        }
    }
}
