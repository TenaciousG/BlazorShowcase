using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorTrainPlaying_Wasm.Server.Data;
using BlazorTrainPlaying_Wasm.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlazorTrainPlaying_Wasm.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        RepositoryEF<Customer, NorthwindContext> _CustomerManager;

        public CustomerController(RepositoryEF<Customer, NorthwindContext> CustomerManager)
        {
            _CustomerManager = CustomerManager;
        }

        [HttpGet]
        public async Task<ActionResult<APIListOfEntityResponse<Customer>>> GetAllCustomer()
        {
            try
            {
                var result = await _CustomerManager.GetAll();
                return Ok(new APIListOfEntityResponse<Customer>()
                {
                    Success = true,
                    Data = result
                });
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpGet("{CustomerId}")]
        public async Task<ActionResult<APIEntityResponse<Customer>>> GetByCustomerId(string CustomerId)
        {
            try
            {
                var result = (await _CustomerManager.Get(x => x.CustomerId == CustomerId)).FirstOrDefault();
                if (result != null)
                {
                    return Ok(new APIEntityResponse<Customer>()
                    {
                        Success = true,
                        Data = result
                    });
                }
                else
                {
                    return Ok(new APIEntityResponse<Customer>()
                    {
                        Success = false,
                        ErrorMessages = new List<string>() { "Customer Not Found" },
                        Data = null
                    });
                }
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpGet("{ContactName}/searchbycontactname")]
        public async Task<ActionResult<APIListOfEntityResponse<Customer>>> SearchByContactName(string ContactName)
        {
            try
            {
                var result = await _CustomerManager.Get(x => x.ContactName.ToLower().Contains(ContactName.ToLower()));
                if (result != null && result.Count() > 0)
                {
                    return Ok(new APIListOfEntityResponse<Customer>()
                    {
                        Success = true,
                        Data = result
                    });
                }
                else
                {
                    return Ok(new APIEntityResponse<Customer>()
                    {
                        Success = false,
                        ErrorMessages = new List<string>() { "Customer Not Found" },
                        Data = null
                    });
                }
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpPost]
        public async Task<ActionResult<APIEntityResponse<Customer>>> Post([FromBody] Customer Customer)
        {
            try
            {
                await _CustomerManager.Insert(Customer);
                var result = (await _CustomerManager.Get(x => x.CustomerId == Customer.CustomerId)).FirstOrDefault();
                if (result != null)
                {
                    return Ok(new APIEntityResponse<Customer>()
                    {
                        Success = true,
                        Data = result
                    });
                }
                else
                {
                    return Ok(new APIEntityResponse<Customer>()
                    {
                        Success = false,
                        ErrorMessages = new List<string>() { "Could not find customer after adding it." },
                        Data = null
                    });
                }
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpPut]
        public async Task<ActionResult<APIEntityResponse<Customer>>> Put([FromBody] Customer Customer)
        {
            try
            {
                await _CustomerManager.Update(Customer);
                var result = (await _CustomerManager.Get(x => x.CustomerId == Customer.CustomerId)).FirstOrDefault();
                if (result != null)
                {
                    return Ok(new APIEntityResponse<Customer>()
                    {
                        Success = true,
                        Data = result
                    });
                }
                else
                {
                    return Ok(new APIEntityResponse<Customer>()
                    {
                        Success = false,
                        ErrorMessages = new List<string>() { "Could not find customer after updating it." },
                        Data = null
                    });
                }
            }
            catch (Exception ex)
            {
                // log exception here
                return StatusCode(500);
            }
        }

        [HttpDelete("{CustomerId}")]
        public async Task<ActionResult> Delete(string CustomerId)
        {
            try
            {
                var CustomerList = await _CustomerManager.Get(x => x.CustomerId == CustomerId);
                if (CustomerList != null)
                {
                    var Customer = CustomerList.First();
                    var success = await _CustomerManager.Delete(Customer);
                    if (success)
                        return NoContent();
                    else
                        return StatusCode(500);
                }
                else
                    return StatusCode(500);
            }
            catch (Exception ex)
            {
                // log exception here
                var msg = ex.Message;
                return StatusCode(500);
            }
        }
    }
}
