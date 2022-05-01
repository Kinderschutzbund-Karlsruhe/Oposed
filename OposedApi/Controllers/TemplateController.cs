﻿using Microsoft.AspNetCore.Mvc;
using OposedApi.Attributes;
using OposedApi.Models;

namespace OposedApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TemplateController : BasicConrollerFunctions<Template>
    {

    }
}