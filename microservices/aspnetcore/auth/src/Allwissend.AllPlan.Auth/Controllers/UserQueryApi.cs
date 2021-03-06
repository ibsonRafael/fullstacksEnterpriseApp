/*
 * Allwissend Microservices API
 *
 * Allwissend Auth API
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Allwissend.AllPlan.Auth.Attributes;
using Allwissend.AllPlan.Auth.Models;

namespace Allwissend.AllPlan.Auth.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class UserQueryApiController : Controller
    { 
        /// <summary>
        /// Get a specific *User*
        /// </summary>
        /// <remarks>The endpoint to update a *User*. </remarks>
        /// <param name="userUuid">Unique identifier representing a specific organization that needs to be fetched</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="402">Payment Required</response>
        /// <response code="403">Forbiden</response>
        /// <response code="404">User not found</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpGet]
        [Route("/v1/auth/user/{userUuid}")]
        [ValidateModelState]
        [SwaggerOperation("GetUser")]
        [SwaggerResponse(statusCode: 200, type: typeof(User), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 402, type: typeof(Error), description: "Payment Required")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "User not found")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult GetUser([FromRoute][Required]Guid? userUuid)
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(User));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 402 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(402, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));

            string exampleJson = null;
            exampleJson = "{\n  \"passwordConfirmation\" : \"passwordConfirmation\",\n  \"password\" : \"password\",\n  \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"user\" : \"user\"\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<User>(exampleJson)
            : default(User);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Get a specific *User*
        /// </summary>
        /// <remarks>The endpoint to update a *User*. </remarks>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="402">Payment Required</response>
        /// <response code="403">Forbiden</response>
        /// <response code="404">User not found</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpGet]
        [Route("/v1/auth/user")]
        [ValidateModelState]
        [SwaggerOperation("ListUser")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<User>), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 402, type: typeof(Error), description: "Payment Required")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "User not found")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult ListUser()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<User>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 402 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(402, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));

            string exampleJson = null;
            exampleJson = "[ {\n  \"passwordConfirmation\" : \"passwordConfirmation\",\n  \"password\" : \"password\",\n  \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"user\" : \"user\"\n}, {\n  \"passwordConfirmation\" : \"passwordConfirmation\",\n  \"password\" : \"password\",\n  \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"user\" : \"user\"\n} ]";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<User>>(exampleJson)
            : default(List<User>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
