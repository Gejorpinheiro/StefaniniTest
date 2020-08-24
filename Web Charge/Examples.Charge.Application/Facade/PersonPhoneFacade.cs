using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonPhoneFacade : IPersonPhoneFacade
    {
        private readonly IPersonPhoneService _personService;
        private readonly IMapper _mapper;

        public PersonPhoneFacade(IPersonPhoneService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        public async Task<ListPersonPhoneResponse> FindAllAsync()
        {
            var result = await _personPhoneService.FindAllAsync();
            var response = new ListPersonPhoneResponse();
            response.PersonPhoneObjects = new List<PersonPhoneDto>();
            response.PersonPhoneObjects.AddRange(result.Select(x => _mapper.Map<PersonPhoneDto>(x)));
            return response;
        }

        public Task<PersonPhoneResponse> FindAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
