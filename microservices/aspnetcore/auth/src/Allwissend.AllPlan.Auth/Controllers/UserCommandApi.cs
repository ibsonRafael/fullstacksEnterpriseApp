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
    public class UserCommandApiController : Controller
    { 
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <remarks>The endpoint save a new *User*. </remarks>
        /// <param name="body">User to be created</param>
        /// <response code="202">Accepted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="402">Payment Required</response>
        /// <response code="403">Forbiden</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpPost]
        [Route("/v1/auth/user")]
        [ValidateModelState]
        [SwaggerOperation("CreateUser")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 402, type: typeof(Error), description: "Payment Required")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult CreateUser([FromBody]User body)
        { 
            //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(202);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 402 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(402, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));


            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete a *User* by his uuid
        /// </summary>
        /// <remarks>The endpoint to update a *User*. </remarks>
        /// <param name="userUuid">Unique identifier representing a specific organization that needs to be fetched</param>
        /// <response code="202">Accepted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="402">Payment Required</response>
        /// <response code="403">Forbiden</response>
        /// <response code="404">User not found</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpDelete]
        [Route("/v1/auth/user/{userUuid}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteUser")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 402, type: typeof(Error), description: "Payment Required")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "User not found")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult DeleteUser([FromRoute][Required]Guid? userUuid)
        { 
            //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(202);

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


            throw new NotImplementedException();
        }

        /// <summary>
        /// Authenticate a user against the server/database
        /// </summary>
        /// <remarks>The endpoint to update a *User*. </remarks>
        /// <param name="userUuid">Unique identifier representing a specific organization that needs to be fetched</param>
        /// <param name="body">User to be updated</param>
        /// <response code="202">Accepted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="402">Payment Required</response>
        /// <response code="403">Forbiden</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpPut]
        [Route("/v1/auth/user/{userUuid}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateUser")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 402, type: typeof(Error), description: "Payment Required")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult UpdateUser([FromRoute][Required]Guid? userUuid, [FromBody]User body)
        { 
            //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(202);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 402 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(402, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));


            throw new NotImplementedException();
        }
    }
}