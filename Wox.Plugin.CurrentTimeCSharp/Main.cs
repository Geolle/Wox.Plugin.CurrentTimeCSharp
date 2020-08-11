using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wox.Plugin;

namespace Wox.Plugin.CurrentTimeCSharp
{
    public class Main : IPlugin
    {
        public void Init(PluginInitContext context) { }

        public List<Result> Query(Query query)
        {
                List<Result> results = new List<Result>();

            results.Add(new Result()
            {
                Title = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                SubTitle = "+++ Click To Copy It +++",
                IcoPath = "time.png",  //相对于插件目录的相对路径
                Action = e =>
                {
                    // 处理用户选择之后的操作
                    Clipboard.SetDataObject(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    //返回false告诉Wox不要隐藏查询窗体，返回true则会自动隐藏Wox查询窗口
                    return true;
                }
            });
            return results;
        }

    }
}
