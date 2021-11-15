using ProductDAL;
using ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductBL
{
    public class ProBL
    {
        public int AddNewDepartment(ProDTO newObj)
        {
            try
            {
                ProDAL dalObj = new ProDAL();
                int result = dalObj.InsertNewDataIntoDepartment(newObj);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
