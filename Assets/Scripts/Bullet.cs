using UnityEngine;

public class Bullet : MonoBehaviour, ILauncher
{
    [SerializeField] private Rigidbody bulletPrefab;
    [SerializeField] private int fireForce = 300;
    [SerializeField] private Transform weaponMountPoint;

    public void Launch(Launcher launcher)
    {
        var bullet = Instantiate(bulletPrefab, weaponMountPoint.position, weaponMountPoint.rotation);
        bullet.AddForce(bullet.transform.forward * fireForce);
    }
}
