using System.Collections.Generic;

namespace OO.ContentContext
{
    public class Career : Content
    {
        public Career()
        {
            Items = new List<CareerItem>();
        }
        public IList<CareerItem> Items { get; set; }
        //Expression Body
        public int TotalCourses => Items.Count;
        

    }

    
}