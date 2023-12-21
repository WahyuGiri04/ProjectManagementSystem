using System.Globalization;
using System.Transactions;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;

namespace UserManagement;

[ApiController]
[Route("[controller]")]
public class Mt(MtRepo mtRepo) : ControllerBase
{
    private readonly MtRepo _mtRepo = mtRepo;

    [HttpPost]
    public IActionResult LoadDataMT100([FromForm] IFormFileCollection file)
    {   
        try
        {
            var res = new List<Mt100Load>();
            var dataTemp = _mtRepo.LoadDataMT100<Mt100Load>(file[0].OpenReadStream());
            if (dataTemp == null)
            {
                res = null;
            }
            else
            {
                res = dataTemp;
            }
            return new OkObjectResult(res);
        }
        catch (Exception ex)
        {
            return new OkObjectResult(ex);
        }
    }
}

