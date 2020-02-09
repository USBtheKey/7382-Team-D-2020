using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;


[CustomEditor(typeof(Shooting_Arrow_Device_Behavior))]
public class Custom_Shooting_Device_Editor : Editor
{
    private bool test;
    
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        Shooting_Arrow_Device_Behavior myScript = (Shooting_Arrow_Device_Behavior) target;

        
        test = EditorGUILayout.Toggle("Label", test);

        using (var group = new EditorGUILayout.FadeGroupScope(Convert.ToInt32(test))) //converts true/false to 1/0 then why is this the syntax - I have no clue;
        {
            if (group.visible)
            {
                EditorGUI.indentLevel++;
                myScript.carrot = EditorGUILayout.IntSlider(myScript.carrot, 0, 10);
                
            }
        }

        //TODO FINSHI THIS
    }
}
