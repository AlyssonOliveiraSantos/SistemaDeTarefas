using API.Integracao.Interfaces;
using API.Integracao.Refit;
using API.Integracao.Response;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;

namespace API.Integracao
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        private readonly IViaCepIntegracaoRefit _viaCepIntegracaoRefit;

        public ViaCepIntegracao(IViaCepIntegracaoRefit viaCepIntegracaoRefit)
        {
            _viaCepIntegracaoRefit = viaCepIntegracaoRefit;
        }
        public async Task<ViaCepResponse> ObterDadosViaCep(string cep)
        {
           var responseData = await _viaCepIntegracaoRefit.ObterDadosViaCep(cep);

            if( responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }
            return null;
        }
    }
}
