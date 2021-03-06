﻿using System.Net;
using YaR.MailRuCloud.Api.Base.Auth;

namespace YaR.MailRuCloud.Api.Base.Requests.WebV2
{
    class EnsureSdcCookieRequest : BaseRequestString
    {
        public EnsureSdcCookieRequest(HttpCommonSettings settings, IAuth auth) 
            : base(settings, auth)
        {
        }

        protected override HttpWebRequest CreateRequest(string baseDomain = null)
        {
            var request = base.CreateRequest(CommonSettings.AuthDomain);
            request.Accept = CommonSettings.DefaultAcceptType;
            return request;
        }

        protected override string RelationalUri
        {
            get
            {
                var uri = $"/sdc?from={ConstSettings.CloudDomain}/home";
                return uri;
            }
        }
    }
}
