﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace AdmToSap
{
    class Connect
    {
        public string server { get; set; }
        public string database { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string ip_sap { get; set; }

        public  string HttpPOST(string url, string querystring) {

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                request.Headers.Add("encoding: utf-8");
            // or whatever - application/json, etc, etc 
            try
            {
                Stream newStream = request.GetRequestStream();

                StreamWriter requestWriter = new StreamWriter(newStream);
                requestWriter.Write(querystring);
                //Console.WriteLine(requestWriter);
                requestWriter.Close();
                requestWriter = null;
            }
            catch (WebException e)
            {
                return e.ToString();

            }


            try
                {
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        return sr.ReadToEnd();
                    }
                }
                catch (WebException ex)
                {
                    return ex.ToString();

                }

        }// fin HttpPOST


    }
}
