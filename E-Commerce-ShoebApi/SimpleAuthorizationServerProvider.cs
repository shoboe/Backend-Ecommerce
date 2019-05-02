using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using E_Commerce_ShoebApi.Models;

namespace E_Commerce_ShoebApi
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated(); //   
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
           context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

            using (var db = new sdirecttestdbEntities1())
            {
                if (db != null)
                {
                    var result = (from obj in db.tblUser_Sk
                                  where (obj.Email == context.UserName &&
                                    obj.Password == context.Password)
                                  select obj).ToList();
                    if (result.Count==1)
                    {
                            identity.AddClaim(new Claim("Age", "1"));

                            var props = new AuthenticationProperties(new Dictionary<string, string>
                            {
                                {
                                    "Email", context.UserName
                                }
                             });

                            var ticket = new AuthenticationTicket(identity, props);
                            context.Validated(ticket);
                        }
                        else
                        {
                            context.SetError("invalid_grant", "Provided username and password is incorrect");
                            context.Rejected();
                        }
                    
                }
                else
                {
                    context.SetError("invalid_grant", "Provided username and password is incorrect");
                    context.Rejected();
                }
                return;
            }
        }
    }
}