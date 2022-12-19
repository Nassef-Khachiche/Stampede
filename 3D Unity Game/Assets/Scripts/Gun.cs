using UnityEngine;
using UnityEngine.AI;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera camera;
    NavMeshAgent nav;

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot() 
    {
        
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
        
    }
}
