using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public abstract class BaseEntity
        //Ortak özellikleri burada tanımladım.Ortak özellikler
        //Abstract kullanılarak tutulur.
    {
        public int Id { get; set; }

                    
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

    }
}
