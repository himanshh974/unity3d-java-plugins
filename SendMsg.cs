using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SendMsg : MonoBehaviour
{

    public InputField TextInput;
    public string text;

    public void GetText()
    {
        text = TextInput.text;
        MsgToPlugin(text);
    }

    public void MsgToPlugin(string msg)
    {
        Debug.Log(msg);

        AndroidJavaClass unityPlayerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject unityActivity = unityPlayerClass.GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaObject bridge = new AndroidJavaObject("com.example.plugin.FirstPluginTest");
        object[] parameters = new object[2];
        parameters[0] = unityActivity;
        parameters[1] = msg;
        bridge.Call("PrintString", parameters);
    }
}