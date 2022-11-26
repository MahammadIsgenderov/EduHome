using EduHome.Models;
using System.Collections.Generic;

namespace EduHome.ViewsModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public About Abouts { get; set; }
        public List<Courses> Courses { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public Info Info { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
