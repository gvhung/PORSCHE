﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml;
using System.IO;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () {

        //如果使用设计的组件，请取消注释以下行 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }
    [WebMethod(Description="取得更新版本")] 
    public string GetVer() 
    { 
        XmlDocument doc = new XmlDocument(); 
        doc.Load(Server.MapPath("update.xml")); 
        XmlElement root = doc.DocumentElement; 
        return root.SelectSingleNode("version").InnerText; 
    } 

    [WebMethod(Description="在线更新软件")] 
    public System.Xml.XmlDocument GetUpdateData() 
    { 
        //验证用户是否登陆 
        //if(sHeader==null) 
        //return null; 
        //if(!DataProvider.GetInstance.CheckLogin(sHeader.Username,sHeader.Password)) 
        //return null; 
        //取得更新的xml模板内容 
        XmlDocument doc = new XmlDocument(); 
        doc.Load(Server.MapPath("update.xml")); 
        XmlElement root = doc.DocumentElement; 
        //看看有几个文件需要更新 
        XmlNode updateNode = root.SelectSingleNode("filelist"); 
        string path = updateNode.Attributes["sourcepath"].Value; 
        int count = int.Parse(updateNode.Attributes["count"].Value); 
        //将xml中的value用实际内容替换 
        for(int i=0;i<count;i++) 
        { 
            XmlNode itemNode = updateNode.ChildNodes[i]; 
            string fileName = path + itemNode.Attributes["name"].Value; 
            FileStream fs = File.OpenRead(Server.MapPath(fileName)); 
            itemNode.Attributes["size"].Value = fs.Length.ToString(); 
            BinaryReader br = new BinaryReader(fs); 
            //这里是文件的实际内容，使用了Base64String编码 
            itemNode.SelectSingleNode("value").InnerText = Convert.ToBase64String(br.ReadBytes((int)fs.Length),0,(int)fs.Length); 
            br.Close(); 
            fs.Close(); 
        } 
        return doc; 
    } 
}
