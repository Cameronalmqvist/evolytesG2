using UnityEngine;

public class TriggeredCollider : MonoBehaviour
{
    private void Start()
    {
        ColliderTrigger colliderTrigger = GetComponent<ColliderTrigger>();

        if (colliderTrigger != null)
        {
            colliderTrigger.onTriggerEnterEvent.AddListener(OnTriggered);
        }
    }

    private void OnTriggered()
    {
        // Do something when triggered by the other collider's event
    }
}
