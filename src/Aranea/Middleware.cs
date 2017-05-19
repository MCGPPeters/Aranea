namespace Aranea
{
    using Microsoft.AspNetCore.Http;

    public delegate RequestDelegate Middleware(RequestDelegate requestDelegate);
}