#region 连接组件

        public static string Conn(string ConnText)
        {
            string ReadText;
#if !DEBUG
            tryagn:
            try
            {
#endif
            string UrlAdress = "http://" + ConnText;
            Stream stream = System.Net.WebRequest.Create(UrlAdress).GetResponse().GetResponseStream();
            //注意urladress为你上面的网页地址。
            StreamReader sr = new StreamReader(stream, System.Text.Encoding.UTF8);
            ReadText = sr.ReadToEnd(); //由于这里并非读取全部文件
            sr.Close(); //关闭流
            stream.Close();
            ReadText = System.Uri.UnescapeDataString(ReadText);
#if !DEBUG
            }
            catch (Exception ex)
            {
                //return "#ERROR#" + ex.Message;//不进行退回验证了直接要求重试
                if (MessageBox.Show("网络连接错误\n点击重试", "网络资源错误", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    goto tryagn;
                }
                else
                {
                    System.Environment.Exit(0);
                    return "#ERROR#" + ex.Message;//不进行退回验证了直接要求重试
                }
            }
#endif
            return ReadText;
        }
		
		
		private static readonly int Key = DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year;

        public static string Conn(string Action, string Block = "NoF", string Nid = "NoF", string Info = "NoF")
        {
            return Conn("{这里放Database_web的链接}?Key=" + Key + "&Action=" + Action + "&Block=" + Block + "&Nid=" + Nid + "&Info=" + Info);

        }
        public static string Temporaty(string Nid, string Info = "")
        {
            return Conn("{这里放Database_web的链接}Temporaty.asp?Key=" + Key + "&Nid=" + Nid + "&Info=" + Info);

        }
        public static string Upload(string Block, string Nid, string Info)
        {
            return System.Convert.ToString(Conn("Input", Block, Nid, Info));
        }
        public static string Modify(string Block, string Nid, string Info)
        {
            return System.Convert.ToString(Conn("Modify", Block, Nid, Info));
        }
        public static string Append(string Block, string Nid, string Info)
        {//AppendnoUpload Append不能添加数据，只能修改
            return System.Convert.ToString(Conn("Append", Block, Nid, Info));
        }
        public static string Delete(string Block, string Nid)
        {
            return System.Convert.ToString(Conn("Delete", Block, Nid));
        }
        public static string Read(string Block, string Nid)
        {
            return System.Convert.ToString(Conn("Read", Block, Nid));
        }
        public static string ReadAllbyBlock(string Block)
        {
            return System.Convert.ToString(Conn("ReadAllbyBlock", Block));
        }
        public static string GetMaxID(string Block)
        {
            return System.Convert.ToString(Conn("MaxID"));
        }