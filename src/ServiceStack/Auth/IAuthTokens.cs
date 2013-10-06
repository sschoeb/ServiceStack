using System;
using System.Collections.Generic;

namespace ServiceStack.Auth
{
    public interface IAuthTokens : IUserAuthDetails
    {
        string Provider { get; set; }
        string UserId { get; set; }
        string AccessToken { get; set; }
        string AccessTokenSecret { get; set; }
        string RefreshToken { get; set; }
        DateTime? RefreshTokenExpiry { get; set; }
        string RequestToken { get; set; }
        string RequestTokenSecret { get; set; }
        Dictionary<string, string> Items { get; set; }
    }

    public class AuthTokens : IAuthTokens
    {
        public AuthTokens() { Items = new Dictionary<string, string>(); }

        public string Provider { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BirthDateRaw { get; set; }
        public string Country { get; set; }
        public string Culture { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public string MailAddress { get; set; }
        public string Nickname { get; set; }
        public string PostalCode { get; set; }
        public string TimeZone { get; set; }
        public string AccessToken { get; set; }
        public string AccessTokenSecret { get; set; }
        public string RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiry { get; set; }
        public string RequestToken { get; set; }
        public string RequestTokenSecret { get; set; }
        public Dictionary<string, string> Items { get; set; }
    }
}