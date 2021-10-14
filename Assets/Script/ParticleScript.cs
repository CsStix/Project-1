using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour
{
    public GameObject collisionparticle;
    public GameObject triggerparticle;

    //Gets executed when something enters this trigger, or when this object enters a trigger
    private void OnTriggerEnter(Collider other)
    {
        if (triggerparticle != null)
        {
            //The triggerparticle will be spawned at the ocation of this object
            //with the same rotation as the object.
            Instantiate(triggerparticle, this.transform.position, this.transform.rotation);
        }

    }

    //Gets executed when something collides with this object
    private void OnCollisionEnter(Collision collision)
    {
        if (collisionparticle != null)
        {
            Instantiate(collisionparticle, collision.contacts[0].point, this.transform.rotation);
        }
    }
}
