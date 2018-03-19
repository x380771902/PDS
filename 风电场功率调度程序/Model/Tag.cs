using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 风电场功率调度程序
{
   public class Tag
    {
        private string tagName = "";
        private string tagTimestamp="" ; 
        private string tagQuality = ""; 
        private string tagDatatype = "";
        private string tagID="";
        private float  tagRatio=1.0f;
        private double tagValue; 

        public Tag()
        {
             
        }
        public Tag(string tagid)
        {
            tagID = tagid;
        } 

        public Tag(string tagid,string dataType)
        {
            tagID = tagid;
            this.TagDatatype = dataType;
        }

        /// <summary>
        /// 测点ID
        /// </summary>
        public string TagID
        {
            get { return this.tagID; }

            set { tagID = value; }
        }

        /// <summary>
        /// 测点数据类型
        /// </summary>
        public string TagDatatype {
            get { return this.tagDatatype; } 
            set { tagDatatype = value; } 
        }
        /// <summary>
        /// 测点值
        /// </summary>
        public double TagValue {
           get { return this.tagValue; }
           set { tagValue = value ;}
        }

        /// <summary>
        /// 测点时间戳
        /// </summary>
        public string TagTimestamp
        {
            get { return tagTimestamp; }
            set
            {
                if (null == value)
                {
                    tagTimestamp = "";
                }
                else { tagTimestamp = value.ToString(); } 
            }
        } 
        /// <summary>
        /// 测点名称
        /// </summary>
        public string TagName
        {
            get { return this.tagName; } 
            set { tagName = value; }
        }

        /// <summary>
        /// 通讯质量
        /// </summary>
        public string TagQuality
        {
            get { return this.tagQuality; }

            set { tagQuality = value; }
        }



        /// <summary>
        /// 测点通讯质量192=good 0=bad
        /// </summary>

    }
}
