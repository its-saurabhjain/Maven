using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace BirthDefectRegistry.Controllers
{
    [Route("api/[controller]")]
    public class BirthDefectController: Controller{

        public IActionResult Get(){
            IList<string> birthDefectList = new List<string>();
            birthDefectList.Add("Allergies");
            birthDefectList.Add("Reflux");
            birthDefectList.Add("Speech");
            birthDefectList.Add("Depression");
            birthDefectList.Add("Asthama");
            birthDefectList.Add("Anger");
            return Ok(birthDefectList);
        } 
    }
}