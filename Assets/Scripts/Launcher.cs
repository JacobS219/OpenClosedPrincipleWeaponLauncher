using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField] private float fireRefreshRate = 1f;
    [SerializeField] private string fireButtonString = "Fire1";

    private ILauncher _launcher;
    private float nextFireTime;

    private void Awake()
    {
        _launcher = GetComponent<ILauncher>();
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
        _launcher.Launch(this);
    }
}
