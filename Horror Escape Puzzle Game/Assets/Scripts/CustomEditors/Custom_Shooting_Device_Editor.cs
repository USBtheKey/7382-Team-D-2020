using UnityEngine;
using UnityEditor;


[CustomEditor(typeof(Shooting_Arrow_Device_Behavior))]
public class Custom_Shooting_Device_Editor : Editor
{


    SerializedProperty repeatRate;
    SerializedProperty delay;
    SerializedProperty burstDelay;
    SerializedProperty firingMode;

    public void OnEnable()
    {
        repeatRate = serializedObject.FindProperty("RepeatRate");
        delay = serializedObject.FindProperty("Delay");
        burstDelay = serializedObject.FindProperty("BurstDelay");
        firingMode = serializedObject.FindProperty("SelectedFiringMode");
    }

    public override void OnInspectorGUI()
    {

        //Declarations
        base.OnInspectorGUI();

        Shooting_Arrow_Device_Behavior myScript = target as Shooting_Arrow_Device_Behavior;

        
        string[] firingMode = new string[] { "None", "Automatic", "Trigger", "Burst", "Random", "Homing" }; 
        //Declarations End
        
        myScript.SelectedFiringMode = EditorGUILayout.Popup("Firing Mode", myScript.SelectedFiringMode, firingMode);
        int mode = myScript.SelectedFiringMode;

        //Display group when choosen

        //door.open = EditorGUILayout.Toggle(...), 
        //serializedObject.FindProperty("open").boolValue = EditorGUILayout.Toggle(...)

        if (mode == 1 || mode == 3 || mode == 4)
        {
            using (var group = new EditorGUILayout.FadeGroupScope(1f))
            {
               EditorGUI.indentLevel++;
               //serializedObject.FindProperty("RepeatRate").floatValue = EditorGUILayout.Slider("Repeat Rate", myScript.RepeatRate, 0, 10);

               myScript.RepeatRate = EditorGUILayout.Slider("Repeat Rate", myScript.RepeatRate, 0, 10);
               myScript.Delay = EditorGUILayout.Slider("Delay", myScript.Delay, 0, 10);
               if(mode == 3) myScript.BurstDelay= EditorGUILayout.Slider("Burst Delay", myScript.BurstDelay, 0, 10);
            }
            //TODO fix values are not saving;   
            //shits not saving WTFFFFFFFFFFFFF being like 3 fucking hours on this garbo fuck!
        }
        serializedObject.Update();
        serializedObject.ApplyModifiedProperties();
        
    }
}
