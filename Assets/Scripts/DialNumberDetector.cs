using UnityEngine;
using UnityEngine.Events;

public class DialNumberDetector : MonoBehaviour
{
    public UnityEvent onCorrectNumberAligned;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered with object on layer: " + LayerMask.LayerToName(other.gameObject.layer));
        Debug.Log("Trigger entered with object with tag: " + other.tag);

        if (other.CompareTag("CorrectNumber"))
        {
            onCorrectNumberAligned.Invoke();
        }
    }
}