using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace APIAcademia.ConfigurationApi
{
    public class ExceptionHandlerApi : IExceptionHandler
    {
        private readonly ILogger<ExceptionHandlerApi> _logger;

        public ExceptionHandlerApi(ILogger<ExceptionHandlerApi> logger)
        => _logger = logger;

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, 
            Exception exception, CancellationToken cancellationToken)
        {
            var (status, titulo) = exception switch
            {
                KeyNotFoundException => (404, "Recurso não encontrado"),
                InvalidOperationException => (409, "Conflito de operação"),
                ArgumentException => (400, "Requisição invalida"),
                _                 => (500, "Erro interno de servidor")
            };

            if(status == 500)
                _logger.LogError(exception, "Erro inesperado {Mensagem}", exception.Message);
            else
                _logger.LogWarning("Exeção tratada [{Status}]:{Mensagem}",status, exception.Message);

            var problem = new ProblemDetails
            {
                Status = status,
                Title = titulo,
                Detail = exception.Message,
                Instance = httpContext.Request.Path
            };

            httpContext.Response.ContentType = "application/problem+json";
            httpContext.Response.StatusCode = status;

            await httpContext.Response
                                .WriteAsJsonAsync(problem, cancellationToken);

            return true;

        }
    }
}
