﻿
using Microsoft.AspNetCore.Mvc;

namespace Towns.webapi.Controllers
{
    [Route("/api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CustomControllerBase : ControllerBase
    {
    }
}