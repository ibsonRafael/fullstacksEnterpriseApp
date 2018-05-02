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

using System.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authorization;

namespace Allwissend.AllPlan.Auth.Controllers
{ 

    /// <summary>
    /// 
    /// </summary>
    public class LoginCommandApiController : Controller
    { 
        private IConfiguration Configuration { get; }
        private UserContext Context { get; }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="configuration"></param>
        public LoginCommandApiController(IConfiguration configuration, UserContext context)
        {
            Configuration = configuration;
            Context = context;
        }


        /// <summary>
        /// Authenticate a user against the server/database
        /// </summary>
        /// <remarks>The endpoint save a new *Organization*. </remarks>
        /// <param name="body">User to be authenticate</param>
        /// <response code="200">OK</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="402">Payment Required</response>
        /// <response code="403">Forbiden</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpPost]
        [Route("/v1/auth/login")]
        [ValidateModelState]
        [SwaggerOperation("DoLogin")]
        [SwaggerResponse(statusCode: 200, type: typeof(JWTokenEncoded), description: "OK")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 402, type: typeof(Error), description: "Payment Required")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult DoLogin([FromBody]User body)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(JWTokenEncoded));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401, default(Error));

            //TODO: Uncomment the next line to return response 402 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(402, default(Error));

            //TODO: Uncomment the next line to return response 403 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(403, default(Error));

            //TODO: Uncomment the next line to return response 504 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(504, default(Error));

            User user = Context.Users.Where(u => u._User.Equals("usuario")).First();


            // Define const Key this should be private secret key  stored in some safe place
            string key = Configuration["JwtTokenConfigurations:Key"];

            // Create Security key  using private key above:
            // not that latest version of JWT using Microsoft namespace instead of System
            var securityKey = new Microsoft
                .IdentityModel.Tokens.SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));

            // Also note that securityKey length should be >256b
            // so you have to make sure that your private key has a proper length
            //
            var credentials = new Microsoft.IdentityModel.Tokens.SigningCredentials
                              (securityKey, SecurityAlgorithms.HmacSha256Signature);

            var claimsIdentity = new ClaimsIdentity(new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user._User + "@myprovider.com"),
                new Claim(ClaimTypes.Role, "Administrator"),
            }, "Custom");

            var securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Audience = Configuration["JwtTokenConfigurations:Audience"],
                Issuer = Configuration["JwtTokenConfigurations:Issuer"],
                Subject = claimsIdentity,
                SigningCredentials = credentials,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var plainToken = tokenHandler.CreateToken(securityTokenDescriptor);
            var signedAndEncodedToken = tokenHandler.WriteToken(plainToken);

            Console.WriteLine(plainToken.ToString());
            Console.WriteLine(signedAndEncodedToken);

            return new ObjectResult(signedAndEncodedToken);
        }

        /// <summary>
        /// Authenticate a user against the server/database
        /// </summary>
        /// <remarks>The endpoint save a new *Organization*. </remarks>
        /// <param name="body">User to be authenticate</param>
        /// <response code="202">Accepted</response>
        /// <response code="401">Unauthorized</response>
        /// <response code="402">Payment Required</response>
        /// <response code="403">Forbiden</response>
        /// <response code="504">Gateway Timeout</response>
        [HttpPost, Authorize]
        [Route("/v1/auth/reset")]
        [ValidateModelState]
        [SwaggerOperation("ResetPassword")]
        [SwaggerResponse(statusCode: 401, type: typeof(Error), description: "Unauthorized")]
        [SwaggerResponse(statusCode: 402, type: typeof(Error), description: "Payment Required")]
        [SwaggerResponse(statusCode: 403, type: typeof(Error), description: "Forbiden")]
        [SwaggerResponse(statusCode: 504, type: typeof(Error), description: "Gateway Timeout")]
        public virtual IActionResult ResetPassword([FromBody]User body, [FromHeader]SecurityTokenDescriptor authentication)
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

            Console.WriteLine(authentication);

            throw new NotImplementedException();
        }
    }
}
