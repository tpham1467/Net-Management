using System.ComponentModel;
using System.Drawing;

namespace DevExpress
{
    internal class XtraEditors
    {
        public class XtraUserControl
        {
        }

        internal class LabelControl
        {
            public LabelControl()
            {
            }

            public object Appearance { get; internal set; }
            public Point Location { get; internal set; }
            public string Name { get; internal set; }
            public Size Size { get; internal set; }
            public int TabIndex { get; internal set; }
        }

        internal class TextEdit
        {
            public TextEdit()
            {
            }

            public ISupportInitialize Properties { get; internal set; }
            public Point Location { get; internal set; }
            public string Name { get; internal set; }
        }

        internal class SimpleButton
        {
            public SimpleButton()
            {
            }

            public object Appearance { get; internal set; }
        }
    }
}