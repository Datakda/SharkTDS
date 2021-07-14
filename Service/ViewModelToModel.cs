using SharkTDS.Models;
using SharkTDS.ViewModels;
using SharkTDS.ViewModels.Flow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.Service
{
    public static class ViewModelToModel
    {
        public static Group ConvertGroupAddModelToGroup(GroupAddModel model)
        {
            Group group = new Group();
            group.Id = model.Id;
            group.Name = model.Name;
            group.Identifier = model.Identifier;
            group.TypeRedirect = model.TypeRedirect;
            group.Header = model.Header;
            group.UrlORCode = model.UrlORCode;
            group.ReplaceToCURL = model.ReplaceToCURL;
            group.GeoBase = model.GeoBase;
            group.UniquenessCheck = model.UniquenessCheck;
            group.TermUniqueness = model.TermUniqueness;
            group.IsActiveBanGroupToTime = model.IsActiveBanGroupToTime;
            group.LimitQestion = model.LimitQestion;
            group.TimePeriod = model.TimePeriod;
            group.SaveKeys = model.SaveKeys;
            group.SaveKeysOfReferer = model.SaveKeysOfReferer;
            group.GroupIsActive = model.GroupIsActive;
            group.Comment = model.Comment;



            return group;
        }

        public static Group Convert(EditGroupModel model) 
        {
            Group group = new Group();
            group.Id = model.Id;
            group.Name = model.Name;
            group.Identifier = model.Identifier;
            group.TypeRedirect = model.TypeRedirect;
            group.Header = model.Header;
            group.UrlORCode = model.UrlORCode;
            group.ReplaceToCURL = model.ReplaceToCURL;
            group.GeoBase = model.GeoBase;
            group.UniquenessCheck = model.UniquenessCheck;
            group.TermUniqueness = model.TermUniqueness;
            group.IsActiveBanGroupToTime = model.IsActiveBanGroupToTime;
            group.LimitQestion = model.LimitQestion;
            group.TimePeriod = model.TimePeriod;
            group.SaveKeys = model.SaveKeys;
            group.SaveKeysOfReferer = model.SaveKeysOfReferer;
            group.GroupIsActive = model.GroupIsActive;
            group.Comment = model.Comment;



            return group;
        }

        public static EditGroupModel ConvertGroupToEditGroupModel(Group model)
        {
            EditGroupModel group = new EditGroupModel();
            group.Id = model.Id;
            group.Name = model.Name;
            group.Identifier = model.Identifier;
            group.TypeRedirect = model.TypeRedirect;
            group.Header = model.Header;
            group.UrlORCode = model.UrlORCode;
            group.ReplaceToCURL = model.ReplaceToCURL;
            group.GeoBase = model.GeoBase;
            group.UniquenessCheck = model.UniquenessCheck;
            group.TermUniqueness = model.TermUniqueness;
            group.IsActiveBanGroupToTime = model.IsActiveBanGroupToTime;
            group.LimitQestion = model.LimitQestion;
            group.TimePeriod = model.TimePeriod;
            group.SaveKeys = model.SaveKeys;
            group.SaveKeysOfReferer = model.SaveKeysOfReferer;
            group.GroupIsActive = model.GroupIsActive;
            group.Comment = model.Comment;
            group.Flows = model.Flows;


            return group;
        }




        public static Flow ConvertFlowAddModelToFlow(FlowAddModel model) 
        {
            Flow flow = new Flow();
            flow.GroupId = model.GroupId;
            flow.Identifier = model.Identifier;
            flow.Name = model.Name;
            flow.TypeRedirect = model.TypeRedirect;
            flow.Header = model.Header;
            flow.TypeDistribution = model.TypeDistribution;
            flow.UrlOrCode = model.UrlOrCode;
            flow.CurlReplace = model.CurlReplace;
            flow.IsActiveFlow = model.IsActiveFlow;
            flow.Comment = model.Comment;
            flow.Сomputer = model.Сomputer;
            flow.Mobile = model.Mobile;
            flow.Tablet = model.Tablet;
            flow.Beeline = model.Beeline;
            flow.Megafon = model.Megafon;
            flow.Mts = model.Mts;
            flow.Tele2 = model.Tele2;
            flow.Azerbaijan = model.Azerbaijan;
            flow.Belarus = model.Belarus;
            flow.Kazakhstan = model.Kazakhstan;
            flow.Ukraine = model.Ukraine;
            flow.Wap_1 = model.Wap_1;
            flow.Wap_2 = model.Wap_2;
            flow.Wap_3 = model.Wap_3;
            flow.IsActiveCountry = model.IsActiveCountry;
            flow.Countries = model.Countries;
            flow.IsActiveCity = model.IsActiveCity;
            flow.Cities = model.Cities;
            flow.IsActiveRegion = model.IsActiveRegion;
            flow.Regions = model.Regions;
            flow.BrowserLanguag = model.BrowserLanguag;
            flow.IsActiveBrowserLanguage = model.IsActiveBrowserLanguage;
            flow.UserAgent = model.UserAgent;
            flow.IsActiveAvailabilityInUserAgent = model.IsActiveAvailabilityInUserAgent;
            flow.Referer = model.Referer;
            flow.IsActiveAvailabilityInReferer = model.IsActiveAvailabilityInReferer;
            flow.DomainName = model.DomainName;
            flow.IsActiveDomainName = model.IsActiveDomainName;
            flow.Keyword = model.Keyword;
            flow.IsActiveAvailabilityInKeyword = model.IsActiveAvailabilityInKeyword;
            flow.NonUniqueVisitors = model.NonUniqueVisitors;
            flow.BlankReferer = model.BlankReferer;
            flow.ActionOnBots = model.ActionOnBots;
            flow.HeaderBots = model.HeaderBots;
            flow.BotsUrlOrCode = model.BotsUrlORCode;
            flow.BotsReplaceToCURL = model.BotsReplaceToCURL;
            flow.IsActiveSignsBotUserAgent = model.IsActiveSignsBotUserAgent;
            flow.EmptyUserAgent = model.EmptyUserAgent;
            flow.EmptyReferer = model.EmptyReferer;
            flow.EmptyBrowserLanguage = model.EmptyBrowserLanguage;
            flow.IPV6 = model.IPV6;
            flow.BlackListUserAgent = model.BlackListUserAgent;
            flow.Baidu = model.Baidu;
            flow.Bing = model.Bing;
            flow.Google = model.Google;
            flow.Mailru = model.Mailru;
            flow.Yahoo = model.Yahoo;
            flow.Yandex = model.Yandex;
            flow.Others = model.Others;
            flow.SaveIpBot = model.SaveIpBot;
            flow.IsActiveLimit = model.IsActiveLimit;
            flow.Visitors = model.Visitors;


            return flow;
        }
        public static FlowEditModel ConvertFlowToFlowEditModel(Flow model)
        {
            FlowEditModel flow = new FlowEditModel();
            flow.GroupId = model.GroupId;
            flow.Identifier = model.Identifier;
            flow.Name = model.Name;
            flow.TypeRedirect = model.TypeRedirect;
            flow.Header = model.Header;
            flow.TypeDistribution = model.TypeDistribution;
            flow.UrlOrCode = model.UrlOrCode;
            flow.CurlReplace = model.CurlReplace;
            flow.IsActiveFlow = model.IsActiveFlow;
            flow.Comment = model.Comment;
            flow.Сomputer = model.Сomputer;
            flow.Mobile = model.Mobile;
            flow.Tablet = model.Tablet;
            flow.Beeline = model.Beeline;
            flow.Megafon = model.Megafon;
            flow.Mts = model.Mts;
            flow.Tele2 = model.Tele2;
            flow.Azerbaijan = model.Azerbaijan;
            flow.Belarus = model.Belarus;
            flow.Kazakhstan = model.Kazakhstan;
            flow.Ukraine = model.Ukraine;
            flow.Wap_1 = model.Wap_1;
            flow.Wap_2 = model.Wap_2;
            flow.Wap_3 = model.Wap_3;
            flow.IsActiveCountry = model.IsActiveCountry;
            flow.Countries = model.Countries;
            flow.IsActiveCity = model.IsActiveCity;
            flow.Cities = model.Cities;
            flow.IsActiveRegion = model.IsActiveRegion;
            flow.Regions = model.Regions;
            flow.BrowserLanguag = model.BrowserLanguag;
            flow.IsActiveBrowserLanguage = model.IsActiveBrowserLanguage;
            flow.UserAgent = model.UserAgent;
            flow.IsActiveAvailabilityInUserAgent = model.IsActiveAvailabilityInUserAgent;
            flow.Referer = model.Referer;
            flow.IsActiveAvailabilityInReferer = model.IsActiveAvailabilityInReferer;
            flow.DomainName = model.DomainName;
            flow.IsActiveDomainName = model.IsActiveDomainName;
            flow.Keyword = model.Keyword;
            flow.IsActiveAvailabilityInKeyword = model.IsActiveAvailabilityInKeyword;
            flow.NonUniqueVisitors = model.NonUniqueVisitors;
            flow.BlankReferer = model.BlankReferer;
            flow.ActionOnBots = model.ActionOnBots;
            flow.HeaderBots = model.HeaderBots;
            flow.BotsUrlORCode = model.BotsUrlOrCode;
            flow.BotsReplaceToCURL = model.BotsReplaceToCURL;
            flow.IsActiveSignsBotUserAgent = model.IsActiveSignsBotUserAgent;
            flow.EmptyUserAgent = model.EmptyUserAgent;
            flow.EmptyReferer = model.EmptyReferer;
            flow.EmptyBrowserLanguage = model.EmptyBrowserLanguage;
            flow.IPV6 = model.IPV6;
            flow.BlackListUserAgent = model.BlackListUserAgent;
            flow.Baidu = model.Baidu;
            flow.Bing = model.Bing;
            flow.Google = model.Google;
            flow.Mailru = model.Mailru;
            flow.Yahoo = model.Yahoo;
            flow.Yandex = model.Yandex;
            flow.Others = model.Others;
            flow.SaveIpBot = model.SaveIpBot;
            flow.IsActiveLimit = model.IsActiveLimit;
            flow.Visitors = model.Visitors;


            return flow;
        }

        public static Flow ConvertFlowEditModelToFlow(FlowEditModel model)
        {
            Flow flow = new Flow();
            flow.Id = model.Id;
            flow.GroupId = model.GroupId;
            flow.Identifier = model.Identifier;
            flow.Name = model.Name;
            flow.TypeRedirect = model.TypeRedirect;
            flow.Header = model.Header;
            flow.TypeDistribution = model.TypeDistribution;
            flow.UrlOrCode = model.UrlOrCode;
            flow.CurlReplace = model.CurlReplace;
            flow.IsActiveFlow = model.IsActiveFlow;
            flow.Comment = model.Comment;
            flow.Сomputer = model.Сomputer;
            flow.Mobile = model.Mobile;
            flow.Tablet = model.Tablet;
            flow.Beeline = model.Beeline;
            flow.Megafon = model.Megafon;
            flow.Mts = model.Mts;
            flow.Tele2 = model.Tele2;
            flow.Azerbaijan = model.Azerbaijan;
            flow.Belarus = model.Belarus;
            flow.Kazakhstan = model.Kazakhstan;
            flow.Ukraine = model.Ukraine;
            flow.Wap_1 = model.Wap_1;
            flow.Wap_2 = model.Wap_2;
            flow.Wap_3 = model.Wap_3;
            flow.IsActiveCountry = model.IsActiveCountry;
            flow.Countries = model.Countries;
            flow.IsActiveCity = model.IsActiveCity;
            flow.Cities = model.Cities;
            flow.IsActiveRegion = model.IsActiveRegion;
            flow.Regions = model.Regions;
            flow.BrowserLanguag = model.BrowserLanguag;
            flow.IsActiveBrowserLanguage = model.IsActiveBrowserLanguage;
            flow.UserAgent = model.UserAgent;
            flow.IsActiveAvailabilityInUserAgent = model.IsActiveAvailabilityInUserAgent;
            flow.Referer = model.Referer;
            flow.IsActiveAvailabilityInReferer = model.IsActiveAvailabilityInReferer;
            flow.DomainName = model.DomainName;
            flow.IsActiveDomainName = model.IsActiveDomainName;
            flow.Keyword = model.Keyword;
            flow.IsActiveAvailabilityInKeyword = model.IsActiveAvailabilityInKeyword;
            flow.NonUniqueVisitors = model.NonUniqueVisitors;
            flow.BlankReferer = model.BlankReferer;
            flow.ActionOnBots = model.ActionOnBots;
            flow.HeaderBots = model.HeaderBots;
            flow.BotsUrlOrCode = model.BotsUrlORCode;
            flow.BotsReplaceToCURL = model.BotsReplaceToCURL;
            flow.IsActiveSignsBotUserAgent = model.IsActiveSignsBotUserAgent;
            flow.EmptyUserAgent = model.EmptyUserAgent;
            flow.EmptyReferer = model.EmptyReferer;
            flow.EmptyBrowserLanguage = model.EmptyBrowserLanguage;
            flow.IPV6 = model.IPV6;
            flow.BlackListUserAgent = model.BlackListUserAgent;
            flow.Baidu = model.Baidu;
            flow.Bing = model.Bing;
            flow.Google = model.Google;
            flow.Mailru = model.Mailru;
            flow.Yahoo = model.Yahoo;
            flow.Yandex = model.Yandex;
            flow.Others = model.Others;
            flow.SaveIpBot = model.SaveIpBot;
            flow.IsActiveLimit = model.IsActiveLimit;
            flow.Visitors = model.Visitors;


            return flow;
        }


    }
}
