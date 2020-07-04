using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PostLoading
{
    class SearchColumns
    {
        public string name { get; set; }


        public string title { get; set; }


        public override string ToString()
        {
            return title;
        }

        public static List<SearchColumns> GetColumns()
        {
            return new List<SearchColumns>() {
                    new SearchColumns() { name = "marsoole_id", title = "شماره مرسوله" },
                    new SearchColumns() { name = "sender", title = "فرستنده" },
                    new SearchColumns() { name = "receiver", title = "گیرنده" },
                    new SearchColumns() { name = "destination", title = "مقصد" },
                    new SearchColumns() { name = "detail_time", title = "زمان" },
                    //new SearchColumns() { name = "hagh_maghar", title = "حق مقر" },
                    new SearchColumns() { name = "destination_code", title = "کد مقصد" },
                    new SearchColumns() { name = "source_code", title = "ک م" },
                    new SearchColumns() { name = "d", title = "د" }
                    //new SearchColumns() { name = "vazn", title = "وزن" },
                    //new SearchColumns() { name = "mablagh_ezhar", title = "مبلغ اظهار شده" },
                    //new SearchColumns() { name = "haghe_bime", title = "حق بیمه" },
                    //new SearchColumns() { name = "maliat", title = "مالیات" },
                    //new SearchColumns() { name = "hagh_sahm_p", title = "حق السهم پ" },
                    //new SearchColumns() { name = "hagh_sahm_t_gh", title = "حق السهم ط ق" },
                    //new SearchColumns() { name = "price", title = "مبلغ ریال" }
            };
        }
    }
}
