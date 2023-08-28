using UnityEngine;
using UnityEngine.Events;

public class ColliderTrigger : MonoBehaviour
{
    public UnityEvent onTriggerEnterEvent; // Define an event

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("collider")) // Check if the other collider has a specific tag
        {
            onTriggerEnterEvent.Invoke(); // Trigger the event
        }
    }
}

