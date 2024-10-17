using System;
using System.Reflection;    //for using protedted method: OnClick
using System.Windows.Forms;

namespace GameServer_Management.Class
{
    public static class Utility
    {
        public static void ClickEvent(Control parent, EventHandler clickEvent)
        {
            if(parent == null || clickEvent == null)
            {
                throw new ArgumentNullException("Control or Event can't be null");
            }
            parent.Click += clickEvent;

            foreach (Control child in parent.Controls)
            {
                child.Click += (s, e) =>
                {
                    MethodInfo onclick = typeof(Control).GetMethod("OnClick", BindingFlags.Instance | BindingFlags.NonPublic);
                    onclick?.Invoke(parent, new object[] { e });
                };
            }
        }
    }
}
