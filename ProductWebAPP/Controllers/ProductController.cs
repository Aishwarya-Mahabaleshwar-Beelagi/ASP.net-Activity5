using ProductBL;
using ProductDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProductWebAPP.Controllers
{
    public class ProductController : ApiController
    {

        [HttpPost]
        public HttpResponseMessage AddNewDepartment(ProDTO newDeptObj)
        {
            try
            {
                if (newDeptObj != null)
                {
                    ProBL blObj = new ProBL();
                    int result = blObj.AddNewDepartment(newDeptObj);
                    if (result == 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Department added successfully");
                    }
                    else if(result == -1)
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Department Name already Exist");

                    }
                    else if(result == -2)
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Length Of Department Name is <3 or >15");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Department Name or GroupName cannot be NULL");
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Check all input values for department");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }
    }
}

