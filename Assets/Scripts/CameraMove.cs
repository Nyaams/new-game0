using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] Transform _target;

    void Start()
    {
        transform.parent = null;
    }
    void Update()
    {
        if(_target != null)
        {
            transform.position = _target.position; 
        }
        
    }
}
