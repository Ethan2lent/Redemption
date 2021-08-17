﻿//Quick Scripts v2 by Jack Wilson, Navlight Games 2021.
//Thank you for purchasing this product.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
using QuickScripts;

[CustomEditor (typeof (QuickRotate))]
[CanEditMultipleObjects]
public class QSEditor_QuickRotate : Editor {

	static string helpText = "Quick Tips:" +
        "\n\n1. Smoothed rotation type means this game object will accelerate to its maximum speed when 'Rotating' is ticked.It will decelerate when not ticked." +
        "\n\n2. Only use Exponential rotation type if you plan on removing the object soon after.It is strongly recommended you do not leave it on exponential forever." +
        "\n\n3. Acceleration for Smoothed type = Time it takes to reach maximum speed. " +
        "\n\n4. Acceleration for Exponential type = Speed addition per frame." +
        "\n\nIn Exponential mode this number gets hardcoded to be divided by 1000 before the current speed is multiplied by it, so it is recommended to keep this number small, around 0.5 - 5." +
        "\n\nFor more information on how to use this component, see the User Guide.";

    public bool showHelp;


	public override void OnInspectorGUI ()
	{
		showHelp = (bool)EditorGUILayout.Toggle ("Show Help", showHelp);
		if (showHelp)
		{
			EditorGUILayout.BeginFadeGroup (1);
			EditorGUILayout.HelpBox (helpText, MessageType.None);
			if (GUILayout.Button ("User Guide"))
				OpenUserGuide ();
			EditorGUILayout.EndFadeGroup ();
		}
		DrawDefaultInspector ();

		if (GUI.changed)
		{
           // EditorUtility.SetDirty(_)
			serializedObject.ApplyModifiedProperties ();
		}
	}

	void OpenUserGuide()
	{
		System.Diagnostics.Process.Start (Application.dataPath + "/QuickScripts/QuickScriptsUserGuide.pdf");
	}
}
