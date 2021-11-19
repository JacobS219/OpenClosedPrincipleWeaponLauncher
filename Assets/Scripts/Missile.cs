using UnityEngine;

public class Missile : MonoBehaviour, ILauncher
{
    [SerializeField] private Rigidbody missilePrefab;
    [SerializeField] private int fireForce = 300;
    [SerializeField] private int missileSelfDestructTimer = 5;
    [SerializeField] private Transform weaponMountPoint;

    public void Launch(Launcher launcher)
    {
        Transform target = FindObjectOfType<Transform>();
        var missile = Instantiate(missilePrefab, weaponMountPoint.position, weaponMountPoint.rotation);
        missile.AddForce(missile.transform.forward * fireForce);
    }
}
