using System;
using UnityEngine;

namespace MapDesignTool.Scripts
{
    [Serializable]
    public class MapDesignPreferences : ScriptableObject
    {
        public enum TOOLMODE
        {
            Move,
            Building,
            Drawing
        }
        public TOOLMODE toolMode = TOOLMODE.Move;

        public TOOLMODE ToolMode
        {
            get => toolMode;
            set => toolMode = value;
        }

        public string[] prefabPath = new[]
        {
            "Assets/MapDesignTool/Prefabs/Tiles",
            "Assets/MapDesignTool/Prefabs/Props",
            "Assets/MapDesignTool/Prefabs/Environments"
        };

        
    }
}
