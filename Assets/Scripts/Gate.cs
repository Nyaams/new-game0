using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;

    [SerializeField] DeformationType _deformationType;

    [SerializeField] GateLook _gateLook;

    private void OnValidate()
    {
        _gateLook.VisualUpdate(_deformationType, _value);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerModifier playerModifier = other.attachedRigidbody.GetComponent<PlayerModifier>();
        if (playerModifier != null)
        {
            if(_deformationType == DeformationType.Width)
            {
                playerModifier.AddWidth(_value);
            }
            else if (_deformationType == DeformationType.Height)
            {
                playerModifier.AddHeight(_value);
            }
            Destroy(gameObject);
        }
    }
}
