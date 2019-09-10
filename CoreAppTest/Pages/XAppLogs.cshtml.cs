using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreAppTest.Pages
{   
    public class XAppLogsModel : PageModel
    {
       

        public string txtName { get; set; }
        public string ArananStr { get; set; }

        public IActionResult OnGet()
        {          
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "C:\\Users\\recep.kaya.BIMSADOM\\Desktop\\scripts");


            string[] xmlFiles = Directory.GetFiles("C:\\Users\\recep.kaya.BIMSADOM\\Desktop\\scripts");
            DirectoryInfo di = new DirectoryInfo("C:\\Users\\recep.kaya.BIMSADOM\\Desktop\\scripts");
            string arama = "1";
            bool aramaSonuc;
            ArananStr = "C:\\Users\\recep.kaya.BIMSADOM\\Desktop\\scripts\\" + arama + ".sql";
            if (!string.IsNullOrEmpty(ArananStr))
            {
                aramaSonuc = xmlFiles.Contains(ArananStr);

            }
            return Page();
        }
        
    }
}