using System;
using System.Collections.Generic;
using System.Text;

namespace AngleTool
{
    /// <summary>
    /// 医院个性化配置，仅有此文件能够放置医院个性化信息
    /// </summary>
    public static class HospitalCustomizedConfig
    {
        /// <summary>
        /// hosts文件内容标记，根据有无此标记判断是否是程序修改过的hosts，标记开始
        /// 
        /// 此常量作为重要的识别标识符，请勿修改
        /// </summary>
        public static string regionStart = "# modified by angle-schedule 请勿修改此区块内容 start";

        /// <summary>
        /// hosts文件内容标记，根据有无此标记判断是否是程序修改过的hosts，标记结束
        /// 
        /// 此常量作为重要的识别标识符，请勿修改
        /// </summary>
        public static string regionEnd = "# modified by angle-schedule 请勿修改此区块内容 end";

        /// <summary>
        /// Hosts版本
        /// </summary>
        public static string hostsVersion = "# angle-schedule-yuebei V1.0.0";

        /// <summary>
        /// 个性化的Hosts配置
        /// </summary>
        public static string[] hostsForAdd = { regionStart, hostsVersion,
                    "128.28.16.248 www.hoswork.com", "128.28.16.248 mch.hoswork.com",
                    "58.67.212.249 www.hoswork.com", "58.67.212.254 qy.gzhc365.com",
                    "59.37.116.113 open.work.weixin.qq.com", "218.75.177.22 js.aq.qq.com",
                    "59.63.235.19 rescdn.qqmail.com", "175.6.26.201 p0xytndy5.bkt.clouddn.com",
                    "47.95.64.126 www.ncqis.cn",
                    regionEnd };

        /// <summary>
        /// 粤北版本
        /// </summary>
        public static string version = "1.2.0 粤北";
    }
}
