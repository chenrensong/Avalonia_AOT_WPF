using Avalonia.Controls;
using Avalonia.Platform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ViewModels;
using WpfLibrary1;

namespace AvaloniaAOT
{
    public class EmbedSample : NativeControlHost
    {
#if !WINDOWS
        private IntPtr? WidgetHandleToDestroy { get; set; }
#endif

        protected override IPlatformHandle CreateNativeControlCore(IPlatformHandle parent)
        {

            MyWpfUserControl control = new MyWpfUserControl();
            control.DataContext = new ClickCounterViewModel();
            //// 获取 ElementHost 的类型信息  
            //Type elementHostType = typeof(WindowsHost);// Type.GetType("WpfControl.WindowsHost");

            //// 创建 ElementHost 的实例  
            //object elementHost = Activator.CreateInstance(elementHostType);

            //// 获取 Child 属性  
            //PropertyInfo childProperty = elementHostType.GetProperty("Child", BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            //// 设置 Child 属性  
            //childProperty.SetValue(elementHost, control);
            //PropertyInfo handleProperty = elementHostType.GetProperty("Handle", BindingFlags.Public | BindingFlags.Instance);

            //// 获取 Handle 属性的值  
            //IntPtr handleValue = (IntPtr)handleProperty.GetValue(elementHost);

            WindowsHost host = new WindowsHost { Child = control };

            return new PlatformHandle(host.Handle, "Ctrl");

        }

        protected override void DestroyNativeControlCore(IPlatformHandle control)
        {

            // destroy the win32 window
            WinApi.DestroyWindow(control.Handle);

            base.DestroyNativeControlCore(control);
        }
    }
}
