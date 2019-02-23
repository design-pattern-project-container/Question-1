using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// DataSource is a basic Data Source for the swimmer class namely fullname , sex , age , strocke
namespace firstProject
{

    public class DataSource
    {
        public String[,] lists = new String[5, 4] {
            { "jack jill","M","18","2.5"},
            { "Robel bale","F","19","4"},
            { "tame robe","M","25","3.5"},
            { "Torltel Jaro","F","17","3.6"},
            { "Fillar jems","M","35","4.7"}
        };
        public String[,] getSwimmers()
        {
            return lists;
        }
    }
}
       