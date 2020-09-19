
using UnityEngine;

public class Wand : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public ParticleSystem muzzleFlash;

    public Camera fpsCam;


    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {

            Shoot();

        }

    }

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hitPoint;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitPoint, range))
        {
            Debug.Log(hitPoint.transform.name);

            Target target = hitPoint.transform.GetComponent<Target>();

            if (target != null) {
                target.TakeDamage(damage);
            }

        }

    }
}
