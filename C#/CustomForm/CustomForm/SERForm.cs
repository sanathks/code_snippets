using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace CustomForm
{
    class SERForm:Form
    {
        Dwm.MARGINS dwmMargins;
        bool _marginOk;
        private bool _aeroEnabled;

        protected override void WndProc(ref Message m)
        {
            int WM_NCCALCSIZE = 0x83;
            int WM_NCHITTEST = 0x84;
            IntPtr result;

            int dwmHandled = Dwm.DwmDefWindowProc(m.HWnd, m.Msg, m.WParam, m.LParam, out result);

            if (dwmHandled == 1)
            {
                m.Result = result;
                return;
            }

            if (m.Msg == WM_NCCALCSIZE && (int)m.WParam == 1)
            {
                NCCALCSIZE_PARAMS nccsp = (NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NCCALCSIZE_PARAMS));

                // Adjust (shrink) the client rectangle to accommodate the border:
                nccsp.rect0.Top += 0;
                nccsp.rect0.Bottom += 0;
                nccsp.rect0.Left += 0;
                nccsp.rect0.Right += 0;

                if (!_marginOk)
                {
                    //Set what client area would be for passing to DwmExtendIntoClientArea
                    dwmMargins.cyTopHeight = 5;
                    dwmMargins.cxLeftWidth = 1;
                    dwmMargins.cyBottomHeight = 1;
                    dwmMargins.cxRightWidth = 1;
                    _marginOk = true;
                }

                Marshal.StructureToPtr(nccsp, m.LParam, false);

                m.Result = IntPtr.Zero;
            }
            else if (m.Msg == WM_NCHITTEST && (int)m.Result == 0)
            {
                m.Result = HitTestNCA(m.HWnd, m.WParam, m.LParam);
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private IntPtr HitTestNCA(IntPtr hwnd, IntPtr wparam, IntPtr lparam)
        {
            int HTNOWHERE = 0;
            int HTCLIENT = 1;
            int HTCAPTION = 2;
            int HTGROWBOX = 4;
            int HTSIZE = HTGROWBOX;
            int HTMINBUTTON = 8;
            int HTMAXBUTTON = 9;
            int HTLEFT = 10;
            int HTRIGHT = 11;
            int HTTOP = 12;
            int HTTOPLEFT = 13;
            int HTTOPRIGHT = 14;
            int HTBOTTOM = 15;
            int HTBOTTOMLEFT = 16;
            int HTBOTTOMRIGHT = 17;
            int HTREDUCE = HTMINBUTTON;
            int HTZOOM = HTMAXBUTTON;
            int HTSIZEFIRST = HTLEFT;
            int HTSIZELAST = HTBOTTOMRIGHT;

            Point p = new Point(100,200);

            Rectangle topleft = RectangleToScreen(new Rectangle(0, 0, dwmMargins.cxLeftWidth, dwmMargins.cxLeftWidth));

            if (topleft.Contains(p))
                return new IntPtr(HTTOPLEFT);

            Rectangle topright = RectangleToScreen(new Rectangle(Width - dwmMargins.cxRightWidth, 0, dwmMargins.cxRightWidth, dwmMargins.cxRightWidth));

            if (topright.Contains(p))
                return new IntPtr(HTTOPRIGHT);

            Rectangle botleft = RectangleToScreen(new Rectangle(0, Height - dwmMargins.cyBottomHeight, dwmMargins.cxLeftWidth, dwmMargins.cyBottomHeight));

            if (botleft.Contains(p))
                return new IntPtr(HTBOTTOMLEFT);

            Rectangle botright = RectangleToScreen(new Rectangle(Width - dwmMargins.cxRightWidth, Height - dwmMargins.cyBottomHeight, dwmMargins.cxRightWidth, dwmMargins.cyBottomHeight));

            if (botright.Contains(p))
                return new IntPtr(HTBOTTOMRIGHT);

            Rectangle top = RectangleToScreen(new Rectangle(0, 0, Width, dwmMargins.cxLeftWidth));

            if (top.Contains(p))
                return new IntPtr(HTTOP);

            Rectangle cap = RectangleToScreen(new Rectangle(0, dwmMargins.cxLeftWidth, Width, dwmMargins.cyTopHeight - dwmMargins.cxLeftWidth));

            if (cap.Contains(p))
                return new IntPtr(HTCAPTION);

            Rectangle left = RectangleToScreen(new Rectangle(0, 0, dwmMargins.cxLeftWidth, Height));

            if (left.Contains(p))
                return new IntPtr(HTLEFT);

            Rectangle right = RectangleToScreen(new Rectangle(Width - dwmMargins.cxRightWidth, 0, dwmMargins.cxRightWidth, Height));

            if (right.Contains(p))
                return new IntPtr(HTRIGHT);

            Rectangle bottom = RectangleToScreen(new Rectangle(0, Height - dwmMargins.cyBottomHeight, Width, dwmMargins.cyBottomHeight));

            if (bottom.Contains(p))
                return new IntPtr(HTBOTTOM);

            return new IntPtr(HTCLIENT);
        }
        
    }
}
