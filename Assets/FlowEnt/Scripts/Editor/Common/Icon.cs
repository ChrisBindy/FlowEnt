using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace FriedSynapse.FlowEnt.Editor
{
    public static class Icon
    {
        public static GUIContent Menu = EditorGUIUtility.IconContent("_Menu@2x", "Menu");
        public static GUIContent Play = EditorGUIUtility.IconContent("Animation.Play", "Play");
        public static GUIContent Replay = EditorGUIUtility.IconContent("d_preAudioAutoPlayOff", "Replay");
        public static GUIContent Pause = EditorGUIUtility.IconContent("PauseButton On@2x", "Pause");
        public static GUIContent PrevFrame = EditorGUIUtility.IconContent("Animation.PrevKey", "Previous Frame");
        public static GUIContent NextFrame = EditorGUIUtility.IconContent("Animation.NextKey", "Next Frame");
        public static GUIContent Stop = EditorGUIUtility.IconContent("d_PreMatQuad@2x", "Stop");

        public static GUIStyle Style = new GUIStyle(EditorStyles.miniButton) { padding = new RectOffset(2, 2, 2, 2) };

        public static void SetIcon(this VisualElement visualElement, GUIContent icon)
            => visualElement.style.backgroundImage = new StyleBackground((Texture2D)icon?.image);
    }
}
