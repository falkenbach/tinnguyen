﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PokerTexas.App_UserControl;
using PokerTexas.App_Common;
using System.Collections.Specialized;
using System.Data.SQLite;
using PokerTexas.App_Model;
using System.Web.Script.Serialization;

namespace PokerTexas.App_Controller
{
    public class FaceBookController
    {
        public bool LoginMobile(FaceBook model)
        {
            try
            {
                WebClientEx client = new WebClientEx();
                client.UserAgent = AppSettings.UserAgentFaceBook;

                client.DoGet("https://developers.facebook.com/resources/dialog_descriptions_android.json");

                NameValueCollection param = new NameValueCollection();
                param.Add("api_key", AppSettings.api_key);
                param.Add("client_country_code", "VN");
                param.Add("credentials_type", "password");
                param.Add("email", model.Login);
                param.Add("error_detail_type", "button_with_disabled");
                param.Add("fb_api_caller_class", "com.facebook.auth.protocol.AuthenticateMethod");
                param.Add("fb_api_req_friendly_name", "authenticate");
                param.Add("format", "json");
                param.Add("generate_machine_id", "1");
                param.Add("generate_session_cookies", "1");
                param.Add("locale", "en_US");
                param.Add("method", "auth.login");
                param.Add("password", model.Pass);
                string sig = Utilities.getSignFB(param);
                param.Add("sig", sig);

                client.DoPost(param, "https://b-api.facebook.com/method/auth.login");
                if (!string.IsNullOrEmpty(client.ResponseText)
                    && client.ResponseText.Contains("session_key")
                    && client.ResponseText.Contains("access_token"))
                {
                    model.MBLoginText = client.ResponseText;
                    model.MBCookie = Utilities.ConvertObjectToBlob(client.CookieContainer);

                    Dictionary<string, object> rs = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(client.ResponseText);
                    if (rs.ContainsKey("uid"))
                    {
                        model.FBID = rs["uid"].ToString();
                        return true;
                    }


                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return false;
        }
    }
}
