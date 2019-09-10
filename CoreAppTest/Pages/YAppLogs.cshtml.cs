using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreAppTest.Pages
{
    public class YAppLogsModel : PageModel
    {

        public string Message { get; set; }
        public void OnGet()
        {
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "C:\\Users\\recep.kaya.BIMSADOM\\Desktop\\scripts2");
            Message = "YAppLogs";
        }
    }
}