using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenGLWinControl.OpenGL;
using OpenGLWinControl.OpenGL.Enumerations;
using OpenGLWinControl.OpenGL.Exceptions;

namespace OpenGLWinControl
{
    /// <summary>
    /// User control for C# Windows Forms that encapsulate OpenGL library.
    /// </summary>
    public partial class OpenGLControl : UserControl
    {
        /// <summary>
        ///     Occurs whenever the control is first time displayed.
        /// </summary>
        public event EventHandler Shown;

        /// <summary>
        ///     Indicates whether control was shown on form.
        /// </summary>
        private bool wasShown = false;

        /// <summary>
        ///     Count of OpenGLControls initialized in application.
        ///     Using more than one OpenGLControl causes OpenGLInitException 
        ///     if EnableMultipleControls set to false.
        /// </summary>
        public static int ControlCount { get; protected set; } = 0;

        /// <summary>
        ///     Determines whether is possible to create more than one OpenGLControl in application.
        ///     Enabling this feature may cause unexpected control behavior!
        /// </summary>
        public static bool EnableMultipleControls;


        bool multipleControls;

        /// <summary>
        ///     Wrapper for static field EnableMultipleControls.
        ///     Used in Windows Forms designer.
        /// </summary>
        [Category("Static")]
        [Browsable(true)]
        [DefaultValue(false)]
        [Description(
            "Determines whether is possible to create" +
            " more than one OpenGLControl in application." +
            " Enabling this feature may cause unexpected control behavior!")]
        public bool MultipleControls
        {
            get => EnableMultipleControls;
            set
            {
                multipleControls = value;
                EnableMultipleControls = value;
            }
        }

        /// <summary>
        ///     Handler for device content.
        /// </summary>
        IntPtr hDC;

        /// <summary>
        ///     Handler for openGL resources.
        /// </summary>
        IntPtr hglrc;

        /// <summary>
        ///     Timer for refreshing the scene
        /// </summary>
        Timer refreshTimer;

        
        /// <summary>
        ///     If set to true control invokes Render method with interval 
        ///     defined in RefreshInterval property.
        ///     Default value is false.
        /// </summary>
        [Category("OpenGL")]
        [Browsable(true)]
        [Description(
            "If set to true control invokes Render method" +
            " with interval defined in RefreshInterval property.")]
        public bool AutoRefresh
        {
            get => refreshTimer.Enabled;
            set => refreshTimer.Enabled = value;
        }

        /// <summary>
        ///     Time in milliseconds between Render calls.
        ///     Default value is 33 (equals 30 FPS)
        /// </summary>
        [Category("OpenGL")]
        [Browsable(true)]
        [Description("Time in milliseconds between Render calls.")]
        public int RefreshInterval
        {
            get => refreshTimer.Interval;
            set => refreshTimer.Interval = value;
        }


        private IRenderingContext renderingContext;


        /// <summary>
        ///     Current rendering context attached to this control.
        /// </summary>
        [Browsable(false)]
        public IRenderingContext RenderingContext
        {
            get => renderingContext;
            set
            {
                if(renderingContext != null)
                    Layout -= (obj, e) => renderingContext.Resize(this.Width, this.Height);

                renderingContext = value;

                if (renderingContext != null)
                {
                    Layout += (obj, e) => renderingContext.Resize(this.Width, this.Height);

                    renderingContext.Init(this.Width, this.Height);
                }
            }
        }

        
        /// <summary>
        ///     Initialize OpenGl Control without callbacks 
        ///     for inintialization and rendering.
        /// </summary>
        /// <exception cref="OpenGLInitException"></exception>
        public OpenGLControl()
        {
            CheckMultipleControls();

            InitializeComponent();
            InitializeOpenGL();
            InitializeRefreshTimer();

            //Render when control is shown
            Shown += (obj, e) => Render();
        }


        #region Initializing methods

        /// <summary>
        ///     Checks control count and whether multiple controls allowed.
        /// </summary>
        void CheckMultipleControls()
        {
            //set static field value in constructor
            EnableMultipleControls = multipleControls;

            //Check count of OpenGLcontrols 
            ControlCount++;
            if (!EnableMultipleControls && ControlCount > 1)
                throw new OpenGLInitException(
                    "Another instance of OpenGLControl class has already been initialized.");
        }

        /// <summary>
        ///     Setup timer to be used for refreshing the scene
        /// </summary>
        void InitializeRefreshTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Tick += (obj, e) => Render();            
            RefreshInterval = 33; // Default value 33 is equal to 30 FPS
        }

        /// <summary>
        ///     Setup Control to use like OpenGL window.
        /// </summary>
        /// <exception cref="OpenGLInitException"></exception>
        void InitializeOpenGL()
        {
            //Get device content handler
            hDC = ContextProcessor.GetDC(this.Handle);

            if (hDC == IntPtr.Zero)
                throw new OpenGLInitException("Can`t get control content handler");

            InitPixelFormat();
        }

        /// <summary>
        ///     Make Windows Forms control compatible with OpenGL calls.
        /// </summary>
        /// <exception cref="OpenGLInitException"></exception>
        void InitPixelFormat()
        {
            // pfd Tells Windows How We Want Things To Be
            ContextProcessor.PIXELFORMATDESCRIPTOR pfd = new ContextProcessor.PIXELFORMATDESCRIPTOR();
            pfd.Init();
            int iPixelFormat;

            // get the device context's best, available pixel format match 
            if ((iPixelFormat = ContextProcessor.ChoosePixelFormat(hDC, ref pfd)) == 0)
                throw new OpenGLInitException("ChoosePixelFormat Failed.");

            if (!ContextProcessor.SetPixelFormat(hDC, iPixelFormat, ref pfd))
                throw new OpenGLInitException("SetPixelFormat Failed.");

            //create openGL context
            hglrc = ContextProcessor.wglGetCurrentContext();

            if ((hglrc = ContextProcessor.wglCreateContext(hDC)) == IntPtr.Zero)
                throw new OpenGLInitException("wglCreateContext Failed.");

            if (!ContextProcessor.wglMakeCurrent(hDC, hglrc))
                throw new OpenGLInitException("wglMakeCurrent Failed.");
        }


        /// <summary>
        ///     Iitializes scene using RenderingContext.Init function
        /// </summary>
        public void InitializeScene()
        {
            if (RenderingContext == null)
                throw new OpenGLInitException("RenderingContext is null.");
            else
                RenderingContext.Init(this.Width, this.Height);
        }

        #endregion

        /// <summary>
        ///     Raises Control.Paint event.
        ///     And raises Shown event if called first time.
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            //Don`t call base.OnPaint to avoid painting control with parent background color
            //base.OnPaint(e);

            if (!wasShown)
            {
                wasShown = true;
                Shown?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        ///     Invokes Render method.
        ///     Raises Control.Layout event.
        /// </summary>
        protected override void OnLayout(LayoutEventArgs e)
        {
            Render();
            base.OnLayout(e);
        }

        /// <summary>
        ///     Render the scene by invoking RenderingContext.Render method.
        /// </summary>
        public void Render()
        {
            if (RenderingContext != null)
            {
                RenderingContext.Render(this.Width, this.Height);
                SwapBuffers();
            }
        }


        /// <summary>
        ///     Swap control context buffers for double buffered render.
        ///     Need to call after each RenderingContext.Render call.
        /// </summary>
        protected void SwapBuffers()
        {
            ContextProcessor.SwapBuffers(hDC);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        ~OpenGLControl()
        {
            this.DestroyHandle();
        }
    }
}
