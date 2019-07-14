using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern__职责链模式_.Example
{
    public class Request
    {
        /// <summary>
        /// 申请类别
        /// </summary>
        public string RequestType { get; set; }

        /// <summary>
        /// 申请内容
        /// </summary>
        public string  RequstContent { get; set; }

        public int Number { get; set; }
    }
}
