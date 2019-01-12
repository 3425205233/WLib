using System;
using System.Windows.Forms;
using ESRI.ArcGIS;

namespace WLib.ArcGis
{
    /// <summary>
    /// ��ʼ��ARCGIS���
    /// </summary>
    public partial class LicenseInitializer
    {
        /// <summary>
        /// ��ʼ��ARCGIS���
        /// </summary>
        public LicenseInitializer()
        {
            ResolveBindingEvent += BindingArcGISRuntime;
        }

        void BindingArcGISRuntime(object sender, EventArgs e)
        {
            ProductCode[] supportedRuntimes = { ProductCode.Engine, ProductCode.Desktop };
            foreach (ProductCode productCode in supportedRuntimes)
            {
                if (RuntimeManager.Bind(productCode))
                    return;
            }
            MessageBox.Show("ArcGIS�����ɴ���", "��ʾ", MessageBoxButtons.OK);
            Environment.Exit(0);
        }
    }
}