using UnityEngine;

public class CapsuleFinder : MonoBehaviour
{
    public CapsuleCollider[] capsules;
    [SerializeField] Cloth c;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        capsules = FindObjectsByType<CapsuleCollider>(FindObjectsSortMode.InstanceID);
        Debug.Log(capsules[0]);
        c.capsuleColliders = capsules;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
