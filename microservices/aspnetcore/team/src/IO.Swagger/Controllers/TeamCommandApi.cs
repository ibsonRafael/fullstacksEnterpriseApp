/*
 * Allwissend Microservices API
 *
 * Allwissend Team API
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
using IO.Swagger.Attributes;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class TeamCommandApiController : Controller
    { 
        /// <summary>
        /// Delte a Team type using its uuid
        /// </summary>
        /// <remarks>The endpoint returns one *Team* by your uuid. </remarks>
        /// <param name="teamUuid">Unique identifier representing a specific team that needs to be fetched</param>
        /// <response code="202">Accepted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbiden</response>
        /// <response code="404">Resources Not Found</response>
        /// <response code="504">Gateway Timeout</response>
        /// <response code="0">Unexpected error</response>
        [HttpDelete]
        [Route("/v1/team/{teamUuid}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteTeamByUuid")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Resources Not Found")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        [SwaggerResponse(statusCode: 0, type: typeof(Error), description: "Unexpected error")]
        public virtual IActionResult DeleteTeamByUuid([FromRoute][Required]Guid? teamUuid)
        { 
            //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(202);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));

            //TODO: Uncomment the next line to return response 0 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(0, default(Error));


            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves a new Team
        /// </summary>
        /// <remarks>The endpoint save a new *Team*. </remarks>
        /// <param name="body">Team to be saved</param>
        /// <response code="201">Created</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbiden</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpPost]
        [Route("/v1/team")]
        [ValidateModelState]
        [SwaggerOperation("SaveTeam")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult SaveTeam([FromBody]Team body)
        {
            //TODO: Uncomment the next line to return response 201 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(201);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));

            var searchID = Guid.NewGuid();

            var result = IO.Swagger.Elastic.ESConnection.EsClient()
                           .Index(body, i => i
                           .Index("teams").Type("team")
                           .Id(searchID));

            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a Team type
        /// </summary>
        /// <remarks>The endpoint returns a list of *Organization*. </remarks>
        /// <param name="teamUuid">Unique identifier representing a specific team that needs to be fetched</param>
        /// <param name="body">Organization to be updated</param>
        /// <response code="202">Accepted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbiden</response>
        /// <response code="404">Resources Not Found</response>
        /// <response code="405">Invalid input</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpPut]
        [Route("/v1/team/{teamUuid}")]
        [ValidateModelState]
        [SwaggerOperation("UpdateTeam")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Resources Not Found")]
        [SwaggerResponse(statusCode: 405, type: typeof(Error), description: "Invalid input")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult UpdateTeam([FromRoute][Required]Guid? teamUuid, [FromBody]Team body)
        { 
            //TODO: Uncomment the next line to return response 202 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(202);

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 405 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(405, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));


            throw new NotImplementedException();
        }
    }
}
