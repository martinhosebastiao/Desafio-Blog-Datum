using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Blog.External.Presentations.Api.Middlewares.Security
{
    public static class SecurityExtensions
    {
        public static IServiceCollection AddSecurity(this IServiceCollection services)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
            });

            services.AddAuthorization(auth =>
            {
                // Criar politica com base no nome do perfil
                // auth.AddPolicy(Polices.Admins, policy => policy.RequireClaim(ClaimTypes.Role, Roles.Admin));

                /*  auth.AddPolicy(Polices.Techs, policy => policy.RequireClaim(ClaimTypes.Role, Roles.TechConnect, Roles.Admin).RequireAssertion(context =>
                  {
                      var _currentUser = new AccessClaimsModel(null, context.User);

                      return _currentUser.Profile == ProfileEnum.TechConnect || _currentUser.Profile == ProfileEnum.Administrator;

                  }));
                  auth.AddPolicy(Polices.Users, policy => policy.RequireClaim(ClaimTypes.Role, Roles.Owner, Roles.Mechanical).RequireAssertion(context =>
                      {
                          //Politicas de acesso com base nas regras de negocio, somente para o grupo Users
                          var _currentUser = new AccessClaimsModel(null, context.User);

                          return _currentUser.Profile == ProfileEnum.Owner || _currentUser.Profile == ProfileEnum.Mechanical;
                      }));
                */

                // Activar politica global
                //  auth.AddPolicy(Polices.Bearers, new AuthorizationPolicyBuilder()
                //  .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                //  .RequireAuthenticatedUser().Build());
            });

            return services;
        }

        public static WebApplication UseSecurity(this WebApplication app)
        {
            //app.UseAuthentication();
            app.UseAuthorization();

            return app;
        }
    }
}
