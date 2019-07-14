using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace jubyLang
{
    public class GLGameSupport
    {
        float RedCred = 0.0f;
        float BlueCred = 0.0f;
        float GreenCred = 0.0f;
        float AlphaCred = 0.0f;
        GameWindow gameWindow;
        public GLGameSupport(GameWindow gameWindow)
        {
            this.gameWindow = gameWindow;
            Start();
        }
        public void SetCred(float RedCred2, float BlueCred2, float GreenCred2, float AlphaCred2)
        {
            RedCred = RedCred2;
            BlueCred = BlueCred2;
            GreenCred = GreenCred2;
            AlphaCred = AlphaCred2;
            gameWindow.Load += Soaded;
        }
        void Start()
        {
            gameWindow.Load += Soaded;
            gameWindow.Run(1.0/60.0);
        }
        void Soaded(object o, EventArgs e)
        {
            GL.ClearColor(RedCred, GreenCred, BlueCred, AlphaCred);
        }
    }
}
