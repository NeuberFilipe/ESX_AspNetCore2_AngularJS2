using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ESX.Aplication.Service.PersonViewModel;
using ESX.Aplication.Service.Interfaces;
using ESX.Aplication.Service.PersonFilterViewModel;
using ESX.UI.Web.Core.Extensions;
using ESX.UI.Web.Core.Results;
using ESX.UI.Web.Core.Validated;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ESX.UI.Web.Core.Controllers
{
    [Route("api/[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonAplicationService _personAplicationService;
        private readonly PersonValidated _validated;
        public PersonController(IPersonAplicationService iPersonAplicationService, Validated.PersonValidated validated)
        {
            _personAplicationService = iPersonAplicationService;
            _validated = validated;
        }
        // GET: api/<controller>
        [HttpGet]
        public DefaultResults<IEnumerable<PersonViewModel>> Get([FromQuery]PersonFilterViewModel filter)
        {
            var result = new DefaultResults<IEnumerable<PersonViewModel>>();
            try
            {
                result.Result = _personAplicationService.GetLatestCalc(filter);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Erros = new string[] { ex.Message };
            }
            return result;
        }

        // GET api/<controller>PersonViewModel/5
        [HttpGet("{id}")]
        public DefaultResults<PersonViewModel> Get(Guid id)
        {
            var result = new DefaultResults<PersonViewModel>();


            try
            {
                result.Result = _personAplicationService.GetById(id);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Erros = new string[] { ex.Message };
            }

            return result;
        }

        // POST api/<controller>
        [HttpPost]
        public DefaultResults<PersonViewModel> Post([FromBody]PersonViewModel model)
        {
            var result = new DefaultResults<PersonViewModel>();

            var validatedResult = _validated.Validate(model);
            if (validatedResult.IsValid)
            {
                try
                {
                    result.Result = _personAplicationService.CreatePerson(model);
                    result.Success = true;
                }
                catch (Exception ex)
                {
                    result.Erros = new string[] { ex.Message };
                }
            }
            else
            {
                result.Erros = validatedResult.GetErros();
            }
            return result;
        }

        // PUT api/<controller>PersonViewModel/5
        [HttpPut("{id}")]
        public DefaultResults Put(int id, [FromBody]PersonViewModel model)
        {
            var result = new DefaultResults();
            var validatedResult = _validated.Validate(model);

            if (validatedResult.IsValid)
            {
                try
                {
                    result.Success = _personAplicationService.Update(model);
                    if (!result.Success)
                        throw new Exception($"Person{id} can't be updated");
                }
                catch (Exception ex)
                {
                    result.Erros = new string[] { ex.Message };
                }
            }
            else
            {
                result.Erros = validatedResult.GetErros();
            }
            return result;
        }

        // DELETE api/<controller>PersonViewModel/5
        [HttpDelete("{id}")]
        public DefaultResults Delete(Guid id)
        {
            var result = new DefaultResults();
            try
            {
                result.Success = _personAplicationService.Delete(id);
                if (!result.Success)
                throw new Exception($"Person{id} can't be deleted");
                return result;
            }
            catch (Exception ex)
            {
                result.Erros = new string[] { ex.Message };
            }
            return result;
        }
    }
}
