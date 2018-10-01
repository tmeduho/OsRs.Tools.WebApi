using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using OsRs.Tools.WebApi.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OsRs.Tools.WebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExchangeController : ControllerBase
  {
    private readonly ExchangeContext _context;

    public ExchangeController(ExchangeContext context)
    {
      if (_context.ExchangeItems.Count() == 0)
      {
        // populate the exchange items if the collection is empty
        _context.RefreshData()
      }
    }
  }
}
