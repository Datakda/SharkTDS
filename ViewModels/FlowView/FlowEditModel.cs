using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharkTDS.ViewModels.Flow
{
    public class FlowEditModel
    {
        public int Id { get; set; }
        public int GroupId { get; set; }

        public int Identifier { get; set; }


        public string Name { get; set; }

        public int TypeRedirect { get; set; }

        public string Header { get; set; }

        public int TypeDistribution { get; set; }

        public string UrlOrCode { get; set; }

        public string CurlReplace { get; set; }

        public bool IsActiveFlow { get; set; }

        public string Comment { get; set; }





        public byte Сomputer { get; set; }
        public byte Mobile { get; set; }
        public byte Tablet { get; set; }


        public byte Beeline { get; set; }
        public byte Megafon { get; set; }
        public byte Mts { get; set; }
        public byte Tele2 { get; set; }
        public byte Azerbaijan { get; set; }
        public byte Belarus { get; set; }
        public byte Kazakhstan { get; set; }
        public byte Ukraine { get; set; }
        public byte Wap_1 { get; set; }
        public byte Wap_2 { get; set; }
        public byte Wap_3 { get; set; }



        public byte IsActiveCountry { get; set; }
        public string Countries { get; set; }

        public byte IsActiveCity { get; set; }
        public string Cities { get; set; }

        public byte IsActiveRegion { get; set; }
        public string Regions { get; set; }







        public string BrowserLanguag { get; set; }
        public byte IsActiveBrowserLanguage { get; set; }

        public string UserAgent { get; set; }
        public byte IsActiveAvailabilityInUserAgent { get; set; }

        public string Referer { get; set; }
        public byte IsActiveAvailabilityInReferer { get; set; }

        public string DomainName { get; set; }
        public byte IsActiveDomainName { get; set; }

        public string Keyword { get; set; }
        public byte IsActiveAvailabilityInKeyword { get; set; }

        public byte NonUniqueVisitors { get; set; }
        public byte BlankReferer { get; set; }






        public string ActionOnBots { get; set; }

        public string HeaderBots { get; set; }
        public string BotsUrlORCode { get; set; }

        public string BotsReplaceToCURL { get; set; }


        public bool IsActiveSignsBotUserAgent { get; set; }

        public bool EmptyUserAgent { get; set; }
        public bool EmptyReferer { get; set; }
        public bool EmptyBrowserLanguage { get; set; }
        public bool IPV6 { get; set; }

        public bool BlackListUserAgent { get; set; }

        public bool Baidu { get; set; }
        public bool Bing { get; set; }
        public bool Google { get; set; }
        public bool Mailru { get; set; }
        public bool Yahoo { get; set; }
        public bool Yandex { get; set; }
        public bool Others { get; set; }

        public bool SaveIpBot { get; set; }
        public bool IsActiveLimit { get; set; }
        public int Visitors { get; set; }
    }
}
