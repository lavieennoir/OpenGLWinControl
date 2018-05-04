using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using OpenGLWinControl.OpenGL.Enumerations.GLUT;
using OpenGLWinControl.OpenGL.HeapData;

namespace OpenGLWinControl.OpenGL
{
    /// <summary>
    /// Containts static methods imported from GLUT library.
    /// (Here you can find methods wich have prefix glut in source library)
    /// </summary>
    public class GLUT
    {
        public GLUTHeapData HeapData;


        internal GLUT()
        {
            HeapData = new GLUTHeapData();
        }

        public void ReallocHeapData(GLUTHeapData newData)
        {
            HeapData = newData;
        }


        public void BitmapCharacter(BitmapFont font, char character) =>
            bitmapCharacter(font, character);

        [DllImport("glut32.dll", EntryPoint = "glutBitmapCharacter")]
        static extern void bitmapCharacter(BitmapFont font, char character);


        public void StrokeCharacter(StrokeFont font, char character) =>
            strokeCharacter(font, character);

        [DllImport("glut32.dll", EntryPoint = "glutStrokeCharacter")]
        static extern void strokeCharacter(StrokeFont font, char character);


        public delegate void MenuFunction(int selectedItem);
        public int CreateMenu(MenuFunction menuFunc) =>
            createMenu(Marshal.GetFunctionPointerForDelegate<MenuFunction>(menuFunc));

        [DllImport("glut32.dll", EntryPoint = "glutCreateMenu")]
        static extern int createMenu(IntPtr menuFunc);


        public void AddMenuEntry(string label, int value)
        {
            if (label == null || label.Length > HeapData.AddMenuEntryLabelMaxSize)
                throw new ArgumentException("Array has to many elements.");

            if (HeapData.ptrAddMenuEntryLabel != IntPtr.Zero)
                Marshal.FreeHGlobal(HeapData.ptrAddMenuEntryLabel);
            HeapData.ptrAddMenuEntryLabel = Marshal.StringToHGlobalAnsi(label);
            //Marshal.Copy(Encoding.ASCII.GetBytes(label.ToArray()), 0, HeapData.ptrAddMenuEntryLabel, label.Length);
            addMenuEntry(HeapData.ptrAddMenuEntryLabel, value);
        }
        [DllImport("glut32.dll", EntryPoint = "glutAddMenuEntry")]
        static extern void addMenuEntry(IntPtr label, int value);


        public void AddSubMenu(string label, int submenu)
        {
            if (label == null || label.Length > HeapData.AddSubMenuLabelMaxSize)
                throw new ArgumentException("Array has to many elements.");

            if (HeapData.ptrAddSubMenuLabel != IntPtr.Zero)
                Marshal.FreeHGlobal(HeapData.ptrAddSubMenuLabel);
            HeapData.ptrAddSubMenuLabel = Marshal.StringToHGlobalAnsi(label);
            //Marshal.Copy(Encoding.ASCII.GetBytes(label.ToArray()), 0, HeapData.ptrAddMenuEntryLabel, label.Length);
            addSubMenu(HeapData.ptrAddSubMenuLabel, submenu);
        }
        [DllImport("glut32.dll", EntryPoint = "glutAddSubMenu")]
        static extern void addSubMenu(IntPtr label, int submenu);


        public void AttachMenu(Button button) =>
            attachMenu(button);
        [DllImport("glut32.dll", EntryPoint = "glutAttachMenu")]
        static extern void attachMenu(Button button);


        public void DetachMenu(Button button) =>
            detachMenu(button);
        [DllImport("glut32.dll", EntryPoint = "glutDetachMenu")]
        static extern void detachMenu(Button button);

        public void PostRedisplay() =>
            postRedisplay();
        [DllImport("glut32.dll", EntryPoint = "glutPostRedisplay")]
        static extern void postRedisplay();

    }
}
