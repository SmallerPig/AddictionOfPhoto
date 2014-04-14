using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

/*==========================================================
*作者：SmallerPig
*时间：2014/1/09 10:31:07
*版权所有:无锡睿阅数字科技有限公司
============================================================*/
namespace RY.Common
{

    /// <summary>
    /// 
    /// </summary>
    public static class TextForConsole
    {
        static string bg_bigClass = "inputComponentBg_big";
        static string titleClass = "titleMark";
        static string inputTextClass = "input_text";
        static string inputUploadClass = "input_text";
        static string inputCheckBoxClass = "input_text";


        /// <summary>
        /// 
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="name">要显示数据模型的字段值，对应input的name属性</param>
        /// <param name="value">默认值。对应input的value属性</param>
        /// <returns></returns>
        public static MvcHtmlString ConsoleTextBox(this HtmlHelper helper, string showName, string name = "", string value = "")
        {
            string result = "<div class=\"" + bg_bigClass + "\"><div class=\"" + titleClass + "\">" + showName + "</div><input id=\""
                + name + "\" name=\"" + name + "\" class=\"input_text\" value=\"" + value + "\"/></div>";
            return new MvcHtmlString(result);
        }


        #region Upload

        public static MvcHtmlString ConsoleUpload(this HtmlHelper helper, string showName, string name, string url, params string[] fileFormat)
        {
            return ConsoleUpload(helper, showName, name, url, "/Content/ConsoleResource/Other/uploaderResource/swf/uploader.swf",
                "", 10, "上传文件", fileFormat
                );
        }

        public static MvcHtmlString ConsoleUpload(this HtmlHelper helper, string showName, string name, string url, string swfUrl, params string[] fileFormat)
        {
            return ConsoleUpload(helper: helper,
                showName: showName,
                name: name,
                url:url,
                swfUrl: swfUrl,
                value:"",
                fileSize: 10,
                tips:"上传文件",
                fileFormat: fileFormat
                );
        }

        public static MvcHtmlString ConsoleUpload(this HtmlHelper helper, string showName, string name, string url, string swfUrl,string tips, params string[] fileFormat)
        {
            return ConsoleUpload(helper: helper,
                showName: showName,
                name: name,
                url: url,
                swfUrl: swfUrl,
                value: "",
                fileSize: 10,
                tips: tips,
                fileFormat: fileFormat
                );
        }

        
        /// <summary>
        /// 返回上传控件！请确保页面引用了对应的Js文件
        /// </summary>
        /// <param name="helper"></param>
        /// <param name="showName">显示名称</param>
        /// <param name="name">对应实体的属性值</param>
        /// <param name="url">要上传到的URL地址</param>
        /// <param name="swfUrl">swf地址</param>
        /// <param name="value">默认值</param>
        /// <param name="fileSize">允许的最大文件大小</param>
        /// <param name="tips">上传建议,将显示在</param>
        /// <param name="fileFormat">允许上传的文件格式</param>
        /// <returns>core.upload控件</returns>
        public static MvcHtmlString ConsoleUpload(this HtmlHelper helper,
            string showName,
            string name = "", string url = "/Upload/Image",
            string swfUrl = "/Content/ConsoleResource/Other/uploaderResource/swf/uploader.swf",
            string value = "",
            int fileSize = 2,
            string tips = "上传文件",
            params string[] fileFormat)
        {
            string file = "";
            if (fileFormat != null)
            {
                foreach (string f in fileFormat)
                {
                    file += f + ",";
                }
            }
            string result = "<div class=\"" + bg_bigClass + "\">"
               + "<div class=\"" + titleClass + "\" style=\"line-height: 35px;\">" + showName + "</div>"
               + "<div class=\"uploaderContainer\">"
                   + " <script type=\"text/javascript\">"
                        + "core.uploader.create({"
                            + "uploadUrl: \"" + url + "\","
                            + "swfUrl: \"" + swfUrl + "\","
                            + "defaultName: '" + value + "',"
                            + " nameRespondElement: \"" + name + "_name\","
                            + "valueRespondElement: \"" + name + "\","
                            + "fileFormat: \"上传文件:" + file + "\","
                            + "fileSize: " + fileSize + ","
                            + "defaultUiString: {"
                                + "btn_select: \"" + tips + "\""
                            + "}"
                        + "});"
                    + "</script>"
                    + "<input id=\"" + name + "_name\" name=\"" + name + "_name\" class=\"hiddenValue\" value='' />"
                    + "<input id=\"" + name + "\" name=\"" + name + "\" class=\"hiddenValue\" value=\"" + value + "\"/>"
                + "</div>"
            + "</div>";
            return new MvcHtmlString(result);
        }

        #endregion


        public static MvcHtmlString ConsoleCheckBox(this HtmlHelper helper, string showName, string name, bool isChecked)
        {
            string tf = isChecked ? "checked" : "";

            string result = "<div class=\"" + bg_bigClass + "\">"
                + "<div class=\"" + titleClass + " small\">" + showName + "</div>"
                + "<div class=\"inputfolder\">"
                + "    <input id=\"" + name + "\" name=\"" + name + "\" type=\"checkbox\" " + tf + " value=\"true\"><input name=\"" + name + "\" type=\"hidden\" value=\"false\"><label></label>"
                + "</div>"
                + "</div>";
            return new MvcHtmlString(result);

        }




    }
}
