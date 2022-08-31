using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace api.Controllers
{
    public class employeeController : ApiController
    {

        //function to manage your resourse
        //based convension
        List<employeecs> lis = new List<employeecs>()
        {
            new employeecs(){Id=1,Name="SANAD",salary=30},
             new employeecs(){Id=2,Name="ali",salary=30},
              new employeecs(){Id=3,Name="nader",salary=30},
               new employeecs(){Id=4,Name="samr",salary=30},
                new employeecs(){Id=5,Name="said",salary=30},
        };


        [HttpGet]
        public List<employeecs> Get()
        {
            return lis;
        }

        [HttpGet]
        public employeecs Get(int id)
        {
            return lis.Where(x => x.Id == id).FirstOrDefault();
        }


        [HttpPut]
        public employeecs Put(employeecs em)
        {
            lis.Add(em);
            return em;
        }

        [HttpPost]
        public employeecs Post(int id,employeecs em)
        {
            var x=lis.Where(n=>n.Id == id).FirstOrDefault();
            x.Name=em.Name;
            x.salary = em.salary;
            return x;
        }


        [HttpDelete]
        public void Delete(int id)
        {
            var del=lis.Where(x=>x.Id == id).FirstOrDefault();
            lis.Remove(del);
            
        }
    }
}
