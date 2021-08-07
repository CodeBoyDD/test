// Copyright(c) 2017 Patrick Becker
//
// Visit the Project page for more information.
// https://github.com/patbec/TaskbarSampleExtension


using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MyDiskInfo.Interop;
using System.Windows.Forms.Integration;
using Utils;
using System.Threading;
using System.Windows.Interop;

namespace MyDiskInfo
{
    /// <summary>
    /// Basic class for a DeskBand object
    /// </summary>
    /// <example>
    /// [ComVisible(true)]
    /// [Guid("00000000-0000-0000-0000-000000000000")]
    /// [DeskBandInfo("Beispiel Erweiterung", "Diese ist eine Beispiel Erweiterung für die Taskleiste.")]
    /// public class SampleExtension : DeskBand
    /// { /*...*/ }
    /// </example>
    public class DeskBand : ElementHost, IObjectWithSite, IDeskBand2, IPersistStream, IInputObject
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern int SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private const int S_OK = 0;
        private const int E_NOTIMPL = unchecked((int)0x80004001);

        protected IInputObjectSite DeskBandSite;

        public DeskBand()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Name = "DeskBand";
        }

        #region Properties

        /// <summary>
        /// Title of the band object, displayed by default on the left or top of the object.
        /// </summary>
        [Browsable(true)]
        [DefaultValue("")]
        public String Title { get; set; }

        /// <summary>
        /// Minimum size of the band object. Default value of -1 sets no minimum constraint.
        /// </summary>
        [Browsable(true)]
        [DefaultValue(typeof(Size), "-1,-1")]
        public Size MinSize { get; set; }

        /// <summary>
        /// Maximum size of the band object. Default value of -1 sets no maximum constraint.
        /// </summary>
        [Browsable(true)]
        [DefaultValue(typeof(Size), "-1,-1")]
        public Size MaxSize { get; set; }

        /// <summary>
        /// Minimum vertical size of the band object. Default value of -1 sets no maximum constraint. (Used when the taskbar is aligned vertically.)
        /// </summary>
        [Browsable(true)]
        [DefaultValue(typeof(Size), "-1,-1")]
        public Size MinSizeVertical { get; set; }

        /// <summary>
        /// Says that band object's size must be multiple of this size. Defauilt value of -1 does not set this constraint.
        /// </summary>
        [Browsable(true)]
        [DefaultValue(typeof(Size), "-1,-1")]
        public Size IntegralSize { get; set; }

        #endregion

        #region IObjectWithSite

        public int SetSite([In, MarshalAs(UnmanagedType.IUnknown)] Object pUnkSite)
        {
            try
            {
                if (DeskBandSite != null) Marshal.ReleaseComObject(DeskBandSite);

                if (pUnkSite != null)
                {
                    var oleWindow = (IOleWindow)pUnkSite;
                    IntPtr pHandle = IntPtr.Zero;
                    oleWindow.GetWindow(out pHandle);
                    SetParent(this.Handle, pHandle);

                    DeskBandSite = (IInputObjectSite)pUnkSite;
                    LogUtil.Log("SetSite S_OK");
                    return WinError.S_OK;
                }
                else
                {
                    LogUtil.Log("SetSite pUnkSite null");
                    return WinError.E_FAIL;
                }
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "SetSite error");
                return WinError.E_FAIL;
            }
        }

        public int GetSite(ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out IntPtr ppvSite)
        {
            try
            {
                if (DeskBandSite != null)
                {
                    var pUnknown = Marshal.GetIUnknownForObject(DeskBandSite);
                    var result = Marshal.QueryInterface(pUnknown, ref riid, out ppvSite);
                    Marshal.Release(pUnknown);

                    LogUtil.Log("GetSite " + result);
                    return result;
                }
                else
                {
                    LogUtil.Log("GetSite E_FAIL");
                    ppvSite = IntPtr.Zero;
                    return WinError.E_FAIL;
                }
            }
            catch (Exception ex)
            {
                LogUtil.Error(ex, "GetSite error");
                Thread.Sleep(200);
                ppvSite = IntPtr.Zero;
                return WinError.E_FAIL;
            }
        }

        #endregion

        #region IDeskBand2

        public virtual int CanRenderComposited(out bool pfCanRenderComposited)
        {
            pfCanRenderComposited = true;
            return S_OK;
        }

        public int SetCompositionState(bool fCompositionEnabled)
        {
            fCompositionEnabled = true;
            return S_OK;
        }

        public int GetCompositionState(out bool pfCompositionEnabled)
        {
            pfCompositionEnabled = false;
            return S_OK;
        }

        public int GetBandInfo(uint dwBandID, DESKBANDINFO.DBIF dwViewMode, ref DESKBANDINFO pdbi)
        {
            if (pdbi.dwMask.HasFlag(DESKBANDINFO.DBIM.DBIM_MINSIZE))
            {
                // Support for a vertical taskbar
                // Most examples have no support for a vertical taskbar. Who in hell uses their taskbar vertically? Me! Very practical on a 21:9 monitor.
                if (dwViewMode.HasFlag(DESKBANDINFO.DBIF.DBIF_VIEWMODE_FLOATING) || dwViewMode.HasFlag(DESKBANDINFO.DBIF.DBIF_VIEWMODE_VERTICAL))
                {
                    pdbi.ptMinSize.Y = this.MinSizeVertical.Width;
                    pdbi.ptMinSize.X = this.MinSizeVertical.Height;
                }
                else
                {
                    pdbi.ptMinSize.X = this.MinSize.Width;
                    pdbi.ptMinSize.Y = this.MinSize.Height;
                }
            }
            if (pdbi.dwMask.HasFlag(DESKBANDINFO.DBIM.DBIM_MAXSIZE))
            {
                if (dwViewMode.HasFlag(DESKBANDINFO.DBIF.DBIF_VIEWMODE_FLOATING) || dwViewMode.HasFlag(DESKBANDINFO.DBIF.DBIF_VIEWMODE_VERTICAL))
                {
                    pdbi.ptMaxSize.Y = this.MaxSize.Width;
                    pdbi.ptMaxSize.X = this.MaxSize.Height;
                }
                else
                {
                    pdbi.ptMaxSize.X = this.MaxSize.Width;
                    pdbi.ptMaxSize.Y = this.MaxSize.Height;
                }
            }
            if (pdbi.dwMask.HasFlag(DESKBANDINFO.DBIM.DBIM_INTEGRAL))
            {
                if (dwViewMode.HasFlag(DESKBANDINFO.DBIF.DBIF_VIEWMODE_FLOATING) || dwViewMode.HasFlag(DESKBANDINFO.DBIF.DBIF_VIEWMODE_VERTICAL))
                {
                    pdbi.ptIntegral.Y = this.IntegralSize.Width;
                    pdbi.ptIntegral.X = this.IntegralSize.Height;
                }
                else
                {
                    pdbi.ptIntegral.X = this.IntegralSize.Width;
                    pdbi.ptIntegral.Y = this.IntegralSize.Height;
                }
            }

            if (pdbi.dwMask.HasFlag(DESKBANDINFO.DBIM.DBIM_ACTUAL))
            {
                if (dwViewMode.HasFlag(DESKBANDINFO.DBIF.DBIF_VIEWMODE_FLOATING) || dwViewMode.HasFlag(DESKBANDINFO.DBIF.DBIF_VIEWMODE_VERTICAL))
                {
                    pdbi.ptActual.Y = this.Size.Width;
                    pdbi.ptActual.X = this.Size.Height;
                }
                else
                {
                    pdbi.ptActual.X = this.Size.Width;
                    pdbi.ptActual.Y = this.Size.Height;
                }
            }

            if (pdbi.dwMask.HasFlag(DESKBANDINFO.DBIM.DBIM_TITLE))
            {
                pdbi.wszTitle = this.Title;
            }

            pdbi.dwModeFlags = DESKBANDINFO.DBIMF.DBIMF_ALWAYSGRIPPER | DESKBANDINFO.DBIMF.DBIMF_NORMAL | DESKBANDINFO.DBIMF.DBIMF_VARIABLEHEIGHT;
            pdbi.dwMask = pdbi.dwMask | DESKBANDINFO.DBIM.DBIM_BKCOLOR | DESKBANDINFO.DBIM.DBIM_TITLE; // Testen

            return S_OK;
        }

        public int GetWindow(out IntPtr phwnd)
        {
            phwnd = Handle;
            return S_OK;
        }

        public int ContextSensitiveHelp(bool fEnterMode)
        {
            return S_OK;
        }

        public int ShowDW([In] bool fShow)
        {
            if (fShow)
                Show();
            else
                Hide();

            return S_OK;
        }

        public virtual void ClearResources()
        {
        }

        public int CloseDW([In] uint dwReserved)
        {
            ClearResources();
            Dispose(true);
            return S_OK;
        }

        public int ResizeBorderDW(RECT prcBorder, [In, MarshalAs(UnmanagedType.IUnknown)] IntPtr punkToolbarSite, bool fReserved)
        {
            return E_NOTIMPL;
        }

        #endregion

        #region Implementation of IPersistStream

        int IPersistStream.GetClassID(out Guid pClassID)
        {
            //  Log key events.

            //  Return the server class id.
            pClassID = this.GetType().GUID;

            //  Return success.
            return WinError.S_OK;
        }

        int IPersistStream.IsDirty()
        {
            //  Log key events.

            //  TODO: return S_OK to indicate the object has changed
            //  since the last time is was saved to a stream.

            //  Until we need explorer bar persistence, we're not dirty.
            return WinError.S_FALSE;
        }

        int IPersistStream.Load(object pStm)
        {
            //  Log key events.

            //  Not implemented: Explorer provided Persistence.
            return WinError.S_OK;
        }

        int IPersistStream.Save(IntPtr pStm, bool fClearDirty)
        {
            //  Log key events.

            //  Not implemented: Explorer provided Persistence.
            return WinError.S_OK;
        }

        int IPersistStream.GetSizeMax(out ulong pcbSize)
        {
            //  Log key events.

            //  Not implemented: Explorer provided Persistence.
            pcbSize = 0;
            return WinError.S_OK;
        }

        int IPersist.GetClassID(out Guid pClassID)
        {
            //  Log key events.

            //  The class ID is just a unique identifier for the class, meaning
            //  that we can use the class GUID as it will be provided for
            //  all SharpShell servers.
            pClassID = this.GetType().GUID;

            //  Return success.
            return WinError.S_OK;
        }

        #endregion

        #region Implementation of IInputObject

        /// <summary>
        /// UI-activates or deactivates the object.
        /// </summary>
        /// <param name="fActivate">Indicates if the object is being activated or deactivated. If this value is nonzero, the object is being activated. If this value is zero, the object is being deactivated.</param>
        /// <param name="msg">A pointer to an MSG structure that contains the message that caused the activation change. This value may be NULL.</param>
        /// <returns>
        /// If this method succeeds, it returns S_OK. Otherwise, it returns an HRESULT error code.
        /// </returns>
        int IInputObject.UIActivateIO(bool fActivate, ref MSG msg)
        {

            //  We're done.
            return WinError.S_OK;
        }

        /// <summary>
        /// Determines if one of the object's windows has the keyboard focus.
        /// </summary>
        /// <returns>
        /// Returns S_OK if one of the object's windows has the keyboard focus, or S_FALSE otherwise.
        /// </returns>
        int IInputObject.HasFocusIO()
        {
            return WinError.S_OK;
        }

        /// <summary>
        /// Enables the object to process keyboard accelerators.
        /// </summary>
        /// <param name="msg">The address of an MSG structure that contains the keyboard message that is being translated.</param>
        /// <returns>
        /// Returns S_OK if the accelerator was translated, or S_FALSE otherwise.
        /// </returns>
        int IInputObject.TranslateAcceleratorIO(ref MSG msg)
        {
            return WinError.S_OK;
        }

        #endregion

        #region Register / Unregister

        [ComRegisterFunctionAttribute]
        public static void Register(Type t)
        {
            string guid = t.GUID.ToString("B");

            DeskBandInfoAttribute[] deskBandInfo = (DeskBandInfoAttribute[])
            t.GetCustomAttributes(typeof(DeskBandInfoAttribute), false);

            // Register only the extension if the attribute DeskBandInfo is used.
            if (deskBandInfo.Length == 1)
            {
                RegistryKey rkClass = Registry.ClassesRoot.CreateSubKey(@"CLSID\" + guid);
                RegistryKey rkCat = rkClass.CreateSubKey("Implemented Categories");

                string _displayName = t.Name;
                string _helpText = t.Name;


                if (deskBandInfo[0].DisplayName != null)
                {
                    _displayName = deskBandInfo[0].DisplayName;
                }

                if (deskBandInfo[0].HelpText != null)
                {
                    _helpText = deskBandInfo[0].HelpText;
                }

                rkClass.SetValue(null, _displayName);
                rkClass.SetValue("MenuText", _displayName);
                rkClass.SetValue("HelpText", _helpText);

                // TaskBar
                rkCat.CreateSubKey("{00021492-0000-0000-C000-000000000046}");

                Console.WriteLine(String.Format("{0} {1} {2}", guid, _displayName, "successfully registered."));
            }
            else
            {
                Console.WriteLine(guid + " has no attributes");
            }
        }

        [ComUnregisterFunctionAttribute]
        public static void Unregister(Type t)
        {
            string guid = t.GUID.ToString("B");

            DeskBandInfoAttribute[] deskBandInfo = (DeskBandInfoAttribute[])
            t.GetCustomAttributes(typeof(DeskBandInfoAttribute), false);

            if (deskBandInfo.Length == 1)
            {
                string _displayName = t.Name;

                if (deskBandInfo[0].DisplayName != null)
                {
                    _displayName = deskBandInfo[0].DisplayName;
                }

                Registry.ClassesRoot.CreateSubKey(@"CLSID").DeleteSubKeyTree(guid);

                Console.WriteLine(String.Format("{0} {1} {2}", guid, _displayName, "successfully removed."));
            }
            else
            {
                Console.WriteLine(guid + " has no attributes");
            }
        }

        #endregion

    }
}
