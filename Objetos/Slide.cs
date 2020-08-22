using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Interop.PowerPoint;

namespace tcc
{
    public class Slide
    {
        private static  Microsoft.Office.Interop.PowerPoint.Application  ppt;
        private static bool isIniciado = false;

        public Slide()
        {
            if (!Slide.isIniciado)
            {
                Slide.isIniciado = true;
                Slide.ppt = new Application();               
            }
        }

        public void iniciarPowerPoint()
        {
            Slide.ppt.Activate();
            //Slide.ppt.Presentations.Open("C:\\Users\\Ricardo\\Documents\\teste.ppt", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse);
            //Slide.ppt.Presentations[1].SlideShowSettings.Run();
        }
       
        
    }
}
