using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarryingObject : MonoBehaviour
{
    public GameObject holder, empty;
    public Rigidbody rb;
    public Collider coll;
    bool isHolding = false;
    
    public void Take()
    {
        transform.SetParent(holder.transform);
        transform.localPosition = new Vector3(0, 0, 0);
        transform.rotation = holder.transform.rotation;
        coll.enabled = false;
        Destroy(rb);
        isHolding = true;
    }

    public void Drop()
    {
        transform.SetParent(null);
        isHolding = false;
        coll.enabled = true;
        rb = gameObject.AddComponent<Rigidbody>();
    }
    public void Throw()
    {
        Drop();
        rb.AddRelativeForce(0, 0, 500); 
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && isHolding)
        {
            Drop();
        }
        if (Input.GetKeyDown(KeyCode.T) && isHolding)
        {
            Throw();
        }
    }
}
