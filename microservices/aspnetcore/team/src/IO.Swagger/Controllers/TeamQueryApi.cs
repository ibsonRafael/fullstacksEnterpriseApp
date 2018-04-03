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
    public class TeamQueryApiController : Controller
    {
        /// <summary>
        /// Get a specific Team
        /// </summary>
        /// <remarks>The endpoint returns one *Team* by your uuid. </remarks>
        /// <param name="teamUuid">Unique identifier representing a specific team that needs to be fetched</param>
        /// <response code="200">An Organization</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbiden</response>
        /// <response code="404">Resources Not Found</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpGet]
        [Route("/v1/team/{teamUuid}")]
        [ValidateModelState]
        [SwaggerOperation("GetTeamByUuid")]
        [SwaggerResponse(statusCode: 200, type: typeof(Team), description: "An Organization")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Resources Not Found")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult GetTeamByUuid([FromRoute][Required]Guid? teamUuid)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Team));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));

            string exampleJson = null;
            exampleJson = "{\n  \"code\" : \"code\",\n  \"members\" : [ {\n    \"period\" : {\n      \"start\" : \"start\",\n      \"end\" : \"end\"\n    },\n    \"practitioner\" : {\n      \"name\" : {\n        \"given\" : [ \"given\", \"given\" ],\n        \"lastUpdated\" : \"lastUpdated\",\n        \"prefix\" : [ \"prefix\", \"prefix\" ],\n        \"alias\" : \"alias\",\n        \"family\" : \"family\",\n        \"suffix\" : [ \"suffix\", \"suffix\" ],\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"first\" : \"first\",\n        \"creation\" : \"creation\"\n      },\n      \"active\" : true,\n      \"photo\" : [ {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      }, {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      } ],\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"type\" : \"permanent\",\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"evaluation\"\n  }, {\n    \"period\" : {\n      \"start\" : \"start\",\n      \"end\" : \"end\"\n    },\n    \"practitioner\" : {\n      \"name\" : {\n        \"given\" : [ \"given\", \"given\" ],\n        \"lastUpdated\" : \"lastUpdated\",\n        \"prefix\" : [ \"prefix\", \"prefix\" ],\n        \"alias\" : \"alias\",\n        \"family\" : \"family\",\n        \"suffix\" : [ \"suffix\", \"suffix\" ],\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"first\" : \"first\",\n        \"creation\" : \"creation\"\n      },\n      \"active\" : true,\n      \"photo\" : [ {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      }, {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      } ],\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"type\" : \"permanent\",\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"evaluation\"\n  } ],\n  \"name\" : \"name\",\n  \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"defaultLocation\" : {\n    \"operationalStatus\" : \"operationalStatus\",\n    \"identifier\" : \"identifier\",\n    \"name\" : \"name\",\n    \"alias\" : [ \"alias\", \"alias\" ],\n    \"type\" : {\n      \"code\" : \"code\",\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"active\"\n  },\n  \"status\" : \"working\",\n  \"currentLocation\" : {\n    \"operationalStatus\" : \"operationalStatus\",\n    \"identifier\" : \"identifier\",\n    \"name\" : \"name\",\n    \"alias\" : [ \"alias\", \"alias\" ],\n    \"type\" : {\n      \"code\" : \"code\",\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"active\"\n  }\n}";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<Team>(exampleJson)
            : default(Team);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// List all teams for current user
        /// </summary>
        /// <remarks>The endpoint returns a list of *Organization* by its current *Status*. </remarks>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <response code="200">An array of Team</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbiden</response>
        /// <response code="404">Resources Not Found</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpGet]
        [Route("/v1/team")]
        [ValidateModelState]
        [SwaggerOperation("ListTeam")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Team>), description: "An array of Team")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Resources Not Found")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult ListTeam([FromQuery]List<string> status)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Team>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));


            var result = IO.Swagger.Elastic.ESConnection.EsClient().Search<Team>(s => s
                .Index("teams")
                .Type("team")
                .From(0)
                .Size(1000)
                .Query(q => q.MatchAll()));

            List<Team> lista = new List<Team>();
            foreach (var hit in result.Hits)  {
                lista.Add(hit.Source);
            }

            var response = (result.Hits.Any() ? lista : default(List<Team>));

            return new ObjectResult(response);
        }

        /// <summary>
        /// List all teams for current user
        /// </summary>
        /// <remarks>The endpoint returns a list of *Organization* by its current *Status*. </remarks>
        /// <param name="status">Status values that need to be considered for filter</param>
        /// <response code="200">An array of Team</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="403">Forbiden</response>
        /// <response code="404">Resources Not Found</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpGet]
        [Route("/v1/team/findByStatus")]
        [ValidateModelState]
        [SwaggerOperation("ListTeamByStatus")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<Team>), description: "An array of Team")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 404, type: typeof(Error), description: "Resources Not Found")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult ListTeamByStatus([FromQuery]List<string> status)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Team>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));

            string exampleJson = null;
            exampleJson = "[ {\n  \"code\" : \"code\",\n  \"members\" : [ {\n    \"period\" : {\n      \"start\" : \"start\",\n      \"end\" : \"end\"\n    },\n    \"practitioner\" : {\n      \"name\" : {\n        \"given\" : [ \"given\", \"given\" ],\n        \"lastUpdated\" : \"lastUpdated\",\n        \"prefix\" : [ \"prefix\", \"prefix\" ],\n        \"alias\" : \"alias\",\n        \"family\" : \"family\",\n        \"suffix\" : [ \"suffix\", \"suffix\" ],\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"first\" : \"first\",\n        \"creation\" : \"creation\"\n      },\n      \"active\" : true,\n      \"photo\" : [ {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      }, {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      } ],\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"type\" : \"permanent\",\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"evaluation\"\n  }, {\n    \"period\" : {\n      \"start\" : \"start\",\n      \"end\" : \"end\"\n    },\n    \"practitioner\" : {\n      \"name\" : {\n        \"given\" : [ \"given\", \"given\" ],\n        \"lastUpdated\" : \"lastUpdated\",\n        \"prefix\" : [ \"prefix\", \"prefix\" ],\n        \"alias\" : \"alias\",\n        \"family\" : \"family\",\n        \"suffix\" : [ \"suffix\", \"suffix\" ],\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"first\" : \"first\",\n        \"creation\" : \"creation\"\n      },\n      \"active\" : true,\n      \"photo\" : [ {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      }, {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      } ],\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"type\" : \"permanent\",\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"evaluation\"\n  } ],\n  \"name\" : \"name\",\n  \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"defaultLocation\" : {\n    \"operationalStatus\" : \"operationalStatus\",\n    \"identifier\" : \"identifier\",\n    \"name\" : \"name\",\n    \"alias\" : [ \"alias\", \"alias\" ],\n    \"type\" : {\n      \"code\" : \"code\",\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"active\"\n  },\n  \"status\" : \"working\",\n  \"currentLocation\" : {\n    \"operationalStatus\" : \"operationalStatus\",\n    \"identifier\" : \"identifier\",\n    \"name\" : \"name\",\n    \"alias\" : [ \"alias\", \"alias\" ],\n    \"type\" : {\n      \"code\" : \"code\",\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"active\"\n  }\n}, {\n  \"code\" : \"code\",\n  \"members\" : [ {\n    \"period\" : {\n      \"start\" : \"start\",\n      \"end\" : \"end\"\n    },\n    \"practitioner\" : {\n      \"name\" : {\n        \"given\" : [ \"given\", \"given\" ],\n        \"lastUpdated\" : \"lastUpdated\",\n        \"prefix\" : [ \"prefix\", \"prefix\" ],\n        \"alias\" : \"alias\",\n        \"family\" : \"family\",\n        \"suffix\" : [ \"suffix\", \"suffix\" ],\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"first\" : \"first\",\n        \"creation\" : \"creation\"\n      },\n      \"active\" : true,\n      \"photo\" : [ {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      }, {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      } ],\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"type\" : \"permanent\",\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"evaluation\"\n  }, {\n    \"period\" : {\n      \"start\" : \"start\",\n      \"end\" : \"end\"\n    },\n    \"practitioner\" : {\n      \"name\" : {\n        \"given\" : [ \"given\", \"given\" ],\n        \"lastUpdated\" : \"lastUpdated\",\n        \"prefix\" : [ \"prefix\", \"prefix\" ],\n        \"alias\" : \"alias\",\n        \"family\" : \"family\",\n        \"suffix\" : [ \"suffix\", \"suffix\" ],\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"first\" : \"first\",\n        \"creation\" : \"creation\"\n      },\n      \"active\" : true,\n      \"photo\" : [ {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      }, {\n        \"lastUpdated\" : \"lastUpdated\",\n        \"extension\" : \"extension\",\n        \"data\" : \"data\",\n        \"size\" : 0,\n        \"language\" : \"language\",\n        \"title\" : \"title\",\n        \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n        \"contentType\" : \"contentType\",\n        \"url\" : \"url\",\n        \"hash\" : \"hash\",\n        \"creation\" : \"creation\"\n      } ],\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"type\" : \"permanent\",\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"evaluation\"\n  } ],\n  \"name\" : \"name\",\n  \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n  \"defaultLocation\" : {\n    \"operationalStatus\" : \"operationalStatus\",\n    \"identifier\" : \"identifier\",\n    \"name\" : \"name\",\n    \"alias\" : [ \"alias\", \"alias\" ],\n    \"type\" : {\n      \"code\" : \"code\",\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"active\"\n  },\n  \"status\" : \"working\",\n  \"currentLocation\" : {\n    \"operationalStatus\" : \"operationalStatus\",\n    \"identifier\" : \"identifier\",\n    \"name\" : \"name\",\n    \"alias\" : [ \"alias\", \"alias\" ],\n    \"type\" : {\n      \"code\" : \"code\",\n      \"name\" : \"name\",\n      \"description\" : \"description\",\n      \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\"\n    },\n    \"uuid\" : \"046b6c7f-0b8a-43b9-b35d-6489e6daee91\",\n    \"status\" : \"active\"\n  }\n} ]";

            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<List<Team>>(exampleJson)
            : default(List<Team>);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}