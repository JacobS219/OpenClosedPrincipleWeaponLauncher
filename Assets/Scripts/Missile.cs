using UnityEngine;

public class Missile : MonoBehaviour, ILauncher
{
    [SerializeField] private Rigidbody missilePrefab;
    [SerializeField] private int fireForce = 300;
    [SerializeField] private int missileSelfDestructTimer = 5;

    public void Launch(Launcher launcher)
    {
        Transform target = FindObjectOfType<Transform>();
        var missile = Instantiate(missilePrefab);
        missile.AddForce(missile.transform.forward * fireForce);
    }
}
