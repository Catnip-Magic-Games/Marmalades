using UnityEngine;
using UnityEditor;
using System.IO;

public class EventImport
{
    private static string EventsPath = "/Editor/CSVs/Events.csv";

    [MenuItem("Utilities/Generate Events")]
    public static void GenerateEvent()
    {
        string[] allLines = File.ReadAllLines(Application.dataPath + EventsPath);

        foreach (string s in allLines)
        {
            string[] splitData = s.Split(',');

            GameEvent gameEvent = ScriptableObject.CreateInstance<GameEvent>();
            gameEvent.eventName = splitData[0];
            gameEvent.eventLuck = int.Parse(splitData[1]);

            AssetDatabase.CreateAsset(gameEvent, $"Assets/Event/{gameEvent.eventName}.asset");
        } 

        AssetDatabase.SaveAssets();
    }
}

