using UnityEngine;
using UnityEngine.Events;

public class DialNumberDetector : MonoBehaviour
{
    public UnityEvent onCorrectNumberAligned;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered: " + other.tag);
        if (other.CompareTag("CorrectNumber") && other.gameObject.layer == LayerMask.NameToLayer("MyLayer"))
        {
            onCorrectNumberAligned.Invoke();
        }
    }
}