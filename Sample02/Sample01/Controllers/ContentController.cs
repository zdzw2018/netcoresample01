using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;

namespace Sample01.Controllers
{
    /// <summary>
    /// Content控制器
    /// </summary>
    public class ContentController : Controller
    {
        private readonly Content contents1;
        public ContentController(IOptionsSnapshot<Content> option)
        {
            contents1 = option.Value;
        }

        /// <summary>
        /// 首页显示
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var contents = new List<Content>();
            //for (int i = 0; i < 11; i++)
            //{
            //    contents.Add(new Content { Id = i, title = $"{i}的标题", content = $"{i}的内容", status = 1, add_time = DateTime.Now.AddDays(-i) });
            //}
            contents.Add(contents1);
            return View(new ContentViewModel { Contents = contents });
        }
    }
}