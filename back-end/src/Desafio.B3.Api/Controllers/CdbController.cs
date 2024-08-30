using AutoMapper;
using Desafio.B3.Api.ViewModels;
using Desafio.B3.Business.Domain;
using Desafio.B3.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Desafio.B3.Api.Controllers
{
    [Route("api/v1/cdb")]
    public class CdbController : MainController
    {        
        private readonly ICdbService _cdbService;
        private readonly IImpostoService _impostoService;
        private readonly IMapper _mapper;

        public CdbController(ICdbService cdbService,
                             IImpostoService impostoService,
                             IMapper mapper,
                             INotificador notificador) : base(notificador)
        {
            _cdbService = cdbService;
            _impostoService = impostoService;
            _mapper = mapper;
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResultadoInvestimentoViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status422UnprocessableEntity)]
        public ActionResult<ResultadoInvestimentoViewModel> ObterCalculoInvestimento(CdbViewModel cdbViewModel)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var obterValorBruto = _cdbService.ObterCalculo(_mapper.Map<Cdb>(cdbViewModel));            
            var imposto = _impostoService.ObterImposto(cdbViewModel.Mes);
            var obterValorLiquido = _impostoService.ObterCalculo(cdbViewModel.ValorMonetario, obterValorBruto, imposto);

            var resultado = new ResultadoInvestimentoViewModel(obterValorBruto, obterValorLiquido);          

            return CustomResponse(HttpStatusCode.OK, resultado);
        }
    }
}
