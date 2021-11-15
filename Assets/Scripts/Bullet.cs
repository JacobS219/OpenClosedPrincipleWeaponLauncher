using UnityEngine;

public class Bullet : MonoBehaviour, ILauncher
{
    [SerializeField] private Rigidbody bulletPrefab;
    [SerializeField] private int fireForce = 300;

    public void Launch(Launcher launcher)
    {
        var bullet = Instantiate(bulletPrefab);
        bullet.AddForce(bullet.transform.forward * fireForce);
    }
}
