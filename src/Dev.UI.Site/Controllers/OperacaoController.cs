using System;
using Dev.UI.Site.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dev.UI.Site.Controllers
{
    public class OperacaoController : Controller
    {
        private readonly OperacaoService _operacaoService, _operacaoService2;
        public OperacaoController(OperacaoService operacaoService, OperacaoService operacaoService2)
        {
            _operacaoService = operacaoService;
            _operacaoService2 = operacaoService2;
        }

        public string PlayGround()
        {

            return 
                "Primeira instância: " + Environment.NewLine +
                _operacaoService.Transient.OperacaoId + Environment.NewLine +
                _operacaoService.Scoped.OperacaoId + Environment.NewLine +
                _operacaoService.Singleton.OperacaoId + Environment.NewLine +
                _operacaoService.SingletonInstance.OperacaoId + Environment.NewLine +

                Environment.NewLine +
                Environment.NewLine +

                "Segunda instância: " + Environment.NewLine +
                _operacaoService2.Transient.OperacaoId + Environment.NewLine +
                _operacaoService2.Scoped.OperacaoId + Environment.NewLine +
                _operacaoService2.Singleton.OperacaoId + Environment.NewLine +
                _operacaoService2.SingletonInstance.OperacaoId + Environment.NewLine;
        }
    }
}