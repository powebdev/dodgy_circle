using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Dodgy_Circle
{
    class GEngine
    {
        /*-----------Members----------------*/
        private Graphics drawHandle;
        private Thread renderThread;

        /*-----------Functions----------*/
        public GEngine(Graphics g)
        {
            drawHandle = g;
        }

        public void init()
        {
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
        }

        public void stop()
        {
            renderThread.Abort();
        }

        private void render()
        {
//            while(true)
  //          {
    //            drawHandle.FillRectangle(new SolidBrush(Color.Aqua), 0, 0, 1200, 700);
      //      }
        }
    }
}
