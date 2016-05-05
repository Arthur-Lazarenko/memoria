using System;
using UnityEngine;

namespace Memoria
{
    public static class ResourceExporter
    {
        public static void ExportSafe()
        {
            try
            {
                if (!Configuration.Export.Enabled)
                {
                    Log.Message("[ResourceExporter] Pass through {Configuration.Export.Enabled = 0}.");
                    return;
                }

                TextResourceExporter.ExportSafe();
                GraphicResourceExporter.ExportSafe();
                FieldSceneExporter.ExportSafe();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "[ResourceExporter] Failed to export resources.");
            }
        }
    }
}