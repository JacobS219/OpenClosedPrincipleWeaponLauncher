using UnityEngine;

public class Launcher : MonoBehaviour
{
    private ILauncher launcher;

    [SerializeField] private float fireRefreshRate = 1f;
    [SerializeField] private string fireButtonString = "Fire1";
    private float nextFireTime;

    private void Awake()
    {
        launcher = GetComponent<ILauncher>();
    }

    private void Update()
    {
        if (Input.GetButtonDown(fireButtonString) && CanFire())
        {
            FireWeapon();
        }
    }

    private bool CanFire()
    {
        return Time.time > nextFireTime;
    }

    private void FireWeapon()
    {
        nextFireTime = Time.time + fireRefreshRate;
        launcher.Launch(this);
    }
}
