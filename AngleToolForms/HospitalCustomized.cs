using System;
using System.Collections.Generic;
using System.Text;

namespace AngleToolForms
{
    public class HospitalCustomized
    {
        /// <summary>
        /// hosts文件内容标记，根据有无此标记判断是否是程序修改过的hosts，标记开始
        /// 
        /// 此常量作为重要的识别标识符，请勿修改
        /// </summary>
        private string regionStart;

        /// <summary>
        /// hosts文件内容标记，根据有无此标记判断是否是程序修改过的hosts，标记结束
        /// 
        /// 此常量作为重要的识别标识符，请勿修改
        /// </summary>
        private string regionEnd;

        /// <summary>
        /// Hosts版本
        /// </summary>
        private string hostsVersion;

        /// <summary>
        /// 个性化的Hosts配置
        /// </summary>
        private string[] hostsForAdd;

        /// <summary>
        /// 粤北版本
        /// </summary>
        private string version;

        public string RegionStart
        {
            get
            {
                return regionStart;
            }

            set
            {
                regionStart = value;
            }
        }

        public string RegionEnd
        {
            get
            {
                return regionEnd;
            }

            set
            {
                regionEnd = value;
            }
        }

        public string HostsVersion
        {
            get
            {
                return hostsVersion;
            }

            set
            {
                hostsVersion = value;
            }
        }

        public string[] HostsForAdd
        {
            get
            {
                return hostsForAdd;
            }

            set
            {
                hostsForAdd = value;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }
    }
}
