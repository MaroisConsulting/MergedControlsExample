using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyToggleButton
{
    public class MyToggleButton : ToggleButton
    {
        public static ComponentResourceKey ButtonBrushKey = 
            new ComponentResourceKey(typeof(MyToggleButton), "ButtonBrush");

        static MyToggleButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyToggleButton), 
                new FrameworkPropertyMetadata(typeof(MyToggleButton)));
        }
    }
}