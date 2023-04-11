using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Events/Event")]
public class GameEvent : ScriptableObject
{
    public string eventName;
    public int eventLuck;

}