using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BankApi.DTO;
using BankApi.Services;


namespace BankApi.Controllers
{
    [Route("bank/[controller]")]
    [ApiController]
    public class BankApiController : ControllerBase
    {
        private IBankService _service;
        public BankApiController(IBankService service)
        {
            _service = service;
        }

        [HttpGet()]
        public IActionResult GetBanks()
        {
           
            var allBanks = _service.GetAllBanks();

            return Ok(allBanks);
        }

        [HttpGet("{id}")]
        public IActionResult GetBanksById(int id)
        {
            var newBank = _service.GetBankById(id);

            if (newBank == null)
                return NotFound($"Bank with id {id} could not be found.");

            return Ok(newBank);
        }


        [HttpPost]
        public IActionResult AddNewBank([FromBody] PostBankDto payload)
        {
            var newBank = _service.AddBank(payload);

            return Ok(newBank);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateBank([FromBody] UpdateBankDto payload, int id)
        {
            var bank = _service.GetBankById(id);

            if (bank == null)
                return NotFound($"Bank with id {id} could not be found.");

            var updatedBank = _service.UpdateBank(payload, id);

            return Ok(payload);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteBank(int id)

        {
            var bank = _service.GetBankById(id);

            if (bank == null)
                return NotFound($"Bank with id {id} could not be found.");

            _service.DeleteBank(id);

            return Ok();
        }
    }
}
